using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Administrator.Conference
{
    public partial class Registerations : AdminBasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ASPxGridView2_BeforePerformDataSelect(object sender, EventArgs e)
        {
            Session["ConferenceRegistrerID"] = ((ASPxGridView)sender).GetMasterRowKeyValue().ToString();
        }
    }
}