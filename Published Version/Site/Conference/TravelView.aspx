<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master" AutoEventWireup="true" CodeBehind="TravelView.aspx.cs" Inherits="SocioBuilderSite.Conference.TravelView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>
<asp:Literal runat="server" ID="PageTitle" Text='<%$Resources:ConferenceFront, TravelView_Title %>'></asp:Literal>
</h1>

<div class="content-all">
<div id="ContentData">
    <div runat="server" id="ContentDiv">
    <asp:Repeater runat="server" ID="TravelRepeater">
        <HeaderTemplate>
        <p>
        </HeaderTemplate>
        <ItemTemplate>
            <span style="font-weight:bold;"><%# Eval("Name")%></span> (<span><%# Eval("TravelType")%></span>)<br />
            <span><%# Eval("TravelDescription")%></span><br /><br />
        </ItemTemplate>
        <FooterTemplate>
        </p>
        </FooterTemplate>
    </asp:Repeater>
</div>
			</div>
    <div class="clear">
    </div>
</div>
				<div class="clear"></div>
               
</asp:Content>
