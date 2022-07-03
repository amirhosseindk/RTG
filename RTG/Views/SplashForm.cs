using ADK.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTG.Views
{
    public partial class SplashForm : RTG.Infrastructure.Base.Forms.BaseForm
    {
        Bitmap img = new Bitmap(Properties.Resources.BCK);
        public SplashForm()
        {
            InitializeComponent();

            backgroundWorker.WorkerReportsProgress = true;

            backgroundWorker.WorkerSupportsCancellation = true;

            BitmapRegion.CreateControlRegion(this, img);
        }

        private bool open = true;

        private Thread _LoadDataThread;

        private ThreadStart _LoadDataThreadStart;

        private void SplashForm_Load(object sender, EventArgs e)
        {
            _LoadDataThreadStart = new ThreadStart(CheckVersion);

            _LoadDataThread = new Thread(_LoadDataThreadStart);

            _LoadDataThread.Start();

            backgroundWorker.RunWorkerAsync();
        }


        public void CheckVersion()
        {
            if (Persistence.Data.GetInfo.GetVersion() != AppSettings.Default.Version)
            {
                MessageBox.Show("Your Cheat Is Not Updated");
                open = false;
            }
        }


        protected override void OnLoad(EventArgs e)
        {

            ADK.Windows.API.AnimateWindow(
                this.Handle,
                2000,
                ConstValues.AW_ACTIVATE |
                ConstValues.AW_VER_POSITIVE |
                ConstValues.AW_SLIDE
                );

            base.OnLoad(e);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker =
                sender as BackgroundWorker;

            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(1);

                backgroundWorker.ReportProgress(i);

                if (backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(open!=true)
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }
    }
}
