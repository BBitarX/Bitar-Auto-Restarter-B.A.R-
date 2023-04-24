using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Bitar_Auto_Restarter
{
    public static class Generic
    {

        public static void showInfo(string msg)
        {
            MessageBox.Show(msg, "B.A.R", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void showError(string msg)
        {
            MessageBox.Show(msg, "B.A.R", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static bool IsValidPath(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            try
            {
                Path.GetFullPath(path);
                return Directory.Exists(path) || File.Exists(path);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Process StartProcess(string exePath)
        {
            
            Process p = new Process();
            p.StartInfo.FileName = exePath;
            p.StartInfo.CreateNoWindow = false;
            p.Start();

            return p;
        }
        public static string GetProcessName(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("Invalid path");
            }
            try
            {
                Path.GetFullPath(path);
                if (File.Exists(path) && Path.GetExtension(path).Equals(".exe", StringComparison.OrdinalIgnoreCase))
                {
                    return Path.GetFileNameWithoutExtension(path);
                }
                else
                {
                    throw new ArgumentException("Invalid executable path");
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Invalid path", ex);
            }
        }
    }
}
