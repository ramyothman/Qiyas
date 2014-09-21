using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Conference.Controls
{
    public partial class SpeakersMainControl : System.Web.UI.UserControl
    {
        public BusinessLogicLayer.Entities.Conference.Conferences CurrentConference
        {
            get
            {
                return Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this.Page);
            }
        }

        private List<BusinessLogicLayer.Entities.Conference.ConferenceSpeakers> speakersList;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                speakersList = BusinessLogicLayer.Common.ConferenceSpeakersLogic.GetAll(CurrentConference.ConferenceId);
                foreach (BusinessLogicLayer.Entities.Conference.ConferenceSpeakers speaker in speakersList)
                {
                    
                    if (string.IsNullOrEmpty(speaker.SpeakerImage))
                        speaker.SpeakerImage = BusinessLogicLayer.Common.SpeakersDefaultImagePath;
                    else
                        speaker.SpeakerImage = BusinessLogicLayer.Common.SpeakersDefaultImageFolder + speaker.SpeakerImage;
                    //BusinessLogicLayer.Entities.Conference.ConferenceSpeakersLanguage slanguage = speaker.GetSpeakerByLanguageId(Convert.ToInt32(BusinessLogicLayer.Common.DefaultLanguageId));
                    
                }
                SpeakersRepeater.DataSource = speakersList;
                SpeakersRepeater.DataBind();
            }
        }
    }
}