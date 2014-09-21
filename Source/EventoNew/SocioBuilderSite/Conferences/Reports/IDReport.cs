using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace SocioBuilderSite.Conferences.Reports
{
    public partial class IDReport : DevExpress.XtraReports.UI.XtraReport
    {
        System.Web.UI.Page _CurrentPage = null;
        public System.Web.UI.Page CurrentPage
        {
            set { _CurrentPage = value; }
            get { return _CurrentPage; }
        }

        
        public void LoadData(BusinessLogicLayer.Entities.Persons.Person person)
        {
            if (CurrentPage != null)
            {
                string path = CurrentPage.MapPath("~/Conferences/Reports/participantID.jpg");
                System.Drawing.Bitmap m = new System.Drawing.Bitmap(path);
                this.xrPictureBox1.Image = m;
            }
            ParticipantNameLabel.Text = person.CompleteName;
            ParticipantCodeLabel.Text = "SSN" + person.BusinessEntityId;
        }
        public IDReport()
        {
            InitializeComponent();
        }

    }
}
