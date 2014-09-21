<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Conference.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="SocioBuilderSite.Conferences.Registration" %>
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
    <script src="Scripts/custom-form-elements.js"
        type="text/javascript"></script>
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
<br class="clear"/><br />
<h1>Registration Form</h1>
<div style="position:relative;width:100%;padding-left:25px;">
    <div id="AbstractSubmissionForm" class="StepsForm" style="width:100%;">
        <div class="SingleStep" id="Step1" style="width:90%;" >
            <div class="newform">
                <fieldset style="width:100%;">
            <div id="steps">
              <img src="images/step-icon-02.jpg" width="18" height="18" /><img src="images/step-line-02.jpg" width="75" height="18" /><img src="images/step-icon-03.jpg" width="18" height="18" /><img src="images/step-line-02.jpg" width="75" height="18" /><img src="images/step-icon-03.jpg" width="18" height="18" /><img src="images/step-line-02.jpg" width="75" height="18" /><img src="images/step-icon-03.jpg" width="18" height="18" />  </div>
            </fieldset>
            <br class="clear" />
            <fieldset style="width:100%;">
                <legend>Resgistration Category
                               </legend>
                               <div class="rbmContactDetailsTable">
                               <table>
                                 <tr>
                                    <td class="rbmContactInfoLabel">
                                    Membership:    
                                    </td>
                                    <td>
                                        <dx:ASPxRadioButtonList ID="RegisterMember" SelectedIndex="0"
                                            runat="server" RepeatColumns="2" 
                                            Width="205px">
                                            
                                            <Items>
                                                <dx:ListEditItem Text="Member" Value="1" Selected="true" />
                                                <dx:ListEditItem Text="Non Member" Value="2" />
                                            </Items>
                                            <Border BorderStyle="None" />
                                        </dx:ASPxRadioButtonList>
                                    
                                    </td>
                                 </tr>
                                 <tr>
                                    <td class="rbmContactInfoLabel">
                                        Sponsorship Type:
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
                                                <dx:ListEditItem Text="Self Sponsor" Value="1" Selected="true" />
                                                <dx:ListEditItem Text="Other" Value="2" />
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
              <legend>Registrar Infromation</legend>
              <Rbm:ProfileInformationControl runat="server" ID="ProfileInformation1" />
                </fieldset>
                <br />
                <table width="99%" border="0" cellspacing="0" cellpadding="0" class="formz">
  <tr>
    <td>&nbsp;</td>
    <td align="right"><input name="input" onclick="NextStep('Step1','Step2',false)" type="button" value="Next" class="newform-bot-01" /></td>
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
                        <br class="clear" /><br />
                        <fieldset>
                        <div class="rbmContactDetailsTable">
                            <table>
                                  <tr>
    <td class="rbmContactInfoLabel">License Number  </td>
    <td >
        <dx:ASPxTextBox ID="RegistrationSaudiLicenseNumber" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
        </dx:ASPxTextBox>
    <br /> </td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>If you are practicing in Saudi Arabia please enter Saudi Commission For Health Specialties Licensing Number(to claim your CME hours)</td>
  </tr>
                            </table>
                            </div>
                        </fieldset>
                        <br class="clear" /><br />
                         <fieldset style="width:100%;">
                <legend>Academic Information
             
                </legend>
                <div class="rbmContactDetailsTable">
                <table>
                <tr>
    <td class="rbmContactInfoLabel">Position</td>
    <td>
    <dx:ASPxTextBox ID="RegistrationPositionAcademic" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887" >
                                </dx:ASPxTextBox>
       </td>
  </tr>
  <tr>
    <td class="rbmContactInfoLabel">Degree</td>
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
                                                <dx:ListEditItem Text="Bs." Value="1" Selected="true" />
                                                <dx:ListEditItem Text="Ph.D."  Value="2" />
                                                <dx:ListEditItem Text="MBBS." Value="3" />
                                                <dx:ListEditItem Text="Health Care Professional" Value="5"/>
                                                <dx:ListEditItem Text="MD." Value="4" />
                                                
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
                     <legend>Hospital Institute</legend>
                     <div class="rbmContactDetailsTable">
                  <table>
                    <tr>
                      <td class="rbmContactInfoLabel">Name</td>
                      <td>
                      <dx:ASPxTextBox ID="RegistrationHospitalName" runat="server"  Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                                </dx:ASPxTextBox>
                      </td>
                    </tr>
                    <tr>
                      <td class="rbmContactInfoLabel">Department</td>
                      <td>
                      <dx:ASPxTextBox ID="RegistrationHospitalDepartment" runat="server"  Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887" >
                                </dx:ASPxTextBox>
                      </td>
                    </tr>
                    <tr>
                      <td class="rbmContactInfoLabel">Address</td>
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
    <td><input name="input2" type="button" value="Back" class="newform-bot-01" onclick="NextStep('Step2','Step1',false)" /></td>
    <td align="right"><input name="input" type="button" value="Next" class="newform-bot-01" onclick="NextStep('Step2','Step4',false)" /></td>
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
                <legend>Area  Of Activity       </legend>
                <div class="rbmContactDetailsTable">
                <table>
                <tr>
        <td><input runat="server" id="SubscribeToNewsLetter" type="checkbox" name="a3" class="styled" /></td>
        <td class="rbmContactInfoLabel"> Please check if you want to subscribe to newsletter<br />
          </td>
      </tr>
                </table>
<span class="rbmContactInfoLabel" style="font-style:italic;color:#023B68;">Please check all that apply</span><br />
<br />
<table>
  <tr>
    <td ><input runat="server" id="AOAAdministrator" type="checkbox" name="a2" class="styled" /></td>
    <td class="rbmContactInfoLabel" >Administrator<br /></td>
    <td ><input runat="server" id="AOARetired" type="checkbox" name="a2" class="styled" /></td>
    <td class="rbmContactInfoLabel">Retired<br /></td>
    <td ><input runat="server" id="AOAClinicalResearcher" type="checkbox" name="a2" class="styled" /></td>
    <td class="rbmContactInfoLabel">Clinical Researcher <br /></td>
  </tr>
  <tr>
    <td ><input runat="server" id="AOABasicResearcher" type="checkbox" name="a" class="styled" /></td>
    <td class="rbmContactInfoLabel">Basic Researcher</td>
    <td ><input runat="server" id="AOATeacherEducator" type="checkbox" name="a" class="styled" /></td>
    <td class="rbmContactInfoLabel">Teacher/Educator<br /></td>
    <td ><input runat="server" id="AOAIndustryRepresentative" type="checkbox" name="a" class="styled" /></td>
    <td class="rbmContactInfoLabel">Industry Representative<br /></td>
  </tr>
  <tr>
    <td ><input runat="server" id="AOAClinicalPractitioner" type="checkbox" name="a3" class="styled" /></td>
    <td class="rbmContactInfoLabel">Clinical Practitioner</td>
    <td ><input runat="server" id="AOAAlliedHealthProfessional" type="checkbox" name="a3" class="styled" /></td>
    <td class="rbmContactInfoLabel">Allied Health Professional</td>
    <td ><input runat="server" id="AOAStudent" type="checkbox" name="a3" class="styled" /></td>
    <td class="rbmContactInfoLabel">Student</td>
  </tr>
  <tr>
    <td ><input runat="server" id="AOAOther" type="checkbox" name="a4" class="styled" /></td>
    <td class="rbmContactInfoLabel">Other</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table>
</div>
<br />
            </fieldset>
                <br />
                <fieldset>
                  <legend>Professional Interest</legend>
                  <div class="rbmContactDetailsTable">
                  <span class="rbmContactInfoLabel" style="font-style:italic;color:#023B68;">Please check all that apply</span><br />
                  <br />
                  <table>  <tr >
                      <td ></td>
                      <td class="rbmContactInfoLabel" >Clinical Nephrology:</td>
                      <td style="width:35px;" ></td>
                      <td class="rbmContactInfoLabel">Pediatric Nephrology</td>
                    </tr>  <tr >
                      <td>&nbsp;</td>
                      <td rowspan="6">
                      <table width="100%" border="0" cellspacing="0" cellpadding="0">  <tr >
                          <td ><input runat="server" id="AOAMCNAcuteKidneyInjury" type="checkbox" name="a6" class="styled" /></td>
                          <td class="rbmContactInfoLabel">Acute Kidney Injury</td>
                        </tr>  <tr >
                          <td ><input runat="server" id="AOAMCNChronicKidneyDisease" type="checkbox" name="a5" class="styled" /></td>
                          <td class="rbmContactInfoLabel">Chronic Kidney Disease<br /></td>
                        </tr>  <tr >
                          <td ><input runat="server" id="AOAMCNHypertension" type="checkbox" name="a17" class="styled" /></td>
                          <td class="rbmContactInfoLabel">Hypertension<br /></td>
                        </tr>  <tr >
                          <td ><input runat="server" id="AOAMCNGlomerulonephritis" type="checkbox" name="a18" class="styled" /></td>
                          <td class="rbmContactInfoLabel">Glomerulonephritis<br /></td>
                        </tr>   <tr >
                          <td ><input runat="server" id="AOAMCNNephrolithiasis" type="checkbox" name="a20" class="styled" /></td>
                          <td class="rbmContactInfoLabel">Nephrolithiasis</td>
                        </tr>
                      </table></td>
                      <td ><input runat="server" id="AOAMGenetics" type="checkbox" name="a15" class="styled" /></td>
                      <td class="rbmContactInfoLabel">Genetics</td>
                    </tr>  <tr >
                      <td>&nbsp;</td>
                      <td ><input runat="server" id="AOAMUrology" type="checkbox" name="a14" class="styled" /></td>
                      <td class="rbmContactInfoLabel">Urology </td>
                    </tr>  <tr >
                      <td>&nbsp;</td>
                      <td ><input runat="server" id="AOAMMineralMetabolism" type="checkbox" name="a13" class="styled" /></td>
                      <td class="rbmContactInfoLabel">Mineral Metabolism</td>
                    </tr>  <tr >
                      <td>&nbsp;</td>
                      <td ><input runat="server" id="AOAMAnemia" type="checkbox" name="a12" class="styled" /></td>
                      <td class="rbmContactInfoLabel">Anemia</td>
                    </tr>  <tr >
                      <td>&nbsp;</td>
                      <td ><input runat="server" id="AOAMDiabetes" type="checkbox" name="a11" class="styled" /></td>
                      <td class="rbmContactInfoLabel">Diabetes </td>
                    </tr>  <tr >
                      <td>&nbsp;</td>
                      <td ><input runat="server" id="AOAMImmunology" type="checkbox" name="a10" class="styled" /></td>
                      <td class="rbmContactInfoLabel">Immunology</td>
                    </tr>  <tr >
                      <td ></td>
                      <td class="rbmContactInfoLabel">Renal replacement therapy:</td>
                      <td ><input runat="server" id="AOAMPathology" type="checkbox" name="a9" class="styled" /></td>
                      <td class="rbmContactInfoLabel">Pathology</td>
                    </tr>  <tr >
                      <td>&nbsp;</td>
                      <td rowspan="3"><table width="100%" border="0" cellspacing="0" cellpadding="0">  <tr >
                          <td ><input runat="server" id="AOAMRRTHemodialysis" type="checkbox" name="a23" class="styled" /></td>
                          <td class="rbmContactInfoLabel">Hemodialysis </td>
                        </tr>  <tr >
                          <td ><input runat="server" id="AOAMRRTPertionealDialysis" type="checkbox" name="a23" class="styled" /></td>
                          <td class="rbmContactInfoLabel">Peritoneal Dialysis</td>
                        </tr>  <tr >
                          <td ><input runat="server" id="AOAMRRTCRRT" type="checkbox" name="a23" class="styled" /></td>
                          <td class="rbmContactInfoLabel">CRRT </td>
                        </tr>
                      </table></td>
                      <td ><input runat="server" id="AOAMIterventionalCCN" type="checkbox" name="a8" class="styled" /></td>
                      <td class="rbmContactInfoLabel">Interventional / Critical Care Nephrology </td>
                    </tr>  <tr >
                      <td>&nbsp;</td>
                      <td > <input runat="server" id="AOAMOther" type="checkbox" name="a7" class="styled" /></td>
                      <td class="rbmContactInfoLabel">Other</td>
                    </tr>  <tr >
                      <td height="15" >&nbsp;</td>
                      <td colspan="2" align="left" ><input runat="server" id="AOAMOtherText" name="textfield" type="text" class="newform-txt" size="30" /></td>
                    </tr>
                  </table>
                  </div>
                  <br />
                </fieldset>
                <br />
                <table width="99%" border="0" cellspacing="0" cellpadding="0" class="formz">
                    <tr>
                        <td>
                            <input name="input2" type="button" value="Back" class="newform-bot-01" onclick="NextStep('Step3','Step2',false)" />
                        </td>
                        <td align="right">
                            <input name="input" type="button" value="Next" class="newform-bot-01" onclick="NextStep('Step3','Step4',false)" />
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
                <legend>Registration Fee</legend>
                <div class="rbmContactDetailsTable">
                <table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td colspan="2" class="rbmContactInfoLabel"> Registration for annual meeting<br />
          </td>
      </tr>
      <tr>
        <td>
            
        </td>
      </tr>
      <tr>
        <td align="left" style="width:30px;" ><input runat="server" id="RegistrationMedicalDoctorsCheck" type="radio"   name="payradio" class="styled" /></td>
        <td align="left" class="rbmContactInfoLabel">Medical doctors <span class="red">600</span> Saudi Riyals</td>
      </tr>
      <tr>
        <td align="left" ><input runat="server" id="RegistrationHealthProfessionalCheck" type="radio" name="payradio" class="styled" /></td>
        <td align="left" class="rbmContactInfoLabel">Allied health professional <span class="red">400 </span>Saudi Riyals</td>
      </tr>
      <tr runat="server" visible="false">
        <td ><input visible="false" type="checkbox" runat="server" id="PreConferenceWorkShopIncluded" value="true" name="a3" class="styled" /></td>
        <td class="rbmContactInfoLabel">Pre conference work shop<br />
          included in the conference fees</td>
      </tr>
      
    </table>
                <table style="width:100%">
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
    <td><input name="input2" type="button" value="Back" class="newform-bot-01" onclick="NextStep('Step4','Step3',false)" /></td>
    <td align="right">
    <asp:Button runat="server" id="SubmitRegistrationForm" Text="Submit" CssClass="newform-bot-01" OnClick="SubmitRegistrationForm_Click" /></td>
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
