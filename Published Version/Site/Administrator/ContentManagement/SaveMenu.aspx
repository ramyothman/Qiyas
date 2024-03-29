﻿<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master"
    AutoEventWireup="true" CodeBehind="SaveMenu.aspx.cs" Inherits="SocioBuilderSite.Administrator.ContentManagement.SaveMenu" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <div class="g12 widgets">
        <div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
            <h3 class="handle">
                Save Menu<asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </h3>
            <div class="inner-content">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                    <div class="form">
                    <fieldset class="fieldset">
                        <%--<label class="label">Save Menu</label>--%>
                        
                        <section><label class="label" for="text_field">Menu Name</label>
							<div>
                            <dx:ASPxTextBox width="70%" ID="txtMenuName" runat="server">
                                        <ValidationSettings ValidationGroup="Save" causesvalidation="True" 
                                            display="Dynamic" errordisplaymode="Text">
                                            <RequiredField IsRequired="True" />
                                        </ValidationSettings>
                                    </dx:ASPxTextBox>
                                
                            </div>
						</section>
                        <section><label class="label" for="text_field">Display Order</label>
							<div>
                            <dx:ASPxTextBox width="170px" ID="txtDisplayOrder" runat="server" Text="0" >
                                        <MaskSettings Mask="&lt;0..100&gt;" />
                                        <ValidationSettings ValidationGroup="Save">
                                            <RequiredField IsRequired="True" />
                                        </ValidationSettings>
                                    </dx:ASPxTextBox>
                                
                            </div>
						</section>
                        <section><label class="label" for="text_field">Menu Type</label>
							<div>
                             <dx:ASPxComboBox ID="cbMenuType" runat="server" DataSourceID="dsMenuType" TextField="Name"
                                        ValueField="MenuEntityTypeId" AutoPostBack="True" Width="450px" 
                                        onselectedindexchanged="cbMenuType_SelectedIndexChanged" 
                                    ValueType="System.Int32">
                                        <ValidationSettings ValidationGroup="Save">
                                            <RequiredField IsRequired="True" />
                                        </ValidationSettings>
                                    </dx:ASPxComboBox>
                                    <asp:ObjectDataSource ID="dsMenuType" runat="server" OldValuesParameterFormatString="original_{0}"
                                        SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.ContentManagement.MenuEntityTypeLogic">
                                    </asp:ObjectDataSource>
                                
                            </div>
						</section>
                        <section><label class="label" for="text_field">Site Name</label>
							<div>
                                <dx:ASPxComboBox ID="cbSiteName" runat="server" Width="450px" DataSourceID="dsSiteName" TextField="Name"
                                        ValueField="SiteId" ValueType="System.Int32">
                                        <ValidationSettings ValidationGroup="Save">
                                            <RequiredField IsRequired="True" />
                                        </ValidationSettings>
                                    </dx:ASPxComboBox>
                                    <asp:ObjectDataSource ID="dsSiteName" runat="server" OldValuesParameterFormatString="original_{0}"
                                        SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.ContentManagement.SiteLogic">
                                    </asp:ObjectDataSource>
                            </div>
						</section> 
                        
                        <section id="divSite" runat="server" visible="false"><label class="label" for="text_field">Section Name</label>
							<div>
                                <dx:ASPxComboBox ID="cbSectionName" runat="server" Width="450px" DataSourceID="dsSection" TextField="Name"
                                            ValueField="SiteSectionId" ValueType="System.Int32">
                                            <ValidationSettings ValidationGroup="Save">
                                                <RequiredField IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxComboBox>
                                        <asp:ObjectDataSource ID="dsSection" runat="server" OldValuesParameterFormatString="original_{0}"
                                            SelectMethod="GetAllBySiteId" TypeName="BusinessLogicLayer.Components.ContentManagement.SiteSectionLogic">
                                            <SelectParameters>
                                                <asp:ControlParameter ControlID="cbSiteName" Name="SiteId" PropertyName="Value" Type="String" />
                                            </SelectParameters>
                                        </asp:ObjectDataSource>
                            </div>
                            <hr />
                            <label class="label" for="text_field">Page Name</label>
							<div>
                                <dx:ASPxComboBox ID="cbPageName" runat="server" Width="450px" DataSourceID="dsPages" TextField="PageName"
                                            ValueField="SitePageId" ValueType="System.Int32">
                                            <ValidationSettings ValidationGroup="Save">
                                                <RequiredField IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxComboBox>
                                        <asp:ObjectDataSource ID="dsPages" runat="server" OldValuesParameterFormatString="original_{0}"
                                            SelectMethod="GetAllBySectionId" TypeName="BusinessLogicLayer.Components.ContentManagement.SitePageLogic">
                                            <SelectParameters>
                                                <asp:ControlParameter ControlID="cbSectionName" Name="SectionId" PropertyName="Value"
                                                    Type="String" />
                                            </SelectParameters>
                                        </asp:ObjectDataSource>
                            </div>
						</section>

                        <section id="divSiteSection" runat="server" visible="false"><label class="label" for="text_field">Section Name</label>
							<div>
                                <dx:ASPxComboBox ID="cbSectionNameArticle" runat="server" Width="450px" DataSourceID="ObjectDataSource1" TextField="Name"
                                            ValueField="SiteSectionId" ValueType="System.Int32">
                                            <ValidationSettings ValidationGroup="Save">
                                                <RequiredField IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxComboBox>
                                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}"
                                            SelectMethod="GetAllBySiteId" TypeName="BusinessLogicLayer.Components.ContentManagement.SiteSectionLogic">
                                            <SelectParameters>
                                                <asp:ControlParameter ControlID="cbSiteName" Name="SiteId" PropertyName="Value" Type="String" />
                                            </SelectParameters>
                                        </asp:ObjectDataSource>
                            </div>
                            
						</section>
                        
                        
                        
                        <section id="divExternalLink" runat="server" visible="false"><label class="label" for="text_field">External Page URL</label>
							<div>
                                <dx:ASPxTextBox ID="txtExternalPageURL" runat="server" Width="450px">
                                            <ValidationSettings ErrorText="*" ValidationGroup="Save">
                                                <RequiredField IsRequired="True" />                                             
                                            </ValidationSettings>
                                        </dx:ASPxTextBox>
                            </div>
						</section>
                        
                        
                        <section id="divSystemPages" runat="server" visible="false"><label class="label" for="text_field">System Page Name</label>
							<div>
                                <dx:ASPxComboBox ID="cbSystemPages" runat="server" DataSourceID="dsSystemPage" 
                                TextField="Name" ValueField="SystemPageId" Width="450px" ValueType="System.Int32">
                                <ValidationSettings ValidationGroup="Save">
                                    <RequiredField IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxComboBox>
                            <asp:ObjectDataSource ID="dsSystemPage" runat="server" 
                                OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                                TypeName="BusinessLogicLayer.Components.ContentManagement.SystemPageLogic">
                                <SelectParameters>
                                    <asp:Parameter DefaultValue="True" Name="IsActive" Type="Boolean" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                            </div>
						</section>
                        
                        
                        
                        <section id="divForParent" runat="server" visible="false"><label class="label" for="text_field">Language</label>
							<div>
                                 <dx:ASPxComboBox ID="cbLang" runat="server" Width="450px" DataSourceID="dsLang" 
                                TextField="Name" ValueField="LanguageId" ValueType="System.Int32">
                                <ValidationSettings>
                                    <RequiredField IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxComboBox>
                            <asp:ObjectDataSource ID="dsLang" runat="server" 
                                OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                                TypeName="BusinessLogicLayer.Components.ContentManagement.LanguageLogic">
                            </asp:ObjectDataSource>
                            </div>
                            <hr />
                            <label class="label" for="text_field">Menu Position</label>
							<div>
                                 <dx:ASPxComboBox ID="cbMenuPosition" Width="450px" runat="server" 
                                DataSourceID="dsmenuPosition" TextField="Name" 
                                ValueField="MenuEntityPositionID" ValueType="System.Int32">
                            </dx:ASPxComboBox>
                            <asp:ObjectDataSource ID="dsmenuPosition" runat="server" 
                                OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                                TypeName="BusinessLogicLayer.Components.ContentManagement.MenuEntityPositionLogic">
                            </asp:ObjectDataSource>
                            </div>
						</section>
                        
                        
                        </fieldset>
                        </div>
                        

                        
                        
                        
                    </ContentTemplate>
                </asp:UpdatePanel>
                <br />
                <table cellspacing="10px" width="80%">
                    <tr align="center">
                        <td>
                            <dx:ASPxButton ID="btnSave" runat="server" Text="Save" ValidationGroup="Save" 
                                onclick="btnSave_Click">
                            </dx:ASPxButton>
                        </td>
                        <td>
                            <dx:ASPxButton ID="btnCancel" runat="server" Text="Cancel" 
                                onclick="btnCancel_Click">
                            </dx:ASPxButton>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
