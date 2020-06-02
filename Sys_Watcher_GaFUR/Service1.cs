using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sys_Watcher_GaFUR
{
    public partial class Service1 : ServiceBase
    {
        private long counter = 0;
        private long i = 0;
        private Timer timer;
        private List<string> result = new List<string>();
        PerformanceCounter performanceCounter;
        public Service1()
        {
            InitializeComponent();
        }

        public List<string> OnDebug(int volume, int interval)
        {
            result = new List<string>();
            OnStart(null);
            i = 0;
            counter = volume;
            int now = DateTime.Now.Millisecond;
            performanceCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            do
            {
                //if (DateTime.Now.Millisecond <= now + interval)
                //{
                    if (!LookProccess())
                        break;
                    now = DateTime.Now.Millisecond;
                //}
                Thread.Sleep(interval);
            } while (true);
            
            return result;
        }

        private bool LookProccess()
        {
            if (i >= counter)
            {
                return false;
            }
            
            
            result.Add(performanceCounter.NextValue().ToString());

            i++;
            return true;
        }

        protected override void OnStart(string[] args) 
        {
            Console.WriteLine(args);
        }

        protected override void OnStop()
        {
        }
    }
}
