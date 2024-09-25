using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PreTool
{
    public partial class PreToolMain : Form
    {
        public PreToolMain()
        {
            InitializeComponent();
            // Initalize the Activation System - uses devicetoolAIO.jar
            if (!File.Exists("resources/devicetool.jar"))
            {
                File.WriteAllBytes(Directory.GetCurrentDirectory() + @"/resources/devicetool.jar", Properties.Resources.devicetool);
            }
        }

        // Check if a Palm Pre or HP Touchpad is connected to the user's computer
        private bool IsPalmPreDeviceConnected()
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "novacom";
                process.StartInfo.Arguments = "-l"; // Execute the connected devices list
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                return output.Contains("topaz-linux") || // HP Touchpad
                       output.Contains("broadway-linux") ||  // HP Veer
                       output.Contains("roadrunner-linux") || // HP/Palm Pre 2
                       output.Contains("pixie-linux") || // Palm Pixi
                       output.Contains("opal-linux") ||  // HP Touchpad GO
                       output.Contains("mantaray-linux") || // HP Pre 3
                       output.Contains("castle-linux"); // Palm Pre 1
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error detecting a device: {ex.Message}", "Did you install the Novacom Drivers or the SDK?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void activateBtn_Click(object sender, EventArgs e)
        {
            if (!IsPalmPreDeviceConnected())
            {
                MessageBox.Show("No palm/HP webOS devices are connected, connect a palm/HP webOS device to use this feature");
                return;
            }

            Process process = new Process();
            process.StartInfo.FileName = "java";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.Arguments = "-jar resources/devicetool.jar";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            try
            {
                process.Start();
                process.WaitForExit();

                using (StreamReader outputReader = process.StandardOutput)
                {
                    string line;
                    while ((line = outputReader.ReadLine()) != null)
                    {
                        ActivationLog.AppendText(line + "\r\n");
                    }
                }
                using (StreamReader errorReader = process.StandardError)
                {
                    string errorLine;
                    while ((errorLine = errorReader.ReadLine()) != null)
                    {
                        ActivationLog.AppendText("Error: " + errorLine + "\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
                ActivationLog.AppendText($"Exception: {ex.Message}\r\n");
            }

            this.progressBar1.Value = this.progressBar1.Minimum;
            this.ProgressBarTimer2.Start();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            int num = (int)this.IPKFileDiag.ShowDialog();
            this.ipkfileloc.Text = this.IPKFileDiag.FileName;
        }

        private void IPKInstBtn_Click(object sender, EventArgs e)
        {
            if (!IsPalmPreDeviceConnected())
            {
                MessageBox.Show("No palm/HP webOS devices are connected, connect a palm/HP webOS device to use this feature");
                return;
            }


            string ipkFilePath = this.ipkfileloc.Text;
            if (File.Exists(ipkFilePath))
            {
                InstallIPK(ipkFilePath);
            }
            else
            {
                Log("IPK file not found: " + ipkFilePath);
            }

            this.progressBar2.Value = this.progressBar2.Minimum;
            this.ProgressBarTimer.Start();
        }

        private void ProgressBarTimer_Tick(object sender, EventArgs e)
        {
            this.progressBar2.Increment(20);
            if (this.progressBar2.Value != this.progressBar2.Maximum)
                return;
            this.ProgressBarTimer.Stop();
        }

        private void ProgressBarTimer2_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(20);
            if (this.progressBar1.Value != this.progressBar1.Maximum)
                return;
            this.ProgressBarTimer2.Stop();
        }

        private async void InstallIPK(string ipkFilePath)
        {
            await Task.Run(() =>
            {
                try
                {
                    Log("Starting IPK installation for: " + ipkFilePath);

                    Process process = new Process();
                    process.StartInfo.FileName = "\"C:\\Program Files (x86)\\HP webOS\\SDK\\bin\\palm-install.bat\"";
                    process.StartInfo.Arguments = $"{ipkFilePath}";
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;

                    process.OutputDataReceived += (sender, args) => Log(args.Data);
                    process.ErrorDataReceived += (sender, args) => Log("Warnings: " + args.Data);

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    process.WaitForExit();

                    if (process.ExitCode == 0)
                    {
                        Log("Installation completed successfully for: " + ipkFilePath);
                    }
                    else
                    {
                        Log("Error: Installation failed with exit code " + process.ExitCode);
                    }
                }
                catch (Exception ex)
                {
                    Log("Error during installation: " + ex.Message);
                }
            });
        }

        private void Log(string message)
        {
            if (IPKLog.InvokeRequired)
            {
                IPKLog.Invoke(new Action(() => IPKLog.AppendText($"{DateTime.Now}: {message}\r\n")));
            }
            else
            {
                IPKLog.AppendText($"{DateTime.Now}: {message}\r\n");
            }
        }

        private void projBrowse_Click(object sender, EventArgs e)
        {
            int num = (int)this.AppProjDiag.ShowDialog();
            this.AppProjLoc.Text = this.AppProjDiag.SelectedPath;
        }


        private async void PackIPK(string appprojPath)
        {
            await Task.Run(() =>
            {
                try
                {
                    Log("Packing IPK: " + appprojPath);

                    Process process = new Process();
                    process.StartInfo.FileName = "\"C:\\Program Files (x86)\\HP webOS\\SDK\\bin\\palm-package.bat\"";
                    process.StartInfo.Arguments = $"{appprojPath}";
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;

                    process.OutputDataReceived += (sender, args) => Log(args.Data);
                    process.ErrorDataReceived += (sender, args) => Log("Warnings: " + args.Data);

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    process.WaitForExit();

                    if (process.ExitCode == 0)
                    {
                        Log("Packing complete for: " + appprojPath);
                    }
                    else
                    {
                        Log("Error: Packing failed with exit code " + process.ExitCode);
                    }
                }
                catch (Exception ex)
                {
                    Log("Error during IPK Packing: " + ex.Message);
                }
            });
        }


        private void packipkBtn_Click(object sender, EventArgs e)
        {
            string appprojPath = this.AppProjLoc.Text;
            if (Directory.Exists(appprojPath))
            {
                PackIPK(appprojPath);
            }
            else
            {
                Log("App Project not found: " + appprojPath);
            }

            this.progressBar3.Value = this.progressBar3.Minimum;
            this.ProgressBarTimer3.Start();
        }

        private void ProgressBarTimer3_Tick(object sender, EventArgs e)
        {
            this.progressBar3.Increment(20);
            if (this.progressBar3.Value != this.progressBar3.Maximum)
                return;
            this.ProgressBarTimer3.Stop();
        }
    }
}