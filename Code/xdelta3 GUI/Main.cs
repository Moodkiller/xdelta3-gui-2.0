using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace xdelta3_GUI
{
    public partial class Main : Form
    {
        private ListBox openFileDialogueCaller;
        private List<string> oldFiles, oldFileNames, newFiles, newFileNames;

        public Main()
        {
            this.InitializeComponent();
            this.oldFiles = new List<string>();
            this.oldFileNames = new List<string>();
            this.newFiles = new List<string>();
            this.newFileNames = new List<string>();
                                 
        }

        #region Button_Click_Events

     

        private void create_Click(object sender, EventArgs e)
        {
            string dest = this.destinationTextBox.Text;
            string subDir = this.patchSubDirTextBox.Text;
            string xdeltaargs = this.xdeltaargs.Text;
            string zipName = this.zipNameTextBox.Text;
            string patchExt = this.patchExtTextBox.Text.Trim();
            string xdeltaLinux = "./xdelta3";
            string xdeltaMac = "./xdelta3_mac";
            //xdelta3 source wildcard
            //Limitation:
            //the file should be like "xdelta*.exe"
            //the file name should NOT contain the word "GUI" (caps only)
            //it will automatically select the first file to meet the above conditions
            string xdeltaFileName = "";
            string[] currentDirFiles = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.exe");
            foreach(string temp in currentDirFiles) {
                string tempFileName = Path.GetFileName(temp);
                if(tempFileName.StartsWith("xdelta") && !tempFileName.Contains("GUI")) {
                    xdeltaFileName = tempFileName;
                    break;
                }
            }

            if(string.IsNullOrEmpty(xdeltaFileName)) {
                MessageBox.Show("Couldn't find the xdelta application. Please make sure the file is present in the current folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            if (this.oldFiles.Count != this.newFiles.Count)
            {
                MessageBox.Show("Number of files don't match. Please ensure there are the same number of files on both sides.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.oldFiles.Count == 0)
            {
                MessageBox.Show("No files to patch!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.destinationTextBox.Text == "")
            {
                MessageBox.Show("Please enter a destination.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.xdeltaargs.Text == "")
            { 
                MessageBox.Show("Please enter xdelta compression arguments.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Path.IsPathRooted(dest) || dest.IndexOfAny(Path.GetInvalidPathChars()) != -1)
            {
                MessageBox.Show("Invalid destination path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (subDir.IndexOfAny(Path.GetInvalidFileNameChars()) != -1)
            {
                MessageBox.Show("Invalid subdirectory name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (zipName.IndexOfAny(Path.GetInvalidFileNameChars()) != -1)
            {
                MessageBox.Show("Invalid .zip file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(string.IsNullOrEmpty(patchExt)) {
                MessageBox.Show("Please enter a patch file extension.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                //Should cover all invalid characters for a file extension, except spaces and dot(.)
                foreach(char ch in Path.GetInvalidFileNameChars()) {
                    if(patchExt.Contains(ch.ToString())) {
                        MessageBox.Show("The patch file extension is invalid. Please check it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                //Need to check for spaces(optional) and dot(.) separately
                if(patchExt.Contains(" ") || patchExt.Contains(".")) {
                    MessageBox.Show("The patch file extension is invalid. Please check it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            dest = (dest.EndsWith("\\") || dest.EndsWith("/")) ? dest : dest + "\\";

            //if (subDir != "")
            //    subDir += "\\";

            string tempDir = "";
            if (this.zipCheckBox.Checked)
            {
                while(true) {
                    char[] chars = new char[17];
                    Random random = new Random();
                    for(int i = 0; i < 16; i++) {
                        int c = random.Next(48, 64);
                        if(c > 57)
                            c += 39;
                        chars[i] = (char)c;
                    }
                    chars[16] = '\\';
                    tempDir = new string(chars);
                    if(!Directory.Exists(dest + tempDir))
                        break;
                }
            }

            if (!Directory.Exists(dest + tempDir + subDir))
                Directory.CreateDirectory(dest + tempDir + subDir);



            //Patch creater//
                //Readme.txt creation//
            StreamWriter readmeWriter = new StreamWriter(dest + tempDir + "1.Readme.txt");
            readmeWriter.WriteLine("Windows:");
            readmeWriter.WriteLine("1. Copy your original files into this folder. DO NOT RENAME!!"); 
            readmeWriter.WriteLine("2. Double click the 3.Apply Patch-Windows.bat file, a CMD window will open and will start patching automatically.");
            readmeWriter.WriteLine("3. Once patching is complete you will find your new files in the main folder and the originals in a folder called 'old'.");
            readmeWriter.WriteLine("4. Enjoy.");
            readmeWriter.WriteLine("");
            readmeWriter.WriteLine("Linux:");
            readmeWriter.WriteLine("1. Copy your original files into this folder. DO NOT RENAME!!");
            readmeWriter.WriteLine("2. In terminal, type: sh " + '"' + "3.Apply Patch-Linux.sh" + '"' + ". Patching should start automatically.");
            readmeWriter.WriteLine("3. Alternatively, if you're using a GUI, double click 3.Apply Patch-Linux.sh and a terminal window should appear.");
            readmeWriter.WriteLine("4. Once patching is complete, you will find your new files in the main folder and the originals in a folder called 'old'.");
            readmeWriter.WriteLine("5. Enjoy.");
            readmeWriter.WriteLine("");
            readmeWriter.WriteLine("Mac:");
            readmeWriter.WriteLine("1. Copy your original files into this folder. DO NOT RENAME!!");
            readmeWriter.WriteLine("2. In terminal, type: " + '"' + "3.Apply Patch-Mac.command" + '"' + ". Patching should start automatically.");
            readmeWriter.WriteLine("3. Alternatively, if you're using a GUI, double click 3.Apply Patch-Mac.command and a terminal window should appear.");
            readmeWriter.WriteLine("4. Once patching is complete, you will find your new files in the main folder and the originals in a folder called 'old'.");
            readmeWriter.WriteLine("5. Enjoy.");
            readmeWriter.Close();

                //Changelog.txt creation//
            StreamWriter changelogWriter = new StreamWriter(dest + tempDir + "2.Changelog.txt");
            changelogWriter.Close();

            //Batch creation - Windows//
            StreamWriter patchWriterWindows = new StreamWriter(dest + tempDir + "3.Apply Patch-Windows.bat");
            patchWriterWindows.WriteLine("@echo off");
            patchWriterWindows.WriteLine("mkdir old");
            // Batch creation - Linux //
            StreamWriter patchWriterLinux = new StreamWriter(dest + tempDir + "3.Apply Patch-Linux.sh");
            patchWriterLinux.NewLine = "\n";
            patchWriterLinux.WriteLine("#!/bin/sh");
            patchWriterLinux.WriteLine("cd \"$(cd \"$(dirname \"$0\")\" && pwd)\"");
            patchWriterLinux.WriteLine("mkdir old");
            patchWriterLinux.WriteLine("chmod +x xdelta3");
            // Batch creation - Mac //
            StreamWriter patchWriterMac = new StreamWriter(dest + tempDir + "3.Apply Patch-Mac.command");
            patchWriterMac.NewLine = "\n";
            patchWriterMac.WriteLine("#!/bin/sh");
            patchWriterMac.WriteLine("cd \"$(cd \"$(dirname \"$0\")\" && pwd)\"");
            patchWriterMac.WriteLine("mkdir ./old");
            patchWriterMac.WriteLine("chmod +x ./xdelta3_mac");
            //
            StreamWriter tempCmdWriter = new StreamWriter(dest + tempDir + "doNotDelete-Windows.bat");
            tempCmdWriter.WriteLine("set path = \"" + Directory.GetCurrentDirectory() + "\"");
            for (int i = 0; i < this.oldFiles.Count; i++)
            {
                patchWriterWindows.WriteLine(".\\" + xdeltaFileName + " -v -d -s \"{0}\" " + "\".\\" + subDir + "\\" + "{0}." + patchExt + "\" \"{2}\"", this.oldFileNames[i], subDir + "\\" + (i + 1).ToString(), this.newFileNames[i]);
                patchWriterWindows.WriteLine("move \"{0}\" old", this.oldFileNames[i]);
                // Batch creation - Linux //
                patchWriterLinux.WriteLine("./xdelta3" + " -v -d -s \"{0}\" " + '"' + subDir + '/' + "{0}." + patchExt + "\" \"{2}\"", this.oldFileNames[i], subDir + (i + 1).ToString(), this.newFileNames[i]);
                patchWriterLinux.WriteLine("mv \"{0}\" old", this.oldFileNames[i]);
                // Batch creation - Mac //
                patchWriterMac.WriteLine("./xdelta3_mac" + " -v -d -s \"{0}\" " + '"' + subDir + '/' + "{0}." + patchExt + "\" \"{2}\"", this.oldFileNames[i], subDir + (i + 1).ToString(), this.newFileNames[i]);
                patchWriterMac.WriteLine("mv \"{0}\" old", this.oldFileNames[i]);
                //
                if (!batchOnlyCheckBox.Checked)
                {
                    tempCmdWriter.WriteLine(xdeltaFileName + " " + xdeltaargs + " " + "\"" + this.oldFiles[i] + "\" \"" + this.newFiles[i] + "\" \"" + dest + tempDir + subDir + "\\" + this.oldFileNames[i] + "." + patchExt + "\"");
                }

            }
            patchWriterWindows.WriteLine("echo Completed!");
            patchWriterWindows.WriteLine("@pause");
            patchWriterLinux.Close();
            patchWriterMac.Close();

            // Temp .bat creation for single CMD window - WINDOWS //
            tempCmdWriter.Close();
            Process cmdWindows = new Process();
            cmdWindows.StartInfo.FileName = dest + tempDir + "doNotDelete-Windows.bat";
            cmdWindows.Start();
            cmdWindows.WaitForExit();
            File.Delete(dest + tempDir + "doNotDelete-Windows.bat");
            patchWriterWindows.Close();
            MessageBox.Show("Patch(s) created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (this.batchOnlyCheckBox.Checked)
            {
                StreamWriter makePatchWriter = new StreamWriter(dest + "Make Patch.bat");
                for (int i = 0; i < this.oldFiles.Count; i++)
                    makePatchWriter.WriteLine(".\\" + subDir + "\\" + xdeltaFileName + " " + xdeltaargs + " " + "\"{0}\" \"{1}\" \"{0}." + patchExt + "\"", this.oldFiles[i], this.newFiles[i], dest + subDir + "\\" + (i + 1).ToString());
                File.Copy(xdeltaFileName, dest + tempDir + subDir + "\\" + xdeltaFileName, true);    
                makePatchWriter.Close();

            }

            if (this.copyxdeltaCheckBox.Checked)
                File.Copy(xdeltaFileName, dest + tempDir + xdeltaFileName, true);
                File.Copy(xdeltaLinux, dest + tempDir + "xdelta3", true);
                File.Copy(xdeltaMac, dest + tempDir + "xdelta3_mac", true);

            if (this.zipCheckBox.Checked)
            {
                zipName = (String.IsNullOrEmpty(zipName.Trim())) ? "Patch" : zipName.Trim();

                //StreamWriter listWriter = new StreamWriter(dest + tempDir + "File List.txt");
                //if (this.copyxdeltaCheckBox.Checked)
                //    listWriter.WriteLine(xdeltaFileName);
                //listWriter.WriteLine("Apply Patch.bat");
                //for (int i = 0; i < this.oldFiles.Count; i++)
                //    listWriter.WriteLine(subDir + (i + 1).ToString() + "." + patchExt);
                //listWriter.Close();                

                Process p = new Process();
                p.StartInfo.FileName = Directory.GetCurrentDirectory() + "\\7za.exe";
                p.StartInfo.WorkingDirectory = dest + tempDir;
                //p.StartInfo.Arguments = "a -tzip \"" + dest + zipName + ".zip\" -mx9 @\"" + dest + tempDir + "File List.txt\"";
                p.StartInfo.Arguments = "a -tzip \"" + dest + zipName + ".zip\" \"" + dest + tempDir + "*";
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                p.WaitForExit();
                Directory.Delete(dest + tempDir, true);
            }
        }
    
        private void clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear all fields?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                this.oldFiles.Clear();
                this.oldFileNames.Clear();
                this.newFiles.Clear();
                this.newFileNames.Clear();
                this.destinationTextBox.Clear();
                this.oldListBox.DataSource = null;
                this.newListBox.DataSource = null;
                this.patchSubDirTextBox.Clear();
                this.patchExtTextBox.Clear();
                this.zipNameTextBox.Clear();
                this.zipCheckBox.Checked = false;
                this.copyxdeltaCheckBox.Checked = false;
                this.batchOnlyCheckBox.Checked = false;
                this.fullPathCheckBox.Checked = false;
            }
        }

        private void destinationButton_Click(object sender, EventArgs e)
        {
           // if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
           // this.destinationTextBox.Text = this.folderBrowserDialog.SelectedPath;

            //Open updated folder browser window
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = destinationTextBox.Text;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                destinationTextBox.Text = dialog.FileName;
            }
        }

        private void move(ListBox box, List<string> files, List<string> fileNames, bool up)
        {
            ListBox.SelectedIndexCollection selection = box.SelectedIndices;
            List<int> indices = new List<int>();
            foreach (int s in selection)
                indices.Add(s);
            indices.Sort();

            int top = up ? 0 : files.Count - 1;
            for (int i = up ? 0 : indices.Count - 1; up ? i < indices.Count : i >= 0; i += up ? 1 : -1)
            {
                if (indices[i] == top)
                {
                    top += up ? 1 : -1;
                    continue;
                }

                int offset = up ? -1 : 1;
                string temp = files[indices[i] + offset];
                files[indices[i] + offset] = files[indices[i]];
                files[indices[i]] = temp;

                temp = fileNames[indices[i] + offset];
                fileNames[indices[i] + offset] = fileNames[indices[i]];
                fileNames[indices[i]] = temp;

                indices[i] += offset;
            }

            box.DataSource = null;
            box.DataSource = this.fullPathCheckBox.Checked ? files : fileNames;
            box.ClearSelected();
            foreach (int i in indices)
                box.SelectedIndex = i;
        }

        //Enable drag and drop to OLD List//
        private void oldListBox_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private string OldGetFileName(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        private void oldListBox_DragDrop(object sender, System.Windows.Forms.DragEventArgs e){
            //Create a list of all dropped files/folders only
            List<string> droppedStringList = new List<string>();
            if(e.Data.GetDataPresent(DataFormats.FileDrop)) { 
                droppedStringList.AddRange((string[])e.Data.GetData(DataFormats.FileDrop, false));
            }

            //Loop through all dropped items, and display all files
            while(droppedStringList.Count > 0) {

                //Select the first item in the list, and then remove it immediately
                string path = droppedStringList[0];
                droppedStringList.RemoveAt(0);  //IMPORTANT, should be removed immediately

                //Check if the current item is file or directory
                FileAttributes attr = File.GetAttributes(path);
                if(attr.HasFlag(FileAttributes.Directory)) {
                    //If directory, add all files (inc. sub folder) to the list
                    droppedStringList.AddRange(Directory.GetFiles(path, "*", SearchOption.AllDirectories));
                }
                else {
                    if(this.oldFiles.Contains(path)) {
                        continue;
                    }
                    this.oldFiles.Add(path);
                    string[] parts = path.Split('\\');
                    this.oldFileNames.Add(parts[parts.Length - 1]);
                }
            }

            this.oldListBox.DataSource = null;
            this.oldListBox.DataSource = this.fullPathCheckBox.Checked ? this.oldFiles : this.oldFileNames;
        }
        
        //Enable drag and drop to NEW List//
        private void newListBox_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        private string NewGetFileName(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        private void newListBox_DragDrop(object sender, System.Windows.Forms.DragEventArgs e){
            //Create a list of all dropped files/folders only
            List<string> droppedStringList = new List<string>();
            if(e.Data.GetDataPresent(DataFormats.FileDrop)) {
                droppedStringList.AddRange((string[])e.Data.GetData(DataFormats.FileDrop, false));
            }

            //Loop through all dropped items, and display all files
            while(droppedStringList.Count > 0) {

                //Select the first item in the list, and then remove it immediately
                string path = droppedStringList[0];
                droppedStringList.RemoveAt(0);  //IMPORTANT, should be removed immediately

                //Check if the current item is file or directory
                FileAttributes attr = File.GetAttributes(path);
                if(attr.HasFlag(FileAttributes.Directory)) {
                    //If directory, add all files (inc. sub folder) to the list
                    droppedStringList.AddRange(Directory.GetFiles(path, "*", SearchOption.AllDirectories));
                }
                else {
                    if(this.newFiles.Contains(path)) {
                        continue;
                    }
                    this.newFiles.Add(path);
                    string[] parts = path.Split('\\');
                    this.newFileNames.Add(parts[parts.Length - 1]);
                }
            }

            this.newListBox.DataSource = null;
            this.newListBox.DataSource = this.fullPathCheckBox.Checked ? this.newFiles : this.newFileNames;
        }
        
        private void upOld_Click(object sender, EventArgs e) { this.move(oldListBox, oldFiles, oldFileNames, true); }

        private void upNew_Click(object sender, EventArgs e) { this.move(newListBox, newFiles, newFileNames, true); }

        private void downOld_Click(object sender, EventArgs e) { this.move(oldListBox, oldFiles, oldFileNames, false); }

        private void downNew_Click(object sender, EventArgs e) { this.move(newListBox, newFiles, newFileNames, false); }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            this.openFileDialogueCaller = this.newListBox;
            this.openFileDialog.ShowDialog();
        }

        private void addOldButton_Click(object sender, EventArgs e)
        {
            this.openFileDialogueCaller = this.oldListBox;
            this.openFileDialog.ShowDialog();
        }

        private void remove(ListBox box, List<string> files, List<string> fileNames)
        {
            ListBox.SelectedIndexCollection selection = box.SelectedIndices;
            List<int> indices = new List<int>();
            foreach (int s in selection)
                indices.Add(s);
            indices.Sort();

            for (int i = indices.Count - 1; i >= 0; i--)
            {
                files.RemoveAt(indices[i]);
                fileNames.RemoveAt(indices[i]);
            }

            box.DataSource = null;
            box.DataSource = this.fullPathCheckBox.Checked ? files : fileNames;
        }

        private void removeOld_Click(object sender, EventArgs e) { this.remove(oldListBox, oldFiles, oldFileNames); }

        private void removeNew_Click(object sender, EventArgs e) { this.remove(newListBox, newFiles, newFileNames); }

        #endregion

        #region Checkbox_Change_Events

        private void fullPathCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection oldSelection = this.oldListBox.SelectedIndices;
            ListBox.SelectedIndexCollection newSelection = this.newListBox.SelectedIndices;

            List<int> oldIndices = new List<int>();
            List<int> newIndices = new List<int>();

            foreach (int s in oldSelection)
                oldIndices.Add(s);
            foreach (int s in newSelection)
                newIndices.Add(s);

            this.oldListBox.DataSource = this.fullPathCheckBox.Checked ? this.oldFiles : this.oldFileNames;
            this.newListBox.DataSource = this.fullPathCheckBox.Checked ? this.newFiles : this.newFileNames;

            this.oldListBox.ClearSelected();
            this.newListBox.ClearSelected();

            foreach (int s in oldIndices)
                this.oldListBox.SelectedIndex = s;
            foreach (int s in newIndices)
                this.newListBox.SelectedIndex = s;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void zipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.zipNameTextBox.Enabled = !this.zipNameTextBox.Enabled;
            this.zipNameLabel.Enabled = !this.zipNameLabel.Enabled;
            this.batchOnlyCheckBox.Enabled = !this.zipCheckBox.Checked;
        }

        private void batchOnlyCheckBox_CheckedChanged(object sender, EventArgs e) { this.zipCheckBox.Enabled = !this.batchOnlyCheckBox.Checked; }

        #endregion

        #region Dialog_Events

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string[] files = new string[0];

            try { files = this.openFileDialog.FileNames; }
            catch (NotSupportedException)
            {
                MessageBox.Show("Unsupported file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.openFileDialogueCaller == this.newListBox)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    if (this.newFiles.Contains(files[i]))
                        continue;
                    this.newFiles.Add(files[i]);

                    string[] parts = files[i].Split('\\');
                    this.newFileNames.Add(parts[parts.Length - 1]);
                }

                this.newListBox.DataSource = null;
                this.newListBox.DataSource = this.fullPathCheckBox.Checked ? this.newFiles : this.newFileNames;
            }
            else if (this.openFileDialogueCaller == this.oldListBox)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    if (this.oldFiles.Contains(files[i]))
                        continue;
                    this.oldFiles.Add(files[i]);

                    string[] parts = files[i].Split('\\');
                    this.oldFileNames.Add(parts[parts.Length - 1]);
                }

                this.oldListBox.DataSource = null;
                this.oldListBox.DataSource = this.fullPathCheckBox.Checked ? this.oldFiles : this.oldFileNames;
            }
        }

        #endregion
        
    }
}