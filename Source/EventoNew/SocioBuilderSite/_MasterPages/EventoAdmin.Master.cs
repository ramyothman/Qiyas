using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer.Entities.ContentManagement;
using BusinessLogicLayer.Components.ContentManagement;
using BusinessLogicLayer.Entities.Persons;

namespace SocioBuilderSite._MasterPages
{
    public partial class EventoAdmin : System.Web.UI.MasterPage
    {
   
        #region private Members
        private List<MenuEntityItem> menuList;
        private List<MenuEntityItem> subMenuList;
     
        #endregion
        #region Page Events
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                Person person = this.Session["USER"] as Person;
                ltrUserName.Text = person.DisplayName;
                menuList = new MenuEntityItemLogic().GetAllParentItemsForItemId(Convert.ToInt32(BusinessLogicLayer.Common.AdminMenu));
                RptrMenuItem.DataSource = menuList;
                RptrMenuItem.DataBind();
            }
        }
        public string GetPagePath(string url, int MenuEntityTypeId)
        {
            string result = url;
            if (MenuEntityTypeId == Convert.ToInt32(MenuEntityTypeEnum.SiteContent) || MenuEntityTypeId == Convert.ToInt32(MenuEntityTypeEnum.SystemPage))
                if (!url.StartsWith("~/"))
                    result = "~/" + result;

            return result;
        }
        #endregion
        #region Rptr Controls Events
        protected void RptrMenuItem_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemIndex != -1)
            {
                MenuEntityItem TopMenu = menuList[e.Item.ItemIndex];
                Repeater RptrSubMenuItem = (Repeater)e.Item.FindControl("RptrSubMenuItem");                
                RptrSubMenuItem.DataSource = subMenuList = new MenuEntityItemLogic().GetAllByParent(TopMenu.MenuEntityItemId);
                RptrSubMenuItem.DataBind();
            }

        }
        protected void RptrSubMenuItem_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemIndex != -1)
            {
                MenuEntityItem  TopMenu = subMenuList[e.Item.ItemIndex];
                Repeater RptrSubSubMenuItem = (Repeater)e.Item.FindControl("RptrSubSubMenuItem");
                //HyperLink HLSubMenuItem = (HyperLink)e.Item.FindControl("HLSubMenuItem");
                //HLSubMenuItem.NavigateUrl = ResolveUrl("~/" + TopMenu.SystemPageSystemPageIDItem.Path);
                List<MenuEntityItem> subsubMenuList;
                RptrSubSubMenuItem.DataSource = subsubMenuList = new MenuEntityItemLogic().GetAllByParent(TopMenu.MenuEntityItemId);
                RptrSubSubMenuItem.DataBind();
               
            }
        }
     
    
   
        #endregion
   
    }
}