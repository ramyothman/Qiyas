<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SocioBuilderSite.Administrator.Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
<div class="g6">
<div class="widget number-widget" id="widget_number">
				<h3 class="handle">Number</h3>
				<div class="inner-content">
					<ul>
						<li><a href=""><span runat="server" id="TotalRegistrations"></span> Total Registerations</a></li>
						<li><a href=""><span runat="server" id="TotalAbstracts"></span> Total Abstracts Submitted</a></li>
						<li><a href=""><span runat="server" id="TotalAbstractsAccepted"></span> Total Abstracts Accepted</a></li>
						<li><a href=""><span runat="server" id="TotalAbstractsPending" ></span> Total Abstracts Pending</a></li>
						
					</ul>
				</div>
			</div>
</div>
<div class="g6">
<div class="widget number-widget" id="Div1">
				<h3 class="handle">Abstracts Pending</h3>
				<div class="inner-content">
                    
                    <dx:ASPxGridView ID="AbstractsGrid" ClientInstanceName="AbstractsGrid" 
                runat="server" AutoGenerateColumns="False" 
                DataSourceID="AbstractsObjectDS" KeyFieldName="AbstractId" >
                
                <Columns>
                    <dx:GridViewCommandColumn VisibleIndex="0">
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn FieldName="AbstractId" ReadOnly="True" 
                        VisibleIndex="1" Visible="False">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Code" FieldName="ABCode" 
                        VisibleIndex="2" ReadOnly="True">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="PersonId" VisibleIndex="2" 
                        Visible="False">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ConferenceId" VisibleIndex="3" 
                        Visible="False">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ConferenceName" VisibleIndex="3" 
                        Caption="Conference" Visible="False">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Category" 
                        FieldName="ConferenceCategoryId" VisibleIndex="4" Visible="False">
                        <PropertiesComboBox DataSourceID="CategoryObjectDS" TextField="CategoryName" 
                            ValueField="ConferenceCategoryId" ValueType="System.Int32">
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataTextColumn FieldName="AbstractTitle" VisibleIndex="5">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="AbstractIntro" VisibleIndex="7" 
                        Visible="False">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="AbstractAuthors" VisibleIndex="6" 
                        Caption="Authors" Visible="False">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="CoverLetter" VisibleIndex="9" 
                        Visible="False">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataCheckColumn FieldName="IsAccepted" VisibleIndex="7" 
                        Visible="False">
                    </dx:GridViewDataCheckColumn>
                    <dx:GridViewDataComboBoxColumn FieldName="AcceptanceType" VisibleIndex="8" 
                        Visible="False">
                        <PropertiesComboBox ValueType="System.String">
                            <Items>
                                <dx:ListEditItem Text="Pending" Value="Pending" />
                                <dx:ListEditItem Text="Cancelled" Value="Cancelled" />
                                <dx:ListEditItem Text="Poster" Value="Poster" />
                                <dx:ListEditItem Text="Oral" Value="Oral" />
                                <dx:ListEditItem Text="Not Accepted" Value="Not Accepted" />
                            </Items>
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataTextColumn FieldName="PresentationPath" Visible="False" 
                        VisibleIndex="12">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="PosterPath" Visible="False" 
                        VisibleIndex="12">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Topic" Visible="False" VisibleIndex="12">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Background" Visible="False" 
                        VisibleIndex="12">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Methods" Visible="False" 
                        VisibleIndex="12">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Results" Visible="False" 
                        VisibleIndex="12">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Conclusions" Visible="False" 
                        VisibleIndex="12">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="AbstractTerms" Visible="False" 
                        VisibleIndex="12">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="AbstractKeywords" Visible="False" 
                        VisibleIndex="12">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DocumentPath1" Visible="False" 
                        VisibleIndex="12">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DocumentPath2" Visible="False" 
                        VisibleIndex="12">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DocumentPath3" Visible="False" 
                        VisibleIndex="12">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="AuthorContactName" Visible="False" 
                        VisibleIndex="12">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Download" FieldName="AbstractId" 
                        VisibleIndex="9">
                        <DataItemTemplate>
                        <asp:LinkButton runat="server" id="AbstractPDFView" Text="Abstract(PDF)" ToolTip="Abstract Pdf" CommandArgument="<%# Container.KeyValue %>" 
                                         onclick="AbstractPDFView_Click">Download</asp:LinkButton>
                        </DataItemTemplate>
                    </dx:GridViewDataTextColumn>
                </Columns>
                 
                <SettingsBehavior AllowFocusedRow="True" ConfirmDelete="True" 
                    EnableRowHotTrack="True" />
                <SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="450px" />
                <Settings ShowFilterRowMenu="True" />
                <SettingsText ConfirmDelete="Are you sure you want to delete this record?" />
            </dx:ASPxGridView>
            </div>
           
            <asp:ObjectDataSource ID="AbstractsObjectDS" runat="server" 
                OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllPending" 
                TypeName="BusinessLogicLayer.Components.Conference.AbstractsLogic" 
                DeleteMethod="Delete">
                <DeleteParameters>
                    <asp:Parameter Name="Original_AbstractId" Type="Int32" />
                </DeleteParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="CategoryObjectDS" runat="server" 
                OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                TypeName="BusinessLogicLayer.Components.Conference.ConferenceCategoryLogic">
            </asp:ObjectDataSource>
				</div>
			</div>
</div>
</asp:Content>
