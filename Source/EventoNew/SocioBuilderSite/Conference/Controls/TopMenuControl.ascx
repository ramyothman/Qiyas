<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TopMenuControl.ascx.cs" Inherits="SocioBuilderSite.Conference.Controls.TopMenuControl" %>

             <asp:Repeater  ID="RptrMenuItem" runat="server" OnItemDataBound="RptrMenuItem_ItemDataBound">
                    <HeaderTemplate>
                        <ul>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <li class="<%# GetItemClass(Container.ItemIndex) %>"><a id="a1" runat="server" href='<%# GetPagePath(Eval("PagePath").ToString(), Convert.ToInt32(Eval("MenuEntityTypeId")))   %>'><%# Eval("Name") %></a>
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