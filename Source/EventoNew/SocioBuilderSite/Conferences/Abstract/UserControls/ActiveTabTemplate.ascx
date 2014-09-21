<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ActiveTabTemplate.ascx.cs" Inherits="SocioBuilderSite.Conferences.Abstract.UserControls.ActiveTabTemplate" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

    <table cellspacing="0" cellpadding="0" border="0" class="selectedTab tabTemplate">
    <tr>
        <td>
            <asp:Image ID="imgTabLeft" runat="server" ImageUrl="~/Conferences/Abstract/images/active_left.png" AlternateText="seletedTabLeft" />
        </td>
        <td class="tabCenter">
            <dx:ASPxLabel ID="lblTabText" runat="server" Text="" CssClass="tabText" />
        </td>
        <td>
            <asp:Image ID="imgTabRight" runat="server" ImageUrl="~/Conferences/Abstract/images/active_right.png" AlternateText="seletedTabRight" />
        </td>
    </tr>
</table>