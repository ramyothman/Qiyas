﻿<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="ManageAbstracts.aspx.cs" Inherits="SocioBuilderSite.Administrator.Conference.Abstracts.ManageAbstracts" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxTabControl" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxClasses" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxCallbackPanel" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView.Export" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <div class="g12 widgets">
			<div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
				<h3 class="handle">Manage Abstracts
                <span style="float:right;margin-right:5px;margin-left:5px;">
                    <dx:ASPxButton ID="btnDelete" runat="server" Text="Delete" AutoPostBack="False">
                        <ClientSideEvents Click="function(s, e) {
	if(confirm('Are you sure you want to delete those abstracts?'))
		gridAbstracts.PerformCallback('');
}" />
                        <Image Height="12px" Url="~/images/griddelete.png">
                        </Image>
                    </dx:ASPxButton>
                </span>
                <span style="float:right;margin-right:5px;margin-left:5px;">
                    <dx:ASPxButton ID="btnDownloadList" runat="server" Text="Download List" 
                        onclick="btnDownloadList_Click" >
                    </dx:ASPxButton>
                </span>
                <span style="float:right;margin-right:5px;margin-left:5px;">
                    <dx:ASPxButton ID="btnReviewers" runat="server" Text="Assign to Reviewers" 
                        AutoPostBack="False">
                        <ClientSideEvents Click="function(s, e) {
	popReviewers.Show();
}" />
                        <Image Url="~/images/reviewers.jpg">
                        </Image>
                    </dx:ASPxButton>
                </span>
                </h3>
				<div class="inner-content">
                    <dx:ASPxGridView ID="gridAbstracts" runat="server" AutoGenerateColumns="False" 
                        DataSourceID="AbstractsObjectDS" KeyFieldName="AbstractId" 
                        oncustomcallback="gridAbstracts_CustomCallback" 
                        PreviewFieldName="Conclusions" ClientInstanceName="gridAbstracts">
                        <Columns>
                            <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0">
                                <DeleteButton>
                                    <Image AlternateText="Delete" Height="16px" ToolTip="Delete" 
                                        Url="~/images/deletegrid.png" Width="16px">
                                    </Image>
                                </DeleteButton>
                                <CancelButton Text="Cancel">
                                </CancelButton>
                                <ClearFilterButton Text="Clear" Visible="True">
                                    <Image AlternateText="Clear">
                                    </Image>
                                </ClearFilterButton>
                            </dx:GridViewCommandColumn>
                            <dx:GridViewDataTextColumn FieldName="AbstractId" ReadOnly="True" 
                                VisibleIndex="1" Visible="False">
                                <EditFormSettings Visible="False" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="ABCode" ReadOnly="True" VisibleIndex="2">
                                <Settings AutoFilterCondition="Contains" />
                                <DataItemTemplate>
                                    <asp:LinkButton ID="lnkABCode" CommandArgument='<%# Eval("AbstractId") %>' 
                                        runat="server" onclick="lnkABCode_Click"><%# Eval("ABCode")%></asp:LinkButton>
                                </DataItemTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="PersonId" VisibleIndex="3" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="ConferenceId" VisibleIndex="4" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="ConferenceName" VisibleIndex="5" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataComboBoxColumn Caption="Category" 
                                FieldName="ConferenceCategoryId" VisibleIndex="6">
                                <PropertiesComboBox DataSourceID="CategoryObjectDS" TextField="CategoryName" 
                                    ValueField="ConferenceCategoryId" ValueType="System.Int32">
                                </PropertiesComboBox>
                            </dx:GridViewDataComboBoxColumn>
                            <dx:GridViewDataTextColumn FieldName="AbstractTitle" VisibleIndex="7">
                                <Settings AutoFilterCondition="Contains" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="AbstractIntro" VisibleIndex="8" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="AbstractAuthors" VisibleIndex="9">
                                <Settings AutoFilterCondition="Contains" />
                            </dx:GridViewDataTextColumn>

                             <dx:GridViewDataTextColumn FieldName="Phone" VisibleIndex="10" 
                                Visible="True">
                                 </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="CoverLetter" VisibleIndex="10" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataCheckColumn FieldName="IsAccepted" VisibleIndex="11" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataTextColumn FieldName="AcceptanceType" VisibleIndex="12" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="PresentationPath" VisibleIndex="18" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="PosterPath" VisibleIndex="19" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="Topic" VisibleIndex="20" Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="Background" VisibleIndex="21" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="Methods" VisibleIndex="22" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="Results" VisibleIndex="23" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="Conclusions" VisibleIndex="24" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="AbstractTerms" VisibleIndex="25" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="AbstractKeywords" VisibleIndex="26" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="DocumentPath1" VisibleIndex="27" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="DocumentPath2" VisibleIndex="28" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="DocumentPath3" VisibleIndex="29" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="RevisionNumber" VisibleIndex="30" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="ParentID" VisibleIndex="15" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataComboBoxColumn Caption="Status" FieldName="AbstractStatusId" 
                                VisibleIndex="17">
                                <PropertiesComboBox DataSourceID="StatusObjectDS" TextField="Name" 
                                    ValueField="AbstractStatusId" ValueType="System.Int32">
                                </PropertiesComboBox>
                            </dx:GridViewDataComboBoxColumn>
                            <dx:GridViewDataTextColumn FieldName="AuthorContactName" VisibleIndex="14" 
                                Name="Contact Name">
                                <Settings AutoFilterCondition="Contains" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="AuthorContactNameFull" VisibleIndex="13" 
                                Caption="Contact" Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Email" FieldName="AuthorEmail" 
                                VisibleIndex="16">
                            </dx:GridViewDataTextColumn>
                        </Columns>
                        <SettingsBehavior AllowFocusedRow="True" ConfirmDelete="True" 
                            EnableRowHotTrack="True" />
                        <Settings ShowFilterRow="True" ShowGroupPanel="True" ShowPreview="True" />
                        <SettingsText ConfirmDelete="Are you sure you want to delete this abstract?" />
                    </dx:ASPxGridView>
                    <asp:ObjectDataSource ID="AbstractsObjectDS" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllParentsByConferenceId" 
                        TypeName="BusinessLogicLayer.Components.Conference.AbstractsLogic" 
                        DeleteMethod="Delete" InsertMethod="Insert" UpdateMethod="Update">
                        <DeleteParameters>
                            <asp:Parameter Name="Original_AbstractId" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="PersonId" Type="Int32" />
                            <asp:Parameter Name="ConferenceId" Type="Int32" />
                            <asp:Parameter Name="ConferenceCategoryId" Type="Int32" />
                            <asp:Parameter Name="AbstractTitle" Type="String" />
                            <asp:Parameter Name="AbstractIntro" Type="String" />
                            <asp:Parameter Name="AbstractAuthors" Type="String" />
                            <asp:Parameter Name="CoverLetter" Type="String" />
                            <asp:Parameter Name="IsAccepted" Type="Boolean" />
                            <asp:Parameter Name="AcceptanceType" Type="String" />
                            <asp:Parameter Name="PresentationPath" Type="String" />
                            <asp:Parameter Name="PosterPath" Type="String" />
                            <asp:Parameter Name="Topic" Type="String" />
                            <asp:Parameter Name="Background" Type="String" />
                            <asp:Parameter Name="Methods" Type="String" />
                            <asp:Parameter Name="Results" Type="String" />
                            <asp:Parameter Name="Conclusions" Type="String" />
                            <asp:Parameter Name="AbstractTerms" Type="String" />
                            <asp:Parameter Name="AbstractKeywords" Type="String" />
                            <asp:Parameter Name="DocumentPath1" Type="String" />
                            <asp:Parameter Name="DocumentPath2" Type="String" />
                            <asp:Parameter Name="DocumentPath3" Type="String" />
                            <asp:Parameter Name="RevisionNumber" Type="Int32" />
                            <asp:Parameter Name="ParentID" Type="Int32" />
                            <asp:Parameter Name="AbstractStatusId" Type="Int32" />
                        </InsertParameters>
                        <SelectParameters>
                            <asp:QueryStringParameter DefaultValue="0" Name="ConferenceId" 
                                QueryStringField="code" Type="Int32" />
                        </SelectParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="PersonId" Type="Int32" />
                            <asp:Parameter Name="ConferenceId" Type="Int32" />
                            <asp:Parameter Name="ConferenceCategoryId" Type="Int32" />
                            <asp:Parameter Name="AbstractTitle" Type="String" />
                            <asp:Parameter Name="AbstractIntro" Type="String" />
                            <asp:Parameter Name="AbstractAuthors" Type="String" />
                            <asp:Parameter Name="CoverLetter" Type="String" />
                            <asp:Parameter Name="IsAccepted" Type="Boolean" />
                            <asp:Parameter Name="AcceptanceType" Type="String" />
                            <asp:Parameter Name="PresentationPath" Type="String" />
                            <asp:Parameter Name="PosterPath" Type="String" />
                            <asp:Parameter Name="Topic" Type="String" />
                            <asp:Parameter Name="Background" Type="String" />
                            <asp:Parameter Name="Methods" Type="String" />
                            <asp:Parameter Name="Results" Type="String" />
                            <asp:Parameter Name="Conclusions" Type="String" />
                            <asp:Parameter Name="AbstractTerms" Type="String" />
                            <asp:Parameter Name="AbstractKeywords" Type="String" />
                            <asp:Parameter Name="DocumentPath1" Type="String" />
                            <asp:Parameter Name="DocumentPath2" Type="String" />
                            <asp:Parameter Name="DocumentPath3" Type="String" />
                            <asp:Parameter Name="RevisionNumber" Type="Int32" />
                            <asp:Parameter Name="ParentID" Type="Int32" />
                            <asp:Parameter Name="AbstractStatusId" Type="Int32" />
                            <asp:Parameter Name="Original_AbstractId" Type="Int32" />
                        </UpdateParameters>
                    </asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="CategoryObjectDS" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.Conference.ConferenceCategoryLogic">
                    </asp:ObjectDataSource>
                </div>
            </div>
</div>
    <asp:ObjectDataSource ID="StatusObjectDS" runat="server" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
        TypeName="BusinessLogicLayer.Components.Conference.AbstractStatusLogic">
    </asp:ObjectDataSource>

    <dx:ASPxPopupControl ID="popReviewers" ClientInstanceName="popReviewers" 
        runat="server" HeaderText="Assign Reviewers" PopupHorizontalAlign="WindowCenter" 
        PopupVerticalAlign="WindowCenter" Width="600px">
        <ContentCollection>
<dx:PopupControlContentControl runat="server" SupportsDisabledAttribute="True">
<div id="ReviewersMessageLabelContainer"><div runat="server" visible="false" id="ReviewersMessageLabel" class="alert info">Reviewers Added to Abstracts!</div></div>
    <dx:ASPxPageControl ID="pageReviewersControl" runat="server" ActiveTabIndex="0" 
        Width="100%">
        <TabPages>
            <dx:TabPage Text="Existing Reviewers">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxGridView ID="gridReviewers" runat="server" AutoGenerateColumns="False" 
                            DataSourceID="ReviewersObjectDS" KeyFieldName="AbstractReviewerId" 
                            ClientInstanceName="gridReviewers">
                            <Columns>
                                <dx:GridViewCommandColumn ShowInCustomizationForm="True" 
                                    ShowSelectCheckbox="True" VisibleIndex="0">
                                    <ClearFilterButton Visible="True">
                                    </ClearFilterButton>
                                </dx:GridViewCommandColumn>
                                <dx:GridViewDataTextColumn FieldName="AbstractReviewerId" ReadOnly="True" 
                                    ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                    <EditFormSettings Visible="False" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataComboBoxColumn Caption="Reviewer" FieldName="PersonId" 
                                    ShowInCustomizationForm="True" VisibleIndex="2" Width="300px">
                                    <PropertiesComboBox DataSourceID="PersonObjectDS" 
                                        IncrementalFilteringMode="Contains" TextField="FullName" 
                                        ValueField="BusinessEntityId" ValueType="System.Int32">
                                        <Columns>
                                            <dx:ListBoxColumn FieldName="FullName" />
                                            <dx:ListBoxColumn FieldName="UserName" />
                                        </Columns>
                                    </PropertiesComboBox>
                                </dx:GridViewDataComboBoxColumn>
                                <dx:GridViewDataCheckColumn FieldName="IsInternal" 
                                    ShowInCustomizationForm="True" VisibleIndex="3">
                                </dx:GridViewDataCheckColumn>
                                <dx:GridViewDataDateColumn FieldName="DateCreated" 
                                    ShowInCustomizationForm="True" Visible="False" VisibleIndex="4">
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataCheckColumn FieldName="IsActive" ShowInCustomizationForm="True" 
                                    Visible="False" VisibleIndex="5">
                                </dx:GridViewDataCheckColumn>
                            </Columns>
                            <Settings ShowFilterRow="True" />
                        </dx:ASPxGridView>
                        <asp:ObjectDataSource ID="ReviewersObjectDS" runat="server" 
                            OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                            TypeName="BusinessLogicLayer.Components.Conference.AbstractReviewerLogic">
                        </asp:ObjectDataSource>
                        <asp:ObjectDataSource ID="PersonObjectDS" runat="server" 
                            OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                            TypeName="BusinessLogicLayer.Components.Persons.PersonLogic">
                        </asp:ObjectDataSource>
                        <dx:ASPxCallbackPanel ID="callBackSubmitReviewersToAbstract" runat="server">
                            <PanelCollection>
                                <dx:PanelContent runat="server">
                                </dx:PanelContent>
                            </PanelCollection>
                        </dx:ASPxCallbackPanel>
                        <br />
                        
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Text="External Reviewers">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <table>
                            <tr>
                                <td>External Reviewer 1:</td>
                                <td>
                                    <dx:ASPxTextBox ID="ExternalReviewerText1" runat="server" Width="170px">
                                    </dx:ASPxTextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>External Reviewer 2:</td>
                                <td>
                                    <dx:ASPxTextBox ID="ExternalReviewerText2" runat="server" Width="170px">
                                    </dx:ASPxTextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>External Reviewer 3:</td>
                                <td>
                                    <dx:ASPxTextBox ID="ExternalReviewerText3" runat="server" Width="170px">
                                    </dx:ASPxTextBox>
                                </td>
                            </tr>
                        </table>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
        </TabPages>
    </dx:ASPxPageControl>
    <dx:ASPxButton ID="btnSubmitExistingReviewers" runat="server" 
                            OnClick="btnSubmitExistingReviewers_Click" Text="Submit Reviewers" 
                            Width="157px">
                        </dx:ASPxButton>
            <dx:ASPxGridViewExporter ID="ASPxGridViewExporter1" runat="server" 
        GridViewID="gridAbstracts">
    </dx:ASPxGridViewExporter>
            </dx:PopupControlContentControl>
</ContentCollection>
    </dx:ASPxPopupControl>
</asp:Content>
