<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SpeakersMainControl.ascx.cs"
    Inherits="SocioBuilderSite.Conference.Controls.SpeakersMainControl" %>
<h1><asp:Literal runat="server" Text='<%$Resources:ConferenceFront, SpeakersSectionHeader %>'></asp:Literal>
    </h1>
<div class="content-all">
    <div class="thumb-scroller">
        <div id="list">
            <div class="prev">
                <img id="Img1" runat="server" src="~/Conference/images/prev.jpg" alt="prev" width="23"
                    height="31" /></div>
            <div class="slider">
                <asp:Repeater runat="server" ID="SpeakersRepeater">
                    <HeaderTemplate>
                        <ul>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <li><a runat="server" href='<%# "~/Conference/SpeakersInfo.aspx?person=" + Eval("PersonId") + "&speaker=" + Eval("ConferenceSpeakerId") %>'>
                            <img id="Img2" runat="server" src='<%# Eval("SpeakerImage") %>' width="85" height="92"
                                class="captify" alt='<%# Eval("CurrentPerson.DisplayName") %>' /></a></li>
                    </ItemTemplate>
                    <FooterTemplate>
                        </ul>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
            <div class="next">
                <img id="Img3" runat="server" src="~/Conference/images/next.jpg" alt="next" width="25"
                    height="31" /></div>
        </div>
        <div class="clear">
        </div>
    </div>
    <div class="clear">
    </div>
</div>
<div class="clear"></div>
