using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillAllIeProcesses
{
    class ProcessMonitor
    {
        public class Process
        {
            public string Description
            {
                get
                {
                    var title = NativeInstance.MainWindowTitle;
                    if (title.Length == 0)
                    {
                        title = "Internet Explorer";
                    }
                    return title;
                }
            }
            public int Id { get { return NativeInstance.Id; } }

            private System.Diagnostics.Process NativeInstance;

            public Process(System.Diagnostics.Process process)
            {
                NativeInstance = process;
            }

            public static void KillProcessById(int processId)
            {
                var p = System.Diagnostics.Process.GetProcessById(processId);
                p.Kill();
                p.WaitForExit();
            }
        }

        public IEnumerable<Process> Processes;
        public bool IsEmpty
        {
            get
            {
                return Processes == null || Processes.Count() == 0;
            }
        }
        public bool HasProcess
        {
            get
            {
                return Processes != null && Processes.Count() > 0;
            }
        }

        private static readonly string IeProcName = "iexplore";

        public void Refresh()
        {
            Processes = System.Diagnostics.Process.GetProcessesByName(IeProcName).Select(proc => new Process(proc));
        }

        public void KillAllProcesses()
        {
            foreach (var proc in Processes)
            {
                Process.KillProcessById(proc.Id);
            }
        }      
    }
}
