namespace Bitar_Auto_Restarter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblLastRestartTime = new MetroFramework.Controls.MetroLabel();
            this.tbPath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.cbLogs = new MetroFramework.Controls.MetroCheckBox();
            this.cbTop = new MetroFramework.Controls.MetroCheckBox();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnHelp = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(9, 250);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Restarter Status: ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblStatus.Location = new System.Drawing.Point(115, 250);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(94, 19);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Not Restarting";
            this.lblStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblStatus.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(244, 250);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(112, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Last Restart Time:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblLastRestartTime
            // 
            this.lblLastRestartTime.AutoSize = true;
            this.lblLastRestartTime.Location = new System.Drawing.Point(362, 250);
            this.lblLastRestartTime.Name = "lblLastRestartTime";
            this.lblLastRestartTime.Size = new System.Drawing.Size(41, 19);
            this.lblLastRestartTime.Style = MetroFramework.MetroColorStyle.Magenta;
            this.lblLastRestartTime.TabIndex = 3;
            this.lblLastRestartTime.Text = "None";
            this.lblLastRestartTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tbPath
            // 
            // 
            // 
            // 
            this.tbPath.CustomButton.Image = null;
            this.tbPath.CustomButton.Location = new System.Drawing.Point(304, 1);
            this.tbPath.CustomButton.Name = "";
            this.tbPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPath.CustomButton.TabIndex = 1;
            this.tbPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPath.CustomButton.UseSelectable = true;
            this.tbPath.CustomButton.Visible = false;
            this.tbPath.Lines = new string[0];
            this.tbPath.Location = new System.Drawing.Point(160, 91);
            this.tbPath.MaxLength = 32767;
            this.tbPath.Name = "tbPath";
            this.tbPath.PasswordChar = '\0';
            this.tbPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPath.SelectedText = "";
            this.tbPath.SelectionLength = 0;
            this.tbPath.SelectionStart = 0;
            this.tbPath.ShortcutsEnabled = true;
            this.tbPath.Size = new System.Drawing.Size(326, 23);
            this.tbPath.Style = MetroFramework.MetroColorStyle.Magenta;
            this.tbPath.TabIndex = 4;
            this.tbPath.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbPath.UseSelectable = true;
            this.tbPath.UseStyleColors = true;
            this.tbPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(23, 89);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(104, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Server Path:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(132, 91);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(27, 23);
            this.btnBrowse.Style = MetroFramework.MetroColorStyle.Magenta;
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "...";
            this.btnBrowse.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.UseStyleColors = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cbLogs
            // 
            this.cbLogs.AutoSize = true;
            this.cbLogs.Location = new System.Drawing.Point(132, 135);
            this.cbLogs.Name = "cbLogs";
            this.cbLogs.Size = new System.Drawing.Size(188, 15);
            this.cbLogs.Style = MetroFramework.MetroColorStyle.Magenta;
            this.cbLogs.TabIndex = 7;
            this.cbLogs.Text = "Crash Time Logs (crashlogs.txt)";
            this.cbLogs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbLogs.UseSelectable = true;
            // 
            // cbTop
            // 
            this.cbTop.AutoSize = true;
            this.cbTop.Location = new System.Drawing.Point(362, 135);
            this.cbTop.Name = "cbTop";
            this.cbTop.Size = new System.Drawing.Size(83, 15);
            this.cbTop.Style = MetroFramework.MetroColorStyle.Magenta;
            this.cbTop.TabIndex = 8;
            this.cbTop.Text = "Stay on top";
            this.cbTop.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbTop.UseSelectable = true;
            this.cbTop.CheckedChanged += new System.EventHandler(this.cbTop_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(80, 180);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(186, 23);
            this.btnStart.Style = MetroFramework.MetroColorStyle.Magenta;
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Initiate Auto Restarter";
            this.btnStart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnStart.UseSelectable = true;
            this.btnStart.UseStyleColors = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(9, 227);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(364, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Made by BBitar#6302, Run as admin for admin perm targets";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(295, 180);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(160, 23);
            this.btnHelp.Style = MetroFramework.MetroColorStyle.Magenta;
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "Help";
            this.btnHelp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnHelp.UseSelectable = true;
            this.btnHelp.UseStyleColors = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 272);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbTop);
            this.Controls.Add(this.cbLogs);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.lblLastRestartTime);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.metroLabel1);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Bitar Auto Restarter (B.A.R)";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblLastRestartTime;
        private MetroFramework.Controls.MetroTextBox tbPath;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroCheckBox cbLogs;
        private MetroFramework.Controls.MetroCheckBox cbTop;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnHelp;
    }
}

