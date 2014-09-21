using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace ITDayRegistration
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bbIRegistration_ItemClick(object sender, ItemClickEventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbIRegistrars_ItemClick(object sender, ItemClickEventArgs e)
        {
            RegistrationsView frm = new RegistrationsView();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            defaultLookAndFeel1.LookAndFeel.SkinName = "Springtime";
            //RegisterForm frm = new RegisterForm();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void btnDrowal_ItemClick(object sender, ItemClickEventArgs e)
        {
            Drowal frm = new Drowal();
            frm.ShowDialog();
        }
    }
}