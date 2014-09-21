using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Controls.BackendPortal
{
    public partial class SiteMenuItemsControl : System.Web.UI.UserControl
    {
        public BusinessLogicLayer.Entities.ContentManagement.ContentEntity CurrentContentEntity
        {
            set
            {
                ViewState["CurrentContentEntity"] = value;
            }
            get
            {
                if (ViewState["CurrentContentEntity"] == null)
                {
                    if (!string.IsNullOrEmpty(Request["CurrentEntity"]))
                    {
                        int id = 0;
                        Int32.TryParse(Request["CurrentEntity"], out id);
                        ViewState["CurrentContentEntity"] = BusinessLogicLayer.Common.ContentEntityLogic.GetByID(id);
                    }                    
                }
                return ViewState["CurrentContentEntity"] as BusinessLogicLayer.Entities.ContentManagement.ContentEntity;
            }
        }
        public string CurrentContentEntityName
        {
            set { ViewState["CurrentContentEntityName"] = value; }
            get 
            {
                return ViewState["CurrentContentEntityName"].ToString();
            }
        }
        public BusinessLogicLayer.Entities.ContentManagement.MenuEntity CurrentMenuEntity
        {
            set
            {
                ViewState["CurrentMenuEntity"] = value;
            }
            get
            {
                if (ViewState["CurrentMenuEntity"] == null)
                {
                    BusinessLogicLayer.Entities.ContentManagement.MenuEntity entity = null;
                    
                    if (entity == null)
                    {
                        entity = new BusinessLogicLayer.Entities.ContentManagement.MenuEntity();
                        entity.ContentEntityId = CurrentContentEntity.ContentEntityId;
                        entity.MenuName = String.Format("{0}-{1}", CurrentContentEntity.ContentEntityType, CurrentContentEntityName);
                        BusinessLogicLayer.Common.MenuEntityLogic.Insert(entity);
                    }
                    ViewState["CurrentMenuEntity"] = entity;
                }
                return ViewState["CurrentMenuEntity"] as BusinessLogicLayer.Entities.ContentManagement.MenuEntity;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}