<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TopMenu.ascx.cs" Inherits="SocioBuilderSite.Controls.Conference.TopMenu" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxMenu" TagPrefix="dxm" %>

    <div class="main-menu-container">
<dxm:ASPxMenu EnableTheming="False" ID="ASPxMenu1" CssClass="TabbedMenu"
    runat="server" AppearAfter="0" DataSourceID="XmlDataSource1" ItemSpacing="0px" 
    SeparatorHeight="32px" SeparatorWidth="1px" ShowSubMenuShadow="False" 
    BorderBetweenItemAndSubMenu="HideRootOnly" 
            Font-Names="Arial, Helvetica, sans-serif" Font-Size="8pt" 
    Font-Underline="False" ForeColor="Black" AutoPostBack="True" 
    SyncSelectionMode="None" EnableDefaultAppearance="False" 
    ClientInstanceName="tabbedMenu" AllowSelectItem="True" SelectParentItem="True" 
    CssFilePath="~/CSS/TabbedMenu.css" Height="32px" NavigateUrlField="LinkUrl">
     <ItemStyle CssClass="rootItem" Wrap="False">
         <BackgroundImage ImageUrl="~/Images/TabbedMenu/RootItemSeparator.gif" Repeat="NoRepeat" HorizontalPosition="right" />
         <Paddings Padding="0px" />
         <HoverStyle CssClass="rootItemHover">
         </HoverStyle>
         <SelectedStyle CssClass="rootItemSelected">
         </SelectedStyle>
     </ItemStyle>
     <Paddings Padding="0px" />
     <Border BorderStyle="None" />
     <RootItemSubMenuOffset X="-1" Y="-2" FirstItemX="-1" FirstItemY="-2" LastItemX="-1"
         LastItemY="-2" />
     <SubMenuStyle GutterWidth="0px" ItemSpacing="0px" BackColor="White" CssClass="menu">
         <Paddings Padding="1px" />
         <Border BorderColor="#919191" BorderStyle="Solid" BorderWidth="1px" />
     </SubMenuStyle>
     <SubMenuItemStyle Wrap="False">
         <HoverStyle BackColor="#EDEDED" >
             <Border BorderWidth="0px" />
         </HoverStyle>
         <Paddings Padding="5px" PaddingLeft="7px" PaddingRight="7px" />
     </SubMenuItemStyle>
     <VerticalPopOutImage Height="5px" Url="~/Images/TabbedMenu/ItemArrow.gif" Width="4px" />
     <ItemSubMenuOffset X="-1" Y="-2" FirstItemY="-3" LastItemY="-2" />
     <LinkStyle Color="Black">
         <Font Underline="False"></Font>
     </LinkStyle>
     <RootItemTextTemplate>
     <a href='<%# Eval("NavigateUrl") %>' runat="server" id="lblLink">
     <div class="dx-tm"><table cellpadding="0" cellspacing="0" border="0"><tr><th class="WhiteBorderRight">
          <dxe:ASPxLabel ID="lblText" runat="server" EnableTheming="False" EnableDefaultAppearance="False" Text='<%# Eval("Text") %>' />
         </th></tr></table></div>    
         </a>
     </RootItemTextTemplate>
     
 </dxm:ASPxMenu>
 </div>
 <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/MenuTabbedMenu.xml" XPath="/mainmenu/item" />