<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master"
    AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="SocioBuilderSite.Conference.Register" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxUploadControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxSpellChecker.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxSpellChecker" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxClasses" TagPrefix="dx" %>
<%@ Register Src="~/Conference/Controls/ProfileInformation.ascx" TagName="ProfileInformationControl" TagPrefix="Rbm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="Scripts/JSON.js"></script>
    <script type="text/javascript" src="Scripts/dxWizard.js"></script>
    <script type="text/javascript">
        function SetConfirmationDisplay() {
            var mobile = '';
            var address = '';
            var name = '';
            var email = '';

            if (WizardHidden.Get('IsInEdit')) {
                mobile = ContactMobileNumberTextClient.GetText();
                address = ContactCountryComboClient.GetText();// + ' ' + ContactCityTextClient.GetText();
                name = ContactFirstNameTextClient.GetText();// + ' ' + ContactLastNameTextClient.GetText();
                email = ContactEmailTextClient.GetText();
            }
            else {
                mobile = WizardHidden.Get('Mobile');
                address = WizardHidden.Get('Address');
                name = WizardHidden.Get('FullName');
                email = WizardHidden.Get('Email');
            }
            
            ConfirmFullName.SetText(name);
            ConfirmAddress.SetText(address);
            ConfirmMobile.SetText(mobile);
            ConfirmEmail.SetText(email);
            
            
            
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <dx:ASPxHiddenField ID="WizardHidden" ClientInstanceName="WizardHidden"
        runat="server" SyncWithServer="true" ViewStateMode="Enabled">
    </dx:ASPxHiddenField>
    <h1>
        <asp:Literal ID="Literal1" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_Title %>'></asp:Literal></h1>
    <br />
     
    <div class="mainContent registration">
        <dx:ASPxPageControl ID="pc" ClientInstanceName="pc" runat="server" ActiveTabIndex="0"
            Width="100%" OnInit="pc_Init" CssClass="pageControl" EnableDefaultAppearance="False"
            LoadingPanelText="" OnBeforeGetCallbackResult="pc_BeforeGetCallbackResult">
            <ClientSideEvents ActiveTabChanged="UpdateButtonsEnabled" ActiveTabChanging="OnActiveTabChanging" />
            <Paddings Padding="0px" />
            <TabPages>
                <dx:TabPage Text='<%$Resources:ConferenceFront, RegistrationForm_RegistrarInformation %>'
                    Name="RegisterationPersonal">
                        <ContentCollection>
                        <dx:ContentControl ID="ContentControlPersonalInfo" runat="server" SupportsDisabledAttribute="True">
                            <div class="registration-container">
                            <Rbm:ProfileInformationControl runat="server" ID="ProfileInformation1" />
                            </div>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage ClientEnabled="False" Name="RegisterationWorkOrganization" Text='<%$Resources:ConferenceFront, RegistrationForm_HospitalInstitude %>'>
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControlWorkOrganization" runat="server" SupportsDisabledAttribute="True">
                            <div class="registration-container">
                      
                <fieldset style="width:100%;">
                     <legend><asp:Literal ID="Literal11" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_HospitalInstitude %>' ></asp:Literal></legend>
                     <div class="rbmContactDetailsTable">
                  <table>
                    <tr>
                      <td class="rbmContactInfoLabel"><asp:Literal ID="Literal12" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_HospitalName %>' ></asp:Literal></td>
                      <td>
                      <dx:ASPxTextBox ID="RegistrationHospitalName" runat="server"  Width="250px">
                      <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="WizardValidation" 
                                 ErrorDisplayMode="None" ErrorTextPosition="Right">
                                 <RequiredField IsRequired="True" />
<RequiredField IsRequired="True"></RequiredField>
                             </ValidationSettings>
                                </dx:ASPxTextBox>
                      </td>
                    </tr>
                    <tr>
                      <td class="rbmContactInfoLabel"><asp:Literal ID="Literal13" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_HospitalDepartment %>' ></asp:Literal></td>
                      <td>
                      <dx:ASPxTextBox ID="RegistrationHospitalDepartment" runat="server"  Width="250px">
                      <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="WizardValidation" 
                                 ErrorDisplayMode="None" ErrorTextPosition="Right">
                                 <RequiredField IsRequired="True" />
<RequiredField IsRequired="True"></RequiredField>
                             </ValidationSettings>
                                </dx:ASPxTextBox>
                      </td>
                    </tr>
                    <tr>
                      <td class="rbmContactInfoLabel"><asp:Literal ID="Literal14" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_HospitalAddress %>' ></asp:Literal></td>
                      <td>
                      <dx:ASPxTextBox ID="RegistrationHospitalAddress" runat="server"  Width="250px">
                      <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="WizardValidation" 
                                 ErrorDisplayMode="None" ErrorTextPosition="Right">
                                 <RequiredField IsRequired="True" />
<RequiredField IsRequired="True"></RequiredField>
                             </ValidationSettings>
                                </dx:ASPxTextBox>
                      </td>
                    </tr>
                  </table>
                  </div>
              </fieldset>
               <p>&nbsp;</p>
                            </div>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage ClientEnabled="False" Name="RegisterationOptions" Text='<%$Resources:ConferenceFront, RegistrationForm_Tab3 %>'>
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControlRegisterationOptions" runat="server" SupportsDisabledAttribute="True">
                            <div class="registration-container">
                            <div style="width:90%;margin:10px;">
<asp:Literal runat="server" ID="RegistrationForm_Pre"></asp:Literal>
<asp:Panel runat="server" id="ResultsAreas">

</asp:Panel>
<asp:Literal runat="server" ID="RegistrationForm_Post"></asp:Literal>
<%--<asp:Literal runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_Information %>'></asp:Literal>--%>
</div>
                            </div>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage ClientEnabled="False" Text='<%$Resources:ConferenceFront, RegistrationForm_Confirmation %>'
                    Name="RegisterationConfirmation">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControlConfirmation" runat="server" SupportsDisabledAttribute="True">
                            
                             <div class="registration-container">
                             <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text='<%$Resources:ConferenceFront, Registeration_ConfirmTitle %>' EnableDefaultAppearance="false" ForeColor="#FF5400" Font-Size="24px"></dx:ASPxLabel> 
                                            <div class="confirm-main-information">
                                                <table>
                                                    <tr>
                                                        <td style="width:120px;font-size:12px"><asp:Literal ID="Literal2" runat="server" Text='<%$Resources:ConferenceFront, Registeration_ConfirmFullName %>'></asp:Literal> </td>
                                                        <td><dx:ASPxLabel ID="ConfirmFullName" ClientInstanceName="ConfirmFullName" runat="server"></dx:ASPxLabel></td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width:120px;font-size:12px"><asp:Literal ID="Literal3" runat="server" Text='<%$Resources:ConferenceFront, Registeration_ConfirmAddress %>'></asp:Literal> </td>
                                                        <td><dx:ASPxLabel ID="ConfirmAddress" ClientInstanceName="ConfirmAddress" runat="server"></dx:ASPxLabel></td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width:120px;font-size:12px"><asp:Literal ID="Literal4" runat="server" Text='<%$Resources:ConferenceFront, Registeration_ConfirmBusinessPhone %>'></asp:Literal> </td>
                                                        <td><dx:ASPxLabel ID="ConfirmMobile" ClientInstanceName="ConfirmMobile" runat="server"></dx:ASPxLabel> </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width:120px;font-size:12px"><asp:Literal ID="Literal6" runat="server" Text='<%$Resources:ConferenceFront, Registeration_ConfirmEmail %>'></asp:Literal> </td>
                                                        <td><dx:ASPxLabel ID="ConfirmEmail" ClientInstanceName="ConfirmEmail" runat="server"></dx:ASPxLabel> </td>
                                                    </tr>
                                                    
                                                </table>
                                                <br />
                                            </div>
                                            <div class="clear"></div>
                            <dx:ASPxCallbackPanel ID="callbackConfirmationPreview" ClientInstanceName="callbackConfirmationPreview"  runat="server" Width="100%" OnCallback="callbackConfirmationPreview_Callback">
                                <PanelCollection>
                                    <dx:PanelContent>
                                        <div class="confirm-registration">
                                            
                                           
                                            <div runat="server" class="confirm-review-registration" id="PreviewRegistration">

                                            </div>
                                        </div>
                                    </dx:PanelContent>
                                </PanelCollection>
                                </dx:ASPxCallbackPanel>
                                                           
        <div class="clear"></div>
                                <dx:ASPxCheckBox runat="server" Width="300px" Text='<%$Resources:ConferenceFront, RegistrationForm_ConfirmMessage %>' OnValidation="RegistrationMedicalDoctorsCheck_Validation" id="RegistrationMedicalDoctorsCheck" Font-Bold="true" Font-Size="16px">
                                <ValidationSettings SetFocusOnError="true" CausesValidation="true" Display="Dynamic" ErrorDisplayMode="Text" RequiredField-ErrorText="*" RequiredField-IsRequired="true" ValidationGroup="WizardValidation" >
                                
<RequiredField IsRequired="True" ErrorText="*"></RequiredField>
                                    </ValidationSettings>
                                </dx:ASPxCheckBox>
                                </div>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>

                
            </TabPages>

            <ActiveTabTemplate>
                <evento:SelectedTab ID="SelectedTab1" runat="server" />
            </ActiveTabTemplate>
            <TabTemplate>
                <evento:UnselectedTab ID="UnselectedTab1" runat="server" />
            </TabTemplate>

<ClientSideEvents ActiveTabChanged="UpdateButtonsEnabled" 
                ActiveTabChanging="OnActiveTabChanging"></ClientSideEvents>

<Paddings Padding="0px"></Paddings>

            <TabStyle>
                <Paddings Padding="0px" />
                <BorderBottom BorderStyle="None" BorderWidth="0px" />
<Paddings Padding="0px"></Paddings>

<BorderBottom BorderStyle="None" BorderWidth="0px"></BorderBottom>
            </TabStyle>
        </dx:ASPxPageControl>
        <div class="clear">
        </div>
        <br />
        <div class="buttonsArea">
            <div class="buttons">
                <table cellpadding="0" cellspacing="0" border="0" class="buttonsTable">
                    <tr>
                        <td>
                            <dx:ASPxButton ID="btnBack" ClientInstanceName="btnBack" runat="server" ValidationGroup="WizardValidation"
                                Text='<%$Resources:ConferenceFront, RegistrationForm_Back %>' AutoPostBack="false"
                                ClientVisible="false" CausesValidation="true" UseSubmitBehavior="False">
                                <ClientSideEvents Click="OnBackButtonClick" />
                            </dx:ASPxButton>
                        </td>
                        <td>
                            
                            <dx:ASPxButton ID="btnNext" ClientInstanceName="btnNext" runat="server" ValidationGroup="WizardValidation"
                                Text='<%$Resources:ConferenceFront, RegistrationForm_Next %>' AutoPostBack="false"
                                CausesValidation="true" UseSubmitBehavior="true">
                                <ClientSideEvents Click="OnNextButtonClick" />
                            </dx:ASPxButton>
                        </td>
                        <td>
                            <%--<asp:Button runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_Submit %>' ID="" ValidationGroup="WizardValidation" OnClick="btnFinish_Click" />--%>
                            <dx:ASPxButton ID="btnFinish" ClientInstanceName="btnFinish" runat="server" ValidationGroup="WizardValidation"
                                Text='<%$Resources:ConferenceFront, RegistrationForm_Submit %>' OnClick="btnFinish_Click"
                                ClientVisible="false">
                                <%--<ClientSideEvents Click="OnFinishButtonClick" />--%>
                            </dx:ASPxButton>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="clear">
        </div>
    </div>
</asp:Content>
