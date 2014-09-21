<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContactInfo.ascx.cs" Inherits="SocioBuilderSite.Controls.Conference.ContactInfo" %>
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
   <style type="text/css">
    
   </style>
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
   <div runat="server" id="ContactInfoSignup">
   <div class="rbmContactDetailsTable" style="display:none;">
    <table style="width:100%;">
        <tr>
            <td>
                <dx:ASPxValidationSummary Visible="false" ID="ASPxValidationSummary1" runat="server" Paddings-PaddingBottom="20px"  
                        ValidationGroup="ContactInfoGroup" BackColor="#FBE3E4" 
                        ShowErrorsInEditors="True" Width="100%" HeaderText="Missing Information">
                        <HeaderStyle Font-Bold="False" Font-Size="16px" />
                        <Border BorderColor="#FBC2C4" BorderStyle="Solid" BorderWidth="2px" />
                    </dx:ASPxValidationSummary>
            </td>
        </tr>
    </table>
   </div>
   <div class="rbmContactInfoTable">
    <div class="rbmContactInfoTableInner">
    <table >
        <tr>
            <td class="rbmContactInfoLabel"><asp:Literal ID="Literal1" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_Email %>' ></asp:Literal><span class="notice-required">&nbsp;</span></td>
            <td >
                <dx:ASPxTextBox ID="ContactEmailText" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887" 
                    onvalidation="ContactEmailText_Validation" >
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" />
               <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="ContactInfoGroup" 
                                 ErrorDisplayMode="Text" ErrorTextPosition="Right" 
                        EnableCustomValidation="True">
                                 <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText='<%$Resources:ConferenceFront, ContactInfo_EnterEmail %>' IsRequired="True" />
                             </ValidationSettings>
                </dx:ASPxTextBox>
            </td>
        </tr>
        <tr runat="server" id="PasswordRow">
            <td class="rbmContactInfoLabel">
                <asp:Literal ID="Literal2" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_Password %>' ></asp:Literal><span class="notice-required">&nbsp;</span>
            </td>
            <td>
                <dx:ASPxTextBox ID="ContactPasswordText" runat="server" Width="250px" Password="true" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="16px" ForeColor="#667887"  ClientInstanceName="PasswordText">
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" />
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
                             <ValidationSettings CausesValidation="True" Display="Dynamic"  ValidationGroup="ContactInfoGroup"
                                 ErrorDisplayMode="Text" ErrorTextPosition="Right" 
                                 EnableCustomValidation="True">
                                 <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText='<%$Resources:ConferenceFront, ContactInfo_PasswordError %>' IsRequired="True" />
                             </ValidationSettings>
                </dx:ASPxTextBox>
            </td>
        </tr>
        <tr runat="server" id="ConfirmPasswordRow">
            <td class="rbmContactInfoLabel">
                <asp:Literal ID="Literal3" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_ConfirmPassword %>' ></asp:Literal>
            </td>
            <td>
                <dx:ASPxTextBox ID="ContactConfirmPassword" runat="server" Width="250px" Password="true" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="16px" ForeColor="#667887" ClientInstanceName="ConfirmPasswordText">
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" />
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
                             <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="ContactInfoGroup"
                                 ErrorDisplayMode="Text" ErrorTextPosition="Right" 
                                 EnableCustomValidation="True">
                                 <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText='<%$Resources:ConferenceFront, ContactInfo_EnterConfirmPassword %>' IsRequired="True" />
                             </ValidationSettings>
                </dx:ASPxTextBox>
            </td>
        </tr>
    </table>
    </div>
    </div>
    <div class="rbmContactDetailsTable">
        <table>
            <tr>
                <td class="rbmContactInfoLabel"><asp:Literal ID="Literal4" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_Title %>' ></asp:Literal><span class="notice-required">&nbsp;</span></td>
                <td>
                <dx:ASPxComboBox ID="ContactTitle" runat="server" SelectedIndex="0"  
                                    ValueType="System.String" Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887" Width="170px" ItemImage-Height="10px" 
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
                                    <Border BorderColor="#0D98ED" BorderStyle="Solid" />
                                    <Paddings PaddingLeft="0px" />
                                    <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="ContactInfoGroup" 
                                 ErrorDisplayMode="Text" ErrorTextPosition="Right">
                                 <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText='<%$Resources:ConferenceFront, ContactInfo_EnterTitle %>' IsRequired="True" />
                             </ValidationSettings>
                                </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td class="rbmContactInfoLabel"><asp:Literal ID="Literal5" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_FirstName %>' ></asp:Literal><span class="notice-required">&nbsp;</span></td>
                <td>
                    <dx:ASPxTextBox ID="ContactFirstName" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" />
                    <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="ContactInfoGroup" 
                                 ErrorDisplayMode="Text" ErrorTextPosition="Right">
                                 <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText='<%$Resources:ConferenceFront, ContactInfo_EnterFirstName %>' IsRequired="True" />
                             </ValidationSettings>
                </dx:ASPxTextBox>
                </td>
            </tr>
            <tr>
                <td class="rbmContactInfoLabel"><asp:Literal ID="Literal6" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_MiddleName %>' ></asp:Literal></td>
                <td>
                    <dx:ASPxTextBox ID="ContactMiddleName" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" />

                </dx:ASPxTextBox>
                </td>
            </tr>
            <tr>
                <td class="rbmContactInfoLabel"><asp:Literal ID="Literal7" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_LastName %>' ></asp:Literal><span class="notice-required">&nbsp;</span></td>
                <td>
                    <dx:ASPxTextBox ID="ContactLastName" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" />
                    <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="ContactInfoGroup" 
                                 ErrorDisplayMode="Text" ErrorTextPosition="Right">
                                 <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText='<%$Resources:ConferenceFront, ContactInfo_EnterLastName %>' IsRequired="True" />
                             </ValidationSettings>
                </dx:ASPxTextBox>
                </td>
            </tr>
            <tr>
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
                <td class="rbmContactInfoLabel"><asp:Literal ID="Literal9" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_DateofBirth %>' ></asp:Literal></td>
                <td>
                    <dx:ASPxDateEdit ID="ContactDateofBirth" runat="server" Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" />
                    </dx:ASPxDateEdit>
                </td>
            </tr>
            <tr>
                <td class="rbmContactInfoLabel"><asp:Literal ID="Literal10" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_Address %>' ></asp:Literal></td>
                <td>
                    <dx:ASPxTextBox ID="ContactAddress" runat="server" Width="500px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" />
                </dx:ASPxTextBox>
                </td>
            </tr>
            <tr>
                <td class="rbmContactInfoLabel"><asp:Literal ID="Literal11" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_POBox %>' ></asp:Literal></td>
                <td>
                    <dx:ASPxTextBox ID="ContactPOBox" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" />
                </dx:ASPxTextBox>
                </td>
            </tr>
            <tr>
                <td class="rbmContactInfoLabel"><asp:Literal ID="Literal12" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_ZipCode %>' ></asp:Literal></td>
                <td>
                    <dx:ASPxTextBox ID="ContactZipCode" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" />
                </dx:ASPxTextBox>
                </td>
            </tr>
            <tr>
                <td class="rbmContactInfoLabel"><asp:Literal ID="Literal13" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_City %>' ></asp:Literal></td>
                <td>
                    <dx:ASPxTextBox ID="ContactCity" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" />
                </dx:ASPxTextBox>
                </td>
            </tr>
            <tr>
                <td class="rbmContactInfoLabel"><asp:Literal ID="Literal14" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_Country %>' ></asp:Literal></td>
                <td>
                     <dx:ASPxComboBox ID="ContactCountry" runat="server" SelectedIndex="0"  
                                    ValueType="System.String" Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887" Width="170px" ItemImage-Height="10px" 
                         ItemImage-Width="0px" DataSourceID="CountryObjectDS" 
                         IncrementalFilteringMode="Contains" TextField="Name" ValueField="CountryRegionCode"
                                   >
                                    <Border BorderColor="#0D98ED" BorderStyle="Solid" />
                                    <Paddings PaddingLeft="0px" />
                                </dx:ASPxComboBox>
                     <asp:ObjectDataSource ID="CountryObjectDS" runat="server" 
                         OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                         TypeName="BusinessLogicLayer.Components.Persons.CountryRegionLogic">
                     </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td class="rbmContactInfoLabel"><asp:Literal ID="Literal15" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_PhoneNumber %>' ></asp:Literal><span class="notice-required">&nbsp;</span></td>
                <td>
                    <table >
                                    <tr>
                                        <td style="padding-top:0px;padding-bottom:0px;">
                                        <dx:ASPxTextBox ID="ContactPhoneCode" runat="server" Width="50px" Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" />
                                            <ValidationSettings Display="Dynamic" 
                                                ErrorDisplayMode="Text" ValidationGroup="Step1ValidationGroup">
                                                <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                                </ErrorFrameStyle>
                                                <RequiredField ErrorText="Required" />
                                                
                                            </ValidationSettings>
                                            <Border BorderColor="#0D98ED" BorderStyle="Solid" />
                                </dx:ASPxTextBox>
                                
                                        </td>
                                        <td style="padding-left:10px;padding-top:0px;padding-bottom:0px;">
                                        <dx:ASPxTextBox ID="ContactPhoneNumber" runat="server" Width="190px" Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" />
                                           <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="ContactInfoGroup" 
                                 ErrorDisplayMode="Text" ErrorTextPosition="Right">
                                 <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText='<%$Resources:ConferenceFront, ContactInfo_EnterPhone %>' IsRequired="True" />
                             </ValidationSettings>
                                            
                                </dx:ASPxTextBox>
                               
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding-top:0px;padding-bottom:0px;"><asp:Literal ID="Literal17" runat="server" Text='<%$Resources:ConferenceFront, Contactinfo_PhoneNumberCode %>' ></asp:Literal></td>
                                        <td style="padding-top:0px;padding-bottom:0px;padding-left:10px;"><asp:Literal ID="Literal16" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_PhoneNumber %>' ></asp:Literal></td>
                                    </tr>
                                </table>
                </td>
            </tr>
            <tr>
                <td class="rbmContactInfoLabel"><asp:Literal ID="Literal18" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_FaxNumber %>' ></asp:Literal></td>
                <td>
                    <table >
                                    <tr>
                                        <td style="padding-top:0px;padding-bottom:0px;">
                                        <dx:ASPxTextBox ID="ContactFaxNumberAreaCode" runat="server" Width="50px" Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" />
                                            
                                            <Border BorderColor="#0D98ED" BorderStyle="Solid" />
                                </dx:ASPxTextBox>
                                
                                        </td>
                                        <td style="padding-left:10px;padding-top:0px;padding-bottom:0px;">
                                        <dx:ASPxTextBox ID="ContactFaxNumber" runat="server" Width="190px" Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" />
                                            
                                            
                                </dx:ASPxTextBox>
                               
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding-top:0px;padding-bottom:0px;"><asp:Literal ID="Literal20" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_FaxNumberCode %>' ></asp:Literal></td>
                                        <td style="padding-top:0px;padding-bottom:0px;padding-left:10px;"><asp:Literal ID="Literal19" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_FaxNumber %>' ></asp:Literal></td>
                                    </tr>
                                </table>
                </td>
            </tr>
            <tr>
                <td class="rbmContactInfoLabel"><asp:Literal ID="Literal21" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_MobileNumber %>' ></asp:Literal><span class="notice-required">&nbsp;</span></td>
                <td>
                    <table >
                                    <tr>
                                        <td style="padding-top:0px;padding-bottom:0px;">
                                        <dx:ASPxTextBox ID="ContactMobileNumberCode" runat="server" Width="50px" Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" />
                                            <ValidationSettings Display="Dynamic" 
                                                ErrorDisplayMode="Text" ValidationGroup="Step1ValidationGroup">
                                                <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                                </ErrorFrameStyle>
                                                <RequiredField ErrorText="Required" />
                                                
                                            </ValidationSettings>
                                            <Border BorderColor="#0D98ED" BorderStyle="Solid" />
                                </dx:ASPxTextBox>
                                
                                        </td>
                                        <td style="padding-left:10px;padding-top:0px;padding-bottom:0px;">
                                        <dx:ASPxTextBox ID="ContactMobileNumber" runat="server" Width="190px" Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" />
                                            <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                                ErrorDisplayMode="Text" ValidationGroup="Step1ValidationGroup">
                                                <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                                </ErrorFrameStyle>
                                                <RequiredField ErrorText='<%$Resources:ConferenceFront, ContactInfo_EnterMobileNumber %>' IsRequired="True" />
                                            </ValidationSettings>
                                            
                                </dx:ASPxTextBox>
                               
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding-top:0px;padding-bottom:0px;"><asp:Literal ID="Literal23" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_MobileNumberCode %>' ></asp:Literal></td>
                                        <td style="padding-top:0px;padding-bottom:0px;padding-left:10px;"><asp:Literal ID="Literal22" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_MobileNumber %>' ></asp:Literal></td>
                                    </tr>
                                </table>
                </td>
            </tr>
            <tr>
                <td class="rbmContactInfoLabel"><asp:Literal ID="Literal24" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_ProfileImage %>' ></asp:Literal></td>
                <td>
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
            <tr>
                <td class="rbmContactInfoLabel">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <dx:ASPxValidationSummary ID="ContactInfoValidationSummary" runat="server"  
                        ValidationGroup="ContactInfoGroup" BackColor="#FBE3E4" 
                        ShowErrorsInEditors="True" Width="100%" HeaderText="Missing Information">
                        <HeaderStyle Font-Bold="False" Font-Size="16px" />
                        <Border BorderColor="#FBC2C4" BorderStyle="Solid" BorderWidth="2px" />
                    </dx:ASPxValidationSummary>
                </td>
            </tr>
            
        </table>

        <br class="clear" /><br />
    </div>
    <table style="width:60%;">
        <tr>
        <td align="right">
        <dx:ASPxButton ID="SignupButton" runat="server" Font-Bold="True" 
                        Font-Size="16px" Height="45px" HorizontalAlign="Center" onclick="Signup_Click" 
                        Text='<%$Resources:ConferenceFront, ContactInfo_Save %>' Width="120px" ValidationGroup="ContactInfoGroup">
                    </dx:ASPxButton>
        </td>
        </tr>

    </table>
   </div>
   
   <div class="loginform success" runat="server" visible="false" id="NotificationMessageProfileUpdated">
   <strong>Success</strong><br /><p><asp:Literal ID="Literal25" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_ProfileUpdatedSuccessfully %>' ></asp:Literal></p>
   </div>
   <div class="loginform success" runat="server" visible="false" id="NotificationMessageSuccess">
   <strong>Success</strong><br /><p><asp:Literal ID="Literal26" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_ProfileSavedSuccessfully %>' ></asp:Literal></p>
   </div>
   
   <div class="loginform error" runat="server" visible="false" id="NotificationMessageError">
   <strong>Error</strong><br /><p runat="server" id="ErrorMessage"><asp:Literal ID="Literal27" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_ErrorMessage %>' ></asp:Literal></p>
   </div>
   
