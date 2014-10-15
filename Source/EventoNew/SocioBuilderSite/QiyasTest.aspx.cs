using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite
{
    public partial class QiyasTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                BusinessLogicLayer.Entities.Conference.ConferencesLanguage confLanguage = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this.Page).GetConferenceByLanguageId(Code.RbmCommon.ConferenceBasePage.GetCurrentPageLanguageId(this.Page));
                if (confLanguage != null)
                {
                    HeadPageTitle.Text = confLanguage.ConferenceName;
                    CustomContent.Content = confLanguage.ConferenceName;
                }
                else
                {
                    HeadPageTitle.Text = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this.Page).ConferenceName;
                    CustomContent.Content = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this.Page).ConferenceName;
                }
                int conferenceId = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this.Page).ConferenceId;
                int languageId = Code.RbmCommon.ConferenceBasePage.GetCurrentPageLanguageId(this.Page);
                MainConferenceLogo.Src = "~/ContentData/Sites/Conferences/" + Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this.Page).ConferenceLogo;
                mainBannerRepeater.DataSource = new BusinessLogicLayer.Components.Conference.ConferenceMainImagesLogic().GetAllByConferenceIdandLanguageId(conferenceId, languageId);
                mainBannerRepeater.DataBind();
            }
        }
    }
}