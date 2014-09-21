﻿<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="SocioBuilderSite.Conference.Registration" %>
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
<%@ Register Src="~/Controls/Reports/MainReportViewerControl.ascx" TagName="ReportViewerControl" TagPrefix="Rbm" %>
<%@ Register Src="~/Controls/Conference/ProfileInformation.ascx" TagName="ProfileInformationControl" TagPrefix="Rbm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="/_Scripts/Front/custom-form-elements.js" type="text/javascript"></script>
<script type="text/javascript">
    function PatchJQuery() {

        if (!window.jQuery || !window.jQuery.clean)
            return;

        var original = window.jQuery.clean;
        window.jQuery.clean = function (elems, context, fragment, scripts) {
            var execResult = original.call(jQuery, elems, context, fragment, scripts);
            if (scripts && scripts.length) {
                for (var i = scripts.length - 1; i >= 0; i--) {
                    var script = scripts[i];
                    if (IsDXScript(script))
                        ArrayRemoveAt(scripts, i);
                }
            }
            return execResult;
        };
    }

    // Utils
    function IsDXScript(script) {
        return script && script.id && script.id.indexOf("dx") == 0;
    }
    function ArrayRemoveAt(array, index) {
        if (index >= 0 && index < array.length) {
            for (var i = index; i < array.length - 1; i++)
                array[i] = array[i + 1];
            array.pop();
        }
    }

    PatchJQuery();
    </script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#Step2').hide();
            $('#Step3').hide();
            $('#Step4').hide();
            $('#Step5').hide();
        });

        function NextStep(stepIdFrom, stepIdTo, boolvalue) {
            if (stepIdFrom == 'Step1') {
                if (ASPxClientEdit.ValidateGroup('Step1ValidationGroup', false)) {
                    $('#' + stepIdFrom).fadeOut('slow', LoadingStep(stepIdTo));
                }
            }
            else if (stepIdFrom == 'Step2') {

                if (ASPxClientEdit.ValidateGroup('Step2ValidationGroup', false)) {
                    $('#' + stepIdFrom).fadeOut('slow', LoadingStep(stepIdTo));
                }
            }
            else if (stepIdFrom == 'Step3') {

                if (ASPxClientEdit.ValidateGroup('Step3ValidationGroup', false)) {
                    $('#' + stepIdFrom).fadeOut('slow', LoadingStep(stepIdTo));
                }
            }
            else if (stepIdFrom == 'Step4') {

                if (ASPxClientEdit.ValidateGroup('Step4ValidationGroup', false)) {
                    $('#' + stepIdFrom).fadeOut('slow', LoadingStep(stepIdTo));
                }
            }

            //ASPxClientEdit.ValidateGroup(\"" + Step1ValidationGroup + "\",false)) 

        }
        var currentstep = 'Step1';
        function LoadingStep(stepIdTo) {
            $('#' + stepIdTo).fadeIn('slow');
            currentstep = stepIdTo;
            document.location.href = '#' + stepIdTo;
        }
    </script>
    <style type="text/css">
        .style1
        {
            width: 209px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1><asp:Literal ID="Literal1" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_Title %>' ></asp:Literal></h1>
<div style="position:relative;width:100%;padding-left:25px;">
    <div id="AbstractSubmissionForm" class="StepsForm" style="width:100%;">
        <div class="SingleStep" id="Step1" style="width:90%;" >
            <div class="newform">
                <fieldset style="width:100%;">
            <div id="steps">
              <img src="images/step-icon-02.jpg" width="18" height="18" /><img src="images/step-line-02.jpg" width="75" height="18" /><img src="images/step-icon-03.jpg" width="18" height="18" /><img src="images/step-line-02.jpg" width="75" height="18" /><img src="images/step-icon-03.jpg" width="18" height="18" /><img src="images/step-line-02.jpg" width="75" height="18" /><img src="images/step-icon-03.jpg" width="18" height="18" />  </div>
            </fieldset>
            <br class="clear" />
            <fieldset style="width:100%;" runat="server" visible="false">
                <legend><asp:Literal ID="Literal2" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_RegistrationCategory %>' ></asp:Literal>
                               </legend>
                               <div class="rbmContactDetailsTable">
                               <table>
                                 <tr>
                                    <td class="rbmContactInfoLabel">
                                    <asp:Literal ID="Literal3" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_Membership %>' ></asp:Literal>    
                                    </td>
                                    <td>
                                        <dx:ASPxRadioButtonList ID="RegisterMember" SelectedIndex="0"
                                            runat="server" RepeatColumns="2" 
                                            Width="205px">
                                            
                                            <Items>
                                                <dx:ListEditItem Text='<%$Resources:ConferenceFront, RegistrationForm_Member %>' Value="1" Selected="true" />
                                                <dx:ListEditItem Text='<%$Resources:ConferenceFront, RegistrationForm_NonMember %>' Value="2" />
                                            </Items>
                                            <Border BorderStyle="None" />
                                        </dx:ASPxRadioButtonList>
                                    
                                    </td>
                                 </tr>
                                 <tr>
                                    <td class="rbmContactInfoLabel">
                                        <asp:Literal ID="Literal4" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_SponsorshipType %>' ></asp:Literal>
                                    </td>
                                    <td>
                                    <table>
                                        <tr>
                                        <td>
                                        <dx:ASPxRadioButtonList ID="RegistrationCategoryRadio" SelectedIndex="0"
                                            ClientInstanceName="RegistrationCategoryRadio" runat="server" RepeatColumns="2" 
                                            Width="205px">
                                            <ClientSideEvents Init="function(s,e){
                                            if(s.GetValue() == '1')
                                                RegistrationSponsorsCombo.SetVisible(false);
                                            else
                                                RegistrationSponsorsCombo.SetVisible(true);
                                                                                              }" SelectedIndexChanged="function(s,e){
                                            if(s.GetValue() == '1')
                                                RegistrationSponsorsCombo.SetVisible(false);
                                            else
                                                RegistrationSponsorsCombo.SetVisible(true);
                                                                                              }" />
                                            <Items>
                                                <dx:ListEditItem Text='<%$Resources:ConferenceFront, RegistrationForm_SelfSponsor %>' Value="1" Selected="true" />
                                                <dx:ListEditItem Text='<%$Resources:ConferenceFront, RegistrationForm_SponsorOther %>' Value="2" />
                                            </Items>
                                            <Border BorderStyle="None" />
                                        </dx:ASPxRadioButtonList></td>
                                        <td>
                                        <dx:ASPxTextBox runat="server" ClientInstanceName="RegistrationSponsorsCombo" ID="RegistrationSponsorsCombo" Width="200px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887"></dx:ASPxTextBox>
                                        </td>
                                        </tr>
                                    </table>
                                        
                                    
                                        
                                    </td>
                                 </tr>
                               </table>
                               </div>
                        </fieldset>
              <br />
              <fieldset style="width:100%;">
              <legend><asp:Literal ID="Literal5" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_RegistrarInformation %>' ></asp:Literal></legend>
              <Rbm:ProfileInformationControl runat="server" ID="ProfileInformation1" />
                </fieldset>
                <br />
                <table width="99%" border="0" cellspacing="0" cellpadding="0" class="formz">
  <tr>
    <td>&nbsp;</td>
    <td align="right"><input name="input" runat="server" onclick="NextStep('Step1','Step2',false)" type="button" value='<%$Resources:ConferenceFront, RegistrationForm_Next %>' class="newform-bot-01" /></td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table>


            </div>
        </div>
        <div class="SingleStep" id="Step2" style="width:90%;">
            <div class="newform">
                <fieldset style="width:100%;">
            <div id="steps">
              <img src="images/step-icon-01.jpg" width="18" height="18" /><img src="images/step-line-01.jpg" width="75" height="18" /><img src="images/step-icon-02.jpg" width="18" height="18" /><img src="images/step-line-02.jpg" width="75" height="18" /><img src="images/step-icon-03.jpg" width="18" height="18" /><img src="images/step-line-02.jpg" width="75" height="18" /><img src="images/step-icon-03.jpg" width="18" height="18" />  </div>
            </fieldset>
                        <%--<br class="clear" /><br />--%>
                        <fieldset runat="server" visible="false">
                        <div class="rbmContactDetailsTable">
                            <table>
                                  <tr>
    <td class="rbmContactInfoLabel"><asp:Literal ID="Literal6" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_LicenseNumber %>' ></asp:Literal> </td>
    <td >
        <dx:ASPxTextBox ID="RegistrationSaudiLicenseNumber" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
        </dx:ASPxTextBox>
    <br /> </td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td><asp:Literal ID="Literal7" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_LicenseNumberDescription %>' ></asp:Literal></td>
  </tr>
                            </table>
                            </div>
                        </fieldset>
                        <%--<br class="clear" /><br />--%>
                         <fieldset style="width:100%;" runat="server" visible="false">
                <legend><asp:Literal ID="Literal8" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_AcademicInformation %>' ></asp:Literal>
             
                </legend>
                <div class="rbmContactDetailsTable">
                <table>
                <tr>
    <td class="rbmContactInfoLabel"><asp:Literal ID="Literal9" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_Position %>' ></asp:Literal></td>
    <td>
    <dx:ASPxTextBox ID="RegistrationPositionAcademic" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887" >
                                </dx:ASPxTextBox>
       </td>
  </tr>
  <tr>
    <td class="rbmContactInfoLabel"><asp:Literal ID="Literal10" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_Degree %>' ></asp:Literal></td>
    <td>
    <dx:ASPxRadioButtonList ID="RegistrationDegree" 
                                            ClientInstanceName="RegistrationCategoryRadio" runat="server" RepeatColumns="3" SelectedIndex="0"
                                            >
                                            <ClientSideEvents Init="function(s,e){
                                            if(s.GetValue() != '5')
                                                RegistrationDegreeOther.SetVisible(false);
                                            else
                                                RegistrationDegreeOther.SetVisible(true);
                                                                                              }" SelectedIndexChanged="function(s,e){
                                            if(s.GetValue() != '5')
                                                RegistrationDegreeOther.SetVisible(false);
                                            else
                                                RegistrationDegreeOther.SetVisible(true);
                                                                                              }" />
                                            <Items>
                                                <dx:ListEditItem Text='<%$Resources:ConferenceFront, RegistrationForm_Bachelor %>' Value="1" Selected="true" />
                                                <dx:ListEditItem Text='<%$Resources:ConferenceFront, RegistrationForm_PhD %>'  Value="2" />
                                                <dx:ListEditItem Text='<%$Resources:ConferenceFront, RegistrationForm_MBBS %>' Value="3" />
                                                <dx:ListEditItem Text='<%$Resources:ConferenceFront, RegistrationForm_HealthCareProfessional %>' Value="5"/>
                                                <dx:ListEditItem Text='<%$Resources:ConferenceFront, RegistrationForm_Masters %>' Value="4" />
                                                
                                            </Items>
                                            <Border BorderStyle="None" />
                                        </dx:ASPxRadioButtonList>

    </td>
  </tr>
  <tr>
    <td></td>
    <td>
    <dx:ASPxComboBox ClientInstanceName="RegistrationDegreeOther" ID="RegistrationDegreeOther" runat="server" SelectedIndex="0"  
                                    ValueType="System.String" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                                    <Items>
                                        <dx:ListEditItem Text="Nurse" Value="0" Selected="true" />
                                        <dx:ListEditItem Text="Dietitian" Value="1" />
                                        <dx:ListEditItem Text="Respiratory Therapist" Value="2" />
                                        <dx:ListEditItem Text="Physiotherapist" Value="3" />
                                        <dx:ListEditItem Text="Others" Value="4" />
                                    </Items>
                                    <Paddings PaddingLeft="5px" />
                                </dx:ASPxComboBox>
    </td>
  </tr>
  
</table>
</div>
                </fieldset>
       
                <br />
                <fieldset style="width:100%;">
                     <legend><asp:Literal ID="Literal11" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_HospitalInstitude %>' ></asp:Literal></legend>
                     <div class="rbmContactDetailsTable">
                  <table>
                    <tr>
                      <td class="rbmContactInfoLabel"><asp:Literal ID="Literal12" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_HospitalName %>' ></asp:Literal></td>
                      <td>
                      <dx:ASPxTextBox ID="RegistrationHospitalName" runat="server"  Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                                </dx:ASPxTextBox>
                      </td>
                    </tr>
                    <tr>
                      <td class="rbmContactInfoLabel"><asp:Literal ID="Literal13" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_HospitalDepartment %>' ></asp:Literal></td>
                      <td>
                      <dx:ASPxTextBox ID="RegistrationHospitalDepartment" runat="server"  Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887" >
                                </dx:ASPxTextBox>
                      </td>
                    </tr>
                    <tr>
                      <td class="rbmContactInfoLabel"><asp:Literal ID="Literal14" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_HospitalAddress %>' ></asp:Literal></td>
                      <td>
                      <dx:ASPxTextBox ID="RegistrationHospitalAddress" runat="server"  Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887" >
                                </dx:ASPxTextBox>
                      </td>
                    </tr>
                  </table>
                  </div>
              </fieldset>
               <p>&nbsp;</p>
                <table width="99%" border="0" cellspacing="0" cellpadding="0" class="formz">
  <tr>
    <td><input name="input2" type="button"  runat="server" value='<%$Resources:ConferenceFront, RegistrationForm_Back %>' class="newform-bot-01" onclick="NextStep('Step2','Step1',false)" /></td>
    <td align="right"><input name="input" runat="server" type="button" value='<%$Resources:ConferenceFront, RegistrationForm_Next %>' class="newform-bot-01" onclick="NextStep('Step2','Step3',false)" /></td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table>

            </div>
        </div>
        <div class="SingleStep" id="Step3" style="width: 90%;">
            <div class="newform">
                <fieldset style="width: 100%;">
                    <div id="steps">
                        <img src="images/step-icon-01.jpg" width="18" height="18" /><img src="images/step-line-01.jpg"
                            width="75" height="18" /><img src="images/step-icon-01.jpg" width="18" height="18" /><img
                                src="images/step-line-01.jpg" width="75" height="18" /><img src="images/step-icon-02.jpg"
                                    width="18" height="18" /><img src="images/step-line-02.jpg" width="75" height="18" /><img
                                        src="images/step-icon-03.jpg" width="18" height="18" />
                    </div>
                </fieldset>
                <br class="clear" />
                <fieldset style="width:100%;">
                <legend><asp:Literal runat="server" ID="Literal22" Text='<%$Resources:ConferenceFront, RegistrationForm_Tab3 %>'></asp:Literal></legend>
                <div class="rbmContactDetailsTable">
                <table>
                <tr>
        <td><input runat="server" id="SubscribeToNewsLetter" type="checkbox" name="a3" class="styled" /></td>
        <td class="rbmContactInfoLabel"> 
          </td>
      </tr>
                </table>
<%--<span class="rbmContactInfoLabel" style="font-style:italic;color:#023B68;">Important Information</span><br />--%>
<div style="width:90%;margin:10px;">
<asp:Literal runat="server" ID="RegistrationForm_Pre"></asp:Literal>
<asp:Panel runat="server" id="ResultsAreas">

</asp:Panel>
<asp:Literal runat="server" ID="RegistrationForm_Post"></asp:Literal>
<%--<asp:Literal runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_Information %>'></asp:Literal>--%>
<div runat="server" id="OldForm" visible="false">
<asp:Literal ID="Literal17" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_TableBeforeReg1 %>'></asp:Literal>
    <dx:ASPxCheckBox runat="server" ID="RegistrationHealthProfessionalCheck" Text='<%$Resources:ConferenceFront, RegistrationForm_AlliedHealthProfessional %>' ></dx:ASPxCheckBox>
<asp:Literal ID="Literal18" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_TableAfterReg1 %>'></asp:Literal>
<asp:Literal ID="Literal19" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_TableBeforeReg2 %>'></asp:Literal>
        <dx:ASPxRadioButton runat="server" ID="PreConferenceWorkShopIncluded" Text='<%$Resources:ConferenceFront, RegistrationForm_PreConferenceWorkshop %>' GroupName="RegistrationGroup" ></dx:ASPxRadioButton>
        <asp:Literal ID="Literal21" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_TableBetReg2 %>'></asp:Literal>
        <dx:ASPxRadioButton runat="server" ID="PreConferenceWorkShopIncluded2" Text='<%$Resources:ConferenceFront, RegistrationForm_PreConferenceWorkshop2 %>' GroupName="RegistrationGroup" ></dx:ASPxRadioButton>

<asp:Literal ID="Literal20" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_TableAfterReg2 %>'></asp:Literal>
</div>
</div>


            
                                       

</div>
<br />
            </fieldset>
               
                <table width="99%" border="0" cellspacing="0" cellpadding="0" class="formz">
                    <tr>
                        <td>
                            <input name="input2" type="button" runat="server" value='<%$Resources:ConferenceFront, RegistrationForm_Back %>' class="newform-bot-01" onclick="NextStep('Step3','Step2',false)" />
                        </td>
                        <td align="right">
                            <input name="input" type="button" runat="server" value='<%$Resources:ConferenceFront, RegistrationForm_Next %>' class="newform-bot-01" onclick="NextStep('Step3','Step4',false)" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="SingleStep" id="Step4" style="width:90%;">
            <div class="newform">
        <fieldset style="width:100%;">
            <div id="steps">
              <img src="images/step-icon-01.jpg" width="18" height="18" /><img src="images/step-line-01.jpg" width="75" height="18" /><img src="images/step-icon-01.jpg" width="18" height="18" /><img src="images/step-line-01.jpg" width="75" height="18" /><img src="images/step-icon-01.jpg" width="18" height="18" /><img src="images/step-line-01.jpg" width="75" height="18" /><img src="images/step-icon-02.jpg" width="18" height="18" />  </div>
            </fieldset>
                        <br class="clear" />
               <fieldset>
                <legend><asp:Literal ID="Literal15" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_RegistrationFee %>' ></asp:Literal></legend>
                <div class="rbmContactDetailsTable">
                
                <table style="width:100%">
                <tr id="Tr1" runat="server" visible="false">
        <td colspan="2" class="rbmContactInfoLabel"> <asp:Literal ID="Literal16" runat="server" Text='<%$Resources:ConferenceFront, RegistrationForm_RegistrationConfirmation %>' ></asp:Literal><br />
          </td>
      </tr>
                <tr>
        <td style="width:30px;" ><dx:ASPxCheckBox runat="server" Width="300px" Text='<%$Resources:ConferenceFront, RegistrationForm_ConfirmMessage %>' id="RegistrationMedicalDoctorsCheck"></dx:ASPxCheckBox></td>
        <td  class="rbmContactInfoLabel"> </td>
      </tr>
                <%--<tr>
    <td width="18%" align="right" class="rbmContactInfoLabel">Position  </td>
    <td align="left" ><dx:ASPxTextBox ID="RegistrationPosition" runat="server" Width="250px" 
                                    Font-Size="17px" 
                                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,sans-serif" 
                                    ForeColor="#6E7679" >
                                </dx:ASPxTextBox> </td>
  </tr>--%>
  <tr>
    <td align="right" valign="top"></td>
    <td align="left">
    </td>
    </tr>
</table>
                </div>
                </fieldset>

               

                <br />
                 <table width="99%" border="0" cellspacing="0" cellpadding="0" class="formz">
  <tr>
    <td><input name="input2" type="button" runat="server" value='<%$Resources:ConferenceFront, RegistrationForm_Back %>' class="newform-bot-01" onclick="NextStep('Step4','Step3',false)" /></td>
    <td align="right">
    <asp:Button runat="server" id="SubmitRegistrationForm" Text='<%$Resources:ConferenceFront, RegistrationForm_Submit %>' CssClass="newform-bot-01" OnClick="SubmitRegistrationForm_Click" /></td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table>
</div>
        </div>
        <div class="SingleStep" id="Step5">
        </div>
    </div>
</div>

</asp:Content>