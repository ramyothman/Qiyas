using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocioBuilderSite.Code.RbmSecurity;

namespace SocioBuilderSite.Conference
{
    public partial class SpeakersInfo : Code.RbmCommon.ConferenceBasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int personId = 0;
                Int32.TryParse(Request["person"], out personId);
                int speakerId = 0;
                Int32.TryParse(Request["speaker"], out speakerId);
                if (personId == 0)
                {
                    if(SecurityManager.isLogged(this.Page))
                        personId = SecurityManager.getUser(this.Page).BusinessEntityId;
                }
                BusinessLogicLayer.Entities.Persons.Person p = BusinessLogicLayer.Common.PersonLogic.GetByID(personId);
                if(p == null)
                    Response.Redirect("~/Conference/Default.aspx");
                LoadData(p,speakerId);
            }
        }

        private void LoadData(BusinessLogicLayer.Entities.Persons.Person person,int speakerId)
        {
            
            //ContactDateofBirthLabel.Text = person.DateofBirth.ToString("dd/MM/yyyy");
            ContactEmailLabel.Text = person.EmailAddressPrimaryObject.Email;
            string gender = "Male";
            if (person.Gender == "F")
                gender = "Female";
            //ContactGenderLabel.Text = gender;
            ContactNameLabel.Text = person.DisplayName;
            if (!string.IsNullOrEmpty(person.PersonImage))
                currentProfileImage.ImageUrl = BusinessLogicLayer.Common.PersonContentPath + person.PersonImage;
            BusinessLogicLayer.Entities.Conference.ConferenceSpeakers s = BusinessLogicLayer.Common.ConferenceSpeakersLogic.GetByID(speakerId);
            s.UpdateSpeakerLanguage(Code.RbmCommon.ConferenceBasePage.GetCurrentPageLanguageId(this));
            if (s != null)
            {
                ContactNameLabel.Text = s.CurrentPerson.DisplayName;
                SpeakerPosition.InnerText = s.SpeakerPosition;
                SpeakersInfoPar.InnerText = s.SpeakerBio;
                currentProfileImage.ImageUrl = BusinessLogicLayer.Common.SpeakersDefaultImageFolder + s.SpeakerImage;
            }
            //ContactFaxNumberLabel.Text = person.PersonFaxPhoneMain;
            //ContactMobileNumberLabel.Text = person.PersonMobileMain;
            //ContactAddressLabel.Text = person.MainPersonAddress.AddressLine1;
            //ContactCityLabel.Text = person.MainPersonAddress.City;
            //ContactCountryLabel.Text = person.MainPersonAddress.CountryName;
            //ContactPhoneNumberLabel.Text = person.PersonHomePhoneMain;
            //ContactPOBoxLabel.Text = person.MainPersonAddress.PostalCode;
            //ContactZipCodeLabel.Text = person.MainPersonAddress.ZipCode;
            
        }
    }
}