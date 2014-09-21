using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using DevExpress.Web.ASPxEditors;
using DevExpress.Web.ASPxGridView;

namespace SocioBuilderSite.BackendPortal.Conference
{
    public partial class ManageAbstracts : AdminBasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                object values = AbstractsGrid.GetRowValues(Convert.ToInt32(0), new string[] { "AbstractId" });
                if (values == null)
                    values = "0";
                Session["ParentID"] = values.ToString();
            }
        }
        protected void ASPxGridView1_BeforePerformDataSelect(object sender, EventArgs e)
        {

            Session["ParentID"] = (sender as ASPxGridView).GetMasterRowKeyValue();
        }
        protected void AbstractPDFView_Click(object sender, EventArgs e)
        {
            LinkButton s = sender as LinkButton;
            DevExpress.XtraReports.UI.XtraReport pdf = CreateReport(Convert.ToInt32(s.CommandArgument));
            MemoryStream stream = new MemoryStream();

            pdf.ExportToRtf(stream);
            Response.ContentType = "application/rtf";
            Response.AddHeader("Content-Disposition", "attachment; filename=\"AbstractSubmission-" + Convert.ToInt32(s.CommandArgument) + ".rtf\"");
            Response.BinaryWrite(stream.GetBuffer());
        }
        DevExpress.XtraReports.UI.XtraReport CreateReport(int id)
        {

            SocioBuilderSite.Conferences.Reports.AbstractSubmissionReport tableReport = new SocioBuilderSite.Conferences.Reports.AbstractSubmissionReport();
            BusinessLogicLayer.Entities.Conference.Abstracts CurrentAbstract = BusinessLogicLayer.Common.AbstractsLogic.GetByID(id);
            tableReport.LoadData(CurrentAbstract);
            return tableReport;
        }
        protected void AbstractsGrid_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            BusinessLogicLayer.Entities.Conference.Abstracts abstracts = BusinessLogicLayer.Common.AbstractsLogic.GetByID(Convert.ToInt32(e.NewValues["AbstractId"]));
            if (e.NewValues["AcceptanceType"].ToString() == "Cancelled" && e.OldValues["AcceptanceType"].ToString() != "Cancelled")
            {
                EmailManager.SendCancelAbstractEmail(this, abstracts);
            }
            else if (e.NewValues["AcceptanceType"].ToString() == "Oral" && e.OldValues["AcceptanceType"].ToString() != "Oral")
            {
                EmailManager.SendOralAcceptedAbstractEmail(this, abstracts);
            }
            else if (e.NewValues["AcceptanceType"].ToString() == "Poster" && e.OldValues["AcceptanceType"].ToString() != "Poster")
            {
                EmailManager.SendPosterAcceptedAbstractEmail(this, abstracts);
            }
            else if (e.NewValues["AcceptanceType"].ToString() == "Not Accepted" && e.OldValues["AcceptanceType"].ToString() != "Not Accepted")
            {
                
                EmailManager.SendNotAcceptedAbstractEmail(this, abstracts);
            }
            
        }

        protected void SendEmailCallback_Callback(object sender, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            btnSendEmail.CommandArgument = e.Parameter;
        }

        protected void btnSendEmail_Click(object sender, EventArgs e)
        {
            ASPxButton btn = sender as ASPxButton;
            BusinessLogicLayer.Entities.Conference.Abstracts abstracts = BusinessLogicLayer.Common.AbstractsLogic.GetByID(Convert.ToInt32(hiddenEmail.Get("Id")));
            LinkButton s = sender as LinkButton;
            DevExpress.XtraReports.UI.XtraReport pdf = CreateReport(Convert.ToInt32(hiddenEmail.Get("Id")));
            MemoryStream stream = new MemoryStream();

            pdf.ExportToPdf(stream);
            EmailManager.SendUserSendEmailWithContent(this, abstracts, SendEmailTitle.Text, SendEmailContent.Text, SendEmailText.Text, stream);
            SendEmailText.Text = "";
            SendEmailTitle.Text = "";
            SendEmailContent.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}