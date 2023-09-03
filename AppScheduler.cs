using Microsoft.VisualBasic;
using System.Diagnostics;

namespace AppScheduler
{
    public partial class AppScheduler : Form
    {
        private Dictionary<string, Process> Processes = new Dictionary<string, Process>();
        private bool _noScheduling = false;

        public AppScheduler()
        {
            InitializeComponent();
        }

        private void addFiles_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
            _noScheduling = true;

            foreach (string file in fileDialog.FileNames)
            {
                if (string.IsNullOrEmpty(file))
                    break;

                try
                {
                    files.Text += $"{file}{Environment.NewLine}";
                    startTimes.Text += $"{Interaction.InputBox($"What would you like the time for {file} activation to be (this can be changed later)", "App Scheduler")}{Environment.NewLine}";
                    cmdArgs.Text += $"{Environment.NewLine}";
                }
                catch
                {
                    MessageBox.Show("File time selection prompt was prematurely closed and has defaulted to time 8:00");
                    files.Text += $"{file}{Environment.NewLine}";
                    startTimes.Text += $"{"8:00 AM"}{Environment.NewLine}";
                    cmdArgs.Text += $"{Environment.NewLine}";
                }
            }

            _noScheduling = false;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void scheduler_Tick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }

            if (_noScheduling)
                return;

            foreach (string file in files.Lines)
            {
                if (string.IsNullOrEmpty(file))
                    continue;

                if (!Path.IsPathFullyQualified(file))
                    continue;

                if (startTimes.Lines.Length <= Array.IndexOf(files.Lines, file))
                    continue;

                if (!DateTime.TryParse(startTimes.Lines[Array.IndexOf(files.Lines, file)], out DateTime startTime))
                    continue;

                if ((useExactMS.Checked && DateTime.Now.ToString("HH:mm:ss:f") == startTime.ToString("HH:mm:ss:f")) ||
                    (!useExactMS.Checked && DateTime.Now.ToString("HH:mm:ss") == startTime.ToString("HH:mm:ss")))
                {
                    if (Processes.TryGetValue(file, out Process proc))
                    {
                        proc.Start();
                        continue;
                    }

                    Process nproc = new Process();
                    nproc.StartInfo.UseShellExecute = true;
                    nproc.StartInfo.FileName = file;
                    nproc.StartInfo.Arguments = cmdArgs.Lines.Length > Array.IndexOf(files.Lines, file)
                        ? cmdArgs.Lines[Array.IndexOf(files.Lines, file)]
                        : string.Empty;

                    Processes[file] = nproc;
                    nproc.Start();
                    continue;
                }

                if (endTimes.Lines.Length <= Array.IndexOf(files.Lines, file))
                    continue;

                if (!DateTime.TryParse(endTimes.Lines[Array.IndexOf(files.Lines, file)], out DateTime endTime))
                    continue;

                if ((useExactMS.Checked && DateTime.Now.ToString("HH:mm:ss:f") == endTime.ToString("HH:mm:ss:f")) ||
                    (!useExactMS.Checked && DateTime.Now.ToString("HH:mm:ss") == endTime.ToString("HH:mm:ss")))
                {
                    if (Processes.TryGetValue(file, out Process proc))
                        proc.Kill();
                }
            }
        }

        private void pauseResume_Click(object sender, EventArgs e)
        {
            if (scheduler.Enabled)
            {
                scheduler.Stop();
                pauseResume.Text = "Resume";
            }
            else
            {
                scheduler.Start();
                pauseResume.Text = "Pause";
            }
        }

        private void useExactMS_CheckedChanged(object sender, EventArgs e)
        {
            if (useExactMS.Checked)
            {
                scheduler.Interval = 90;
            }
            else
            {
                scheduler.Interval = 400;
            }
        }

        private void parseFilesAssociation_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < files.Lines.Length; i++)
            {
                string file = this.files.Lines[i];

                if (string.IsNullOrEmpty(file))
                    continue;

                Process nproc = new Process
                {
                    StartInfo = { UseShellExecute = true, FileName = file }
                };

                nproc.Start();
                string path = nproc.MainModule.FileName;
                nproc.Kill();

                string[] files = this.files.Lines;
                string[] args = cmdArgs.Lines;

                files[i] = path;
                if (args[i].Length > 0)
                    args[i] += " ";
                args[i] += $"\"{file}\"";

                this.files.Lines = files;
                cmdArgs.Lines = args;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveDialog.FileName = "files.txt";
            saveDialog.ShowDialog();
            File.WriteAllText(saveDialog.FileName, files.Text);

            saveDialog.FileName = "startTimes.txt";
            saveDialog.ShowDialog();
            File.WriteAllText(saveDialog.FileName, startTimes.Text);

            saveDialog.FileName = "endTimes.txt";
            saveDialog.ShowDialog();
            File.WriteAllText(saveDialog.FileName, endTimes.Text);

            saveDialog.FileName = "cmdArgs.txt";
            saveDialog.ShowDialog();
            File.WriteAllText(saveDialog.FileName, cmdArgs.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();

            if (fileDialog.FileNames.Length != 4)
                throw new ArgumentException("All 4 save files must be loaded at once.");

            files.Text = File.ReadAllText(fileDialog.FileNames[0]);
            startTimes.Text = File.ReadAllText(fileDialog.FileNames[1]);
            endTimes.Text = File.ReadAllText(fileDialog.FileNames[2]);
            cmdArgs.Text = File.ReadAllText(fileDialog.FileNames[3]);
        }
    }
}