<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdministrationMaster.Master" AutoEventWireup="true" CodeBehind="ManageSystemFunction.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.ContentManagement.ManageSystemFunction" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MessagePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <dx:ASPxGridView ID="ASPxGridView1" ClientInstanceName="sgrid" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SystemFunctionDS" KeyFieldName="SystemFunctionId">
        <Columns>
            <dx:GridViewCommandColumn ButtonType="Image" VisibleIndex="0">
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
            <dx:GridViewDataTextColumn FieldName="SystemFunctionId" ReadOnly="True" 
                ShowInCustomizationForm="True" VisibleIndex="1">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Name" ShowInCustomizationForm="True" 
                VisibleIndex="2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataCheckColumn FieldName="IsActive" ShowInCustomizationForm="True" 
                VisibleIndex="3">
            </dx:GridViewDataCheckColumn>
            <dx:GridViewDataCheckColumn FieldName="IsBackendFunction" 
                ShowInCustomizationForm="True" VisibleIndex="4">
            </dx:GridViewDataCheckColumn>
            <dx:GridViewDataTextColumn FieldName="RowGuid" ShowInCustomizationForm="True" 
                Visible="False" VisibleIndex="4">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn FieldName="ModifiedDate" 
                ShowInCustomizationForm="True" VisibleIndex="5">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataDateColumn>
        </Columns>
        <SettingsBehavior AllowFocusedRow="True" ConfirmDelete="True" />
        <SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="450px" />
        <Settings ShowFilterRow="True" />
        <SettingsText ConfirmDelete="Are you sure you want to delete this record?" />
    </dx:ASPxGridView>
    <asp:ObjectDataSource ID="SystemFunctionDS" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
        TypeName="BusinessLogicLayer.Components.RoleSecurity.SystemFunctionLogic" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_SystemFunctionId" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="IsActive" Type="Boolean" />
            <asp:Parameter Name="IsBackendFunction" Type="Boolean" />
            <asp:Parameter DbType="Guid" Name="RowGuid" />
            <asp:Parameter Name="ModifiedDate" Type="DateTime" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="IsActive" Type="Boolean" />
            <asp:Parameter Name="IsBackendFunction" Type="Boolean" />
            <asp:Parameter DbType="Guid" Name="RowGuid" />
            <asp:Parameter Name="ModifiedDate" Type="DateTime" />
            <asp:Parameter Name="Original_SystemFunctionId" Type="Int32" />
        </UpdateParameters>
    </asp:ObjectDataSource>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="DashBoardContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="LeftSideBar" runat="server">
<div class="portlet ui-widget ui-widget-content ui-helper-clearfix ui-corner-all form-container">
            <div class="portlet-header ui-widget-header">
                Site Categories</div>
            <div class="portlet-content">
                <table>
                    <tr>
                        <td><a href="javascript:void(0);" onclick="sgrid.AddNewRow();">
                        <img runat="server" id="newFolderImage" src="~/images/addCategories.png" height="48" width="48" alt="Site Categories" />
                        </a></td>
                    </tr>
                    <tr>
                        <td><a href="javascript:void(0);" onclick="sgrid.AddNewRow();" style="font-weight:bold;">Add New</a></td>
                    </tr>
                </table>
                
                <div class="clearfix"></div>
       
            
            </div>
        </div>
</asp:Content>
