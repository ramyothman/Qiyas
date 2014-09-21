using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.MasterPages
{
    public partial class ConferenceMaster : System.Web.UI.MasterPage
    {
        public BusinessLogicLayer.Entities.Conference.Conferences CurrentConference
        {
            get
            {
                
                if (Application["CurrentApplicationConference"] == null)
                {
                    //TODO: Load Conference Dynamically
                    int id = 1;
                    Int32.TryParse(Request["SiteId"], out id);
                    if (id == 0)
                        id = 1;
                    Application["CurrentApplicationConference"] = BusinessLogicLayer.Common.ConferencesLogic.GetByID(id);
                    if (Application["CurrentApplicationConference"] != null)
                        Application["CurrentApplicationConferenceId"] = ((BusinessLogicLayer.Entities.Conference.Conferences)Application["CurrentApplicationConference"]).ConferenceId;
                }
                if (!IsPostBack)
                {
                    Session["CurrentApplicationConferenceId"] = Application["CurrentApplicationConferenceId"].ToString();
                }
                return Application["CurrentApplicationConference"] as BusinessLogicLayer.Entities.Conference.Conferences;
            }
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConferenceDateLabel.InnerText = String.Format("{0}-{1} {2:MMMM} {3}", CurrentConference.StartDate.Day, CurrentConference.EndDate.Day, CurrentConference.EndDate,CurrentConference.EndDate.Year);
                if (!string.IsNullOrEmpty(CurrentConference.ConferenceLogo))
                {
                    ConferenceMainLogoImage.Src = BusinessLogicLayer.Common.ConferenceContentPath + CurrentConference.ConferenceLogo;
                }
                else
                {
                    ConferenceMainLogoImage.Visible = false;
                }
            }
        }
    }
}