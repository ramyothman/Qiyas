using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace SocioBuilderSite.Administrator.Conference.Abstracts.Controls
{
    public partial class AbstractControl : System.Web.UI.UserControl
    {
        public BusinessLogicLayer.Entities.Conference.Abstracts CurrentAbstract
        {
            get
            {
                string key = "CurrentAbstract" + Request["abstract"];
                int id = 0;
                Int32.TryParse(Request["abstract"],out id);
                if(Session[key] == null)
                    Session[key] = BusinessLogicLayer.Common.AbstractsLogic.GetByID(id);
                if (Session[key] == null)
                    Session[key] = new BusinessLogicLayer.Entities.Conference.Abstracts();
                return Session[key] as BusinessLogicLayer.Entities.Conference.Abstracts;
            }
            set
            {
                string key = "CurrentAbstract" + Request["abstract"];
                Session[key] = null;
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadMainData();
                LoadReviewers();
            }
        }

        private void LoadMainData()
        {
            MainCategoryCombo.DataBind();
            MainBackgroundMemo.Text = CurrentAbstract.Background;
            MainBackgroundHtml.Html = CurrentAbstract.Background;
            if (MainCategoryCombo.Items.FindByValue(CurrentAbstract.ConferenceCategoryId) != null)
                MainCategoryCombo.SelectedIndex = MainCategoryCombo.Items.FindByValue(CurrentAbstract.ConferenceCategoryId).Index;
            MainConclusionMemo.Text = CurrentAbstract.Conclusions;
            MainConclusionHtml.Html = CurrentAbstract.Conclusions;
            MainKeyWordsText.Text = CurrentAbstract.AbstractKeywords;
            MainMethodsMemo.Text = CurrentAbstract.Methods;
            MainMethodsHtml.Html = CurrentAbstract.Methods;
            MainResultsMemo.Text = CurrentAbstract.Results;
            MainResultsHtml.Html = CurrentAbstract.Results;
            MainTitleMemo.Text = CurrentAbstract.AbstractTitle;
            MainTitleHtml.Html = CurrentAbstract.AbstractTitle;
            MainAbstractCode.InnerText = "Abstract Detail: " + CurrentAbstract.ABCode;
        }

        private void LoadReviewers()
        {
            foreach (BusinessLogicLayer.Entities.Conference.AbstractReviewerAssignment reviewer in CurrentAbstract.CurrentAbstractReviewers)
            {
                gridReviewers.Selection.SelectRowByKey(reviewer.AbstractReviewerAssignmentId);
            }
        }
        DevExpress.XtraReports.UI.XtraReport CreateReport(int id)
        {

            SocioBuilderSite.Conferences.Reports.AbstractSubmissionReport tableReport = new SocioBuilderSite.Conferences.Reports.AbstractSubmissionReport();
            BusinessLogicLayer.Entities.Conference.Abstracts CurrentAbstract = BusinessLogicLayer.Common.AbstractsLogic.GetByID(id);
            tableReport.LoadData(CurrentAbstract);
            return tableReport;
        }

        protected void AbstractPDFView_Click(object sender, EventArgs e)
        {
            //LinkButton s = sender as LinkButton;
            
        }
        protected void btnAbstractCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageAbstracts.aspx?code=" + Request["code"]);
        }

        protected void btnAbstractSave_Click(object sender, EventArgs e)
        {
            
            //MainBackgroundMemo.Text = CurrentAbstract.Background;
            CurrentAbstract.Background = MainBackgroundHtml.Html;
            CurrentAbstract.ConferenceCategoryId = Convert.ToInt32(MainCategoryCombo.SelectedItem.Value);

            //MainConclusionMemo.Text = CurrentAbstract.Conclusions;
            CurrentAbstract.Conclusions = MainConclusionHtml.Html;
            CurrentAbstract.AbstractKeywords = MainKeyWordsText.Text  ;
            //MainMethodsMemo.Text = CurrentAbstract.Methods;
            CurrentAbstract.Methods = MainMethodsHtml.Html;
            //MainResultsMemo.Text = CurrentAbstract.Results;
            CurrentAbstract.Results = MainResultsHtml.Html;
            //MainTitleMemo.Text = CurrentAbstract.AbstractTitle;
            CurrentAbstract.AbstractTitle = MainTitleHtml.Html;
            BusinessLogicLayer.Common.AbstractsLogic.Update(CurrentAbstract, CurrentAbstract.AbstractId);
            Response.Redirect("ManageAbstracts.aspx?code=" + Request["code"]);
        }

        protected void btnAbstractPDF_Click(object sender, EventArgs e)
        {
            DevExpress.XtraReports.UI.XtraReport pdf = CreateReport(CurrentAbstract.AbstractId);
            MemoryStream stream = new MemoryStream();

            pdf.ExportToRtf(stream);
            Response.ContentType = "application/rtf";
            Response.AddHeader("Content-Disposition", String.Format("attachment; filename=\"{0}-AbstractSubmission.rtf\"", CurrentAbstract.ABCode));
            Response.BinaryWrite(stream.GetBuffer());
        }

        protected void btnAbstractAttachmentPDF_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(CurrentAbstract.DocumentPath1))
                Response.Redirect("~/ContentData/Sites/Conferences/" + CurrentAbstract.DocumentPath1);
            
                
        }

        protected void btnSaveFeedback_Click(object sender, EventArgs e)
        {
            //BusinessLogicLayer.Entities.Conference.Abstracts abstracts = BusinessLogicLayer.Common.AbstractsLogic.GetByID(Convert.ToInt32(e.NewValues["AbstractId"]));
            if (cmbStatus.Text == "Cancelled" && CurrentAbstract.CurrentStatus.Name != "Cancelled")
            {
                EmailManager.SendCancelAbstractEmail(this.Page, CurrentAbstract);
            }
            else if (cmbStatus.Text == "Oral" && CurrentAbstract.CurrentStatus.Name != "Oral")
            {
                EmailManager.SendOralAcceptedAbstractEmail(this.Page, CurrentAbstract);
            }
            else if (cmbStatus.Text == "Poster" && CurrentAbstract.CurrentStatus.Name != "Poster")
            {
                EmailManager.SendPosterAcceptedAbstractEmail(this.Page, CurrentAbstract);
            }
            else if (cmbStatus.Text == "Not Accepted" && CurrentAbstract.CurrentStatus.Name != "Not Accepted")
            {

                EmailManager.SendNotAcceptedAbstractEmail(this.Page, CurrentAbstract);
            }
            CurrentAbstract.AbstractStatusId = (int)(cmbStatus.SelectedItem.Value);
            BusinessLogicLayer.Common.AbstractsLogic.Update(CurrentAbstract, CurrentAbstract.AbstractId);
        }
    }
}