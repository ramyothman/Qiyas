<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SiteMenuItemsControl.ascx.cs" Inherits="SocioBuilderSite.Controls.BackendPortal.SiteMenuItemsControl" %>
<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<p>
    &nbsp;</p>

<dx:ASPxTreeList ID="mainTree" ClientInstanceName="mainTree" runat="server" 
                    AutoGenerateColumns="False" DataSourceID="SiteMenuObjectDS" 
                    KeyFieldName="MenuEntityItemId" 
    ParentFieldName="MenuEntityParentId">
                    <Columns>
                        <dx:TreeListTextColumn FieldName="IconPath" VisibleIndex="0" Caption="Icon">
                        </dx:TreeListTextColumn>
                        <dx:TreeListTextColumn FieldName="MenuEntityParentId" VisibleIndex="2" 
                            Caption="Parent Id" Visible="False">
                            <EditFormSettings Visible="False" />
                        </dx:TreeListTextColumn>
                        <dx:TreeListTextColumn FieldName="Name" VisibleIndex="1">
                        </dx:TreeListTextColumn>
                        <dx:TreeListTextColumn FieldName="PagePath" VisibleIndex="2" Visible="False">
                            <EditFormSettings Visible="True" />
                        </dx:TreeListTextColumn>
                        <dx:TreeListTextColumn FieldName="ContentEntityId" VisibleIndex="2" 
                            Visible="False">
                            <EditFormSettings Visible="True" />
                        </dx:TreeListTextColumn>
                        <dx:TreeListCheckColumn FieldName="DisplayAlways" VisibleIndex="2" 
                            Visible="False">
                            <EditFormSettings Visible="True" />
                        </dx:TreeListCheckColumn>
                        <dx:TreeListTextColumn FieldName="DisplayOrder" VisibleIndex="2">
                        </dx:TreeListTextColumn>
                        <dx:TreeListComboBoxColumn Caption="Entity Type" FieldName="MenuEntityTypeId" 
                            VisibleIndex="3">
                            <PropertiesComboBox ValueType="System.String">
                            </PropertiesComboBox>
                        </dx:TreeListComboBoxColumn>
                        <dx:TreeListTextColumn FieldName="MenuEntityId" VisibleIndex="6" Caption="Id">
                        </dx:TreeListTextColumn>
                        <dx:TreeListDateTimeColumn FieldName="ModifiedDate" VisibleIndex="4">
                            <EditFormSettings Visible="False" />
                        </dx:TreeListDateTimeColumn>
                        <dx:TreeListCheckColumn FieldName="IsActive" VisibleIndex="5">
                        </dx:TreeListCheckColumn>
                        <dx:TreeListCommandColumn VisibleIndex="7">
                            <EditButton Visible="True">
                            </EditButton>
                            <NewButton Visible="True">
                            </NewButton>
                            <DeleteButton Visible="True">
                            </DeleteButton>
                        </dx:TreeListCommandColumn>
                    </Columns>
                    <SettingsBehavior AllowFocusedNode="True" />
                    <SettingsEditing AllowNodeDragDrop="True" />
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
<asp:ObjectDataSource ID="EntityTypeObjectDS" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
    TypeName="BusinessLogicLayer.Components.ContentManagement.MenuEntityTypeLogic">
</asp:ObjectDataSource>
<p>
    &nbsp;</p>
