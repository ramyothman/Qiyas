<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master"
    AutoEventWireup="true" CodeBehind="SaveARSpeakers.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.Conference.SaveARSpeakers" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxUploadControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
     <div class="g12 widgets">
			<div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
				<h3 class="handle">Save Speaker </h3>
				<div class="inner-content">
    <div>
        <table>
            <tr>
                <td>
                    Name
                </td>
                <td>
                    <dx:ASPxTextBox ID="txtName" runat="server" Width="170px">
                    </dx:ASPxTextBox>
                </td>
               
            </tr>
      
            <tr>
                <td>
                    Position
                </td>
                <td>
                    <dx:ASPxTextBox ID="txtPosition" runat="server" Width="170px">
                    </dx:ASPxTextBox>
                </td>
                <td>
                    Bio
                </td>
                <td>
                    <dx:ASPxMemo ID="txtBio" Width="400px" Height="300px" runat="server">
                    </dx:ASPxMemo>
                </td>
            </tr>
         
   
              <tr id="trParent" runat="server" visible="false">
            <td>
            Language
            </td>
            <td>
             <dx:ASPxComboBox ID="cbLanguage" runat="server" Width="170px" DataSourceID="dsLanguage"
                        TextField="Name" ValueField="LanguageId">
                 <ValidationSettings>
                     <RequiredField IsRequired="True" />
                 </ValidationSettings>
                    </dx:ASPxComboBox>
                    <asp:ObjectDataSource ID="dsLanguage" runat="server" OldValuesParameterFormatString="original_{0}"
                        SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.LanguageLogic">
                    </asp:ObjectDataSource>
            </td>
           
            </tr>
            <tr align="center">
                <td colspan="5">
                    <dx:ASPxButton ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click">
                    </dx:ASPxButton>
                </td>
            </tr>
        </table>
    </div>
    </div>
    </div>
    </div>
</asp:Content>

