
using System.Diagnostics;

namespace ImageClassificator.Forms
{
    public partial class MainForm : Form
    {

        private AppSettings settings = AppSettings.Default;
        private readonly SynchronizationContext? synchronizationContext;

        public MainForm()
        {
            synchronizationContext = SynchronizationContext.Current;
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            labelHomePythonPath.Text = settings.PythonPath;
            labelSettingsPythonPath.Text = settings.PythonPath;
            labelHomeMobileNetPath.Text = settings.MobileNetPath;
            labelSettingsMobileNetPath.Text = settings.MobileNetPath;
            labelHomeInputPath.Text = settings.InputPath;
            labelSettingsInputPath.Text = settings.InputPath;
            labelHomeProcessingPath.Text = settings.ProcessingPath;
            labelSettingsProcessingPath.Text = settings.ProcessingPath;
            labelHomeOutputPath.Text = settings.OutputPath;
            labelSettingsOutputPath.Text = settings.OutputPath;
            labelHomeTagLanguage.Text = settings.TagLanguage;
            comboBoxSettingsTagLanguage.SelectedItem = settings.TagLanguage;
        }

        private void comboBoxSettingsTagLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.TagLanguage = comboBoxSettingsTagLanguage.SelectedItem.ToString();
            settings.Save();
            LoadSettings();
        }

        private void buttonHomeChangeSettings_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageSettings);
        }

        private void buttonSettingsChooseInputPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new()
            {
                InitialDirectory = settings.InputPath
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                settings.InputPath = folderBrowserDialog.SelectedPath;
                settings.Save();
                LoadSettings();
            }
        }

        private void buttonSettingsChooseProcessingPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new()
            {
                InitialDirectory = settings.ProcessingPath
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                settings.ProcessingPath = folderBrowserDialog.SelectedPath;
                settings.Save();
                LoadSettings();
            }
        }

        private void buttonSettingsChooseOutputPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new()
            {
                InitialDirectory = settings.OutputPath
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                settings.OutputPath = folderBrowserDialog.SelectedPath;
                settings.Save();
                LoadSettings();
            }
        }

        private void buttonSettingsChoosePythonPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new()
            {
                InitialDirectory = settings.PythonPath
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                settings.PythonPath = folderBrowserDialog.SelectedPath;
                settings.Save();
                LoadSettings();
            }
        }

        private void buttonSettingsChooseMobileNetPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new()
            {
                InitialDirectory = settings.MobileNetPath
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                settings.MobileNetPath = folderBrowserDialog.SelectedPath;
                settings.Save();
                LoadSettings();
            }
        }

        private void buttonHomeStart_Click(object sender, EventArgs e)
        {
            Process? process = null;
            if (buttonHomeStart.Text == "Starten")
            {
                string command = settings.PythonPath + "\\python.exe";
                string languageKey = new Dictionary<string, string> { { "Deutsch", "de" }, { "English", "en" } }[settings.TagLanguage];
                string arguments = ".\\Scripts\\ImageClassificatorCLI.py -i " + settings.InputPath + " -p " + settings.ProcessingPath + " -o " + settings.OutputPath + " -m " + settings.MobileNetPath + " -l " + languageKey;
                richTextBoxConsoleOutput.Text = "";
                WriteToConsole(command + " " + arguments);
                process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = command,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        Arguments = arguments,
                        CreateNoWindow = true
                    }
                };
                process.OutputDataReceived += (sender, args) => synchronizationContext?.Post(_ => WriteToConsole(args.Data), null);
                process.ErrorDataReceived += (sender, args) => synchronizationContext?.Post(_ => WriteToConsole(args.Data), null);
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                buttonHomeStart.Text = "Stoppen";
            }
            else
            {
                process?.Kill();
                process?.WaitForExit();
                buttonHomeStart.Text = "Starten";
            }
        }

        private void WriteToConsole(string? line)
        {
            richTextBoxConsoleOutput.AppendText(line);
            richTextBoxConsoleOutput.AppendText(Environment.NewLine);
            richTextBoxConsoleOutput.ScrollToCaret();
        }

    }
}
