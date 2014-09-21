<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="ManageSiteArticles.aspx.cs" Inherits="SocioBuilderSite.Administrator.ContentManagement.ManageSiteArticles" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
<div class="g12 widgets">
			<div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
				<h3 class="handle">Manage Site Articles</h3>
				<div class="inner-content">
                <a href="SaveSiteArticle.aspx?PageCode=0"  style="font-weight:bold;">Add New</a>
                <br /><br />
            <dx:ASPxGridView ID="SitePageGrid" ClientInstanceName="SitePageGrid" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="SitePagesObjectDS" KeyFieldName="ArticleId" 
                    oncelleditorinitialize="SitePageGrid_CellEditorInitialize">
                <ClientSideEvents CustomButtonClick="function(s, e) {
	window.location.href ='SaveSiteArticle.aspx?ArticleCode=' + s.GetRowKey(s.GetFocusedRowIndex());
}" />
                <Columns>
                    <dx:GridViewCommandColumn ButtonType="Image" VisibleIndex="0" Width="60px" Caption=" ">
                        <DeleteButton Visible="True">
                            <Image Height="16px" Url="~/images/griddelete.png" Width="16px">
                            </Image>
                        </DeleteButton>
                        <EditButton>
                            <Image Height="16px" Url="~/images/editgrid.png" Width="16px">
                            </Image>
                        </EditButton>
                        <NewButton>
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
                        <CustomButtons>
                            <dx:GridViewCommandColumnCustomButton Text="Edit">
                                <Image AlternateText="Edit" Height="16px" Url="~/images/editgrid.png" 
                                    Width="16px">
                                </Image>
                            </dx:GridViewCommandColumnCustomButton>
                        </CustomButtons>
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn FieldName="SitePageId" 
                        ReadOnly="True" VisibleIndex="1" Caption="Id" Visible="false">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Name" FieldName="ArticleName" 
                        VisibleIndex="2" Width="220px">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Site" FieldName="SiteId" 
                        VisibleIndex="3">
                        <PropertiesComboBox DataSourceID="SiteObjectDS" TextField="Name" 
                            ValueField="SiteId" ValueType="System.Int32">
                             <ClientSideEvents SelectedIndexChanged="function(s, e) { OnSiteChanged(s); }"></ClientSideEvents>
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Section" FieldName="SiteSectionId" 
                        VisibleIndex="4">
                        <PropertiesComboBox DataSourceID="SectionObjectDS" 
                            IncrementalFilteringMode="Contains" TextField="Name" ValueField="SiteSectionId" 
                            ValueType="System.Int32">
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Status" FieldName="ArticleStatusId" 
                        VisibleIndex="5">
                        <PropertiesComboBox DataSourceID="StatusObjectDS" TextField="Name" 
                            ValueField="PageStatusId" ValueType="System.Int32">
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Creator" FieldName="CreatorId" 
                        VisibleIndex="7">
                        <PropertiesComboBox DataSourceID="PersonObjectDS" TextField="UserName" 
                            ValueField="BusinessEntityId" ValueType="System.Int32">
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataDateColumn FieldName="ModifiedDate" VisibleIndex="9">
                    </dx:GridViewDataDateColumn>
                </Columns>
                <SettingsBehavior AllowFocusedRow="True" ConfirmDelete="True" />
                <SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="450px" />
                <Settings ShowFilterRow="True" ShowGroupPanel="True" />
                <SettingsText ConfirmDelete="Are you sure you want to delete this record?" />

<SettingsBehavior AllowFocusedRow="True" ConfirmDelete="True"></SettingsBehavior>

<SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="450px"></SettingsEditing>

<Settings ShowFilterRow="True" ShowGroupPanel="True"></Settings>

<SettingsText ConfirmDelete="Are you sure you want to delete this record?"></SettingsText>
    </dx:ASPxGridView>
                
                <asp:ObjectDataSource ID="SitePagesObjectDS" runat="server" 
                    DeleteMethod="Delete" InsertMethod="Insert" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllBySiteId" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.ArticleLogic" 
                    UpdateMethod="Update">
                    <DeleteParameters>
                        <asp:Parameter Name="Original_ArticleId" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="ArticleId" Type="Int32" />
                        <asp:Parameter Name="SiteSectionId" Type="Int32" />
                        <asp:Parameter Name="CreatorId" Type="Int32" />
                        <asp:Parameter Name="ArticleStatusId" Type="Int32" />
                        <asp:Parameter Name="AuthorId" Type="Int32" />
                        <asp:Parameter Name="PostDate" Type="DateTime" />
                        <asp:Parameter Name="AllowLanguageSpecificTags" Type="Boolean" />
                        <asp:Parameter DbType="Guid" Name="RowGuid" />
                        <asp:Parameter Name="ModifiedDate" Type="DateTime" />
                        <asp:Parameter Name="CommentsTypeId" Type="Int32" />
                        <asp:Parameter Name="EnableModeteration" Type="Boolean" />
                    </InsertParameters>
                    <SelectParameters>
                        <asp:SessionParameter DefaultValue="0" Name="SiteId" 
                            SessionField="CurrentWorkingSite" Type="String" />
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="ArticleId" Type="Int32" />
                        <asp:Parameter Name="SiteSectionId" Type="Int32" />
                        <asp:Parameter Name="CreatorId" Type="Int32" />
                        <asp:Parameter Name="ArticleStatusId" Type="Int32" />
                        <asp:Parameter Name="AuthorId" Type="Int32" />
                        <asp:Parameter Name="PostDate" Type="DateTime" />
                        <asp:Parameter Name="AllowLanguageSpecificTags" Type="Boolean" />
                        <asp:Parameter DbType="Guid" Name="RowGuid" />
                        <asp:Parameter Name="ModifiedDate" Type="DateTime" />
                        <asp:Parameter Name="CommentsTypeId" Type="Int32" />
                        <asp:Parameter Name="EnableModeteration" Type="Boolean" />
                        <asp:Parameter Name="Original_ArticleId" Type="Int32" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
                
                <asp:ObjectDataSource ID="SiteObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.SiteLogic">
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="SectionObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllBySiteId" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.SiteSectionLogic">
                    <SelectParameters>
                        <asp:Parameter Name="SiteId" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                
                <asp:ObjectDataSource ID="StatusObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.PageStatusLogic">
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="SecurityAccessObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.RoleSecurity.SecurityAccessTypeLogic">
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="PersonObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.Persons.PersonLogic">
                </asp:ObjectDataSource>
                
    </div>
    </div>
   </div>
</asp:Content>
