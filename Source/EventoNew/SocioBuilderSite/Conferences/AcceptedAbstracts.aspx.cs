using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Conferences
{
    public partial class AcceptedAbstracts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OralAbstractHidden.Set("OralCount", 0);
            }
        }
        
        private int _OralCount;
        public int OralCount
        {
            get { return Convert.ToInt32(OralAbstractHidden.Get("OralCount")); }
            set
            {
                OralAbstractHidden.Set("OralCount", value);
            }
        }
        

        public string GetImagePath(string path)
        {
            if (System.IO.File.Exists(BusinessLogicLayer.Common.ConferenceContentPath + path))
            {
                return BusinessLogicLayer.Common.ConferenceContentPath + path;
            }
            else
            {
                return "images/poster-image.png";
            }
        }
    }
}