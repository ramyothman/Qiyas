<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="ManageMenuLanguage.aspx.cs" Inherits="SocioBuilderSite.Administrator.ContentManagement.ManageMenuLanguage" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
  <div class="g12 widgets">
  <div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
				<h3 class="handle">Manage Site Menus</h3>
				<div class="inner-content">
                    <dx:ASPxGridView ID="gvMenus" runat="server" 
                        AutoGenerateColumns="False" DataSourceID="dsMenu" 
                        KeyFieldName="MenuEntityItemId">
                        <Columns>
                            <dx:GridViewDataTextColumn FieldName="MenuEntityItemId" ReadOnly="True" 
                                Visible="False" VisibleIndex="0">
                                <EditFormSettings Visible="False" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="MenuEntityParentId" Visible="False" 
                                VisibleIndex="1">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="Name" VisibleIndex="2">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="PagePath" VisibleIndex="3">
                            </dx:GridViewDataTextColumn>
                        </Columns>
                        <SettingsDetail AllowOnlyOneMasterRowExpanded="True" ShowDetailRow="True" />           
                <SettingsBehavior AllowFocusedRow="True" ConfirmDelete="True" 
                    EnableRowHotTrack="True" />
                <SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="450px" />
                <Settings ShowFilterRow="True" />
                        <Templates>
                            <DetailRow>
                                <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" 
                                    DataSourceID="dsMenuLanguage" KeyFieldName="MenuEntityItemId" OnBeforePerformDataSelect="ASPxGridView1_BeforePerformDataSelect">
                                    <Columns>
                                      <dx:GridViewCommandColumn ButtonType="Image" VisibleIndex="0" Width="60px" Caption=" ">
                        <DeleteButton Visible="True">
                            <Image Height="16px" Url="~/images/griddelete.png" Width="16px">
                            </Image>
                        </DeleteButton>
                        <EditButton Visible="True">
                            <Image Height="16px" Url="~/images/editgrid.png" Width="16px">
                            </Image>
                        </EditButton>
                        <NewButton Visible="True">
                            <Image Height="16px" Url="~/images/newgrid.png" Width="16px">
                            </Image>
                        </NewButton>
                        <CancelButton>
                            <Image Height="32px" Url="~/images/cancelsave32.png" Width="32px">
                            </Image>
                        </CancelButton>
                        <UpdateButton>
                            <Image Height="32px" Url="~/images/filesave32.png" Width="32px">
                            </Image>
                        </UpdateButton>
                        <ClearFilterButton Visible="True">
                        </ClearFilterButton>
                    </dx:GridViewCommandColumn>
                                        <dx:GridViewDataTextColumn FieldName="MenuEntityItemId" ReadOnly="True" 
                                            Visible="False" VisibleIndex="0">
                                            <EditFormSettings Visible="False" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="Name" VisibleIndex="1">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataComboBoxColumn Caption="Language" FieldName="LanguageID" 
                        VisibleIndex="22">
                        <PropertiesComboBox DataSourceID="dsLanguages" TextField="Name" ValueField="LanguageId"></PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                                    </Columns>
                                     <SettingsBehavior AllowFocusedRow="True" ConfirmDelete="True" 
                    EnableRowHotTrack="True" />
                <SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="450px" />
                <Settings ShowFilterRow="True" />
                <SettingsText ConfirmDelete="Are you sure you want to delete this record?" /> 
                                </dx:ASPxGridView>
                                  <asp:ObjectDataSource ID="dsLanguages" runat="server" 
                OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                TypeName="BusinessLogicLayer.Components.ContentManagement.LanguageLogic">
            </asp:ObjectDataSource> 
                                <asp:ObjectDataSource ID="dsMenuLanguage" runat="server" DeleteMethod="Delete" 
                                    InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
                                    SelectMethod="GetAll" 
                                    TypeName="BusinessLogicLayer.Components.ContentManagement.MenuEntityItemLanguageLogic" 
                                    UpdateMethod="Update">
                                    <DeleteParameters>
                                        <asp:Parameter Name="Original_MenuEntityItemId" Type="Int32" />
                                    </DeleteParameters>
                                    <InsertParameters>
                                        <asp:Parameter Name="Name" Type="String" />
                                        <asp:Parameter Name="LanguageID" Type="Int32" />
                                         <asp:SessionParameter Name="ParentId" SessionField="ParentID" Type="Int32" />
                                    </InsertParameters>
                                    <SelectParameters>
                                        <asp:SessionParameter Name="ParentID" SessionField="ParentID" Type="Int32" />
                                    </SelectParameters>
                                    <UpdateParameters>
                                        <asp:Parameter Name="Name" Type="String" />
                                        <asp:Parameter Name="LanguageID" Type="Int32" />
                                        <asp:SessionParameter Name="ParentId" SessionField="ParentID" Type="Int32" />
                                        <asp:Parameter Name="Original_MenuEntityItemId" Type="Int32" />
                                    </UpdateParameters>
                                </asp:ObjectDataSource>
                            </DetailRow>
                        </Templates>
                    </dx:ASPxGridView>

                    <asp:ObjectDataSource ID="dsMenu" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.ContentManagement.MenuEntityItemLogic">
                    </asp:ObjectDataSource>

                </div>
                </div>
  </div>
</asp:Content>
