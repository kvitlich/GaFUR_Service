using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sys_Watcher_GaFUR
{
    public partial class Form1 : Form
    {

        private int dataCount;
        private int interval;
#if DEBUG
        public Service1 service;
        public Form1(Service1 service)
        {
            this.service = service;
            InitializeComponent();
            mainGrid.ReadOnly = true;
        }

        private async void Start(object sender, EventArgs e)
        {
            try
            {
                if (!BeforeStart())
                    return;

                startButton.Enabled = false;
                mainGrid.Rows.Clear();


                List<string> result = await Task.Run(() => service.OnDebug(Int32.Parse(dataVolume.Text), Int32.Parse(meteringInterval.Text)));
                MessageBox.Show("Готово!");
                double middleSumm = 0;
                for (int i = 0; i < result.Count; i++)
                {
                    mainGrid.Rows.Add(result[i]);
                    middleSumm += Double.Parse(result[i]);
                }
                middleSumm /= result.Count;
                middleValue.Text = middleSumm.ToString();
                startButton.Enabled = true;
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
#else
        ServiceBase[] serviceBases;
        public Form1(ServiceBase[] serviceBases)
        {
            this.serviceBases = serviceBases;
            InitializeComponent();
        }

        private void Start(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            ServiceBase.Run(serviceBases);
        }

#endif
        private void dataVolume_TextChanged(object sender, EventArgs e)
        {

        }
        private void meteringInterval_TextChanged(object sender, EventArgs e)
        {
            //meteringInterval.Text;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool BeforeStart()
        {
            if (!Int32.TryParse(dataVolume.Text, out dataCount))
            {
                MessageBox.Show("Количество измерений вводятся с помощью типа int или long!");
                return false;
            }
            else if (!Int32.TryParse(meteringInterval.Text, out dataCount))
            {
                MessageBox.Show("Интервал тоже должен быть типа int или long!");
                return false;
            }
            //meteringInterval.Text;
            return true;
        }
    }
}

////Installs and starts the service
//ServiceInstaller.InstallAndStart("MyServiceName", "MyServiceDisplayName", "C:\\PathToServiceFile.exe");

////Removes the service
//ServiceInstaller.Uninstall("MyServiceName");

////Checks the status of the service
//ServiceInstaller.GetServiceStatus("MyServiceName");

////Starts the service
//ServiceInstaller.StartService("MyServiceName");

////Stops the service
//ServiceInstaller.StopService("MyServiceName");

////Check if service is installed
//ServiceInstaller.ServiceIsInstalled("MyServiceName");