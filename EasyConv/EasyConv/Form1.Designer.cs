namespace EasyConv
{
    partial class EasyConv
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
            this.settingsGbx = new System.Windows.Forms.GroupBox();
            this.resetFileName = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.convertBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.browseBtn = new System.Windows.Forms.Button();
            this.dirTxt = new System.Windows.Forms.TextBox();
            this.logGbx = new System.Windows.Forms.GroupBox();
            this.log = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progress = new System.Windows.Forms.Label();
            this.settingsGbx.SuspendLayout();
            this.logGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsGbx
            // 
            this.settingsGbx.Controls.Add(this.resetFileName);
            this.settingsGbx.Controls.Add(this.label3);
            this.settingsGbx.Controls.Add(this.label2);
            this.settingsGbx.Controls.Add(this.fileName);
            this.settingsGbx.Controls.Add(this.convertBtn);
            this.settingsGbx.Controls.Add(this.label1);
            this.settingsGbx.Controls.Add(this.browseBtn);
            this.settingsGbx.Controls.Add(this.dirTxt);
            this.settingsGbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsGbx.Location = new System.Drawing.Point(0, 0);
            this.settingsGbx.Name = "settingsGbx";
            this.settingsGbx.Size = new System.Drawing.Size(760, 155);
            this.settingsGbx.TabIndex = 1;
            this.settingsGbx.TabStop = false;
            this.settingsGbx.Text = "Settings";
            // 
            // resetFileName
            // 
            this.resetFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetFileName.Location = new System.Drawing.Point(634, 69);
            this.resetFileName.Name = "resetFileName";
            this.resetFileName.Size = new System.Drawing.Size(120, 36);
            this.resetFileName.TabIndex = 7;
            this.resetFileName.Text = "Reset";
            this.resetFileName.UseVisualStyleBackColor = true;
            this.resetFileName.Click += new System.EventHandler(this.resetFileName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(8, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(614, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "NOTE: If you are using MAMAtv then you should leave the file name as default (cha" +
    "nnels.mama)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "New File Name";
            // 
            // fileName
            // 
            this.fileName.BackColor = System.Drawing.Color.White;
            this.fileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName.Location = new System.Drawing.Point(198, 69);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(424, 36);
            this.fileName.TabIndex = 4;
            this.fileName.Text = "channels.mama";
            // 
            // convertBtn
            // 
            this.convertBtn.Enabled = false;
            this.convertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertBtn.Location = new System.Drawing.Point(634, 113);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(120, 36);
            this.convertBtn.TabIndex = 3;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "File";
            // 
            // browseBtn
            // 
            this.browseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBtn.Location = new System.Drawing.Point(634, 18);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(120, 36);
            this.browseBtn.TabIndex = 1;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // dirTxt
            // 
            this.dirTxt.BackColor = System.Drawing.Color.White;
            this.dirTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirTxt.Location = new System.Drawing.Point(66, 18);
            this.dirTxt.Name = "dirTxt";
            this.dirTxt.ReadOnly = true;
            this.dirTxt.Size = new System.Drawing.Size(556, 36);
            this.dirTxt.TabIndex = 0;
            // 
            // logGbx
            // 
            this.logGbx.Controls.Add(this.log);
            this.logGbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.logGbx.Location = new System.Drawing.Point(0, 155);
            this.logGbx.Name = "logGbx";
            this.logGbx.Size = new System.Drawing.Size(760, 506);
            this.logGbx.TabIndex = 2;
            this.logGbx.TabStop = false;
            this.logGbx.Text = "Log";
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.White;
            this.log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log.Location = new System.Drawing.Point(3, 18);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(754, 485);
            this.log.TabIndex = 1;
            this.log.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 667);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(743, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 2;
            // 
            // progress
            // 
            this.progress.AutoSize = true;
            this.progress.Location = new System.Drawing.Point(3, 693);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(0, 17);
            this.progress.TabIndex = 3;
            // 
            // EasyConv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 714);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.logGbx);
            this.Controls.Add(this.settingsGbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EasyConv";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyConv";
            this.settingsGbx.ResumeLayout(false);
            this.settingsGbx.PerformLayout();
            this.logGbx.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox settingsGbx;
        private System.Windows.Forms.GroupBox logGbx;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox dirTxt;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button resetFileName;
    }
}

