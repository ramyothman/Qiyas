<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ActiveTabTemplate.ascx.cs" Inherits="SocioBuilderSite.Conference.Controls.ActiveTabTemplate" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

    <table cellspacing="0" cellpadding="0" border="0" class="selectedTab tabTemplate">
    <tr>
        <td>
            <asp:Image ID="imgTabLeft" runat="server" ImageUrl='<%$Resources:ConferenceFront, PageTab_SelectedLeftImage %>' AlternateText="seletedTabLeft" />
        </td>
        <td class="tabCenter">
            <dx:ASPxLabel ID="lblTabText" runat="server" Text="" CssClass="tabText" />
        </td>
        <td>
            <asp:Image ID="imgTabRight" runat="server" ImageUrl='<%$Resources:ConferenceFront, PageTab_SelectedRightImage %>' AlternateText="seletedTabRight" />
        </td>
    </tr>
</table>
