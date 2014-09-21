<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SideMenuControl.ascx.cs" Inherits="SocioBuilderSite.Conference.Controls.SideMenuControl" %>
    <div class="left-nav" style="margin-bottom:20px;">
        <asp:Repeater  ID="RptrMenuItem" runat="server" OnItemDataBound="RptrMenuItem_ItemDataBound">
                    <HeaderTemplate>
                        <ul>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <li><a id="a1" runat="server" href='<%# GetPagePath(Eval("PagePath").ToString(), Convert.ToInt32(Eval("MenuEntityTypeId")))   %>'><%# Eval("Name") %></a>
                        <asp:Repeater ID="RptrSubMenuItem" runat="server" OnItemDataBound="RptrSubMenuItem_ItemDataBound">
                                <HeaderTemplate>
                                    <ul>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <li><a id="a1" runat="server" href='<%# GetPagePath(Eval("PagePath").ToString(), Convert.ToInt32(Eval("MenuEntityTypeId")))   %>'><%# Eval("Name") %></a></li>
                                </ItemTemplate>
                                <FooterTemplate>
                                    </ul>
                                </FooterTemplate>
                            </asp:Repeater>
                        </li>
                    </ItemTemplate>
                    <FooterTemplate>
                        </ul>
                    </FooterTemplate>
                </asp:Repeater>
       <%-- <ul>
            <li><a href="#">test item 01</a>
                <ul>
                    <li><a href="#">sup item</a></li>
                    <li><a href="#">sup item</a></li>
                    <li><a href="#">sup item</a></li>
                    <li><a href="#">sup item</a></li>
                    <li><a href="#">sup item</a></li>
                    <li><a href="#">sup item</a></li>
                </ul>
            </li>
            <li><a href="#">test item 02</a></li>
            <li><a href="#">test item 03</a></li>
            <li><a href="#">test item 04</a></li>
            <li><a href="#">test item 05</a></li>
        </ul>--%>
    </div>
    