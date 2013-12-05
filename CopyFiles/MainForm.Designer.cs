namespace CopyFiles
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._tbControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._fromSource = new CopyFiles.FromSourceInFolders();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._fromSources = new CopyFiles.FromSourcesInFolder();
            this._imageList16 = new System.Windows.Forms.ImageList(this.components);
            this._contexMenuFolders = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._tsmiAddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiRemoveFolder = new System.Windows.Forms.ToolStripMenuItem();
            this._tbControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this._contexMenuFolders.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tbControl
            // 
            this._tbControl.Controls.Add(this.tabPage1);
            this._tbControl.Controls.Add(this.tabPage2);
            this._tbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tbControl.ImageList = this._imageList16;
            this._tbControl.Location = new System.Drawing.Point(0, 0);
            this._tbControl.Name = "_tbControl";
            this._tbControl.SelectedIndex = 0;
            this._tbControl.Size = new System.Drawing.Size(300, 405);
            this._tbControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._fromSource);
            this.tabPage1.ImageKey = "FromFolder";
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(292, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Из папки в папки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _fromSource
            // 
            this._fromSource.Location = new System.Drawing.Point(0, 0);
            this._fromSource.Name = "_fromSource";
            this._fromSource.Size = new System.Drawing.Size(292, 379);
            this._fromSource.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this._fromSources);
            this.tabPage2.ImageKey = "InFolder";
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(292, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Из папок в папку";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _fromSources
            // 
            this._fromSources.Location = new System.Drawing.Point(0, 0);
            this._fromSources.Name = "_fromSources";
            this._fromSources.Size = new System.Drawing.Size(292, 379);
            this._fromSources.TabIndex = 0;
            // 
            // _imageList16
            // 
            this._imageList16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imageList16.ImageStream")));
            this._imageList16.TransparentColor = System.Drawing.Color.White;
            this._imageList16.Images.SetKeyName(0, "AddFolder");
            this._imageList16.Images.SetKeyName(1, "RemoveFolder");
            this._imageList16.Images.SetKeyName(2, "Copy");
            this._imageList16.Images.SetKeyName(3, "SaveSettings");
            this._imageList16.Images.SetKeyName(4, "FromFolder");
            this._imageList16.Images.SetKeyName(5, "InFolder");
            // 
            // _contexMenuFolders
            // 
            this._contexMenuFolders.BackColor = System.Drawing.SystemColors.Control;
            this._contexMenuFolders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmiAddFolder,
            this._tsmiRemoveFolder});
            this._contexMenuFolders.Name = "_contexMenuFiles";
            this._contexMenuFolders.Size = new System.Drawing.Size(211, 48);
            // 
            // _tsmiAddFolder
            // 
            this._tsmiAddFolder.AutoToolTip = true;
            this._tsmiAddFolder.Image = ((System.Drawing.Image)(resources.GetObject("_tsmiAddFolder.Image")));
            this._tsmiAddFolder.ImageTransparentColor = System.Drawing.Color.White;
            this._tsmiAddFolder.Name = "_tsmiAddFolder";
            this._tsmiAddFolder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert)));
            this._tsmiAddFolder.Size = new System.Drawing.Size(210, 22);
            this._tsmiAddFolder.Text = "Добавить папку";
            this._tsmiAddFolder.ToolTipText = "Добавить папку в список назначения";
            // 
            // _tsmiRemoveFolder
            // 
            this._tsmiRemoveFolder.AutoToolTip = true;
            this._tsmiRemoveFolder.Image = ((System.Drawing.Image)(resources.GetObject("_tsmiRemoveFolder.Image")));
            this._tsmiRemoveFolder.ImageTransparentColor = System.Drawing.Color.White;
            this._tsmiRemoveFolder.Name = "_tsmiRemoveFolder";
            this._tsmiRemoveFolder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this._tsmiRemoveFolder.Size = new System.Drawing.Size(210, 22);
            this._tsmiRemoveFolder.Text = "Удалить папку";
            this._tsmiRemoveFolder.ToolTipText = "Убрать папку из списка назначения";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 405);
            this.Controls.Add(this._tbControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(316, 440);
            this.MinimumSize = new System.Drawing.Size(316, 440);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Копирование файлов";
            this._tbControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this._contexMenuFolders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _tbControl;
        private System.Windows.Forms.ImageList _imageList16;
        private System.Windows.Forms.ContextMenuStrip _contexMenuFolders;
        private System.Windows.Forms.ToolStripMenuItem _tsmiAddFolder;
        private System.Windows.Forms.ToolStripMenuItem _tsmiRemoveFolder;
        private System.Windows.Forms.TabPage tabPage1;
        private FromSourceInFolders _fromSource;
        private System.Windows.Forms.TabPage tabPage2;
        private FromSourcesInFolder _fromSources;

    }
}

