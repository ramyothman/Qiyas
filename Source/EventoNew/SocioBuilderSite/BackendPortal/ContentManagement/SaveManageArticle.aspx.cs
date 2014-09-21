using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.BackendPortal.ContentManagement
{
    public partial class SaveManageArticle : System.Web.UI.Page
    {
        public BusinessLogicLayer.Entities.ContentManagement.Article ArticlePage
        {
            get
            {
                if (Session["CurrentArticle"] == null)
                {
                    Session["CurrentArticle"] = new BusinessLogicLayer.Entities.ContentManagement.Article();
                }
                return Session["CurrentArticle"] as BusinessLogicLayer.Entities.ContentManagement.Article;
            }
            set
            {
                Session["CurrentArticle"] = value;
            }
        }

        public int OldLangID
        {
            get
            {
                if (Session["CurrentArticle"] == null)
                    return 0;
                else
                    return Convert.ToInt32(Session["CurrentArticle"]);

            }
            set
            {
                Session["CurrentArticle"] = value;
            }

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ArticlePage = null;
                DevExpress.Web.ASPxEditors.ASPxListBox CheckList = SiteCategories.FindControl("ListBox") as DevExpress.Web.ASPxEditors.ASPxListBox;
                if (CheckList != null)
                {
                    CheckList.DataBind();
                    CheckList.Items.Insert(0, new DevExpress.Web.ASPxEditors.ListEditItem("(Select All)", "0"));
                }
                   
            
                 ArticleSite.DataBind();
                 ArticleState.DataBind();
                 ArticleLanguages.DataBind();
                 ArticleLanguages.SelectedIndex = ArticleLanguages.Items.IndexOfValue(BusinessLogicLayer.Common.DefaultLanguage.LanguageId);
                 if (!string.IsNullOrEmpty("ArticleCode"))
                  {
                    int ArticleId = 0;
                    Int32.TryParse(Request["ArticleCode"],out ArticleId);
                    ArticlePage = BusinessLogicLayer.Common.ArticleLogic.GetByID(ArticleId);
                    if (!ArticlePage.NewRecord)
                    {
                       ArticleSite.SelectedIndex = ArticleSite.Items.IndexOfValue(ArticlePage.ArticleId);
                       ArticleState.SelectedIndex = ArticleState.Items.IndexOfValue(ArticlePage.ArticleStatusId);
                       List<BusinessLogicLayer.Entities.ContentManagement.ArticleCategory> cats = BusinessLogicLayer.Common.ArticleCategoryLogic.GetAllByArticleId(ArticlePage.ArticleId);
                           foreach (BusinessLogicLayer.Entities.ContentManagement.ArticleCategory cat in cats)
                           {
                               foreach (DevExpress.Web.ASPxEditors.ListEditItem item in CheckList.Items)
                               {
                                   if (item.Value.ToString( ) == cat.ArticleCategoryId.ToString())
                                   {
                                       categoriesDropDown.Text += item.Text + ";";
                                       item.Selected = true;
                                   }
                               }
                           

                           }
                       

                           categoriesDropDown.Text = categoriesDropDown.Text.Remove(categoriesDropDown.Text.Length - 1, 1);
                           if (CheckList != null)
                           {

                               foreach (DevExpress.Web.ASPxEditors.ListEditItem item in CheckList.Items)
                               {
                                   if (item.Value.ToString() != "0")
                                   {
                                       BusinessLogicLayer.Common.ArticleCategoryLogic.Insert(Convert.ToInt32(item.Value), ArticlePage.ArticleId, DateTime.Now);
                                   }
                               }
                           }
                           ArticleLanguages.SelectedIndex = ArticleLanguages.Items.IndexOfValue(BusinessLogicLayer.Common.DefaultLanguage.LanguageId);
                           BusinessLogicLayer.Entities.ContentManagement.ArticleLanguage atlang =ArticlePage.GetArticlePageLanguageByLanguageId(Convert.ToInt32(ArticleLanguages.SelectedItem.Value));
                           ArticleTitle.Text = atlang.ArticleName;
                           ArticleAlies.Text = atlang.AuthorAlias;
                    }
                  }
                 OldLangID = (int)ArticleLanguages.SelectedItem.Value;
            }
        }

        private void Save()
        {
            #region Getting Language Last Updates
            BusinessLogicLayer.Entities.ContentManagement.ArticleLanguage oldLanguge = ArticlePage.GetArticlePageLanguageByLanguageId(OldLangID);
            oldLanguge.ArticleName = ArticleTitle.Text;
            oldLanguge.ArticleContent = ArticleContent.Html;
            oldLanguge.ModifiedDate = DateTime.Now;
            oldLanguge.LanguageId = OldLangID;
            oldLanguge.ArticleAlias = ArticleAlies.Text;
            if(oldLanguge.NewRecord)
            {
                oldLanguge.NewRecord = false;
                ArticlePage.CurrentArticleLanguage.Add(oldLanguge);
            }
         
            #endregion

            if (ArticlePage.NewRecord)
            {
                #region Insert
                ArticlePage.CreatorId = 1;
                ArticlePage.ModifiedDate = DateTime.Now;
                ArticlePage.ArticleStatusId = Convert.ToInt32(ArticleState.Value);
                BusinessLogicLayer.Common.ArticleLogic.Insert(ArticlePage);
                List<BusinessLogicLayer.Entities.ContentManagement.ArticleCategory> cats = new List<BusinessLogicLayer.Entities.ContentManagement.ArticleCategory>();
                DevExpress.Web.ASPxEditors.ASPxListBox checkBox = categoriesDropDown.FindControl("listBox") as DevExpress.Web.ASPxEditors.ASPxListBox;
                if (checkBox != null)
                {
                    foreach (DevExpress.Web.ASPxEditors.ListEditItem item in checkBox.Items)
                    {
                        if (item.Value.ToString() != "0" && item.Selected)
                        {
                            BusinessLogicLayer.Common.ArticleCategoryLogic.Insert(Convert.ToInt32(item.Value), ArticlePage.ArticleId, DateTime.Now);

                        }
                    }
                    
                }
                foreach (BusinessLogicLayer.Entities.ContentManagement.ArticleLanguage lang in ArticlePage.CurrentArticleLanguage)
                {
                    lang.ArticleId = ArticlePage.ArticleId;
                    BusinessLogicLayer.Common.ArticleLanguageLogic.Insert(lang);
                }
                    
                
                #endregion
            }
            else
            {
                #region Update
                ArticlePage.CreatorId = 1;
                ArticlePage.ModifiedDate = DateTime.Now;
                ArticlePage.ArticleStatusId = Convert.ToInt32(ArticleState.Value);
                BusinessLogicLayer.Common.ArticleLogic.Update(ArticlePage, ArticlePage.ArticleId);
                DevExpress.Web.ASPxEditors.ASPxListBox checkbox = categoriesDropDown.FindControl("listBox") as DevExpress.Web.ASPxEditors.ASPxListBox;
                BusinessLogicLayer.Common.ArticleCategoryLogic.DeleteByArticleId(ArticlePage.ArticleId);
                if (checkbox != null)
                {
                    foreach (DevExpress.Web.ASPxEditors.ListEditItem item in checkbox.Items)
                    {
                        if (item.Value.ToString() != "0" && item.Selected)
                        {
                            BusinessLogicLayer.Common.ArticleCategoryLogic.Insert(Convert.ToInt32(item.Value), ArticlePage.ArticleId, DateTime.Now);
                        }
                    }
                }
                BusinessLogicLayer.Common.ArticleLanguageLogic.DeleteByArticleId(ArticlePage.ArticleId);
                foreach (BusinessLogicLayer.Entities.ContentManagement.ArticleLanguage lang in ArticlePage.CurrentArticleLanguage)
                {
                    lang.ArticleId = ArticlePage.ArticleId;
                    BusinessLogicLayer.Common.ArticleLanguageLogic.Insert(lang);
                }
                    
 
                #endregion
            }

            

        }

        private string GetErrorMessageClasses()
        {
            return "response-msg error ui-corner-all";

        }
        private string GetSuccessMessageClasses()
        {
            return "response-msg success ui-corner-all";

       }

        protected void ApplyButton_Click(object sender, EventArgs e)
        {
            try 
            {
                Save();
               
                NoticeMessage.Attributes.Add("class",GetSuccessMessageClasses());
                NoticeMessage.InnerHtml = "<span>Success Saving</span>Data Save Successfully";

            }
            catch(Exception ex)
            {
                NoticeMessage.Attributes.Add("class", GetErrorMessageClasses());
                NoticeMessage.InnerHtml = "<span>Error Saving</span>" + ex.Message;

            }
        }
        

        protected void SaveButton_Click(object sender, EventArgs e)
        {

            try
            {
                NoticeMessage.Attributes.Add("class", GetSuccessMessageClasses());
                NoticeMessage.InnerHtml = "<span>Success Saving</span>Data Saved Successfully";
            }
            catch (Exception ex)
            {
                NoticeMessage.Attributes.Add("class", GetErrorMessageClasses());
                NoticeMessage.InnerHtml = "<span>Error Saving</span>" + ex.Message;
                return;
            }
            Response.Redirect("ManageArticles.aspx");
            
        }
       protected void ArticleContentLanguageCallbackPanel_Callback(object sender, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            BusinessLogicLayer.Entities.ContentManagement.ArticleLanguage oldlanguage = ArticlePage.GetArticlePageLanguageByLanguageId(OldLangID);
            BusinessLogicLayer.Entities.ContentManagement.ArticleLanguage newLanguage = ArticlePage.GetArticlePageLanguageByLanguageId(OldLangID);
            oldlanguage.ArticleName = ArticleTitle.Text;
            oldlanguage.ArticleContent = ArticleContent.Html;
            oldlanguage.ModifiedDate = DateTime.Now;
            oldlanguage.LanguageId = OldLangID;
            oldlanguage.ArticleAlias = ArticleAlies.Text;
            if (oldlanguage.NewRecord)
            {
                oldlanguage.NewRecord = false;
                ArticlePage.CurrentArticleLanguage.Add(oldlanguage);

            }
            ArticleAlies.Text = newLanguage.ArticleAlias;
            ArticleContent.Html = newLanguage.ArticleContent;
            ArticleTitle.Text = newLanguage.ArticleName;


            OldLangID = Convert.ToInt32(e.Parameter);

        


        }


        
    }
}