<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master"
    AutoEventWireup="true" CodeBehind="ManageSpeakers.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.Conference.ManageSpeakers" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxUploadControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxSpellChecker.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxSpellChecker" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
     <div class="g12 widgets">
			<div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
				<h3 class="handle">Manage Speakers </h3>
				<div class="inner-content">
        <asp:HyperLink ID="hlNewSpeaker" runat="server" Text="New Speaker" NavigateUrl="SaveSpeakers.aspx"></asp:HyperLink>
        
            <dx:ASPxGridView ID="SpeakersGrid" ClientInstanceName="SpeakersGrid" runat="server"
                AutoGenerateColumns="False" DataSourceID="SpeakersObjectDS" KeyFieldName="ConferenceSpeakerId">
                <Columns>
                    <dx:GridViewCommandColumn VisibleIndex="0" Caption=" ">
                       <DeleteButton Visible="True">
                            <Image Height="16px" Url="~/images/griddelete.png" Width="16px">
                            </Image>
                        </DeleteButton>                    
                        <ClearFilterButton Visible="True">
                        </ClearFilterButton>
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn Caption=" " VisibleIndex="1">
                        <DataItemTemplate>
                            <asp:HyperLink ID="hlEdit" runat="server" NavigateUrl='<%#"SaveSpeakers.aspx?ID="+Eval("ConferenceSpeakerId").ToString()%>'
                                Text="Edit"></asp:HyperLink>
                        </DataItemTemplate>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ConferenceSpeakerId" VisibleIndex="1" Caption="Id"
                        ReadOnly="True" Visible="false">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Conference" FieldName="ConferenceId" VisibleIndex="2">
                        <PropertiesComboBox DataSourceID="ConferenceObjectDS" TextField="ConferenceName"
                            ValueField="ConferenceId" ValueType="System.Int32">
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Speaker Name" FieldName="PersonId" VisibleIndex="3">
                        <PropertiesComboBox DataSourceID="PersonObjectDS" TextField="DisplayName" ValueField="BusinessEntityId"
                            ValueType="System.Int32" IncrementalFilteringMode="Contains">
                        </PropertiesComboBox>
                        <EditFormSettings ColumnSpan="2" />
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataDateColumn FieldName="DateRegistered" VisibleIndex="4" Caption="Registeration Date">
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataTextColumn Caption="Position" FieldName="SpeakerPosition" VisibleIndex="5">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Bio" FieldName="SpeakerBio" VisibleIndex="6">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Photo" FieldName="SpeakerImage" VisibleIndex="7">
                        <DataItemTemplate>
                            <asp:Image ID="SpeakerImage" runat="server" Width="100" ImageUrl='<%# "~/ContentData/Sites/Conferences/" + Eval("SpeakerImage")%>'
                                Visible='<%#Eval("SpeakerImage")!=null?true:false %>' />
                        </DataItemTemplate>
                    </dx:GridViewDataTextColumn>
                </Columns>
                <SettingsDetail AllowOnlyOneMasterRowExpanded="True" ShowDetailRow="True" />
                <SettingsBehavior ConfirmDelete="True" />
                <Settings ShowFilterRow="True" />
                <SettingsText ConfirmDelete="Are you sure you want to delete this record?" />
                <Templates>
                    <DetailRow>
                     <asp:HyperLink ID="hlNewSpeaker" runat="server" Text="New Speaker" NavigateUrl='<%#"SaveARSpeakers.aspx?ParentID="+ Eval("ConferenceSpeakerId").ToString()%>'></asp:HyperLink>
                        <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" 
                            DataSourceID="dsSpeakerlang" KeyFieldName="ConferenceSpeakerId" OnBeforePerformDataSelect="ASPxGridView1_BeforePerformDataSelect">
                    <Columns>
                    <dx:GridViewCommandColumn VisibleIndex="0" Caption=" ">
                         <DeleteButton Visible="True">
                            <Image Height="16px" Url="~/images/griddelete.png" Width="16px">
                            </Image>
                        </DeleteButton>                    
                        <ClearFilterButton Visible="True">
                        </ClearFilterButton>
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn Caption=" " VisibleIndex="1">
                        <DataItemTemplate>
                            <asp:HyperLink ID="hlEdit" runat="server" NavigateUrl='<%#"SaveARSpeakers.aspx?ID="+Eval("ConferenceSpeakerId").ToString()+"&ParentID="+ Session["ParentID"].ToString()%>'
                                Text="Edit"></asp:HyperLink>
                        </DataItemTemplate>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ConferenceSpeakerId" VisibleIndex="1" Caption="Id"
                        ReadOnly="True" Visible="false">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Conference" FieldName="ConferenceId" VisibleIndex="2" Visible="false">
                        <PropertiesComboBox DataSourceID="ConferenceObjectDS" TextField="ConferenceName"
                            ValueField="ConferenceId" ValueType="System.Int32">
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataTextColumn Caption="Speaker Name" FieldName="SpeakerName" VisibleIndex="3">
                        
                        <EditFormSettings ColumnSpan="2" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn FieldName="DateRegistered" VisibleIndex="4" Caption="Registeration Date" Visible="false">
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataTextColumn Caption="Position" FieldName="SpeakerPosition" VisibleIndex="5">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Bio" FieldName="SpeakerBio" VisibleIndex="6">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Photo" FieldName="SpeakerImage" VisibleIndex="7" Visible="false">
                        <DataItemTemplate>
                            <asp:Image ID="SpeakerImage" runat="server" Width="100" ImageUrl='<%# "~/ContentData/Sites/Conferences/" + Eval("SpeakerImage")%>'
                                Visible='<%#Eval("SpeakerImage")!=null?true:false %>' />
                        </DataItemTemplate>
                    </dx:GridViewDataTextColumn>
                                <dx:GridViewDataComboBoxColumn Caption="Language" FieldName="LanguageID" 
                        VisibleIndex="22">
                        <PropertiesComboBox DataSourceID="dsLanguages" TextField="Name" ValueField="LanguageId"></PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                                <dx:GridViewDataTextColumn FieldName="ConferenceSpeakerParentId" 
                                    VisibleIndex="22" Visible="false">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataCheckColumn FieldName="NewRecord" VisibleIndex="23" Visible="false">
                                </dx:GridViewDataCheckColumn>
                            </Columns>
                             <SettingsBehavior ConfirmDelete="True" />
                <Settings ShowFilterRow="True" />
                <SettingsText ConfirmDelete="Are you sure you want to delete this record?" />
                        </dx:ASPxGridView>
                         <asp:ObjectDataSource ID="dsLanguages" runat="server" 
                OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                TypeName="BusinessLogicLayer.Components.ContentManagement.LanguageLogic">
            </asp:ObjectDataSource>
                        <asp:ObjectDataSource ID="dsSpeakerlang" runat="server" DeleteMethod="Delete" 
                            InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
                            SelectMethod="GetAll" 
                            TypeName="BusinessLogicLayer.Components.Conference.ConferenceSpeakersLanguageLogic" 
                            UpdateMethod="Update">
                            <DeleteParameters>
                                <asp:Parameter Name="Original_ConferenceSpeakerId" Type="Int32" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="PersonId" Type="Int32" />
                                <asp:Parameter Name="ConferenceId" Type="Int32" />
                                <asp:Parameter Name="DateRegistered" Type="DateTime" />
                                <asp:Parameter Name="SpeakerImage" Type="String" />
                                <asp:Parameter Name="SpeakerPosition" Type="String" />
                                <asp:Parameter Name="SpeakerBio" Type="String" />
                                <asp:Parameter Name="FlightfromCountry" Type="String" />
                                <asp:Parameter Name="FlightFromCity" Type="String" />
                                <asp:Parameter Name="FlightToCountry" Type="String" />
                                <asp:Parameter Name="FlightToCity" Type="String" />
                                <asp:Parameter Name="FlightNO" Type="String" />
                                <asp:Parameter Name="ArrivalDate" Type="DateTime" />
                                <asp:Parameter Name="ArrivalTime" Type="String" />
                                <asp:Parameter Name="DepratureDate" Type="DateTime" />
                                <asp:Parameter Name="DepratureTime" Type="String" />
                                <asp:Parameter Name="AirllineID" Type="Int32" />
                                <asp:Parameter Name="HotelID" Type="Int32" />
                                <asp:Parameter Name="ResponsiblePersonID" Type="Int32" />
                                <asp:Parameter Name="ArrivalTimeAMorPM" Type="String" />
                                <asp:Parameter Name="DepratureTimeAMorPM" Type="String" />
                                <asp:Parameter Name="LanguageID" Type="Int32" />
                                 <asp:SessionParameter Name="ConferenceSpeakerParentId" SessionField="ParentID" Type="Int32" />
                            </InsertParameters>
                            <SelectParameters>
                                <asp:SessionParameter Name="ParentID" SessionField="ParentID" Type="Int32" />
                            </SelectParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="PersonId" Type="Int32" />
                                <asp:Parameter Name="ConferenceId" Type="Int32" />
                                <asp:Parameter Name="DateRegistered" Type="DateTime" />
                                <asp:Parameter Name="SpeakerImage" Type="String" />
                                <asp:Parameter Name="SpeakerPosition" Type="String" />
                                <asp:Parameter Name="SpeakerBio" Type="String" />
                                <asp:Parameter Name="FlightfromCountry" Type="String" />
                                <asp:Parameter Name="FlightFromCity" Type="String" />
                                <asp:Parameter Name="FlightToCountry" Type="String" />
                                <asp:Parameter Name="FlightToCity" Type="String" />
                                <asp:Parameter Name="FlightNO" Type="String" />
                                <asp:Parameter Name="ArrivalDate" Type="DateTime" />
                                <asp:Parameter Name="ArrivalTime" Type="String" />
                                <asp:Parameter Name="DepratureDate" Type="DateTime" />
                                <asp:Parameter Name="DepratureTime" Type="String" />
                                <asp:Parameter Name="AirllineID" Type="Int32" />
                                <asp:Parameter Name="HotelID" Type="Int32" />
                                <asp:Parameter Name="ResponsiblePersonID" Type="Int32" />
                                <asp:Parameter Name="ArrivalTimeAMorPM" Type="String" />
                                <asp:Parameter Name="DepratureTimeAMorPM" Type="String" />
                                <asp:Parameter Name="LanguageID" Type="Int32" />
                                <asp:SessionParameter Name="ConferenceSpeakerParentId" SessionField="ParentID" Type="Int32" />
                                <asp:Parameter Name="Original_ConferenceSpeakerId" Type="Int32" />
                            </UpdateParameters>
                        </asp:ObjectDataSource>
                    </DetailRow>
                </Templates>
            </dx:ASPxGridView>
            </div>
            <asp:ObjectDataSource ID="SpeakersObjectDS" runat="server" DeleteMethod="Delete"
                OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.Conference.ConferenceSpeakersLogic">
                <DeleteParameters>
                    <asp:Parameter Name="Original_ConferenceSpeakerId" Type="Int32" />
                </DeleteParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ConferenceObjectDS" runat="server" OldValuesParameterFormatString="original_{0}"
                SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.Conference.ConferencesLogic">
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="PersonObjectDS" runat="server" OldValuesParameterFormatString="original_{0}"
                SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.Persons.PersonLogic">
            </asp:ObjectDataSource>
            <br />
        </div>
    </div>
</asp:Content>

