<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master" AutoEventWireup="true" CodeBehind="Schedules.aspx.cs" Inherits="SocioBuilderSite.Conference.Schedules" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxTabControl" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxClasses" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 id="H1" runat="server">Schedule</h1>
<div runat="server" id="Program2">
    
    <dx:ASPxPageControl ID="schedulePageControl" runat="server" ActiveTabIndex="0" Width="100%">
        <TabPages>
            
            
            
        </TabPages>
    </dx:ASPxPageControl>



</div>
</asp:Content>
