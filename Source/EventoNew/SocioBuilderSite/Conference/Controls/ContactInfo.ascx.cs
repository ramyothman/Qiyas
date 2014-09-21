using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocioBuilderSite.Code.RbmSecurity;
using System.IO;
using SocioBuilderSite.Code.RbmCommon;
using DevExpress.Web.ASPxUploadControl;
using System.Web.UI.HtmlControls;

namespace SocioBuilderSite.Conference.Controls
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
                    if (!string.IsNullOrEmpty(person.MainPersonAddress.CountryRegionCode))
                        ContactCountry.SelectedIndex = ContactCountry.Items.FindByValue(person.MainPersonAddress.CountryRegionCode).Index;
                    if (person.DateofBirth != DateTime.MinValue)
                        ContactDateofBirth.Date = person.DateofBirth;
                    if (!string.IsNullOrEmpty(person.EmailAddressPrimaryObject.Email))
                        ContactEmailText.Text = person.EmailAddressPrimaryObject.Email;
                    else
                        ContactEmailText.Text = person.Credentials.Username;
                    ContactEmailText.ReadOnly = true;
                    ContactFaxNumber.Text = person.PersonFaxPhoneMain;
                    ContactPhoneNumber.Text = person.PersonHomePhoneMain;
                    ContactMobileNumber.Text = person.PersonMobileMain;

                    ContactFirstName.Text = person.FullName;
                    //ContactMiddleName.Text = person.MiddleName;
                    //ContactLastName.Text = person.LastName;
                    if (!string.IsNullOrEmpty(person.Gender))
                        ContactGender.SelectedIndex = ContactGender.Items.FindByValue(person.Gender).Index;
                    ContactPOBox.Text = person.MainPersonAddress.PostalCode;
                    if (ContactTitle.Items.FindByValue(person.Title) != null)
                        ContactTitle.SelectedIndex = ContactTitle.Items.FindByValue(person.Title).Index;
                    ContactZipCode.Text = person.MainPersonAddress.ZipCode;
                }
            }
        }
        EmailManager emailManager = new EmailManager();
        public bool SaveData(out string Message)
        {
            bool result = false;
            Message = "";
            bool isValid = DevExpress.Web.ASPxEditors.ASPxEdit.ValidateEditorsInContainer(this);
            if (isValid)
            {
                try
                {
                    SetData(person, personLanguages, emailAddresses, address);

                    if (SecurityManager.isLogged(this.Page))
                    {
                        #region Saving Data
                        BusinessLogicLayer.Common.PersonLogic.Update(person, person.BusinessEntityId);
                        if (person.PersonDefaultLanguage.NewRecord)
                        {
                            BusinessLogicLayer.Common.PersonLanguagesLogic.Insert(person.PersonDefaultLanguage);
                        }
                        else
                        {
                            BusinessLogicLayer.Common.PersonLanguagesLogic.Update(person.PersonDefaultLanguage, person.PersonDefaultLanguage.PersonLanguageId);
                        }
                        if (person.EmailAddressPrimaryObject.NewRecord)
                            BusinessLogicLayer.Common.EmailAddressLogic.Insert(emailAddresses);
                        else
                            BusinessLogicLayer.Common.EmailAddressLogic.Update(emailAddresses, emailAddresses.EmailAddressId);
                        if (address.NewRecord)
                        {
                            BusinessLogicLayer.Common.AddressLogic.Insert(address);
                            BusinessLogicLayer.Common.BusinessEntityAddressLogic.Insert(person.BusinessEntityId, address.AddressId, 1, Guid.NewGuid(), DateTime.Now);
                        }
                        else
                        {
                            BusinessLogicLayer.Common.AddressLogic.Update(address, address.AddressId);
                        }
                        if (person.HomePhoneObject.NewRecord)
                            BusinessLogicLayer.Common.PersonPhoneLogic.Insert(person.BusinessEntityId, person.PersonHomePhoneMain, 1, DateTime.Now, true, "");
                        else
                            BusinessLogicLayer.Common.PersonPhoneLogic.Update(person.BusinessEntityId, person.PersonHomePhoneMain, person.HomePhoneObject.PhoneNumberTypeId, DateTime.Now, person.HomePhoneObject.PhoneVerified, person.HomePhoneObject.PhoneVerificationCode, person.HomePhoneObject.Id);
                        if (person.FaxPhoneObject.NewRecord)
                            BusinessLogicLayer.Common.PersonPhoneLogic.Insert(person.BusinessEntityId, person.PersonFaxPhoneMain, 3, DateTime.Now, true, "");
                        else
                            BusinessLogicLayer.Common.PersonPhoneLogic.Update(person.BusinessEntityId, person.PersonFaxPhoneMain, person.FaxPhoneObject.PhoneNumberTypeId, DateTime.Now, person.FaxPhoneObject.PhoneVerified, person.FaxPhoneObject.PhoneVerificationCode, person.FaxPhoneObject.Id);
                        if (person.MobilePhoneObject.NewRecord)
                            BusinessLogicLayer.Common.PersonPhoneLogic.Insert(person.BusinessEntityId, person.PersonMobileMain, 5, DateTime.Now, true, "");
                        else
                            BusinessLogicLayer.Common.PersonPhoneLogic.Update(person.BusinessEntityId, person.PersonMobileMain, person.MobilePhoneObject.PhoneNumberTypeId, DateTime.Now, person.MobilePhoneObject.PhoneVerified, person.MobilePhoneObject.PhoneVerificationCode, person.MobilePhoneObject.Id);
                        SecurityManager.UpdateUser(this.Page, person);
                        OnProfileSaveEvent(person);
                        #endregion
                    }
                    else
                    {

                        BusinessLogicLayer.Common.PersonLogic.Insert(person);
                        emailAddresses.BusinessEntityId = person.BusinessEntityId;
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
                        person.Credentials = credential;
                        BusinessLogicLayer.Common.AddressLogic.Insert(address);
                        BusinessLogicLayer.Common.BusinessEntityAddressLogic.Insert(person.BusinessEntityId, address.AddressId, 1, Guid.NewGuid(), DateTime.Now);
                        BusinessLogicLayer.Common.PersonPhoneLogic.Insert(person.BusinessEntityId, ContactPhoneNumber.Text.Trim(), 1, DateTime.Now, true, "");
                        BusinessLogicLayer.Common.PersonPhoneLogic.Insert(person.BusinessEntityId, ContactFaxNumber.Text.Trim(), 3, DateTime.Now, true, "");
                        BusinessLogicLayer.Common.PersonPhoneLogic.Insert(person.BusinessEntityId, ContactMobileNumber.Text.Trim(), 5, DateTime.Now, true, "");

                        SocioBuilderSite.Code.EmailManagement.EmailSenderEventArgs args = new Code.EmailManagement.EmailSenderEventArgs();
                        args.EmailType = EmailManager.EmailTypes.Signup;
                        args.CurrentPerson = person;
                        args.InputObject = ContactPasswordText.Text;
                        args.CurrentPage = this.Page;
                        args.LanguageId = Code.RbmCommon.ConferenceBasePage.GetCurrentPageLanguageId(this.Page);
                        args.CurrentConference = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this.Page);
                        args.ToUser = person.EmailAddressPrimaryObject.Email;
                        emailManager.OnSendEmail(args);
                        //EmailManager.SendSignupEmail(this.Page, person.DisplayName, address.City, ContactCountry.Text, ContactMobileNumber.Text.Trim(), credential.Username, ContactPasswordText.Text, credential.ActivationCode, credential.Username);
                        ContactInfoSignup.Visible = false;
                    }
                    result = true;
                }
                catch (Exception ex)
                {
                    Message = ex.Message;
                }
            }
            return result;
        }

        public void SetData(BusinessLogicLayer.Entities.Persons.Person person, BusinessLogicLayer.Entities.Persons.PersonLanguages personLanguages, BusinessLogicLayer.Entities.Persons.EmailAddress emailAddresses, BusinessLogicLayer.Entities.Persons.Address address)
        {
            string[] Names = ContactFirstName.Text.Trim().Split(' ');

            string FirstName = ContactFirstName.Text;
            string LastName = ContactLastName.Text;
            string MiddleName = ContactMiddleName.Text;
            //for (int i = 1; i < Names.Length - 1; i++)
            //{
            //    MiddleName += Names[i] + " ";
            //}
            if (SecurityManager.isLogged(this.Page))
            {
                #region Setting Data
                person = SecurityManager.getUser(this.Page);
                personLanguages = new BusinessLogicLayer.Entities.Persons.PersonLanguages();
                emailAddresses = person.EmailAddressPrimaryObject;
                address = person.MainPersonAddress;
                person.Title = ContactTitle.Text;
                person.FirstName = FirstName;
                person.MiddleName = MiddleName;
                person.LastName = LastName;
                person.DateofBirth = ContactDateofBirth.Date;
                person.Gender = ContactGender.Value.ToString();
                person.DisplayName = string.Format("{0} {1} {2}", person.Title, person.FirstName, person.LastName);
                if (profileLogoUpload.UploadedFiles.Length > 0)
                    person.PersonImage = SavePostedFile(profileLogoUpload.UploadedFiles[0]);


                emailAddresses.BusinessEntityId = person.BusinessEntityId;
                emailAddresses.Email = ContactEmailText.Text.Trim();

                if (person.EmailAddressPrimaryObject.NewRecord)
                {
                    emailAddresses.EmailAddressTypeId = 1;
                    emailAddresses.EmailVerificationHash = emailAddresses.EmailVerificationHash = Tools.MD5(emailAddresses.Email);
                    emailAddresses.EmailVerified = false;
                }


                address.AddressLine1 = ContactAddress.Text.Trim();
                address.City = ContactCity.Text.Trim();
                address.CountryRegionCode = ContactCountry.SelectedItem.Value.ToString();
                address.ModifiedDate = DateTime.Now;
                address.RowGuid = Guid.NewGuid();
                address.ZipCode = ContactZipCode.Text;
                address.PostalCode = ContactPOBox.Text;


                person.PersonHomePhoneMain = ContactPhoneNumber.Text.Trim();

                person.PersonFaxPhoneMain = ContactFaxNumber.Text.Trim();

                person.PersonMobileMain = ContactMobileNumber.Text;
                #endregion
            }
            else
            {
                person.EmailPromotion = 1;
                person.NameStyle = false;
                person.Title = ContactTitle.Text;
                person.FirstName = FirstName;
                person.MiddleName = MiddleName;
                person.LastName = LastName;
                person.DateofBirth = ContactDateofBirth.Date;
                person.Gender = ContactGender.Value.ToString();
                person.DisplayName = string.Format("{0} {1} {2}", person.Title, person.FirstName, person.LastName);
                if (profileLogoUpload.HasFile)
                    person.PersonImage = SavePostedFile(profileLogoUpload.UploadedFiles[0]);

                emailAddresses.BusinessEntityId = person.BusinessEntityId;
                emailAddresses.Email = ContactEmailText.Text.Trim();
                emailAddresses.EmailAddressTypeId = 1;
                emailAddresses.EmailVerificationHash = emailAddresses.EmailVerificationHash = Tools.MD5(emailAddresses.Email);
                emailAddresses.EmailVerified = false;

                address.AddressLine1 = ContactAddress.Text.Trim();
                address.City = ContactCity.Text.Trim();
                address.CountryRegionCode = ContactCountry.SelectedItem.Value.ToString();
                address.ModifiedDate = DateTime.Now;
                address.RowGuid = Guid.NewGuid();
                address.ZipCode = ContactZipCode.Text;
                address.PostalCode = ContactPOBox.Text;
                person.PersonHomePhoneMain = ContactPhoneNumber.Text.Trim();

                person.PersonFaxPhoneMain = ContactFaxNumber.Text.Trim();

                person.PersonMobileMain = ContactMobileNumber.Text;
            }
        }
        BusinessLogicLayer.Entities.Persons.Person person = new BusinessLogicLayer.Entities.Persons.Person();
        BusinessLogicLayer.Entities.Persons.PersonLanguages personLanguages = new BusinessLogicLayer.Entities.Persons.PersonLanguages();
        BusinessLogicLayer.Entities.Persons.EmailAddress emailAddresses = new BusinessLogicLayer.Entities.Persons.EmailAddress();
        BusinessLogicLayer.Entities.Persons.Address address = new BusinessLogicLayer.Entities.Persons.Address();
        public BusinessLogicLayer.Entities.Persons.Person CurrentPerson
        {
            get
            {

                SetData(person, personLanguages, emailAddresses, address);

                return person;
            }
        }
        public HtmlGenericControl ContactInfoSignupProperty
        {
            get
            {
                return ContactInfoSignup;
            }
        }
        #region Events
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

        public delegate void ProfileSaved(object sender, BusinessLogicLayer.Entities.Persons.Person profile);
        public event ProfileSaved ProfileSaveEvent;
        public void OnProfileSaveEvent(BusinessLogicLayer.Entities.Persons.Person profile)
        {
            if (ProfileSaveEvent != null)
            {
                ProfileSaveEvent(this, profile);
            }
        }

        protected void ContactEmailText_Validation(object sender, DevExpress.Web.ASPxEditors.ValidationEventArgs e)
        {
            if (!IsInProfile)
            {
                BusinessLogicLayer.Entities.Persons.Person person = BusinessLogicLayer.Common.PersonLogic.GetByUserName(ContactEmailText.Text.Trim());
                if (person != null)
                {
                    e.ErrorText = Resources.ConferenceFront.ContactForm_RegisteredEmail;
                    e.IsValid = false;
                }
                else
                    e.IsValid = true;
            }
        }
        #endregion

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
                if (Tools.IsImage(uploadedFile.FileBytes))
                {
                    Session["profileLogoUpload"] = fileName;
                    //uploadedFile.SaveAs(Server.MapPath("~/ContentData/Sites/Conferences/") + fileName, true);
                    byte[] thumb = Tools.CreateThumb(uploadedFile.FileBytes, 100, false);
                    //MemoryStream stream = new MemoryStream(thumb);
                    FileStream stream = new FileStream(Server.MapPath(BusinessLogicLayer.Common.PersonContentPath) + fileName, FileMode.Create);
                    byte[] thumbImage = Tools.CreateThumb(uploadedFile.FileBytes, 100, false);
                    stream.Write(thumbImage, 0, thumbImage.Length);
                    stream.Flush();
                    stream.Close();
                    BusinessLogicLayer.Entities.Persons.Person person = SecurityManager.getUser(this.Page);
                    person.PersonImage = fileName;
                    BusinessLogicLayer.Common.PersonLogic.Update(person, person.BusinessEntityId);
                }
                else
                {
                    BusinessLogicLayer.Components.UserMonitorLogic monitorLogic = new BusinessLogicLayer.Components.UserMonitorLogic();
                    string ipMain = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                    string IpForwardedFor = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                    string ip = String.Format("{0}-{1}", ipMain, IpForwardedFor);
                    int userid = 0;
                    if (SecurityManager.isLogged(this.Page))
                        userid = SecurityManager.getUser(this.Page).BusinessEntityId;
                    monitorLogic.Insert(userid, false, ip, fileName, DateTime.Now);
                    EmailManager.sendMail(String.Format("wrong file uploaded: {0} From IP: {1}", fileName, ip), "Qiyas File Upload Attempt", "ramy.mostafa@gmail.com");
                    fileName = "";
                }
            }
            else
            {

                BusinessLogicLayer.Components.UserMonitorLogic monitorLogic = new BusinessLogicLayer.Components.UserMonitorLogic();
                string ipMain = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                string IpForwardedFor = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                string ip = String.Format("{0}-{1}", ipMain, IpForwardedFor);
                int userid = 0;
                if (SecurityManager.isLogged(this.Page))
                    userid = SecurityManager.getUser(this.Page).BusinessEntityId;
                fileName = uploadedFile.FileName;
                monitorLogic.Insert(userid, false, ip, fileName, DateTime.Now);
                EmailManager.sendMail(String.Format("wrong file uploaded: {0} From IP: {1}", fileName, ip), "Qiyas File Upload Attempt", "ramy.mostafa@gmail.com");
                fileName = "";

            }
            return fileName;
        }
        protected void profileLogoUpload_FileUploadComplete(object sender, DevExpress.Web.ASPxUploadControl.FileUploadCompleteEventArgs e)
        {
            e.CallbackData = SavePostedFile(e.UploadedFile);
        }
        #endregion
    }
}