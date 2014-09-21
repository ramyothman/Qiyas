using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocioBuilderSite.Code.RbmSecurity;
using DevExpress.Web.ASPxUploadControl;
using System.IO;
using SocioBuilderSite.Code.RbmCommon;
using SocioBuilderSite.Controls.Conference;

namespace SocioBuilderSite.Conference.Controls
{
    public partial class ProfileInformation : System.Web.UI.UserControl
    {
        public ContactInfo CurrentContactInfo
        {
            get { return CIC1; }
        }
        DevExpress.Web.ASPxHiddenField.ASPxHiddenField _WizardHidden;
        public DevExpress.Web.ASPxHiddenField.ASPxHiddenField WizardHidden
        {
            set
            {
                _WizardHidden = value;
            }
            get
            {
                if (_WizardHidden == null)
                {
                    _WizardHidden = new DevExpress.Web.ASPxHiddenField.ASPxHiddenField();
                }
                return _WizardHidden;
            }
        }
        private void LoadData(BusinessLogicLayer.Entities.Persons.Person person)
        {
            if (SecurityManager.isLogged(this.Page))
            {
                WizardHidden.Set("Mobile",person.PersonMobileMain);
                WizardHidden.Set("Address",person.MainPersonAddress.CountryName + ", " + person.MainPersonAddress.City );
                WizardHidden.Set("FullName", person.FirstName + " " + person.LastName);
                WizardHidden.Set("Email",person.EmailAddressPrimaryObject.Email);

                ContactAddressLabel.Text = person.MainPersonAddress.AddressLine1;
                ContactCityLabel.Text = person.MainPersonAddress.City;
                ContactCountryLabel.Text = person.MainPersonAddress.CountryName;
                ContactDateofBirthLabel.Text = person.DateofBirth.ToString("dd/MM/yyyy");
                ContactEmailLabel.Text = person.EmailAddressPrimaryObject.Email;
                ContactFaxNumberLabel.Text = person.PersonFaxPhoneMain;
                string gender = "Male";
                if (person.Gender == "F")
                    gender = "Female";
                ContactGenderLabel.Text = gender;
                ContactMobileNumberLabel.Text = person.PersonMobileMain;
                ContactNameLabel.Text = person.DisplayName;
                ContactPhoneNumberLabel.Text = person.PersonHomePhoneMain;
                ContactPOBoxLabel.Text = person.MainPersonAddress.PostalCode;
                ContactZipCodeLabel.Text = person.MainPersonAddress.ZipCode;
                if (!string.IsNullOrEmpty(person.PersonImage))
                    currentProfileImage.ImageUrl = BusinessLogicLayer.Common.PersonContentPath + person.PersonImage;

            }
            //else
            //{
            //    Response.Redirect("~/Conference/Default.aspx");
            //}
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            CIC1.IsInProfile = SecurityManager.isLogged(this.Page);
            if (!CIC1.IsInProfile)
            {
                ProfileMultiView.ActiveViewIndex = 1;
                WizardHidden.Set("IsInEdit", true);
            }
            CIC1.ProfileSaveEvent += new ContactInfo.ProfileSaved(ProfileSaved_OnSaved);
            if (!IsPostBack)
            {
                LoadData(SecurityManager.getUser(this.Page));
            }
            else
            {
                LoadData(SecurityManager.getUser(this.Page));
            }

        }

        public BusinessLogicLayer.Entities.Persons.Person CurrentPerson
        {
            get
            {
                BusinessLogicLayer.Entities.Persons.Person person;
                if (CIC1.IsInProfile && ProfileMultiView.ActiveViewIndex == 0)
                {
                    person = SecurityManager.getUser(this.Page);
                }
                else
                {
                    person = CIC1.CurrentPerson;
                }
                return person;
            }
        }

        public void ProfileSaved_OnSaved(object sender, BusinessLogicLayer.Entities.Persons.Person value)
        {
            ProfileMultiView.ActiveViewIndex = 0;
            WizardHidden.Set("IsInEdit", false);
            LoadData(value);
        }
        protected void currentLinkEdit_Click(object sender, EventArgs e)
        {
            ProfileMultiView.ActiveViewIndex = 1;
            WizardHidden.Set("IsInEdit", true);
        }
    }
}