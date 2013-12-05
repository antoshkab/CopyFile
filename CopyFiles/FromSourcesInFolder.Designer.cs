namespace CopyFiles
{
    partial class FromSourcesInFolder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._bAddFolder = new System.Windows.Forms.Button();
            this._bDelFolder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._lbFolders = new System.Windows.Forms.ListBox();
            this._lbDestination = new System.Windows.Forms.Label();
            this._pgFilesCopy = new System.Windows.Forms.ProgressBar();
            this._bSaveSettings = new System.Windows.Forms.Button();
            this._btnCopy = new System.Windows.Forms.Button();
            this._dftb = new CopyFiles.SfTextBox();
            this._cbOverwriteAll = new System.Windows.Forms.CheckBox();
            this._cbOverwriteNew = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _bAddFolder
            // 
            this._bAddFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._bAddFolder.ImageIndex = 0;
            this._bAddFolder.Location = new System.Drawing.Point(3, 3);
            this._bAddFolder.Name = "_bAddFolder";
            this._bAddFolder.Size = new System.Drawing.Size(140, 23);
            this._bAddFolder.TabIndex = 8;
            this._bAddFolder.Text = "Добавить папки";
            this._bAddFolder.UseVisualStyleBackColor = true;
            // 
            // _bDelFolder
            // 
            this._bDelFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._bDelFolder.ImageIndex = 1;
            this._bDelFolder.Location = new System.Drawing.Point(149, 3);
            this._bDelFolder.Name = "_bDelFolder";
            this._bDelFolder.Size = new System.Drawing.Size(140, 23);
            this._bDelFolder.TabIndex = 9;
            this._bDelFolder.Text = "Удалить папки";
            this._bDelFolder.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._lbFolders);
            this.groupBox1.Location = new System.Drawing.Point(3, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 224);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список папок источников";
            // 
            // _lbFolders
            // 
            this._lbFolders.AllowDrop = true;
            this._lbFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbFolders.Location = new System.Drawing.Point(3, 16);
            this._lbFolders.Name = "_lbFolders";
            this._lbFolders.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this._lbFolders.Size = new System.Drawing.Size(280, 205);
            this._lbFolders.TabIndex = 0;
            // 
            // _lbDestination
            // 
            this._lbDestination.AutoSize = true;
            this._lbDestination.Location = new System.Drawing.Point(3, 282);
            this._lbDestination.Name = "_lbDestination";
            this._lbDestination.Size = new System.Drawing.Size(68, 13);
            this._lbDestination.TabIndex = 11;
            this._lbDestination.Text = "Назначение";
            // 
            // _pgFilesCopy
            // 
            this._pgFilesCopy.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._pgFilesCopy.Location = new System.Drawing.Point(3, 353);
            this._pgFilesCopy.MarqueeAnimationSpeed = 50;
            this._pgFilesCopy.Name = "_pgFilesCopy";
            this._pgFilesCopy.Size = new System.Drawing.Size(286, 23);
            this._pgFilesCopy.Step = 1;
            this._pgFilesCopy.TabIndex = 15;
            // 
            // _bSaveSettings
            // 
            this._bSaveSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._bSaveSettings.ImageKey = "save.png";
            this._bSaveSettings.Location = new System.Drawing.Point(149, 324);
            this._bSaveSettings.Name = "_bSaveSettings";
            this._bSaveSettings.Size = new System.Drawing.Size(140, 23);
            this._bSaveSettings.TabIndex = 14;
            this._bSaveSettings.Text = "Сохранить настройки";
            this._bSaveSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._bSaveSettings.UseVisualStyleBackColor = true;
            // 
            // _btnCopy
            // 
            this._btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnCopy.ImageIndex = 2;
            this._btnCopy.Location = new System.Drawing.Point(3, 324);
            this._btnCopy.Name = "_btnCopy";
            this._btnCopy.Size = new System.Drawing.Size(140, 23);
            this._btnCopy.TabIndex = 13;
            this._btnCopy.Text = "Копировать";
            this._btnCopy.UseVisualStyleBackColor = true;
            this._btnCopy.Click += new System.EventHandler(this._btnCopy_Click);
            // 
            // _dftb
            // 
            this._dftb.Location = new System.Drawing.Point(6, 298);
            this._dftb.MaximumSize = new System.Drawing.Size(1920, 20);
            this._dftb.MinimumSize = new System.Drawing.Size(64, 20);
            this._dftb.Name = "_dftb";
            this._dftb.Size = new System.Drawing.Size(283, 20);
            this._dftb.TabIndex = 12;
            this._dftb.TbPath = "";
            // 
            // _cbOverwriteAll
            // 
            this._cbOverwriteAll.AutoSize = true;
            this._cbOverwriteAll.Location = new System.Drawing.Point(3, 262);
            this._cbOverwriteAll.Name = "_cbOverwriteAll";
            this._cbOverwriteAll.Size = new System.Drawing.Size(141, 17);
            this._cbOverwriteAll.TabIndex = 16;
            this._cbOverwriteAll.Text = "Заменять одинаковые";
            this._cbOverwriteAll.UseVisualStyleBackColor = true;
            // 
            // _cbOverwriteNew
            // 
            this._cbOverwriteNew.AutoSize = true;
            this._cbOverwriteNew.Location = new System.Drawing.Point(150, 262);
            this._cbOverwriteNew.Name = "_cbOverwriteNew";
            this._cbOverwriteNew.Size = new System.Drawing.Size(136, 17);
            this._cbOverwriteNew.TabIndex = 17;
            this._cbOverwriteNew.Text = "Заменять если новее";
            this._cbOverwriteNew.UseVisualStyleBackColor = true;
            // 
            // FromSourcesInFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._cbOverwriteNew);
            this.Controls.Add(this._cbOverwriteAll);
            this.Controls.Add(this._bAddFolder);
            this.Controls.Add(this._bDelFolder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._lbDestination);
            this.Controls.Add(this._pgFilesCopy);
            this.Controls.Add(this._bSaveSettings);
            this.Controls.Add(this._btnCopy);
            this.Controls.Add(this._dftb);
            this.Name = "FromSourcesInFolder";
            this.Size = new System.Drawing.Size(292, 379);
            this.Load += new System.EventHandler(this.FromSourcesInFolder_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _bAddFolder;
        private System.Windows.Forms.Button _bDelFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox _lbFolders;
        private System.Windows.Forms.Label _lbDestination;
        private System.Windows.Forms.ProgressBar _pgFilesCopy;
        private System.Windows.Forms.Button _bSaveSettings;
        private System.Windows.Forms.Button _btnCopy;
        private SfTextBox _dftb;
        private System.Windows.Forms.CheckBox _cbOverwriteAll;
        private System.Windows.Forms.CheckBox _cbOverwriteNew;
    }
}
