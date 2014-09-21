<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master" AutoEventWireup="true" CodeBehind="MediaReferences.aspx.cs" Inherits="SocioBuilderSite.Conference.MediaReferences" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<dx:ASPxGridView runat="server" AutoGenerateColumns="False" 
                    DataSourceID="MediaReferenceObjectDS" 
                    KeyFieldName="ConferenceMediaReferenceId" 
        ID="MediaReferenceGrid" >
                    <Columns>
                        
                        <dx:GridViewDataTextColumn Caption="Id" FieldName="ConferenceMediaReferenceId" 
                            ReadOnly="True" VisibleIndex="1" Visible="False">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataComboBoxColumn Caption="Conference" FieldName="ConferenceId" 
                            VisibleIndex="3" Visible="False">
                            <PropertiesComboBox DataSourceID="dsconference" TextField="ConferenceName" 
                                ValueField="ConferenceId" ValueType="System.Int32">
                            </PropertiesComboBox>
                        </dx:GridViewDataComboBoxColumn>
                        <dx:GridViewDataComboBoxColumn Caption="Language" FieldName="LanguageId" 
                            VisibleIndex="4" Visible="False">
                            <PropertiesComboBox DataSourceID="dsLang" TextField="Name" 
                                ValueField="LanguageId" ValueType="System.Int32">
                            </PropertiesComboBox>
                        </dx:GridViewDataComboBoxColumn>
                        <dx:GridViewDataTextColumn Caption="Order" FieldName="ReferenceOrder" Visible="false" 
                            VisibleIndex="2" Width="40px" SortIndex="0" SortOrder="Ascending">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Title" VisibleIndex="5" Caption='<%$Resources:ConferenceFront, MediaReference_Title %>' Width="200px">
                            <DataItemTemplate>
                                <a href='<%# Eval("ReferenceUrl").ToString() %>' target="_blank"><%# Eval("Title").ToString() %></a>
                            </DataItemTemplate>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Url" FieldName="ReferenceUrl" 
                            VisibleIndex="6" Visible="False">
                            <EditFormSettings Visible="True" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn  FieldName="ReferenceName" Caption='<%$Resources:ConferenceFront, MediaReference_Reference %>'  
                            VisibleIndex="7">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataImageColumn  FieldName="ReferenceLogo" Caption='<%$Resources:ConferenceFront, MediaReference_Logo %>' 
                            VisibleIndex="9">
                            <PropertiesImage ImageHeight="80px" 
                            ImageUrlFormatString="~/ContentData/Sites/Conferences/{0}">
                        </PropertiesImage>
                            
                        </dx:GridViewDataImageColumn>
                        <dx:GridViewDataDateColumn  FieldName="PublishingDate" Caption='<%$Resources:ConferenceFront, MediaReference_Date %>'  
                            VisibleIndex="8">
                        </dx:GridViewDataDateColumn>
                    </Columns>
                    <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                </dx:ASPxGridView>
                <asp:ObjectDataSource ID="MediaReferenceObjectDS" runat="server" 
                    DeleteMethod="Delete" InsertMethod="Insert" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.ConferenceMediaReferenceLogic" 
                    UpdateMethod="Update">
                    <DeleteParameters>
                        <asp:Parameter Name="Original_ConferenceMediaReferenceId" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="ConferenceId" Type="Int32" />
                        <asp:Parameter Name="LanguageId" Type="Int32" />
                        <asp:Parameter Name="ReferenceOrder" Type="Int32" />
                        <asp:Parameter Name="Title" Type="String" />
                        <asp:Parameter Name="ReferenceUrl" Type="String" />
                        <asp:Parameter Name="ReferenceName" Type="String" />
                        <asp:Parameter Name="ReferenceLogo" Type="String" />
                        <asp:Parameter Name="PublishingDate" Type="DateTime" />
                    </InsertParameters>
                    <SelectParameters>
                        <asp:SessionParameter DefaultValue="0" Name="ConferenceId" 
                            SessionField="ConferenceId" Type="Int32" />
                        <asp:SessionParameter DefaultValue="2" Name="LanguageId" 
                            SessionField="LanguageId" Type="Int32" />
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="ConferenceId" Type="Int32" />
                        <asp:Parameter Name="LanguageId" Type="Int32" />
                        <asp:Parameter Name="ReferenceOrder" Type="Int32" />
                        <asp:Parameter Name="Title" Type="String" />
                        <asp:Parameter Name="ReferenceUrl" Type="String" />
                        <asp:Parameter Name="ReferenceName" Type="String" />
                        <asp:Parameter Name="ReferenceLogo" Type="String" />
                        <asp:Parameter Name="PublishingDate" Type="DateTime" />
                        <asp:Parameter Name="Original_ConferenceMediaReferenceId" Type="Int32" />
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
</asp:Content>
