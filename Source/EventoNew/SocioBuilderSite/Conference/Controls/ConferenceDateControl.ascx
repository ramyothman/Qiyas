<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ConferenceDateControl.ascx.cs" Inherits="SocioBuilderSite.Conference.Controls.ConferenceDateControl" %>
<h1><asp:Literal runat="server" Text='<%$Resources:ConferenceFront, TimeandDate %>' ></asp:Literal></h1>
			<div class="date-block">
				<h2><asp:Literal runat="server" Text="2 - 4" ID="confDateLiteral"></asp:Literal> <span runat="server" id="confMonthYearSpan"> Dec 2012</span></h2>
				<p runat="server" id="confNameParagraph">Acceptance Crlteria in High Education</p>
			<div class="clear"></div>
            </div>
            