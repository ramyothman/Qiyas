<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master" AutoEventWireup="true" CodeBehind="HotelView.aspx.cs" Inherits="SocioBuilderSite.Conference.HotelView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Repeater runat="server" ID="HotelRepeater">
<ItemTemplate>
<h1 runat="server" id="VenueTitle">
        <%# Eval("Name") %>
    </h1>

<div class="content-all">
<div id="ContentData">
    <div runat="server" id="ContentDiv">
    <%# Eval("Description") %>
</div>
			</div>
    <div class="clear">
    </div>
</div>
				<div class="clear"></div>
                <br />

</ItemTemplate>
</asp:Repeater>
</asp:Content>
