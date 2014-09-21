<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="NoAccess.aspx.cs" Inherits="SocioBuilderSite.Administrator.NoAccess" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
<br />
<br />
<asp:Label ID="lbl" runat="server" Text="You haven't permission to access this page please contact system administrator for support." ForeColor="White" Font-Bold="true"></asp:Label>
</asp:Content>
