using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocioBuilderSite.Code.RbmCommon;
using DevExpress.Web.ASPxUploadControl;
using System.IO;
using SocioBuilderSite.Code.RbmSecurity;

namespace SocioBuilderSite.Controls.IRB
{
    public partial class ContactInfo : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ContactCountry.DataBind();
                ContactCountry.SelectedIndex = ContactCountry.Items.FindByValue(BusinessLogicLayer.Common.DefaultCountryKey).Index;
                BusinessLogicLayer.Entities.Persons.Person person;
                if (SecurityManager.isLogged(this.Page))
                {
                    person = SecurityManager.getUser(this.Page);
                    
                    ContactAddress.Text = person.MainPersonAddress.AddressLine1;
                    ContactCity.Text = person.MainPersonAddress.City;
                    ConfirmPasswordRow.Visible = false;
                    PasswordRow.Visible = false;
                    if(!string.IsNullOrEmpty(person.MainPersonAddress.CountryRegionCode))
                        ContactCountry.SelectedIndex = ContactCountry.Items.FindByValue(person.MainPersonAddress.CountryRegionCode).Index;
                    if(person.DateofBirth != DateTime.MinValue)
                        ContactDateofBirth.Date = person.DateofBirth;
                    if (!string.IsNullOrEmpty(person.EmailAddressPrimaryObject.Email))
                        ContactEmailText.Text = person.EmailAddressPrimaryObject.Email;
                    else
                        ContactEmailText.Text = person.Credentials.Username;
                    ContactEmailText.ReadOnly = true;
                    string []texts = person.PersonFaxPhoneMain.Split('-');
                    if(texts.Length == 1)
                        ContactFaxNumber.Text = texts[0];
                    else if (texts.Length == 2)
                    {
                        ContactFaxNumberAreaCode.Text = texts[0];
                        ContactFaxNumber.Text = texts[1];
                    }
                    texts = person.PersonHomePhoneMain.Split('-');
                    if (texts.Length == 1)
                        ContactPhoneNumber.Text = texts[0];
                    else if (texts.Length == 2)
                    {
                        ContactPhoneCode.Text = texts[0];
                        ContactPhoneNumber.Text = texts[1];
                    }

                    texts = person.PersonMobileMain.Split('-');
                    if (texts.Length == 1)
                        ContactMobileNumber.Text = texts[0];
                    else if (texts.Length == 2)
                    {
                        ContactMobileNumberCode.Text = texts[0];
                        ContactMobileNumber.Text = texts[1];
                    }
                    ContactFirstName.Text = person.FirstName;
                    ContactMiddleName.Text = person.MiddleName;
                    ContactLastName.Text = person.LastName;
                    if (!string.IsNullOrEmpty(person.Gender))
                        ContactGender.SelectedIndex = ContactGender.Items.FindByValue(person.Gender).Index;
                    ContactPOBox.Text = person.MainPersonAddress.PostalCode;
                    if (ContactTitle.Items.FindByValue(person.Title) != null)
                        ContactTitle.SelectedIndex = ContactTitle.Items.FindByValue(person.Title).Index;
                    ContactZipCode.Text = person.MainPersonAddress.ZipCode;
                }
            }
        }
        private bool _IsInProfile;
        public bool IsInProfile
        {
            get
            {
                _IsInProfile = false;
                if (ViewState["IsInProfile"] != null)
                    _IsInProfile = Convert.ToBoolean(ViewState["IsInProfile"]);
                return _IsInProfile; 
            }
            set
            {
                ViewState["IsInProfile"] = value;
            }
        }
        
        protected void Signup_Click(object sender, EventArgs e)
        {
            bool isValid = DevExpress.Web.ASPxEditors.ASPxEdit.ValidateEditorsInContainer(this);
            if (isValid)
            {
                try
                {
                    if (IsInProfile && !SecurityManager.isLogged(this.Page))
                    {
                        Response.Redirect("~/Conferences/Default.aspx");
                    }
                    if (SecurityManager.isLogged(this.Page))
                    {
                        

                        BusinessLogicLayer.Entities.Persons.Person person = SecurityManager.getUser(this.Page);
                        BusinessLogicLayer.Entities.Persons.PersonLanguages personLanguages = new BusinessLogicLayer.Entities.Persons.PersonLanguages();
                        BusinessLogicLayer.Entities.Persons.EmailAddress emailAddresses = person.EmailAddressPrimaryObject;
                        BusinessLogicLayer.Entities.Persons.Address address = person.MainPersonAddress;
                        person.Title = ContactTitle.Text;
                        person.FirstName = ContactFirstName.Text.Trim();
                        person.MiddleName = ContactMiddleName.Text.Trim();
                        person.LastName = ContactLastName.Text.Trim();
                        person.DateofBirth = ContactDateofBirth.Date;
                        person.Gender = ContactGender.Value.ToString();
                        person.DisplayName = string.Format("{0} {1} {2}", person.Title, person.FirstName, person.LastName);
                        if(profileLogoUpload.HasFile)
                            person.PersonImage = SavePostedFile(profileLogoUpload.UploadedFiles[0]);
                        BusinessLogicLayer.Common.PersonLogic.Update(person,person.BusinessEntityId);
                        if (person.PersonDefaultLanguage.NewRecord)
                        {
                            BusinessLogicLayer.Common.PersonLanguagesLogic.Insert(person.PersonDefaultLanguage);
                        }
                        else
                        {
                            BusinessLogicLayer.Common.PersonLanguagesLogic.Update(person.PersonDefaultLanguage, person.PersonDefaultLanguage.PersonLanguageId);
                        }
                        emailAddresses.BusinessEntityId = person.BusinessEntityId;
                        emailAddresses.Email = ContactEmailText.Text.Trim();
                        
                        if(person.EmailAddressPrimaryObject.NewRecord)
                        {
                            emailAddresses.EmailAddressTypeId = 1;
                            emailAddresses.EmailVerificationHash = emailAddresses.EmailVerificationHash = Tools.MD5(emailAddresses.Email);
                            emailAddresses.EmailVerified = false;
                            BusinessLogicLayer.Common.EmailAddressLogic.Insert(emailAddresses);
                        }
                        else
                            BusinessLogicLayer.Common.EmailAddressLogic.Update(emailAddresses, emailAddresses.EmailAddressId);
                        
                        address.AddressLine1 = ContactAddress.Text.Trim();
                        address.City = ContactCity.Text.Trim();
                        address.CountryRegionCode = ContactCountry.SelectedItem.Value.ToString();
                        address.ModifiedDate = DateTime.Now;
                        address.RowGuid = Guid.NewGuid();
                        address.ZipCode = ContactZipCode.Text;
                        address.PostalCode = ContactPOBox.Text;
                        if (address.NewRecord)
                        {
                            BusinessLogicLayer.Common.AddressLogic.Insert(address);
                            BusinessLogicLayer.Common.BusinessEntityAddressLogic.Insert(person.BusinessEntityId, address.AddressId, 1, Guid.NewGuid(), DateTime.Now);
                        }
                        else
                        {
                            BusinessLogicLayer.Common.AddressLogic.Update(address, address.AddressId);
                        }
                        string phone = "";
                        string mainPhone = "";
                        if (!string.IsNullOrEmpty(ContactPhoneCode.Text))
                            phone = String.Format("{0}-{1}", ContactPhoneCode.Text, ContactPhoneNumber.Text);
                        else
                            phone = ContactPhoneNumber.Text;
                        mainPhone = phone;
                        person.PersonHomePhoneMain = phone;
                        if(person.HomePhoneObject.NewRecord)
                            BusinessLogicLayer.Common.PersonPhoneLogic.Insert(person.BusinessEntityId, phone, 1, DateTime.Now, true, "");
                        else
                            BusinessLogicLayer.Common.PersonPhoneLogic.Update(person.BusinessEntityId, phone, person.HomePhoneObject.PhoneNumberTypeId, DateTime.Now, person.HomePhoneObject.PhoneVerified, person.HomePhoneObject.PhoneVerificationCode, person.HomePhoneObject.Id);
                        if (!string.IsNullOrEmpty(ContactFaxNumberAreaCode.Text))
                            phone = String.Format("{0}-{1}", ContactFaxNumberAreaCode.Text, ContactFaxNumber.Text);
                        else
                            phone = ContactFaxNumber.Text;
                        person.PersonFaxPhoneMain= phone;
                        if(person.FaxPhoneObject.NewRecord)
                            BusinessLogicLayer.Common.PersonPhoneLogic.Insert(person.BusinessEntityId, phone, 3, DateTime.Now, true, "");
                        else
                            BusinessLogicLayer.Common.PersonPhoneLogic.Update(person.BusinessEntityId, phone, person.FaxPhoneObject.PhoneNumberTypeId, DateTime.Now, person.FaxPhoneObject.PhoneVerified, person.FaxPhoneObject.PhoneVerificationCode, person.FaxPhoneObject.Id);
                        if (!string.IsNullOrEmpty(ContactMobileNumberCode.Text))
                            phone = String.Format("{0}-{1}", ContactMobileNumberCode.Text, ContactMobileNumber.Text);
                        else
                            phone = ContactMobileNumber.Text;
                        person.PersonMobileMain = phone;
                        if(person.MobilePhoneObject.NewRecord)
                            BusinessLogicLayer.Common.PersonPhoneLogic.Insert(person.BusinessEntityId, phone, 5, DateTime.Now, true, "");
                        else
                            BusinessLogicLayer.Common.PersonPhoneLogic.Update(person.BusinessEntityId, phone, person.MobilePhoneObject.PhoneNumberTypeId, DateTime.Now, person.MobilePhoneObject.PhoneVerified, person.MobilePhoneObject.PhoneVerificationCode, person.MobilePhoneObject.Id);
                        //ContactInfoSignup.Visible = false;
                        //NotificationMessageError.Visible = false;
                        //NotificationMessageSuccess.Visible = false;
                        //NotificationMessageProfileUpdated.Visible = true;
                        SecurityManager.UpdateUser(this.Page,person);
                        OnProfileSaveEvent(person);
                    }
                    else
                    {

                        BusinessLogicLayer.Entities.Persons.Person person = new BusinessLogicLayer.Entities.Persons.Person();
                        BusinessLogicLayer.Entities.Persons.PersonLanguages personLanguages = new BusinessLogicLayer.Entities.Persons.PersonLanguages();
                        BusinessLogicLayer.Entities.Persons.EmailAddress emailAddresses = new BusinessLogicLayer.Entities.Persons.EmailAddress();
                        BusinessLogicLayer.Entities.Persons.Address address = new BusinessLogicLayer.Entities.Persons.Address();
                        person.EmailPromotion = 1;
                        person.NameStyle = false;
                        person.Title = ContactTitle.Text;
                        person.FirstName = ContactFirstName.Text.Trim();
                        person.MiddleName = ContactMiddleName.Text.Trim();
                        person.LastName = ContactLastName.Text.Trim();
                        person.DateofBirth = ContactDateofBirth.Date;
                        person.Gender = ContactGender.Value.ToString();
                        person.DisplayName = string.Format("{0} {1} {2}", person.Title, person.FirstName, person.LastName);
                        if(profileLogoUpload.HasFile)
                            person.PersonImage = SavePostedFile(profileLogoUpload.UploadedFiles[0]);
                        BusinessLogicLayer.Common.PersonLogic.Insert(person);
                        emailAddresses.BusinessEntityId = person.BusinessEntityId;
                        emailAddresses.Email = ContactEmailText.Text.Trim();
                        emailAddresses.EmailAddressTypeId = 1;
                        emailAddresses.EmailVerificationHash = emailAddresses.EmailVerificationHash = Tools.MD5(emailAddresses.Email);
                        emailAddresses.EmailVerified = false;
                        BusinessLogicLayer.Common.EmailAddressLogic.Insert(emailAddresses);
                        BusinessLogicLayer.Entities.Persons.Credential credential = new BusinessLogicLayer.Entities.Persons.Credential();
                        credential.BusinessEntityId = person.BusinessEntityId;
                        credential.Username = ContactEmailText.Text.Trim();
                        credential.IsActivated = false;
                        credential.ActivationCode = Tools.MD5(emailAddresses.Email);
                        credential.IsActive = true;
                        credential.ModifiedDate = DateTime.Now;
                        credential.RowGuid = Guid.NewGuid();
                        credential.PasswordSalt = String.Format("{0}AICSSN", System.DateTime.Now.Second);
                        credential.PasswordHash = Tools.MD5(ContactPasswordText.Text + credential.PasswordSalt);
                        BusinessLogicLayer.Common.CredentialLogic.Insert(credential);
                        address.AddressLine1 = ContactAddress.Text.Trim();
                        address.City = ContactCity.Text.Trim();
                        address.CountryRegionCode = ContactCountry.SelectedItem.Value.ToString();
                        address.ModifiedDate = DateTime.Now;
                        address.RowGuid = Guid.NewGuid();
                        address.ZipCode = ContactZipCode.Text;
                        address.PostalCode = ContactPOBox.Text;
                        BusinessLogicLayer.Common.AddressLogic.Insert(address);
                        BusinessLogicLayer.Common.BusinessEntityAddressLogic.Insert(person.BusinessEntityId, address.AddressId, 1, Guid.NewGuid(), DateTime.Now);

                        string phone = "";
                        string mainPhone = "";
                        if (string.IsNullOrEmpty(ContactPhoneCode.Text))
                            phone = String.Format("{0}-{1}", ContactPhoneCode.Text, ContactPhoneNumber.Text);
                        else
                            phone = ContactPhoneNumber.Text;
                        mainPhone = phone;
                        BusinessLogicLayer.Common.PersonPhoneLogic.Insert(person.BusinessEntityId, phone, 1, DateTime.Now, true, "");
                        if (string.IsNullOrEmpty(ContactFaxNumberAreaCode.Text))
                            phone = String.Format("{0}-{1}", ContactFaxNumberAreaCode.Text, ContactFaxNumber.Text);
                        else
                            phone = ContactFaxNumber.Text;
                        BusinessLogicLayer.Common.PersonPhoneLogic.Insert(person.BusinessEntityId, phone, 3, DateTime.Now, true, "");
                        if (string.IsNullOrEmpty(ContactMobileNumberCode.Text))
                            phone = String.Format("{0}-{1}", ContactMobileNumberCode.Text, ContactMobileNumber.Text);
                        else
                            phone = ContactMobileNumber.Text;
                        BusinessLogicLayer.Common.PersonPhoneLogic.Insert(person.BusinessEntityId, phone, 5, DateTime.Now, true, "");

                        EmailManager.SendSignupEmail(this.Page, person.DisplayName, address.City, ContactCountry.Text, mainPhone, credential.Username, ContactPasswordText.Text, credential.ActivationCode, credential.Username);
                        ContactInfoSignup.Visible = false;
                        NotificationMessageError.Visible = false;
                        NotificationMessageSuccess.Visible = true;
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

        protected void ContactEmailText_Validation(object sender, DevExpress.Web.ASPxEditors.ValidationEventArgs e)
        {
            if (!IsInProfile)
            {
                BusinessLogicLayer.Entities.Persons.Person person = BusinessLogicLayer.Common.PersonLogic.GetByUserName(ContactEmailText.Text.Trim());
                if (person != null)
                {
                    e.ErrorText = "This email is already registered";
                    e.IsValid = false;
                }
                else
                    e.IsValid = true;
            }
        }

        #region UploadFile
        private string SavePostedFile(UploadedFile uploadedFile)
        {

            Session["profileLogoUpload"] = null;
            string fileName = "";
            if (uploadedFile.IsValid)
            {
                Random random = new Random();
                //string _MenuGroupId = Session["MenuGroupId"].ToString();
                string dateString = String.Format("{0}{1}{2}", System.DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
                string timeString = String.Format("{0}{1}{2}", System.DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                fileName = String.Format("{0}-{1}-{2}-{3}", dateString, timeString, random.Next(), uploadedFile.FileName);
                Session["profileLogoUpload"] = fileName;
                //uploadedFile.SaveAs(Server.MapPath("~/ContentData/Sites/Conferences/") + fileName, true);
                byte[] thumb = Tools.CreateThumb(uploadedFile.FileBytes, 100, false);
                //MemoryStream stream = new MemoryStream(thumb);
                FileStream stream = new FileStream(Server.MapPath(BusinessLogicLayer.Common.PersonContentPath) + fileName, FileMode.Create);
                stream.Write(uploadedFile.FileBytes, 0, uploadedFile.FileBytes.Length);
                stream.Flush();
                stream.Close();
                BusinessLogicLayer.Entities.Persons.Person person = SecurityManager.getUser(this.Page);
                person.PersonImage = fileName;
                BusinessLogicLayer.Common.PersonLogic.Update(person, person.BusinessEntityId);
            }
            return fileName;
        }
        protected void profileLogoUpload_FileUploadComplete(object sender, DevExpress.Web.ASPxUploadControl.FileUploadCompleteEventArgs e)
        {
            e.CallbackData = SavePostedFile(e.UploadedFile);
        }
        #endregion

        public delegate void ProfileSaved(object sender,BusinessLogicLayer.Entities.Persons.Person profile);
        public event ProfileSaved ProfileSaveEvent;
        public void OnProfileSaveEvent(BusinessLogicLayer.Entities.Persons.Person profile)
        {
            if (ProfileSaveEvent != null)
            {
                ProfileSaveEvent(this, profile);
            }
        }

    }
}