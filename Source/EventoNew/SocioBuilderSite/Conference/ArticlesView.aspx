<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master" AutoEventWireup="true" CodeBehind="ArticlesView.aspx.cs" Inherits="SocioBuilderSite.Conference.ArticlesView" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="news-content">
    <dx:ASPxGridView ID="gridNews" runat="server" AutoGenerateColumns="False" 
        DataSourceID="articlesObjectDS" KeyFieldName="ArticleId" Width="100%">
        <Columns>
            <dx:GridViewDataTextColumn FieldName="ArticleId" ReadOnly="True" 
                VisibleIndex="0">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="SiteSectionId" VisibleIndex="1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="CreatorId" VisibleIndex="2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="ArticleStatusId" VisibleIndex="3">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="AuthorId" VisibleIndex="4">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn FieldName="PostDate" VisibleIndex="5" SortIndex="0" SortOrder="Descending">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataCheckColumn FieldName="AllowLanguageSpecificTags" 
                VisibleIndex="6">
            </dx:GridViewDataCheckColumn>
            <dx:GridViewDataTextColumn FieldName="RowGuid" VisibleIndex="7">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn FieldName="ModifiedDate" VisibleIndex="8">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn FieldName="CommentsTypeId" VisibleIndex="9">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataCheckColumn FieldName="EnableModeteration" VisibleIndex="10">
            </dx:GridViewDataCheckColumn>
            <dx:GridViewDataTextColumn FieldName="SiteId" VisibleIndex="11">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="ArticleName" VisibleIndex="12">
            </dx:GridViewDataTextColumn>
        </Columns>
        <Settings GridLines="Horizontal" ShowColumnHeaders="False" />
        <Templates>
            <DataRow>
                <div class="news-item">
                    
                    <img id="Img1" width="100" height="100" runat="server" src='<%# Eval("ArticleAttachment").ToString() == "" ? "~/Conference/images/QiyasOrganizer.png"   : BusinessLogicLayer.Common.ConferenceContentPath + "/" + Eval("ArticleAttachment") %>' />
                        <h2><a runat="server" href='<%# "~/Conference/ArticleContent.aspx?article=" + Eval("ArticleId") %>'><%# Eval("ArticleName") %></a></h2>
                        <p>
                            <%# Eval("ArticleDescription") %>
                        </p>
                    
                    <div class="clear"></div>
                </div>
                <div class="clear"></div>
            </DataRow>
        </Templates>
        <Border BorderStyle="None" />
    </dx:ASPxGridView>
    </div>
    <asp:ObjectDataSource ID="articlesObjectDS" runat="server" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllBySectionId" 
        TypeName="BusinessLogicLayer.Components.ContentManagement.ArticleLogic">
        <SelectParameters>
            <asp:QueryStringParameter DefaultValue="0" Name="SiteSectionId" 
                QueryStringField="Code" Type="String" />
            <asp:SessionParameter DefaultValue="0" Name="LanguageID" 
                SessionField="LanguageId" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
