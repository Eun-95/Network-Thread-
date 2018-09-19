using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;



namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        bool Runflags = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            while(Runflags)
            {
                System.Threading.Thread.Sleep(1);
                foreach(var proc in Process.GetProcesses())
                {
                    if (proc.ProcessName.ToString() == "WindowsFormsApplication1")
                    {
                        Runflags = false;
                        this.IbIReceive02.Text = "실행되었고 값은" + WindowsFormsApplication1.Form1.SendName;
                    }
                }
            }
        }
    }
}
