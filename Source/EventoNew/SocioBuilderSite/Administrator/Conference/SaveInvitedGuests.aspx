<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master"
    AutoEventWireup="true" CodeBehind="SaveInvitedGuests.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.Conference.SaveInvitedGuests" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxUploadControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
     <div class="g12 widgets">
			<div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
				<h3 class="handle">Save Invited Guest </h3>
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
                <td>
                    Conference
                </td>
                <td>
                    <dx:ASPxComboBox ID="cbConfernece" runat="server" Width="170px" DataSourceID="ConferenceObjectDS"
                        TextField="ConferenceName" ValueField="ConferenceId">
                    </dx:ASPxComboBox>
                    <asp:ObjectDataSource ID="ConferenceObjectDS" runat="server" OldValuesParameterFormatString="original_{0}"
                        SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.Conference.ConferencesLogic">
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td>
                    RegisterartionDate
                </td>
                <td>
                    <dx:ASPxDateEdit ID="dtRegisterartionDate" runat="server" Width="170px">
                    </dx:ASPxDateEdit>
                </td>
                <td>
                    Speaker Photo
                </td>
                <td>
                    <dx:ASPxUploadControl ID="SpeakerImageUpload" runat="server">
                    </dx:ASPxUploadControl>
                </td>
                <td>
                    <asp:Image ID="imgSpeaker" runat="server" Visible="false" Width="90px" Height="70px" />
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
                    <dx:ASPxTextBox ID="txtBio" runat="server" Width="170px">
                    </dx:ASPxTextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <b>Flight Information</b>
                </td>
            </tr>
            <tr>
                <td>
                    From Country:
                </td>
                <td>
                    <dx:ASPxTextBox ID="txtFlightFromCountry" runat="server" Width="170px">
                    </dx:ASPxTextBox>
                </td>
                <td>
                    From City
                </td>
                <td>
                    <dx:ASPxTextBox ID="txtFlightFromCity" runat="server" Width="170px">
                    </dx:ASPxTextBox>
                </td>
            </tr>
            <tr>
                <td>
                    To Country
                </td>
                <td>
                    <dx:ASPxTextBox ID="txtFlightToCountry" runat="server" Width="170px">
                    </dx:ASPxTextBox>
                </td>
                <td>
                    To City
                </td>
                <td>
                    <dx:ASPxTextBox ID="txtFlightToCity" runat="server" Width="170px">
                    </dx:ASPxTextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Arrival Date
                </td>
                <td>
                    <dx:ASPxDateEdit ID="dtArrivalDate" runat="server" Width="170px">
                    </dx:ASPxDateEdit>
                </td>
                <td>
                    Arrival Time
                </td>
                <td>
                    <dx:ASPxTextBox ID="dtArrivalTime" runat="server" Width="70px"></dx:ASPxTextBox>
                </td>
                <td>
                    <dx:ASPxComboBox ID="cbPMOrAMArrival" runat="server" Width="50px" >
                        <Items>
                            <dx:ListEditItem Text="AM" Value="AM" Selected="true" />
                            <dx:ListEditItem Text="PM" Value="PM" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    Flight Number
                </td>
                <td>
                    <dx:ASPxTextBox ID="txtFlightNumber" runat="server" Width="170px">
                    </dx:ASPxTextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Deprature Date
                </td>
                <td>
                    <dx:ASPxDateEdit ID="dtDepratureDate" runat="server" Width="170px">
                    </dx:ASPxDateEdit>
                </td>
                <td>
                    Deprature Time
                </td>
                <td>
                     <dx:ASPxTextBox ID="dtDepratureTime" runat="server" Width="70px"></dx:ASPxTextBox>
                </td>
                <td>
                    <dx:ASPxComboBox ID="cbPMorAMDeprature" runat="server" Width="50px" >
                        <Items>
                            <dx:ListEditItem Text="AM" Value="AM" Selected="true" />
                            <dx:ListEditItem Text="PM" Value="PM" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    AirLine Name
                </td>
                <td>
                    <dx:ASPxComboBox ID="cbAirLine" runat="server" Width="170px" DataSourceID="dsAirLine"
                        TextField="Name" ValueField="ID">
                    </dx:ASPxComboBox>
                    <asp:ObjectDataSource ID="dsAirLine" runat="server" OldValuesParameterFormatString="original_{0}"
                        SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.Conference.AirLineLogic">
                    </asp:ObjectDataSource>
                </td>
                <td>
                    Hotel Name
                </td>
                <td>
                    <dx:ASPxComboBox ID="cbHotel" runat="server" Width="170px" DataSourceID="dsHotels"
                        TextField="Name" ValueField="ID">
                    </dx:ASPxComboBox>
                    <asp:ObjectDataSource ID="dsHotels" runat="server" OldValuesParameterFormatString="original_{0}"
                        SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.Conference.HotelLogic">
                    </asp:ObjectDataSource>
                </td>
                
            </tr>
            <tr>
                <td>
                    Responsible Person Name
                </td>
                <td>
                    <dx:ASPxComboBox ID="cbResponsiblePerson" runat="server" Width="170px" DataSourceID="PersonObjectDS"
                        TextField="DisplayName" ValueField="BusinessEntityId">
                    </dx:ASPxComboBox>
                    <asp:ObjectDataSource ID="PersonObjectDS" runat="server" OldValuesParameterFormatString="original_{0}"
                        SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.Persons.PersonLogic">
                    </asp:ObjectDataSource>
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

