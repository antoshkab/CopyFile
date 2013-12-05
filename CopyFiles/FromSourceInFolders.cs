using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using CopyFiles.Properties;

// ReSharper disable PossibleNullReferenceException

namespace CopyFiles
{
    public partial class FromSourceInFolders : UserControl
    {
        #region Поля и переменные

        public ContextMenuStrip SetListBoxContextMenu
        {
            set { _lbFolders.ContextMenuStrip = value; }
        }

        public ImageList SetControlsImages
        {
            set
            {
                _bAddFolder.Image = value.Images["AddFolder"];
                _bDelFolder.Image = value.Images["RemoveFolder"];
                _btnCopy.Image = value.Images["Copy"];
                _bSaveSettings.Image = value.Images["SaveSettings"];
            }
        }

        #endregion

        #region Контруктор

        public FromSourceInFolders()
        {
            InitializeComponent();
            _lbFolders.AllowDrop = true;
        }

        #endregion

        #region Методы

        private void RemoveFolderInFolderList(object sender, EventArgs e)
        {
            if (_lbFolders.SelectedItems.Count == 0)
                return;
            var items = _lbFolders.SelectedItems.Cast<object>().ToArray();
            foreach (var item in items)
                _lbFolders.Items.Remove(item);
        }


        private void AddFolderInFolderList(object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.RootFolder = Environment.SpecialFolder.MyDocuments;
                folderBrowser.ShowNewFolderButton = false;
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    if (_lbFolders.Items.Contains(folderBrowser.SelectedPath))
                    {
                        if (MessageBox.Show(Resources.DublicateFolder, Resources.SfTextBoxNoFilesInFolderCaption, MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Information) == DialogResult.No)
                            return;
                        AddFolderInFolderList(sender, e);
                        return;
                    }
                    _lbFolders.Items.Add(folderBrowser.SelectedPath);
                }
                else
                    return;
            }
            if (MessageBox.Show(Resources.MessageBoxNextFolderText, Resources.SfTextBoxNoFilesInFolderCaption, MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.No)
                return;
            AddFolderInFolderList(sender, e);
        }


        private void LoadSettings()
        {
            try
            {
                var config = XDocument.Load(string.Format("{0}\\config\\FromSource.xml", Application.StartupPath));
                foreach (var item in config.Element("CopyFile").Element("FolderList").Elements("Path"))
                    _lbFolders.Items.Add(item.Value);
                _sftb.TbPath = config.Element("CopyFile").Element("SourcePath").Element("Path").Value;
            }
                    // ReSharper disable EmptyGeneralCatchClause
            catch
                    // ReSharper restore EmptyGeneralCatchClause
            {}
        }


        private void CopyFile()
        {
            var files = new DirectoryInfo(_sftb.TbPath).GetFiles();
            var destPaths = _lbFolders.Items.Cast<string>().ToArray();
            _pgFilesCopy.Value = 0;
            _pgFilesCopy.Minimum = 0;
            _pgFilesCopy.Maximum = files.Length * destPaths.Length;
            int nowIteration = 0;
            using (var bgWorker = new BackgroundWorker{WorkerReportsProgress = true, WorkerSupportsCancellation = true})
            {
                bgWorker.DoWork += delegate(object sender, DoWorkEventArgs e)
                                       {
                                           var worker = sender as BackgroundWorker;
                                           Parallel.ForEach(destPaths, destPath =>
                                                                           {
                                                                               foreach (var file in files)
                                                                               {
                                                                                   DoCopy(Path.Combine(_sftb.TbPath, file.Name),
                                                                                          Path.Combine(destPath, file.Name));
                                                                                   nowIteration++;
                                                                                   worker.ReportProgress(nowIteration);
                                                                               }
                                                                           });
                                       };
                bgWorker.ProgressChanged += (sender, args) => _pgFilesCopy.Value = args.ProgressPercentage;

                bgWorker.RunWorkerCompleted +=
                        (sender, args) =>
                        MessageBox.Show(Resources.CopyCompliteText, Resources.CopyCompliteCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgWorker.RunWorkerAsync();
            }
        }


        private void DoCopy(string sourceFile, string destFile)
        {
            try
            {
                if (File.Exists(destFile))
                {
                    if (_cbOverwriteAll.Checked)
                    {
                        File.Copy(sourceFile, destFile, true);
                        return;
                    }
                    if (_cbOverwriteNew.Checked)
                        if (CheckFile(sourceFile, destFile))
                        {
                            File.Copy(sourceFile, destFile, true);
                            return;
                        }
                    return;
                }
                File.Copy(sourceFile, destFile);
            }
            catch
            {}
        }


        private bool CheckFile(string sourceFile, string destFile)
        {
            var sfile = new FileInfo(sourceFile);
            var dFile = new FileInfo(destFile);
            return (sfile.LastWriteTime > dFile.LastWriteTime) || (sfile.CreationTime > dFile.CreationTime);
        }

        #endregion

        #region События

        private void FromSourceInFolders_Load(object sender, EventArgs e)
        {
            #region Привязка действий

            _bAddFolder.Click += AddFolderInFolderList;
            _bDelFolder.Click += RemoveFolderInFolderList;

            _lbFolders.ContextMenuStrip.Items[0].Click += AddFolderInFolderList;
            _lbFolders.ContextMenuStrip.Items[1].Click += RemoveFolderInFolderList;
            _lbFolders.DragEnter +=
                    (s, args) => args.Effect = args.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
            _lbFolders.DragDrop += _lbFolders_DragDrop;

            _bSaveSettings.Click += _bSaveSettings_Click;

            #endregion

            #region Загрузка настроек если они есть

            if (!File.Exists(string.Format("{0}\\config\\FromSource.xml", Application.StartupPath)))
                return;
            LoadSettings();

            #endregion
        }


        private void _bSaveSettings_Click(object sender, EventArgs e)
        {
            var comment = new XComment("Файл настроек для копирования из папки в папки");
            var folderList = new XElement("FolderList");
            foreach (var item in _lbFolders.Items)
                folderList.Add(new XElement("Path", item));
            var sourcePath = new XElement("SourcePath");
            sourcePath.Add(new XElement("Path", _sftb.TbPath));
            var root = new XElement("CopyFile", folderList, sourcePath);
            var config = new XDocument();
            config.Add(comment, root);
            config.Save(string.Format("{0}\\config\\FromSource.xml", Application.StartupPath));
        }


        private void _lbFolders_DragDrop(object sender, DragEventArgs e)
        {
            foreach (var folderPath in ((string[])e.Data.GetData(DataFormats.FileDrop)).Where(Directory.Exists))
                _lbFolders.Items.Add(folderPath);
        }


        private void _btnCopy_Click(object sender, EventArgs e)
        {
            CopyFile();
        }

        #endregion
    }
}

// ReSharper restore PossibleNullReferenceException