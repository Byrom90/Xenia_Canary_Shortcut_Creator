using System;
using System.Windows.Forms;
using IWshRuntimeLibrary;

// It's messy and has minimal error handling but it's functional (For me at least) - Byrom

namespace Xenia_Canary_Shortcut_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string XeniaExectuablePath = "";
        string GameExecutablePath = "";
        string GameName = "";
        string XeniaDirectory = "";
        string OrigConfigFilePath = "";

        private void BrowseXeniaBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Locate and select xenia_canary.exe";
            OFD.Filter = "All files (*.*)|*.*|Executable files (*.exe)|*.exe";
            OFD.FilterIndex = 2;
            OFD.RestoreDirectory = true;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                XeniaExectuablePath = OFD.FileName;
                CurrentXeniaPathLbl.Text = OFD.FileName;
                XeniaDirectory = System.IO.Path.GetDirectoryName(XeniaExectuablePath);
                OrigConfigFilePath = XeniaDirectory + "\\xenia-canary.config.toml";

                if (!System.IO.File.Exists(OrigConfigFilePath))
                {
                    MessageBox.Show("xenia-canary.config.toml was not found in the Xenia directory.\nPlease run Xenia at least once to allow it to create the default config.\nGenerating dedicated configs will be disabled until this issue is resolved.", "Error - Default Config Not Found!");
                    UseDediConfigCbox.Checked = false;
                    UseDediConfigCbox.Enabled = false;
                    ConfigFilePathLbl.Text = "Please run Xenia at least once to enable!";
                    ConfigFilePathLbl.Enabled = false;
                }
                else
                    ConfigFilePathLbl.Text = XeniaDirectory + "\\" + "UNDEFINED_GAME_Config.toml";

                BrowseGameBtn.Enabled = true;
            }

        }

        private void BrowseGameBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Locate and select the game executable (.xex)";
            OFD.Filter = "All files (*.*)|*.*|Executable files (*.xex)|*.xex|Executable files (*.exe)|*.exe"; // Also includes a filter for .exe files to accommodate dev builds
            OFD.FilterIndex = 2;
            OFD.RestoreDirectory = true;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                GameExecutablePath = OFD.FileName;
                CurrentGamePathLbl.Text = OFD.FileName;
            }
            GameNameTbox.Enabled = true;
        }

        private void GameNameTbox_TextChanged(object sender, EventArgs e)
        {
            // Update config file path
            if (XeniaDirectory != "")
            {
                GameName = GameNameTbox.Text;
                string TextToSet = XeniaDirectory + "\\" + GameNameTbox.Text + "_Config.toml";
                TextToSet = TextToSet.Replace(" ", "_");
                ConfigFilePathLbl.Text = TextToSet;
                if (GameName != "")
                    CreateShortcutBtn.Enabled = true;
                else
                    CreateShortcutBtn.Enabled = false;
            }
        }

        private void CreateShortcutBtn_Click(object sender, EventArgs e)
        {
            string shortcutLocation = "Launch " + GameNameTbox.Text + ".lnk";
            if (System.IO.File.Exists(shortcutLocation)) // Do not continue if a shortcut exists with the same name
            {
                MessageBox.Show("A shortcut using this name already exists!\nPlease enter a different game name or remove this shortcut to continue.", "Error - Shortcut Exists!");
                return;
            }
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);


            string LaunchParams = "\"" + GameExecutablePath + "\"";
            if (UseDediConfigCbox.Checked)
            {
                string NewConfigFilePath = XeniaDirectory + "\\" + GameNameTbox.Text + "_Config.toml";
                NewConfigFilePath = NewConfigFilePath.Replace(" ", "_");
                if (System.IO.File.Exists(NewConfigFilePath)) // Do not continue if a config file exists with the same name
                {
                    MessageBox.Show("A config file using this name already exists!\nPlease enter a different game name or remove this config to continue.", "Error - Config File Exists!");
                    return;
                }
                System.IO.File.Copy(OrigConfigFilePath, NewConfigFilePath);
                LaunchParams += " --config " + NewConfigFilePath;
            }
            if (FullscreenCbox.Checked)
                LaunchParams += " --fullscreen";

            shortcut.Description = "Launch " + GameNameTbox.Text + " using Xenia";   // The description of the shortcut
            shortcut.IconLocation = XeniaExectuablePath; // The shortcut icon. Setting this to the executable uses the embedded icon
            shortcut.TargetPath = XeniaExectuablePath; // The path of the file that will launch when the shortcut is run. Example: D:\EMULATORS\xenia\xenia_canary.exe
            shortcut.Arguments = LaunchParams; // All the extra parameters. Example: "D:\EMULATORS\xenia\GTA V\default.xex" --config D:\EMULATORS\xenia\GTA_V_Config.toml --fullscreen
            shortcut.Save(); // Example of completed shortcut target: D:\EMULATORS\xenia\xenia_canary.exe "D:\EMULATORS\xenia\GTA V\default.xex" --config D:\EMULATORS\xenia\GTA_V_Config.toml --fullscreen
        }
    }
}
