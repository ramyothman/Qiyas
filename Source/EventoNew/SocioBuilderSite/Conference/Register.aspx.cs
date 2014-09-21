using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocioBuilderSite.Code.RbmSecurity;
using SocioBuilderSite.Code.Payments;
using DevExpress.Web.ASPxEditors;
using System.Linq;
using System.Linq.Expressions;
namespace SocioBuilderSite.Conference
{
    public partial class Register : Code.RbmCommon.ConferenceBasePage
    {
        #region wizard Events
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
            set
            {
                _selectedInvoice = new Invoice();
                Session["CurrentInvoice"] = _selectedInvoice;
            }
        }


        protected void pc_Init(object sender, EventArgs e)
        {

        }

        protected void pc_BeforeGetCallbackResult(object sender, EventArgs e)
        {

        }
        #endregion

        #region Generating Types
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
                string sessionKey = "ConferenceRegisterTypeList" + conference.ConferenceId;
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
            //BusinessLogicLayer.Entities.Conference.Conferences conference = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this);
            //BusinessLogicLayer.Entities.Conference.ConferenceRegistrationSettingLanguages settingsLang = conference.CurrentConferenceRegistrationSettings.GetSettingLanguageByLanguageID(Code.RbmCommon.ConferenceBasePage.GetCurrentPageLanguageId(this));
            //RegistrationForm_Post.Text = settingsLang.RegistrationInstructionsInFormPost;
            //RegistrationForm_Pre.Text = settingsLang.RegistrationInstructionsInFormPre;
            ProfileInformation1.WizardHidden = WizardHidden;
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            emailManager.SendEmailEvent += new EmailManager.SendEmailEventHandler(emailManager.SendEmail);
            if (!IsPostBack)
            {
                SelectedInvoice = null;
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

        protected void callbackConfirmationPreview_Callback(object sender, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            #region Get Submitted Generated Data

            List<BusinessLogicLayer.Entities.Conference.ConferenceRegistrationItems> surveyAnswers = Code.RbmCommon.RegistrationInterfaceHelper.RetrieveUserAnswers(ResultsAreas);
            BusinessLogicLayer.Components.Conference.ConferenceRegistrationItemsLogic itemsLogic = new BusinessLogicLayer.Components.Conference.ConferenceRegistrationItemsLogic();
            Table table = new Table();
            decimal total = 0;
            foreach (BusinessLogicLayer.Entities.Conference.ConferenceRegistrationItems item in surveyAnswers)
            {
                TableRow row = new TableRow();
                TableCell cellName = new TableCell();
                cellName.CssClass = "table-cell-name";
                TableCell cellPayment = new TableCell();
                cellPayment.CssClass = "table-cell-value";
                var itemType = (from x in ConferenceRegistrationTypeList where x.ConferenceRegistrationTypeId == item.ConferenceRegistrationTypeID select x).FirstOrDefault();
                if (itemType != null)
                {
                    cellName.Text = itemType.NameLanguage;
                    if (DateTime.Today > itemType.EarlyRegistrationEndDate)
                    {
                        cellPayment.Text = itemType.LateFee.ToString() + Resources.ConferenceFront.Registration_Currency;
                        total += itemType.LateFee;
                    }
                    else
                    {
                        cellPayment.Text = itemType.Fee.ToString() + Resources.ConferenceFront.Registration_Currency;
                        total += itemType.Fee;
                    }
                    row.Cells.Add(cellName);
                    row.Cells.Add(cellPayment);
                    table.Rows.Add(row);
                }
            }
            TableRow rowTotal = new TableRow();
            TableCell cellNameTotal = new TableCell();
            cellNameTotal.CssClass = "table-cell-footer";
            TableCell cellPaymentTotal = new TableCell();
            cellPaymentTotal.CssClass = "table-cell-footer-value";
            cellNameTotal.Text = Resources.ConferenceFront.Registration_Total;
            cellPaymentTotal.Text = total + Resources.ConferenceFront.Registration_Currency;
            rowTotal.Cells.Add(cellNameTotal);
            rowTotal.Cells.Add(cellPaymentTotal);
            table.Rows.Add(rowTotal);
            PreviewRegistration.Controls.Add(table);
            #endregion

        }
        private void LoadData(BusinessLogicLayer.Entities.Conference.ConferenceRegisterations registeration)
        {
            BusinessLogicLayer.Entities.Persons.Person person = SecurityManager.getUser(this.Page);
            BusinessLogicLayer.Entities.Conference.Conferences conference = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this);
            if (person != null && conference != null)
            {
                RegistrationHospitalName.Text = registeration.HospitalInstituteName;
                RegistrationHospitalDepartment.Text = registeration.HospitalInstituteDepartment;
                RegistrationHospitalAddress.Text = registeration.HospitalInstituteAddress;
                
                BusinessLogicLayer.Entities.Conference.ConferenceRegisterations registration = BusinessLogicLayer.Common.ConferenceRegisterationsLogic.GetByID(conference.ConferenceId, person.BusinessEntityId);
                if (registration != null)
                {
                    List<BusinessLogicLayer.Entities.Conference.ConferenceRegistrationItems> items = new BusinessLogicLayer.Components.Conference.ConferenceRegistrationItemsLogic().GetAllByConferenceRegistererId(registeration.ConferenceRegistererId);
                    SocioBuilderSite.Code.RbmCommon.RegistrationInterfaceHelper.LoadControlValues(ResultsAreas, items);
                }
                
            }
        }
        private bool SetData(BusinessLogicLayer.Entities.Conference.ConferenceRegisterations registeration)
        {
            bool result = false;
            BusinessLogicLayer.Entities.Persons.Person person = SecurityManager.getUser(this.Page);
            if (person == null)
            {
                person = ProfileInformation1.CurrentPerson;
                string message = "";
                result = ProfileInformation1.CurrentContactInfo.SaveData(out message);
                if (!result)
                    return result;
            }
            BusinessLogicLayer.Entities.Conference.Conferences conference = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this);
            if (person != null && conference != null)
            {
                registeration.IsSelfSponsor = true;
                registeration.Address = person.MainPersonAddress.AddressLine1;
                
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
                
                registeration.ZipCode = person.MainPersonAddress.ZipCode;
                registeration.IsActive = false;
                registeration.HospitalInstituteAddress = RegistrationHospitalAddress.Text;
                registeration.HospitalInstituteDepartment = RegistrationHospitalDepartment.Text;
                registeration.HospitalInstituteName = RegistrationHospitalName.Text;
                result = true;
                
                
            }
            return result;
        }
        protected void btnFinish_Click(object sender, EventArgs e)
        {
            bool isValid = DevExpress.Web.ASPxEditors.ASPxEdit.ValidateEditorsInContainer(this.pc);
            if (isValid)
            {
                #region Registration
                BusinessLogicLayer.Entities.Persons.Person person = SecurityManager.getUser(this.Page);
                if (person == null)
                    person = ProfileInformation1.CurrentPerson;
                BusinessLogicLayer.Entities.Conference.Conferences conference = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this);
                BusinessLogicLayer.Entities.Conference.ConferenceRegisterations registration = BusinessLogicLayer.Common.ConferenceRegisterationsLogic.GetByID(conference.ConferenceId, person.BusinessEntityId);
                if (registration == null)
                {

                    registration = new BusinessLogicLayer.Entities.Conference.ConferenceRegisterations();
                    bool result = SetData(registration);
                    if (!result)
                        return;
                    BusinessLogicLayer.Common.ConferenceRegisterationsLogic.Insert(registration);
                    Session["RegistrationPayment"] = registration.CurrentConferenceRegistrationType.Fee;
                    Session["RegistrationCurrent"] = registration;
                }
                else
                {
                    bool result = SetData(registration);
                    if (!result)
                        return;
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
                SelectedInvoice.InvoiceItems.Clear();
                //SelectedInvoice.ContactAddress1 = person.MainPersonAddress.AddressLine1;
                //SelectedInvoice.ContactAddress2 = person.MainPersonAddress.AddressLine2;
                //SelectedInvoice.ContactCity = person.MainPersonAddress.City;
                //SelectedInvoice.ContactCountry = person.MainPersonAddress.CountryName;
                //SelectedInvoice.ContactEmail = person.EmailAddressPrimaryObject.Email;
                //SelectedInvoice.ContactName = person.FullName;
                //SelectedInvoice.ContactPhone = person.PersonHomePhoneMain;
                //SelectedInvoice.ContactZip = person.MainPersonAddress.ZipCode;
                SelectedInvoice.Currency = Resources.ConferenceFront.PaymentCurrency;
                //SelectedInvoice.ShipToAddress1 = person.MainPersonAddress.AddressLine1;
                //SelectedInvoice.ShipToAddress2 = person.MainPersonAddress.AddressLine2;
                //SelectedInvoice.ShipToCity = person.MainPersonAddress.City;
                //SelectedInvoice.ShipToCountry = person.MainPersonAddress.CountryName;
                //SelectedInvoice.ShipToName = person.FullName;
                //SelectedInvoice.ShipToZip = person.MainPersonAddress.ZipCode;
                #region Get Submitted Generated Data
                decimal total = 0;
                foreach (BusinessLogicLayer.Entities.Conference.ConferenceRegistrationItems item in surveyAnswers)
                {

                    var itemType = (from x in ConferenceRegistrationTypeList where x.ConferenceRegistrationTypeId == item.ConferenceRegistrationTypeID select x).FirstOrDefault();
                    if (itemType != null)
                    {
                        Product product = new Product();
                        product.Name = itemType.NameLanguage;
                        product.ProductId = itemType.ConferenceRegistrationTypeId;
                        product.Shipping = 0;
                        product.Taxable = false;
                        if (DateTime.Today > itemType.EarlyRegistrationEndDate)
                        {
                            product.Price = itemType.LateFee;
                        }
                        else
                        {
                            product.Price = itemType.Fee;
                        }
                        SelectedInvoice.AddToInvoice(product, 1);
                    }
                }
                #endregion

                #endregion
                Response.Redirect("~/Conference/FinishRegistration.aspx");
                #endregion
            }
            else
            {
                pc.ActiveTabIndex = pc.TabPages.Count - 1;
            }
        }

        protected void RegistrationMedicalDoctorsCheck_Validation(object sender, DevExpress.Web.ASPxEditors.ValidationEventArgs e)
        {
            if (e.Value == null) e.IsValid = false;
            e.IsValid = Convert.ToBoolean(e.Value);
        }
        
    }
}