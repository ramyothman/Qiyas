using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocioBuilderSite.Code.RbmSecurity;

namespace SocioBuilderSite.Administrator.Login
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (SecurityManager.doLogin(this, txtusername.Text, txtpassword.Text))
                    Response.Redirect("~/Administrator/Default.aspx");
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}