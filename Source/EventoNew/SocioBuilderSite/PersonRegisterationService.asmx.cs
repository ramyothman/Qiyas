using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SocioBuilderSite.Code.RbmCommon;

namespace SocioBuilderSite
{
    /// <summary>
    /// Summary description for PersonRegisterationService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PersonRegisterationService : System.Web.Services.WebService
    {

        [WebMethod]
        public BusinessLogicLayer.Entities.Persons.Person RegisterUser(string Title,string FirstName,string MiddleName,string LastName,string LicenseNumber,DateTime DateOfBirth,char Gender,string Email,bool IsEmailVerified,string Mobile,string Phone,string Fax,bool SetAddress,string AddressLine1,string City,string CountryCodeISO3,string ZipCode,string PostalCode,bool SetCredentials,string username,string password,out bool success,out string msg)
        {
            BusinessLogicLayer.Entities.Persons.Person person = new BusinessLogicLayer.Entities.Persons.Person();
            bool result = false;
            msg = "";
            try
            {

                BusinessLogicLayer.Entities.Persons.PersonLanguages personLanguages = new BusinessLogicLayer.Entities.Persons.PersonLanguages();
                BusinessLogicLayer.Entities.Persons.EmailAddress emailAddresses = new BusinessLogicLayer.Entities.Persons.EmailAddress();
                BusinessLogicLayer.Entities.Persons.Address address = new BusinessLogicLayer.Entities.Persons.Address();
                person.EmailPromotion = 1;
                person.NameStyle = false;
                person.Title = Title.Trim();
                person.FirstName = FirstName.Trim();
                person.MiddleName = MiddleName.Trim();
                person.LastName = LastName.Trim();
                person.DateofBirth = DateOfBirth;
                person.Gender = Gender.ToString();
                person.DisplayName = string.Format("{0} {1} {2}", person.Title, person.FirstName, person.LastName);

                BusinessLogicLayer.Common.PersonLogic.Insert(person);
                emailAddresses.BusinessEntityId = person.BusinessEntityId;
                emailAddresses.Email = Email.Trim();
                emailAddresses.EmailAddressTypeId = 1;
                emailAddresses.EmailVerificationHash = emailAddresses.EmailVerificationHash = Tools.MD5(emailAddresses.Email);
                emailAddresses.EmailVerified = false;
                BusinessLogicLayer.Common.EmailAddressLogic.Insert(emailAddresses);
                if (SetCredentials)
                {
                    BusinessLogicLayer.Entities.Persons.Credential credential = new BusinessLogicLayer.Entities.Persons.Credential();
                    credential.BusinessEntityId = person.BusinessEntityId;
                    credential.Username = username.Trim();
                    credential.IsActivated = false;
                    credential.ActivationCode = Tools.MD5(Email);
                    credential.IsActive = true;
                    credential.ModifiedDate = DateTime.Now;
                    credential.RowGuid = Guid.NewGuid();
                    credential.PasswordSalt = String.Format("{0}AICSSN", System.DateTime.Now.Second);
                    credential.PasswordHash = Tools.MD5(password + credential.PasswordSalt);
                    BusinessLogicLayer.Common.CredentialLogic.Insert(credential);
                    //EmailManager.SendSignupEmail(this, person.DisplayName, address.City, CountryCodeISO3, Phone, username, password, credential.ActivationCode, credential.Username);
                }
                if (SetAddress)
                {
                    address.AddressLine1 = AddressLine1.Trim();
                    address.City = City.Trim();
                    address.CountryRegionCode = CountryCodeISO3;
                    address.ModifiedDate = DateTime.Now;
                    address.RowGuid = Guid.NewGuid();
                    address.ZipCode = ZipCode;
                    address.PostalCode = PostalCode;
                    BusinessLogicLayer.Common.AddressLogic.Insert(address);
                    BusinessLogicLayer.Common.BusinessEntityAddressLogic.Insert(person.BusinessEntityId, address.AddressId, 1, Guid.NewGuid(), DateTime.Now);
                }
                string phone = Phone;
                string mainPhone = "";

                mainPhone = phone;
                BusinessLogicLayer.Common.PersonPhoneLogic.Insert(person.BusinessEntityId, phone, 1, DateTime.Now, true, "");
                phone = Fax;
                BusinessLogicLayer.Common.PersonPhoneLogic.Insert(person.BusinessEntityId, phone, 3, DateTime.Now, true, "");
                phone = Mobile;
                BusinessLogicLayer.Common.PersonPhoneLogic.Insert(person.BusinessEntityId, phone, 5, DateTime.Now, true, "");
                result = true;
                BusinessLogicLayer.Entities.Conference.ConferenceRegisterations registeration = new BusinessLogicLayer.Entities.Conference.ConferenceRegisterations();
                registeration.ConferenceId = 1;
                registeration.ConferenceRegistrationTypeId = 1;
                registeration.DateRegistered = DateTime.Now;
                registeration.Email = Email;
                registeration.FaxNumber = Fax;
                registeration.IsActive = true;
                registeration.LicenseNumber = LicenseNumber;
                registeration.MobileNumber = Mobile;
                registeration.PersonId = person.BusinessEntityId;
                registeration.PhoneNumber = Phone;
                registeration.PreConferenceWorkShopIncluded = true;
                BusinessLogicLayer.Common.ConferenceRegisterationsLogic.Insert(registeration);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            
            success = result;
            return person;
        }

        [WebMethod]
        public BusinessLogicLayer.Entities.Persons.Person GetPerson(string email)
        {
            BusinessLogicLayer.Entities.Persons.Person person = BusinessLogicLayer.Common.PersonLogic.GetByUserName(email);
            return person;
        }

        [WebMethod]
        public BusinessLogicLayer.Entities.Persons.Person GetPerson(int id)
        {
            BusinessLogicLayer.Entities.Persons.Person person = BusinessLogicLayer.Common.PersonLogic.GetByID(id);
            return person;
        }

        [WebMethod]
        public List<BusinessLogicLayer.Entities.Conference.ConferenceRegisterations> GetRegisterations()
        {
            BusinessLogicLayer.Components.Conference.ConferenceRegisterationsLogic cregisterations = new BusinessLogicLayer.Components.Conference.ConferenceRegisterationsLogic();
            List<BusinessLogicLayer.Entities.Conference.ConferenceRegisterations> registerationsList = cregisterations.GetAll();
            return registerationsList;
        }

        [WebMethod]
        public BusinessLogicLayer.Entities.Conference.ConferenceRegisterations GetPersonRegisteration(string email)
        {
            BusinessLogicLayer.Components.Conference.ConferenceRegisterationsLogic cregisterations = new BusinessLogicLayer.Components.Conference.ConferenceRegisterationsLogic();
            BusinessLogicLayer.Entities.Persons.Person person = BusinessLogicLayer.Common.PersonLogic.GetByUserName(email);
            BusinessLogicLayer.Entities.Conference.ConferenceRegisterations registeration = new BusinessLogicLayer.Entities.Conference.ConferenceRegisterations();
            if(person != null)
            {
                registeration = cregisterations.GetByID(1, person.BusinessEntityId);
            }
            return registeration;
        }
    }
}
