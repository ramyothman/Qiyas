using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace SocioBuilderSite
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            Response.Redirect(BusinessLogicLayer.Common.CurrentSiteUrl);
            //Response.Redirect("~/Liver/Default.aspx");
            int x = 0;
            //Response.Redirect("~/Livers/Default.aspx");
        }
    }
}