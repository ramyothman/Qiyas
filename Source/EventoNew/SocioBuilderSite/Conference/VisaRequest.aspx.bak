<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master" AutoEventWireup="true" CodeBehind="VisaRequest.aspx.cs" Inherits="SocioBuilderSite.Conference.VisaRequest" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxUploadControl" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>
        <asp:Literal ID="Literal1" runat="server" Text='<%$Resources:ConferenceFront, VisaRequest_Title %>'></asp:Literal></h1>
    <br />
<h2>
        <asp:Literal ID="Literal5" runat="server" Text='<%$Resources:ConferenceFront, VisaRequest_Summary %>'></asp:Literal></h2>
    <br />
     
    <div runat="server" id="VisaRequestDiv" class="mainContent registration">

 <div class="registration-container">
                      
               <div class="rbmContactDetailsTable">
                  <table>
                    <tr>
                      <td class="rbmContactInfoLabel"><asp:Literal ID="Literal12" runat="server" Text='<%$Resources:ConferenceFront, VisaRequest_Country %>' ></asp:Literal></td>
                      <td>
                      <dx:ASPxTextBox ID="VisaRequestCountry" runat="server"  Width="250px">
                      <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="WizardValidation" 
                                 ErrorDisplayMode="None" ErrorTextPosition="Right">
                                 <RequiredField IsRequired="True" />
<RequiredField IsRequired="True"></RequiredField>
                             </ValidationSettings>
                                </dx:ASPxTextBox>
                      </td>
                    </tr>
                    <tr>
                      <td class="rbmContactInfoLabel"><asp:Literal ID="Literal13" runat="server" Text='<%$Resources:ConferenceFront, VisaRequest_City %>' ></asp:Literal></td>
                      <td>
                      <dx:ASPxTextBox ID="VisaRequestCity" runat="server"  Width="250px">
                      <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="WizardValidation" 
                                 ErrorDisplayMode="None" ErrorTextPosition="Right">
                                 <RequiredField IsRequired="True" />
<RequiredField IsRequired="True"></RequiredField>
                             </ValidationSettings>
                                </dx:ASPxTextBox>
                      </td>
                    </tr>
                    <tr>
                      <td class="rbmContactInfoLabel"><asp:Literal ID="Literal14" runat="server" Text='<%$Resources:ConferenceFront, VisaRequest_Company %>' ></asp:Literal></td>
                      <td>
                      <dx:ASPxTextBox ID="VisaRequestCompany" runat="server"  Width="250px">
                      <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="WizardValidation" 
                                 ErrorDisplayMode="None" ErrorTextPosition="Right">
                                 <RequiredField IsRequired="True" />
<RequiredField IsRequired="True"></RequiredField>
                             </ValidationSettings>
                                </dx:ASPxTextBox>
                      </td>
                    </tr>
                    <tr>
                      <td class="rbmContactInfoLabel"><asp:Literal ID="Literal2" runat="server" Text='<%$Resources:ConferenceFront, VisaRequest_Job %>' ></asp:Literal></td>
                      <td>
                      <dx:ASPxTextBox ID="VisaRequestJob" runat="server"  Width="250px">
                      <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="WizardValidation" 
                                 ErrorDisplayMode="None" ErrorTextPosition="Right">
                                 <RequiredField IsRequired="True" />
<RequiredField IsRequired="True"></RequiredField>
                             </ValidationSettings>
                                </dx:ASPxTextBox>
                      </td>
                    </tr>
                    <tr>
                      <td class="rbmContactInfoLabel"><asp:Literal ID="Literal3" runat="server" Text='<%$Resources:ConferenceFront, VisaRequest_Religion %>' ></asp:Literal></td>
                      <td>
                      <dx:ASPxTextBox ID="VisaRequestReligion" runat="server"  Width="250px">
                      <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="WizardValidation" 
                                 ErrorDisplayMode="None" ErrorTextPosition="Right">
                                 <RequiredField IsRequired="True" />
<RequiredField IsRequired="True"></RequiredField>
                             </ValidationSettings>
                                </dx:ASPxTextBox>
                      </td>
                    </tr>
                     <tr>
                      <td class="rbmContactInfoLabel"><asp:Literal ID="Literal4" runat="server" Text='<%$Resources:ConferenceFront, VisaRequest_PassportAttachment %>' ></asp:Literal></td>
                      <td>
                       <dx:ASPxUploadControl ID="PassportUpload" ClientInstanceName="profileLogoUpload"  
                                runat="server" ShowProgressPanel="True"  
                              OnFileUploadComplete="VisaUpload_FileUploadComplete">
                                <ClientSideEvents FileUploadComplete="function(s, e) {
	UploaderProfile_OnUploadComplete(e);
}" />
 <ValidationSettings AllowedFileExtensions=".jpg,.jpeg,.jpe,.gif,.png">
 
                                            </ValidationSettings>
                            </dx:ASPxUploadControl>
                      </td>
                    </tr>
                    <tr>
                    <td></td>
        <td id="Td1"  runat="server" align='<%$Resources:ConferenceFront, Direction %>'>
        <dx:ASPxButton ID="SignupButton" runat="server" Font-Bold="True" 
                        Font-Size="16px" Height="45px" HorizontalAlign="Center" onclick="Signup_Click" 
                        Text='<%$Resources:ConferenceFront, ContactInfo_Save %>' Width="120px" ValidationGroup="WizardValidation">
                    </dx:ASPxButton>
        </td>
        </tr>
                  </table>
                  </div>
                            </div>
                            </div>


    <div runat="server" visible="false" id="NoticeMessage" class="success">
    </div>
</asp:Content>
