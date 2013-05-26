namespace DDJtoDDS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenDDJFolder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OpenDDSFolder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenDDJFolder
            // 
            this.OpenDDJFolder.Location = new System.Drawing.Point(6, 19);
            this.OpenDDJFolder.Name = "OpenDDJFolder";
            this.OpenDDJFolder.Size = new System.Drawing.Size(186, 23);
            this.OpenDDJFolder.TabIndex = 0;
            this.OpenDDJFolder.Text = "Convert To DDS (DirectDraw)";
            this.OpenDDJFolder.UseVisualStyleBackColor = true;
            this.OpenDDJFolder.Click += new System.EventHandler(this.OpenDDJFolder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OpenDDJFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DDJ to DDS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OpenDDSFolder);
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 56);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DDS to DDJ";
            // 
            // OpenDDSFolder
            // 
            this.OpenDDSFolder.Location = new System.Drawing.Point(6, 19);
            this.OpenDDSFolder.Name = "OpenDDSFolder";
            this.OpenDDSFolder.Size = new System.Drawing.Size(186, 23);
            this.OpenDDSFolder.TabIndex = 0;
            this.OpenDDSFolder.Text = "Convert To DDJ (Joymax)";
            this.OpenDDSFolder.UseVisualStyleBackColor = true;
            this.OpenDDSFolder.Click += new System.EventHandler(this.OpenDDSFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 138);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "DDJ to DDS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenDDJFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button OpenDDSFolder;
    }
}

