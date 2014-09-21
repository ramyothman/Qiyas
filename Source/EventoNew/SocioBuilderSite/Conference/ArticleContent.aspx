<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master" AutoEventWireup="true" CodeBehind="ArticleContent.aspx.cs" Inherits="SocioBuilderSite.Conference.ArticleContent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1><asp:Literal ID="TitleLiteral" runat="server" Text=""></asp:Literal>
    </h1>
<div class="content-all">
<div id="ContentData">
    <div runat="server" id="ContentDiv">

</div>
			</div>
    <div class="clear">
    </div>
</div>
				<div class="clear"></div>
</asp:Content>
