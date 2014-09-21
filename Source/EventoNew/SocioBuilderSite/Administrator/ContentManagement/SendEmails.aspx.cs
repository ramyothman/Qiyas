using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using System.Linq.Expressions;

namespace SocioBuilderSite.Administrator.ContentManagement
{
    public partial class SendEmails : AdminBasePage
    {
        List<BusinessLogicLayer.Entities.Persons.Person> Persons = null;// new List<BusinessLogicLayer.Entities.Persons.Person>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Persons == null)
            {
                Persons = BusinessLogicLayer.Common.PersonLogic.GetAll();
            }
            gridContacts.DataSource = Persons;
            gridContacts.DataBind();
            
            manager.SendEmailEvent += new EmailManager.SendEmailEventHandler(manager.SendEmail);
        }
        EmailManager manager = new EmailManager();
        protected void btnSendEmails_Click(object sender, EventArgs e)
        {
            int count = 0;
            List<object> list = gridContacts.GetSelectedFieldValues("BusinessEntityId");
            foreach (int item in list)
            {
                var person = (from x in Persons where x.BusinessEntityId == item select x).FirstOrDefault();
                if (person == null) continue;
                if (person.Email.Trim() == "") continue;
                SocioBuilderSite.Code.EmailManagement.EmailSenderEventArgs args = new Code.EmailManagement.EmailSenderEventArgs();
                args.EmailType = EmailManager.EmailTypes.Custom;
                args.CurrentPerson = person;
                args.EmailTitle = txtSubject.Text;
                args.InputObject = EmailContentHtmlEditor.Html;
                args.CurrentPage = this.Page;
                args.LanguageId = Code.RbmCommon.ConferenceBasePage.GetCurrentPageLanguageId(this.Page);
                args.CurrentConference = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this.Page);
                args.ToUser = person.EmailAddressPrimaryObject.Email;
                manager.OnSendEmail(args);
                count++;
            }
            string[] emailsSplit = txtEmail.Text.Split(',');
            foreach (string email in emailsSplit)
            {
                if (string.IsNullOrEmpty(email.Trim())) continue;
                string template = EmailManager.GetTemplateClearCustomData(EmailContentHtmlEditor.Html);
                EmailManager.sendMail(template, txtSubject.Text, email);
                count++;
            }

            SuccessMessage.Visible = true;
            string MessageText = "Email Sent Successfully To ##COUNT## Accounts";
            SuccessMessage.InnerText = MessageText.Replace("##COUNT##", count.ToString());
        }
    }
}