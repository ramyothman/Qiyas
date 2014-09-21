using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxTabControl;

namespace SocioBuilderSite.Conference.Controls
{
    public partial class ActiveTabTemplate : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Parent as TabControlTemplateContainer) != null)
                lblTabText.Text = (Parent as TabControlTemplateContainer).Tab.Text;
            else
                lblTabText.Text = (Parent as PageControlTemplateContainer).TabPage.Text;
        }
    }
}