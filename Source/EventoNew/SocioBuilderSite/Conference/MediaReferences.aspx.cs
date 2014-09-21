using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Conference
{
    public partial class MediaReferences : Code.RbmCommon.ConferenceBasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["ConferenceId"] = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this).ConferenceId;
                Session["LanguageId"] = Code.RbmCommon.ConferenceBasePage.GetCurrentPageLanguageId(this);
                MediaReferenceGrid.DataBind();
            }
        }
    }
}