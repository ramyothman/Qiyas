<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdministrationMaster.Master" AutoEventWireup="true" CodeBehind="SaveSitePage.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.ContentManagement.SaveSitePage" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<%@ Register assembly="DevExpress.Web.ASPxSpellChecker.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSpellChecker" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="../Scripts/JSON.js"></script>
    <% if (DesignMode)
   { %>
   <script src="../Scripts/ASPxScriptIntelliSense.js" type="text/javascript"></script>
    <%} %>
<script type="text/javascript">
    function PatchJQuery() {

        if (!window.jQuery || !window.jQuery.clean)
            return;

        var original = window.jQuery.clean;
        window.jQuery.clean = function (elems, context, fragment, scripts) {
            var execResult = original.call(jQuery, elems, context, fragment, scripts);
            if (scripts && scripts.length) {
                for (var i = scripts.length - 1; i >= 0; i--) {
                    var script = scripts[i];
                    if (IsDXScript(script))
                        ArrayRemoveAt(scripts, i);
                }
            }
            return execResult;
        };
    }

    // Utils
    function IsDXScript(script) {
        return script && script.id && script.id.indexOf("dx") == 0;
    }
    function ArrayRemoveAt(array, index) {
        if (index >= 0 && index < array.length) {
            for (var i = index; i < array.length - 1; i++)
                array[i] = array[i + 1];
            array.pop();
        }
    }

    PatchJQuery();
    </script>

    <script type="text/javascript">
        var textSeparator = ";";
        function OnListBoxSelectionChanged(listBox, args) {
            if (args.index == 0)
                args.isSelected ? listBox.SelectAll() : listBox.UnselectAll();
            UpdateSelectAllItemState();
            UpdateText();
        }
        function UpdateSelectAllItemState() {
            IsAllSelected() ? checkListBox.SelectIndices([0]) : checkListBox.UnselectIndices([0]);
        }
        function IsAllSelected() {
            for (var i = 1; i < checkListBox.GetItemCount(); i++)
                if (!checkListBox.GetItem(i).selected)
                    return false;
            return true;
        }
        function UpdateText() {
            var selectedItems = checkListBox.GetSelectedItems();
            checkComboBox.SetText(GetSelectedItemsText(selectedItems));
        }
        function SynchronizeListBoxValues(dropDown, args) {
            checkListBox.UnselectAll();
            var texts = dropDown.GetText().split(textSeparator);
            var values = GetValuesByTexts(texts);
            checkListBox.SelectValues(values);
            UpdateSelectAllItemState();
            UpdateText();  // for remove non-existing texts
        }
        function GetSelectedItemsText(items) {
            var texts = [];
            for (var i = 0; i < items.length; i++)
                if (items[i].index != 0)
                    texts.push(items[i].text);
            return texts.join(textSeparator);
        }
        function GetValuesByTexts(texts) {
            var actualValues = [];
            var item;
            for (var i = 0; i < texts.length; i++) {
                item = checkListBox.FindItemByText(texts[i]);
                if (item != null)
                    actualValues.push(item.value);
            }
            return actualValues;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MessagePlaceHolder" runat="server">
<div runat="server" id="NoticeMessage">
    
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <div class="title title-spacing">
        <table>
            <tr>
                <td rowspan="2">
                    <img runat="server" id="pageImage" src="~/images/PageManagement.png" alt="Page Management"
                        height="48" width="48" />
                </td>
                <td>
                    <h2>
                        Page Manager : <span runat="server" id="titleHeaderInfo">[New]</span>
                    </h2>
                </td>
            </tr>
            <tr>
                <td valign="top">
                    This page allows you to place information for the site page
                </td>
            </tr>
        </table>
    </div>
    <dx:ASPxValidationSummary ID="MainFormValidationSummary" runat="server" 
        BackColor="#F9E5E6" ForeColor="#B50007" ShowErrorsInEditors="True" 
        Width="100%" HeaderText="Missing Information" Visible="False">
        <HeaderStyle Font-Bold="True" />
        <Border BorderColor="#E8AAAD" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxValidationSummary>
                    <dx:ASPxCallbackPanel ID="pageContentLanguageCallbackPanel" 
                    ClientInstanceName="pageContentLanguageCallbackPanel" runat="server" LoadingDivStyle-BackColor="Gray" 
                    oncallback="pageContentLanguageCallbackPanel_Callback">
<LoadingDivStyle BackColor="Gray"></LoadingDivStyle>
                    <PanelCollection>
<dx:PanelContent ID="PanelContent1" runat="server"  SupportsDisabledAttribute="True">
    <div>
        <table>
            <tr>
                <td class="rbmcenter-label">Language</td>
                <td>
                    <dx:ASPxComboBox ID="pageLanguages" runat="server" 
                        DataSourceID="PageContentObjectDS" TextField="Name" ValueField="LanguageId" 
                        ValueType="System.Int32">
                        <ClientSideEvents SelectedIndexChanged="function(s, e) {
	pageContentLanguageCallbackPanel.PerformCallback(s.GetValue());
}" />
                    </dx:ASPxComboBox>
                    <asp:ObjectDataSource ID="PageContentObjectDS" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.ContentManagement.LanguageLogic">
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td class="rbmcenter-label">
                    Title
                </td>
                <td>
                    <dx:ASPxTextBox ID="pageTitle" runat="server" Width="170px">
                        <ValidationSettings CausesValidation="True" Display="Dynamic">
                            <RequiredField ErrorText="* Please Enter Title" IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </td>
            </tr>
            <tr>
                <td class="rbmcenter-label">
                    Alias
                </td>
                <td>
                    <dx:ASPxTextBox ID="pageAlias" runat="server" Width="170px">
                    </dx:ASPxTextBox>
                </td>
            </tr>
            <tr>
                <td class="rbmcenter-label">
                    Site
                </td>
                <td>
                    <dx:ASPxComboBox ID="pageSite" runat="server" DataSourceID="SiteObjectDS" 
                        TextField="Name" ValueField="SiteId" ValueType="System.Int32">
                        <ClientSideEvents SelectedIndexChanged="function(s, e) {
	pageSection.PerformCallback(s.GetValue());
}" />
                        <ValidationSettings CausesValidation="True" Display="Dynamic">
                            <RequiredField ErrorText="* Please Select Site" IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                    <asp:ObjectDataSource ID="SiteObjectDS" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.ContentManagement.SiteLogic">
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td class="rbmcenter-label">Section</td>
                <td>
                    <dx:ASPxComboBox ID="pageSection" runat="server" 
                        ClientInstanceName="pageSection" DataSourceID="SectionObjectDS" 
                        oncallback="pageSection_Callback" TextField="Name" ValueField="SiteSectionId" 
                        ValueType="System.Int32">
                        <ValidationSettings CausesValidation="True" Display="Dynamic">
                            <RequiredField ErrorText="* Please Select Section" IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                    <asp:ObjectDataSource ID="SectionObjectDS" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllBySiteId" 
                        TypeName="BusinessLogicLayer.Components.ContentManagement.SiteSectionLogic">
                        <SelectParameters>
                            <asp:Parameter Name="SiteId" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td class="rbmcenter-label">
                    Categories
                </td>
                <td>
                    <dx:ASPxDropDownEdit ClientInstanceName="checkComboBox" ID="categoriesDropDownEdit" Width="210px" runat="server" EnableAnimation="False">
                     <DropDownWindowTemplate>
                         <dx:ASPxListBox Width="100%" ID="listBox" ClientInstanceName="checkListBox" 
                             SelectionMode="CheckColumn" runat="server" 
                             DataSourceID="CategoriesObjectDS" TextField="Name" ValueField="SiteCategoryId" 
                             ValueType="System.Int32">
                             <ClientSideEvents SelectedIndexChanged="OnListBoxSelectionChanged" />
                         </dx:ASPxListBox>
                         
                         <table style="width:100%"><tr><td align="right">
                             <dx:ASPxButton ID="ASPxButton1" AutoPostBack="False" runat="server" Text="Close">
                                 <ClientSideEvents Click="function(s, e){ checkComboBox.HideDropDown(); }" />
                             </dx:ASPxButton>
                         </td></tr></table>
                     </DropDownWindowTemplate>
                     <ClientSideEvents TextChanged="SynchronizeListBoxValues" DropDown="SynchronizeListBoxValues" />

<ClientSideEvents DropDown="SynchronizeListBoxValues" TextChanged="SynchronizeListBoxValues"></ClientSideEvents>
                 </dx:ASPxDropDownEdit>
                    <asp:ObjectDataSource ID="CategoriesObjectDS" runat="server" 
                             OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                             TypeName="BusinessLogicLayer.Components.ContentManagement.SiteCategoryLogic">
                     </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td class="rbmcenter-label">
                        State
                </td>
                <td>
                    <dx:ASPxComboBox ID="pageState" runat="server" DataSourceID="StateObjectDS" 
                        TextField="Name" ValueField="PageStatusId" ValueType="System.Int32" 
                        OnSelectedIndexChanged="pageState_SelectedIndexChanged">
                        <ValidationSettings CausesValidation="True" Display="Dynamic">
                            <RequiredField ErrorText="* Please Select Status" IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                    <asp:ObjectDataSource ID="StateObjectDS" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.ContentManagement.PageStatusLogic">
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td  class="rbmcenter-label">Access</td>
                <td>
                    <dx:ASPxComboBox ID="pageSecurityAccess" runat="server" 
                        DataSourceID="SecurityAccessObjectDS" TextField="Name" 
                        ValueField="SecurityAccessTypeId" ValueType="System.Int32">
                        <ValidationSettings CausesValidation="True" Display="Dynamic">
                            <RequiredField ErrorText="* Please Select Access" IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                    <asp:ObjectDataSource ID="SecurityAccessObjectDS" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.RoleSecurity.SecurityAccessTypeLogic">
                    </asp:ObjectDataSource>
                </td>
            </tr>
            
        </table>
    </div>
    <br />
    <div class="portlet ui-widget ui-widget-content ui-helper-clearfix ui-corner-all form-container">
        <div class="portlet-header ui-widget-header">
            Page Content</div>
        <div class="portlet-content">
            <dx:ASPxHtmlEditor ID="pageContent" runat="server" Width="100%">
            </dx:ASPxHtmlEditor>
            <div class="clearfix">
            </div>
        </div>
    </div>
        
</dx:PanelContent>
</PanelCollection>
                </dx:ASPxCallbackPanel>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="DashBoardContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="LeftSideBar" runat="server">
    <div class="portlet ui-widget ui-widget-content ui-helper-clearfix ui-corner-all form-container">
        <div class="portlet-header ui-widget-header">
            Action</div>
        <div class="portlet-content">
            <table style="width: 100%;">
                <tr>
                    <td align="center" style="text-align: center;">
                        <dx:ASPxButton ID="SaveButton" runat="server" BackColor="Transparent" ToolTip="Save"
                            EnableDefaultAppearance="False" Width="48px" Height="48px" OnClick="SaveButton_Click">
                            <HoverStyle BackColor="#CDE9FF">
                            </HoverStyle>
                            <FocusRectBorder BorderStyle="None" />
                            <BackgroundImage HorizontalPosition="0px" ImageUrl="~/images/filesave.png" Repeat="NoRepeat" />
                            <Border BorderStyle="None" />
                        </dx:ASPxButton>
                    </td>
                    <td align="center" style="text-align: center;">
                        <dx:ASPxButton ID="ApplyButton" runat="server" BackColor="Transparent" ToolTip="Apply"
                            EnableDefaultAppearance="False" Width="48px" Height="48px" OnClick="ApplyButton_Click">
                            <HoverStyle BackColor="#CDE9FF">
                            </HoverStyle>
                            <FocusRectBorder BorderStyle="None" />
                            <BackgroundImage HorizontalPosition="0px" ImageUrl="~/images/applysave.png" Repeat="NoRepeat" />
                            <Border BorderStyle="None" />
                        </dx:ASPxButton>
                    </td>
                    <td align="center" style="text-align: center;">
                        <a href="ManageSitePages.aspx">
                            <img runat="server" id="cancelSave" src="~/images/cancelsave.png" alt="Cancel" />
                        </a>
                    </td>
                </tr>
            </table>
            <div class="clearfix">
            </div>
        </div>
    </div>
</asp:Content>
