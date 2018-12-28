namespace MusicManager
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
            this.btnRun = new System.Windows.Forms.Button();
            this.fbdRootPath = new System.Windows.Forms.FolderBrowserDialog();
            this.txtRootPath = new System.Windows.Forms.TextBox();
            this.lblRootpath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(425, 54);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(177, 63);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtRootPath
            // 
            this.txtRootPath.Location = new System.Drawing.Point(103, 12);
            this.txtRootPath.Name = "txtRootPath";
            this.txtRootPath.Size = new System.Drawing.Size(499, 22);
            this.txtRootPath.TabIndex = 1;
            this.txtRootPath.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtRootPath_MouseDoubleClick);
            // 
            // lblRootpath
            // 
            this.lblRootpath.AutoSize = true;
            this.lblRootpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRootpath.Location = new System.Drawing.Point(12, 15);
            this.lblRootpath.Name = "lblRootpath";
            this.lblRootpath.Size = new System.Drawing.Size(85, 17);
            this.lblRootpath.TabIndex = 3;
            this.lblRootpath.Text = "Root Path:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(612, 127);
            this.Controls.Add(this.lblRootpath);
            this.Controls.Add(this.txtRootPath);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.FolderBrowserDialog fbdRootPath;
        private System.Windows.Forms.TextBox txtRootPath;
        private System.Windows.Forms.Label lblRootpath;
    }
}

