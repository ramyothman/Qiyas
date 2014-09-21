using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxGridView;

namespace SocioBuilderSite.BackendPortal.Conference
{
    public partial class ManageConferencePrograms : AdminBasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                object values = ConferenceProgramGrid.GetRowValues(Convert.ToInt32(0), new string[] { "ConferenceProgramId" });
                if (values == null)
                    values = "0";
                Session["ParentID"] = values.ToString();
            }
        }
        protected void ASPxGridView1_BeforePerformDataSelect(object sender, EventArgs e)
        {

            Session["ParentID"] = (sender as ASPxGridView).GetMasterRowKeyValue();
        }
    }
}