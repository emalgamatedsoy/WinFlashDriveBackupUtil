namespace BackupUtility
{
    partial class BackupUtilityMain
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
            this.pictureChkBox = new System.Windows.Forms.CheckBox();
            this.videoChkBox = new System.Windows.Forms.CheckBox();
            this.docChkBox = new System.Windows.Forms.CheckBox();
            this.fldtowriteEdit = new System.Windows.Forms.TextBox();
            this.fldtowriteBtn = new System.Windows.Forms.Button();
            this.DriveLetterComboBox = new System.Windows.Forms.ComboBox();
            this.driveLetterSelectLbl = new System.Windows.Forms.Label();
            this.openfldtowriteLbl = new System.Windows.Forms.Label();
            this.backupBtn = new System.Windows.Forms.Button();
            this.musicChkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // pictureChkBox
            // 
            this.pictureChkBox.AutoSize = true;
            this.pictureChkBox.Location = new System.Drawing.Point(7, 93);
            this.pictureChkBox.Name = "pictureChkBox";
            this.pictureChkBox.Size = new System.Drawing.Size(95, 17);
            this.pictureChkBox.TabIndex = 0;
            this.pictureChkBox.Text = "pictureChkBox";
            this.pictureChkBox.UseVisualStyleBackColor = true;
            this.pictureChkBox.CheckedChanged += new System.EventHandler(this.pictureChkBox_CheckedChanged);
            // 
            // videoChkBox
            // 
            this.videoChkBox.AutoSize = true;
            this.videoChkBox.Location = new System.Drawing.Point(7, 116);
            this.videoChkBox.Name = "videoChkBox";
            this.videoChkBox.Size = new System.Drawing.Size(89, 17);
            this.videoChkBox.TabIndex = 1;
            this.videoChkBox.Text = "videoChkBox";
            this.videoChkBox.UseVisualStyleBackColor = true;
            this.videoChkBox.CheckedChanged += new System.EventHandler(this.videoChkBox_CheckedChanged);
            // 
            // docChkBox
            // 
            this.docChkBox.AutoSize = true;
            this.docChkBox.Location = new System.Drawing.Point(7, 162);
            this.docChkBox.Name = "docChkBox";
            this.docChkBox.Size = new System.Drawing.Size(81, 17);
            this.docChkBox.TabIndex = 2;
            this.docChkBox.Text = "docChkBox";
            this.docChkBox.UseVisualStyleBackColor = true;
            this.docChkBox.CheckedChanged += new System.EventHandler(this.docChkBox_CheckedChanged);
            // 
            // fldtowriteEdit
            // 
            this.fldtowriteEdit.Location = new System.Drawing.Point(12, 38);
            this.fldtowriteEdit.Name = "fldtowriteEdit";
            this.fldtowriteEdit.Size = new System.Drawing.Size(259, 20);
            this.fldtowriteEdit.TabIndex = 3;
            this.fldtowriteEdit.Text = "fldtowriteEdit";
            // 
            // fldtowriteBtn
            // 
            this.fldtowriteBtn.Location = new System.Drawing.Point(101, 64);
            this.fldtowriteBtn.Name = "fldtowriteBtn";
            this.fldtowriteBtn.Size = new System.Drawing.Size(75, 23);
            this.fldtowriteBtn.TabIndex = 4;
            this.fldtowriteBtn.Text = "fldtowriteBtn";
            this.fldtowriteBtn.UseVisualStyleBackColor = true;
            this.fldtowriteBtn.Click += new System.EventHandler(this.fldtowriteBtn_Click);
            // 
            // DriveLetterComboBox
            // 
            this.DriveLetterComboBox.FormattingEnabled = true;
            this.DriveLetterComboBox.Location = new System.Drawing.Point(198, 196);
            this.DriveLetterComboBox.Name = "DriveLetterComboBox";
            this.DriveLetterComboBox.Size = new System.Drawing.Size(74, 21);
            this.DriveLetterComboBox.TabIndex = 5;
            this.DriveLetterComboBox.Enter += new System.EventHandler(this.DriveLetterComboBox_Enter);
            // 
            // driveLetterSelectLbl
            // 
            this.driveLetterSelectLbl.AutoSize = true;
            this.driveLetterSelectLbl.Location = new System.Drawing.Point(4, 204);
            this.driveLetterSelectLbl.Name = "driveLetterSelectLbl";
            this.driveLetterSelectLbl.Size = new System.Drawing.Size(101, 13);
            this.driveLetterSelectLbl.TabIndex = 6;
            this.driveLetterSelectLbl.Text = "driveLetterSelectLbl";
            // 
            // openfldtowriteLbl
            // 
            this.openfldtowriteLbl.AutoSize = true;
            this.openfldtowriteLbl.Location = new System.Drawing.Point(12, 9);
            this.openfldtowriteLbl.Name = "openfldtowriteLbl";
            this.openfldtowriteLbl.Size = new System.Drawing.Size(87, 13);
            this.openfldtowriteLbl.TabIndex = 7;
            this.openfldtowriteLbl.Text = "openfldtowriteLbl";
            // 
            // backupBtn
            // 
            this.backupBtn.Location = new System.Drawing.Point(12, 248);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(260, 23);
            this.backupBtn.TabIndex = 8;
            this.backupBtn.Text = "backupBtn";
            this.backupBtn.UseVisualStyleBackColor = true;
            this.backupBtn.Click += new System.EventHandler(this.backupBtn_Click);
            // 
            // musicChkBox
            // 
            this.musicChkBox.AutoSize = true;
            this.musicChkBox.Location = new System.Drawing.Point(7, 139);
            this.musicChkBox.Name = "musicChkBox";
            this.musicChkBox.Size = new System.Drawing.Size(90, 17);
            this.musicChkBox.TabIndex = 11;
            this.musicChkBox.Text = "musicChkBox";
            this.musicChkBox.UseVisualStyleBackColor = true;
            this.musicChkBox.CheckedChanged += new System.EventHandler(this.musicChkBox_CheckedChanged);
            // 
            // BackupUtilityMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 283);
            this.Controls.Add(this.musicChkBox);
            this.Controls.Add(this.backupBtn);
            this.Controls.Add(this.openfldtowriteLbl);
            this.Controls.Add(this.driveLetterSelectLbl);
            this.Controls.Add(this.DriveLetterComboBox);
            this.Controls.Add(this.fldtowriteBtn);
            this.Controls.Add(this.fldtowriteEdit);
            this.Controls.Add(this.docChkBox);
            this.Controls.Add(this.videoChkBox);
            this.Controls.Add(this.pictureChkBox);
            this.Name = "BackupUtilityMain";
            this.Text = "USB Backup Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox pictureChkBox;
        private System.Windows.Forms.CheckBox videoChkBox;
        private System.Windows.Forms.CheckBox docChkBox;
        private System.Windows.Forms.TextBox fldtowriteEdit;
        private System.Windows.Forms.Button fldtowriteBtn;
        private System.Windows.Forms.ComboBox DriveLetterComboBox;
        private System.Windows.Forms.Label driveLetterSelectLbl;
        private System.Windows.Forms.Label openfldtowriteLbl;
        private System.Windows.Forms.Button backupBtn;
        private System.Windows.Forms.CheckBox musicChkBox;
    }
}

