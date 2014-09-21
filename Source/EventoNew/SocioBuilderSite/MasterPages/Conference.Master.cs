﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.MasterPages
{
    public partial class Conference : System.Web.UI.MasterPage
    {
        public BusinessLogicLayer.Entities.Conference.Conferences CurrentConference
        {
            get
            {
                if (Application["CurrentApplicationConference"] == null)
                {
                    //TODO: Load Conference Dynamically
                    Application["CurrentApplicationConference"] = BusinessLogicLayer.Common.ConferencesLogic.GetByID(1);
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
                if(CurrentConference.StartDate.Day != CurrentConference.EndDate.Day)
                    ConferenceDateLabel.InnerText = String.Format("{0}-{1} {2:MMMM} {3}", CurrentConference.StartDate.Day, CurrentConference.EndDate.Day, CurrentConference.EndDate, CurrentConference.EndDate.Year);
                else
                    ConferenceDateLabel.InnerText = String.Format("{0} {2:MMMM} {3}", CurrentConference.StartDate.Day, CurrentConference.EndDate.Day, CurrentConference.EndDate, CurrentConference.EndDate.Year);
                ConferenceCodeH1.InnerText = CurrentConference.ConferenceName;
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