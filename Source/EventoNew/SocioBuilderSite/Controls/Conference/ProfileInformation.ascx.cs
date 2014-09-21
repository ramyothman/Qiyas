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

namespace SocioBuilderSite.Controls.Conference
{
    public partial class ProfileInformation : System.Web.UI.UserControl
    {
        private void LoadData(BusinessLogicLayer.Entities.Persons.Person person)
        {
            if (SecurityManager.isLogged(this.Page))
            {
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
            else
            {
                Response.Redirect("~/Conference/Default.aspx");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
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

        public void ProfileSaved_OnSaved(object sender, BusinessLogicLayer.Entities.Persons.Person value)
        {
            ProfileMultiView.ActiveViewIndex = 0;
            LoadData(value);
        }
        protected void currentLinkEdit_Click(object sender, EventArgs e)
        {
            ProfileMultiView.ActiveViewIndex = 1;
        }

    }
}