<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="SaveSitePage.aspx.cs" Inherits="SSN.Backend.ContentManagement.SaveSitePage" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxFileManager" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<%@ Register assembly="DevExpress.Web.ASPxSpellChecker.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSpellChecker" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <div class="g8 widgets">
        <div class="widget widget-header-blue">
            <h3 class="handle" runat="server" id="MainSitePageCode">
                Page Details
            </h3>
            <div class="inner-content">
             <ul  class="message no-margin" visible="false" runat="server" id="NoticeMessageDiv">
                    <li runat="server" id="NoticeMessage"></li>
                 </ul>
            <dx:ASPxValidationSummary ID="MainFormValidationSummary" runat="server" 
        BackColor="#F9E5E6" ForeColor="#B50007" ShowErrorsInEditors="True" 
        Width="100%" HeaderText="Missing Information" Visible="False">
        <HeaderStyle Font-Bold="True" />
        <Border BorderColor="#E8AAAD" BorderStyle="Solid" BorderWidth="1px" />
    </dx:ASPxValidationSummary>
                <div class="form">
                    <fieldset class="fieldset">
                        
                        <section><label class="label" for="text_field">Language</label>
							<div>
                                <dx:ASPxComboBox ID="pageLanguages" runat="server" 
                        DataSourceID="PageContentObjectDS" TextField="Name" ValueField="LanguageId" Width="250px" Font-Size="14px"  
                        ValueType="System.Int32">
                        <ClientSideEvents SelectedIndexChanged="function(s, e) {
	pageContentLanguageCallbackPanel.PerformCallback(s.GetValue());
}" />
                    </dx:ASPxComboBox>
                    <asp:ObjectDataSource ID="PageContentObjectDS" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.ContentManagement.LanguageLogic">
                    </asp:ObjectDataSource>
                            </div>
						</section>
                       
                        <section><label class="label" for="text_field">Alias</label>
							<div>
                             <dx:ASPxTextBox ID="pageAlias" runat="server" Width="100%" Font-Size="16px">
                    </dx:ASPxTextBox>
                            </div>
						</section>
                         <section><label class="label" for="text_field">Site</label>
							<div>
                             <dx:ASPxComboBox ID="pageSite" runat="server" DataSourceID="SiteObjectDS" Width="100%" Font-Size="14px"  
                        TextField="Name" ValueField="SiteId" ValueType="System.Int32">
                        <ClientSideEvents SelectedIndexChanged="function(s, e) {
	pageSection.PerformCallback(s.GetValue());
}" />
                        <ValidationSettings CausesValidation="True" Display="Dynamic" ErrorDisplayMode="Text" ErrorTextPosition="Bottom">
                            <RequiredField ErrorText="* Please Select Site" IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                    <asp:ObjectDataSource ID="SiteObjectDS" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.ContentManagement.SiteLogic">
                    </asp:ObjectDataSource>
                            </div>
						</section>
                        <section><label class="label" for="text_field">Section</label>
							<div>
                             <dx:ASPxComboBox ID="pageSection" runat="server" Font-Size="14px" Width="250px"  
                        ClientInstanceName="pageSection" DataSourceID="SectionObjectDS" 
                        oncallback="pageSection_Callback" TextField="Name" ValueField="SiteSectionId" 
                        ValueType="System.Int32">
                        <ValidationSettings CausesValidation="True" Display="Dynamic" ErrorDisplayMode="Text" ErrorTextPosition="Bottom">
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
                            </div>
						</section>
                        
                    </fieldset>
                </div>
            </div>
        </div>
    </div>
    <div class="g4">
    <div class="widget widget-header-blue">
        <h3 class="handle">
             Action</h3>
        <div class="inner-content">
        <table>
                    <tr>
                    <td>
                      <dx:ASPxButton ID="SaveButton" runat="server" BackColor="Transparent" ToolTip="Save"
                            EnableDefaultAppearance="False" Width="48px" Height="48px" OnClick="SaveButton_Click">
                            <HoverStyle BackColor="#CDE9FF">
                            </HoverStyle>
                            <FocusRectBorder BorderStyle="None" />
                            <BackgroundImage HorizontalPosition="0px" ImageUrl="~/images/filesave.png" Repeat="NoRepeat" />
                            <Border BorderStyle="None" />
                        </dx:ASPxButton>
                    </td>
                    <td>
                     <dx:ASPxButton ID="ApplyButton" runat="server" BackColor="Transparent" ToolTip="Apply"
                            EnableDefaultAppearance="False" Width="48px" Height="48px" OnClick="ApplyButton_Click">
                            <HoverStyle BackColor="#CDE9FF">
                            </HoverStyle>
                            <FocusRectBorder BorderStyle="None" />
                            <BackgroundImage HorizontalPosition="0px" ImageUrl="~/images/applysave.png" Repeat="NoRepeat" />
                            <Border BorderStyle="None" />
                        </dx:ASPxButton>
                    </td>
                    
                    <td>
                   <a href="ManageSitePages.aspx">
                            <img runat="server" id="cancelSave" src="~/images/cancelsave.png" alt="Cancel" />    </a>
                    </td>
                    </tr>
                    </table>
                    <br />
                     <div class="form">
                    <fieldset class="fieldset">
                    <section><label class="label" for="text_field">Categories</label>
							<div>
                             <dx:ASPxDropDownEdit ClientInstanceName="checkComboBox" ID="categoriesDropDownEdit" Width="100%" Font-Size="14px" runat="server" EnableAnimation="False">
                     <DropDownWindowTemplate>
                         <dx:ASPxListBox Width="100%" Font-Size="14px" ID="listBox" ClientInstanceName="checkListBox" 
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
                            </div>
						</section>
                        <section><label class="label" for="text_field">State</label>
							<div>
                             <dx:ASPxComboBox ID="pageState" runat="server" DataSourceID="StateObjectDS" Width="100%" Font-Size="14px" 
                        TextField="Name" ValueField="PageStatusId" ValueType="System.Int32" 
                        OnSelectedIndexChanged="pageState_SelectedIndexChanged">
                        <ValidationSettings CausesValidation="True" Display="Dynamic" ErrorDisplayMode="Text" ErrorTextPosition="Bottom">
                            <RequiredField ErrorText="* Please Select Status" IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                    <asp:ObjectDataSource ID="StateObjectDS" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.ContentManagement.PageStatusLogic">
                    </asp:ObjectDataSource>
                            </div>
						</section>
                        <section><label class="label" for="text_field">Access</label>
							<div>
                             <dx:ASPxComboBox ID="pageSecurityAccess" runat="server" Width="100%" Font-Size="14px" 
                        DataSourceID="SecurityAccessObjectDS" TextField="Name" 
                        ValueField="SecurityAccessTypeId" ValueType="System.Int32">
                        <ValidationSettings CausesValidation="True" Display="Dynamic" ErrorDisplayMode="Text" ErrorTextPosition="Bottom">
                            <RequiredField ErrorText="* Please Select Access" IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                    <asp:ObjectDataSource ID="SecurityAccessObjectDS" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.RoleSecurity.SecurityAccessTypeLogic">
                    </asp:ObjectDataSource>
                            </div>
						</section>
                        </fieldset>
                        </div>
        </div>
        </div>
        </div>
 <div class="g12 widgets">
			
                
               
    <dx:ASPxCallbackPanel ID="pageContentLanguageCallbackPanel" 
                    ClientInstanceName="pageContentLanguageCallbackPanel" runat="server" LoadingDivStyle-BackColor="Gray" 
                    oncallback="pageContentLanguageCallbackPanel_Callback">
<LoadingDivStyle BackColor="Gray"></LoadingDivStyle>
                    <PanelCollection>
<dx:PanelContent ID="PanelContent1" runat="server"  SupportsDisabledAttribute="True">
   <div class="form">
                    <fieldset class="fieldset">
                    
                    <label class="label">Page Content</label>
                     <section><label class="label" for="text_field">Title</label>
							<div>
                                <dx:ASPxTextBox ID="pageTitle" runat="server" Width="100%" Font-Size="16px">
                        <ValidationSettings CausesValidation="True" Display="Dynamic" ErrorDisplayMode="Text" ErrorTextPosition="Bottom">
                            <RequiredField ErrorText="* Please Enter Title" IsRequired="True" />
<RequiredField IsRequired="True" ErrorText="* Please Enter Title"></RequiredField>
                        </ValidationSettings>
                    </dx:ASPxTextBox><dx:ASPxCheckBox Text="Is Main Page" runat="server" ID="chkIsMainPage"></dx:ASPxCheckBox>
                            </div>
						</section>
                        <section>
                            <div style="width:95%">
        <div class="portlet-content">
            <dx:ASPxHtmlEditor ID="pageContent" runat="server" Width="100%">
                <SettingsHtmlEditing AllowFormElements="True" AllowIFrames="True" 
                    AllowScripts="True" />
                    <SettingsDocumentSelector Enabled="True">
            <CommonSettings RootFolder="~/ContentData/Documents" AllowedFileExtensions=".doc, .docx, .xls, .xlsx, .pdf, .ppt, .pptx, .rtf" />

                        <editingsettings allowcreate="True" allowdelete="True" allowrename="True" />
<CommonSettings RootFolder="~/ContentData/Documents" 
                            AllowedFileExtensions=".doc, .docx, .xls, .xlsx, .pdf, .ppt, .pptx, .rtf" 
                            initialfolder="Documents" thumbnailfolder="~/ContentData/Documents"></CommonSettings>

<EditingSettings AllowCreate="True" AllowRename="True" AllowDelete="True"></EditingSettings>

                        <uploadsettings enabled="True" useadvanceduploadmode="True">
                        </uploadsettings>
            <PermissionSettings>
                <AccessRules>
                    <dx:FileManagerFolderAccessRule Role="" Upload="Allow" />
                    <dx:FileManagerFolderAccessRule Role="" Path="Documents" Upload="Allow" />
                </AccessRules>
            </PermissionSettings>
        </SettingsDocumentSelector>
        <SettingsImageSelector Enabled="True">
            <CommonSettings RootFolder="~/ContentData/Documents" ThumbnailFolder="~/ContentData/Documents"
                InitialFolder="Documents" />
<CommonSettings ThumbnailFolder="~/ContentData/Documents" RootFolder="~/ContentData/Documents" InitialFolder="Documents" AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></CommonSettings>

            <editingsettings allowcreate="True" />

<EditingSettings AllowCreate="True"></EditingSettings>

            <uploadsettings enabled="True" useadvanceduploadmode="True">
            </uploadsettings>
            <PermissionSettings>
                <AccessRules>
                    <dx:FileManagerFolderAccessRule Role="" Upload="Allow" Browse="Allow" 
                        Edit="Allow" EditContents="Allow" />
                    <dx:FileManagerFolderAccessRule Role="" Path="Documents" Upload="Allow" 
                        Browse="Allow" Edit="Allow" EditContents="Allow" />
                </AccessRules>
            </PermissionSettings>
        </SettingsImageSelector>

<SettingsHtmlEditing AllowScripts="True" AllowIFrames="True" AllowFormElements="True"></SettingsHtmlEditing>

                <SettingsImageUpload useadvanceduploadmode="True">
                    <ValidationSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png">
                    </ValidationSettings>
                </SettingsImageUpload>
                <SettingsImageSelector>
                    <CommonSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png" />
                </SettingsImageSelector>
            </dx:ASPxHtmlEditor>

            <div class="clearfix">
            </div>
        </div>
    </div>
                        </section>
                        </fieldset>
                        </div>
                       
    
        
</dx:PanelContent>
</PanelCollection>
                </dx:ASPxCallbackPanel>

    
    </div>
    
</asp:Content>
