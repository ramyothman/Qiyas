<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FooterMenuControl.ascx.cs" Inherits="SocioBuilderSite.Conference.Controls.FooterMenuControl" %>

             <asp:Repeater  ID="RptrMenuItem" runat="server" OnItemDataBound="RptrMenuItem_ItemDataBound">
                    <HeaderTemplate>
                        <ul>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <li class="<%# GetItemClass(Container.ItemIndex) %>"><a id="a1" runat="server" href='<%# GetPagePath(Eval("PagePath").ToString(), Convert.ToInt32(Eval("MenuEntityTypeId")))   %>'><%# Eval("Name") %></a></li>
                    </ItemTemplate>
                    <FooterTemplate>
                        </ul>
                    </FooterTemplate>
                </asp:Repeater>