using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitar_Auto_Restarter
{
    
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private static bool stayOnTop = false;
        private static bool timeLogs = false;
        private static bool started = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void cbTop_CheckedChanged(object sender, EventArgs e)
        {
            if (!stayOnTop)
            {
                MainForm mf = new MainForm();
                mf.TopMost = true;
                stayOnTop = true;
            }
            else if (stayOnTop)
            {
                MainForm mf = new MainForm();
                mf.TopMost = false;
                stayOnTop = false;
            }
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            


            if (!started)
            {
                string exePath = tbPath.Text;
                if (!Generic.IsValidPath(exePath))
                {
                    Generic.showError("Invalid path. Either empty or file does not exist.");
                    return;
                }

                started = true;
                lblStatus.ForeColor = System.Drawing.Color.FromArgb(100, 255, 100);
                lblStatus.Text = "Awaiting Crashes...";
                btnStart.Text = "Stop Auto Restarter";
                while (started)
                {
                    if (!(Process.GetProcessesByName(Generic.GetProcessName(exePath)).Length > 0))
                    {
                        string time = System.DateTime.Now.ToString("hh:mm:ss");
                        Generic.StartProcess(exePath);
                        if (cbLogs.Checked)
                        {
                            if (!File.Exists("crashlogs.txt"))
                            {
                                File.CreateText("crashlogs.txt");
                            }
                            
                            string msg = $"> Restarted {Generic.GetProcessName(exePath)} at {time}\n";
                            File.AppendAllText("crashlogs.txt", msg);
                        }
                        lblLastRestartTime.Text = time;
                    }
                    Thread.Sleep(5000);

                }
                
            }
            else if (started)
            {
                string exePath = tbPath.Text;
                

                started = false;
                
                lblStatus.ForeColor = System.Drawing.Color.FromArgb(255, 100, 100);
                lblStatus.Text = "Not Restarting";
                btnStart.Text = "Initiate Auto Restarter";
                
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
            ofd.Title = "Choose the target executable";
            string exePath = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                exePath = ofd.FileName;
            }
            tbPath.Text = exePath;

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/BBitarX");
        }
    }
}
