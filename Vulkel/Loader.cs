using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO.Compression;
using static System.Windows.Forms.Application;
using System.Diagnostics;
using System.Threading;

namespace Vulkel
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        private async void Loader_Load(object sender, EventArgs e)
        {
            // Configuration
            var version = "alpha-0.0.4";
            //---------------------------//
            // Prevent the application open multiple time
            String thisprocessname = Process.GetCurrentProcess().ProcessName;

            if (Process.GetProcesses().Count(p => p.ProcessName == thisprocessname) > 1)
            {
                Application.Exit();
                return;
            }
            //--------------------------//
            // Change the Form (prevent byfron detection).
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < 10)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }
            this.Text = Name;

            // Make the bootstrapper always on top (topMost)
            this.TopMost = true;

            // start the loading interface
            slidingLoading.Start();

            // Checking for update
            slidingLoading.Interval = 50;
            loadingText.Text = "Checking for update...";

            await Task.Delay(5000);

            WebClient wb = new WebClient();
            string backendChecker = wb.DownloadString("https://raw.githubusercontent.com/codernocook/Vulkel/backend/versionControler.txt");

            var result = backendChecker.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            
            if (result[0] == version)
            {
                // Checking if some file got deleted or just not installed successfully
                if (!Directory.Exists("Monaco") || !File.Exists("Oxygen API.dll"))
                {
                    // check if the vulkel not deleted, and still exist
                    if (File.Exists("dllPack.zip"))
                    {
                        File.Delete("dllPack.zip");
                    }

                    // old version found, redownload it
                    loadingText.Text = "Downloading zip.";
                    slidingLoading.Interval = 5;
                    slidingLoading.Stop();

                    var clientDownloader = new WebClient();
                    clientDownloader.DownloadFile(result[1], "dllPack.zip");

                    loadingText.Text = "Downloaded zip.";
                    slidingLoading.Start();

                    // delete old file
                    loadingText.Text = "Deleting exist file.";
                    slidingLoading.Interval = 5;
                    slidingLoading.Stop();
                    if (File.Exists("Vulkel.exe"))
                    {
                        // if the `VulkelInstaller.exe` exist we will remove this
                        if (File.Exists("VulkelInstaller.exe"))
                        {
                            File.Delete("VulkelInstaller.exe");
                        }

                        // Change the current installer name
                        File.Move("Vulkel.exe", "VulkelInstaller.exe");
                    }
                    if (File.Exists("Vulkel.exe.config"))
                    {
                        File.Delete("Vulkel.exe.config");
                    }
                    if (File.Exists("Vulkel.pdb"))
                    {
                        File.Delete("Vulkel.pdb");
                    }
                    if (File.Exists("README.md"))
                    {
                        File.Delete("README.md");
                    }
                    if (Directory.Exists("Monaco"))
                    {
                        Directory.Delete("Monaco", true);
                    }
                    if (File.Exists("Oxygen API.dll"))
                    {
                        File.Delete("Oxygen API.dll");
                    }
                    if (!Directory.Exists("scripts"))
                    {
                        Directory.CreateDirectory("scripts");
                    }

                    // unzip the download file
                    loadingText.Text = "Unzip.";
                    slidingLoading.Interval = 5;
                    slidingLoading.Stop();
                    string zipPath = @".\dllPack.zip";
                    string extractPath = @".\";

                    ZipFile.ExtractToDirectory(zipPath, extractPath);


                    // delete zip
                    loadingText.Text = "Delete old file.";
                    slidingLoading.Interval = 5;
                    slidingLoading.Stop();
                    if (!Directory.Exists("scripts"))
                    {
                        Directory.CreateDirectory("scripts");
                    }
                    if (File.Exists("dllPack.zip"))
                    {
                        File.Delete("dllPack.zip");
                    }
                    if (File.Exists("Oxygen_API.dll"))
                    {
                        File.Move("Oxygen_API.dll", "Oxygen API.dll");
                    };
                    slidingLoading.Interval = 5;
                    slidingLoading.Start();
                    if (File.Exists("VulkelInstaller.exe"))
                    {
                        // Run the new version of Vulkel
                        System.Diagnostics.Process.Start("Vulkel.exe");

                        // Stop the current installer
                        Application.Exit();

                        // delete the current Installer
                        //File.Delete("VulkelInstaller.exe"); // this not work because we stop the application before running this
                    }
                    return;
                }

                // Start installing dll
                loadingText.Text = "Installing dll.";
                slidingLoading.Interval = 10;
                slidingLoading.Stop();

                // make sure the name of the dll is Oxygen API
                if (File.Exists("Oxygen_API.dll"))
                {
                    File.Move("Oxygen_API.dll", "Oxygen API.dll");
                };

                // Delete old dll
                if (File.Exists("Oxygen API.dll"))
                {
                    File.Delete("Oxygen API.dll");
                }

                // alright nothing wrong we can continue downloading the dll
                var client = new WebClient();
                client.DownloadFile(result[2], "Oxygen API.dll");

                if (File.Exists("Oxygen_API.dll"))
                {
                    File.Move("Oxygen_API.dll", "Oxygen API.dll");
                };

                loadingText.Text = "Checking file.";
                slidingLoading.Interval = 2;
                slidingLoading.Start();
                // check if the scripts folder exist
                if (!File.Exists("scripts"))
                {
                    Directory.CreateDirectory("scripts");
                }

                // make sure the old installer is removed
                if (File.Exists("VulkelInstaller.exe"))
                {
                    File.Delete("VulkelInstaller.exe");
                }
            }
            else
            {
                // check if the vulkel not deleted, and still exist
                if (File.Exists("dllPack.zip"))
                {
                    File.Delete("dllPack.zip");
                }

                // old version found, redownload it
                loadingText.Text = "Downloading zip.";
                slidingLoading.Interval = 5;
                slidingLoading.Stop();

                var clientDownloader_a = new WebClient();
                clientDownloader_a.DownloadFile(result[1], "dllPack.zip");

                loadingText.Text = "Downloaded zip.";
                slidingLoading.Start();

                // delete old file
                loadingText.Text = "Deleting exist file.";
                slidingLoading.Interval = 5;
                slidingLoading.Stop();
                if (File.Exists("Vulkel.exe"))
                {
                    // if the `VulkelInstaller.exe` exist we will remove this
                    if (File.Exists("VulkelInstaller.exe"))
                    {
                        File.Delete("VulkelInstaller.exe");
                    }

                    // Change the current installer name
                    File.Move("Vulkel.exe", "VulkelInstaller.exe");
                }
                if (File.Exists("Vulkel.exe.config"))
                {
                    File.Delete("Vulkel.exe.config");
                }
                if (File.Exists("Vulkel.pdb"))
                {
                    File.Delete("Vulkel.pdb");
                }
                if (File.Exists("README.md"))
                {
                    File.Delete("README.md");
                }
                if (Directory.Exists("Monaco"))
                {
                    Directory.Delete("Monaco", true);
                }
                if (File.Exists("Oxygen API.dll"))
                {
                    File.Delete("Oxygen API.dll");
                }
                if (!Directory.Exists("scripts"))
                {
                    Directory.CreateDirectory("scripts");
                }

                // unzip the download file
                loadingText.Text = "Unzip.";
                slidingLoading.Interval = 5;
                slidingLoading.Stop();
                string zipPath = @".\dllPack.zip";
                string extractPath = @".\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);


                // delete zip
                loadingText.Text = "Delete old file.";
                slidingLoading.Interval = 5;
                slidingLoading.Stop();
                if (!Directory.Exists("scripts"))
                {
                    Directory.CreateDirectory("scripts");
                }
                if (File.Exists("dllPack.zip"))
                {
                    File.Delete("dllPack.zip");
                }
                if (File.Exists("Oxygen_API.dll"))
                {
                    File.Move("Oxygen_API.dll", "Oxygen API.dll");
                };
                slidingLoading.Interval = 5;
                slidingLoading.Start();
                if (File.Exists("VulkelInstaller.exe"))
                {
                    // Run the new version of Vulkel
                    System.Diagnostics.Process.Start("Vulkel.exe");

                    // Stop the current installer
                    Application.Exit();

                    // delete the current Installer
                    //File.Delete("VulkelInstaller.exe"); // this not work because we stop the application before running this
                }
            }

            // patch due to auto restart sliding function
            var preventCrashBug = false;
            Task.Run(() =>
            {
                while (true)
                {
                    if (panel_slidingProcess.Width >= mainPanel.Width && preventCrashBug == false)
                    {
                        preventCrashBug = true;
                        panel_slidingProcess.Width = mainPanel.Width;
                        slidingLoading.Stop();
                        Thread thread = new Thread(() =>
                        {
                            Application.Run(new Vulkel());
                        });
                        thread.SetApartmentState(ApartmentState.STA);
                        thread.Start();
                        this.Invoke(new Action(() => { this.Close(); }));
                        break; // Prevent this loop lagging the application
                    }
                }
            });
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool slidingCheck = false;
        private void slidingLoading_Tick(object sender, EventArgs e)
        {
            panel_slidingProcess.Width += 1;

            // Checking for update interface
            if (panel_slidingProcess.Width >= mainPanel.Width / 4)
            {
                if (slidingCheck == true) return;
                slidingCheck = true;
                loadingText.Text = "Installing dll.";
                slidingLoading.Interval = 10;
            }

            // Installing dll & new update interface
            if (panel_slidingProcess.Width >= mainPanel.Width)
            {
                panel_slidingProcess.Width = mainPanel.Width;
                slidingLoading.Stop();
                Thread thread = new Thread(() =>
                {
                    Application.Run(new Vulkel());
                });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                this.Invoke(new Action(() => { this.Close(); }));
            }
        }

        private Point lastPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void loadingText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
