<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdministrationMaster.Master" AutoEventWireup="true" CodeBehind="ManageSiteMenu.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.ContentManagement.ManageSiteMenu" %>

<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MessagePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainPlaceHolder" runat="server">
<div class="portlet ui-widget ui-widget-content ui-helper-clearfix ui-corner-all form-container">
            <div class="portlet-header ui-widget-header">
                <table>
                    <tr>
                        <td><img runat="server" id="Img1" src="~/images/SiteMenu.png" height="16" width="16" alt="" /></td>
                        <td style="font-size:12px;">Manage Site Menu</td>
                    </tr>
                </table>
            </div>
            <div class="portlet-content">
                <dx:ASPxTreeList ID="mainTree" ClientInstanceName="mainTree" runat="server" 
                    AutoGenerateColumns="False" DataSourceID="SiteMenuObjectDS" 
                    KeyFieldName="MenuEntityItemId">
                    <Columns>
                        <dx:TreeListTextColumn FieldName="MenuEntityParentId" VisibleIndex="0">
                        </dx:TreeListTextColumn>
                        <dx:TreeListTextColumn FieldName="Name" VisibleIndex="1">
                        </dx:TreeListTextColumn>
                        <dx:TreeListTextColumn FieldName="PagePath" VisibleIndex="2">
                        </dx:TreeListTextColumn>
                        <dx:TreeListTextColumn FieldName="ContentEntityId" VisibleIndex="3">
                        </dx:TreeListTextColumn>
                        <dx:TreeListCheckColumn FieldName="DisplayAlways" VisibleIndex="4">
                        </dx:TreeListCheckColumn>
                        <dx:TreeListCheckColumn FieldName="IsActive" VisibleIndex="5">
                        </dx:TreeListCheckColumn>
                        <dx:TreeListTextColumn FieldName="IconPath" VisibleIndex="6">
                        </dx:TreeListTextColumn>
                        <dx:TreeListTextColumn FieldName="DisplayOrder" VisibleIndex="7">
                        </dx:TreeListTextColumn>
                        <dx:TreeListDateTimeColumn FieldName="ModifiedDate" VisibleIndex="8">
                        </dx:TreeListDateTimeColumn>
                        <dx:TreeListTextColumn FieldName="MenuEntityTypeId" VisibleIndex="9">
                        </dx:TreeListTextColumn>
                        <dx:TreeListTextColumn FieldName="MenuEntityId" VisibleIndex="10">
                        </dx:TreeListTextColumn>
                        <dx:TreeListCheckColumn FieldName="NewRecord" VisibleIndex="11">
                        </dx:TreeListCheckColumn>
                    </Columns>
                </dx:ASPxTreeList>
                <asp:ObjectDataSource ID="SiteMenuObjectDS" runat="server" 
                    DeleteMethod="Delete" InsertMethod="Insert" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.MenuEntityItemLogic" 
                    UpdateMethod="Update">
                    <DeleteParameters>
                        <asp:Parameter Name="Original_MenuEntityItemId" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="MenuEntityParentId" Type="Int32" />
                        <asp:Parameter Name="Name" Type="String" />
                        <asp:Parameter Name="PagePath" Type="String" />
                        <asp:Parameter Name="ContentEntityId" Type="Int32" />
                        <asp:Parameter Name="DisplayAlways" Type="Boolean" />
                        <asp:Parameter Name="IsActive" Type="Boolean" />
                        <asp:Parameter Name="IconPath" Type="String" />
                        <asp:Parameter Name="DisplayOrder" Type="Int32" />
                        <asp:Parameter Name="ModifiedDate" Type="DateTime" />
                        <asp:Parameter Name="MenuEntityTypeId" Type="Int32" />
                        <asp:Parameter Name="MenuEntityId" Type="Int32" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="MenuEntityParentId" Type="Int32" />
                        <asp:Parameter Name="Name" Type="String" />
                        <asp:Parameter Name="PagePath" Type="String" />
                        <asp:Parameter Name="ContentEntityId" Type="Int32" />
                        <asp:Parameter Name="DisplayAlways" Type="Boolean" />
                        <asp:Parameter Name="IsActive" Type="Boolean" />
                        <asp:Parameter Name="IconPath" Type="String" />
                        <asp:Parameter Name="DisplayOrder" Type="Int32" />
                        <asp:Parameter Name="ModifiedDate" Type="DateTime" />
                        <asp:Parameter Name="MenuEntityTypeId" Type="Int32" />
                        <asp:Parameter Name="MenuEntityId" Type="Int32" />
                        <asp:Parameter Name="Original_MenuEntityItemId" Type="Int32" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
            </div>
</div>
            
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="DashBoardContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="LeftSideBar" runat="server">
<div class="portlet ui-widget ui-widget-content ui-helper-clearfix ui-corner-all form-container">
            <div class="portlet-header ui-widget-header">
                Site Menu</div>
            <div class="portlet-content">
                <table>
                    <tr>
                        <td><a href="javascript:void(0);" onclick="mainTree.StartEditNewNode();">
                        <img runat="server" id="newFolderImage" src="~/images/SiteMenuAdd.png" height="48" width="48" alt="Add Menu Item" />
                        </a></td>
                    </tr>
                    <tr>
                        <td><a href="javascript:void(0);" onclick="mainTree.StartEditNewNode();" style="font-weight:bold;">Add New</a></td>
                    </tr>
                </table>
                
                <div class="clearfix"></div>
       
            
            </div>
        </div>
</asp:Content>
