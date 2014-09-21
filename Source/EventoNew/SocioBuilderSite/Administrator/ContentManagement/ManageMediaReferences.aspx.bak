<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="ManageMediaReferences.aspx.cs" Inherits="SocioBuilderSite.Administrator.ContentManagement.ManageMediaReferences" %>


<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxUploadControl" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript">
    function Uploader_OnUploadComplete(args) {
        if (args.isValid) {
            //            txtImageUploadPath.SetText(args.callbackData);
            lblIconPath.SetText(args.callbackData);
        }
    }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <div class="g12 widgets">
        <div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
            <h3 class="handle">
                Manage Media References</h3>
            <div class="inner-content">
                <dx:ASPxGridView runat="server" AutoGenerateColumns="False" 
                    DataSourceID="MediaReferenceObjectDS" 
                    KeyFieldName="ConferenceMediaReferenceId" ID="MediaReferenceGrid" 
                    onrowinserting="ConferenceGrid_RowInserting" 
                    onrowupdating="ConferenceGrid_RowUpdating" 
                    onstartrowediting="ConferenceGrid_StartRowEditing">
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
                        <dx:GridViewDataTextColumn Caption="Id" FieldName="ConferenceMediaReferenceId" 
                            ReadOnly="True" VisibleIndex="1" Visible="False">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataComboBoxColumn Caption="Conference" FieldName="ConferenceId" 
                            VisibleIndex="3">
                            <PropertiesComboBox DataSourceID="dsconference" TextField="ConferenceName" 
                                ValueField="ConferenceId" ValueType="System.Int32">
                            </PropertiesComboBox>
                        </dx:GridViewDataComboBoxColumn>
                        <dx:GridViewDataComboBoxColumn Caption="Language" FieldName="LanguageId" 
                            VisibleIndex="4">
                            <PropertiesComboBox DataSourceID="dsLang" TextField="Name" 
                                ValueField="LanguageId" ValueType="System.Int32">
                            </PropertiesComboBox>
                        </dx:GridViewDataComboBoxColumn>
                        <dx:GridViewDataTextColumn Caption="Order" FieldName="ReferenceOrder" 
                            VisibleIndex="2" Width="40px">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Title" VisibleIndex="5">
                            <DataItemTemplate>
                                <a href='<%# Eval("ReferenceUrl").ToString() %>' target="_blank"><%# Eval("Title").ToString() %></a>
                            </DataItemTemplate>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Url" FieldName="ReferenceUrl" 
                            VisibleIndex="6" Visible="False">
                            <EditFormSettings Visible="True" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Reference" FieldName="ReferenceName" 
                            VisibleIndex="7">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataImageColumn Caption="Logo" FieldName="ReferenceLogo" 
                            VisibleIndex="9">
                            <PropertiesImage ImageHeight="80px" 
                            ImageUrlFormatString="~/ContentData/Sites/Conferences/{0}">
                        </PropertiesImage>
                            <EditItemTemplate>
                            <dx:ASPxUploadControl ID="conferenceLogoUpload" 
                                ClientInstanceName="conferenceLogoUpload" runat="server" 
                                ShowProgressPanel="True" ShowUploadButton="True" 
                                onfileuploadcomplete="conferenceLogoUpload_FileUploadComplete">
                                 <ClientSideEvents FileUploadComplete="function(s, e) {
	Uploader_OnUploadComplete(e);
}" />
<ValidationSettings AllowedFileExtensions=".jpg,.jpeg,.jpe,.gif,.png">
                                            </ValidationSettings>
                            </dx:ASPxUploadControl>
                            <dx:ASPxLabel ID="lblIconPath" runat="server" 
                        ClientInstanceName="lblIconPath">
                    </dx:ASPxLabel>
                        </EditItemTemplate>
                        </dx:GridViewDataImageColumn>
                        <dx:GridViewDataDateColumn Caption="Date" FieldName="PublishingDate" 
                            VisibleIndex="8">
                        </dx:GridViewDataDateColumn>
                    </Columns>
                    <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                    <Settings ShowFilterRow="True" ShowGroupPanel="True" />
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
            </div>
        </div>
    </div>
</asp:Content>
