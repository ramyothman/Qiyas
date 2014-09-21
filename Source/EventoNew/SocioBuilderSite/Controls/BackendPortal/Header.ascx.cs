using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Controls
{
    public partial class Header : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["CurrentWorkingSite"] != null)
                {
                    SiteSettingsGrid.DataBind();
                    int index = SiteSettingsGrid.FindVisibleIndexByKeyValue(Session["CurrentWorkingSite"].ToString());
                    SiteSettingsGrid.Selection.SetSelection(index,true);
                }
            }
        }

        protected void SiteSettingsCallback_Callback(object source, DevExpress.Web.ASPxCallback.CallbackEventArgs e)
        {
            Session["CurrentWorkingSite"] = e.Parameter;
            int index = SiteSettingsGrid.FindVisibleIndexByKeyValue(Session["CurrentWorkingSite"].ToString());
            e.Result= index.ToString();
        }
    }
}