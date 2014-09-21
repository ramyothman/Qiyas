<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdministrationMaster.Master" AutoEventWireup="true" CodeBehind="AllWardDisplay.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.BedManagement.AllWardDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MessagePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainPlaceHolder" runat="server">
<div class="title title-spacing">
        <h2>
            <span runat="server" id="titleProfileHolder"></span> All Wards Display
        </h2>
        This page contains the display of all wards you can click on a ward to enter it.
    </div>
    <a href="AllWardRoomsDisplay.aspx">
<img src="Images/WardsDisplay.png" alt="Ward Display" /></a>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="DashBoardContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="LeftSideBar" runat="server">
<div class="portlet ui-widget ui-widget-content ui-helper-clearfix ui-corner-all">
        <div class="portlet-header ui-widget-header">
            All Wards Statistics</div>
        <div class="portlet-content">
        Total Capacities: 800<br />
        Free Beds: 100
        Occupied Beds: 650
        Closed Beds: 50
            </div>
    </div>
    
</asp:Content>
