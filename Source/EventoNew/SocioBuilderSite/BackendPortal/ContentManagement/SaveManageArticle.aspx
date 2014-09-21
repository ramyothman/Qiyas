<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdministrationMaster.Master" AutoEventWireup="true" CodeBehind="SaveManageArticle.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.ContentManagement.SaveManageArticle" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx"%>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>

<%@ Register assembly="DevExpress.Web.ASPxSpellChecker.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSpellChecker" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="../Scripts/JSON.js"></script>
    <% if (DesignMode)
       {%>
    <script src="../Scripts/ASPxScriptIntelliSense.js" type="text/javascript"></script>
    <% } %>
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

        function IsDXScript(script) {
            return script && script.id && script.id.indexOF("dx") == 0;
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
        var textSepator = ";";
        function OnListBoxSelectionChanged(listBox, args) {
            if (args.index == 0)
                args.isSelected ? listBox.SelectAll() : listBox.UnselectAll();
            UpdateSelectAllItemState();
            UpdateText();
        }

        function UpdateSelectAllItemState() {
            IsAllSelected() ? CheckListComboBox.SelectIndices([0]) : CheckListComboBox.UnselectIndices([0]);
        }

        function IsAllSelected() {
            for (var i = 1; i < CheckListComboBox.GetItemCount(); i++) {
                if (!CheckListComboBox.GetItem(i).selected)
                    return false;
                return true;
            }
        }

        function UpdateText() {
            var selectedItems = checkListBox.GetSelectedItems();
            CheckListComboBox.SetText(GetSelectedItemsText(selectedItems));
        }

        function SynchronizeListBoxValues(dropDown, args) {

            CheckListComboBox.UnselectAll();
            var texts = dropDown.GetText().split(textSepator);
            var values = GetValuesByTexts(texts);
            CheckListComboBox.SelectValues(values);
            UpdateSelectAllItemState();
            UpdateText();

        }

        function GetSelectedItemsText(items) {
            var texts = [];
            for (var i = 0; i < items.length; i++)
                if (items[i].index != 0)
                    texts.push(items[i].text);
            return texts.join(textSepator);

        }
        function GetValuesByTexts(texts) {
            var actualValues = [];
            var item;
            for (var i = 0; i < texts.length; i++) {
                item = CheckListComboBox.FindItemByText(texts[i]);
                if (item != null)
                    actualValues.push(item.value);

            }
            return actualValues;
        }

        </script>
     
    <style type="text/css">
        .style1
        {
            height: 55px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MessagePlaceHolder" runat="server">
<div runat="server" id="NoticeMessage">
</div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainPlaceHolder" runat="server">

 
      
<div="Title Title-spacing>
<table>
   <tr>
      
        <td rowspan="2">
            <img runat="server" id="pageImage" src="~/images/PageManagement.png" alt="Page Management"
                        height="48" width="48" />
         </td>
        <td>
            <h2> 
               Article Manage: <span runat="server" id="TitleHeaderInfo">[New]</span>
            </h2>
         </td>
   </tr>
   <tr>
         <td valign="top">
                  This page allow you to place information for the article page 
         </td>
   </tr>
   
</table>
</div>
    <dx:ASPxCallbackPanel ID="ArticleContentLanguageCallbackPanel" ClientInstanceName="ArticleContentLanguageCallbackPanel"
        runat="server" LoadingDivStyle-BackColor="Gray" OnCallback="ArticleContentLanguageCallbackPanel_Callback">
        <LoadingDivStyle BackColor="Gray">
        </LoadingDivStyle>
        <PanelCollection>
            <dx:HtmlEditorRoundPanelContent>
                <table>
                    <tr>
                        <td class="rbmcenter-label">Language</td>
                            
                        
                        <td>
                            <dx:ASPxComboBox ID="ArticleLanguages" runat="server" DataSourceID="ArticleLanguageDS"
                                ValueType="System.Int32" TextField="ArticleName" ValueField="LanguageId">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) {
                            ArticleContentLanguageCallbackPanel.performCallback(s.GetValue());}"  />
                            </dx:ASPxComboBox>
                            <asp:ObjectDataSource ID="ArticleLanguageDS" runat="server" OldValuesParameterFormatString="original_{0}"
                                SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.ContentManagement.ArticleLanguageLogic">
                            </asp:ObjectDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td class="rbmcenter-label">
                            Title
                        </td>
                        <td>
                            <dx:ASPxTextBox ID="ArticleTitle" runat="server" Width="170px">
                                <ValidationSettings CausesValidation="True" Display="Dynamic">
                                    <RequiredField ErrorText="*Please Enter Title" IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="rbmcenter-label">
                            Alies
                        </td>
                        <td>
                            <dx:ASPxTextBox ID="ArticleAlies" runat="server" Width="170px">
                            </dx:ASPxTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="rbmcenter-label">
                            Article
                        </td>
                        <td>
                            <dx:ASPxComboBox ID="ArticleSite" runat="server" DataSourceID="ArticleSiteObjectDS"
                                ValueType="System.Int32" ValueField="ArticleId">
                                <ClientSideEvents SelectedIndexChanged="function(s, e) {ArticleContentLanguageCallbackPanel.performCallback(s.GetValue());}" />
                                <ValidationSettings CausesValidation="True" Display="Dynamic">
                                    <RequiredField ErrorText="Please Select Article" IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxComboBox>
                            <asp:ObjectDataSource ID="ArticleSiteObjectDS" runat="server" OldValuesParameterFormatString="original_{0}"
                                SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.ContentManagement.ArticleLogic">
                            </asp:ObjectDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td class="rbmcenter-label">
                            Categories
                        </td>
                        <td>
                            <dx:ASPxDropDownEdit ClientInstanceName="CheckListComboBox" 
                                ID="categoriesDropDown" runat="server" Width="210px" EnableAnimation="false">
                            <DropDownWindowTemplate>
                                <dx:ASPxListBox Width="100px" ID="ListBox" ClientInstanceName="CheckListComboBox" SelectionMode="CheckColumn"
                                    runat="server" DataSourceID="SiteCategories" TextField="" ValueField="" ValueType="System.Int32">
                                    <ClientSideEvents SelectedIndexChanged="OnListBoxSelectionChanged" />
                                </dx:ASPxListBox>
                                <table style="width:100%"><tr><td align="right">
                                <dx:ASPxButton ID="Button" AutoPostBack="false" runat="server"
                                 Text="Close">
                                 <ClientSideEvents Click="function(s, e) {CheckListComboBox.HideDropDown(); }" />
                                 </dx:ASPxButton> 
                                </td> </tr>
                                </table>
                            </DropDownWindowTemplate>
                            <ClientSideEvents TextChanged="SynchronizeListBoxValues" DropDown="SynchronizeListBoxValues" />
                            </dx:ASPxDropDownEdit>
                            
                            <asp:ObjectDataSource ID="SiteCategories" runat="server" OldValuesParameterFormatString="original_{0}"
                                SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.ContentManagement.ArticleCategoryLogic">
                            </asp:ObjectDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td class="rbmcenter-label">
                            State
                        </td>
                        <td>
                            <dx:ASPxComboBox ID="ArticleState" runat="server" DataSourceID="StateObjectDS" 
                                ValueType="System.Int32" TextField="Name" ValueField="ArticleStatusId">
                                <ValidationSettings CausesValidation="True" Display="Dynamic">
                                    <RequiredField ErrorText="Please Select State" IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxComboBox>
                            <asp:ObjectDataSource ID="StateObjectDS" runat="server" OldValuesParameterFormatString="original_{0}"
                                SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.ContentManagement.ArticleStatusLogic">
                            </asp:ObjectDataSource>
                        </td>
                    </tr>
                </table>
                <br />
                <div>
                    <div class="portlet ui-widget ui-widget-content ui-helper-clearfix ui-corner-all form-container">
                        <div class="portlet-header ui-widget-header">
                            Article Content
                        </div>
                        <div class="portlet-content">
                            <dx:ASPxHtmlEditor ID="ArticleContent" runat="server">
                            </dx:ASPxHtmlEditor>
                        </div>
                        <div class="ClearFix">
                        </div>
                    </div>
                </div>
            </dx:HtmlEditorRoundPanelContent>
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
                            EnableDefaultAppearance="false" Width="48px" Height="48px" OnClick="SaveButton_Click">
                            <HoverStyle BackColor="#CDE9FF">
                            </HoverStyle>
                            <FocusRectBorder BorderStyle="None" />
                            <BackgroundImage HorizontalPosition="0px" ImageUrl="~/images/filesave.png" Repeat="NoRepeat" />
                            <Border BorderStyle="None" />
                        </dx:ASPxButton>
                    </td>
                    <td align="center" style="text-align: center;">
                        <dx:ASPxButton ID="ApplyButton" runat="server" BackColor="Transparent" ToolTip="Apply"
                            EnableDefaultAppearance="false" Width="48px" Height="48px" OnClick="ApplyButton_Click">
                            <HoverStyle BackColor="#CDE9FF">
                            </HoverStyle>
                            <FocusRectBorder BorderStyle="None" />
                            <BackgroundImage HorizontalPosition="0px" ImageUrl="~/images/applysave.png" Repeat="NoRepeat" />
                            <Border BorderStyle="None" />
                        </dx:ASPxButton>
                    </td>
                    <td align="center" style="text-align: center;">
                        <a href="ManageArticles.aspx">
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
