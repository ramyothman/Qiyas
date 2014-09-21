using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Conferences
{
    public partial class Verification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request["Code"]))
                {
                    BusinessLogicLayer.Entities.Persons.Person person = BusinessLogicLayer.Common.PersonLogic.GetByActivationCode(Request["Code"]);
                    if (person == null)
                    {
                        NotificationMessageSuccess.Visible = false;
                        NotificationMessageError.Visible = true;
                    }
                    else
                    {
                        person.Credentials.IsActivated = true;
                        BusinessLogicLayer.Common.CredentialLogic.Update(person.Credentials, person.BusinessEntityId);
                        NotificationMessageError.Visible = false;
                        NotificationMessageSuccess.Visible = true;
                    }
                }
                else
                {
                    NotificationMessageSuccess.Visible = false;
                    NotificationMessageError.Visible = true;
                }
            }
        }
    }
}