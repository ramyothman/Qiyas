using QualityManagementSite.Code;
using SocioBuilderSite.Code.RbmSecurity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Conference
{
    public partial class SiteForm : SocioBuilderSite.Code.RbmCommon.ConferenceBasePage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request["Code"]))
                {
                    int formDocumentId = 0;
                    Int32.TryParse(Request["Code"], out formDocumentId);
                    BusinessLogicLayer.Entities.FormBuilder.FormDocument document = BusinessLogicLayer.Common.FormDocumentLogic.GetByID(formDocumentId);
                    if (document != null)
                    {
                        FormTitle.Text = document.Title;
                        InterfaceHelper.AddTextToDiv(HeaderArea, String.Format("<span style='font-size:14px;font-weight:bold'>{0}</span><br/><br/>", document.Description));
                        PopulateQuestions(document);
                    }
                    else
                    {
                        Response.Redirect("~/Default.aspx");
                    }

                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void PopulateQuestions(BusinessLogicLayer.Entities.FormBuilder.FormDocument form)
        {



            foreach (BusinessLogicLayer.Entities.FormBuilder.FormField q in form.FormFields)
            {

                Panel p = new Panel();
                p.Attributes["class"] = "QuestionPanel";
                p.ID = "Panel" + q.FormFieldId.ToString();
                InterfaceHelper.AddQuestionAdvanced(q, p);
                ResultsAreas.Controls.Add(p);


            }
        }



        protected void btnSubmitForm_Click(object sender, EventArgs e)
        {
            List<BusinessLogicLayer.Entities.FormBuilder.FormSubmissionAnswer> surveyAnswers = InterfaceHelper.RetrieveUserAnswers(ResultsAreas);
            if (!string.IsNullOrEmpty(Request["Code"]))
            {
                int surveyId = 0;
                Int32.TryParse(Request["Code"], out surveyId);
                int userId = 0;
                if (SecurityManager.isLogged(this))
                    userId = SecurityManager.getUser(this).BusinessEntityId;
                InterfaceHelper.CollectSurveyUserAnswers(surveyAnswers, surveyId, userId);
                ResultsAreasSuccess.Visible = true;
                ResultsAreasSuccess.InnerText = BusinessLogicLayer.Common.FormDocumentLogic.GetByID(surveyId).ConfirmationText;
                ResultsAreas.Visible = false;
                btnSubmitForm.Visible = false;
            }
        }

        protected void SavingCallbackPanel_Callback(object sender, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {


        }
    }
}