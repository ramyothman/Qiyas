using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocioBuilderSite.Code.Payments;

namespace SocioBuilderSite.Conference
{
    public partial class FinishRegistration : Code.RbmCommon.ConferenceBasePage
    {
        private Invoice _selectedInvoice = new Invoice();
        public Invoice SelectedInvoice
        {
            get
            {
                if (Session["CurrentInvoice"] == null)
                    return new Invoice();

                _selectedInvoice = Session["CurrentInvoice"] as Invoice;   
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
        protected void Page_Load(object sender, EventArgs e)
        {
            LiteralPrice.Text = SelectedInvoice.Total.ToString();
            BusinessLogicLayer.Entities.Conference.Conferences conference = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this);
            BusinessLogicLayer.Entities.Conference.ConferenceRegistrationSettingLanguages settingsLang = conference.CurrentConferenceRegistrationSettings.GetSettingLanguageByLanguageID(Code.RbmCommon.ConferenceBasePage.GetCurrentPageLanguageId(this));
            FinishText.Text = settingsLang.PostRegistrationInstructions;
            
        }
    }
}