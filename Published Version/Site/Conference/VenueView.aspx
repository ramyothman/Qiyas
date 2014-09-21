<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master" AutoEventWireup="true" CodeBehind="VenueView.aspx.cs" Inherits="SocioBuilderSite.Conference.VenueView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1 runat="server" id="VenueTitle">
        
    </h1>

<div class="content-all">
<div id="ContentData">
    <div runat="server" id="ContentDiv">
    
</div>
<div runat="server" id="GoogleMap" visible="false">
<br />
<iframe  width="640" height="314" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src='<%= "http://maps.google.com/maps/ms?ie=UTF8&amp;hl=en&amp;t=h&amp;safe=on&amp;msa=0&amp;msid=114054029326748302567.00048c260b4cdfb71027d&amp;ll=" + CurrentConference.LocationLongitude + "," + CurrentConference.LocationLatitude + "&amp;spn=0.002087,0.006856&amp;z=17&amp;output=embed" %>'></iframe>
<br />
</div>
			</div>
    <div class="clear">
    </div>
</div>
				<div class="clear"></div>

</asp:Content>
