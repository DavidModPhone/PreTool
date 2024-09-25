namespace PreTool
{
    partial class PreToolMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreToolMain));
            this.ActivateGroup = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.activateBtn = new System.Windows.Forms.Button();
            this.ActivationLog = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.projBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AppProjLoc = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.IPKLabel = new System.Windows.Forms.Label();
            this.ipkfileloc = new System.Windows.Forms.TextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.IPKInstBtn = new System.Windows.Forms.Button();
            this.IPKLog = new System.Windows.Forms.TextBox();
            this.IPKFileDiag = new System.Windows.Forms.OpenFileDialog();
            this.ProgressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.ProgressBarTimer2 = new System.Windows.Forms.Timer(this.components);
            this.AppProjDiag = new System.Windows.Forms.FolderBrowserDialog();
            this.packipkBtn = new System.Windows.Forms.Button();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.ProgressBarTimer3 = new System.Windows.Forms.Timer(this.components);
            this.ActivateGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActivateGroup
            // 
            this.ActivateGroup.Controls.Add(this.progressBar1);
            this.ActivateGroup.Controls.Add(this.activateBtn);
            this.ActivateGroup.Controls.Add(this.ActivationLog);
            this.ActivateGroup.Location = new System.Drawing.Point(12, 12);
            this.ActivateGroup.Name = "ActivateGroup";
            this.ActivateGroup.Size = new System.Drawing.Size(425, 223);
            this.ActivateGroup.TabIndex = 0;
            this.ActivateGroup.TabStop = false;
            this.ActivateGroup.Text = "Activation";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(87, 189);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(332, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // activateBtn
            // 
            this.activateBtn.Location = new System.Drawing.Point(6, 189);
            this.activateBtn.Name = "activateBtn";
            this.activateBtn.Size = new System.Drawing.Size(75, 23);
            this.activateBtn.TabIndex = 2;
            this.activateBtn.Text = "Activate!";
            this.activateBtn.UseVisualStyleBackColor = true;
            this.activateBtn.Click += new System.EventHandler(this.activateBtn_Click);
            // 
            // ActivationLog
            // 
            this.ActivationLog.BackColor = System.Drawing.Color.Black;
            this.ActivationLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ActivationLog.ForeColor = System.Drawing.Color.White;
            this.ActivationLog.Location = new System.Drawing.Point(6, 19);
            this.ActivationLog.Multiline = true;
            this.ActivationLog.Name = "ActivationLog";
            this.ActivationLog.ReadOnly = true;
            this.ActivationLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ActivationLog.Size = new System.Drawing.Size(413, 164);
            this.ActivationLog.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar3);
            this.groupBox1.Controls.Add(this.packipkBtn);
            this.groupBox1.Controls.Add(this.projBrowse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AppProjLoc);
            this.groupBox1.Controls.Add(this.browseBtn);
            this.groupBox1.Controls.Add(this.IPKLabel);
            this.groupBox1.Controls.Add(this.ipkfileloc);
            this.groupBox1.Controls.Add(this.progressBar2);
            this.groupBox1.Controls.Add(this.IPKInstBtn);
            this.groupBox1.Controls.Add(this.IPKLog);
            this.groupBox1.Location = new System.Drawing.Point(12, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 320);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IPK";
            // 
            // projBrowse
            // 
            this.projBrowse.Location = new System.Drawing.Point(350, 225);
            this.projBrowse.Name = "projBrowse";
            this.projBrowse.Size = new System.Drawing.Size(75, 23);
            this.projBrowse.TabIndex = 9;
            this.projBrowse.Text = "Browse...";
            this.projBrowse.UseVisualStyleBackColor = true;
            this.projBrowse.Click += new System.EventHandler(this.projBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "App Project Folder:";
            // 
            // AppProjLoc
            // 
            this.AppProjLoc.Location = new System.Drawing.Point(109, 227);
            this.AppProjLoc.Name = "AppProjLoc";
            this.AppProjLoc.Size = new System.Drawing.Size(235, 20);
            this.AppProjLoc.TabIndex = 7;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(350, 189);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 6;
            this.browseBtn.Text = "Browse...";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // IPKLabel
            // 
            this.IPKLabel.AutoSize = true;
            this.IPKLabel.Location = new System.Drawing.Point(6, 196);
            this.IPKLabel.Name = "IPKLabel";
            this.IPKLabel.Size = new System.Drawing.Size(46, 13);
            this.IPKLabel.TabIndex = 5;
            this.IPKLabel.Text = "IPK File:";
            // 
            // ipkfileloc
            // 
            this.ipkfileloc.Location = new System.Drawing.Point(55, 193);
            this.ipkfileloc.Name = "ipkfileloc";
            this.ipkfileloc.Size = new System.Drawing.Size(289, 20);
            this.ipkfileloc.TabIndex = 2;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(87, 291);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(338, 23);
            this.progressBar2.TabIndex = 3;
            // 
            // IPKInstBtn
            // 
            this.IPKInstBtn.Location = new System.Drawing.Point(6, 291);
            this.IPKInstBtn.Name = "IPKInstBtn";
            this.IPKInstBtn.Size = new System.Drawing.Size(75, 23);
            this.IPKInstBtn.TabIndex = 4;
            this.IPKInstBtn.Text = "Install IPK";
            this.IPKInstBtn.UseVisualStyleBackColor = true;
            this.IPKInstBtn.Click += new System.EventHandler(this.IPKInstBtn_Click);
            // 
            // IPKLog
            // 
            this.IPKLog.BackColor = System.Drawing.Color.Black;
            this.IPKLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IPKLog.ForeColor = System.Drawing.Color.White;
            this.IPKLog.Location = new System.Drawing.Point(6, 19);
            this.IPKLog.Multiline = true;
            this.IPKLog.Name = "IPKLog";
            this.IPKLog.ReadOnly = true;
            this.IPKLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IPKLog.Size = new System.Drawing.Size(419, 164);
            this.IPKLog.TabIndex = 3;
            // 
            // IPKFileDiag
            // 
            this.IPKFileDiag.Filter = "IPK File|*.ipk";
            // 
            // ProgressBarTimer
            // 
            this.ProgressBarTimer.Tick += new System.EventHandler(this.ProgressBarTimer_Tick);
            // 
            // ProgressBarTimer2
            // 
            this.ProgressBarTimer2.Tick += new System.EventHandler(this.ProgressBarTimer2_Tick);
            // 
            // packipkBtn
            // 
            this.packipkBtn.Location = new System.Drawing.Point(6, 262);
            this.packipkBtn.Name = "packipkBtn";
            this.packipkBtn.Size = new System.Drawing.Size(75, 23);
            this.packipkBtn.TabIndex = 10;
            this.packipkBtn.Text = "Pack IPK";
            this.packipkBtn.UseVisualStyleBackColor = true;
            this.packipkBtn.Click += new System.EventHandler(this.packipkBtn_Click);
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(87, 262);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(338, 23);
            this.progressBar3.TabIndex = 11;
            // 
            // ProgressBarTimer3
            // 
            this.ProgressBarTimer3.Tick += new System.EventHandler(this.ProgressBarTimer3_Tick);
            // 
            // PreToolMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 573);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ActivateGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PreToolMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreTool";
            this.ActivateGroup.ResumeLayout(false);
            this.ActivateGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ActivateGroup;
        private System.Windows.Forms.Button activateBtn;
        private System.Windows.Forms.TextBox ActivationLog;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IPKLog;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Label IPKLabel;
        private System.Windows.Forms.TextBox ipkfileloc;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button IPKInstBtn;
        private System.Windows.Forms.OpenFileDialog IPKFileDiag;
        private System.Windows.Forms.Timer ProgressBarTimer;
        private System.Windows.Forms.Timer ProgressBarTimer2;
        private System.Windows.Forms.Button projBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AppProjLoc;
        private System.Windows.Forms.FolderBrowserDialog AppProjDiag;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Button packipkBtn;
        private System.Windows.Forms.Timer ProgressBarTimer3;
    }
}

