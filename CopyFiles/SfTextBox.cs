using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CopyFiles.Properties;

namespace CopyFiles
{
    public partial class SfTextBox : UserControl
    {
        #region Поля и переменные

        public string TbPath
        {
            get { return _tbPath.Text; }
            set { _tbPath.Text = value; }
        }

        #endregion

        #region Конструктор

        public SfTextBox()
        {
            InitializeComponent();
            _tbPath.AllowDrop = true;
            
            _tbPath.DragEnter += (sender, args) => args.Effect = args.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
            
            _tbPath.DragDrop += delegate(object sender, DragEventArgs args)
                                    {
                                        var count = ((string[])args.Data.GetData(DataFormats.FileDrop)).Where(Directory.Exists).Count();
                                        if (count != 1)
                                            return;
                                        _tbPath.Text = ((string[])args.Data.GetData(DataFormats.FileDrop)).Where(Directory.Exists).First();
                                    };
        }

        #endregion

        #region События

        private void _btnSourceFolder_Click(object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.ShowNewFolderButton = true;
                folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
                folderBrowser.Description = Resources.FolderBrowserDescription;
                if (folderBrowser.ShowDialog() != DialogResult.OK)
                    return;
                _tbPath.Text = folderBrowser.SelectedPath;
            }
        }

        #endregion
    }
}