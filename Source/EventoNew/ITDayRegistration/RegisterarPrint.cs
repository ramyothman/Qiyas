using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ITDayRegistration
{
    public partial class RegisterarPrint : DevExpress.XtraReports.UI.XtraReport
    {
        public RegisterarPrint()
        {
            InitializeComponent();
        }
        public void LoadData(int id, string name,string department)
        {
            xcellId.Text = id.ToString();
            xcellName.Text = name;
            xcellDepartment.Text = department;
        }
    }
}
