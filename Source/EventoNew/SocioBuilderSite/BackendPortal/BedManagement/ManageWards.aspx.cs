using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.BackendPortal.BedManagement
{
    public partial class ManageWards : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string GetWardTypeHtml(object typeInt)
        {

            string type = WardsGrid.GetRowValuesByKeyValue(typeInt, "WardType").ToString();
            return type;
        }

        protected void WardsGrid_HtmlDataCellPrepared(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewTableDataCellEventArgs e)
        {
            if (e.DataColumn.FieldName == "WardType")
            {
                switch (e.CellValue.ToString())
                {
                    case "M":
                        Control cf = WardsGrid.FindRowCellTemplateControl(e.VisibleIndex, e.DataColumn, "FemaleImage");
                        cf.Visible = false;
                        break;
                    case "F":
                        Control cm = WardsGrid.FindRowCellTemplateControl(e.VisibleIndex, e.DataColumn, "MaleImage");
                        cm.Visible = false;
                        break;
                }
            }
        }
    }
}