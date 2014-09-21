using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocioBuilderSite.Code.RbmSecurity;

namespace SocioBuilderSite.Conferences
{
    public partial class RequestLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (SecurityManager.isLogged(this))
            {
                Response.Redirect("~/Conferences/Default.aspx");
            }
        }
    }
}