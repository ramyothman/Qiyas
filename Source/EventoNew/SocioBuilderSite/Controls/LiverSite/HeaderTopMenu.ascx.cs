using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Controls.LiverSite
{
    public partial class HeaderTopMenu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Code.RbmCommon.Tools.getWebsiteUrl(this.Page).Contains(HomeHref.HRef.Remove(0,2)))
                    HomeHref.Attributes.Add("class", "active");
                else if (Code.RbmCommon.Tools.getWebsiteUrl(this.Page).Contains(BoardofDirectorsHref.HRef.Remove(0, 2)))
                    BoardofDirectorsHref.Attributes.Add("class", "active");
            }
        }
    }
}