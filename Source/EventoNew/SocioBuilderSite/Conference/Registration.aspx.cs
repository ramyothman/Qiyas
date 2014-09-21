using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocioBuilderSite.Code.RbmSecurity;
using SocioBuilderSite.Code.Payments;
using DevExpress.Web.ASPxEditors;

namespace SocioBuilderSite.Conference
{
    public partial class Registration : Code.RbmCommon.ConferenceBasePage
    {
        #region Generated Properties
        List<DevExpress.Web.ASPxEditors.ASPxCheckBox> RegistrationChecks
        {
            get
            {
                List<ASPxCheckBox> result = new List<ASPxCheckBox>();
                if (Session["RegistrationChecksSession"] == null)
                {
                    BusinessLogicLayer.Entities.Conference.Conferences conference = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this);
                    foreach (BusinessLogicLayer.Entities.Conference.ConferenceRegistrationType type in conference.RegistrationTypes)
                    {
                        ASPxCheckBox list = new ASPxCheckBox();
                        list.ID = "regRegistrationType" + type.ConferenceRegistrationTypeId;
                        list.ClientInstanceName = list.ID;
                        if (Code.RbmCommon.ConferenceBasePage.GetCurrentPageLanguageId(this).ToString() == BusinessLogicLayer.Common.DefaultLanguageId)
                        {
                            list.Text = type.Name;
                        }
                        else
                        {
                            BusinessLogicLayer.Entities.Conference.ConferenceRegistrationTypeLanguage lang = type.GetTypeLanguageByLanguageID(Code.RbmCommon.ConferenceBasePage.GetCurrentPageLanguageId(this));
                            if (lang != null)
                                list.Text = lang.Name;
                        }
                        //string clientMethod = "function(s, e) { OnListBoxSelectionChangedExt(s,e,\'ovrCategoryddl" + cat.OVRCategoryId.ToString() + "\',\'ovrCategorylist" + cat.OVRCategoryId.ToString()  + "\');}";
                        //list.ClientSideEvents.SelectedIndexChanged = clientMethod;
                        result.Add(list);
                    }
                    Session["RegistrationChecksSession"] = result;
                }
                return Session["RegistrationChecksSession"] as List<ASPxCheckBox>;
            }
        }
        #endregion
        public List<BusinessLogicLayer.Entities.Conference.ConferenceRegistrationType> ConferenceRegistrationTypeList
        {
            get
            {
                BusinessLogicLayer.Entities.Conference.Conferences conference = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this);
                string sessionKey = "ConferenceRegistrationTypeList" + conference.ConferenceId;
                List<BusinessLogicLayer.Entities.Conference.ConferenceRegistrationType> temp;
                if (Session[sessionKey] == null)
                {
                    temp = new BusinessLogicLayer.Components.Conference.ConferenceRegistrationTypeLogic().GetAllByConferenceId(conference.ConferenceId, Code.RbmCommon.ConferenceBasePage.GetCurrentPageLanguageId(this));    
                    Session[sessionKey] = temp;
                }
                return Session[sessionKey] as List<BusinessLogicLayer.Entities.Conference.ConferenceRegistrationType>;
            }
        }
        EmailManager emailManager = new EmailManager();
        private void PopulateQuestions()
        {
            foreach (BusinessLogicLayer.Entities.Conference.ConferenceRegistrationType q in ConferenceRegistrationTypeList)
            {

                Panel p = new Panel();
                p.Attributes["class"] = "QuestionPanel";
                p.ID = "Panel" + q.ConferenceRegistrationTypeId.ToString();
                Code.RbmCommon.RegistrationInterfaceHelper.AddQuestionAdvanced(q, p);
                ResultsAreas.Controls.Add(p);


            }
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            PopulateQuestions();
            //if (!IsPostBack)
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            emailManager.SendEmailEvent += new EmailManager.SendEmailEventHandler(emailManager.SendEmail);
            if (!SecurityManager.isLogged(this.Page))
            {
                Response.Redirect("~/Conference/RequestLogin.aspx");
            }
            if (!IsPostBack)
            {
                BusinessLogicLayer.Entities.Conference.Conferences conference = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this);
                if (!conference.IsRegistrationActive())
                {
                    Response.Redirect("~/Conference/Default.aspx");
                }
                else
                {
                    BusinessLogicLayer.Entities.Conference.ConferenceRegistrationSettingLanguages settingsLang = conference.CurrentConferenceRegistrationSettings.GetSettingLanguageByLanguageID(Code.RbmCommon.ConferenceBasePage.GetCurrentPageLanguageId(this));
                    RegistrationForm_Post.Text = settingsLang.RegistrationInstructionsInFormPost;
                    RegistrationForm_Pre.Text = settingsLang.RegistrationInstructionsInFormPre;
                }
                if (SecurityManager.isLogged(this.Page))
                {
                    RegistrationMedicalDoctorsCheck.Checked = true;
                    BusinessLogicLayer.Entities.Persons.Person person = SecurityManager.getUser(this.Page);
                    
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
            BusinessLogicLayer.Entities.Conference.Conferences conference = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this);
            if (person != null && conference != null)
            {
                //if (!string.IsNullOrEmpty(registeration.AcademicInformationDegree))
                //    RegistrationDegree.SelectedIndex = RegistrationDegree.Items.FindByText(registeration.AcademicInformationDegree).Index;
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
            BusinessLogicLayer.Entities.Conference.Conferences conference = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this);
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
                //registeration.AOAAdministrator = AOAAdministrator.Checked;
                //registeration.AOAAlliedHealthProfessional = AOAAlliedHealthProfessional.Checked;
                //registeration.AOABasicResearcher = AOABasicResearcher.Checked;
                //registeration.AOAClinicalPractitioner = AOAClinicalPractitioner.Checked;
                //registeration.AOAClinicalResearcher = AOAClinicalResearcher.Checked;
                //registeration.AOAIndustryRepresentative = AOAIndustryRepresentative.Checked;
                //registeration.AOAMAnemia = AOAMAnemia.Checked;
                //registeration.AOAMCNAcuteKidneyInjury = AOAMCNAcuteKidneyInjury.Checked;
                //registeration.AOAMCNChronicKidneyDisease = AOAMCNChronicKidneyDisease.Checked;
                //registeration.AOAMCNGlomerulonephritis = AOAMCNGlomerulonephritis.Checked;
                //registeration.AOAMCNHypertension = AOAMCNHypertension.Checked;
                //registeration.AOAMCNNephrolithiasis = AOAMCNNephrolithiasis.Checked;
                //registeration.AOAMDiabetes = AOAMDiabetes.Checked;
                //registeration.AOAMGenetics = AOAMGenetics.Checked;
                //registeration.AOAMImmunology = AOAMImmunology.Checked;
                //registeration.AOAMIterventionalCCN = AOAMIterventionalCCN.Checked;
                //registeration.AOAMMineralMetabolism = AOAMMineralMetabolism.Checked;
                //registeration.AOAMOther = AOAMOther.Checked;
                //registeration.AOAMOtherText = AOAMOtherText.Value;
                //registeration.AOAMRRTCRRT = AOAMRRTCRRT.Checked;
                //registeration.AOAMRRTHemodialysis = AOAMRRTHemodialysis.Checked;
                //registeration.AOAMRRTPertionealDialysis = AOAMRRTPertionealDialysis.Checked;
                //registeration.AOAMUrology = AOAMUrology.Checked;
                //registeration.AOAOther = AOAOther.Checked;
                //registeration.AOARetired = AOARetired.Checked;
                //registeration.AOAStudent = AOAStudent.Checked;
                //registeration.AOATeacherEducator = AOATeacherEducator.Checked;
                registeration.City = person.MainPersonAddress.City;
                registeration.ConferenceId = conference.ConferenceId;
                if (RegistrationMedicalDoctorsCheck.Checked)
                    registeration.ConferenceRegistrationTypeId = 1;
                else
                    registeration.ConferenceRegistrationTypeId = 2;

                registeration.Country = person.MainPersonAddress.CountryName;
                if (registeration.NewRecord)
                    registeration.DateRegistered = DateTime.Now;
                registeration.PersonId = person.BusinessEntityId;
                registeration.PhoneNumber = person.PersonHomePhoneMain;
                registeration.POBox = person.MainPersonAddress.PostalCode;
                registeration.PreConferenceWorkShopIncluded = PreConferenceWorkShopIncluded.Checked;
                if(RegistrationCategoryRadio.SelectedItem != null)
                    registeration.RegitrationCategory = RegistrationCategoryRadio.SelectedItem.Text;
                registeration.SponsorName = RegistrationSponsorsCombo.Text;
                registeration.SubscribeToNewsLetter = SubscribeToNewsLetter.Checked;
                registeration.ZipCode = person.MainPersonAddress.ZipCode;
                registeration.IsActive = false;
                //registeration.DateRegistered = DateTime.Now;
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
            BusinessLogicLayer.Entities.Conference.Conferences conference = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this);
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
                BusinessLogicLayer.Common.ConferenceRegisterationsLogic.Update(registration, registration.ConferenceRegistererId);
                Session["RegistrationPayment"] = registration.CurrentConferenceRegistrationType.Fee;
                Session["RegistrationCurrent"] = registration;
            }
            #region Get Submitted Generated Data
            List<BusinessLogicLayer.Entities.Conference.ConferenceRegistrationItems> surveyAnswers = Code.RbmCommon.RegistrationInterfaceHelper.RetrieveUserAnswers(ResultsAreas);
            BusinessLogicLayer.Components.Conference.ConferenceRegistrationItemsLogic itemsLogic = new BusinessLogicLayer.Components.Conference.ConferenceRegistrationItemsLogic();
            itemsLogic.DeleteByRegitrationID(registration.ConferenceRegistererId);
            foreach (BusinessLogicLayer.Entities.Conference.ConferenceRegistrationItems item in surveyAnswers)
            {
                item.ConferenceRegistererId = registration.ConferenceRegistererId;
                itemsLogic.Insert(item);
            }
            
            #endregion
            #region EmailManager
            SocioBuilderSite.Code.EmailManagement.EmailSenderEventArgs args = new Code.EmailManagement.EmailSenderEventArgs();
            args.EmailType = EmailManager.EmailTypes.Register;
            args.CurrentPerson = person;
            args.CurrentPage = this;
            args.LanguageId = GetCurrentPageLanguageId(this);
            args.CurrentConference = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this);
            args.ToUser = person.EmailAddressPrimaryObject.Email;
            emailManager.OnSendEmail(args);
            #endregion

            #region Invoice
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
                product.Price += 1125;//registration.CurrentConferenceRegistrationType.Fee;
            if (PreConferenceWorkShopIncluded.Checked)
                product.Price += 1125;
            if (PreConferenceWorkShopIncluded2.Checked)
                product.Price += 1125;
            product.Shipping = 0;
            product.Taxable = false;
            //SelectedInvoice.SubTotal = product.Price;
            SelectedInvoice.AddToInvoice(product, 1);
            #endregion
            Response.Redirect("~/Conference/FinishRegistration.aspx");
        }
    }
}