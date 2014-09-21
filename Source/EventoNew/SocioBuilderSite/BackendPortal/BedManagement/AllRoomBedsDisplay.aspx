<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdministrationMaster.Master" AutoEventWireup="true" CodeBehind="AllRoomBedsDisplay.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.BedManagement.AllRoomBedsDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MessagePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainPlaceHolder" runat="server">
<div class="title title-spacing">
        <h2>
            <span runat="server" id="titleProfileHolder"></span> Ward A11 - Room 1 - Phone: 71293
        </h2>
        This page contains the display of all beds in room .
    </div>
    <a href="BedDetailDisplay.aspx">
<img src="Images/BedsDisplay.png" alt="Room Display" /></a>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="DashBoardContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="LeftSideBar" runat="server">

<div class="portlet ui-widget ui-widget-content ui-helper-clearfix ui-corner-all">
        <div class="portlet-header ui-widget-header">
            Room Statistics</div>
        <div class="portlet-content">
        Total Capacities: 6<br />
        Free Beds: 1
        Occupied Beds: 5
        Closed Beds: 0
            </div>
    </div>
</asp:Content>
