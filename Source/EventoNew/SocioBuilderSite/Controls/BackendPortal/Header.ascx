<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="SocioBuilderSite.Controls.Header" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxCallback" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxMenu" TagPrefix="dx" %>

<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<script type="text/javascript">
    function GetSelectedSite() {
        SiteSettingsGrid.GetRowValues(SiteSettingsGrid.GetFocusedRowIndex(),'SiteId', OnGetSelectedValues);
    }

    function OnGetSelectedValues(values){
        alert(values);
    }
</script>
<div id="header">
    <div id="sitename">
        <a runat="server" id="mainHeaderLink" href="~/BackendPortal/Default.aspx" class="logo float-left"
            title="College of Medicine">College of Medicine & University Hospitals</a>
        <%--<div class="button float-right">
			<a href="#" id="dialog_link" class="btn ui-state-default ui-corner-all"><span class="ui-icon ui-icon-newwin"></span>Open Dialog</a>
			<a href="#" id="login_dialog" class="btn ui-state-default ui-corner-all"><span class="ui-icon ui-icon-image"></span>Open Login Box</a>
		</div>
        <div id="dialog" title="Dialog Title">
				<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
		</div>--%>
        <div id="top-menu">
            <a href="javascript:void(0);" onclick="var window = SiteSettingsPopup.GetWindow(0);
SiteSettingsPopup.ShowWindowAtElementByID(window,'tmSettings');" title="Settings" id="tmSettings">
                Settings</a> | <a href="~/BackendPortal/Contactus.aspx" title="Contact us" runat="server"
                    id="tmContactus">Contact us</a> <span>Logged in as <a href="~/BackendPortal/Profile.aspx"
                        title="Logged in as admin" runat="server" id="tmUserName">admin</a></span>
            | <a href="~/BackendPortal/Profile.aspx" title="Edit profile" runat="server" id="tmProfile">
                Edit profile</a> | <a href="~/BackendPortal/Login.aspx?Action=Logout" title="Logout"
                    runat="server" id="tmLogout">Logout</a>
        </div>
    </div>
    <div id="navigationmain">
    <dx:ASPxMenu ID="MainNavigationMenu" runat="server" Height="38px" NavigateUrlField="URL"
        TextField="Caption" ImageUrlField="Image">
        <Items>
            <dx:MenuItem Text="Content Management">
                <Items>
                    <dx:MenuItem NavigateUrl="~/BackendPortal/ContentManagement/ManageSites.aspx" 
                        Text="Manage Sites">
                    </dx:MenuItem>
                    <dx:MenuItem NavigateUrl="~/BackendPortal/ContentManagement/ManageSiteSections.aspx" 
                        Text="Manage Sections">
                    </dx:MenuItem>
                    <dx:MenuItem NavigateUrl="~/BackendPortal/ContentManagement/ManageSitePages.aspx" 
                        Text="Manage Pages">
                    </dx:MenuItem>
                    <dx:MenuItem NavigateUrl="~/BackendPortal/ContentManagement/ManageSiteCategories.aspx" 
                        Text="Manage Site Categories">
                    </dx:MenuItem>
                    <dx:MenuItem NavigateUrl="~/BackendPortal/ContentManagement/ManageSystemFolders.aspx" 
                        Text="Manage System Folders">
                    </dx:MenuItem>
                    <dx:MenuItem NavigateUrl="~/BackendPortal/ContentManagement/ManageSystemPages.aspx" 
                        Text="Manage System Pages">
                    </dx:MenuItem>
                </Items>
            </dx:MenuItem>
            <dx:MenuItem Text="Conference Management">
                <Items>
                    <dx:MenuItem NavigateUrl="~/BackendPortal/Conference/ManageConferences.aspx" 
                        Text="Manage Conferences">
                    </dx:MenuItem>
                    <dx:MenuItem NavigateUrl="~/BackendPortal/Conference/ManageConferencePrograms.aspx" Text="Manage Conference Programs">
                    </dx:MenuItem>
                    <dx:MenuItem NavigateUrl="~/BackendPortal/Conference/ManageConferenceHalls.aspx" Text="Manage Conference Halls">
                    </dx:MenuItem>
                    <dx:MenuItem NavigateUrl="~/BackendPortal/Conference/ManageScheduleSessionTypes.aspx" Text="Manage Conference Schedule">
                    </dx:MenuItem>
                    <dx:MenuItem NavigateUrl="~/BackendPortal/Conference/ManageConferenceSchedule.aspx" Text="Manage Schedule">
                    </dx:MenuItem>
                    <dx:MenuItem NavigateUrl="~/BackendPortal/Conference/ManageSpeakers.aspx" Text="Manage Speakers">
                    </dx:MenuItem>
                    <dx:MenuItem NavigateUrl="~/BackendPortal/Conference/ManageSponsors.aspx" 
                        Text="Manage Sponsors">
                    </dx:MenuItem>
                    <dx:MenuItem NavigateUrl="~/BackendPortal/Conference/ManageAbstracts.aspx" Text="Manage Abstracts">
                    </dx:MenuItem>
                    
                </Items>
            </dx:MenuItem>
            <dx:MenuItem Text="User Management">
                <Items>
                    <dx:MenuItem NavigateUrl="~/BackendPortal/RoleSecurity/ManageUsers.aspx" 
                        Text="Manage Users">
                    </dx:MenuItem>
                </Items>
            </dx:MenuItem>
        </Items>
    </dx:ASPxMenu>
    <asp:XmlDataSource ID="MainMenuXmlDataSource" runat="server" XPath="mainmenu/item"
        EnableCaching="False"></asp:XmlDataSource>
</div>
</div>


<dx:ASPxPopupControl ID="SiteSettingsPopup" 
    ClientInstanceName="SiteSettingsPopup" HeaderText="Default Site" runat="server" 
    PopupHorizontalAlign="OutsideLeft" PopupVerticalAlign="Below" 
    >
    <ContentCollection>
<dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server" SupportsDisabledAttribute="True">
<div id="siteSettingsGridLoadingContainer">
 <dx:ASPxGridView ID="SiteSettingsGrid" ClientInstanceName="SiteSettingsGrid" runat="server" DataSourceID="SitesObjectDS" 
        AutoGenerateColumns="False" KeyFieldName="SiteId">
        <Columns>
            <dx:GridViewDataTextColumn Caption="Id" FieldName="SiteId" ReadOnly="True" 
                ShowInCustomizationForm="True" VisibleIndex="0">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Name" ShowInCustomizationForm="True" Width="200px" 
                VisibleIndex="1" Caption="Site">
                <DataItemTemplate>
                    <a href="javascript:void(0);" onclick="SiteSettingsCallback.PerformCallback('<%# Eval("SiteId") %>')">
                    <%# Eval("Name") %>
                        
                    </a>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
        </Columns>
        
        </dx:ASPxGridView>
        </div>
    <dx:ASPxCallback ID="SiteSettingsCallback" 
        ClientInstanceName="SiteSettingsCallback" runat="server" 
        OnCallback="SiteSettingsCallback_Callback">
        <ClientSideEvents BeginCallback="function(s, e) {
	SiteSettingsLoadingPanel.ShowInElementByID('siteSettingsGridLoadingContainer');
}" CallbackComplete="function(s, e) {
    SiteSettingsGrid.UnselectRows();
    SiteSettingsGrid.SelectRows(e.result);
	SiteSettingsLoadingPanel.Hide();
    SiteSettingsPopup.Hide();

}"  />
    </dx:ASPxCallback>
    <dx:ASPxLoadingPanel ID="SiteSettingsLoadingPanel" ClientInstanceName="SiteSettingsLoadingPanel" runat="server"  
        ContainerElementID="SiteSettingsPopup">
    </dx:ASPxLoadingPanel>
</dx:PopupControlContentControl>
</ContentCollection>
</dx:ASPxPopupControl>
<asp:ObjectDataSource ID="SitesObjectDS" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
    TypeName="BusinessLogicLayer.Components.ContentManagement.SiteLogic">
</asp:ObjectDataSource>
