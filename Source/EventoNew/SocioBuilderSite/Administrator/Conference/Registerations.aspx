<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="Registerations.aspx.cs" Inherits="SocioBuilderSite.Administrator.Conference.Registerations" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
 <div class="g12 widgets">
			<div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
				<h3 class="handle">Registrations </h3>
				<div class="inner-content">
                    <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" 
                        DataSourceID="dsRegistration" KeyFieldName="ConferenceRegistererId">
                        <Columns>
                            <dx:GridViewDataTextColumn FieldName="ConferenceRegistererId" ReadOnly="True" 
                                Visible="False" VisibleIndex="0">
                                <EditFormSettings Visible="False" />
                               
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataComboBoxColumn FieldName="SponsorId" Caption="Sponsor" 
                                VisibleIndex="1" Visible="False">
                              <PropertiesComboBox DataSourceID="dsSponsors" TextField="SponsorName" ValueField="SponsorID"
                            ValueType="System.Int32" IncrementalFilteringMode="Contains">
                        </PropertiesComboBox>
                            </dx:GridViewDataComboBoxColumn>
                            <dx:GridViewDataComboBoxColumn FieldName="PersonId" Caption="Name" 
                                VisibleIndex="3">
                              <PropertiesComboBox DataSourceID="PersonObjectDS" TextField="DisplayName" ValueField="BusinessEntityId"
                            ValueType="System.Int32" IncrementalFilteringMode="Contains">
                        </PropertiesComboBox>
                            </dx:GridViewDataComboBoxColumn>
                            <dx:GridViewDataComboBoxColumn FieldName="ConferenceId" Caption="Conference" 
                                VisibleIndex="4">
                            <PropertiesComboBox DataSourceID="ConferenceObjectDS" TextField="ConferenceName"
                            ValueField="ConferenceId" ValueType="System.Int32">
                        </PropertiesComboBox>
                            </dx:GridViewDataComboBoxColumn>
                            <dx:GridViewDataTextColumn FieldName="UniquePayment" ReadOnly="True" 
                                VisibleIndex="8" Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataDateColumn FieldName="DateRegistered" VisibleIndex="26">
                            </dx:GridViewDataDateColumn>
                            <dx:GridViewDataTextColumn FieldName="DiscountAmount" VisibleIndex="9" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="AmountPaid" VisibleIndex="10" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="DiscountReason" VisibleIndex="11" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="RegitrationCategory" VisibleIndex="5">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="LicenseNumber" VisibleIndex="12" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="Address" VisibleIndex="13" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="POBox" VisibleIndex="14" Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="ZipCode" VisibleIndex="15" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="City" VisibleIndex="16" Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="Country" VisibleIndex="2">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="PhoneNumberCountryCode" VisibleIndex="17" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="PhoneNumberAreaCode" VisibleIndex="18" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="PhoneNumber" VisibleIndex="6">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="FaxNumberCountryCode" VisibleIndex="19" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="FaxNumberAreaCode" VisibleIndex="20" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="FaxNumber" VisibleIndex="21" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="MobileNumberCountryCode" 
                                VisibleIndex="22" Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="MobileNumberAreaCode" VisibleIndex="23" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="MobileNumber" VisibleIndex="7">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="Email" VisibleIndex="24">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="AcademicInformationPosition" 
                                VisibleIndex="25" Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="AcademicInformationDegree" 
                                VisibleIndex="27" Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataCheckColumn FieldName="AcademicInformationHealthCarePro" 
                                VisibleIndex="28" Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataTextColumn FieldName="AcademicInformationHealthCareProValue" 
                                VisibleIndex="29" Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="HospitalInstituteName" VisibleIndex="30" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="HospitalInstituteDepartment" 
                                VisibleIndex="31" Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="HospitalInstituteAddress" 
                                VisibleIndex="32" Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="HospitalInstituteZipCode" 
                                VisibleIndex="33" Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="HospitalInstituteCity" VisibleIndex="34" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="HospitalInstituteCountry" 
                                VisibleIndex="35" Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="HospitalInstitutePOBox" VisibleIndex="36" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="ConferenceRegistrationTypeId" 
                                VisibleIndex="37" Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataCheckColumn FieldName="PreConferenceWorkShopIncluded" 
                                VisibleIndex="38" Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="SubscribeToNewsLetter" VisibleIndex="39" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAAdministrator" VisibleIndex="40" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOARetired" VisibleIndex="41" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAClinicalResearcher" VisibleIndex="42" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOABasicResearcher" VisibleIndex="43" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOATeacherEducator" VisibleIndex="44" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAIndustryRepresentative" 
                                VisibleIndex="45" Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAClinicalPractitioner" 
                                VisibleIndex="46" Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAAlliedHealthProfessional" 
                                VisibleIndex="47" Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAStudent" VisibleIndex="48" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAOther" VisibleIndex="49" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataTextColumn FieldName="AOAOtherText" VisibleIndex="50" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAMCNAcuteKidneyInjury" 
                                VisibleIndex="51" Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAMCNChronicKidneyDisease" 
                                VisibleIndex="52" Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAMCNHypertension" VisibleIndex="53" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAMCNGlomerulonephritis" 
                                VisibleIndex="54" Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAMCNNephrolithiasis" VisibleIndex="55" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAMRRTHemodialysis" VisibleIndex="56" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAMRRTPertionealDialysis" 
                                VisibleIndex="57" Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAMRRTCRRT" VisibleIndex="58" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAMPediatricNephrology" 
                                VisibleIndex="59" Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAMGenetics" VisibleIndex="60" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAMUrology" VisibleIndex="61" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAMMineralMetabolism" VisibleIndex="62" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAMAnemia" VisibleIndex="63" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAMDiabetes" VisibleIndex="64" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAMImmunology" VisibleIndex="65" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAMPathology" VisibleIndex="66" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAMIterventionalCCN" VisibleIndex="67" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="AOAMOther" VisibleIndex="68" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataTextColumn FieldName="AOAMOtherText" VisibleIndex="69" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="SponsorName" VisibleIndex="70" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="DeductedAmount" VisibleIndex="71" 
                                Visible="False">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataCheckColumn FieldName="IsActive" VisibleIndex="72" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="IsMember" VisibleIndex="73" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="IsSelfSponsor" VisibleIndex="74" 
                                Visible="False">
                            </dx:GridViewDataCheckColumn>
                        </Columns>
                        <Templates>
                            <DetailRow>
                                 <dx:ASPxGridView ID="ASPxGridView2" runat="server" AutoGenerateColumns="False" DataSourceID="RegistrationResultObjectDS" KeyFieldName="ConferenceRegistrationItemID" OnBeforePerformDataSelect="ASPxGridView2_BeforePerformDataSelect">
                                        <Columns>
                                            <dx:GridViewCommandColumn VisibleIndex="0">
                                                <DeleteButton Visible="True">
                                                </DeleteButton>
                                            </dx:GridViewCommandColumn>
                                            <dx:GridViewDataTextColumn Caption="ID" FieldName="ConferenceRegistrationItemID" ReadOnly="True" VisibleIndex="1">
                                                <EditFormSettings Visible="False" />
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataComboBoxColumn Caption="Type" FieldName="ConferenceRegistrationTypeID" VisibleIndex="2">
                                                <PropertiesComboBox DataSourceID="ConfRegistrationTypeObjectDS" TextField="Name" ValueField="ConferenceRegistrationTypeId" ValueType="System.Int32">
                                                </PropertiesComboBox>
                                            </dx:GridViewDataComboBoxColumn>
                                            <dx:GridViewDataTextColumn FieldName="ConferenceRegistererId" Visible="False" VisibleIndex="3">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataDateColumn Caption="Date" FieldName="CreatedDate" VisibleIndex="4">
                                            </dx:GridViewDataDateColumn>
                                        </Columns>
                                    </dx:ASPxGridView>
                                    <asp:ObjectDataSource ID="RegistrationResultObjectDS" runat="server" DeleteMethod="Delete" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllByConferenceRegistererId" TypeName="BusinessLogicLayer.Components.Conference.ConferenceRegistrationItemsLogic">
                                        <DeleteParameters>
                                            <asp:Parameter Name="Original_ConferenceRegistrationItemID" Type="Int32" />
                                        </DeleteParameters>
                                        <SelectParameters>
                                            <asp:SessionParameter DefaultValue="0" Name="ConferenceRegistererId" SessionField="ConferenceRegistrerID" Type="Int32" />
                                        </SelectParameters>
                                    </asp:ObjectDataSource>
                            </DetailRow>

                        </Templates>
                         <SettingsBehavior ConfirmDelete="True" />
                <Settings ShowFilterRow="True" ShowGroupPanel="True" />
                <SettingsText ConfirmDelete="Are you sure you want to delete this record?" />
                        <SettingsDetail ShowDetailRow="True" />
                    </dx:ASPxGridView>

                     <asp:ObjectDataSource ID="dsSponsors" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.Conference.SponsorsLogic">
                    </asp:ObjectDataSource>

                     <asp:ObjectDataSource ID="PersonObjectDS" runat="server" OldValuesParameterFormatString="original_{0}"
                SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.Persons.PersonLogic">
            </asp:ObjectDataSource>
             <asp:ObjectDataSource ID="ConferenceObjectDS" runat="server" OldValuesParameterFormatString="original_{0}"
                SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.Conference.ConferencesLogic">
            </asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="dsRegistration" runat="server" DeleteMethod="Delete" 
                        InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
                        SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.Conference.ConferenceRegisterationsLogic" 
                        UpdateMethod="Update">
                        <DeleteParameters>
                            <asp:Parameter Name="Original_ConferenceRegistererId" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="SponsorId" Type="Int32" />
                            <asp:Parameter Name="PersonId" Type="Int32" />
                            <asp:Parameter Name="ConferenceId" Type="Int32" />
                            <asp:Parameter Name="DateRegistered" Type="DateTime" />
                            <asp:Parameter Name="DiscountAmount" Type="Decimal" />
                            <asp:Parameter Name="AmountPaid" Type="Decimal" />
                            <asp:Parameter Name="DiscountReason" Type="String" />
                            <asp:Parameter Name="RegitrationCategory" Type="String" />
                            <asp:Parameter Name="LicenseNumber" Type="String" />
                            <asp:Parameter Name="Address" Type="String" />
                            <asp:Parameter Name="POBox" Type="String" />
                            <asp:Parameter Name="ZipCode" Type="String" />
                            <asp:Parameter Name="City" Type="String" />
                            <asp:Parameter Name="Country" Type="String" />
                            <asp:Parameter Name="PhoneNumberCountryCode" Type="String" />
                            <asp:Parameter Name="PhoneNumberAreaCode" Type="String" />
                            <asp:Parameter Name="PhoneNumber" Type="String" />
                            <asp:Parameter Name="FaxNumberCountryCode" Type="String" />
                            <asp:Parameter Name="FaxNumberAreaCode" Type="String" />
                            <asp:Parameter Name="FaxNumber" Type="String" />
                            <asp:Parameter Name="MobileNumberCountryCode" Type="String" />
                            <asp:Parameter Name="MobileNumberAreaCode" Type="String" />
                            <asp:Parameter Name="MobileNumber" Type="String" />
                            <asp:Parameter Name="Email" Type="String" />
                            <asp:Parameter Name="AcademicInformationPosition" Type="String" />
                            <asp:Parameter Name="AcademicInformationDegree" Type="String" />
                            <asp:Parameter Name="AcademicInformationHealthCarePro" Type="Boolean" />
                            <asp:Parameter Name="AcademicInformationHealthCareProValue" Type="String" />
                            <asp:Parameter Name="HospitalInstituteName" Type="String" />
                            <asp:Parameter Name="HospitalInstituteDepartment" Type="String" />
                            <asp:Parameter Name="HospitalInstituteAddress" Type="String" />
                            <asp:Parameter Name="HospitalInstituteZipCode" Type="String" />
                            <asp:Parameter Name="HospitalInstituteCity" Type="String" />
                            <asp:Parameter Name="HospitalInstituteCountry" Type="String" />
                            <asp:Parameter Name="HospitalInstitutePOBox" Type="String" />
                            <asp:Parameter Name="ConferenceRegistrationTypeId" Type="Int32" />
                            <asp:Parameter Name="PreConferenceWorkShopIncluded" Type="Boolean" />
                            <asp:Parameter Name="SubscribeToNewsLetter" Type="Boolean" />
                            <asp:Parameter Name="AOAAdministrator" Type="Boolean" />
                            <asp:Parameter Name="AOARetired" Type="Boolean" />
                            <asp:Parameter Name="AOAClinicalResearcher" Type="Boolean" />
                            <asp:Parameter Name="AOABasicResearcher" Type="Boolean" />
                            <asp:Parameter Name="AOATeacherEducator" Type="Boolean" />
                            <asp:Parameter Name="AOAIndustryRepresentative" Type="Boolean" />
                            <asp:Parameter Name="AOAClinicalPractitioner" Type="Boolean" />
                            <asp:Parameter Name="AOAAlliedHealthProfessional" Type="Boolean" />
                            <asp:Parameter Name="AOAStudent" Type="Boolean" />
                            <asp:Parameter Name="AOAOther" Type="Boolean" />
                            <asp:Parameter Name="AOAOtherText" Type="String" />
                            <asp:Parameter Name="AOAMCNAcuteKidneyInjury" Type="Boolean" />
                            <asp:Parameter Name="AOAMCNChronicKidneyDisease" Type="Boolean" />
                            <asp:Parameter Name="AOAMCNHypertension" Type="Boolean" />
                            <asp:Parameter Name="AOAMCNGlomerulonephritis" Type="Boolean" />
                            <asp:Parameter Name="AOAMCNNephrolithiasis" Type="Boolean" />
                            <asp:Parameter Name="AOAMRRTHemodialysis" Type="Boolean" />
                            <asp:Parameter Name="AOAMRRTPertionealDialysis" Type="Boolean" />
                            <asp:Parameter Name="AOAMRRTCRRT" Type="Boolean" />
                            <asp:Parameter Name="AOAMPediatricNephrology" Type="Boolean" />
                            <asp:Parameter Name="AOAMGenetics" Type="Boolean" />
                            <asp:Parameter Name="AOAMUrology" Type="Boolean" />
                            <asp:Parameter Name="AOAMMineralMetabolism" Type="Boolean" />
                            <asp:Parameter Name="AOAMAnemia" Type="Boolean" />
                            <asp:Parameter Name="AOAMDiabetes" Type="Boolean" />
                            <asp:Parameter Name="AOAMImmunology" Type="Boolean" />
                            <asp:Parameter Name="AOAMPathology" Type="Boolean" />
                            <asp:Parameter Name="AOAMIterventionalCCN" Type="Boolean" />
                            <asp:Parameter Name="AOAMOther" Type="Boolean" />
                            <asp:Parameter Name="AOAMOtherText" Type="String" />
                            <asp:Parameter Name="SponsorName" Type="String" />
                            <asp:Parameter Name="DeductedAmount" Type="Decimal" />
                            <asp:Parameter Name="IsActive" Type="Boolean" />
                            <asp:Parameter Name="IsMember" Type="Boolean" />
                            <asp:Parameter Name="IsSelfSponsor" Type="Boolean" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="SponsorId" Type="Int32" />
                            <asp:Parameter Name="PersonId" Type="Int32" />
                            <asp:Parameter Name="ConferenceId" Type="Int32" />
                            <asp:Parameter Name="DateRegistered" Type="DateTime" />
                            <asp:Parameter Name="DiscountAmount" Type="Decimal" />
                            <asp:Parameter Name="AmountPaid" Type="Decimal" />
                            <asp:Parameter Name="DiscountReason" Type="String" />
                            <asp:Parameter Name="RegitrationCategory" Type="String" />
                            <asp:Parameter Name="LicenseNumber" Type="String" />
                            <asp:Parameter Name="Address" Type="String" />
                            <asp:Parameter Name="POBox" Type="String" />
                            <asp:Parameter Name="ZipCode" Type="String" />
                            <asp:Parameter Name="City" Type="String" />
                            <asp:Parameter Name="Country" Type="String" />
                            <asp:Parameter Name="PhoneNumberCountryCode" Type="String" />
                            <asp:Parameter Name="PhoneNumberAreaCode" Type="String" />
                            <asp:Parameter Name="PhoneNumber" Type="String" />
                            <asp:Parameter Name="FaxNumberCountryCode" Type="String" />
                            <asp:Parameter Name="FaxNumberAreaCode" Type="String" />
                            <asp:Parameter Name="FaxNumber" Type="String" />
                            <asp:Parameter Name="MobileNumberCountryCode" Type="String" />
                            <asp:Parameter Name="MobileNumberAreaCode" Type="String" />
                            <asp:Parameter Name="MobileNumber" Type="String" />
                            <asp:Parameter Name="Email" Type="String" />
                            <asp:Parameter Name="AcademicInformationPosition" Type="String" />
                            <asp:Parameter Name="AcademicInformationDegree" Type="String" />
                            <asp:Parameter Name="AcademicInformationHealthCarePro" Type="Boolean" />
                            <asp:Parameter Name="AcademicInformationHealthCareProValue" Type="String" />
                            <asp:Parameter Name="HospitalInstituteName" Type="String" />
                            <asp:Parameter Name="HospitalInstituteDepartment" Type="String" />
                            <asp:Parameter Name="HospitalInstituteAddress" Type="String" />
                            <asp:Parameter Name="HospitalInstituteZipCode" Type="String" />
                            <asp:Parameter Name="HospitalInstituteCity" Type="String" />
                            <asp:Parameter Name="HospitalInstituteCountry" Type="String" />
                            <asp:Parameter Name="HospitalInstitutePOBox" Type="String" />
                            <asp:Parameter Name="ConferenceRegistrationTypeId" Type="Int32" />
                            <asp:Parameter Name="PreConferenceWorkShopIncluded" Type="Boolean" />
                            <asp:Parameter Name="SubscribeToNewsLetter" Type="Boolean" />
                            <asp:Parameter Name="AOAAdministrator" Type="Boolean" />
                            <asp:Parameter Name="AOARetired" Type="Boolean" />
                            <asp:Parameter Name="AOAClinicalResearcher" Type="Boolean" />
                            <asp:Parameter Name="AOABasicResearcher" Type="Boolean" />
                            <asp:Parameter Name="AOATeacherEducator" Type="Boolean" />
                            <asp:Parameter Name="AOAIndustryRepresentative" Type="Boolean" />
                            <asp:Parameter Name="AOAClinicalPractitioner" Type="Boolean" />
                            <asp:Parameter Name="AOAAlliedHealthProfessional" Type="Boolean" />
                            <asp:Parameter Name="AOAStudent" Type="Boolean" />
                            <asp:Parameter Name="AOAOther" Type="Boolean" />
                            <asp:Parameter Name="AOAOtherText" Type="String" />
                            <asp:Parameter Name="AOAMCNAcuteKidneyInjury" Type="Boolean" />
                            <asp:Parameter Name="AOAMCNChronicKidneyDisease" Type="Boolean" />
                            <asp:Parameter Name="AOAMCNHypertension" Type="Boolean" />
                            <asp:Parameter Name="AOAMCNGlomerulonephritis" Type="Boolean" />
                            <asp:Parameter Name="AOAMCNNephrolithiasis" Type="Boolean" />
                            <asp:Parameter Name="AOAMRRTHemodialysis" Type="Boolean" />
                            <asp:Parameter Name="AOAMRRTPertionealDialysis" Type="Boolean" />
                            <asp:Parameter Name="AOAMRRTCRRT" Type="Boolean" />
                            <asp:Parameter Name="AOAMPediatricNephrology" Type="Boolean" />
                            <asp:Parameter Name="AOAMGenetics" Type="Boolean" />
                            <asp:Parameter Name="AOAMUrology" Type="Boolean" />
                            <asp:Parameter Name="AOAMMineralMetabolism" Type="Boolean" />
                            <asp:Parameter Name="AOAMAnemia" Type="Boolean" />
                            <asp:Parameter Name="AOAMDiabetes" Type="Boolean" />
                            <asp:Parameter Name="AOAMImmunology" Type="Boolean" />
                            <asp:Parameter Name="AOAMPathology" Type="Boolean" />
                            <asp:Parameter Name="AOAMIterventionalCCN" Type="Boolean" />
                            <asp:Parameter Name="AOAMOther" Type="Boolean" />
                            <asp:Parameter Name="AOAMOtherText" Type="String" />
                            <asp:Parameter Name="SponsorName" Type="String" />
                            <asp:Parameter Name="DeductedAmount" Type="Decimal" />
                            <asp:Parameter Name="IsActive" Type="Boolean" />
                            <asp:Parameter Name="IsMember" Type="Boolean" />
                            <asp:Parameter Name="IsSelfSponsor" Type="Boolean" />
                            <asp:Parameter Name="Original_ConferenceRegistererId" Type="Int32" />
                        </UpdateParameters>
                    </asp:ObjectDataSource>
                    
                    <asp:ObjectDataSource ID="ConfRegistrationTypeObjectDS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.Conference.ConferenceRegistrationTypeLogic"></asp:ObjectDataSource>
                    
                </div>
                </div>
                </div>
</asp:Content>
