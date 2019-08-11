namespace xdelta3_GUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.create = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.addOld = new System.Windows.Forms.Button();
            this.destinationButton = new System.Windows.Forms.Button();
            this.addNew = new System.Windows.Forms.Button();
            this.filesGroupBox = new System.Windows.Forms.GroupBox();
            this.downNew = new System.Windows.Forms.Button();
            this.upNew = new System.Windows.Forms.Button();
            this.downOld = new System.Windows.Forms.Button();
            this.upOld = new System.Windows.Forms.Button();
            this.removeNew = new System.Windows.Forms.Button();
            this.removeOld = new System.Windows.Forms.Button();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.newListBox = new System.Windows.Forms.ListBox();
            this.oldListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.patchExtTextBox = new System.Windows.Forms.TextBox();
            this.patchExtLabel = new System.Windows.Forms.Label();
            this.zipNameTextBox = new System.Windows.Forms.TextBox();
            this.zipNameLabel = new System.Windows.Forms.Label();
            this.zipCheckBox = new System.Windows.Forms.CheckBox();
            this.copyxdeltaCheckBox = new System.Windows.Forms.CheckBox();
            this.patchSubDirTextBox = new System.Windows.Forms.TextBox();
            this.patchSubDirLabel = new System.Windows.Forms.Label();
            this.batchOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.fullPathCheckBox = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.xdeltaargs = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.Label();
            this.xdeltaGroupBox = new System.Windows.Forms.GroupBox();
            this.filesGroupBox.SuspendLayout();
            this.optionsGroupBox.SuspendLayout();
            this.xdeltaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.create.Location = new System.Drawing.Point(476, 520);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(90, 40);
            this.create.TabIndex = 20;
            this.create.Text = "Create Patch";
            this.toolTip.SetToolTip(this.create, "Create patches using specified settings.");
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(395, 535);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 25);
            this.clear.TabIndex = 19;
            this.clear.Text = "Clear";
            this.toolTip.SetToolTip(this.clear, "Clear all fields.");
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.CheckFileExists = false;
            this.openFileDialog.CheckPathExists = false;
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // addOld
            // 
            this.addOld.Location = new System.Drawing.Point(6, 250);
            this.addOld.Name = "addOld";
            this.addOld.Size = new System.Drawing.Size(63, 24);
            this.addOld.TabIndex = 2;
            this.addOld.Text = "Add";
            this.toolTip.SetToolTip(this.addOld, "Add one or more files to patch from.");
            this.addOld.UseVisualStyleBackColor = true;
            this.addOld.Click += new System.EventHandler(this.addOldButton_Click);
            // 
            // destinationButton
            // 
            this.destinationButton.Location = new System.Drawing.Point(529, 280);
            this.destinationButton.Name = "destinationButton";
            this.destinationButton.Size = new System.Drawing.Size(25, 20);
            this.destinationButton.TabIndex = 12;
            this.destinationButton.Text = "...";
            this.toolTip.SetToolTip(this.destinationButton, "Browse.");
            this.destinationButton.UseVisualStyleBackColor = true;
            this.destinationButton.Click += new System.EventHandler(this.destinationButton_Click);
            // 
            // addNew
            // 
            this.addNew.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addNew.Location = new System.Drawing.Point(283, 250);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(63, 24);
            this.addNew.TabIndex = 7;
            this.addNew.Text = "Add";
            this.toolTip.SetToolTip(this.addNew, "Add one or more files to patch to.");
            this.addNew.UseVisualStyleBackColor = true;
            this.addNew.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // filesGroupBox
            // 
            this.filesGroupBox.Controls.Add(this.downNew);
            this.filesGroupBox.Controls.Add(this.upNew);
            this.filesGroupBox.Controls.Add(this.downOld);
            this.filesGroupBox.Controls.Add(this.upOld);
            this.filesGroupBox.Controls.Add(this.removeNew);
            this.filesGroupBox.Controls.Add(this.removeOld);
            this.filesGroupBox.Controls.Add(this.destinationTextBox);
            this.filesGroupBox.Controls.Add(this.newListBox);
            this.filesGroupBox.Controls.Add(this.oldListBox);
            this.filesGroupBox.Controls.Add(this.label3);
            this.filesGroupBox.Controls.Add(this.label1);
            this.filesGroupBox.Controls.Add(this.label2);
            this.filesGroupBox.Controls.Add(this.destinationButton);
            this.filesGroupBox.Controls.Add(this.addOld);
            this.filesGroupBox.Controls.Add(this.addNew);
            this.filesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.filesGroupBox.Name = "filesGroupBox";
            this.filesGroupBox.Size = new System.Drawing.Size(560, 306);
            this.filesGroupBox.TabIndex = 8;
            this.filesGroupBox.TabStop = false;
            this.filesGroupBox.Text = "Files";
            // 
            // downNew
            // 
            this.downNew.Location = new System.Drawing.Point(491, 250);
            this.downNew.Name = "downNew";
            this.downNew.Size = new System.Drawing.Size(63, 24);
            this.downNew.TabIndex = 10;
            this.downNew.Text = "Down";
            this.toolTip.SetToolTip(this.downNew, "Move the selected files down.");
            this.downNew.UseVisualStyleBackColor = true;
            this.downNew.Click += new System.EventHandler(this.downNew_Click);
            // 
            // upNew
            // 
            this.upNew.Location = new System.Drawing.Point(421, 250);
            this.upNew.Name = "upNew";
            this.upNew.Size = new System.Drawing.Size(63, 24);
            this.upNew.TabIndex = 9;
            this.upNew.Text = "Up";
            this.toolTip.SetToolTip(this.upNew, "Move the selected files up.");
            this.upNew.UseVisualStyleBackColor = true;
            this.upNew.Click += new System.EventHandler(this.upNew_Click);
            // 
            // downOld
            // 
            this.downOld.Location = new System.Drawing.Point(214, 250);
            this.downOld.Name = "downOld";
            this.downOld.Size = new System.Drawing.Size(63, 24);
            this.downOld.TabIndex = 5;
            this.downOld.Text = "Down";
            this.toolTip.SetToolTip(this.downOld, "Move the selected files down.");
            this.downOld.UseVisualStyleBackColor = true;
            this.downOld.Click += new System.EventHandler(this.downOld_Click);
            // 
            // upOld
            // 
            this.upOld.Location = new System.Drawing.Point(145, 250);
            this.upOld.Name = "upOld";
            this.upOld.Size = new System.Drawing.Size(63, 24);
            this.upOld.TabIndex = 4;
            this.upOld.Text = "Up";
            this.toolTip.SetToolTip(this.upOld, "Move the selected files up.");
            this.upOld.UseVisualStyleBackColor = true;
            this.upOld.Click += new System.EventHandler(this.upOld_Click);
            // 
            // removeNew
            // 
            this.removeNew.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.removeNew.Location = new System.Drawing.Point(352, 250);
            this.removeNew.Name = "removeNew";
            this.removeNew.Size = new System.Drawing.Size(63, 24);
            this.removeNew.TabIndex = 8;
            this.removeNew.Text = "Remove";
            this.toolTip.SetToolTip(this.removeNew, "Remove the selected files from the list.");
            this.removeNew.UseVisualStyleBackColor = true;
            this.removeNew.Click += new System.EventHandler(this.removeNew_Click);
            // 
            // removeOld
            // 
            this.removeOld.Location = new System.Drawing.Point(76, 250);
            this.removeOld.Name = "removeOld";
            this.removeOld.Size = new System.Drawing.Size(63, 24);
            this.removeOld.TabIndex = 3;
            this.removeOld.Text = "Remove";
            this.toolTip.SetToolTip(this.removeOld, "Remove the selected files from the list.");
            this.removeOld.UseVisualStyleBackColor = true;
            this.removeOld.Click += new System.EventHandler(this.removeOld_Click);
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.AllowDrop = true;
            this.destinationTextBox.Location = new System.Drawing.Point(133, 280);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(393, 20);
            this.destinationTextBox.TabIndex = 11;
            this.toolTip.SetToolTip(this.destinationTextBox, "Location of the root folder for all files that will be created. Paste supported.");
            // 
            // newListBox
            // 
            this.newListBox.AllowDrop = true;
            this.newListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.newListBox.FormattingEnabled = true;
            this.newListBox.HorizontalScrollbar = true;
            this.newListBox.Location = new System.Drawing.Point(283, 32);
            this.newListBox.Name = "newListBox";
            this.newListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.newListBox.Size = new System.Drawing.Size(271, 212);
            this.newListBox.TabIndex = 6;
            this.toolTip.SetToolTip(this.newListBox, "The list of files to patch to. Drag and drop supported for files and/or directori" +
        "es.");
            this.newListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.newListBox_DragDrop);
            this.newListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.newListBox_DragEnter);
            // 
            // oldListBox
            // 
            this.oldListBox.AllowDrop = true;
            this.oldListBox.ForeColor = System.Drawing.Color.Red;
            this.oldListBox.FormattingEnabled = true;
            this.oldListBox.HorizontalScrollbar = true;
            this.oldListBox.Location = new System.Drawing.Point(6, 32);
            this.oldListBox.Name = "oldListBox";
            this.oldListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.oldListBox.Size = new System.Drawing.Size(271, 212);
            this.oldListBox.TabIndex = 1;
            this.toolTip.SetToolTip(this.oldListBox, "The list of files to patch from. Drag and drop supported for files and/or directo" +
        "ries.");
            this.oldListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.oldListBox_DragDrop);
            this.oldListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.oldListBox_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(6, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Patch File(s) Destination";
            this.toolTip.SetToolTip(this.label3, "Location of the root folder for all files that will be created. Paste supported.\r" +
        "\n");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Old File(s)";
            this.toolTip.SetToolTip(this.label1, "The list of files to patch from.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(280, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "New File(s)";
            this.toolTip.SetToolTip(this.label2, "The list of files to patch to.");
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Controls.Add(this.patchExtTextBox);
            this.optionsGroupBox.Controls.Add(this.patchExtLabel);
            this.optionsGroupBox.Controls.Add(this.zipNameTextBox);
            this.optionsGroupBox.Controls.Add(this.zipNameLabel);
            this.optionsGroupBox.Controls.Add(this.zipCheckBox);
            this.optionsGroupBox.Controls.Add(this.copyxdeltaCheckBox);
            this.optionsGroupBox.Controls.Add(this.patchSubDirTextBox);
            this.optionsGroupBox.Controls.Add(this.patchSubDirLabel);
            this.optionsGroupBox.Controls.Add(this.batchOnlyCheckBox);
            this.optionsGroupBox.Controls.Add(this.fullPathCheckBox);
            this.optionsGroupBox.Location = new System.Drawing.Point(12, 324);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(560, 121);
            this.optionsGroupBox.TabIndex = 9;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Options";
            // 
            // patchExtTextBox
            // 
            this.patchExtTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "xdelta",
            "vcdiff",
            "diff"});
            this.patchExtTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.patchExtTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.patchExtTextBox.Location = new System.Drawing.Point(97, 93);
            this.patchExtTextBox.Name = "patchExtTextBox";
            this.patchExtTextBox.Size = new System.Drawing.Size(177, 20);
            this.patchExtTextBox.TabIndex = 20;
            this.patchExtTextBox.Text = "vcdiff";
            this.toolTip.SetToolTip(this.patchExtTextBox, "Set the extension of the \'difference\' files for xdelta to use.\r\n");
            // 
            // patchExtLabel
            // 
            this.patchExtLabel.AutoSize = true;
            this.patchExtLabel.Location = new System.Drawing.Point(7, 96);
            this.patchExtLabel.Name = "patchExtLabel";
            this.patchExtLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.patchExtLabel.Size = new System.Drawing.Size(84, 13);
            this.patchExtLabel.TabIndex = 19;
            this.patchExtLabel.Text = "Patch Extension";
            this.toolTip.SetToolTip(this.patchExtLabel, "Set the extension of the \'difference\' files for xdelta to use. Can be anything.");
            // 
            // zipNameTextBox
            // 
            this.zipNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.zipNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.zipNameTextBox.Enabled = false;
            this.zipNameTextBox.Location = new System.Drawing.Point(337, 66);
            this.zipNameTextBox.Name = "zipNameTextBox";
            this.zipNameTextBox.Size = new System.Drawing.Size(217, 20);
            this.zipNameTextBox.TabIndex = 18;
            this.zipNameTextBox.Text = "patch";
            this.toolTip.SetToolTip(this.zipNameTextBox, "Define the name of the .zip archive to create.");
            // 
            // zipNameLabel
            // 
            this.zipNameLabel.AutoSize = true;
            this.zipNameLabel.Enabled = false;
            this.zipNameLabel.Location = new System.Drawing.Point(280, 69);
            this.zipNameLabel.Name = "zipNameLabel";
            this.zipNameLabel.Size = new System.Drawing.Size(51, 13);
            this.zipNameLabel.TabIndex = 6;
            this.zipNameLabel.Text = "Zip name";
            this.toolTip.SetToolTip(this.zipNameLabel, "Define the name of the .zip archive to create.");
            // 
            // zipCheckBox
            // 
            this.zipCheckBox.AutoSize = true;
            this.zipCheckBox.Location = new System.Drawing.Point(283, 43);
            this.zipCheckBox.Name = "zipCheckBox";
            this.zipCheckBox.Size = new System.Drawing.Size(75, 17);
            this.zipCheckBox.TabIndex = 17;
            this.zipCheckBox.Text = "Zip all files";
            this.toolTip.SetToolTip(this.zipCheckBox, "Compress and zip all generated files.");
            this.zipCheckBox.UseVisualStyleBackColor = true;
            this.zipCheckBox.CheckedChanged += new System.EventHandler(this.zipCheckBox_CheckedChanged);
            // 
            // copyxdeltaCheckBox
            // 
            this.copyxdeltaCheckBox.AutoSize = true;
            this.copyxdeltaCheckBox.Checked = true;
            this.copyxdeltaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copyxdeltaCheckBox.Location = new System.Drawing.Point(283, 19);
            this.copyxdeltaCheckBox.Name = "copyxdeltaCheckBox";
            this.copyxdeltaCheckBox.Size = new System.Drawing.Size(227, 17);
            this.copyxdeltaCheckBox.TabIndex = 16;
            this.copyxdeltaCheckBox.Text = "Copy xdelta3 executables to main directory";
            this.toolTip.SetToolTip(this.copyxdeltaCheckBox, "Copy xdelta3 executables (Windows and Linux) to the main folder (recommended).");
            this.copyxdeltaCheckBox.UseVisualStyleBackColor = true;
            // 
            // patchSubDirTextBox
            // 
            this.patchSubDirTextBox.Location = new System.Drawing.Point(97, 66);
            this.patchSubDirTextBox.Name = "patchSubDirTextBox";
            this.patchSubDirTextBox.Size = new System.Drawing.Size(177, 20);
            this.patchSubDirTextBox.TabIndex = 15;
            this.patchSubDirTextBox.Text = "vcdiff";
            this.toolTip.SetToolTip(this.patchSubDirTextBox, "Subdirectory to put the generated patch files in (relative to the root folder spe" +
        "cified above).");
            // 
            // patchSubDirLabel
            // 
            this.patchSubDirLabel.AutoSize = true;
            this.patchSubDirLabel.Location = new System.Drawing.Point(6, 69);
            this.patchSubDirLabel.Name = "patchSubDirLabel";
            this.patchSubDirLabel.Size = new System.Drawing.Size(66, 13);
            this.patchSubDirLabel.TabIndex = 2;
            this.patchSubDirLabel.Text = "Patch subdir";
            this.toolTip.SetToolTip(this.patchSubDirLabel, "Subdirectory to put the generated patch files in (relative to the root folder spe" +
        "cified above).\r\n");
            // 
            // batchOnlyCheckBox
            // 
            this.batchOnlyCheckBox.AutoSize = true;
            this.batchOnlyCheckBox.Location = new System.Drawing.Point(9, 43);
            this.batchOnlyCheckBox.Name = "batchOnlyCheckBox";
            this.batchOnlyCheckBox.Size = new System.Drawing.Size(214, 17);
            this.batchOnlyCheckBox.TabIndex = 14;
            this.batchOnlyCheckBox.Text = "Batch file only (for making patches later)";
            this.toolTip.SetToolTip(this.batchOnlyCheckBox, "Generate a .bat file to make the patches later on.");
            this.batchOnlyCheckBox.UseVisualStyleBackColor = true;
            this.batchOnlyCheckBox.CheckedChanged += new System.EventHandler(this.batchOnlyCheckBox_CheckedChanged);
            // 
            // fullPathCheckBox
            // 
            this.fullPathCheckBox.AutoSize = true;
            this.fullPathCheckBox.Location = new System.Drawing.Point(9, 19);
            this.fullPathCheckBox.Name = "fullPathCheckBox";
            this.fullPathCheckBox.Size = new System.Drawing.Size(98, 17);
            this.fullPathCheckBox.TabIndex = 13;
            this.fullPathCheckBox.Text = "Show full paths";
            this.toolTip.SetToolTip(this.fullPathCheckBox, "Show full file paths instead of just file names in the above boxes.");
            this.fullPathCheckBox.UseVisualStyleBackColor = true;
            this.fullPathCheckBox.CheckedChanged += new System.EventHandler(this.fullPathCheckBox_CheckedChanged);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 0;
            this.toolTip.ReshowDelay = 0;
            // 
            // xdeltaargs
            // 
            this.xdeltaargs.AutoCompleteCustomSource.AddRange(new string[] {
            "-B 1073741824 -e -9 -S djw -vfs",
            "-e -9 -S djw -vfs"});
            this.xdeltaargs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.xdeltaargs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.xdeltaargs.Location = new System.Drawing.Point(9, 28);
            this.xdeltaargs.Name = "xdeltaargs";
            this.xdeltaargs.Size = new System.Drawing.Size(545, 20);
            this.xdeltaargs.TabIndex = 21;
            this.xdeltaargs.Text = "-B 1073741824 -e -9 -S djw -vfs";
            this.toolTip.SetToolTip(this.xdeltaargs, "Supports all xdelta flags. Enter arguments as desired with single spaces between " +
        "each. Do not change if unsure. \r\nNOTE: remove or change -B value if programme la" +
        "gs when making patches.");
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Enabled = false;
            this.info.Location = new System.Drawing.Point(9, 534);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(290, 26);
            this.info.TabIndex = 21;
            this.info.Text = "xdelta3 GUI by Jordi Vermeulen (modified by Brian Campbell)\rUses xdelta 3.1.0";
            // 
            // xdeltaGroupBox
            // 
            this.xdeltaGroupBox.Controls.Add(this.xdeltaargs);
            this.xdeltaGroupBox.Location = new System.Drawing.Point(12, 451);
            this.xdeltaGroupBox.Name = "xdeltaGroupBox";
            this.xdeltaGroupBox.Size = new System.Drawing.Size(560, 63);
            this.xdeltaGroupBox.TabIndex = 22;
            this.xdeltaGroupBox.TabStop = false;
            this.xdeltaGroupBox.Text = "Xdelta Arguments";
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 580);
            this.Controls.Add(this.xdeltaGroupBox);
            this.Controls.Add(this.info);
            this.Controls.Add(this.optionsGroupBox);
            this.Controls.Add(this.filesGroupBox);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.create);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xdelta3 GUI 2.0  v2.0.9";
            this.Load += new System.EventHandler(this.Main_Load);
            this.filesGroupBox.ResumeLayout(false);
            this.filesGroupBox.PerformLayout();
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.xdeltaGroupBox.ResumeLayout(false);
            this.xdeltaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button addOld;
        private System.Windows.Forms.Button destinationButton;
        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.GroupBox filesGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.ListBox newListBox;
        private System.Windows.Forms.ListBox oldListBox;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.Button removeNew;
        private System.Windows.Forms.Button removeOld;
        private System.Windows.Forms.CheckBox fullPathCheckBox;
        private System.Windows.Forms.Button downNew;
        private System.Windows.Forms.Button upNew;
        private System.Windows.Forms.Button downOld;
        private System.Windows.Forms.Button upOld;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox batchOnlyCheckBox;
        private System.Windows.Forms.TextBox patchSubDirTextBox;
        private System.Windows.Forms.Label patchSubDirLabel;
        private System.Windows.Forms.CheckBox zipCheckBox;
        private System.Windows.Forms.CheckBox copyxdeltaCheckBox;
        private System.Windows.Forms.TextBox zipNameTextBox;
        private System.Windows.Forms.Label zipNameLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.GroupBox xdeltaGroupBox;
        private System.Windows.Forms.TextBox xdeltaargs;
        private System.Windows.Forms.TextBox patchExtTextBox;
        private System.Windows.Forms.Label patchExtLabel;
    }
}

