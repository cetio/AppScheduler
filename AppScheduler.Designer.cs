namespace AppScheduler
{
    partial class AppScheduler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppScheduler));
            fileDialog = new OpenFileDialog();
            files = new TextBox();
            startTimes = new TextBox();
            cmdArgs = new TextBox();
            startTimeLabel = new Label();
            cmdArgsLabel = new Label();
            scheduler = new System.Windows.Forms.Timer(components);
            notifyIcon = new NotifyIcon(components);
            pauseResume = new Button();
            useExactMS = new CheckBox();
            endTimeLabel = new Label();
            endTimes = new TextBox();
            parseFilesAssociation = new Button();
            saveDialog = new SaveFileDialog();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            browseToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            createManifestToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // fileDialog
            // 
            fileDialog.Multiselect = true;
            // 
            // files
            // 
            files.Location = new Point(12, 27);
            files.Multiline = true;
            files.Name = "files";
            files.Size = new Size(279, 357);
            files.TabIndex = 1;
            files.WordWrap = false;
            // 
            // startTimes
            // 
            startTimes.Location = new Point(297, 27);
            startTimes.Multiline = true;
            startTimes.Name = "startTimes";
            startTimes.Size = new Size(73, 357);
            startTimes.TabIndex = 2;
            startTimes.WordWrap = false;
            // 
            // cmdArgs
            // 
            cmdArgs.Location = new Point(455, 27);
            cmdArgs.Multiline = true;
            cmdArgs.Name = "cmdArgs";
            cmdArgs.Size = new Size(157, 357);
            cmdArgs.TabIndex = 3;
            cmdArgs.WordWrap = false;
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.BackColor = SystemColors.ButtonHighlight;
            startTimeLabel.Location = new Point(297, 5);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new Size(60, 15);
            startTimeLabel.TabIndex = 5;
            startTimeLabel.Text = "Start Time";
            // 
            // cmdArgsLabel
            // 
            cmdArgsLabel.AutoSize = true;
            cmdArgsLabel.BackColor = SystemColors.ButtonHighlight;
            cmdArgsLabel.Location = new Point(455, 5);
            cmdArgsLabel.Name = "cmdArgsLabel";
            cmdArgsLabel.Size = new Size(60, 15);
            cmdArgsLabel.TabIndex = 6;
            cmdArgsLabel.Text = "Cmd Args";
            // 
            // scheduler
            // 
            scheduler.Enabled = true;
            scheduler.Interval = 90;
            scheduler.Tick += scheduler_Tick;
            // 
            // notifyIcon
            // 
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "App Scheduler";
            notifyIcon.MouseDoubleClick += notifyIcon_MouseDoubleClick;
            // 
            // pauseResume
            // 
            pauseResume.Location = new Point(237, 390);
            pauseResume.Name = "pauseResume";
            pauseResume.Size = new Size(93, 23);
            pauseResume.TabIndex = 7;
            pauseResume.Text = "Pause";
            pauseResume.UseVisualStyleBackColor = true;
            pauseResume.Click += pauseResume_Click;
            // 
            // useExactMS
            // 
            useExactMS.AutoSize = true;
            useExactMS.Checked = true;
            useExactMS.CheckState = CheckState.Checked;
            useExactMS.Location = new Point(342, 393);
            useExactMS.Name = "useExactMS";
            useExactMS.Size = new Size(221, 19);
            useExactMS.TabIndex = 8;
            useExactMS.Text = "Use Exact MS (disable if not working)";
            useExactMS.UseVisualStyleBackColor = true;
            useExactMS.CheckedChanged += useExactMS_CheckedChanged;
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.BackColor = SystemColors.ButtonHighlight;
            endTimeLabel.Location = new Point(376, 5);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new Size(56, 15);
            endTimeLabel.TabIndex = 10;
            endTimeLabel.Text = "End Time";
            // 
            // endTimes
            // 
            endTimes.Location = new Point(376, 27);
            endTimes.Multiline = true;
            endTimes.Name = "endTimes";
            endTimes.Size = new Size(73, 357);
            endTimes.TabIndex = 9;
            endTimes.WordWrap = false;
            // 
            // parseFilesAssociation
            // 
            parseFilesAssociation.Location = new Point(12, 390);
            parseFilesAssociation.Name = "parseFilesAssociation";
            parseFilesAssociation.Size = new Size(219, 23);
            parseFilesAssociation.TabIndex = 12;
            parseFilesAssociation.Text = "Parse Files As Associated Process";
            parseFilesAssociation.UseVisualStyleBackColor = true;
            parseFilesAssociation.Click += parseFilesAssociation_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(621, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { browseToolStripMenuItem, saveAsToolStripMenuItem, saveToolStripMenuItem, loadToolStripMenuItem, createManifestToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(42, 20);
            fileToolStripMenuItem.Text = "Files";
            // 
            // browseToolStripMenuItem
            // 
            browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            browseToolStripMenuItem.Size = new Size(157, 22);
            browseToolStripMenuItem.Text = "Browse";
            browseToolStripMenuItem.Click += browseToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(157, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(157, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(157, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // createManifestToolStripMenuItem
            // 
            createManifestToolStripMenuItem.Name = "createManifestToolStripMenuItem";
            createManifestToolStripMenuItem.Size = new Size(157, 22);
            createManifestToolStripMenuItem.Text = "Create Manifest";
            createManifestToolStripMenuItem.Click += createManifestToolStripMenuItem_Click;
            // 
            // AppScheduler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 423);
            Controls.Add(startTimeLabel);
            Controls.Add(parseFilesAssociation);
            Controls.Add(endTimeLabel);
            Controls.Add(endTimes);
            Controls.Add(useExactMS);
            Controls.Add(pauseResume);
            Controls.Add(cmdArgsLabel);
            Controls.Add(cmdArgs);
            Controls.Add(startTimes);
            Controls.Add(files);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "AppScheduler";
            Text = "App Scheduler";
            Load += AppScheduler_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog fileDialog;
        private TextBox files;
        private TextBox startTimes;
        private TextBox cmdArgs;
        private Label startTimeLabel;
        private Label cmdArgsLabel;
        private System.Windows.Forms.Timer scheduler;
        private NotifyIcon notifyIcon;
        private Button pauseResume;
        private CheckBox useExactMS;
        private Label endTimeLabel;
        private TextBox endTimes;
        private Button parseFilesAssociation;
        private SaveFileDialog saveDialog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem browseToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem createManifestToolStripMenuItem;
    }
}