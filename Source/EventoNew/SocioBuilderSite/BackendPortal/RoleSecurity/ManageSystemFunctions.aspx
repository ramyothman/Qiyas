﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdministrationMaster.Master" AutoEventWireup="true" CodeBehind="ManageSystemFunctions.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.RoleSecurity.ManageSystemFunctions" %>

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
            <span runat="server" id="titleProfileHolder"></span>Manage System Functions
        </h2>
    </div>
    <dx:ASPxGridView ID="SystemFunctionsGrid" runat="server" 
        AutoGenerateColumns="False" DataSourceID="SystemFunctionObjectDS" 
        KeyFieldName="SystemFunctionId">
        <Columns>
            <dx:GridViewCommandColumn ShowInCustomizationForm="True" VisibleIndex="0">
                <EditButton Visible="True">
                </EditButton>
                <NewButton Visible="True">
                </NewButton>
                <DeleteButton Visible="True">
                </DeleteButton>
                <ClearFilterButton Visible="True">
                </ClearFilterButton>
            </dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn Caption="Id" FieldName="SystemFunctionId" 
                ReadOnly="True" ShowInCustomizationForm="True" VisibleIndex="1">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Name" ShowInCustomizationForm="True" 
                VisibleIndex="2" Width="200px">
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
        <SettingsBehavior ConfirmDelete="True" />
        <SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="450px" />
        <Settings ShowFilterRow="True" />
        <SettingsText ConfirmDelete="Are you sure you want to delete this record?" />
    </dx:ASPxGridView>
    <asp:ObjectDataSource ID="SystemFunctionObjectDS" runat="server" 
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
</asp:Content>