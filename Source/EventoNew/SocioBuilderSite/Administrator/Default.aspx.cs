using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace SocioBuilderSite.Administrator
{
    public partial class Default : AdminBasePage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int Registrations = BusinessLogicLayer.Common.ConferenceRegisterationsLogic.GetAll().Count;
                int totalAbstracts = BusinessLogicLayer.Common.AbstractsLogic.GetAll().Count;
                int pending = BusinessLogicLayer.Common.AbstractsLogic.GetPending().Count;
                int accepted = BusinessLogicLayer.Common.AbstractsLogic.GetAllOral().Count + BusinessLogicLayer.Common.AbstractsLogic.GetAllPoster().Count;

                TotalRegistrations.InnerText = Registrations.ToString();
                TotalAbstracts.InnerText = totalAbstracts.ToString();
                TotalAbstractsPending.InnerText = pending.ToString();
                TotalAbstractsAccepted.InnerText = accepted.ToString();

            }
        }

        DevExpress.XtraReports.UI.XtraReport CreateReport(int id)
        {

            SocioBuilderSite.Conferences.Reports.AbstractSubmissionReport tableReport = new SocioBuilderSite.Conferences.Reports.AbstractSubmissionReport();
            BusinessLogicLayer.Entities.Conference.Abstracts CurrentAbstract = BusinessLogicLayer.Common.AbstractsLogic.GetByID(id);
            tableReport.LoadData(CurrentAbstract);
            return tableReport;
        }

        protected void AbstractPDFView_Click(object sender, EventArgs e)
        {
            LinkButton s = sender as LinkButton;
            DevExpress.XtraReports.UI.XtraReport pdf = CreateReport(Convert.ToInt32(s.CommandArgument));
            MemoryStream stream = new MemoryStream();

            pdf.ExportToRtf(stream);
            Response.ContentType = "application/rtf";
            Response.AddHeader("Content-Disposition", "attachment; filename=\"Abstract Submission.rtf\"");
            Response.BinaryWrite(stream.GetBuffer());
        }
    }
}