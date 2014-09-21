using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Conference
{
    public partial class ForgetPassword : Code.RbmCommon.ConferenceBasePage
    {
        EmailManager emailManager = new EmailManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            emailManager.SendEmailEvent += new EmailManager.SendEmailEventHandler(emailManager.SendEmail);
        }
        protected void SendPasswordButton_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.Entities.Persons.Person person = BusinessLogicLayer.Common.PersonLogic.GetByUserName(EmailText.Text);
            if (person == null)
            {
                NoticeError.InnerText = Resources.ConferenceFront.ForgetPassword_NoticeError;
                NoticeError.Visible = true;
            }
            else
            {
                string password = Guid.NewGuid().ToString().Substring(0, 6);
                person.Credentials.PasswordHash = Code.RbmCommon.Tools.MD5(password + person.Credentials.PasswordSalt);
                BusinessLogicLayer.Common.CredentialLogic.Update(person.Credentials, person.Credentials.BusinessEntityId);
                SocioBuilderSite.Code.EmailManagement.EmailSenderEventArgs args = new Code.EmailManagement.EmailSenderEventArgs();
                args.EmailType = EmailManager.EmailTypes.ForgotPassword;
                args.CurrentPerson = person;
                args.InputObject = password;
                args.CurrentPage = this;
                args.LanguageId = GetCurrentPageLanguageId(this);
                args.CurrentConference = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this);
                args.ToUser = person.EmailAddressPrimaryObject.Email;
                emailManager.OnSendEmail(args);
                //EmailManager.SendForgetPasswordEmail(this.Page, person.FullName, person.MainPersonAddress.City, person.MainPersonAddress.CountryName, person.PersonHomePhoneMain, person.Credentials.Username, password, "", person.EmailAddressPrimaryObject.Email);
                NoticeError.InnerText = Resources.ConferenceFront.ForgetPassword_SuccessMessage;
                NoticeError.Visible = true;
            }
        }
    }
}