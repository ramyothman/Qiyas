﻿ <%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="ManageSitePages.aspx.cs" Inherits="SSN.Backend.ContentManagement.ManageSitePages" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
 <div class="g12 widgets">
			<div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
				<h3 class="handle">Manage Site Pages</h3>
				<div class="inner-content">
                <a href="SaveSitePage.aspx?PageCode=0"  style="font-weight:bold;">Add New</a>
                <br /><br />
            <dx:ASPxGridView ID="SitePageGrid" ClientInstanceName="SitePageGrid" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="SitePagesObjectDS" KeyFieldName="SitePageId" 
                    oncelleditorinitialize="SitePageGrid_CellEditorInitialize">
                <ClientSideEvents CustomButtonClick="function(s, e) {
	window.location.href ='SaveSitePage.aspx?PageCode=' + s.GetRowKey(s.GetFocusedRowIndex());
}" />
                <Columns>
                    <dx:GridViewCommandColumn ButtonType="Image" VisibleIndex="0" Width="60px" Caption=" ">
                        <DeleteButton Visible="True">
                            <Image Height="16px" Url="~/images/griddelete.png" Width="16px">
                            </Image>
                        </DeleteButton>
                        <EditButton>
                            <Image Height="16px" Url="~/images/editgrid.png" Width="16px">
                            </Image>
                        </EditButton>
                        <NewButton>
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
                        <CustomButtons>
                            <dx:GridViewCommandColumnCustomButton Text="Edit">
                                <Image AlternateText="Edit" Height="16px" Url="~/images/editgrid.png" 
                                    Width="16px">
                                </Image>
                            </dx:GridViewCommandColumnCustomButton>
                        </CustomButtons>
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn FieldName="SitePageId" 
                        ReadOnly="True" VisibleIndex="1" Caption="Id" Visible="false">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Name" FieldName="PageName" VisibleIndex="2">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Site" FieldName="SiteId" 
                        ShowInCustomizationForm="True" VisibleIndex="3">
                        <PropertiesComboBox DataSourceID="SiteObjectDS" TextField="Name" 
                            ValueField="SiteId" ValueType="System.Int32">
                             <ClientSideEvents SelectedIndexChanged="function(s, e) { OnSiteChanged(s); }"></ClientSideEvents>
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Section" FieldName="SectionId" 
                        VisibleIndex="4">
                        <PropertiesComboBox DataSourceID="SectionObjectDS" 
                            IncrementalFilteringMode="Contains" TextField="Name" ValueField="SiteSectionId" 
                            ValueType="System.Int32">
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Status" FieldName="PageStatusId" 
                        VisibleIndex="5">
                        <PropertiesComboBox DataSourceID="StatusObjectDS" TextField="Name" 
                            ValueField="PageStatusId" ValueType="System.Int32">
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Security Access" 
                        FieldName="SecurityAccessTypeId" VisibleIndex="6">
                        <PropertiesComboBox DataSourceID="SecurityAccessObjectDS" TextField="Name" 
                            ValueField="SecurityAccessTypeId" ValueType="System.Int32">
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Creator" FieldName="CreatorId" 
                        VisibleIndex="7">
                        <PropertiesComboBox DataSourceID="PersonObjectDS" TextField="UserName" 
                            ValueField="BusinessEntityId" ValueType="System.Int32">
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataTextColumn FieldName="UniquePageName" VisibleIndex="7" 
                        Caption="Uni. Page Name" Visible="False">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataCheckColumn FieldName="IsMainPage" VisibleIndex="8" 
                        Caption="Main Page">
                    </dx:GridViewDataCheckColumn>
                    <dx:GridViewDataTextColumn FieldName="RowGuid" VisibleIndex="8" Visible="False">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn FieldName="RevisionDate" VisibleIndex="9" 
                        Visible="False">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataDateColumn FieldName="ModifiedDate" VisibleIndex="9">
                    </dx:GridViewDataDateColumn>
                </Columns>
                <SettingsBehavior AllowFocusedRow="True" ConfirmDelete="True" />
                <SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="450px" />
                <Settings ShowFilterRow="True" ShowGroupPanel="True" />
                <SettingsText ConfirmDelete="Are you sure you want to delete this record?" />
    </dx:ASPxGridView>
                
                <asp:ObjectDataSource ID="SitePagesObjectDS" runat="server" 
                    DeleteMethod="Delete" InsertMethod="Insert" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllBySiteId" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.SitePageLogic" 
                    UpdateMethod="Update">
                    <DeleteParameters>
                        <asp:Parameter Name="Original_SitePageId" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="SitePageId" Type="Int32" />
                        <asp:Parameter Name="SectionId" Type="Int32" />
                        <asp:Parameter Name="PageStatusId" Type="Int32" />
                        <asp:Parameter Name="SecurityAccessTypeId" Type="Int32" />
                        <asp:Parameter Name="CreatorId" Type="Int32" />
                        <asp:Parameter Name="UniquePageName" Type="String" />
                        <asp:Parameter Name="IsMainPage" Type="Boolean" />
                        <asp:Parameter DbType="Guid" Name="RowGuid" />
                        <asp:Parameter Name="RevisionDate" Type="DateTime" />
                        <asp:Parameter Name="ModifiedDate" Type="DateTime" />
                        <asp:Parameter Name="SiteId" Type="Int32" />
                    </InsertParameters>
                    <SelectParameters>
                        <asp:SessionParameter DefaultValue="0" Name="SiteId" 
                            SessionField="CurrentWorkingSite" Type="String" />
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="SitePageId" Type="Int32" />
                        <asp:Parameter Name="SectionId" Type="Int32" />
                        <asp:Parameter Name="PageStatusId" Type="Int32" />
                        <asp:Parameter Name="SecurityAccessTypeId" Type="Int32" />
                        <asp:Parameter Name="CreatorId" Type="Int32" />
                        <asp:Parameter Name="UniquePageName" Type="String" />
                        <asp:Parameter Name="IsMainPage" Type="Boolean" />
                        <asp:Parameter DbType="Guid" Name="RowGuid" />
                        <asp:Parameter Name="RevisionDate" Type="DateTime" />
                        <asp:Parameter Name="ModifiedDate" Type="DateTime" />
                        <asp:Parameter Name="SiteId" Type="Int32" />
                        <asp:Parameter Name="Original_SitePageId" Type="Int32" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
                
                <asp:ObjectDataSource ID="SiteObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.SiteLogic">
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="SectionObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllBySiteId" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.SiteSectionLogic">
                    <SelectParameters>
                        <asp:Parameter Name="SiteId" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                
                <asp:ObjectDataSource ID="StatusObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.PageStatusLogic">
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="SecurityAccessObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.RoleSecurity.SecurityAccessTypeLogic">
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="PersonObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.Persons.PersonLogic">
                </asp:ObjectDataSource>
                
    </div>
    </div>
   </div>
</asp:Content>
