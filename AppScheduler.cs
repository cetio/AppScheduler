using Microsoft.VisualBasic;
using Microsoft.Win32;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;

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

            for (int i = 0; i < files.Lines.Length; i++)
            {
                string file = files.Lines[i];

                if (string.IsNullOrEmpty(file))
                    continue;

                if (startTimes.Lines.Length <= Array.IndexOf(files.Lines, file))
                    continue;

                if (!DateTime.TryParse(startTimes.Lines[Array.IndexOf(files.Lines, file)], out DateTime startTime))
                    continue;

                if ((useExactMsTimingsToolStripMenuItem.Checked && DateTime.Now.ToString("HH:mm:ss:f") == startTime.ToString("HH:mm:ss:f")) ||
                    (!useExactMsTimingsToolStripMenuItem.Checked && DateTime.Now.ToString("HH:mm:ss") == startTime.ToString("HH:mm:ss")))
                {
                    if (!Path.IsPathFullyQualified(file))
                    {
                        MessageBox.Show($"File path {file} is not valid.");
                        continue;
                    }

                    if (Processes.TryGetValue(file + i, out Process proc))
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

                    if (runAsAdministratorToolStripMenuItem.Checked)
                        nproc.StartInfo.Verb = "runas";

                    if (fullscreenProcessToolStripMenuItem.Checked)
                        nproc.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;

                    if (minimizeProcessToolStripMenuItem.Checked)
                        nproc.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;

                    Processes[file + i] = nproc;
                    nproc.Start();
                    continue;
                }

                if (endTimes.Lines.Length <= Array.IndexOf(files.Lines, file))
                    continue;

                if (!DateTime.TryParse(endTimes.Lines[Array.IndexOf(files.Lines, file)], out DateTime endTime))
                    continue;

                if ((useExactMsTimingsToolStripMenuItem.Checked && DateTime.Now >= endTime) ||
                    (!useExactMsTimingsToolStripMenuItem.Checked && DateTime.Now >= endTime))
                {
                    if (Processes.TryGetValue(file + i, out Process proc))
                        KillAllProcessesSpawnedBy(proc, true);

                    if (nuclearModeToolStripMenuItem.Checked)
                        KillAllProcessesSpawnedBy(Process.GetCurrentProcess(), false);
                }
            }
        }

        private static void KillAllProcessesSpawnedBy(Process parentProcess, bool killSelf)
        {
            if (killSelf)
                parentProcess.Kill();

            // NOTE: Process Ids are reused!
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(
                "SELECT * " +
                "FROM Win32_Process " +
                "WHERE ParentProcessId=" + parentProcess.Id);
            ManagementObjectCollection collection = searcher.Get();
            if (collection.Count > 0)
            {
                foreach (var item in collection)
                {
                    int childProcessId = (int)(uint)item["ProcessId"];
                    if (childProcessId != Process.GetCurrentProcess().Id)
                    {
                        Process childProcess = Process.GetProcessById(childProcessId);

                        KillAllProcessesSpawnedBy(childProcess, false);
                        childProcess.Kill();
                    }
                }
            }
        }

        private void useExactMS_CheckedChanged(object sender, EventArgs e)
        {
            if (useExactMsTimingsToolStripMenuItem.Checked)
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

                string[] files = this.files.Lines;
                string[] args = cmdArgs.Lines;

                files[i] = FindExecutable(file);
                if (args[i].Length > 0)
                    args[i] += " ";
                args[i] += $"\"{file}\"";

                this.files.Lines = files;
                cmdArgs.Lines = args;
            }
        }

        private string FindExecutable(string path)
        {
            var executable = new StringBuilder(1024);
            FindExecutable(path, string.Empty, executable);
            return executable.ToString();
        }

        [DllImport("shell32.dll", EntryPoint = "FindExecutable")]
        private static extern long FindExecutable(string lpFile, string lpDirectory, StringBuilder lpResult);

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
            _noScheduling = true;

            files.Text.TrimEnd();
            startTimes.Text.TrimEnd();
            endTimes.Text.TrimEnd();
            cmdArgs.Text.TrimEnd();

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

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();

            if (fileDialog.FileNames.Length != 4)
                throw new ArgumentException("All 4 save files must be loaded at once.");

            files.Text = File.ReadAllText(fileDialog.FileNames[0]);
            startTimes.Text = File.ReadAllText(fileDialog.FileNames[1]);
            endTimes.Text = File.ReadAllText(fileDialog.FileNames[2]);
            cmdArgs.Text = File.ReadAllText(fileDialog.FileNames[3]);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "\\files.txt", files.Text);
            File.WriteAllText(Application.StartupPath + "\\startTimes.txt", startTimes.Text);
            File.WriteAllText(Application.StartupPath + "\\endTimes.txt", endTimes.Text);
            File.WriteAllText(Application.StartupPath + "\\cmdArgs.txt", cmdArgs.Text);
        }

        private void createManifestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (createManifestToolStripMenuItem.Checked)
            {
                File.WriteAllText(Application.StartupPath + "\\autoload_manifest", string.Empty);
            }
            else
            {
                File.Delete(Application.StartupPath + "\\autoload_manifest");
            }
        }

        private void AppScheduler_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + "\\autoload_manifest"))
                return;

            if (File.Exists(Application.StartupPath + "\\files.txt"))
                files.Text = File.ReadAllText(Application.StartupPath + "\\files.txt");
            else
                MessageBox.Show("Manifest exists but files save does not.");

            if (File.Exists(Application.StartupPath + "\\startTimes.txt"))
                startTimes.Text = File.ReadAllText(Application.StartupPath + "\\startTimes.txt");
            else
                MessageBox.Show("Manifest exists but startTimes save does not.");

            if (File.Exists(Application.StartupPath + "\\endTimes.txt"))
                endTimes.Text = File.ReadAllText(Application.StartupPath + "\\endTimes.txt");
            else
                MessageBox.Show("Manifest exists but endTimes save does not.");

            if (File.Exists(Application.StartupPath + "\\cmdArgs.txt"))
                cmdArgs.Text = File.ReadAllText(Application.StartupPath + "\\cmdArgs.txt");
            else
                MessageBox.Show("Manifest exists but cmdArgs save does not.");
        }

        private void pauseSchedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pauseSchedulingToolStripMenuItem.Checked)
            {
                scheduler.Stop();
            }
            else
            {
                scheduler.Start();
            }
        }

        private void runAtStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (runAtStartupToolStripMenuItem.Checked)
                rk.SetValue("AppScheduler", Application.ExecutablePath);
            else
                rk.DeleteValue("AppScheduler", false);
        }
    }
}