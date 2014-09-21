using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Administrator.Conference.Abstracts
{
    public partial class ManageAbstracts : AdminBasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gridAbstracts_CustomCallback(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewCustomCallbackEventArgs e)
        {
            List<object> abstracts = gridAbstracts.GetSelectedFieldValues( "AbstractId");
            foreach (int id in abstracts)
            {
                try
                {
                    BusinessLogicLayer.Common.AbstractsLogic.Delete(id);
                }
                catch (Exception ex)
                {

                }
            }
            gridAbstracts.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected void btnSubmitExistingReviewers_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.Components.Conference.AbstractReviewerAssignmentLogic logic = new BusinessLogicLayer.Components.Conference.AbstractReviewerAssignmentLogic();
            List<object> abstracts = gridAbstracts.GetSelectedFieldValues("AbstractId");
            List<object> reviewers = gridReviewers.GetSelectedFieldValues("AbstractReviewerId");
            List<object> persons = gridReviewers.GetSelectedFieldValues("PersonId");
            foreach (int abstractId in abstracts)
            {
                for (int i = 0; i< reviewers.Count;i++)
                {
                    logic.Insert((int)reviewers[i], abstractId, false, DateTime.Now, DateTime.MinValue);
                    BusinessLogicLayer.Entities.Persons.Person person = new BusinessLogicLayer.Components.Persons.PersonLogic().GetByID((int)persons[i]);
                    EmailManager.SendReviewerSubmissionEmail(this, BusinessLogicLayer.Common.AbstractsLogic.GetByID(abstractId), person.CompleteName, person.EmailAddressPrimaryObject.Email, null);
                }
            }

            if (!string.IsNullOrEmpty(ExternalReviewerText1.Text.Trim()))
            {

            }

            if (!string.IsNullOrEmpty(ExternalReviewerText2.Text.Trim()))
            {

            }

            if (!string.IsNullOrEmpty(ExternalReviewerText2.Text.Trim()))
            {

            }
        }

        protected void lnkABCode_Click(object sender, EventArgs e)
        {
            LinkButton btn = sender as LinkButton;
            Response.Redirect("Abstract.aspx?code=" + Request["code"] + "&abstract=" + btn.CommandArgument);
        }

        protected void btnDownloadList_Click(object sender, EventArgs e)
        {
            ASPxGridViewExporter1.WriteXlsToResponse();
        }
    }
}