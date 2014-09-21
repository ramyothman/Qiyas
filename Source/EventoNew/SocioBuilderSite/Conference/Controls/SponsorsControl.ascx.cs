using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Conference.Controls
{
    public class SponsorImage
    {
        private string _ImagePath;
        public string ImagePath
        {
            get { return _ImagePath; }
            set
            {
                _ImagePath = value;
            }
        }

        private string _ClassName;
        public string ClassName
        {
            get { return _ClassName; }
            set
            {
                _ClassName = value;
            }
        }

        private string _Url;
        public string Url
        {
            get { return _Url; }
            set
            {
                _Url = value;
            }
        }

        private string _SponsorName;
        public string SponsorName
        {
            get { return _SponsorName; }
            set
            {
                _SponsorName = value;
            }
        }
        
    }
    public partial class SponsorsControl : System.Web.UI.UserControl
    {
        public BusinessLogicLayer.Entities.Conference.Conferences CurrentConference
        {
            get
            {
                return Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this.Page);
            }
        }
        private List<SponsorImage> sponsorImageList;
        void LoadSponsorList()
        {
            BusinessLogicLayer.Components.Conference.SponsorslanguageLogic sponsorLangLogic = new BusinessLogicLayer.Components.Conference.SponsorslanguageLogic();
            List<BusinessLogicLayer.Entities.Conference.Sponsors> sponsors = BusinessLogicLayer.Common.SponsorsLogic.GetAllByConferenceId(CurrentConference.ConferenceId.ToString());
            sponsorImageList = new List<SponsorImage>();
            int count = 1;
            foreach (BusinessLogicLayer.Entities.Conference.Sponsors sponsor in sponsors)
            {
                BusinessLogicLayer.Entities.Conference.Sponsorslanguage sponsorLanguage = sponsor.GetSponsorByLanguageId(Code.RbmCommon.ConferenceBasePage.GetCurrentPageLanguageId(this.Page));
                SponsorImage simage = new SponsorImage();
                simage.ImagePath = System.Configuration.ConfigurationManager.AppSettings["SponsorDefaultImagePath"];
                if (sponsorLanguage != null)
                {
                    if (!string.IsNullOrEmpty(sponsorLanguage.SponsorImage))
                        simage.ImagePath = BusinessLogicLayer.Common.SponsorDefaultImageFolder + sponsorLanguage.SponsorImage;
                    simage.SponsorName = sponsorLanguage.SponsorName;
                }
                else
                {
                    
                    if (!string.IsNullOrEmpty(sponsor.SponsorImage))
                        simage.ImagePath = BusinessLogicLayer.Common.SponsorDefaultImageFolder + sponsor.SponsorImage;
                    simage.SponsorName = sponsor.SponsorName;
                }
                if (count % 3 == 0)
                {
                    simage.ClassName = "noright";
                }
                count++;
                sponsorImageList.Add(simage);
            }
            //for (int i = count; i <= 9; i++)
            //{
            //    SponsorImage simage = new SponsorImage();
            //    simage.ImagePath = System.Configuration.ConfigurationManager.AppSettings["SponsorDefaultImagePath"];
            //    if (i % 3 == 0)
            //    {
            //        simage.ClassName = "noright";
            //    }
            //    sponsorImageList.Add(simage);
            //}
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSponsorList();
                SponsorsRepeater.DataSource = sponsorImageList;
                SponsorsRepeater.DataBind();
            }
        }
    }
}