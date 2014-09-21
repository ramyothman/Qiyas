using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocioBuilderSite.Code.RbmSecurity;
using System.IO;

namespace SocioBuilderSite.Conferences
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!SecurityManager.isLogged(this))
                {
                    Response.Redirect("~/Conferences/RequestLogin.aspx");
                }
                Session["CurrentPersonId"] = MyCurrentAbstractsControl.CurrentSpeaker.BusinessEntityId;
                AbstractPDFView.CommandArgument = MyCurrentAbstractsControl.CurrentSpeaker.BusinessEntityId.ToString();
                
            }
        }

        DevExpress.XtraReports.UI.XtraReport CreateReport()
        {
            Reports.IDReport tableReport = new Reports.IDReport();
            tableReport.CurrentPage = this;
            tableReport.LoadData(MyCurrentAbstractsControl.CurrentSpeaker);
            return tableReport;
        }

        protected void AbstractPDFView_Click(object sender, EventArgs e)
        {
            LinkButton s = sender as LinkButton;
            DevExpress.XtraReports.UI.XtraReport pdf = CreateReport();
            MemoryStream stream = new MemoryStream();

            pdf.ExportToPdf(stream);
            Response.ContentType = "application/pdf";
            Response.AddHeader("Content-Disposition", "attachment; filename=\"Participant ID PDF.pdf\"");
            Response.BinaryWrite(stream.GetBuffer());
        }

        
    }
}