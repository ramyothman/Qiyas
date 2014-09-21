<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="ManageSystemPages.aspx.cs" Inherits="SocioBuilderSite.Administrator.ContentManagement.ManageSystemPages" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
    <%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
<div class="g12 widgets">
			<div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
				<h3 class="handle">Manage System Pages</h3>
				<div class="inner-content">
                <dx:ASPxGridView ID="PagesGrid" ClientInstanceName="PagesGrid" runat="server" 
                    AutoGenerateColumns="False" DataSourceID="SystemPagesObjectDS" 
                    KeyFieldName="SystemPageId">
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
                        <dx:GridViewDataTextColumn Caption="Id" FieldName="SystemPageId" 
                            ReadOnly="True" VisibleIndex="1" Width="40px">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataComboBoxColumn Caption="System Folder" 
                            FieldName="SystemFolderId" VisibleIndex="2">
                            <PropertiesComboBox DataSourceID="SystemFoldersObjectDS" TextField="Name" 
                                ValueField="SystemFolderId" ValueType="System.Int32">
                            </PropertiesComboBox>
                            <EditFormSettings ColumnSpan="2" />
                        </dx:GridViewDataComboBoxColumn>
                        <dx:GridViewDataTextColumn FieldName="Name" VisibleIndex="3">
                            <EditFormSettings ColumnSpan="2" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Path" VisibleIndex="4">
                            <EditFormSettings ColumnSpan="2" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataComboBoxColumn Caption="Security Access" 
                            FieldName="SecurityAccessTypeId" VisibleIndex="5">
                            <PropertiesComboBox DataSourceID="SecurityAccessTypeObjectDS" TextField="Name" 
                                ValueField="SecurityAccessTypeId" ValueType="System.Int32">
                            </PropertiesComboBox>
                            <EditFormSettings ColumnSpan="2" />
                        </dx:GridViewDataComboBoxColumn>
                        <dx:GridViewDataTextColumn FieldName="RowGuid" 
                            VisibleIndex="5" Visible="False">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataDateColumn FieldName="ModifiedDate" VisibleIndex="6">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataDateColumn>
                        <dx:GridViewDataCheckColumn FieldName="IsActive" VisibleIndex="7">
                        </dx:GridViewDataCheckColumn>
                    </Columns>
                    <SettingsBehavior AllowFocusedRow="True" ConfirmDelete="True" />
                    <SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="450px" />
                    <Settings ShowFilterRow="True" />
                    <SettingsText ConfirmDelete="Are you sure you want to delete this record?" />
                </dx:ASPxGridView>
                <asp:ObjectDataSource ID="SystemPagesObjectDS" runat="server" 
                    DeleteMethod="Delete" InsertMethod="Insert" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.SystemPageLogic" 
                    UpdateMethod="Update">
                    <DeleteParameters>
                        <asp:Parameter Name="Original_SystemPageId" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="SystemPageId" Type="Int32" />
                        <asp:Parameter Name="Name" Type="String" />
                        <asp:Parameter Name="Path" Type="String" />
                        <asp:Parameter Name="SecurityAccessTypeId" Type="Int32" />
                        <asp:Parameter Name="IsActive" Type="Boolean" />
                        <asp:Parameter DbType="Guid" Name="RowGuid" />
                        <asp:Parameter Name="ModifiedDate" Type="DateTime" />
                        <asp:Parameter Name="SystemFolderId" Type="Int32" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="SystemPageId" Type="Int32" />
                        <asp:Parameter Name="Name" Type="String" />
                        <asp:Parameter Name="Path" Type="String" />
                        <asp:Parameter Name="SecurityAccessTypeId" Type="Int32" />
                        <asp:Parameter Name="IsActive" Type="Boolean" />
                        <asp:Parameter DbType="Guid" Name="RowGuid" />
                        <asp:Parameter Name="ModifiedDate" Type="DateTime" />
                        <asp:Parameter Name="SystemFolderId" Type="Int32" />
                        <asp:Parameter Name="Original_SystemPageId" Type="Int32" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="SecurityAccessTypeObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.RoleSecurity.SecurityAccessTypeLogic"></asp:ObjectDataSource>
                <asp:ObjectDataSource ID="SystemFoldersObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.SystemFolderLogic"></asp:ObjectDataSource>

             
                <div class="clearfix">
                    
                </div>
    </div>
    </div>
    </div>
    
</asp:Content>
