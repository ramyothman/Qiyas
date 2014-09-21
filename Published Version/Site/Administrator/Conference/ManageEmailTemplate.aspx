<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="ManageEmailTemplate.aspx.cs" Inherits="SocioBuilderSite.Administrator.Conference.ManageEmailTemplate" %>

<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
 <div class="g12 widgets">
			<div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
				<h3 class="handle">Manage Email Template</h3>
				<div class="inner-content">
                 <a href="SaveEditTemplate.aspx">
                                New Email Template
                                </a>
                    <dx:ASPxGridView ID="gvEmailTemplates" runat="server" 
                        AutoGenerateColumns="False" DataSourceID="dsEmailTemplates" 
                        KeyFieldName="EmailTemplateID">
                        <Columns>
                         <dx:GridViewCommandColumn ButtonType="Image" VisibleIndex="0" Width="60px" Caption=" ">
                        <DeleteButton Visible="True">
                            <Image Height="16px" Url="~/images/griddelete.png" Width="16px">
                            </Image>
                        </DeleteButton>
                    
                        <ClearFilterButton Visible="True">
                        </ClearFilterButton>
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn Caption=" " VisibleIndex="1">
                        <DataItemTemplate>
                            <a href='<%#"SaveEditTemplate.aspx?ID="+Eval("EmailTemplateID").ToString()%>'>
                                <asp:Image runat="server" ID="img" ImageUrl="~/images/editgrid.png" />
                                </a>
                        </DataItemTemplate>
                    </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="EmailTemplateID" ReadOnly="True" 
                                Visible="False" VisibleIndex="0">
                                <EditFormSettings Visible="False" />
                            </dx:GridViewDataTextColumn>
                              <dx:GridViewDataTextColumn FieldName="Name" Caption="Name" VisibleIndex="1">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataComboBoxColumn FieldName="SystemEmailTypeID" Caption="Template Type" VisibleIndex="1">
                            <PropertiesComboBox DataSourceID="dsTemplateType" TextField="Name" ValueField="SystemEmailTypeID"></PropertiesComboBox>
                            </dx:GridViewDataComboBoxColumn>
                            <dx:GridViewDataComboBoxColumn FieldName="ConferenceID" Caption="conference Name" VisibleIndex="2">
                            <PropertiesComboBox DataSourceID="dsconference" TextField="ConferenceName" ValueField="ConferenceId"></PropertiesComboBox>
                            </dx:GridViewDataComboBoxColumn>
                            <dx:GridViewDataComboBoxColumn FieldName="LanguageID" Caption="Language" VisibleIndex="3">
                            <PropertiesComboBox DataSourceID="dsLang" TextField="Name" ValueField="LanguageId"></PropertiesComboBox>
                            </dx:GridViewDataComboBoxColumn>
                          
                            <dx:GridViewDataTextColumn FieldName="Description" VisibleIndex="5" Visible="false">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="EmailContent" Visible="False" 
                                VisibleIndex="6">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataCheckColumn FieldName="NewRecord" Visible="False" 
                                VisibleIndex="7">
                            </dx:GridViewDataCheckColumn>
                        </Columns>
                         
                <SettingsBehavior AllowFocusedRow="True" ConfirmDelete="True" EnableRowHotTrack="True" />
                <SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="450px" />
                <Settings ShowFilterRow="True" />
                <SettingsText ConfirmDelete="Are you sure you want to delete this record?" />
               
                    </dx:ASPxGridView>

                    <asp:ObjectDataSource ID="dsTemplateType" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.Conference.SystemEmailTypeLogic">
                    </asp:ObjectDataSource>

                    <asp:ObjectDataSource ID="dsEmailTemplates" runat="server" 
                        DeleteMethod="Delete" InsertMethod="Insert" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.Conference.EmailTemplateLogic" 
                        UpdateMethod="Update">
                        <DeleteParameters>
                            <asp:Parameter Name="Original_EmailTemplateID" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="SystemEmailTypeID" Type="Int32" />
                            <asp:Parameter Name="ConferenceID" Type="Int32" />
                            <asp:Parameter Name="LanguageID" Type="Int32" />
                            <asp:Parameter Name="Name" Type="String" />
                            <asp:Parameter Name="Description" Type="String" />
                            <asp:Parameter Name="EmailContent" Type="String" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="SystemEmailTypeID" Type="Int32" />
                            <asp:Parameter Name="ConferenceID" Type="Int32" />
                            <asp:Parameter Name="LanguageID" Type="Int32" />
                            <asp:Parameter Name="Name" Type="String" />
                            <asp:Parameter Name="Description" Type="String" />
                            <asp:Parameter Name="EmailContent" Type="String" />
                            <asp:Parameter Name="Original_EmailTemplateID" Type="Int32" />
                        </UpdateParameters>
                    </asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="dsconference" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.Conference.ConferencesLogic">
                    </asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="dsLang" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.ContentManagement.LanguageLogic">
                    </asp:ObjectDataSource>
                </div>
                </div>
                </div>
</asp:Content>
