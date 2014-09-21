using System;
using System.Collections.Generic;
using System.Web;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Threading;
using System.Globalization;
using SocioBuilderSite.Code.RbmCommon;
using SocioBuilderSite.Code.RbmSecurity;
using BusinessLogicLayer.Entities.Persons;
using BusinessLogicLayer.Components.RoleSecurity;
using System.Linq;
using System.Data.Linq;
using BusinessLogicLayer.Components.ContentManagement;
using BusinessLogicLayer.Entities.ContentManagement;
using BusinessLogicLayer.Entities.RoleSecurity;
/// <summary>
/// Summary description for AdminBasePage
/// </summary>
public class AdminBasePage : BasePage
{
    List<int> SystemFunctionIds;
    public AdminBasePage()
    {
        
        //
        // TODO: Add constructor logic here
        //
    }
    protected void Page_Init(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            if (!string.IsNullOrEmpty(Request["Logout"]))
            {
                if (SecurityManager.doLogout(this))
                    Response.Redirect("~/Administrator/Login/Default.aspx");

            }
            if (!SecurityManager.isLogged(this))
            {
                Response.Redirect(ResolveUrl("~/Administrator/Login/Default.aspx") + "?ReturnUrl=" + this.Page.Request.Url.AbsoluteUri);
                //Response.Redirect("~/Administrator/Login/Default.aspx?ReturnUrl=" + this.Page.Request.Url.AbsoluteUri);
            }
            else
            {

                //TODO: apply security
                string path = this.Request.Url.AbsolutePath.Remove(0, 1);
                Person person = this.Session["USER"] as Person;
                List<int> RoleIds = new PersonRoleLogic().GetAllByPersonID(person.BusinessEntityId).Select(c => c.RoleId).ToList();
                SystemPage page = new SystemPageLogic().GetByPagePath(path);
                bool hasAccess = false;
                SystemFunctionIds = new List<int>();
                if (RoleIds.Contains(2))
                {
                    hasAccess = true;
                }
                else
                {
                    foreach (int RoleID in RoleIds)
                    {
                        SystemFunctionIds.AddRange(new RolePrivilegeLogic().GetAll(RoleID).Where(c => c.ContentEntityId == page.SystemPageId).Select(r => r.SystemFunctionId));
                        if (new RolePrivilegeLogic().GetAll(RoleID).Select(r => r.ContentEntityId).Contains(page.SystemPageId))
                        {
                            hasAccess = true;

                        }
                    }
                }
                if (!hasAccess)
                {
                    Response.Redirect("~/Administrator/NoAccess.aspx");
                }
                //ApplySecuritySettings();
            }
        }


    }
     
    private void ApplySecurityOnControl(Control parent)
    {        
        foreach (Control ctlContent in parent.Controls)
        {
            if (ctlContent is ContentPlaceHolder)
            {

                using (Control ctlChild = ctlContent.FindControl("AddNew"))
                {

                    System.Web.UI.HtmlControls.HtmlAnchor c = ctlChild as System.Web.UI.HtmlControls.HtmlAnchor;
                    if (c != null)
                    {
                        if (!SystemFunctionIds.Contains((int)PrivilegeFor.CanInsert))
                            c.Visible = false;
                    }
                }
                foreach (Control ctlChild in ctlContent.Controls)
                {
                    #region ChildControls
                    using (DevExpress.Web.ASPxGridView.ASPxGridView grid = ctlChild as DevExpress.Web.ASPxGridView.ASPxGridView)
                    {
                        if (grid != null)
                        {
                            foreach (DevExpress.Web.ASPxGridView.GridViewColumn col in grid.Columns)
                            {
                                DevExpress.Web.ASPxGridView.GridViewCommandColumn cmdCol = col as DevExpress.Web.ASPxGridView.GridViewCommandColumn;
                                if (cmdCol != null)
                                {

                                    if (!SystemFunctionIds.Contains((int)PrivilegeFor.CanInsert))
                                    {
                                        cmdCol.NewButton.Visible = false;
                                    }
                                    if (!SystemFunctionIds.Contains((int)PrivilegeFor.CanEdit))
                                    {
                                        cmdCol.EditButton.Visible = false;
                                    }
                                    if (!SystemFunctionIds.Contains((int)PrivilegeFor.CanDelete))
                                    {
                                        cmdCol.DeleteButton.Visible = false;
                                    }
                                }
                                if (col.Caption.Trim() == "Update")
                                {
                                    if (!SystemFunctionIds.Contains((int)PrivilegeFor.CanEdit))
                                        col.Visible = false;
                                }
                            }

                        }
                    }
                    #endregion
                }
            }
            else
            {
                ApplySecurityOnControl(ctlContent);
            }
        }
    }
    private void ApplySecuritySettings()
    {
        //string url = "~" + Tools.getWebsiteUrl(this);
        foreach (Control ctlMaster in this.Page.Controls)
        {
            if (ctlMaster is MasterPage)
            {
                foreach (Control ctlForm in ctlMaster.Controls)
                {
                    if (ctlForm is HtmlForm)
                    {

                        foreach (Control ctlContent in ctlForm.Controls)
                        {
                            ApplySecurityOnControl(ctlContent);

                        }
                    }
                }
            }

        }
    }

    
}
