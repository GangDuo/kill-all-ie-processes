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
            UpdateList();
        }

        private void UpdateList()
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

        private void btnClose1_Click(object sender, System.EventArgs e)
        {
            try
            {
                int procID = System.Convert.ToInt32(ListView1.SelectedItems[0].SubItems[1].Text);
                Process tempProc = Process.GetProcessById(procID);
                tempProc.Kill();
                tempProc.WaitForExit();
            }
            catch
            {
                MessageBox.Show("Please select a process in the ListView before clicking this button." +
                    " Or the Process may have been closed by somebody.");
            }
            finally
            {
                UpdateList();
            }
        }
        private void btnCloseAll_Click(object sender, System.EventArgs e)
        {
            try
            {
                KillAllProcesses();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("No instances of Internet Explorer running.");
            }
            finally
            {
                UpdateList();
            }
        }

        private void KillAllProcesses()
        {
            foreach (Process proc in Processes)
            {
                proc.Kill();
                proc.WaitForExit();
            }
        }

        private void closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Processes == null || Processes.Length == 0)
            {
                return;
            }
            
            var result = MessageBox.Show("すべてのInternet Explorerプロセスを強制終了しますか？",
                "確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    try
                    {
                        KillAllProcesses();
                    }
                    catch { }
                    break;
                default:
                    MessageBox.Show("Internet Explorer強制終了を中止しました。");
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateList();
        }
    }
}
