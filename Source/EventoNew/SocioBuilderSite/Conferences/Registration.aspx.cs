using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocioBuilderSite.Code.RbmSecurity;
using SocioBuilderSite.Code.Payments;

namespace SocioBuilderSite.Conferences
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!SecurityManager.isLogged(this.Page))
            {
                Response.Redirect("~/Conferences/RequestLogin.aspx");
                
            }
            if (!IsPostBack)
            {
                if (SecurityManager.isLogged(this.Page))
                {
                    RegistrationMedicalDoctorsCheck.Checked = true;
                    BusinessLogicLayer.Entities.Persons.Person person = SecurityManager.getUser(this.Page);
                    BusinessLogicLayer.Entities.Conference.Conferences conference = Application["CurrentApplicationConference"] as BusinessLogicLayer.Entities.Conference.Conferences;
                    BusinessLogicLayer.Entities.Conference.ConferenceRegisterations registration = BusinessLogicLayer.Common.ConferenceRegisterationsLogic.GetByID(conference.ConferenceId, person.BusinessEntityId);
                    if (registration != null)
                    {
                        LoadData(registration);
                    }
                }
            }
        }
        private void LoadData(BusinessLogicLayer.Entities.Conference.ConferenceRegisterations registeration)
        {
            BusinessLogicLayer.Entities.Persons.Person person = SecurityManager.getUser(this.Page);
            BusinessLogicLayer.Entities.Conference.Conferences conference = Application["CurrentApplicationConference"] as BusinessLogicLayer.Entities.Conference.Conferences;
            if (person != null && conference != null)
            {
                if (!string.IsNullOrEmpty(registeration.AcademicInformationDegree))
                    RegistrationDegree.SelectedIndex = RegistrationDegree.Items.FindByText(registeration.AcademicInformationDegree).Index;
                if (RegistrationDegree.SelectedItem.Index == 4)
                {
                    RegistrationDegreeOther.Text = registeration.AcademicInformationHealthCareProValue;
                }
                if (registeration.IsMember)
                    RegisterMember.SelectedIndex = 0;
                else
                    RegisterMember.SelectedIndex = 1;
                if (registeration.IsSelfSponsor)
                    RegistrationCategoryRadio.SelectedIndex = 0;
                else
                {
                    RegistrationCategoryRadio.SelectedIndex = 1;
                    RegistrationSponsorsCombo.Visible = true;
                }
                RegistrationPositionAcademic.Text = registeration.AcademicInformationPosition;
                AOAAdministrator.Checked = registeration.AOAAdministrator;
                AOAAlliedHealthProfessional.Checked = registeration.AOAAlliedHealthProfessional;
                AOABasicResearcher.Checked = registeration.AOABasicResearcher;
                AOAClinicalPractitioner.Checked = registeration.AOAClinicalPractitioner;
                AOAClinicalResearcher.Checked = registeration.AOAClinicalResearcher;
                AOAIndustryRepresentative.Checked = registeration.AOAIndustryRepresentative;
                AOAMAnemia.Checked = registeration.AOAMAnemia;
                AOAMCNAcuteKidneyInjury.Checked = registeration.AOAMCNAcuteKidneyInjury;
                AOAMCNChronicKidneyDisease.Checked = registeration.AOAMCNChronicKidneyDisease;
                AOAMCNGlomerulonephritis.Checked = registeration.AOAMCNGlomerulonephritis;
                AOAMCNHypertension.Checked = registeration.AOAMCNHypertension;
                AOAMCNNephrolithiasis.Checked = registeration.AOAMCNNephrolithiasis;
                AOAMDiabetes.Checked = registeration.AOAMDiabetes;
                AOAMGenetics.Checked = registeration.AOAMGenetics;
                AOAMImmunology.Checked = registeration.AOAMImmunology;
                AOAMIterventionalCCN.Checked = registeration.AOAMIterventionalCCN;
                AOAMMineralMetabolism.Checked = registeration.AOAMMineralMetabolism;
                AOAMOther.Checked = registeration.AOAMOther;
                AOAMOtherText.Value = registeration.AOAMOtherText;
                AOAMRRTCRRT.Checked = registeration.AOAMRRTCRRT;
                AOAMRRTHemodialysis.Checked = registeration.AOAMRRTHemodialysis;
                AOAMRRTPertionealDialysis.Checked = registeration.AOAMRRTPertionealDialysis;
                AOAMUrology.Checked = registeration.AOAMUrology;
                AOAOther.Checked = registeration.AOAOther;
                AOAOther.Checked = registeration.AOARetired;
                AOAStudent.Checked = registeration.AOAStudent;
                AOATeacherEducator.Checked = registeration.AOATeacherEducator;
                if (registeration.ConferenceRegistrationTypeId == 1)
                    RegistrationMedicalDoctorsCheck.Checked = true;
                else
                    RegistrationHealthProfessionalCheck.Checked = true;

                PreConferenceWorkShopIncluded.Checked = registeration.PreConferenceWorkShopIncluded;
                if (!string.IsNullOrEmpty(registeration.RegitrationCategory))
                {
                    RegistrationCategoryRadio.SelectedIndex = RegistrationCategoryRadio.Items.IndexOfText(registeration.RegitrationCategory);
                }
                RegistrationSponsorsCombo.Text = registeration.SponsorName;
                SubscribeToNewsLetter.Checked = registeration.SubscribeToNewsLetter;
                //SubmitRegistrationForm.Visible = false;
            }
        }
        private void SetData(BusinessLogicLayer.Entities.Conference.ConferenceRegisterations registeration)
        {
            BusinessLogicLayer.Entities.Persons.Person person = SecurityManager.getUser(this.Page);
            BusinessLogicLayer.Entities.Conference.Conferences conference = Application["CurrentApplicationConference"] as BusinessLogicLayer.Entities.Conference.Conferences;
            if (person != null && conference != null)
            {
                registeration.AcademicInformationDegree = RegistrationDegree.SelectedItem.Text;
                if (RegistrationDegree.SelectedItem.Index == 4)
                {
                    registeration.AcademicInformationHealthCarePro = true;
                    registeration.AcademicInformationHealthCareProValue = RegistrationDegreeOther.Text;
                }
                if (RegisterMember.SelectedIndex == 0)
                    registeration.IsMember = true;
                else
                    registeration.IsMember = false;
                if (RegistrationCategoryRadio.SelectedIndex == 0)
                    registeration.IsSelfSponsor = true;
                else
                    registeration.IsSelfSponsor = false;
                registeration.AcademicInformationPosition = RegistrationPositionAcademic.Text;
                registeration.Address = person.MainPersonAddress.AddressLine1;
                registeration.AOAAdministrator = AOAAdministrator.Checked;
                registeration.AOAAlliedHealthProfessional = AOAAlliedHealthProfessional.Checked;
                registeration.AOABasicResearcher = AOABasicResearcher.Checked;
                registeration.AOAClinicalPractitioner = AOAClinicalPractitioner.Checked;
                registeration.AOAClinicalResearcher = AOAClinicalResearcher.Checked;
                registeration.AOAIndustryRepresentative = AOAIndustryRepresentative.Checked;
                registeration.AOAMAnemia = AOAMAnemia.Checked;
                registeration.AOAMCNAcuteKidneyInjury = AOAMCNAcuteKidneyInjury.Checked;
                registeration.AOAMCNChronicKidneyDisease = AOAMCNChronicKidneyDisease.Checked;
                registeration.AOAMCNGlomerulonephritis = AOAMCNGlomerulonephritis.Checked;
                registeration.AOAMCNHypertension = AOAMCNHypertension.Checked;
                registeration.AOAMCNNephrolithiasis = AOAMCNNephrolithiasis.Checked;
                registeration.AOAMDiabetes = AOAMDiabetes.Checked;
                registeration.AOAMGenetics = AOAMGenetics.Checked;
                registeration.AOAMImmunology = AOAMImmunology.Checked;
                registeration.AOAMIterventionalCCN = AOAMIterventionalCCN.Checked;
                registeration.AOAMMineralMetabolism = AOAMMineralMetabolism.Checked;
                registeration.AOAMOther = AOAMOther.Checked;
                registeration.AOAMOtherText = AOAMOtherText.Value;
                registeration.AOAMRRTCRRT = AOAMRRTCRRT.Checked;
                registeration.AOAMRRTHemodialysis = AOAMRRTHemodialysis.Checked;
                registeration.AOAMRRTPertionealDialysis = AOAMRRTPertionealDialysis.Checked;
                registeration.AOAMUrology = AOAMUrology.Checked;
                registeration.AOAOther = AOAOther.Checked;
                registeration.AOARetired = AOARetired.Checked;
                registeration.AOAStudent = AOAStudent.Checked;
                registeration.AOATeacherEducator = AOATeacherEducator.Checked;
                registeration.City = person.MainPersonAddress.City;
                registeration.ConferenceId = conference.ConferenceId;
                if (RegistrationMedicalDoctorsCheck.Checked)
                    registeration.ConferenceRegistrationTypeId = 1;
                else
                    registeration.ConferenceRegistrationTypeId = 2;

                registeration.Country = person.MainPersonAddress.CountryName;
                if(registeration.NewRecord)
                    registeration.DateRegistered = DateTime.Now;
                registeration.PersonId = person.BusinessEntityId;
                registeration.PhoneNumber = person.PersonHomePhoneMain;
                registeration.POBox = person.MainPersonAddress.PostalCode;
                registeration.PreConferenceWorkShopIncluded = PreConferenceWorkShopIncluded.Checked;
                registeration.RegitrationCategory = RegistrationCategoryRadio.SelectedItem.Text;
                registeration.SponsorName = RegistrationSponsorsCombo.Text;
                registeration.SubscribeToNewsLetter = SubscribeToNewsLetter.Checked;
                registeration.ZipCode = person.MainPersonAddress.ZipCode;
                registeration.IsActive = false;
            }
        }
        private Invoice _selectedInvoice = new Invoice();
        public Invoice SelectedInvoice
        {
            get
            {
                if (_selectedInvoice.InvoiceId == "")
                {
                    _selectedInvoice = Session["CurrentInvoice"] as Invoice;
                    if (_selectedInvoice == null)
                    {
                        _selectedInvoice = new Invoice();
                        Session["CurrentInvoice"] = _selectedInvoice;
                    }
                }
                return _selectedInvoice;
            }
        }
        public void SubmitRegistrationForm_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.Entities.Persons.Person person = SecurityManager.getUser(this.Page);
            BusinessLogicLayer.Entities.Conference.Conferences conference = Application["CurrentApplicationConference"] as BusinessLogicLayer.Entities.Conference.Conferences;
            BusinessLogicLayer.Entities.Conference.ConferenceRegisterations registration = BusinessLogicLayer.Common.ConferenceRegisterationsLogic.GetByID(conference.ConferenceId, person.BusinessEntityId);
            if (registration == null)
            {
                registration = new BusinessLogicLayer.Entities.Conference.ConferenceRegisterations();
                SetData(registration);
                BusinessLogicLayer.Common.ConferenceRegisterationsLogic.Insert(registration);
                Session["RegistrationPayment"] = registration.CurrentConferenceRegistrationType.Fee;
                Session["RegistrationCurrent"] = registration;
            }
            else
            {
                SetData(registration);
                BusinessLogicLayer.Common.ConferenceRegisterationsLogic.Update(registration,registration.ConferenceRegistererId);
                Session["RegistrationPayment"] = registration.CurrentConferenceRegistrationType.Fee;
                Session["RegistrationCurrent"] = registration;
               
            }
            SelectedInvoice.InvoiceId = conference.ConferenceName + registration.ConferenceRegistererId;
            SelectedInvoice.ContactTitle = person.Title;
            SelectedInvoice.ContactFirstName = person.FirstName;
            SelectedInvoice.ContactLastName = person.LastName;
            SelectedInvoice.ContactAddress1 = person.MainPersonAddress.AddressLine1;
            SelectedInvoice.ContactAddress2 = person.MainPersonAddress.AddressLine2;
            SelectedInvoice.ContactCity = person.MainPersonAddress.City;
            SelectedInvoice.ContactCountry = person.MainPersonAddress.CountryName;
            SelectedInvoice.ContactEmail = person.EmailAddressPrimaryObject.Email;
            SelectedInvoice.ContactName = person.FullName;
            SelectedInvoice.ContactPhone = person.PersonHomePhoneMain;
            SelectedInvoice.ContactZip = person.MainPersonAddress.ZipCode;
            SelectedInvoice.Currency = "SAR";
            SelectedInvoice.ShipToAddress1 = person.MainPersonAddress.AddressLine1;
            SelectedInvoice.ShipToAddress2 = person.MainPersonAddress.AddressLine2;
            SelectedInvoice.ShipToCity = person.MainPersonAddress.City;
            SelectedInvoice.ShipToCountry = person.MainPersonAddress.CountryName;
            SelectedInvoice.ShipToName = person.FullName;
            SelectedInvoice.ShipToZip = person.MainPersonAddress.ZipCode;
            Product product = new Product();
            product.Name = registration.CurrentConferenceRegistrationType.Name;
            product.ProductId = registration.ConferenceRegistrationTypeId;
            if (RegistrationMedicalDoctorsCheck.Checked)
                product.Price = 600;//registration.CurrentConferenceRegistrationType.Fee;
            else
                product.Price = 400;
            product.Shipping = 0;
            product.Taxable = false;
            SelectedInvoice.AddToInvoice(product,1);
            Response.Redirect("~/Conferences/MakePayment.aspx");
        }
    }
}