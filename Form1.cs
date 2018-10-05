using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KillAllIeProcesses
{
    public partial class Form1 : Form
    {
        private Process[] Processes;
        private static readonly string IeProcName = "iexplore";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            ListViewItem itemAdd;
            ListView1.Items.Clear();
            Processes = Process.GetProcessesByName(IeProcName);
            foreach (Process proc in Processes)
            {
                var title = proc.MainWindowTitle;
                if (title.Length == 0)
                {
                    title = "Internet Explorer";
                }
                itemAdd = ListView1.Items.Add(title);
                itemAdd.SubItems.Add(proc.Id.ToString());
            }
        }
        private void btnClose1_Click(object sender, System.EventArgs e) { }
        private void btnCloseAll_Click(object sender, System.EventArgs e) { }
        private void closing(object sender, System.ComponentModel.CancelEventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
    }
}
