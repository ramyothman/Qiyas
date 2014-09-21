using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Conference
{
    public partial class ArticleContent : Code.RbmCommon.ConferenceBasePage
    {
        public BusinessLogicLayer.Entities.Conference.Conferences CurrentConference
        {
            get
            {
                return Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this.Page);
            }
        }
        BusinessLogicLayer.Entities.ContentManagement.Article _CurrentArticle;
        BusinessLogicLayer.Entities.ContentManagement.Article CurrentArticle
        {
            get
            {
                if (_CurrentArticle == null)
                {
                    int id = 0;
                    Int32.TryParse(Request["article"], out id);
                    if (id != 0)
                    {
                        _CurrentArticle = BusinessLogicLayer.Common.ArticleLogic.GetByID(id);
                        _CurrentArticle.DefaultLanguage = Code.RbmCommon.ConferenceBasePage.GetCurrentPageLanguageId(this);
                    }
                    else
                        Response.Redirect("ArticlesView.aspx");
                    if (_CurrentArticle == null)
                        Response.Redirect("ArticlesView.aspx");
                }
                return _CurrentArticle;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                int langId = Code.RbmCommon.ConferenceBasePage.GetCurrentPageLanguageId(this.Page);
                BusinessLogicLayer.Entities.ContentManagement.ArticleLanguage pageLang = CurrentArticle.GetArticlePageLanguageByLanguageId(langId);
                if (pageLang != null && !pageLang.NewRecord)
                {
                    ContentDiv.InnerHtml = pageLang.ArticleContent;
                    TitleLiteral.Text = pageLang.ArticleName;
                }
                else
                {
                    ContentDiv.InnerHtml = CurrentArticle.ArticleContent;
                    TitleLiteral.Text = CurrentArticle.ArticleName;
                }
            }
        }
    }
}