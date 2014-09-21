using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using SocioBuilderSite.Code.RbmSecurity;

namespace SocioBuilderSite.Conferences
{
    public partial class MyAbstracts : System.Web.UI.Page
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
            }
        }
        
        
        
    }
}