using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Administrator.Conference
{
    public partial class RegistrationDetails : AdminBasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDownloadList_Click(object sender, EventArgs e)
        {
            ASPxGridViewExporter1.WriteXlsToResponse();
        }
    }
}