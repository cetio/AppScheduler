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
            addFiles = new Button();
            fileDialog = new OpenFileDialog();
            files = new TextBox();
            startTimes = new TextBox();
            cmdArgs = new TextBox();
            filesLabel = new Label();
            startTimeLabel = new Label();
            cmdArgsLabel = new Label();
            scheduler = new System.Windows.Forms.Timer(components);
            notifyIcon = new NotifyIcon(components);
            pauseResume = new Button();
            useExactMS = new CheckBox();
            endTimeLabel = new Label();
            endTimes = new TextBox();
            parseFilesAssociation = new Button();
            button1 = new Button();
            button2 = new Button();
            saveDialog = new SaveFileDialog();
            SuspendLayout();
            // 
            // addFiles
            // 
            addFiles.Location = new Point(12, 12);
            addFiles.Name = "addFiles";
            addFiles.Size = new Size(93, 23);
            addFiles.TabIndex = 0;
            addFiles.Text = "Add Files";
            addFiles.UseVisualStyleBackColor = true;
            addFiles.Click += addFiles_Click;
            // 
            // fileDialog
            // 
            fileDialog.Multiselect = true;
            // 
            // files
            // 
            files.Location = new Point(12, 56);
            files.Multiline = true;
            files.Name = "files";
            files.Size = new Size(279, 357);
            files.TabIndex = 1;
            files.WordWrap = false;
            // 
            // startTimes
            // 
            startTimes.Location = new Point(297, 56);
            startTimes.Multiline = true;
            startTimes.Name = "startTimes";
            startTimes.Size = new Size(73, 357);
            startTimes.TabIndex = 2;
            startTimes.WordWrap = false;
            // 
            // cmdArgs
            // 
            cmdArgs.Location = new Point(455, 56);
            cmdArgs.Multiline = true;
            cmdArgs.Name = "cmdArgs";
            cmdArgs.Size = new Size(157, 357);
            cmdArgs.TabIndex = 3;
            cmdArgs.WordWrap = false;
            // 
            // filesLabel
            // 
            filesLabel.AutoSize = true;
            filesLabel.Location = new Point(12, 38);
            filesLabel.Name = "filesLabel";
            filesLabel.Size = new Size(30, 15);
            filesLabel.TabIndex = 4;
            filesLabel.Text = "Files";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new Point(297, 38);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new Size(60, 15);
            startTimeLabel.TabIndex = 5;
            startTimeLabel.Text = "Start Time";
            // 
            // cmdArgsLabel
            // 
            cmdArgsLabel.AutoSize = true;
            cmdArgsLabel.Location = new Point(455, 38);
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
            pauseResume.Location = new Point(111, 12);
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
            useExactMS.Location = new Point(210, 15);
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
            endTimeLabel.Location = new Point(376, 38);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new Size(56, 15);
            endTimeLabel.TabIndex = 10;
            endTimeLabel.Text = "End Time";
            // 
            // endTimes
            // 
            endTimes.Location = new Point(376, 56);
            endTimes.Multiline = true;
            endTimes.Name = "endTimes";
            endTimes.Size = new Size(73, 357);
            endTimes.TabIndex = 9;
            endTimes.WordWrap = false;
            // 
            // parseFilesAssociation
            // 
            parseFilesAssociation.Location = new Point(12, 419);
            parseFilesAssociation.Name = "parseFilesAssociation";
            parseFilesAssociation.Size = new Size(219, 23);
            parseFilesAssociation.TabIndex = 12;
            parseFilesAssociation.Text = "Parse Files As Associated Process";
            parseFilesAssociation.UseVisualStyleBackColor = true;
            parseFilesAssociation.Click += parseFilesAssociation_Click;
            // 
            // button1
            // 
            button1.Location = new Point(237, 418);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 13;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(333, 418);
            button2.Name = "button2";
            button2.Size = new Size(90, 23);
            button2.TabIndex = 14;
            button2.Text = "Load";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AppScheduler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 453);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(parseFilesAssociation);
            Controls.Add(endTimeLabel);
            Controls.Add(endTimes);
            Controls.Add(useExactMS);
            Controls.Add(pauseResume);
            Controls.Add(cmdArgsLabel);
            Controls.Add(startTimeLabel);
            Controls.Add(filesLabel);
            Controls.Add(cmdArgs);
            Controls.Add(startTimes);
            Controls.Add(files);
            Controls.Add(addFiles);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AppScheduler";
            Text = "App Scheduler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addFiles;
        private OpenFileDialog fileDialog;
        private TextBox files;
        private TextBox startTimes;
        private TextBox cmdArgs;
        private Label filesLabel;
        private Label startTimeLabel;
        private Label cmdArgsLabel;
        private System.Windows.Forms.Timer scheduler;
        private NotifyIcon notifyIcon;
        private Button pauseResume;
        private CheckBox useExactMS;
        private Label endTimeLabel;
        private TextBox endTimes;
        private Button parseFilesAssociation;
        private Button button1;
        private Button button2;
        private SaveFileDialog saveDialog;
    }
}