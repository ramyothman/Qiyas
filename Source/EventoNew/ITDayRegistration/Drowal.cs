using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;

namespace ITDayRegistration
{
    public partial class Drowal : DevExpress.XtraEditors.XtraForm
    {
        public delegate void DrowCompleted();
        public event DrowCompleted DrowCompletedEvent;
        public Drowal()
        {
            InitializeComponent();
            DrowCompletedEvent += new DrowCompleted(DrowCompleted_Handler);
        }

        public void DrowCompleted_Handler()
        {
            

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Int32.TryParse(txtMax.Text, out max);
            backgroundWorker1.RunWorkerAsync();
        }
        string name = "";
        int id = 0;
        int min = 0;
        int max = 500;
        int winner = 0;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker1.ReportProgress(100);
            Random r = new Random();
            winner = r.Next(1, max);
            //int max = BusinessLogicLayer.Common.GetMaxForQuickContacts();
            //name = "";
            //int count = 0;
            //while (string.IsNullOrEmpty(name))
            //{
            //    id = r.Next(1, max);
            //    name = BusinessLogicLayer.Common.GetUserForQuickContacts(id);
            //    count++;
            //    if (count == 5)
            //        break;
            //}
            //BusinessLogicLayer.Common.
            Thread.Sleep(3000);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            marqueeProgressBarControl1.Visible = false;
            lblName.Text = name;
            lblNumber.Text = id.ToString();
            //lblName.Visible = true;
            //lblNumber.Visible = true;
            WinnerLabel.Text = winner.ToString();
            WinnerLabel.Visible = true;
            this.Refresh();
            if (DrowCompletedEvent != null)
            {
                DrowCompletedEvent.Invoke();
            }
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblNumber.Text = "";
            lblName.Text = "";
            marqueeProgressBarControl1.Visible = true;
            
        }

        private void Drowal_Load(object sender, EventArgs e)
        {
            this.Update();
            this.Refresh();
        }
    }
}