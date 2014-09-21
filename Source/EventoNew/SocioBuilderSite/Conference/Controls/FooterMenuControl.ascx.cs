using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer.Entities.ContentManagement;
using BusinessLogicLayer.Components.ContentManagement;

namespace SocioBuilderSite.Conference.Controls
{
    public partial class FooterMenuControl : System.Web.UI.UserControl
    {

        #region private Members
        private List<MenuEntityItem> menuList;
        private List<MenuEntityItem> subMenuList;

        #endregion
        public BusinessLogicLayer.Entities.Conference.Conferences CurrentConference
        {
            get
            {
                return Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this.Page);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int LanguageId = 1;
                if (Session["LanguageId"] != null)
                    LanguageId = Convert.ToInt32(Session["LanguageId"]);
                MenuEntityItem item = new MenuEntityItemLogic().GetAllParentItemForSiteIdByLanguageId(CurrentConference.SiteId, LanguageId);
                if (item != null)
                {
                    menuList = new MenuEntityItemLogic().GetAllParentItemsForItemId(item.MenuEntityItemId);
                    ItemCount = menuList.Count;
                    RptrMenuItem.DataSource = menuList;
                    RptrMenuItem.DataBind();
                }

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
        #region Rptr Controls Events
        protected int ItemCount { get; set; }
        protected string GetItemClass(int itemIndex)
        {
            string result = "";
            if (itemIndex == 0)
            {
                result = "";
            }
            else if (itemIndex == this.ItemCount - 1)
            {
                result = "fix";
            }
            else
            {
                result = "";
            }
            MenuEntityItem TopMenu = menuList[itemIndex];
            int count = new MenuEntityItemLogic().GetAllByParent(TopMenu.MenuEntityItemId).Count;
            if (count > 0)
                result += " " + "arrow";
            return result.Trim();
        }
        protected void RptrMenuItem_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemIndex != -1)
            {
                //MenuEntityItem TopMenu = menuList[e.Item.ItemIndex];
                //Repeater RptrSubMenuItem = (Repeater)e.Item.FindControl("RptrSubMenuItem");
                //RptrSubMenuItem.DataSource = subMenuList = new MenuEntityItemLogic().GetAllByParent(TopMenu.MenuEntityItemId);
                //RptrSubMenuItem.DataBind();
            }

        }
        protected void RptrSubMenuItem_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemIndex != -1)
            {
                //MenuEntityItem TopMenu = subMenuList[e.Item.ItemIndex];
                //Repeater RptrSubSubMenuItem = (Repeater)e.Item.FindControl("RptrSubSubMenuItem");
                ////HyperLink HLSubMenuItem = (HyperLink)e.Item.FindControl("HLSubMenuItem");
                ////HLSubMenuItem.NavigateUrl = ResolveUrl("~/" + TopMenu.SystemPageSystemPageIDItem.Path);
                //List<MenuEntityItem> subsubMenuList;
                //RptrSubSubMenuItem.DataSource = subsubMenuList = new MenuEntityItemLogic().GetAllByParent(TopMenu.MenuEntityItemId);
                //RptrSubSubMenuItem.DataBind();

            }
        }
        #endregion

    }
}