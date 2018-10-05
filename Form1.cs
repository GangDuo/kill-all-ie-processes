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
        private ProcessMonitor processMonitor = new ProcessMonitor();

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
            processMonitor.Refresh();
            foreach (var proc in processMonitor.Processes)
            {
                itemAdd = ListView1.Items.Add(proc.Description);
                itemAdd.SubItems.Add(proc.Id.ToString());
            }
        }

        private void btnClose1_Click(object sender, System.EventArgs e)
        {
            try
            {
                int procID = System.Convert.ToInt32(ListView1.SelectedItems[0].SubItems[1].Text);
                ProcessMonitor.Process.KillProcessById(procID);
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
                processMonitor.KillAllProcesses();
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

        private void closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (processMonitor.IsEmpty)
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
                        processMonitor.KillAllProcesses();
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
