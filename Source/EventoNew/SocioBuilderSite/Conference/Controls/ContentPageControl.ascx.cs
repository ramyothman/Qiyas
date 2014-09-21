using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Conference.Controls
{
    public partial class ContentPageControl : System.Web.UI.UserControl
    {
        public BusinessLogicLayer.Entities.Conference.Conferences CurrentConference
        {
            get
            {
                return Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this.Page);
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
                    Int32.TryParse(Request["page"], out id);
                    if (id != 0)
                        _CurrentSitePage = BusinessLogicLayer.Common.SitePageLogic.GetByID(id);
                    else
                        _CurrentSitePage = BusinessLogicLayer.Common.SitePageLogic.GetDefaultPage(CurrentConference.SiteId);
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
                if (pageLang != null && !pageLang.NewRecord)
                {
                    ContentDiv.InnerHtml = pageLang.PageContent;
                    TitleLiteral.Text = pageLang.PageName;
                }
                else
                {
                    ContentDiv.InnerHtml = CurrentSitePage.PageContent;
                    TitleLiteral.Text = CurrentSitePage.PageName;
                }
            }
        }
    }
}