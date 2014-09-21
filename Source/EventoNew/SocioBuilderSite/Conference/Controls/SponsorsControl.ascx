<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SponsorsControl.ascx.cs" Inherits="SocioBuilderSite.Conference.Controls.SponsorsControl" %>
<h1><asp:Literal ID="Literal1" runat="server" Text='<%$Resources:ConferenceFront, SponsorsSectionHeader %>' ></asp:Literal></h1>
			<div class="side-bar-thumb">
                <asp:Repeater runat="server" ID="SponsorsRepeater">
                <ItemTemplate>
				<img runat="server" src='<%# Eval("ImagePath") %>' class='<%# Eval("ClassName") %>' width="82" height="87" alt="1" />
                </ItemTemplate>
                </asp:Repeater>
                <div class="clear"></div>
                <a runat="server" href='<%$Resources:ConferenceFront, SponsorControl_ImagePathLink %>'><img runat="server" src='<%$Resources:ConferenceFront, SponsorControl_ImagePath %>' /></a>

			</div>