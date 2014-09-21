using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Conference
{
    public partial class RegisterSignup : Code.RbmCommon.ConferenceBasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Signup_Click(object sender, EventArgs e)
        {
            string Message = "";
            try
            {
                bool result = ContactInfoControl1.SaveData(out Message);
                if (result)
                {
                    ContactInfoControl1.ContactInfoSignupProperty.Visible = false;
                    NotificationMessageError.Visible = false;
                    SignupButton.Visible = false;
                    NotificationMessageSuccess.Visible = true;
                }
                else
                {
                    NotificationMessageError.InnerText = Message;
                    NotificationMessageError.Visible = true;
                    NotificationMessageSuccess.Visible = false;
                }
            }
            catch (Exception ex)
            {
                NotificationMessageSuccess.Visible = false;
                NotificationMessageError.Visible = true;
                ErrorMessage.InnerText = ex.Message;
            }

        }
    }
}