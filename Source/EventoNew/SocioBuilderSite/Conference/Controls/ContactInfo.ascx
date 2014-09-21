<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContactInfo.ascx.cs" Inherits="SocioBuilderSite.Conference.Controls.ContactInfo" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxUploadControl" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
       <script type="text/javascript">
           function UploaderProfile_OnUploadComplete(args) {
               if (args.isValid) {
                   //$('#currentProfileImage').attr('src', '../ContentData/Persons/' + args.callbackData);
                   currentProfileImage.SetImageUrl(args.callbackData);
                   //            txtImageUploadPath.SetText(args.callbackData);
                   //lblIconPath.SetText(args.callbackData);
               }
           }
</script>
<div runat="server" id="ContactInfoSignup" class="register-new-form">
                
    <table class="rbmContactInfoTable">
        <tr>
            <td class="rbmContactInfoLabelNew">
                <asp:Literal ID="Literal1" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_Email %>' ></asp:Literal><span class="notice-required">&nbsp;</span>
            </td>
            <td>
                <dx:ASPxTextBox runat="server" ClientInstanceName="ContactEmailTextClient" ID="ContactEmailText" onvalidation="ContactEmailText_Validation">
                    <ValidationSettings CausesValidation="True" ValidationGroup="WizardValidation" Display="Dynamic" 
                        ErrorDisplayMode="Text">
                        <RequiredField ErrorText='<%$Resources:ConferenceFront, ContactInfo_EnterEmail %>' IsRequired="True" />
                    </ValidationSettings>
                </dx:ASPxTextBox>
            </td>
        </tr>
        <tr runat="server" id="PasswordRow">
            <td class="rbmContactInfoLabelNew">
                <asp:Literal ID="Literal2" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_Password %>' ></asp:Literal><span class="notice-required">&nbsp;</span>
            </td>
            <td>
                <dx:ASPxTextBox ID="ContactPasswordText" runat="server"  Password="true" 
                    ClientInstanceName="PasswordText">
                    
                         <ClientSideEvents Validation="function(s, e) {
	var confirmpass = new String(PasswordText.GetText());
	if(confirmpass.length &lt; 6)
	{
		e.isValid = false;
		e.errorText = 'Password must be at least 6 characters';
	}
	else
	{
		e.isValid = true;
	}
	ConfirmPasswordText.Validate();

}" />
<ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="WizardValidation"
                                 ErrorDisplayMode="None" ErrorTextPosition="Right" 
                                 EnableCustomValidation="True">
                                 <RequiredField ErrorText='<%$Resources:ConferenceFront, ContactInfo_PasswordError %>' IsRequired="True" />
                             </ValidationSettings>
                </dx:ASPxTextBox>
            </td>
        </tr>
        <tr runat="server" id="ConfirmPasswordRow">
            <td class="rbmContactInfoLabelNew">
                <asp:Literal ID="Literal3" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_ConfirmPassword %>' ></asp:Literal>
            </td>
            <td>
                <dx:ASPxTextBox ID="ContactConfirmPassword" runat="server" Password="true" 
                    ClientInstanceName="ConfirmPasswordText">
                    
                      <ClientSideEvents Validation="function(s, e) {
	var confirmpass = new String(ConfirmPasswordText.GetText());
	var pass = new String(PasswordText.GetText());
	if(pass.length != 0)
	{
    
	if(ConfirmPasswordText.GetText() != PasswordText.GetText())
	{
		e.isValid = false;
		e.errorText = 'Password and Confirm Password Must Match';
	}
	else
	{
		e.isValid = true;
	}
	}
	
}" />
                             <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="WizardValidation"
                                 ErrorDisplayMode="None" ErrorTextPosition="Right" 
                                 EnableCustomValidation="True">
                                 <RequiredField ErrorText='<%$Resources:ConferenceFront, ContactInfo_EnterConfirmPassword %>' IsRequired="True" />
                             </ValidationSettings>
                </dx:ASPxTextBox>
            </td>
        </tr>
    </table>
    <table class="rbmContactDetailsTable">
        <tr>
                <td class="rbmContactInfoLabelNew"><asp:Literal ID="Literal4" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_Title %>' ></asp:Literal><span class="notice-required">&nbsp;</span></td>
                <td>
                <dx:ASPxComboBox ID="ContactTitle" runat="server" SelectedIndex="0" ClientInstanceName="ContactTitleComboClient" 
                                    ValueType="System.String" ItemImage-Height="10px" Width="100px" 
                        ItemImage-Width="0px" DropDownStyle="DropDown"
                                   >
                                    <Items>
                                        <dx:ListEditItem Text='<%$Resources:ConferenceFront, ContactInfo_TitleDr %>' Value="0" />
                                        <dx:ListEditItem Text='<%$Resources:ConferenceFront, ContactInfo_TitleProf %>' Value="1" />
                                        <dx:ListEditItem Text='<%$Resources:ConferenceFront, ContactInfo_TitleMr %>' Value="2" />
                                        <dx:ListEditItem Text='<%$Resources:ConferenceFront, ContactInfo_TitleMiss %>' Value="3" />
                                        <dx:ListEditItem Text='<%$Resources:ConferenceFront, ContactInfo_TitleMrs %>' Value="4" />
                                        <dx:ListEditItem Text='<%$Resources:ConferenceFront, ContactInfo_TitleMs %>' Value="5" />
                                    </Items>
                        
                                    <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="WizardValidation" 
                                 ErrorDisplayMode="None" ErrorTextPosition="Right">
                                 <RequiredField ErrorText='<%$Resources:ConferenceFront, ContactInfo_EnterTitle %>' IsRequired="True" />
                             </ValidationSettings>
                                </dx:ASPxComboBox>
                </td>
                <td class="rbmContactInfoLabel"><asp:Literal ID="Literal8" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_Gender %>' ></asp:Literal></td>
                <td>
                    <dx:ASPxRadioButtonList ID="ContactGender" 
                                             runat="server" RepeatColumns="2" 
                                            Width="205px" SelectedIndex ="0">
                                            <Items>
                                                <dx:ListEditItem Text='<%$Resources:ConferenceFront, ContactInfo_GenderMale %>' Value="M" />
                                                <dx:ListEditItem Text='<%$Resources:ConferenceFront, ContactInfo_GenderFemale %>' Value="F" />
                                            </Items>
                                            <Border BorderStyle="None" />
                                        </dx:ASPxRadioButtonList>
                </td>
            </tr>
        <tr>
                <td class="rbmContactInfoLabelNew"><asp:Literal ID="Literal5" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_Name %>' ></asp:Literal><span class="notice-required">&nbsp;</span></td>
                <td>
                    <dx:ASPxTextBox ID="ContactFirstName" runat="server" ClientInstanceName="ContactFirstNameTextClient" NullText='<%$Resources:ConferenceFront, ContactInfo_FirstName %>' Width="160px" >
                    <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="WizardValidation" 
                                 ErrorDisplayMode="None" ErrorTextPosition="Bottom">
                                 <RequiredField ErrorText='<%$Resources:ConferenceFront, ContactInfo_EnterFirstName %>' IsRequired="True" />
                             </ValidationSettings>
                </dx:ASPxTextBox>
                </td>
                <td>
                 <dx:ASPxTextBox ID="ContactMiddleName" runat="server" NullText='<%$Resources:ConferenceFront, ContactInfo_MiddleName %>' Width="160px">
                </dx:ASPxTextBox>
                </td>
                <td>
                <dx:ASPxTextBox ID="ContactLastName" runat="server" ClientInstanceName="ContactLastNameTextClient" NullText='<%$Resources:ConferenceFront, ContactInfo_LastName %>' Width="160px" >
                    <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="WizardValidation" 
                                 ErrorDisplayMode="None" ErrorTextPosition="Bottom">
                                 <RequiredField ErrorText='<%$Resources:ConferenceFront, ContactInfo_EnterLastName %>' IsRequired="True" />
                             </ValidationSettings>
                </dx:ASPxTextBox>
                </td>
            </tr>
        
        <tr>
            <td class="rbmContactInfoLabelNew"><asp:Literal ID="Literal10" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_Address %>' ></asp:Literal></td>
                <td colspan="3">
                    <dx:ASPxTextBox ID="ContactAddress" runat="server" Width="92%">
                </dx:ASPxTextBox>
                </td>
        </tr>
        <tr>
            <td></td>
            <td>
                    <dx:ASPxTextBox ID="ContactPOBox" runat="server" Width="160px" NullText='<%$Resources:ConferenceFront, ContactInfo_POBox %>'>
                </dx:ASPxTextBox>
                </td>
                <td>
                <dx:ASPxTextBox ID="ContactZipCode" runat="server" Width="160px" NullText='<%$Resources:ConferenceFront, ContactInfo_ZipCode %>' >
                </dx:ASPxTextBox>
                </td>
                <td>
                 <dx:ASPxTextBox ID="ContactCity" ClientInstanceName="ContactCityTextClient" runat="server" Width="160px" NullText='<%$Resources:ConferenceFront, ContactInfo_City %>' >   
                </dx:ASPxTextBox>
                </td>
        </tr>
        <tr>
           <td class="rbmContactInfoLabelNew"><asp:Literal ID="Literal14" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_Country %>' ></asp:Literal></td>
                <td>
                     <dx:ASPxComboBox ID="ContactCountry" ClientInstanceName="ContactCountryComboClient" runat="server" SelectedIndex="0" Width="160px"  
                                    ValueType="System.String"  ItemImage-Height="10px" 
                         ItemImage-Width="0px" DataSourceID="CountryObjectDS" 
                         IncrementalFilteringMode="Contains" TextField="Name" ValueField="CountryRegionCode"
                                   >
                                   <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="WizardValidation"
                                 ErrorDisplayMode="None" ErrorTextPosition="Right" 
                                 EnableCustomValidation="True">
                             </ValidationSettings>
                                </dx:ASPxComboBox>
                     <asp:ObjectDataSource ID="CountryObjectDS" runat="server" 
                         OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                         TypeName="BusinessLogicLayer.Components.Persons.CountryRegionLogic">
                     </asp:ObjectDataSource>
                </td>
            <td class="rbmContactInfoLabelNew"><asp:Literal ID="Literal9" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_DateofBirth %>' ></asp:Literal></td>
                <td>
                    <dx:ASPxDateEdit ID="ContactDateofBirth" runat="server" Width="160px">
                    </dx:ASPxDateEdit>
                </td>
                
        </tr>
        <tr>
            <td class="rbmContactInfoLabelNew">
            <asp:Literal ID="Literal15" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_PhoneNumber %>' ></asp:Literal> / <asp:Literal ID="Literal18" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_FaxNumber %>' ></asp:Literal> / <asp:Literal ID="Literal21" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_MobileNumber %>' ></asp:Literal>
            </td>
            <td>
             <dx:ASPxTextBox ID="ContactPhoneNumber" runat="server" Width="160px" NullText='<%$Resources:ConferenceFront, ContactInfo_PhoneNumber %>' >
                                           <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="WizardValidation" 
                                 ErrorDisplayMode="None" ErrorTextPosition="Right">
                                 <RequiredField ErrorText='<%$Resources:ConferenceFront, ContactInfo_EnterPhone %>' IsRequired="True" />
                             </ValidationSettings>
                                            
                                </dx:ASPxTextBox>
            </td>
            <td>
            <dx:ASPxTextBox ID="ContactFaxNumber" runat="server" Width="160px" NullText='<%$Resources:ConferenceFront, ContactInfo_FaxNumber %>'>
                                </dx:ASPxTextBox>
            </td>
            <td>
             
             <dx:ASPxTextBox ID="ContactMobileNumber" ClientInstanceName="ContactMobileNumberTextClient" runat="server" NullText='<%$Resources:ConferenceFront, ContactInfo_MobileNumber %>' Width="160px" >
             
                                            <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                                ErrorDisplayMode="None" ValidationGroup="WizardValidation">
                                                <RequiredField ErrorText='<%$Resources:ConferenceFront, ContactInfo_EnterMobileNumber %>' IsRequired="True" />
                                            </ValidationSettings>
                                            
                                </dx:ASPxTextBox>
            </td>
        </tr>
        <tr>
             <td class="rbmContactInfoLabelNew"><asp:Literal ID="Literal24" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_ProfileImage %>' ></asp:Literal></td>
                <td colspan="3">
                    <dx:ASPxUploadControl ID="profileLogoUpload" ClientInstanceName="profileLogoUpload"  
                                runat="server" ShowProgressPanel="True"  OnFileUploadComplete="profileLogoUpload_FileUploadComplete">
                                <ClientSideEvents FileUploadComplete="function(s, e) {
	UploaderProfile_OnUploadComplete(e);
}" />
 <ValidationSettings AllowedFileExtensions=".jpg,.jpeg,.jpe,.gif,.png">
                                            </ValidationSettings>
                            </dx:ASPxUploadControl>
                </td>
        </tr>
    </table>

</div>