using System.IO;
using System.Windows.Forms;

namespace CopyFiles
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _fromSource.SetControlsImages = _imageList16;
            _fromSource.SetListBoxContextMenu = _contexMenuFolders;
            _fromSources.SetControlsImages = _imageList16;
            _fromSources.SetListBoxContextMenu = _contexMenuFolders;
            Directory.CreateDirectory(string.Format("{0}\\config", Application.StartupPath));
        }
    }
}