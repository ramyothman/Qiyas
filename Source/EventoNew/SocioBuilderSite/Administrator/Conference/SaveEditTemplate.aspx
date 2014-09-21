<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="SaveEditTemplate.aspx.cs" Inherits="SocioBuilderSite.Administrator.Conference.SaveEditTemplate" %>

<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxSpellChecker.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSpellChecker" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
  <div class="g12 widgets">
			<div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
				<h3 class="handle">Save Email Template </h3>
				<div class="inner-content">
                    <table>
                        <tr>
                            <td>
                                 <table>
                <tr>
                <td>
                Name
                </td>
                <td>
                    <dx:ASPxTextBox ID="txtName" runat="server" Width="170px">
                        <ValidationSettings>
                            <RequiredField IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </td>
                </tr>
                 <tr>
                <td>
                Template Type
                </td>
                <td>
                    <dx:ASPxComboBox ID="cbEmailType" runat="server" DataSourceID="dsEmailType" 
                        TextField="Name" ValueField="SystemEmailTypeID" ValueType="System.Int32">
                        <ValidationSettings>
                            <RequiredField IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                    <asp:ObjectDataSource ID="dsEmailType" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.Conference.SystemEmailTypeLogic">
                    </asp:ObjectDataSource>
                </td>
                </tr>
                 <tr>
                <td>
                Conference Name
                </td>
                <td>
                    <dx:ASPxComboBox ID="cbConference" runat="server" DataSourceID="dsConference" 
                        TextField="ConferenceName" ValueField="ConferenceId" ValueType="System.Int32">
                        <ValidationSettings>
                            <RequiredField IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                    <asp:ObjectDataSource ID="dsConference" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.Conference.ConferencesLogic">
                    </asp:ObjectDataSource>
                </td>
                </tr>
                 <tr>
                <td>
                Language
                </td>
                <td>
                    <dx:ASPxComboBox ID="cbLang" runat="server" DataSourceID="dsLanguage" 
                        TextField="Name" ValueField="LanguageId" ValueType="System.Int32">
                        <ValidationSettings>
                            <RequiredField IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                    <asp:ObjectDataSource ID="dsLanguage" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.ContentManagement.LanguageLogic">
                    </asp:ObjectDataSource>
                </td>
                </tr>
                  <tr>
                <td>
                Content
                </td>
                <td>
                    <dx:ASPxHtmlEditor ID="txtContent" runat="server" Width="100%">
<SettingsImageUpload UploadImageFolder="~/ContentData/" UseAdvancedUploadMode="True">
<ValidationSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></ValidationSettings>
</SettingsImageUpload>

                        <SettingsValidation>
                            <RequiredField IsRequired="True" />
                        </SettingsValidation>

<SettingsImageSelector>
<CommonSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></CommonSettings>
</SettingsImageSelector>

<SettingsDocumentSelector>
<CommonSettings AllowedFileExtensions=".rtf, .pdf, .doc, .docx, .odt, .txt, .xls, .xlsx, .ods, .ppt, .pptx, .odp"></CommonSettings>
</SettingsDocumentSelector>
                    </dx:ASPxHtmlEditor>
                </td>
                </tr>
                  <tr>
                <td>
                Description
                </td>
                <td>
                    <dx:ASPxMemo ID="txtDesc" runat="server" Height="71px" Width="586px">
                    </dx:ASPxMemo>
                </td>
                </tr>
                <tr align="center">
                <td colspan="2">
                <br /><br />
                    <dx:ASPxButton ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click">
                    </dx:ASPxButton>
                </td>
                </tr>
                </table>
                            </td>

                            <td>
                                <table>
                                    <tr>
                                        <td>##CUSTOMBODY##</td>
                                        <td>Custom Text</td>
                                    </tr>
                                    <tr>
                                        <td>##DATE##</td>
                                        <td>Date</td>
                                    </tr>
                                    <tr>
                                        <td>##CITY##</td>
                                        <td>CITY</td>
                                    </tr>
                                    <tr>
                                        <td>##COUNTRY##</td>
                                        <td>COUNTRY</td>
                                    </tr>
                                    <tr>
                                        <td>##PHONENUMBER##</td>
                                        <td>PHONENUMBER</td>
                                    </tr>
                                    <tr>
                                        <td>##MOBILE##</td>
                                        <td>MOBILE</td>
                                    </tr>
                                    <tr>
                                        <td>##NAME##</td>
                                        <td>NAME</td>
                                    </tr>
                                    <tr>
                                        <td>##NAMEFULL##</td>
                                        <td>NAMEFULL</td>
                                    </tr>
                                    <tr>
                                        <td>##USERNAME##</td>
                                        <td>USERNAME</td>
                                    </tr>
                                    <tr>
                                        <td>##PASSWORD##</td>
                                        <td>PASSWORD</td>
                                    </tr>
                                    <tr>
                                        <td>##VERIFY##</td>
                                        <td>VERIFY</td>
                                    </tr>
                                     <tr>
                                        <td>##TITLE##</td>
                                        <td>TITLE</td>
                                    </tr>
                                     <tr>
                                        <td>##ABSTRACTNUMBER##</td>
                                        <td>ABSTRACTNUMBER</td>
                                    </tr>
                                     <tr>
                                        <td>##CATEGORY##</td>
                                        <td>CATEGORY</td>
                                    </tr>
                                     <tr>
                                        <td>##AUTHORS##</td>
                                        <td>AUTHORS</td>
                                    </tr>

                                </table>
                            </td>                        

                        </tr>

                    </table>
               
                </div>
                </div>
                </div>
</asp:Content>
