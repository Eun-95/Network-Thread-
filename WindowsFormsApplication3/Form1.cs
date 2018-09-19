using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using WindowsFormsApplication1;
//실제 스레드 사용하여 작동하는 부분
namespace WindowsFormsApplication3
{
    public partial class Form1_FormClosing : Form
    {
        bool Runflags = true;
        Thread RaceThread = null;


        public Form1_FormClosing()
        {
            InitializeComponent();
        }
        private void btnReceive_Click(object sender, EventArgs e)
        {
            RaceThread = new Thread(ReceiveData);
            RaceThread.Start();
        }
        private void ReceiveData()
        {

            while (Runflags)
            {
                Thread.Sleep(1);
                foreach (var proc in Process.GetProcesses())
                {
                    if (proc.ProcessName.ToString() == "WindowsFormsApplication1")
                    {
                        Runflags = false;
                        this.lblReceive02.Text = "실행되었고 값은" + WindowsFormsApplication1.Form1.SendName;
                    }
                }
            }
            RaceThread.Abort(); // Abort는 강제종료
        }

        private void Form1_FormClosing_Load(object sender, EventArgs e)
        {
            if (RaceThread != null)
                RaceThread.Abort();
        }
    }
}