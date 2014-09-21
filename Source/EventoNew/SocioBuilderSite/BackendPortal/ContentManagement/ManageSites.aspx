﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdministrationMaster.Master" AutoEventWireup="true" CodeBehind="ManageSites.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.ContentManagement.ManageSites" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MessagePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainPlaceHolder" runat="server">
<div class="portlet ui-widget ui-widget-content ui-helper-clearfix ui-corner-all form-container">
            <div class="portlet-header ui-widget-header">
                <table>
                    <tr>
                        <td><img runat="server" id="Img1" src="~/images/sitesManagement.png" height="16" width="16" alt="" /></td>
                        <td style="font-size:12px;">Manage Sites</td>
                    </tr>
                </table>
                                 </div>
            <div class="portlet-content">
                <dx:ASPxGridView ID="SitesGrid" ClientInstanceName="SitesGrid" runat="server" 
                    AutoGenerateColumns="False" DataSourceID="SitesObjectDS" KeyFieldName="SiteId">
                    <Columns>
                        <dx:GridViewCommandColumn ButtonType="Image" VisibleIndex="0" Width="60px">
                            <DeleteButton Visible="True">
                                <Image Height="16px" Url="~/images/griddelete.png" Width="16px">
                                </Image>
                            </DeleteButton>
                            <EditButton Visible="True">
                                <Image Height="16px" Url="~/images/editgrid.png" Width="16px">
                                </Image>
                            </EditButton>
                            <NewButton Visible="True">
                                <Image Height="16px" Url="~/images/newgrid.png" Width="16px">
                                </Image>
                            </NewButton>
                            <CancelButton>
                                <Image Url="~/images/cancelsave32.png">
                                </Image>
                            </CancelButton>
                            <UpdateButton>
                                <Image Url="~/images/filesave32.png">
                                </Image>
                            </UpdateButton>
                            <ClearFilterButton Visible="True">
                            </ClearFilterButton>
                        </dx:GridViewCommandColumn>
                        <dx:GridViewDataTextColumn Caption="Id" FieldName="SiteId" ReadOnly="True" 
                            ShowInCustomizationForm="True" VisibleIndex="1">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Name" ShowInCustomizationForm="True" 
                            VisibleIndex="2">
                            <EditFormSettings ColumnSpan="2" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="TimeFormat" 
                            ShowInCustomizationForm="True" VisibleIndex="3">
                            <PropertiesTextEdit ConvertEmptyStringToNull="False">
                            </PropertiesTextEdit>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="DateFormat" 
                            ShowInCustomizationForm="True" VisibleIndex="4">
                            <PropertiesTextEdit ConvertEmptyStringToNull="False">
                            </PropertiesTextEdit>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="PostSize" ShowInCustomizationForm="True" 
                            Visible="False" VisibleIndex="5">
                            <EditFormSettings Visible="True" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataComboBoxColumn Caption="Section" FieldName="DefaultSectionId" 
                            VisibleIndex="5">
                            <PropertiesComboBox DataSourceID="DefaultSectionObjectDS" TextField="Name" 
                                ValueField="SiteSectionId" ValueType="System.Int32">
                            </PropertiesComboBox>
                        </dx:GridViewDataComboBoxColumn>
                        <dx:GridViewDataComboBoxColumn Caption="Comment Status" 
                            FieldName="DefaultCommentStatusId" Visible="False" VisibleIndex="6">
                            <PropertiesComboBox DataSourceID="DefaultCommentStatusObjectDS" 
                                TextField="CommentStatusName" ValueField="CommentStatusId" 
                                ValueType="System.Int32">
                            </PropertiesComboBox>
                            <EditFormSettings Visible="True" />
                        </dx:GridViewDataComboBoxColumn>
                        <dx:GridViewDataComboBoxColumn Caption="Security Access" 
                            FieldName="DefaultSecurityAccessTypeId" VisibleIndex="6">
                            <PropertiesComboBox DataSourceID="SecurityObjectDS" TextField="Name" 
                                ValueField="SecurityAccessTypeId" ValueType="System.Int32">
                            </PropertiesComboBox>
                        </dx:GridViewDataComboBoxColumn>
                        <dx:GridViewDataTextColumn FieldName="HomeNewsCount" 
                            ShowInCustomizationForm="True" Visible="False" VisibleIndex="7">
                            <EditFormSettings Visible="True" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="HomeEventsCount" 
                            ShowInCustomizationForm="True" Visible="False" VisibleIndex="7">
                            <EditFormSettings Visible="True" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataComboBoxColumn Caption="Master Page" 
                            FieldName="MasterPageTemplateId" VisibleIndex="7">
                            <PropertiesComboBox DataSourceID="MasterPageObjectDS" TextField="Name" 
                                ValueField="MasterPageTemplateId" ValueType="System.Int32">
                            </PropertiesComboBox>
                        </dx:GridViewDataComboBoxColumn>
                        <dx:GridViewDataCheckColumn FieldName="ShowFullTextArticles" 
                            ShowInCustomizationForm="True" Visible="False" VisibleIndex="8">
                            <EditFormSettings Visible="True" />
                        </dx:GridViewDataCheckColumn>
                        <dx:GridViewDataCheckColumn FieldName="AllowPostingComments" 
                            ShowInCustomizationForm="True" Visible="False" VisibleIndex="8">
                            <EditFormSettings Visible="True" />
                        </dx:GridViewDataCheckColumn>
                        <dx:GridViewDataCheckColumn FieldName="AllowAnonymousComments" 
                            ShowInCustomizationForm="True" Visible="False" VisibleIndex="8">
                            <EditFormSettings Visible="True" />
                        </dx:GridViewDataCheckColumn>
                        <dx:GridViewDataTextColumn FieldName="RowGuid" ShowInCustomizationForm="True" 
                            Visible="False" VisibleIndex="8">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataDateColumn FieldName="ModifiedDate" 
                            ShowInCustomizationForm="True" VisibleIndex="8">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataDateColumn>
                        <dx:GridViewDataCheckColumn FieldName="IsActive" ShowInCustomizationForm="True" 
                            VisibleIndex="9">
                        </dx:GridViewDataCheckColumn>
                    </Columns>
                    <SettingsBehavior AllowFocusedRow="True" ConfirmDelete="True" />
                    <SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="500px" />
                    <Settings ShowFilterRow="True" />
                    <SettingsText ConfirmDelete="Are you sure you want to delete this record?" />
                </dx:ASPxGridView>
                <asp:ObjectDataSource ID="SitesObjectDS" runat="server" DeleteMethod="Delete" 
                    InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
                    SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.SiteLogic" 
                    UpdateMethod="Update">
                    <DeleteParameters>
                        <asp:Parameter Name="Original_SiteId" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="SiteId" Type="Int32" />
                        <asp:Parameter Name="Name" Type="String" />
                        <asp:Parameter Name="IsActive" Type="Boolean" />
                        <asp:Parameter Name="TimeFormat" Type="String" />
                        <asp:Parameter Name="DateFormat" Type="String" />
                        <asp:Parameter Name="PostSize" Type="Int32" />
                        <asp:Parameter Name="DefaultSectionId" Type="Int32" />
                        <asp:Parameter Name="DefaultCommentStatusId" Type="Int32" />
                        <asp:Parameter Name="DefaultSecurityAccessTypeId" Type="Int32" />
                        <asp:Parameter Name="HomeNewsCount" Type="Int32" />
                        <asp:Parameter Name="HomeEventsCount" Type="Int32" />
                        <asp:Parameter Name="MasterPageTemplateId" Type="Int32" />
                        <asp:Parameter Name="ShowFullTextArticles" Type="Boolean" />
                        <asp:Parameter Name="AllowPostingComments" Type="Boolean" />
                        <asp:Parameter Name="AllowAnonymousComments" Type="Boolean" />
                        <asp:Parameter DbType="Guid" Name="RowGuid" />
                        <asp:Parameter Name="ModifiedDate" Type="DateTime" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="SiteId" Type="Int32" />
                        <asp:Parameter Name="Name" Type="String" />
                        <asp:Parameter Name="IsActive" Type="Boolean" />
                        <asp:Parameter Name="TimeFormat" Type="String" />
                        <asp:Parameter Name="DateFormat" Type="String" />
                        <asp:Parameter Name="PostSize" Type="Int32" />
                        <asp:Parameter Name="DefaultSectionId" Type="Int32" />
                        <asp:Parameter Name="DefaultCommentStatusId" Type="Int32" />
                        <asp:Parameter Name="DefaultSecurityAccessTypeId" Type="Int32" />
                        <asp:Parameter Name="HomeNewsCount" Type="Int32" />
                        <asp:Parameter Name="HomeEventsCount" Type="Int32" />
                        <asp:Parameter Name="MasterPageTemplateId" Type="Int32" />
                        <asp:Parameter Name="ShowFullTextArticles" Type="Boolean" />
                        <asp:Parameter Name="AllowPostingComments" Type="Boolean" />
                        <asp:Parameter Name="AllowAnonymousComments" Type="Boolean" />
                        <asp:Parameter DbType="Guid" Name="RowGuid" />
                        <asp:Parameter Name="ModifiedDate" Type="DateTime" />
                        <asp:Parameter Name="Original_SiteId" Type="Int32" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="DefaultSectionObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.SiteSectionLogic"></asp:ObjectDataSource>
                <asp:ObjectDataSource ID="DefaultCommentStatusObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.CommentStatusLogic"></asp:ObjectDataSource>
                <asp:ObjectDataSource ID="SecurityObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.RoleSecurity.SecurityAccessTypeLogic"></asp:ObjectDataSource>
                <asp:ObjectDataSource ID="MasterPageObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.MasterPageTemplateLogic"></asp:ObjectDataSource>

                <div class="clearfix"></div>
            </div>
        </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="DashBoardContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="LeftSideBar" runat="server">
<div class="portlet ui-widget ui-widget-content ui-helper-clearfix ui-corner-all form-container">
            <div class="portlet-header ui-widget-header">
                Sites</div>
            <div class="portlet-content">
                <table>
                    <tr>
                        <td><a href="javascript:void(0);" onclick="SitesGrid.AddNewRow();">
                        <img runat="server" id="newFolderImage" src="~/images/AddSite.png" height="48" width="48" alt="New System Folder" />
                        </a></td>
                    </tr>
                    <tr>
                        <td><a href="javascript:void(0);" onclick="SitesGrid.AddNewRow();" style="font-weight:bold;">Add New</a></td>
                    </tr>
                </table>
                
                <div class="clearfix"></div>
       
            
            </div>
        </div>

</asp:Content>
