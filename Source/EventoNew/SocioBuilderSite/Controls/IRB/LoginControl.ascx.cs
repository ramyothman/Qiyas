using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocioBuilderSite.Code.RbmSecurity;

namespace SocioBuilderSite.Controls.IRB
{
    public partial class LoginControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (SecurityManager.isLogged(this.Page))
                {
                    LoginScreen.Visible = false;
                    LoggedInScreen.Visible = true;
                    UserNameLabel.InnerText = SecurityManager.getUser(this.Page).FullName;
                }
            }
        }
        private bool ValidateLogin(out string errortext)
        {
            bool result = true;
            errortext = "<ul>";
            
            try
            {
                if (string.IsNullOrEmpty(EmailText.Text.Trim()))
                {
                    errortext += "<li>Enter Email Address</li>";
                    result = false;
                }
                if (string.IsNullOrEmpty(PasswordText.Text.Trim()))
                {
                    errortext += "<li>Enter Password</li>";
                    result = false;
                }
                if (result)
                {
                    result = SecurityManager.doLogin(this.Page, EmailText.Text.Trim(), PasswordText.Text);
                }
            }
            catch (Exception ex)
            {
                errortext += String.Format("<li>{0}</li>", ex.Message);
                result = false;
            }
            finally
            {
                errortext += "</ul>";
            }
            
            return result;
        }
        protected void SubmitLogin_Click(object sender, EventArgs e)
        {
            
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {

            SecurityManager.doLogout(this.Page);
            LoggedInScreen.Visible = false;
            LoginScreen.Visible = true;
            
        }

        protected void ASPxButton1_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (!ValidateLogin(out errorMessage))
            {
                ErrorMessage.InnerHtml = errorMessage;
                ErrorMessage.Visible = true;
                return;
            }
            if (SecurityManager.isLogged(this.Page))
            {
                LoginScreen.Visible = false;
                LoggedInScreen.Visible = true;
                UserNameLabel.InnerText = SecurityManager.getUser(this.Page).FullName;
                Response.Redirect("~/IRB/Default.aspx");
            }
        }
    }
}