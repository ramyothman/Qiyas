using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;
using System.Linq.Expressions;
namespace SocioBuilderSite.Conference
{
    public partial class HotelView : Code.RbmCommon.ConferenceBasePage
    {
        class HotelData
        {
            // Fields...
            private string _Location;
            private string _Phone;
            private string _Fax;
            private string _Email;
            private int _Star;
            private string _Url;
            private string _Description;
            private string _Name;


            public string Name
            {
                get { return _Name; }
                set
                {
                    _Name = value;
                }
            }


            public string Description
            {
                get { return _Description; }
                set
                {
                    _Description = value;
                }
            }


            public string Url
            {
                get { return _Url; }
                set
                {
                    _Url = value;
                }
            }


            public int Star
            {
                get { return _Star; }
                set
                {
                    _Star = value;
                }
            }


            public string Email
            {
                get { return _Email; }
                set
                {
                    _Email = value;
                }
            }


            public string Fax
            {
                get { return _Fax; }
                set
                {
                    _Fax = value;
                }
            }


            public string Phone
            {
                get { return _Phone; }
                set
                {
                    _Phone = value;
                }
            }


            public string Location
            {
                get { return _Location; }
                set
                {
                    _Location = value;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BusinessLogicLayer.Components.Conference.HotelLanguageLogic venueLangLogic = new BusinessLogicLayer.Components.Conference.HotelLanguageLogic();
                int langId = Code.RbmCommon.ConferenceBasePage.GetCurrentPageLanguageId(this.Page);
                List<BusinessLogicLayer.Entities.Conference.Hotel> hotels = new BusinessLogicLayer.Components.Conference.HotelLogic().GetAllByConferenceID(CurrentConference.ConferenceId);
                
                List<HotelData> hdata = new List<HotelData>();
                foreach (BusinessLogicLayer.Entities.Conference.Hotel hotel in hotels)
                {
                    HotelData h = new HotelData();
                    h.Email = hotel.Email;
                    h.Fax = hotel.Fax;
                    h.Phone = hotel.Phone;
                    h.Star = hotel.Star;
                    h.Url = hotel.URL;
                    if (langId == 1)
                    {
                        h.Description = hotel.Description;
                        h.Name = hotel.Name;
                        h.Location = hotel.Location;
                    }
                    else
                    {
                        List<BusinessLogicLayer.Entities.Conference.HotelLanguage> pageLang = venueLangLogic.GetAll(hotel.ID, langId);
                        var hlang = (from x in pageLang where x.ParentID == hotel.ID select x).FirstOrDefault();
                        if (hlang != null)
                        {
                            h.Location = hlang.Location;
                            h.Name = hlang.Name;
                            h.Description = hlang.Description;
                        }
                    }
                    hdata.Add(h);
                }

                HotelRepeater.DataSource = hdata;
                HotelRepeater.DataBind();
                //if (pageLang != null && !pageLang.NewRecord)
                //{
                //    ContentDiv.InnerHtml = pageLang.Description;
                //    VenueTitle.InnerText = pageLang.Name;
                //}
                //else if (CurrentConference.ConferenceVenue != null)
                //{
                //    ContentDiv.InnerHtml = CurrentConference.ConferenceVenue.Description;
                //    VenueTitle.InnerText = CurrentConference.ConferenceVenue.Name;
                //}
            }
        }
    }
}