﻿<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master"
    AutoEventWireup="true" CodeBehind="ManageTransportationType.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.Conference.ManageTransportationType" %>

<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxUploadControl" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
     <div class="g12 widgets">
			<div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
				<h3 class="handle">Manage Transportation Type </h3>
				<div class="inner-content">
            <dx:ASPxGridView ID="TransportationTypeGrid" runat="server" AutoGenerateColumns="False"
                KeyFieldName="ID" Width="50%" DataSourceID="DSTransportationType">
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
                    <dx:GridViewDataTextColumn FieldName="ID" ReadOnly="True" Visible="False" VisibleIndex="0">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="TypeName" VisibleIndex="1">
                        <PropertiesTextEdit>
                            <ValidationSettings>
                                <RequiredField IsRequired="True" />
                            </ValidationSettings>
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataCheckColumn FieldName="NewRecord" Visible="False" VisibleIndex="2">
                    </dx:GridViewDataCheckColumn>
                </Columns>
                <SettingsDetail AllowOnlyOneMasterRowExpanded="True" ShowDetailRow="True" />
                <SettingsBehavior AllowFocusedRow="True" ConfirmDelete="True" EnableRowHotTrack="True" />
                <SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="450px" />
                <Settings ShowFilterRow="True" />
                <SettingsText ConfirmDelete="Are you sure you want to delete this record?" />
                <Templates>
                    <DetailRow>
                        <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" 
                            DataSourceID="dsTransLang" KeyFieldName="ID" OnBeforePerformDataSelect="ASPxGridView1_BeforePerformDataSelect">
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
                    <dx:GridViewDataTextColumn FieldName="ID" ReadOnly="True" Visible="False" VisibleIndex="0">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="TypeName" VisibleIndex="1">
                        <PropertiesTextEdit>
                            <ValidationSettings>
                                <RequiredField IsRequired="True" />
                            </ValidationSettings>
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataCheckColumn FieldName="NewRecord" Visible="False" VisibleIndex="2">
                    </dx:GridViewDataCheckColumn>
                       <dx:GridViewDataComboBoxColumn Caption="Language" FieldName="LanguageID" 
                        VisibleIndex="22">
                        <PropertiesComboBox DataSourceID="dsLanguages" TextField="Name" ValueField="LanguageId"></PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                                <dx:GridViewDataTextColumn FieldName="ParentID" VisibleIndex="3" Visible="false">
                                </dx:GridViewDataTextColumn>
                                
                </Columns>
                <SettingsBehavior AllowFocusedRow="True" ConfirmDelete="True" EnableRowHotTrack="True" />
                <SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="450px" />
                <Settings ShowFilterRow="True" />
                <SettingsText ConfirmDelete="Are you sure you want to delete this record?" />
                               
                            
                        </dx:ASPxGridView>
                        <asp:ObjectDataSource ID="dsTransLang" runat="server" DeleteMethod="Delete" 
                            InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
                            SelectMethod="GetAll" 
                            TypeName="BusinessLogicLayer.Components.Conference.TransportationTypeLanguageLogic" 
                            UpdateMethod="Update">
                            <DeleteParameters>
                                <asp:Parameter Name="Original_ID" Type="Int32" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="TypeName" Type="String" />
                                <asp:Parameter Name="LanguageID" Type="Int32" />
                                <asp:SessionParameter Name="ParentID" SessionField="ParentID" Type="Int32" />
                            </InsertParameters>
                            <SelectParameters>
                                <asp:SessionParameter Name="ParentID" SessionField="ParentID" Type="Int32" />
                            </SelectParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="TypeName" Type="String" />
                                <asp:Parameter Name="LanguageID" Type="Int32" />
                                 <asp:SessionParameter Name="ParentID" SessionField="ParentID" Type="Int32" />
                                <asp:Parameter Name="Original_ID" Type="Int32" />
                            </UpdateParameters>
                        </asp:ObjectDataSource>
                    </DetailRow>
                </Templates>
            </dx:ASPxGridView>
          </div>
             <asp:ObjectDataSource ID="dsLanguages" runat="server" 
                OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                TypeName="BusinessLogicLayer.Components.ContentManagement.LanguageLogic">
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="DSTransportationType" runat="server" DeleteMethod="Delete"
                InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll"
                TypeName="BusinessLogicLayer.Components.Conference.TransportationTypeLogic" UpdateMethod="Update">
                <DeleteParameters>
                    <asp:Parameter Name="Original_ID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="TypeName" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="TypeName" Type="String" />
                    <asp:Parameter Name="Original_ID" Type="Int32" />
                </UpdateParameters>
            </asp:ObjectDataSource>
            <br />
        </div>
    </div>
</asp:Content>
