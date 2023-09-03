using Microsoft.VisualBasic;
using System.Diagnostics;

namespace AppScheduler
{
    public partial class AppScheduler : Form
    {
        private bool _selecting = false;
        private Dictionary<string, Process> _processes = new Dictionary<string, Process>();

        public AppScheduler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            _selecting = true;

            foreach (string file in openFileDialog1.FileNames)
            {
                if (string.IsNullOrEmpty(file) || file == "openFileDialog1")
                    break;

                try
                {
                    textBox1.Text += $"{file}{Environment.NewLine}";
                    textBox2.Text += $"{Interaction.InputBox($"What would you like the time for {file} activation to be (this can be changed later)", "App Scheduler")}{Environment.NewLine}";
                    textBox3.Text += $"{Environment.NewLine}";
                }
                catch
                {
                    MessageBox.Show("File time selection prompt was prematurely closed and has defaulted to time 8:00");
                    textBox1.Text += $"{file}{Environment.NewLine}";
                    textBox2.Text += $"{"8:00 AM"}{Environment.NewLine}";
                    textBox3.Text += $"{Environment.NewLine}";
                }
            }

            _selecting = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }

            if (_selecting)
                return;

            foreach (string file in textBox1.Lines)
            {
                if (string.IsNullOrEmpty(file))
                    continue;

                if (!Path.IsPathFullyQualified(file))
                    throw new ArgumentException($"File path {file} cannot be parsed, and is not valid.");

                if (textBox2.Lines.Length <= Array.IndexOf(textBox1.Lines, file))
                    continue;

                if (!DateTime.TryParse(textBox2.Lines[Array.IndexOf(textBox1.Lines, file)], out DateTime startTime))
                    continue;

                if ((checkBox1.Checked && DateTime.Now.ToString("HH:mm:ss:f") == startTime.ToString("HH:mm:ss:f")) ||
                    (!checkBox1.Checked && DateTime.Now.ToString("HH:mm:ss") == startTime.ToString("HH:mm:ss")))
                {
                    if (_processes.TryGetValue(file, out Process proc))
                    {
                        proc.Start();
                        continue;
                    }

                    Process nproc = new Process();
                    nproc.StartInfo.UseShellExecute = true;
                    nproc.StartInfo.FileName = file;
                    nproc.StartInfo.Arguments = textBox3.Lines.Length > Array.IndexOf(textBox1.Lines, file)
                        ? textBox3.Lines[Array.IndexOf(textBox1.Lines, file)]
                        : string.Empty;

                    _processes[file] = nproc;
                    nproc.Start();
                    continue;
                }

                if (textBox4.Lines.Length <= Array.IndexOf(textBox1.Lines, file))
                    continue;

                if (!DateTime.TryParse(textBox4.Lines[Array.IndexOf(textBox1.Lines, file)], out DateTime endTime))
                    continue;

                if ((checkBox1.Checked && DateTime.Now.ToString("HH:mm:ss:f") == endTime.ToString("HH:mm:ss:f")) ||
                    (!checkBox1.Checked && DateTime.Now.ToString("HH:mm:ss") == endTime.ToString("HH:mm:ss")))
                {
                    if (_processes.TryGetValue(file, out Process proc))
                        proc.Kill();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                button2.Text = "Resume";
            }
            else
            {
                timer1.Start();
                button2.Text = "Pause";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                timer1.Interval = 50;
            }
            else
            {
                timer1.Interval = 400;
            }
        }
    }
}