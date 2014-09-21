using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Conferences
{
    public partial class ForgetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SendPasswordButton_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.Entities.Persons.Person person = BusinessLogicLayer.Common.PersonLogic.GetByUserName(EmailText.Text);
            if (person == null)
            {
                NoticeError.InnerText = "This email is not registered in the system.";
                NoticeError.Visible = true;
            }
            else
            {
                string password = Guid.NewGuid().ToString().Substring(0,6);
                person.Credentials.PasswordHash = Code.RbmCommon.Tools.MD5(password + person.Credentials.PasswordSalt);
                BusinessLogicLayer.Common.CredentialLogic.Update(person.Credentials, person.Credentials.BusinessEntityId);
                EmailManager.SendForgetPasswordEmail(this.Page, person.FullName, person.MainPersonAddress.City, person.MainPersonAddress.CountryName, person.PersonHomePhoneMain, person.Credentials.Username, password, "", person.EmailAddressPrimaryObject.Email);
                NoticeError.InnerText = "An Email has been send with credentials";
                NoticeError.Visible = true;
            }
        }
    }
}