using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using SocioBuilderSite.Code.RbmCommon;

namespace SocioBuilderSite.Conferences
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("RegisterSignup.aspx");
        }

        protected void Signup_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLogicLayer.Entities.Persons.Person person = new BusinessLogicLayer.Entities.Persons.Person();
                BusinessLogicLayer.Entities.Persons.PersonLanguages personLanguages = new BusinessLogicLayer.Entities.Persons.PersonLanguages();
                BusinessLogicLayer.Entities.Persons.EmailAddress emailAddresses = new BusinessLogicLayer.Entities.Persons.EmailAddress();
                person.EmailPromotion = 1;
                person.NameStyle = false;
                
                personLanguages.PersonId = person.BusinessEntityId;
                string []Name = NameText.Text.Trim().Split(' ');
                if (Name.Length >= 1)
                    person.FirstName = Name[0];
                if(Name.Length == 2)
                   person.LastName = Name[1];
                else if (Name.Length > 2)
                {
                    for (int i = 1; i < Name.Length - 2;i++ )
                    {
                        person.MiddleName += Name[i] + " ";
                    }
                    person.MiddleName.Trim();
                    person.LastName = Name[Name.Length - 1];
                }
                person.DisplayName = NameText.Text;
                BusinessLogicLayer.Common.PersonLogic.Insert(person);
                emailAddresses.BusinessEntityId = person.BusinessEntityId;
                emailAddresses.Email = EmailText.Text.Trim();
                emailAddresses.EmailAddressTypeId = 1;
                emailAddresses.EmailVerificationHash = Tools.MD5(emailAddresses.Email);
                BusinessLogicLayer.Common.EmailAddressLogic.Insert(emailAddresses);
                BusinessLogicLayer.Common.PersonPhoneLogic.Insert(person.BusinessEntityId, MobileText.Text.Trim(), 5, DateTime.Now, true, "");
                BusinessLogicLayer.Entities.Persons.Credential credential = new BusinessLogicLayer.Entities.Persons.Credential();
                credential.BusinessEntityId = person.BusinessEntityId;
                credential.Username = EmailText.Text.Trim();
                credential.IsActivated = true;
                credential.IsActive = true;
                credential.ModifiedDate = DateTime.Now;
                credential.RowGuid = Guid.NewGuid();
                credential.PasswordSalt = String.Format("{0}KKUH", System.DateTime.Now.Second);
                credential.PasswordHash = Tools.MD5(PasswordText.Text + credential.PasswordSalt);
                BusinessLogicLayer.Common.CredentialLogic.Insert(credential);
                SignupFormView.Visible = false;
                NotificationMessage.Visible = true;
                NotificationMessage.InnerHtml = string.Format("<strong>Success</strong><br /><p>You have been successfully singed up to the system please login with your credentials to start using site features</p>");
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