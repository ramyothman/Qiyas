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
    public partial class MakePayment : System.Web.UI.Page
    {
        private Invoice _selectedInvoice = new Invoice();
        public Invoice SelectedInvoice
        {
            get
            {
                if (_selectedInvoice.InvoiceId == "")
                {
                    try
                    {
                        _selectedInvoice = (Invoice)Session["CurrentInvoice"];
                        
                    }
                    catch { }
                }
                return _selectedInvoice;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (SecurityManager.isLogged(this.Page))
                {

                    BusinessLogicLayer.Entities.Persons.Person person = SecurityManager.getUser(this.Page);
                    BusinessLogicLayer.Entities.Conference.Conferences conference = Application["CurrentApplicationConference"] as BusinessLogicLayer.Entities.Conference.Conferences;
                    BusinessLogicLayer.Entities.Conference.ConferenceRegisterations registration = BusinessLogicLayer.Common.ConferenceRegisterationsLogic.GetByID(conference.ConferenceId, person.BusinessEntityId);
                    
                    ReferenceCode.InnerText = SelectedInvoice.InvoiceId;
                    if (registration == null)
                    {
                        Response.Redirect("~/Conferences/Registration.aspx");
                    }
                }
                else
                {
                    Response.Redirect("~/Conferences/RequestLogin.aspx");
                }
                AmountPayment.InnerText = Session["RegistrationPayment"].ToString() + "SR";
            }
        }
    }
}