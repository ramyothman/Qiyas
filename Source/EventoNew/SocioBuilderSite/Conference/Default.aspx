<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SocioBuilderSite.Conference.Default" %>
<%@ Register Src="~/Conference/Controls/SpeakersMainControl.ascx" TagName="SpeakersControl" TagPrefix="evento" %>
<%@ Register Src="~/Conference/Controls/ContentPageControl.ascx" TagName="ContentControl" TagPrefix="evento" %>
<%@ Register Src="~/Conference/Controls/HtmlControl.ascx" TagName="CustomHtmlControl" TagPrefix="evento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<evento:CustomHtmlControl runat="server" ID="TopCustomHtmlControl" CurrentSitePageId="35" />
<evento:SpeakersControl Visible="true" ID="SpeakersControl1" runat="server"></evento:SpeakersControl>				
<evento:ContentControl runat="server" ID="ContentControl1" />
<evento:CustomHtmlControl runat="server" ID="BottomCustomHtmlControl" CurrentSitePageId="36" />
</asp:Content>
