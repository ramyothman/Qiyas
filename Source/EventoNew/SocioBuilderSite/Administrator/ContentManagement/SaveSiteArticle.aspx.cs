using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocioBuilderSite.Code.RbmSecurity;
using SocioBuilderSite.Code.RbmCommon;
using DevExpress.Web.ASPxUploadControl;
using System.IO;

namespace SocioBuilderSite.Administrator.ContentManagement
{
    public partial class SaveSiteArticle : System.Web.UI.Page
    {
        public string SiteLink
        {
            set
            {

            }
        }
        public BusinessLogicLayer.Entities.ContentManagement.Article SitePage
        {
            get
            {
                if (Session["AMCurrentSiteArticle"] == null)
                {
                    Session["AMCurrentSiteArticle"] = new BusinessLogicLayer.Entities.ContentManagement.Article();
                }
                return Session["AMCurrentSiteArticle"] as BusinessLogicLayer.Entities.ContentManagement.Article;
            }
            set
            {
                Session["AMCurrentSiteArticle"] = value;
            }
        }

        public int OldLanguageId
        {
            get
            {
                if (Session["AMSiteArticleOldLanguageId"] == null)
                    return 0;
                else
                    return Convert.ToInt32(Session["AMSiteArticleOldLanguageId"]);
            }

            set { Session["AMSiteArticleOldLanguageId"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SitePage = null;
                DevExpress.Web.ASPxEditors.ASPxListBox checkbox = categoriesDropDownEdit.FindControl("listBox") as DevExpress.Web.ASPxEditors.ASPxListBox;
                if (checkbox != null)
                {
                    checkbox.DataBind();
                    checkbox.Items.Insert(0, new DevExpress.Web.ASPxEditors.ListEditItem("(Select All)", "0"));
                }
                pageSite.DataBind();
                pageState.DataBind();
                //pageSecurityAccess.DataBind();
                pageLanguages.DataBind();
                pageLanguages.SelectedIndex = pageLanguages.Items.IndexOfValue(BusinessLogicLayer.Common.DefaultLanguage.LanguageId);
                if (!string.IsNullOrEmpty(Request["ArticleCode"]))
                {
                    int pageId = 0;
                    Int32.TryParse(Request["ArticleCode"], out pageId);
                    SitePage = BusinessLogicLayer.Common.ArticleLogic.GetByID(pageId);

                    if (!SitePage.NewRecord)
                    {
                        SiteLink = pageId.ToString();
                        pageSite.SelectedIndex = pageSite.Items.IndexOfValue(SitePage.SiteId);
                        pageState.SelectedIndex = pageState.Items.IndexOfValue(SitePage.ArticleStatusId);
                        //pageSecurityAccess.SelectedIndex = pageSecurityAccess.Items.IndexOfValue(SitePage.SecurityAccessTypeId);
                        
                        //pageAlias.Text = SitePage.UniquePageName;
                        //chkIsMainPage.Checked = SitePage.IsMainPage;
                        pageSection.DataBind();
                        pageSection.SelectedIndex = pageSection.Items.IndexOfValue(SitePage.SiteSectionId);
                        List<BusinessLogicLayer.Entities.ContentManagement.ArticleCategory> cats = BusinessLogicLayer.Common.ArticleCategoryLogic.GetAllByArticleId(SitePage.ArticleId);
                        foreach (BusinessLogicLayer.Entities.ContentManagement.ArticleCategory cat in cats)
                        {

                            foreach (DevExpress.Web.ASPxEditors.ListEditItem item in checkbox.Items)
                            {
                                if (item.Value.ToString() == cat.SiteCategoryId.ToString())
                                {
                                    categoriesDropDownEdit.Text += item.Text + ";";
                                    item.Selected = true;
                                }
                            }
                        }
                        if (categoriesDropDownEdit.Text.Length > 0)
                            categoriesDropDownEdit.Text = categoriesDropDownEdit.Text.Remove(categoriesDropDownEdit.Text.Length - 1, 1);
                        if (checkbox != null)
                        {

                            foreach (DevExpress.Web.ASPxEditors.ListEditItem item in checkbox.Items)
                            {
                                if (item.Value.ToString() != "0")
                                {
                                    BusinessLogicLayer.Common.ArticleCategoryLogic.Insert(Convert.ToInt32(item.Value), SitePage.ArticleId, DateTime.Now);
                                }
                            }
                        }
                        cmbCommentType.DataBind();
                        cmbCommentType.SelectedIndex = cmbCommentType.Items.IndexOfValue(SitePage.CommentsTypeId);
                        pageLanguages.SelectedIndex = pageLanguages.Items.IndexOfValue(BusinessLogicLayer.Common.DefaultLanguage.LanguageId);
                        BusinessLogicLayer.Entities.ContentManagement.ArticleLanguage splang = SitePage.GetArticlePageLanguageByLanguageId(Convert.ToInt32(pageLanguages.SelectedItem.Value));
                        pageTitle.Text = splang.ArticleName;
                        pageContent.Html = splang.ArticleContent;
                        txtAlias.Text = splang.ArticleAlias;
                        txtAuthor.Text = splang.AuthorAlias;
                        txtSummaryText.Text = splang.ArticleSummary;
                        //pageAlias.Text = splang.ArticleAlias;
                    }
                }
                OldLanguageId = (int)pageLanguages.SelectedItem.Value;
            }
        }

        private void Save()
        {
            #region Getting Language Last Updates
            BusinessLogicLayer.Entities.ContentManagement.ArticleLanguage oldLanguage = SitePage.GetArticlePageLanguageByLanguageId(OldLanguageId);
            oldLanguage.ArticleName = pageTitle.Text;
            oldLanguage.ArticleContent = pageContent.Html;
            oldLanguage.ModifiedDate = DateTime.Now;
            oldLanguage.ArticleSummary = txtSummaryText.Text;
            oldLanguage.AuthorAlias = txtAuthor.Text;
            oldLanguage.ArticleAlias = txtAlias.Text;
            oldLanguage.LanguageId = OldLanguageId;
            
            //oldLanguage.ArticleAlias = pageAlias.Text;
            if (oldLanguage.NewRecord)
            {
                oldLanguage.NewRecord = false;
                SitePage.CurrentArticleLanguage.Add(oldLanguage);
            }
            #endregion

            if (SitePage.NewRecord)
            {
                #region Insert
                SitePage.CreatorId = SecurityManager.getUser(this).BusinessEntityId;
                SitePage.AuthorId = SecurityManager.getUser(this).BusinessEntityId;
                //SitePage.IsMainPage = false;
                SitePage.ModifiedDate = DateTime.Now;
                SitePage.ArticleStatusId = Convert.ToInt32(pageState.Value);
                SitePage.PostDate = DateTime.Now;
                //SitePage.SecurityAccessTypeId = Convert.ToInt32(pageSecurityAccess.Value);
                //SitePage.UniquePageName = pageAlias.Text;
                if (cmbCommentType.Value != null)
                    SitePage.CommentsTypeId = Convert.ToInt32(cmbCommentType.Value);
                else
                    SitePage.CommentsTypeId = 1;
                SitePage.SiteSectionId = Convert.ToInt32(pageSection.Value);
                //SitePage.is = chkIsMainPage.Checked;
                
                BusinessLogicLayer.Common.ArticleLogic.Insert(SitePage);
                SitePage.NewRecord = false;
                List<BusinessLogicLayer.Entities.ContentManagement.ArticleCategory> cats = new List<BusinessLogicLayer.Entities.ContentManagement.ArticleCategory>();
                DevExpress.Web.ASPxEditors.ASPxListBox checkbox = categoriesDropDownEdit.FindControl("listBox") as DevExpress.Web.ASPxEditors.ASPxListBox;
                if (checkbox != null)
                {

                    foreach (DevExpress.Web.ASPxEditors.ListEditItem item in checkbox.Items)
                    {
                        if (item.Value.ToString() != "0" && item.Selected)
                        {
                            BusinessLogicLayer.Common.ArticleCategoryLogic.Insert(Convert.ToInt32(item.Value), SitePage.ArticleId, DateTime.Now);
                        }
                    }
                }
                foreach (BusinessLogicLayer.Entities.ContentManagement.ArticleLanguage lang in SitePage.CurrentArticleLanguage)
                {
                    lang.ArticleId = SitePage.ArticleId;
                    BusinessLogicLayer.Common.ArticleLanguageLogic.Insert(lang);
                }
                #endregion
            }
            else
            {
                #region Update
                SitePage.CreatorId = SecurityManager.getUser(this).BusinessEntityId;
                SitePage.AuthorId = SecurityManager.getUser(this).BusinessEntityId;
                //SitePage.IsMainPage = false;
                SitePage.ModifiedDate = DateTime.Now;
                SitePage.ArticleStatusId = Convert.ToInt32(pageState.Value);
                SitePage.PostDate = DateTime.Now;
                //SitePage.SecurityAccessTypeId = Convert.ToInt32(pageSecurityAccess.Value);
                //SitePage. = pageAlias.Text;
                SitePage.SiteSectionId = Convert.ToInt32(pageSection.Value);
                //SitePage.IsMainPage = chkIsMainPage.Checked;
                if (cmbCommentType.Value != null)
                    SitePage.CommentsTypeId = Convert.ToInt32(cmbCommentType.Value);
                else
                    SitePage.CommentsTypeId = 1;
                BusinessLogicLayer.Common.ArticleLogic.Update(SitePage, SitePage.ArticleId);
                DevExpress.Web.ASPxEditors.ASPxListBox checkbox = categoriesDropDownEdit.FindControl("listBox") as DevExpress.Web.ASPxEditors.ASPxListBox;
                BusinessLogicLayer.Common.ArticleCategoryLogic.DeleteByArticleId(SitePage.ArticleId);
                if (checkbox != null)
                {
                    foreach (DevExpress.Web.ASPxEditors.ListEditItem item in checkbox.Items)
                    {
                        if (item.Value.ToString() != "0" && item.Selected)
                        {
                            BusinessLogicLayer.Common.ArticleCategoryLogic.Insert(Convert.ToInt32(item.Value), SitePage.ArticleId, DateTime.Now);
                        }
                    }
                }
                BusinessLogicLayer.Common.ArticleLanguageLogic.DeleteByArticleId(SitePage.ArticleId);
                foreach (BusinessLogicLayer.Entities.ContentManagement.ArticleLanguage lang in SitePage.CurrentArticleLanguage)
                {
                    lang.ArticleId = SitePage.ArticleId;
                    BusinessLogicLayer.Common.ArticleLanguageLogic.Insert(lang);
                }


                #endregion
            }
        }
        private string GetErrorMessageClasses()
        {
            return "message error no-margin";
        }
        private string GetSuccessMessageClasses()
        {
            return "message success no-margin";
        }
        protected void ApplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
                NoticeMessageDiv.Visible = true;
                NoticeMessageDiv.Attributes.Remove("class");
                NoticeMessageDiv.Attributes.Add("class", GetSuccessMessageClasses());
                NoticeMessage.InnerHtml = "Data Saved Successfully";
            }
            catch (Exception ex)
            {
                NoticeMessageDiv.Visible = true;
                NoticeMessageDiv.Attributes.Remove("class");
                NoticeMessageDiv.Attributes.Add("class", GetErrorMessageClasses());
                NoticeMessage.InnerHtml = "<span>Error Saving: </span>" + ex.Message;
            }
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
                NoticeMessageDiv.Visible = true;
                NoticeMessageDiv.Attributes.Remove("class");
                NoticeMessageDiv.Attributes.Add("class", GetSuccessMessageClasses());
                NoticeMessage.InnerHtml = "Data Saved Successfully";
                SiteLink = SitePage.ArticleId.ToString();
            }
            catch (Exception ex)
            {
                NoticeMessageDiv.Visible = true;
                NoticeMessageDiv.Attributes.Remove("class");
                NoticeMessageDiv.Attributes.Add("class", GetErrorMessageClasses());
                NoticeMessage.InnerHtml = "<span>Error Saving: </span>" + ex.Message;
                return;
            }
            Response.Redirect("ManageSiteArticles.aspx");
        }

        protected void pageSection_Callback(object sender, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            SectionObjectDS.SelectParameters[0].DefaultValue = e.Parameter;
            pageSection.DataBind();
        }

        protected void pageContentLanguageCallbackPanel_Callback(object sender, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            BusinessLogicLayer.Entities.ContentManagement.ArticleLanguage oldLanguage = SitePage.GetArticlePageLanguageByLanguageId(OldLanguageId);
            BusinessLogicLayer.Entities.ContentManagement.ArticleLanguage newlanguage = SitePage.GetArticlePageLanguageByLanguageId(Convert.ToInt32(e.Parameter));

            oldLanguage.ArticleName = pageTitle.Text;
            oldLanguage.ArticleContent = pageContent.Html;
            oldLanguage.ArticleSummary = txtSummaryText.Text;
            oldLanguage.ArticleAlias = txtAlias.Text;
            oldLanguage.AuthorAlias = txtAuthor.Text;
            oldLanguage.ModifiedDate = DateTime.Now;
            if(!string.IsNullOrEmpty(txtPublishStart.Text))
                    oldLanguage.PublishStartDate = txtPublishStart.Date;
            if(!string.IsNullOrEmpty(txtPublishEnd.Text))
                    oldLanguage.PublishEndDate = txtPublishEnd.Date;
            oldLanguage.LanguageId = OldLanguageId;
            //oldLanguage.ArticleAlias = pageAlias.Text;
            if (oldLanguage.NewRecord)
            {
                oldLanguage.NewRecord = false;
                SitePage.CurrentArticleLanguage.Add(oldLanguage);
            }

            //pageAlias.Text = newlanguage.ArticleAlias;
            pageContent.Html = newlanguage.ArticleContent;
            pageTitle.Text = newlanguage.ArticleName;
            txtSummaryText.Text = newlanguage.ArticleSummary;
            txtAlias.Text = newlanguage.ArticleAlias;
            txtAuthor.Text = newlanguage.AuthorAlias;
            if (newlanguage.PublishStartDate == DateTime.MinValue)
                 txtPublishStart.Text = "";
            else
                txtPublishStart.Date = newlanguage.PublishStartDate;
            if (newlanguage.PublishEndDate == DateTime.MinValue)
                txtPublishEnd.Text = "";
            else
                txtPublishEnd.Date = newlanguage.PublishEndDate;
            OldLanguageId = Convert.ToInt32(e.Parameter);

        }

        protected void pageState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string SavePostedFile(UploadedFile uploadedFile)
        {
            BusinessLogicLayer.Entities.ContentManagement.ArticleLanguage oldLanguage = SitePage.GetArticlePageLanguageByLanguageId(OldLanguageId);
            Session["UploadedFile"] = null;
            string fileName = "";
            if (uploadedFile.IsValid)
            {
                Random random = new Random();
                //string _MenuGroupId = Session["MenuGroupId"].ToString();
                string dateString = String.Format("{0}{1}{2}", System.DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
                string timeString = String.Format("{0}{1}{2}", System.DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                fileName = String.Format("{0}-{1}-{2}-{3}", dateString, timeString, random.Next(), uploadedFile.FileName);
                if (Tools.IsImage(uploadedFile.FileBytes))
                {
                    Session["UploadedFile"] = fileName;
                    if (oldLanguage != null)
                    {
                        oldLanguage.ArticleAttachment = fileName;
                    }
                    //uploadedFile.SaveAs(Server.MapPath("~/ContentData/MenuImages/") + fileName, true);
                    //byte[] thumb = Tools.CreateThumb(uploadedFile.FileBytes, 32, true);
                    //MemoryStream stream = new MemoryStream(thumb);
                    FileStream stream = new FileStream(Server.MapPath(BusinessLogicLayer.Common.ConferenceContentPath) + fileName, FileMode.Create);
                    stream.Write(uploadedFile.FileBytes, 0, uploadedFile.FileBytes.Length);
                    stream.Flush();
                    stream.Close();
                }
                else
                {
                    BusinessLogicLayer.Components.UserMonitorLogic monitorLogic = new BusinessLogicLayer.Components.UserMonitorLogic();
                    string ipMain = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                    string IpForwardedFor = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                    string ip = String.Format("{0}-{1}", ipMain, IpForwardedFor);
                    int userid = 0;
                    if (SecurityManager.isLogged(this.Page))
                        userid = SecurityManager.getUser(this.Page).BusinessEntityId;
                    monitorLogic.Insert(userid, false, ip, fileName, DateTime.Now);
                    fileName = "";
                }


            }
            return fileName;
        }
        protected void conferenceLogoUpload_FileUploadComplete(object sender, DevExpress.Web.ASPxUploadControl.FileUploadCompleteEventArgs e)
        {
            e.CallbackData = SavePostedFile(e.UploadedFile);
        }

    }
}