namespace CopyFiles
{
    partial class SfTextBox
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
            this.components = new System.ComponentModel.Container();
            this._tbPath = new System.Windows.Forms.TextBox();
            this._btnSourceFolder = new System.Windows.Forms.Button();
            this._ttControl = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // _tbPath
            // 
            this._tbPath.BackColor = System.Drawing.SystemColors.Window;
            this._tbPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tbPath.Location = new System.Drawing.Point(0, 0);
            this._tbPath.Name = "_tbPath";
            this._tbPath.ReadOnly = true;
            this._tbPath.Size = new System.Drawing.Size(64, 20);
            this._tbPath.TabIndex = 0;
            this._ttControl.SetToolTip(this._tbPath, "Перетащите или нажмите <...> для добавления папки");
            // 
            // _btnSourceFolder
            // 
            this._btnSourceFolder.Dock = System.Windows.Forms.DockStyle.Right;
            this._btnSourceFolder.Location = new System.Drawing.Point(40, 0);
            this._btnSourceFolder.MaximumSize = new System.Drawing.Size(24, 19);
            this._btnSourceFolder.MinimumSize = new System.Drawing.Size(24, 19);
            this._btnSourceFolder.Name = "_btnSourceFolder";
            this._btnSourceFolder.Size = new System.Drawing.Size(24, 19);
            this._btnSourceFolder.TabIndex = 1;
            this._btnSourceFolder.Text = "...";
            this._ttControl.SetToolTip(this._btnSourceFolder, "Выбрать папку");
            this._btnSourceFolder.UseVisualStyleBackColor = true;
            this._btnSourceFolder.Click += new System.EventHandler(this._btnSourceFolder_Click);
            // 
            // _ttControl
            // 
            this._ttControl.AutomaticDelay = 200;
            this._ttControl.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this._ttControl.ToolTipTitle = "Подсказка";
            // 
            // SfTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._btnSourceFolder);
            this.Controls.Add(this._tbPath);
            this.MaximumSize = new System.Drawing.Size(1920, 20);
            this.MinimumSize = new System.Drawing.Size(64, 20);
            this.Name = "SfTextBox";
            this.Size = new System.Drawing.Size(64, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tbPath;
        private System.Windows.Forms.Button _btnSourceFolder;
        private System.Windows.Forms.ToolTip _ttControl;
    }
}
