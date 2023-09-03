﻿namespace AppScheduler
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
            endTimeLabel = new Label();
            endTimes = new TextBox();
            parseFilesAssociation = new Button();
            saveDialog = new SaveFileDialog();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            browseToolStripMenuItem = new ToolStripMenuItem();
            createManifestToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            schedulingToolStripMenuItem = new ToolStripMenuItem();
            useExactMsTimingsToolStripMenuItem = new ToolStripMenuItem();
            pauseSchedulingToolStripMenuItem = new ToolStripMenuItem();
            nuclearModeToolStripMenuItem = new ToolStripMenuItem();
            filesLabel = new Label();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // fileDialog
            // 
            fileDialog.Multiselect = true;
            // 
            // files
            // 
            files.Location = new Point(169, 49);
            files.Multiline = true;
            files.Name = "files";
            files.Size = new Size(363, 357);
            files.TabIndex = 1;
            files.WordWrap = false;
            // 
            // startTimes
            // 
            startTimes.Location = new Point(11, 49);
            startTimes.Multiline = true;
            startTimes.Name = "startTimes";
            startTimes.Size = new Size(73, 357);
            startTimes.TabIndex = 2;
            startTimes.WordWrap = false;
            // 
            // cmdArgs
            // 
            cmdArgs.Location = new Point(538, 49);
            cmdArgs.Multiline = true;
            cmdArgs.Name = "cmdArgs";
            cmdArgs.Size = new Size(297, 357);
            cmdArgs.TabIndex = 3;
            cmdArgs.WordWrap = false;
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.BackColor = SystemColors.Control;
            startTimeLabel.Location = new Point(11, 27);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new Size(60, 15);
            startTimeLabel.TabIndex = 5;
            startTimeLabel.Text = "Start Time";
            // 
            // cmdArgsLabel
            // 
            cmdArgsLabel.AutoSize = true;
            cmdArgsLabel.BackColor = SystemColors.Control;
            cmdArgsLabel.Location = new Point(538, 27);
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
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.BackColor = SystemColors.Control;
            endTimeLabel.Location = new Point(90, 27);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new Size(56, 15);
            endTimeLabel.TabIndex = 10;
            endTimeLabel.Text = "End Time";
            // 
            // endTimes
            // 
            endTimes.Location = new Point(90, 49);
            endTimes.Multiline = true;
            endTimes.Name = "endTimes";
            endTimes.Size = new Size(73, 357);
            endTimes.TabIndex = 9;
            endTimes.WordWrap = false;
            // 
            // parseFilesAssociation
            // 
            parseFilesAssociation.Location = new Point(206, 23);
            parseFilesAssociation.Name = "parseFilesAssociation";
            parseFilesAssociation.Size = new Size(187, 23);
            parseFilesAssociation.TabIndex = 12;
            parseFilesAssociation.Text = "File 2 Exe (to allow cmd args)";
            parseFilesAssociation.UseVisualStyleBackColor = true;
            parseFilesAssociation.Click += parseFilesAssociation_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, schedulingToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(849, 24);
            menuStrip.TabIndex = 15;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { browseToolStripMenuItem, createManifestToolStripMenuItem, toolStripSeparator1, saveToolStripMenuItem, saveAsToolStripMenuItem, loadToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(61, 20);
            fileToolStripMenuItem.Text = "Options";
            // 
            // browseToolStripMenuItem
            // 
            browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            browseToolStripMenuItem.Size = new Size(170, 22);
            browseToolStripMenuItem.Text = "Browse";
            browseToolStripMenuItem.Click += browseToolStripMenuItem_Click;
            // 
            // createManifestToolStripMenuItem
            // 
            createManifestToolStripMenuItem.Checked = true;
            createManifestToolStripMenuItem.CheckOnClick = true;
            createManifestToolStripMenuItem.CheckState = CheckState.Checked;
            createManifestToolStripMenuItem.Name = "createManifestToolStripMenuItem";
            createManifestToolStripMenuItem.Size = new Size(170, 22);
            createManifestToolStripMenuItem.Text = "Auto Load Default";
            createManifestToolStripMenuItem.Click += createManifestToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(167, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(170, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(170, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(170, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // schedulingToolStripMenuItem
            // 
            schedulingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { useExactMsTimingsToolStripMenuItem, pauseSchedulingToolStripMenuItem, nuclearModeToolStripMenuItem });
            schedulingToolStripMenuItem.Name = "schedulingToolStripMenuItem";
            schedulingToolStripMenuItem.Size = new Size(78, 20);
            schedulingToolStripMenuItem.Text = "Scheduling";
            // 
            // useExactMsTimingsToolStripMenuItem
            // 
            useExactMsTimingsToolStripMenuItem.CheckOnClick = true;
            useExactMsTimingsToolStripMenuItem.Name = "useExactMsTimingsToolStripMenuItem";
            useExactMsTimingsToolStripMenuItem.Size = new Size(191, 22);
            useExactMsTimingsToolStripMenuItem.Text = " Use Exact ms Timings";
            // 
            // pauseSchedulingToolStripMenuItem
            // 
            pauseSchedulingToolStripMenuItem.CheckOnClick = true;
            pauseSchedulingToolStripMenuItem.Name = "pauseSchedulingToolStripMenuItem";
            pauseSchedulingToolStripMenuItem.Size = new Size(191, 22);
            pauseSchedulingToolStripMenuItem.Text = "Pause Scheduling";
            pauseSchedulingToolStripMenuItem.Click += pauseSchedulingToolStripMenuItem_Click;
            // 
            // nuclearModeToolStripMenuItem
            // 
            nuclearModeToolStripMenuItem.CheckOnClick = true;
            nuclearModeToolStripMenuItem.Name = "nuclearModeToolStripMenuItem";
            nuclearModeToolStripMenuItem.Size = new Size(191, 22);
            nuclearModeToolStripMenuItem.Text = "Nuclear Mode";
            nuclearModeToolStripMenuItem.ToolTipText = "kill all children 😧";
            // 
            // filesLabel
            // 
            filesLabel.AutoSize = true;
            filesLabel.BackColor = SystemColors.Control;
            filesLabel.Location = new Point(169, 27);
            filesLabel.Name = "filesLabel";
            filesLabel.Size = new Size(30, 15);
            filesLabel.TabIndex = 17;
            filesLabel.Text = "Files";
            // 
            // AppScheduler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 418);
            Controls.Add(filesLabel);
            Controls.Add(startTimeLabel);
            Controls.Add(parseFilesAssociation);
            Controls.Add(endTimeLabel);
            Controls.Add(endTimes);
            Controls.Add(cmdArgsLabel);
            Controls.Add(cmdArgs);
            Controls.Add(startTimes);
            Controls.Add(files);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "AppScheduler";
            Text = "App Scheduler";
            Load += AppScheduler_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
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
        private Label endTimeLabel;
        private TextBox endTimes;
        private Button parseFilesAssociation;
        private SaveFileDialog saveDialog;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem browseToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem createManifestToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private Label filesLabel;
        private ToolStripMenuItem schedulingToolStripMenuItem;
        private ToolStripMenuItem useExactMsTimingsToolStripMenuItem;
        private ToolStripMenuItem pauseSchedulingToolStripMenuItem;
        private ToolStripMenuItem nuclearModeToolStripMenuItem;
    }
}