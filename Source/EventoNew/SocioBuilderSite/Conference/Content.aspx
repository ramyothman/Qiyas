<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master" AutoEventWireup="true" CodeBehind="Content.aspx.cs" Inherits="SocioBuilderSite.Conference.Content" %>
<%@ Register Src="~/Conference/Controls/ContentPageControl.ascx" TagName="ContentControl" TagPrefix="evento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
<script type="text/javascript" src="http://w.sharethis.com/button/buttons.js"></script>
<script type="text/javascript">stLight.options({ publisher: "5c2c61b9-46c1-40e8-8f17-1edbd015805a" }); </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
<evento:ContentControl runat="server" ID="ContentControl1" />
    <br />
    <div class="social-networks">
        <span class='st_facebook_hcount' displayText='Facebook'></span>
<span class='st_twitter_hcount' displayText='Tweet'></span>
<span class='st_linkedin_hcount' displayText='LinkedIn'></span>
    </div>
</asp:Content>
