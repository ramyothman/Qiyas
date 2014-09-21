using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer.Entities.Persons;
using SocioBuilderSite.Code.RbmSecurity;
using Newtonsoft.Json;
using System.IO;
using SocioBuilderSite.Code.RbmCommon;
namespace SocioBuilderSite.BackendPortal.RoleSecurity
{
    public partial class UserDetails : AdminBasePage
    {
        Person CurrentPerson
        {
            set { Session["UserDetailCurrentPerson"] = value; }
            get 
            {
                if (Session["UserDetailCurrentPerson"] == null)
                {
                    Session["UserDetailCurrentPerson"] = new Person();
                }
                return Session["UserDetailCurrentPerson"] as Person;
            }
        }
        List<PersonPhone> PersonPhones
        {
            set { Session["UserDetailPersonPhones"] = value; }
            get
            {
                if (Session["UserDetailPersonPhones"] == null)
                {
                    Session["UserDetailPersonPhones"] = BusinessLogicLayer.Common.PersonPhoneLogic.GetByPersonId(CurrentPerson.BusinessEntityId);
                }
                return Session["UserDetailPersonPhones"] as List<PersonPhone>;
            }
        }

        List<EmailAddress> PersonEmails
        {
            set { Session["ProfilePersonEmails"] = value; }
            get
            {
                if (Session["ProfilePersonEmails"] == null)
                {
                    Session["ProfilePersonEmails"] = BusinessLogicLayer.Common.EmailAddressLogic.GetByPersonId(CurrentPerson.BusinessEntityId);
                }
                return Session["ProfilePersonEmails"] as List<EmailAddress>;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TitleObjectDS.SelectParameters[0].DefaultValue = BusinessLogicLayer.Common.LookupTitle;
                TitleObjectDS.SelectParameters[1].DefaultValue = BusinessLogicLayer.Common.DefaultLanguage.LanguageId.ToString();
                PromotionObjectDS.SelectParameters[0].DefaultValue = BusinessLogicLayer.Common.LookupReceivedPromotion;
                PromotionObjectDS.SelectParameters[1].DefaultValue = BusinessLogicLayer.Common.DefaultLanguage.LanguageId.ToString();
                bool isNew = true;
                int id = 0;
                if (!string.IsNullOrEmpty(Request["User"]))
                {
                    Int32.TryParse(Request["User"], out id);
                    CurrentPerson = BusinessLogicLayer.Common.PersonLogic.GetByID(id);
                    if (CurrentPerson == null)
                    {
                        CurrentPerson = new Person();
                    }
                    else
                    {
                        personNameStyle.Value = CurrentPerson.NameStyle.ToString();
                        personPromotion.Value = CurrentPerson.EmailPromotion;
                        personNationality.Value=CurrentPerson.NationalityCode;
                        userTitle.Text=CurrentPerson.Title;
                        userFirstName.Text=CurrentPerson.FirstName;
                        userMiddleName.Text=CurrentPerson.MiddleName;
                        userLastName.Text=CurrentPerson.LastName;
                        userDisplayName.Text=CurrentPerson.DisplayName;
                        userSuffix.Text=CurrentPerson.Suffix;
                        credUsername.Text = CurrentPerson.UserName;
                        PersonPhones = CurrentPerson.PersonPhones;
                        PersonEmails = CurrentPerson.EmailAddresses;
                            
                    }
                }
                else
                    Session["UserDetailCurrentPerson"] = null;
                if (CurrentPerson.NewRecord)
                {
                    personNationality.DataBind();
                    personNationality.SelectedIndex = personNationality.Items.FindByValue(BusinessLogicLayer.Common.DefaultCountryKey).Index;
                    
                }
                else
                {
                    
                }
                string jsonStringPhone = JsonConvert.SerializeObject(PersonPhones);
                string jsonStringEmail = JsonConvert.SerializeObject(PersonEmails);
                personPhoneHiddenField.Add("jsonStringPhone", jsonStringPhone);
                personEmailHiddenField.Add("jsonStringEmail", jsonStringEmail);
            }
        }
        private bool Save()
        {
            if (CurrentPerson.NewRecord)
            {
                int ids = 0;
                BusinessLogicLayer.Common.PersonLogic.Insert(ref ids, Convert.ToBoolean(personNameStyle.Value), Convert.ToInt32(personPromotion.Value), new Guid(), DateTime.Now, DateTime.Now, personNationality.Value.ToString(), userTitle.Text, userFirstName.Text, userMiddleName.Text, userLastName.Text, userDisplayName.Text, userSuffix.Text,"M",DateTime.MinValue,"");
                if (!string.IsNullOrEmpty(credUsername.Text))
                {
                    
                    string salt = new Guid().ToString().Substring(0, 5);
                    string password = Tools.MD5(credPassword.Text + salt);
                    BusinessLogicLayer.Common.CredentialLogic.Insert(ids, credUsername.Text, password, salt, "", true, credUserActive.Checked, new Guid(), DateTime.Now);
                }
                JsonSerializer serializer = new JsonSerializer();
                string jsonStringPhone = "";
                if(personPhoneHiddenField.Contains("jsonStringSetPhone"))
                     jsonStringPhone = personPhoneHiddenField.Get("jsonStringSetPhone").ToString();
                string jsonStringEmail = personEmailHiddenField.Get("jsonStringSetEmail").ToString();
                StringReader reader = new StringReader(jsonStringPhone);
                using (JsonReader jsonReader = new JsonTextReader(reader))
                {
                    PersonPhones = (List<PersonPhone>)serializer.Deserialize(jsonReader, typeof(List<PersonPhone>));
                }
                reader = new StringReader(jsonStringEmail);
                using (JsonReader jsonReader = new JsonTextReader(reader))
                {
                    PersonEmails = (List<EmailAddress>)serializer.Deserialize(jsonReader, typeof(List<EmailAddress>));
                }
                foreach (EmailAddress address in PersonEmails)
                {
                    address.BusinessEntityId = ids;
                    BusinessLogicLayer.Common.EmailAddressLogic.Insert(address);
                }

                foreach (PersonPhone phone in PersonPhones)
                {
                    phone.BusinessEntityId = ids;
                    BusinessLogicLayer.Common.PersonPhoneLogic.Insert(phone);
                }
                return true;
            }
            else
            {
                
                BusinessLogicLayer.Common.PersonLogic.Update(CurrentPerson.BusinessEntityId, Convert.ToBoolean(personNameStyle.Value), Convert.ToInt32(personPromotion.Value), new Guid(), DateTime.Now, DateTime.Now, personNationality.Value.ToString(), userTitle.Text, userFirstName.Text, userMiddleName.Text, userLastName.Text, userDisplayName.Text, userSuffix.Text, "M", DateTime.MinValue, "");
                if (!string.IsNullOrEmpty(credPassword.Text))
                {
                    string salt = new Guid().ToString().Substring(0, 5);
                    string password = Tools.MD5(credPassword.Text + salt);
                    CurrentPerson.Credentials.PasswordSalt = salt;
                    CurrentPerson.Credentials.PasswordHash = Tools.MD5(credPassword.Text + salt);
                    BusinessLogicLayer.Common.CredentialLogic.Update(CurrentPerson.Credentials, CurrentPerson.Credentials.BusinessEntityId);
                }
                BusinessLogicLayer.Common.EmailAddressLogic.DeleteByPersonId(CurrentPerson.BusinessEntityId);
                BusinessLogicLayer.Common.PersonPhoneLogic.DeleteByPersonId(CurrentPerson.BusinessEntityId);


                JsonSerializer serializer = new JsonSerializer();
                string jsonStringPhone = "";
                if (personPhoneHiddenField.Contains("jsonStringSetPhone"))
                    jsonStringPhone = personPhoneHiddenField.Get("jsonStringSetPhone").ToString();
                string jsonStringEmail = personEmailHiddenField.Get("jsonStringSetEmail").ToString();
                StringReader reader = new StringReader(jsonStringPhone);
                using (JsonReader jsonReader = new JsonTextReader(reader))
                {
                    PersonPhones = (List<PersonPhone>)serializer.Deserialize(jsonReader, typeof(List<PersonPhone>));
                }
                reader = new StringReader(jsonStringEmail);
                using (JsonReader jsonReader = new JsonTextReader(reader))
                {
                    PersonEmails = (List<EmailAddress>)serializer.Deserialize(jsonReader, typeof(List<EmailAddress>));
                }
                foreach (EmailAddress address in PersonEmails)
                {
                    address.BusinessEntityId = CurrentPerson.BusinessEntityId;
                    BusinessLogicLayer.Common.EmailAddressLogic.Insert(address);
                }

                foreach (PersonPhone phone in PersonPhones)
                {
                    phone.BusinessEntityId = CurrentPerson.BusinessEntityId;
                    BusinessLogicLayer.Common.PersonPhoneLogic.Insert(phone);
                }
                return true;
            }
            
        }
        protected void SaveButton_Click(object sender, EventArgs e)
        {
            if(Save())
                Response.Redirect("ManageUsers.aspx");
        }
        protected void ApplyButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageUsers.aspx");
        }
    }
}