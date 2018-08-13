using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupUtility
{
    public partial class BackupFilesOutput : Form
    {
        public HashSet<String> files;
        public BackupFilesOutput(HashSet<String> files)
        {
            this.files = files;
            InitializeComponent();
            OutputFilesVerbose();
        }

        public void OutputFilesVerbose()
        {
            verboseFileOutputTB.Text = "Copied " + files.Count + " files: \n\n";
            foreach (string file in files)
            {
                verboseFileOutputTB.Text += file + "\n";
            }
        }
        
    }
}
