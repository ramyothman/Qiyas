<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdministrationMaster.Master" AutoEventWireup="true" CodeBehind="ManageRoles.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.RoleSecurity.ManageRoles" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MessagePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainPlaceHolder" runat="server">
<div class="title title-spacing">
        <h2>
            <span runat="server" id="titleProfileHolder"></span>Manage Roles
        </h2>
    </div>
    <dx:ASPxGridView ID="ManageRolesGrid" runat="server" 
        AutoGenerateColumns="False" DataSourceID="RolesObjectDS" KeyFieldName="RoleId">
        <Columns>
            <dx:GridViewCommandColumn VisibleIndex="0">
                <EditButton Visible="True">
                </EditButton>
                <NewButton Visible="True">
                </NewButton>
                <DeleteButton Visible="True">
                </DeleteButton>
                <ClearFilterButton Visible="True">
                </ClearFilterButton>
            </dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn FieldName="RoleId" ReadOnly="True" VisibleIndex="1">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Name" VisibleIndex="2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataCheckColumn FieldName="IsActive" VisibleIndex="3">
            </dx:GridViewDataCheckColumn>
            <dx:GridViewDataTextColumn FieldName="RowGuid" Visible="False" VisibleIndex="3">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn FieldName="ModifiedDate" VisibleIndex="4">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataDateColumn>
        </Columns>
        <SettingsBehavior ConfirmDelete="True" />
        <SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="450px" />
        <Settings ShowFilterRow="True" />
        <SettingsText ConfirmDelete="Are you sure you want to delete this record?" />
    </dx:ASPxGridView>
    <asp:ObjectDataSource ID="RolesObjectDS" runat="server" DeleteMethod="Delete" 
        InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetAll" 
        TypeName="BusinessLogicLayer.Components.RoleSecurity.RoleLogic" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_RoleId" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="IsActive" Type="Boolean" />
            <asp:Parameter DbType="Guid" Name="RowGuid" />
            <asp:Parameter Name="ModifiedDate" Type="DateTime" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="IsActive" Type="Boolean" />
            <asp:Parameter DbType="Guid" Name="RowGuid" />
            <asp:Parameter Name="ModifiedDate" Type="DateTime" />
            <asp:Parameter Name="Original_RoleId" Type="Int32" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    <br />

    <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="RolePrivilegesObjectDS" KeyFieldName="RolePrivilegeId">
        <Columns>
            <dx:GridViewDataTextColumn Caption="Id" FieldName="RolePrivilegeId" 
                ReadOnly="True" VisibleIndex="0">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Role Id" FieldName="RoleId" 
                VisibleIndex="1">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="ContentEntityId" VisibleIndex="2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="SystemFunctionId" VisibleIndex="3">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataCheckColumn FieldName="HasAccess" VisibleIndex="4">
            </dx:GridViewDataCheckColumn>
            <dx:GridViewDataDateColumn FieldName="ModifiedDate" VisibleIndex="5">
            </dx:GridViewDataDateColumn>
        </Columns>
    </dx:ASPxGridView>
    <asp:ObjectDataSource ID="RolePrivilegesObjectDS" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
        TypeName="BusinessLogicLayer.Components.RoleSecurity.RolePrivilegeLogic" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_RolePrivilegeId" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="RoleId" Type="Int32" />
            <asp:Parameter Name="ContentEntityId" Type="Int32" />
            <asp:Parameter Name="SystemFunctionId" Type="Int32" />
            <asp:Parameter Name="HasAccess" Type="Boolean" />
            <asp:Parameter Name="ModifiedDate" Type="DateTime" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="RoleId" Type="Int32" />
            <asp:Parameter Name="ContentEntityId" Type="Int32" />
            <asp:Parameter Name="SystemFunctionId" Type="Int32" />
            <asp:Parameter Name="HasAccess" Type="Boolean" />
            <asp:Parameter Name="ModifiedDate" Type="DateTime" />
            <asp:Parameter Name="Original_RolePrivilegeId" Type="Int32" />
        </UpdateParameters>
    </asp:ObjectDataSource>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="DashBoardContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="LeftSideBar" runat="server">
</asp:Content>
