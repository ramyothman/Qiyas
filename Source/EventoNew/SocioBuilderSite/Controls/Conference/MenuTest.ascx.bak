<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuTest.ascx.cs" Inherits="SocioBuilderSite.Controls.Conference.MenuTest" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxMenu" TagPrefix="dx" %>
<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/MenuTabbedMenu.xml" XPath="/mainmenu/item" />

<dx:ASPxMenu ID="ASPxMenu2" runat="server" 
    DataSourceID="XmlDataSource1" 
    EnableDefaultAppearance="False" EnableTheming="false" 
    CssFilePath="~/App_Themes/ConferenceNew/Web/styles.css" CssPostfix="Aqua" 
    ShowSubMenuShadow="False"  >
     <SubMenuStyle ItemSpacing="0px" SeparatorColor="Transparent" 
        SeparatorHeight="0px" SeparatorWidth="0px" GutterImageSpacing="0px">
   
    </SubMenuStyle>
</dx:ASPxMenu>

