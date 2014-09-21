using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Controls.LiverSite.ar
{
    public partial class MainSlider : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string _MainPageTitleText;
        public string MainPageTitleText
        {
            get { return _MainPageTitleText; }
            set
            {
                MainPageTitle.InnerText = value;
                _MainPageTitleText = value;
            }
        }

        private string _MainPageTitleDescription;
        public string MainPageTitleDescriptionText
        {
            get { return _MainPageTitleDescription; }
            set
            {
                MainPageTitleDescription.InnerText = value;
                _MainPageTitleDescription = value;
            }
        }


        private bool _IsMainPage;
        public bool IsMainPage
        {
            get { return _IsMainPage; }
            set
            {
                ContentPage.Visible = !(value);
                MainPage.Visible = value;
                _IsMainPage = value;
            }
        }
    }
}