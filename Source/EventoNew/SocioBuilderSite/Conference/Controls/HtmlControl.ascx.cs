using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Conference.Controls
{
    public partial class HtmlControl : System.Web.UI.UserControl
    {
        public BusinessLogicLayer.Entities.Conference.Conferences CurrentConference
        {
            get
            {
                return Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this.Page);
            }
        }
        private string _CurrentSitePageId;
        public string CurrentSitePageId
        {
            get 
            {
                if (ViewState["CurrentSitePageId"] == null)
                    ViewState["CurrentSitePageId"] = "0";
                return ViewState["CurrentSitePageId"].ToString(); 
            }
            set
            {
                ViewState["CurrentSitePageId"] = value;
            }
        }
        
        BusinessLogicLayer.Entities.ContentManagement.SitePage _CurrentSitePage;
        BusinessLogicLayer.Entities.ContentManagement.SitePage CurrentSitePage
        {
            get
            {
                if (_CurrentSitePage == null)
                {
                    int id = 0;
                    Int32.TryParse(CurrentSitePageId, out id);
                    if (id != 0)
                        _CurrentSitePage = BusinessLogicLayer.Common.SitePageLogic.GetByID(id);
                    if (_CurrentSitePage == null)
                        _CurrentSitePage = new BusinessLogicLayer.Entities.ContentManagement.SitePage();
                }
                return _CurrentSitePage;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                int langId = Code.RbmCommon.ConferenceBasePage.GetCurrentPageLanguageId(this.Page);
                BusinessLogicLayer.Entities.ContentManagement.SitePageLanguage pageLang = CurrentSitePage.GetSitePageLanguageByLanguageId(langId);
                if (CurrentSitePage.NewRecord)
                    MainContent.Visible = false;
                if (pageLang != null && !pageLang.NewRecord)
                {
                    if (pageLang.PageContent == "")
                        MainContent.Visible = false;
                    ContentDiv.InnerHtml = pageLang.PageContent;
                }
                else
                {
                    if (CurrentSitePage.PageContent == "")
                        MainContent.Visible = false;
                    ContentDiv.InnerHtml = CurrentSitePage.PageContent;
                    
                }
            }
        }

    }
}