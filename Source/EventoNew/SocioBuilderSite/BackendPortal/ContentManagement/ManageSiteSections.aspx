﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdministrationMaster.Master" AutoEventWireup="true" CodeBehind="ManageSiteSections.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.ContentManagement.ManageSiteSections" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            direction: ltr;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MessagePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainPlaceHolder" runat="server">
<div class="portlet ui-widget ui-widget-content ui-helper-clearfix ui-corner-all form-container">
            <div class="portlet-header ui-widget-header">
                <table>
                    <tr>
                        <td><img runat="server" id="Img1" src="~/images/view_icon.png" height="16" width="16" alt="" /></td>
                        <td style="font-size:12px;" class="style1">Manage Site Sections</td>
                    </tr>
                </table>
                                 </div>
            <div class="portlet-content">
            <dx:ASPxGridView ID="FoldersGrid" ClientInstanceName="FoldersGrid" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="SiteSectionObjectDS" KeyFieldName="SiteSectionId">
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
                            <Image Height="32px" Url="~/images/cancelsave32.png" Width="32px">
                            </Image>
                        </CancelButton>
                        <UpdateButton>
                            <Image Height="32px" Url="~/images/filesave32.png" Width="32px">
                            </Image>
                        </UpdateButton>
                        <ClearFilterButton Visible="True">
                        </ClearFilterButton>
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn FieldName="SiteSectionId" 
                        ReadOnly="True" VisibleIndex="1" Caption="Id" Width="50px">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Name" VisibleIndex="2" Width="200px">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Section Parent" 
                        FieldName="SiteSectionParentId" VisibleIndex="3">
                        <PropertiesComboBox DataSourceID="SiteSectionObjectDS" TextField="Name" 
                            ValueField="SiteSectionId" ValueType="System.Int32">
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Section Status" 
                        FieldName="SectionStatusId" VisibleIndex="4">
                        <PropertiesComboBox DataSourceID="SectionStatusObjectDS" TextField="Name" 
                            ValueField="SiteSectionStatusId" ValueType="System.Int32">
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Site" FieldName="SiteId" 
                        VisibleIndex="5">
                        <PropertiesComboBox DataSourceID="SiteObjectDS" TextField="Name" 
                            ValueField="SiteId" ValueType="System.Int32">
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Person" FieldName="PersonId" 
                        VisibleIndex="6">
                        <PropertiesComboBox DataSourceID="PersonObjectDS" TextField="FullName" 
                            ValueField="BusinessEntityId" ValueType="System.Int32">
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Security Access" 
                        FieldName="SecurityAccessTypeId" VisibleIndex="7">
                        <PropertiesComboBox DataSourceID="SecurityAccessObjectDS" TextField="Name" 
                            ValueField="SecurityAccessTypeId" ValueType="System.Int32">
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataTextColumn FieldName="RowGuid" VisibleIndex="8" Visible="False">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn FieldName="ModifiedDate" VisibleIndex="8">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataDateColumn>
                </Columns>
                <SettingsBehavior AllowFocusedRow="True" ConfirmDelete="True" />
                <SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="450px" />
                <Settings ShowFilterRow="True" />
                <SettingsText ConfirmDelete="Are you sure you want to delete this record?" />
    </dx:ASPxGridView>
                
                <asp:ObjectDataSource ID="SiteSectionObjectDS" runat="server" 
                    DeleteMethod="Delete" InsertMethod="Insert" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllBySiteId" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.SiteSectionLogic" 
                    UpdateMethod="Update">
                    <DeleteParameters>
                        <asp:Parameter Name="Original_SiteSectionId" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="SiteSectionId" Type="Int32" />
                        <asp:Parameter Name="Name" Type="String" />
                        <asp:Parameter Name="SiteSectionParentId" Type="Int32" />
                        <asp:Parameter Name="SectionStatusId" Type="Int32" />
                        <asp:Parameter Name="SiteId" Type="Int32" />
                        <asp:Parameter Name="PersonId" Type="Int32" />
                        <asp:Parameter Name="SecurityAccessTypeId" Type="Int32" />
                        <asp:Parameter DbType="Guid" Name="RowGuid" />
                        <asp:Parameter Name="ModifiedDate" Type="DateTime" />
                    </InsertParameters>
                    <SelectParameters>
                        <asp:SessionParameter DefaultValue="0" Name="SiteId" 
                            SessionField="CurrentWorkingSite" Type="String" />
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="SiteSectionId" Type="Int32" />
                        <asp:Parameter Name="Name" Type="String" />
                        <asp:Parameter Name="SiteSectionParentId" Type="Int32" />
                        <asp:Parameter Name="SectionStatusId" Type="Int32" />
                        <asp:Parameter Name="SiteId" Type="Int32" />
                        <asp:Parameter Name="PersonId" Type="Int32" />
                        <asp:Parameter Name="SecurityAccessTypeId" Type="Int32" />
                        <asp:Parameter DbType="Guid" Name="RowGuid" />
                        <asp:Parameter Name="ModifiedDate" Type="DateTime" />
                        <asp:Parameter Name="Original_SiteSectionId" Type="Int32" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
                
                <div class="clearfix">
                    <asp:ObjectDataSource ID="SecurityAccessObjectDS" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.RoleSecurity.SecurityAccessTypeLogic">
                    </asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="SiteObjectDS" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.ContentManagement.SiteLogic">
                    </asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="SectionStatusObjectDS" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.ContentManagement.SiteSectionStatusLogic">
                    </asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="PersonObjectDS" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.Persons.PersonLogic">
                    </asp:ObjectDataSource>
                </div>
            </div>
        </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="DashBoardContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="LeftSideBar" runat="server">
<div class="portlet ui-widget ui-widget-content ui-helper-clearfix ui-corner-all form-container">
            <div class="portlet-header ui-widget-header">
                Site Secionts</div>
            <div class="portlet-content">
                <table>
                    <tr>
                        <td><a href="javascript:void(0);" onclick="FoldersGrid.AddNewRow();">
                        <img runat="server" id="newFolderImage" src="~/images/orange-folder-new.png" height="48" width="48" alt="New Site Sections" />
                        </a></td>
                    </tr>
                    <tr>
                        <td><a href="javascript:void(0);" onclick="FoldersGrid.AddNewRow();" style="font-weight:bold;">Add New</a></td>
                    </tr>
                </table>
                
                <div class="clearfix"></div>
       
            
            </div>
        </div>
</asp:Content>
