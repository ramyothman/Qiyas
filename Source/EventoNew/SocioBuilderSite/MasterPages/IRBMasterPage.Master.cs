using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.MasterPages
{
    public partial class IRBMasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool _LeftSectionVisible;
        public bool LeftSectionVisible
        {
            get { return LeftSectionDiv.Visible; }
            set
            {
                LeftSectionDiv.Visible = value;
            }
        }
        
    }
}