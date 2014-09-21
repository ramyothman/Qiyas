using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Conference
{
    public partial class TravelView : Code.RbmCommon.ConferenceBasePage
    {
        class TravelInfo
        {
            // Fields...
            private string _TravelDescription;
            private string _TravelType;
            private string _Name;


            public string Name
            {
                get { return _Name; }
                set
                {
                    _Name = value;
                }
            }


            public string TravelType
            {
                get { return _TravelType; }
                set
                {
                    _TravelType = value;
                }
            }


            public string TravelDescription
            {
                get { return _TravelDescription; }
                set
                {
                    _TravelDescription = value;
                }
            }
            
        }
        public BusinessLogicLayer.Entities.Conference.Conferences CurrentConference
        {
            get
            {
                return Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this.Page);
            }
        }
        List<TravelInfo> TravelInfoCollection = new List<TravelInfo>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BusinessLogicLayer.Components.Conference.TravelLogic travelLogic = new BusinessLogicLayer.Components.Conference.TravelLogic();
                System.Collections.Generic.List<BusinessLogicLayer.Entities.Conference.Travel> list = travelLogic.GetAllByConferenceID(CurrentConference.ConferenceId);
                int langId = Code.RbmCommon.ConferenceBasePage.GetCurrentPageLanguageId(this.Page);
                foreach (BusinessLogicLayer.Entities.Conference.Travel travel in list)
                {
                    TravelInfo info = new TravelInfo();
                    
                    BusinessLogicLayer.Entities.Conference.Travellanguage travelLang = travel.GetByLanguageId(langId);
                    if (travelLang != null && !travelLang.NewRecord)
                    {
                        info.Name = travelLang.Name;
                        info.TravelDescription = travelLang.Description;
                        info.TravelType = travelLang.TransportationTypeLanguage;
                    }
                    else
                    {
                        info.Name = travel.Name;
                        info.TravelDescription = travel.Description;
                        info.TravelType = travel.TransportationType.TypeName;
                    }
                    TravelInfoCollection.Add(info);
                }
                TravelRepeater.DataSource = TravelInfoCollection;
                TravelRepeater.DataBind();
                //List<> List = travelLogic.GetAllByConferenceID(CurrentConference.ConferenceId);
            }
        }
    }
}