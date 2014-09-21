<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdministrationMaster.Master" AutoEventWireup="true" CodeBehind="AllWardRoomsDisplay.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.BedManagement.AllWardRoomsDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MessagePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainPlaceHolder" runat="server">
<div class="title title-spacing">
        <h2>
            <span runat="server" id="titleProfileHolder"></span> Ward A11 - Phone: 71293
        </h2>
        This page contains the display of all rooms in ward you can click on a room to enter it.
    </div>
    <a href="AllRoomBedsDisplay.aspx">
<img src="Images/RoomsDisplay.png" alt="Ward Display" />
</a>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="DashBoardContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="LeftSideBar" runat="server">
<div class="portlet ui-widget ui-widget-content ui-helper-clearfix ui-corner-all">
        <div class="portlet-header ui-widget-header">
            Ward Statistics</div>
        <div class="portlet-content">
        Total Capacities: 16<br />
        Free Beds: 2
        Occupied Beds: 14
        Closed Beds: 0
            </div>
    </div>
</asp:Content>
