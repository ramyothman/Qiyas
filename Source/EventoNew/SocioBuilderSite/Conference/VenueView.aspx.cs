using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Conference
{
    public partial class VenueView : Code.RbmCommon.ConferenceBasePage
    {
        public BusinessLogicLayer.Entities.Conference.Conferences CurrentConference
        {
            get
            {
                return Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this.Page);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BusinessLogicLayer.Components.Conference.VenuesLanguageLogic venueLangLogic = new BusinessLogicLayer.Components.Conference.VenuesLanguageLogic();
                int langId = Code.RbmCommon.ConferenceBasePage.GetCurrentPageLanguageId(this.Page);
                BusinessLogicLayer.Entities.Conference.VenuesLanguage pageLang = venueLangLogic.GetAll(CurrentConference.ConferenceVenueID,langId);

                if (pageLang != null && !pageLang.NewRecord)
                {
                    ContentDiv.InnerHtml = pageLang.Description;
                    VenueTitle.InnerText = pageLang.Name;
                }
                else if (CurrentConference.ConferenceVenue != null)
                {
                    ContentDiv.InnerHtml = CurrentConference.ConferenceVenue.Description;
                    VenueTitle.InnerText = CurrentConference.ConferenceVenue.Name;
                }
                if (CurrentConference.LocationLongitude != 0 && CurrentConference.LocationLatitude != 0)
                {
                    GoogleMap.Visible = true;
                    //GoogleMapFrame.Attributes["src"] = string.Format(@"http://maps.google.com/maps/ms?ie=UTF8&amp;hl=en&amp;t=h&amp;safe=on&amp;msa=0&amp;msid=114054029326748302567.00048c260b4cdfb71027d&amp;ll={0},{1}&amp;spn=0.002087,0.006856&amp;z=17&amp;output=embed",CurrentConference.LocationLongitude,CurrentConference.LocationLatitude);
                }
            }
        }
    }
}