using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using SocioBuilderSite.Code.RbmSecurity;

namespace SocioBuilderSite.Controls.Conference
{
    public partial class MyAbstracts : System.Web.UI.UserControl
    {
        public BusinessLogicLayer.Entities.Persons.Person CurrentSpeaker
        {
            get
            {
                if (Session["CurrentSpeaker"] == null)
                {
                    Session["CurrentSpeaker"] = SecurityManager.getUser(this.Page);
                }
                return Session["CurrentSpeaker"] as BusinessLogicLayer.Entities.Persons.Person;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AbstractsGrid_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            BusinessLogicLayer.Entities.Conference.Abstracts abstracts = BusinessLogicLayer.Common.AbstractsLogic.GetByID(Convert.ToInt32(e.OldValues["AbstractId"]));
            if (e.NewValues["AcceptanceType"].ToString() == "Cancelled")
            {
                EmailManager.SendCancelAbstractEmail(this.Page, abstracts);
            }
            else if (e.NewValues["AcceptanceType"].ToString() == "Oral")
            {
                EmailManager.SendOralAcceptedAbstractEmail(this.Page, abstracts);
            }
            else if (e.NewValues["AcceptanceType"].ToString() == "Poster")
            {
                EmailManager.SendPosterAcceptedAbstractEmail(this.Page, abstracts);
            }
            else if (e.NewValues["AcceptanceType"].ToString() == "Not Accepted")
            {
                EmailManager.SendNotAcceptedAbstractEmail(this.Page, abstracts);
            }

        }

        protected void AbstractPDFView_Click(object sender, EventArgs e)
        {
            LinkButton s = sender as LinkButton;
            DevExpress.XtraReports.UI.XtraReport pdf = CreateReport(Convert.ToInt32(s.CommandArgument));
            MemoryStream stream = new MemoryStream();

            pdf.ExportToPdf(stream);
            Response.ContentType = "application/pdf";
            Response.AddHeader("Content-Disposition", "attachment; filename=\"Abstract Submission.pdf\"");
            Response.BinaryWrite(stream.GetBuffer());
        }
        DevExpress.XtraReports.UI.XtraReport CreateReport(int id)
        {

            SocioBuilderSite.Conferences.Reports.AbstractSubmissionReport tableReport = new SocioBuilderSite.Conferences.Reports.AbstractSubmissionReport();
            BusinessLogicLayer.Entities.Conference.Abstracts CurrentAbstract = BusinessLogicLayer.Common.AbstractsLogic.GetByID(id);
            tableReport.LoadData(CurrentAbstract);
            return tableReport;
        }

        protected void callBackPanel_Callback(object sender, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            DevExpress.XtraReports.UI.XtraReport print = CreateReport(Convert.ToInt32(e.Parameter));
            ReportViewer1.Report = print;
        }

        public string GetStatusIcon(string status, string PosterPath)
        {
            string result = "";
            //ab.conf
            switch (status)
            {
                case "Pending":
                    result = "abs-pending-presentation";
                    break;
                case "Cancelled":
                    result = "abs-withdrawed-presentation";
                    break;
                case "Oral":
                    result = "abs-oral-presentation";
                    break;
                case "Poster":
                    result = "abs-poster-presentation";
                    break;
                case "Not Accepted":
                    result = "abs-rejected-presentation";
                    break;
            }

            return result;

        }
        protected void AbstractPrintView_Click(object sender, EventArgs e)
        {

            //MemoryStream stream = new MemoryStream();

            //pdf.ExportToPdf(stream);
            //Response.ContentType = "application/pdf"; 
            //Response.AddHeader("Content-Disposition", "attachment; filename=\"Abstract Submission.pdf\""); 
            //Response.BinaryWrite(stream.GetBuffer());
        }
    }
}