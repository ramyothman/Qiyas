<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="RegistrationDetails.aspx.cs" Inherits="SocioBuilderSite.Administrator.Conference.RegistrationDetails" %>

<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1.Export, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView.Export" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <div class="g12 widgets">
			<div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
				<h3 class="handle">Registrations Details

                    <span style="float:right;margin-right:5px;margin-left:5px;">
                    <dx:ASPxButton ID="btnDownloadList" runat="server" Text="Download List" 
                        onclick="btnDownloadList_Click" >
                    </dx:ASPxButton>
                </span>
				</h3>
				<div class="inner-content">
                     <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="RegistrationDetailsObjectDS" KeyFieldName="ConferenceRegistrationItemID" 
                        >
                         <Columns>
                             <dx:GridViewCommandColumn VisibleIndex="0">
                                 <DeleteButton Visible="True">
                                 </DeleteButton>
                                 <ClearFilterButton Visible="True">
                                 </ClearFilterButton>
                             </dx:GridViewCommandColumn>
                             <dx:GridViewDataTextColumn Caption="Name" FieldName="Name" VisibleIndex="3">
                             </dx:GridViewDataTextColumn>
                             <dx:GridViewDataTextColumn Caption="Mobile" FieldName="Mobile" VisibleIndex="3">
                             </dx:GridViewDataTextColumn>
                             <dx:GridViewDataTextColumn Caption="Email" FieldName="Email" VisibleIndex="3">
                             </dx:GridViewDataTextColumn>
                             <dx:GridViewDataTextColumn Caption="Id" FieldName="ConferenceRegistrationItemID" ReadOnly="True" VisibleIndex="1">
                                 <EditFormSettings Visible="False" />
                             </dx:GridViewDataTextColumn>
                             <dx:GridViewDataComboBoxColumn Caption="Type" FieldName="ConferenceRegistrationTypeID" VisibleIndex="2">
                                 <PropertiesComboBox DataSourceID="ObjectDSType" TextField="Name" ValueField="ConferenceRegistrationTypeId" ValueType="System.Int32">
                                 </PropertiesComboBox>
                             </dx:GridViewDataComboBoxColumn>
                             <dx:GridViewDataTextColumn Caption="Registrer ID" FieldName="ConferenceRegistererId" VisibleIndex="4">
                             </dx:GridViewDataTextColumn>
                             <dx:GridViewDataDateColumn FieldName="CreatedDate" VisibleIndex="5">
                             </dx:GridViewDataDateColumn>
                         </Columns>
                         <SettingsBehavior ConfirmDelete="True" />
                         <SettingsPager PageSize="50">
                         </SettingsPager>
                         <Settings ShowFilterRow="True" ShowGroupPanel="True" />
                         <SettingsText ConfirmDelete="Are you sure you want to delete this record?" />
                         </dx:ASPxGridView>
                     <asp:ObjectDataSource ID="RegistrationDetailsObjectDS" runat="server" DeleteMethod="Delete" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.Conference.ConferenceRegistrationItemsLogic">
                         <DeleteParameters>
                             <asp:Parameter Name="Original_ConferenceRegistrationItemID" Type="Int32" />
                         </DeleteParameters>
                     </asp:ObjectDataSource>
                     <asp:ObjectDataSource ID="ObjectDSType" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.Conference.ConferenceRegistrationTypeLogic"></asp:ObjectDataSource>
                      <dx:ASPxGridViewExporter ID="ASPxGridViewExporter1" runat="server" 
        GridViewID="ASPxGridView1">
    </dx:ASPxGridViewExporter>
 </div>
                </div>
        </div>
</asp:Content>
