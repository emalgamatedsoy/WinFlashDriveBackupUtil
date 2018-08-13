using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BackupUtility
{
    public partial class BackupUtilityMain : Form
    {
        ModelBackupUtil model = new ModelBackupUtil();
        int i = 0;
        /// <summary>
        /// Creation of form hierarchy:
        /// 
        /// 1.) Creates components
        /// 2.) Sets the form constraints
        /// 3.) Sets the initial constraints on widgets
        /// 4.) initializes labels
        /// </summary>
        public BackupUtilityMain()
        {
            InitializeComponent();
            SetFormConstraints();
            SetInitConstraints();
            InitLabels();
        }

        /// <summary>
        /// initiates all of the labels associated with
        /// the main form.
        /// </summary>
        public void InitLabels()
        {
            openfldtowriteLbl.Text = "Select a folder to write to";
            fldtowriteEdit.Text = "";
            fldtowriteBtn.Text = "Open";
            pictureChkBox.Text = "Pictures";
            videoChkBox.Text = "Videos";
            docChkBox.Text = "Documents";
            musicChkBox.Text = "Music";
            driveLetterSelectLbl.Text = "Select Drive to Backup";
            backupBtn.Text = "Backup";

        }

        /// <summary>
        /// Creates the combo box,
        /// selection is used for all drives that are removable.
        /// </summary>
        
        public void CreateComboBox()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            try
            {
                foreach (DriveInfo d in allDrives)
                {
                    if (d.DriveType.ToString().Equals("Removable"))
                        DriveLetterComboBox.Items.Add(d.Name.ToString());
                }
                DriveLetterComboBox.SelectedIndex = 0;
            }

            catch (ArgumentException)
            { MessageBox.Show("There are no removable drives connected."); }
        }

        /// <summary>
        /// set the form constraints
        /// </summary>
        public void SetFormConstraints()
        {
            MaximizeBox = false;
        }

        /// <summary>
        /// set the initial constraints.
        /// 
        /// clear textbox, and make text box only editable.
        /// set value of progress bar, including minima and maxima discreet constraints
        /// (0 - 100)
        /// </summary>
        public void SetInitConstraints()
        {
            fldtowriteEdit.ReadOnly = true;
        }

        /// <summary>
        /// on clicking open button,
        /// opens up file browser dialog, and allows user to 
        /// select folder to dump to.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fldtowriteBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                model.setwriteTo(fbd.SelectedPath.ToString());
                fldtowriteEdit.Text = model.getwriteTo();
            }

        }

        /// <summary>
        /// on entering the drive letter combo box, 
        /// it creates another instance of itself.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DriveLetterComboBox_Enter(object sender, EventArgs e)
        {
            CreateComboBox();
        }

        /// <summary>
        /// Tests include:
        /// if no folder selected
        /// if no drive letter selected
        /// calls if no checkbox is checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backupBtn_Click(object sender, EventArgs e)
        {
            if (fldtowriteEdit.Text.Equals(""))
            {
                MessageBox.Show("No folder selected, please select folder to backup.");
            }
            else if (DriveLetterComboBox.SelectedItem == null)
            {
                MessageBox.Show("No removable drive selected, please select removable drive.");
                throw new ArgumentOutOfRangeException();
            }
            
            else
            {
                model.setreadFrom(DriveLetterComboBox.SelectedItem.ToString());

                SetFilesToWriteStack(model.getreadFrom());
                CopyFilesToWrite(model.getwriteTo(), model.getFiles());
                OpenNewModal(new BackupFilesOutput(model.getFiles()));
                
                //reset complete model.
                model = new ModelBackupUtil();
            }
        }


        

        /// <summary>
        /// Post-order traversal file operations.
        /// Iterates through files and recursively
        /// calls itself through directories.
        /// unauthorized access exception
        /// IOException
        /// 
        /// uses a post-order traversal through a stack
        /// </summary>
        /// <param name="path"></param>
        private void SetFilesToWriteStack(String root)
        {
            Stack<String> dirs = new Stack<String>();
            dirs.Push(root);

            while (dirs.Count > 0)
            {
                String currentDir = dirs.Pop();
                try
                {
                    String[] subDirs = Directory.GetDirectories(currentDir);
                    String[] files = Directory.GetFiles(currentDir);
                    foreach (String f in files)
                    {
                        if (model.getPicture())
                            if (model.isPictureType(f))
                                model.AddFile(f);

                        if (model.getVideo())
                            if (model.isVideoType(f))
                                model.AddFile(f);

                        if (model.getDocument())
                            if (model.isDocumentType(f))
                                model.AddFile(f);

                        if (model.getMusic())
                            if (model.isMusicType(f))
                                model.AddFile(f);
                    }
                    foreach (String sub in subDirs)
                        dirs.Push(sub);

                }
                catch (UnauthorizedAccessException) { }
                catch (IOException) { }
            }
        }

        /// <summary>
        /// will allow new modal to open from alternate form.
        /// general form context
        /// </summary>
        /// <param name="b"></param>
        private void OpenNewModal(Form b)
        {
            try
            {
                b.ShowDialog();
                b.Close();
            }
            
            catch (InvalidOperationException) { }
            
        }


        /// <summary>
        /// places all files in hashmap to 
        /// selected positions.
        /// </summary>
        /// <param name="to"></param>
        /// <param name="files"></param>
        /// <param name="from"></param>
        private void CopyFilesToWrite(String to, HashSet<String> files)
        {
            try
            {
                int progress, count = 0;
                foreach (String s in files)
                {
                    progress = (count + (files.Count / 100));
                    //overwrite files if both files of the same name exist.
                    File.Copy(s,(to + "\\" + Path.GetFileName(s)), true);
                }
            }
            catch (IOException) { }
        }

        /// <summary>
        /// get the picture checkbox status, and write it into model.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureChkBox_CheckedChanged(object sender, EventArgs e)
        {
            model.setPicture(pictureChkBox.Checked);
        }

        /// <summary>
        /// get the video checkbox status, and write it into model.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void videoChkBox_CheckedChanged(object sender, EventArgs e)
        {
            model.setVideo(videoChkBox.Checked);
        }

        /// <summary>
        /// get music checkbox status, and write it into model.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void musicChkBox_CheckedChanged(object sender, EventArgs e)
        {
            model.setMusic(musicChkBox.Checked);
        }

        /// <summary>
        /// get document checkbox status, and write it into model.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void docChkBox_CheckedChanged(object sender, EventArgs e)
        {
            model.setDocument(docChkBox.Checked);
        }
    }

}
