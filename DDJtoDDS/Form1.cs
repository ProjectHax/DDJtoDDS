using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace DDJtoDDS
{
    public partial class Form1 : Form
    {
        static String application_path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\";

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenDDJFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            DialogResult result = dlg.ShowDialog();

            if (dlg.SelectedPath.Length > 0)
            {
                String[] files = Directory.GetFiles(dlg.SelectedPath, "*.ddj", SearchOption.TopDirectoryOnly);
                if (files.Length > 0)
                {
                    MessageBox.Show("The conversion process may take several minutes depending on how many files there are. Afterwards the converted directory will pop up.", "DDJ to DDS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    String converted_to_dds = application_path + "\\converted_to_dds\\";
                    Directory.CreateDirectory(converted_to_dds);

                    for (int x = 0; x < files.Length; ++x)
                    {
                        String dds_path = converted_to_dds + Path.GetFileNameWithoutExtension(files[x]) + ".dds";

                        byte[] data = File.ReadAllBytes(files[x]);
                        using (FileStream file = new FileStream(dds_path, FileMode.OpenOrCreate))
                        {
                            file.Write(data, 20, data.Length - 20);
                            file.Close();
                        }
                    }

                    Process.Start(converted_to_dds);
                }
                else
                {
                    MessageBox.Show("No DDJ's could be found in the specified directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OpenDDSFolder_Click(object sender, EventArgs e)
        {
            // JMXVDDJ 1000........
            byte[] ddj_header = { 0x4A, 0x4D, 0x58, 0x56, 0x44, 0x44, 0x4A, 0x20, 0x31, 0x30, 0x30, 0x30, 0x88, 0x80, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00 };

            FolderBrowserDialog dlg = new FolderBrowserDialog();
            DialogResult result = dlg.ShowDialog();

            if (dlg.SelectedPath.Length > 0)
            {
                String[] files = Directory.GetFiles(dlg.SelectedPath, "*.dds", SearchOption.TopDirectoryOnly);
                if (files.Length > 0)
                {
                    MessageBox.Show("The conversion process may take several minutes depending on how many files there are. Afterwards the converted directory will pop up.", "DDJ to DDS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    String converted_to_ddj = application_path + "\\converted_to_ddj\\";
                    Directory.CreateDirectory(converted_to_ddj);

                    for (int x = 0; x < files.Length; ++x)
                    {
                        String ddj_path = converted_to_ddj + Path.GetFileNameWithoutExtension(files[x]) + ".ddj";

                        byte[] data = File.ReadAllBytes(files[x]);
                        using (FileStream file = new FileStream(ddj_path, FileMode.OpenOrCreate))
                        {
                            file.Write(ddj_header, 0, 20);
                            file.Write(data, 0, data.Length);
                            file.Close();
                        }
                    }

                    Process.Start(converted_to_ddj);
                }
                else
                {
                    MessageBox.Show("No DDS's could be found in the specified directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
