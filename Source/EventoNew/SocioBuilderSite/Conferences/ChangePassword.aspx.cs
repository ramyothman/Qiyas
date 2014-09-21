using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocioBuilderSite.Code.RbmSecurity;
using SocioBuilderSite.Code.RbmCommon;

namespace SocioBuilderSite.Conferences
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!SecurityManager.isLogged(this.Page))
                {
                    Response.Redirect("Default.aspx");
                }
                
            }
        }

        protected void Signup_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLogicLayer.Entities.Persons.Credential credential = SecurityManager.getUser(this.Page).Credentials;
                credential.PasswordSalt = String.Format("{0}KKUH", System.DateTime.Now.Second);
                credential.PasswordHash = Tools.MD5(PasswordText.Text + credential.PasswordSalt);
                BusinessLogicLayer.Common.CredentialLogic.Update(credential, credential.BusinessEntityId);
                //SignupFormView.Visible = false;
                NotificationMessage.Visible = true;
                NotificationMessage.InnerHtml = string.Format("<strong>Success</strong><br /><p>Your Password Have Been Updated Successfully</p>");
                NotificationMessage.Attributes.Remove("class");
                NotificationMessage.Attributes.Add("class", "success");
            }
            catch (Exception ex)
            {
                SignupFormView.Visible = false;
                NotificationMessage.Visible = true;
                NotificationMessage.InnerHtml = String.Format("<strong>Error</strong><br /><span>{0}</span>", ex.Message);
                NotificationMessage.Attributes.Remove("class");
                NotificationMessage.Attributes.Add("class", "error");
            }
        }
    }
}