<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TabTemplate.ascx.cs" Inherits="SocioBuilderSite.Conference.Controls.TabTemplate" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

 <table cellspacing="0" cellpadding="0" border="0" class="unselectedTab tabTemplate" >
    <tr>
        <td>
            <asp:Image ID="imgTabLeft" runat="server" ImageUrl='<%$Resources:ConferenceFront, PageTab_LeftImage %>' AlternateText="tabLeft" />
        </td>
        <td class="tabCenter">
            <dx:ASPxLabel ID="lblTabText" runat="server" Text="" CssClass="tabText" />
        </td>
        <td>
            <asp:Image ID="imgTabRight" runat="server" ImageUrl="<%$Resources:ConferenceFront, PageTab_RightImage %>" AlternateText="tabRight" />
        </td>
    </tr>
</table>
