﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Conference.Master" AutoEventWireup="true" CodeBehind="AbstractSubmission.aspx.cs" Inherits="SocioBuilderSite.Conferences.Abstract.AbstractSubmission" %>


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
<script type="text/javascript" src="Scripts/JSON.js"></script>
    
    <script type="text/javascript">
        $(document).ready(function () {
            $('#Step1').hide();
            $('#Step2').hide();
            $('#Step3').hide();
            $('#Step4').hide();
            $('#Step5').hide();
        });
        function Step3Called() {
            if (currentstep == 'Step0') {
                $('#Step0').hide();
                $('#Step1').hide();
                $('#Step2').hide();
                $('#Step5').hide();
                $('#Step4').hide();
                $('#Step3').hide();
                $('#Step1').fadeIn('slow');
                currentstep = 'Step1';

            }
            else if (currentstep == 'Step3') {
                $('#Step0').hide();
                $('#Step1').hide();
                $('#Step2').hide();
                $('#Step5').hide();
                $('#Step3').hide();
                $('#Step4').fadeIn('slow');
                currentstep = 'Step4';

            }
            else if (currentstep == 'Step4') {
                $('#Step0').hide();
                $('#Step1').hide();
                $('#Step2').hide();
                $('#Step4').hide();
                $('#Step3').hide();
                $('#Step5').fadeIn('slow');
                currentstep = 'Step5';
            }
        }
        function NextStep(stepIdFrom, stepIdTo, boolvalue) {
            if (stepIdFrom == 'Step0') {
                if (AbstractAuthorCoAuthor.GetValue() == '0')
                    MainCallbackPanel.PerformCallback('author');
                else {
                    LoadCoAuthorDataFromProfile();
                    coauthorLoaded = true;
                    $('#' + stepIdFrom).fadeOut('slow', LoadingStep(stepIdTo));
//                    if (!coauthorLoaded) {
//                        
//                    }
                }
                
            }
            if (stepIdFrom == 'Step1') {
                if (ASPxClientEdit.ValidateGroup('Step1ValidationGroup', false)) {
                    $('#' + stepIdFrom).fadeOut('slow', LoadingStep(stepIdTo));
                }
            }
            else if (stepIdFrom == 'Step2') {

                if (ValidateCoAuthors()) {
                    $('#' + stepIdFrom).fadeOut('slow', LoadingStep(stepIdTo));
                }
            }
            else if (stepIdFrom == "Step3") {
                if (ASPxClientEdit.ValidateGroup('Step3ValidationGroup', false)) {
                    if (stepIdTo == "Step4") {
                        SaveStateForStep2();
                        GetCoAuthorsClientData();
                        MainCallbackPanel.PerformCallback('pre');
                    }
                    else {
                        $('#' + stepIdFrom).fadeOut('slow', LoadingStep(stepIdTo));
                    }
                }
            }
            else if (stepIdFrom == "Step4") {
                if (ASPxClientEdit.ValidateGroup('Step4ValidationGroup', false)) {
                    if (stepIdTo == "Step5") {
                        MainCallbackPanel.PerformCallback('save');
                    }
                    else {
                        $('#' + stepIdFrom).fadeOut('slow', LoadingStep(stepIdTo));
                    }
                }
            }
            
            //ASPxClientEdit.ValidateGroup(\"" + Step1ValidationGroup + "\",false)) 

        }
        
        function LoadingStep(stepIdTo) {
            $('#' + stepIdTo).fadeIn('slow');
            currentstep = stepIdTo;
            if (currentstep != 'Step1' && stepIdTo == 'Step2') {
                LoadStateForStep2();
            }
            document.location.href = '#' + stepIdTo;
        }

        var counter = 0;
        var coauthorLoaded = false;
        var currentstep = 'Step0';
        function moreFields() {
            counter++;
            var newFields = document.getElementById('readroot').cloneNode(true);

            newFields.id = 'author' + counter;
            newFields.style.display = 'block';
            var newField = newFields.childNodes;
            //alert(newField.length);
            for (var i = 0; i < newField.length; i++) {
                var theName = 'authorsGen'; //newField[i].name
                if (theName != null && theName != 'undefined') {
                    newField[i].name = theName + counter;
                    newField[i].id = theName + counter;
                }
            }
            var insertHere = document.getElementById('afterappendcoauthors');
            //alert(insertHere);
            //$('#afterappendcoauthors').after('test');
            //$('#afterappendcoauthors').before('test2');
            //alert($('#afterappendcoauthors').html());
            $('#afterappendcoauthors').before($(newFields).html());
            //alert($(newFields).html());
            //$(newFields).insertBefore('#afterappendcoauthors');
            //$('#AfterAppendCoauthors').insertBefore(newFields, insertHere);
            //insertHere.parentNode.insertBefore(newFields, insertHere);
        }

        function ValidateCoAuthors() {

            var isValid = true;
            var divCoAuthorsMain = $('#AppendCoauthors').children().each(function () {
                var tableControl = $(this).find('fieldset').find('table');
                /************ First Name ************/
                var testControl = tableControl.find('#CoAuthorFirstNameText');
                var cerror = tableControl.find('#CoAuthorFirstNameTextError');
                if (testControl.attr('value') == '') {
                    $(cerror).html('* Required');
                    isValid = false;
                }
                else {
                    $(cerror).html('');
                }
                /************ Family Name ***********/
                testControl = tableControl.find('#CoAuthorFamilyNameText');
                cerror = tableControl.find('#CoAuthorFamilyNameTextError');
                if (testControl.attr('value') == '') {
                    $(cerror).html('* Required');
                    isValid = false;
                }
                else {
                    $(cerror).html('');
                }
                /*********** Email ****************/
                testControl = tableControl.find('#CoAuthorEmailText');
                cerror = tableControl.find('#CoAuthorEmailTextError');
                if (testControl.attr('value') == '') {
                    $(cerror).html('* Required');
                    isValid = false;
                }
                else {
                    $(cerror).html('');
                }
                /********** Phone ****************/
                testControl = tableControl.find('#CoAuthorPhoneNumberText');
                cerror = tableControl.find('#CoAuthorPhoneNumberTextError');
                if (testControl.attr('value') == '') {
                    $(cerror).html('* Required');
                    isValid = false;
                }
                else {
                    $(cerror).html('');
                }
            });
            return isValid;
        }
        function GetCoAuthorsClientData() {

            var isValid = true;
            var CurrentAbstract = new Array();
            CurrentAbstractAuthors = new Array();
            var divCoAuthorsMain = $('#AppendCoauthors').children().each(function () {

                var typeTD = $(this).find('fieldset').find('table');
                var coAuthor = new Object();
                /************ First Name ************/
                var controlMain = typeTD.find('#CoAuthorFirstNameText');
                coAuthor.FirstName = controlMain.attr('value');
                //alert('FirstName: ' + coAuthor.FirstName);

                controlMain = typeTD.find('#CoAuthorFamilyNameText');
                coAuthor.FamilyName = controlMain.attr('value');
                //alert('FamilyName: ' + coAuthor.FamilyName);

                controlMain = typeTD.find('#CoAuthorTitleCombo option:selected');
                coAuthor.Title = controlMain.text();
                //alert('Title: ' + coAuthor.Title);

                controlMain = typeTD.find('#CoAuthorDegreeText');
                coAuthor.Degree = controlMain.attr('value');
                //alert('Degree: ' + coAuthor.Degree);

                controlMain = typeTD.find('#CoAuthorEmailText');
                coAuthor.Email = controlMain.attr('value');
                //alert('Email: ' + coAuthor.Email);

                controlMain = typeTD.find('#CoAuthorPOBoxText');
                coAuthor.POBox = controlMain.attr('value');
                //alert('POBox: ' + coAuthor.POBox);

                controlMain = typeTD.find('#CoAuthorZipCodeText');
                coAuthor.ZipCode = controlMain.attr('value');
                //alert('ZipCode: ' + coAuthor.ZipCode);

                controlMain = typeTD.find('#CoAuthorCityText');
                coAuthor.City = controlMain.attr('value');
                //alert('City: ' + coAuthor.City);

                controlMain = typeTD.find('#CoAuthorCountryText');
                coAuthor.Country = controlMain.attr('value');
                //alert('Country: ' + coAuthor.Country);

                controlMain = typeTD.find('#CoAuthorAddressText');
                coAuthor.Address = controlMain.attr('value');
                //alert('Address: ' + coAuthor.Address);

                controlMain = typeTD.find('#CoAuthorPhoneNumberAreaCodeText');
                coAuthor.PhoneNumberAreaCode = controlMain.attr('value');
                controlMain = typeTD.find('#CoAuthorPhoneNumberText');
                coAuthor.PhoneNumber = controlMain.attr('value');
                //alert('Code: ' + coAuthor.PhoneNumberAreaCode + ' Phone: ' + coAuthor.PhoneNumber);

                controlMain = typeTD.find('#CoAuthorAffilitationDepartmentText');
                coAuthor.AffilitationDepartment = controlMain.attr('value');
                //alert('AffilitationDepartment: ' + coAuthor.AffilitationDepartment);

                controlMain = typeTD.find('#CoAuthorAffilitationInstitutionHospitalText');
                coAuthor.AffilitationInstitutionHospital = controlMain.attr('value');
                //alert('AffilitationInstitutionHospital: ' + coAuthor.AffilitationInstitutionHospital);

                controlMain = typeTD.find('#CoAuthorAffilitationCityText');
                coAuthor.AffilitationCity = controlMain.attr('value');
                //alert('AffilitationCity: ' + coAuthor.AffilitationCity);

                controlMain = typeTD.find('#CoAuthorAffilitationCountryText');
                coAuthor.AffilitationCountry = controlMain.attr('value');
                //alert('AffilitationCountry: ' + coAuthor.AffilitationCountry);

                CurrentAbstractAuthors.push(coAuthor);
            });

            var jsonphone = JSON.stringify(CurrentAbstractAuthors, function (key, value) {
                return value;
            });
            AbstractSubmissionHidden.Set("CoAuthorsData", jsonphone);
        }
        function LoadCoAuthorDataFromProfile() {
            moreFields();
            var isValid = true;
            var CurrentAbstract = new Array();
            CurrentAbstractAuthors = new Array();
            var jsonStringC = AbstractSubmissionHidden.Get("CoAuthorsDataFromProfile");

            var CurrentAbstractAuthors = JSON.parse(jsonStringC, function (key, value) { return value; });
            var counter = -1;
            var total = $('#AppendCoauthors').children().count;
            var divCoAuthorsMain = $('#AppendCoauthors').children().each(function () {
                counter++;
                var typeTD = $(this).find('fieldset').find('table');
                if (counter == total - 1)
                    return;
                var coAuthor = CurrentAbstractAuthors[0];
                /************ First Name ************/
                var controlMain = typeTD.find('#CoAuthorFirstNameText');
                controlMain.attr('value', coAuthor.FirstName);
                //alert('FirstName: ' + coAuthor.FirstName);

                controlMain = typeTD.find('#CoAuthorFamilyNameText');
                controlMain.attr('value', coAuthor.FamilyName);
                //alert('FamilyName: ' + coAuthor.FamilyName);

                controlMain = typeTD.find('#CoAuthorTitleCombo option:selected');
                controlMain.text(coAuthor.Title);
                //alert('Title: ' + coAuthor.Title);

                controlMain = typeTD.find('#CoAuthorDegreeText');
                controlMain.attr('value', coAuthor.Degree);
                //alert('Degree: ' + coAuthor.Degree);

                controlMain = typeTD.find('#CoAuthorEmailText');
                controlMain.attr('value', coAuthor.Email);
                //alert('Email: ' + coAuthor.Email);

                controlMain = typeTD.find('#CoAuthorPOBoxText');
                controlMain.attr('value', coAuthor.POBox);
                //alert('POBox: ' + coAuthor.POBox);

                controlMain = typeTD.find('#CoAuthorZipCodeText');
                controlMain.attr('value', coAuthor.ZipCode);
                //alert('ZipCode: ' + coAuthor.ZipCode);

                controlMain = typeTD.find('#CoAuthorCityText');
                controlMain.attr('value', coAuthor.City);
                //alert('City: ' + coAuthor.City);

                controlMain = typeTD.find('#CoAuthorCountryText');
                controlMain.attr('value', coAuthor.Country);
                //alert('Country: ' + coAuthor.Country);

                controlMain = typeTD.find('#CoAuthorAddressText');
                controlMain.attr('value', coAuthor.Address);
                //alert('Address: ' + coAuthor.Address);

                controlMain = typeTD.find('#CoAuthorPhoneNumberAreaCodeText');
                controlMain.attr('value', coAuthor.PhoneNumberAreaCode);
                controlMain = typeTD.find('#CoAuthorPhoneNumberText');
                controlMain.attr('value', coAuthor.PhoneNumber);
                //alert('Code: ' + coAuthor.PhoneNumberAreaCode + ' Phone: ' + coAuthor.PhoneNumber);

                controlMain = typeTD.find('#CoAuthorAffilitationDepartmentText');
                controlMain.attr('value', coAuthor.AffilitationDepartment);
                //alert('AffilitationDepartment: ' + coAuthor.AffilitationDepartment);

                controlMain = typeTD.find('#CoAuthorAffilitationInstitutionHospitalText');
                controlMain.attr('value', coAuthor.AffilitationInstitutionHospital);
                //alert('AffilitationInstitutionHospital: ' + coAuthor.AffilitationInstitutionHospital);

                controlMain = typeTD.find('#CoAuthorAffilitationCityText');
                controlMain.attr('value', coAuthor.AffilitationCity);
                //alert('AffilitationCity: ' + coAuthor.AffilitationCity);

                controlMain = typeTD.find('#CoAuthorAffilitationCountryText');
                controlMain.attr('value', coAuthor.AffilitationCountry);
                //alert('AffilitationCountry: ' + coAuthor.AffilitationCountry);
                return;
            });


        }
        function SetCoAuthorsClientData() {

            var isValid = true;
            var CurrentAbstract = new Array();
            CurrentAbstractAuthors = new Array();
            var jsonStringC = AbstractSubmissionHidden.Get("CoAuthorsData");
            var CurrentAbstractAuthors = JSON.parse(jsonStringC, function (key, value) { return value; });
            var counter = -1;
            var total = $('#AppendCoauthors').children().count;
            var divCoAuthorsMain = $('#AppendCoauthors').children().each(function () {
                counter++;
                var typeTD = $(this).find('fieldset').find('table');
                if (counter == total - 1)
                    return;
                var coAuthor = CurrentAbstractAuthors[counter];
                /************ First Name ************/
                var controlMain = typeTD.find('#CoAuthorFirstNameText');
                controlMain.attr('value', coAuthor.FirstName);
                //alert('FirstName: ' + coAuthor.FirstName);

                controlMain = typeTD.find('#CoAuthorFamilyNameText');
                controlMain.attr('value', coAuthor.FamilyName);
                //alert('FamilyName: ' + coAuthor.FamilyName);

                controlMain = typeTD.find('#CoAuthorTitleCombo option:selected');
                controlMain.text(coAuthor.Title);
                //alert('Title: ' + coAuthor.Title);

                controlMain = typeTD.find('#CoAuthorDegreeText');
                controlMain.attr('value', coAuthor.Degree);
                //alert('Degree: ' + coAuthor.Degree);

                controlMain = typeTD.find('#CoAuthorEmailText');
                controlMain.attr('value', coAuthor.Email);
                //alert('Email: ' + coAuthor.Email);

                controlMain = typeTD.find('#CoAuthorPOBoxText');
                controlMain.attr('value', coAuthor.POBox);
                //alert('POBox: ' + coAuthor.POBox);

                controlMain = typeTD.find('#CoAuthorZipCodeText');
                controlMain.attr('value', coAuthor.ZipCode);
                //alert('ZipCode: ' + coAuthor.ZipCode);

                controlMain = typeTD.find('#CoAuthorCityText');
                controlMain.attr('value', coAuthor.City);
                //alert('City: ' + coAuthor.City);

                controlMain = typeTD.find('#CoAuthorCountryText');
                controlMain.attr('value', coAuthor.Country);
                //alert('Country: ' + coAuthor.Country);

                controlMain = typeTD.find('#CoAuthorAddressText');
                controlMain.attr('value', coAuthor.Address);
                //alert('Address: ' + coAuthor.Address);

                controlMain = typeTD.find('#CoAuthorPhoneNumberAreaCodeText');
                controlMain.attr('value', coAuthor.PhoneNumberAreaCode);
                controlMain = typeTD.find('#CoAuthorPhoneNumberText');
                controlMain.attr('value', coAuthor.PhoneNumber);
                //alert('Code: ' + coAuthor.PhoneNumberAreaCode + ' Phone: ' + coAuthor.PhoneNumber);

                controlMain = typeTD.find('#CoAuthorAffilitationDepartmentText');
                controlMain.attr('value', coAuthor.AffilitationDepartment);
                //alert('AffilitationDepartment: ' + coAuthor.AffilitationDepartment);

                controlMain = typeTD.find('#CoAuthorAffilitationInstitutionHospitalText');
                controlMain.attr('value', coAuthor.AffilitationInstitutionHospital);
                //alert('AffilitationInstitutionHospital: ' + coAuthor.AffilitationInstitutionHospital);

                controlMain = typeTD.find('#CoAuthorAffilitationCityText');
                controlMain.attr('value', coAuthor.AffilitationCity);
                //alert('AffilitationCity: ' + coAuthor.AffilitationCity);

                controlMain = typeTD.find('#CoAuthorAffilitationCountryText');
                controlMain.attr('value', coAuthor.AffilitationCountry);
                //alert('AffilitationCountry: ' + coAuthor.AffilitationCountry);
            });

            
        }
        function SaveStateForStep2() {
            var insertHere = document.getElementById('AppendCoauthors');
            AbstractSubmissionHidden.Set('Step2', $(insertHere).html());
        }
        function LoadStateForStep2() {

            if (currentstep != 'Step2')
                return;
            var insertHere = document.getElementById('AppendCoauthors');

            if (AbstractSubmissionHidden.Get('Step2') != null && AbstractSubmissionHidden.Get('Step2') != 'undefined')
                if (AbstractSubmissionHidden.Get('Step2') != '') {
                    $(insertHere).html(AbstractSubmissionHidden.Get('Step2'));
                    SetCoAuthorsClientData();
                }
        }

    </script>
    <script type="text/javascript">
        function Uploader_OnUploadComplete(args) {
            if (args.isValid) {
                //            txtImageUploadPath.SetText(args.callbackData);
                lblIconPath.SetText(args.callbackData);
            }
        }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <dx:ASPxHiddenField ID="AbstractSubmissionHidden" ClientInstanceName="AbstractSubmissionHidden" runat="server">
    </dx:ASPxHiddenField> 
    <br class="clear"/>
    <div style="position:relative;">

    <div id="AbstractSubmissionForm" class="StepsForm">
        <dx:ASPxCallbackPanel ID="MainCallbackPanel" ClientInstanceName="MainCallbackPanel"
        runat="server" Width="100%" LoadingDivStyle-BackColor="#A0A0A0" LoadingDivStyle-Opacity="50"
        OnCallback="MainCallbackPanel_Callback">
        <ClientSideEvents EndCallback="function(s,e){Step3Called();}" />
        <PanelCollection>
            <dx:PanelContent ID="PanelContent1" runat="server">
            <div class="SingleStep" id="Step0">
            <div class="newform">
                <ul id="topmenu">
                    <li><a href="#" class="active">Authors</a></li>
                    <li><a href="#">Abstract</a></li>
                    <li><a href="#">Review</a></li>
                    <li><a href="#">Finish</a></li>
                </ul>
                <br class="clear" />
                <fieldset style="width:100%">
                    <div id="Div4">
                        <img src="images/step-icon-02.jpg" width="18" height="18" /><img src="images/step-line-02.jpg"
                            width="75" height="18" /><img src="images/step-icon-03.jpg" width="18" height="18" /><img
                                src="images/step-line-02.jpg" width="75" height="18" /><img src="images/step-icon-03.jpg"
                                    width="18" height="18" /><img src="images/step-line-02.jpg" width="75" height="18" /><img
                                        src="images/step-icon-03.jpg" width="18" height="18" />
                    </div>
                </fieldset>
                <br class="clear" /><br />
                <fieldset style="width:100%;">
                    <p><strong><i>Pleaes Choose One of The Following</i></strong></p>
                    <dx:ASPxRadioButtonList ID="AbstractAuthorCoAuthor" ClientInstanceName="AbstractAuthorCoAuthor" runat="server" SelectedIndex="0">
                    <Items>
                    <dx:ListEditItem Text="I am the primary author" Selected="true" Value="0" />
                    <dx:ListEditItem Text="I am submitting the abstract as co author" Value="1" />
                    </Items>
                    <Border BorderStyle="None" />
                    </dx:ASPxRadioButtonList>
                </fieldset>
                <br class="clear" />
                <br />
                <fieldset style="width:100%;">
                <Rbm:ProfileInformationControl runat="server" ID="pf1" />
                </fieldset>
                <br />
                <br class="clear" />
                <table width="99%" border="0" cellspacing="0" cellpadding="0" class="formz">
                    <tr>
                        <td>
                            
                        </td>
                        <td align="right">
                            <input name="input" type="button" value="Next" class="newform-bot-01" onclick="NextStep('Step0','Step1',false)" />
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
        <div class="SingleStep" id="Step1" rel="Main Author">
            <div class="newform">
                <ul id="topmenu">
                    <li><a href="#" class="active">Authors</a></li>
                    <li><a href="#">Abstract</a></li>
                    <li><a href="#">Review</a></li>
                    <li><a href="#">Finish</a></li>
                </ul>
                <br class="clear" />
                <fieldset>
                    <div id="steps">
                        <img src="images/step-icon-02.jpg" width="18" height="18" /><img src="images/step-line-02.jpg"
                            width="75" height="18" /><img src="images/step-icon-03.jpg" width="18" height="18" /><img
                                src="images/step-line-02.jpg" width="75" height="18" /><img src="images/step-icon-03.jpg"
                                    width="18" height="18" /><img src="images/step-line-02.jpg" width="75" height="18" /><img
                                        src="images/step-icon-03.jpg" width="18" height="18" />
                    </div>
                </fieldset>
                <br class="clear" />
                <fieldset>
                    <legend>Abstract Submission</legend>
                    <table width="100%" border="0" cellspacing="5" cellpadding="5">
                        <tr>
                            <td width="18%" align="right">
                                <label>
                                    Catorgery</label>
                            </td>
                            <td width="82%" align="left" style="padding-left:20px;">
                                
                                <dx:ASPxComboBox ID="AbstractCategoryCombo" runat="server" SelectedIndex="0"  Height="25px" 
                                    ValueType="System.String" Font-Bold="False" Font-Size="15px" 
                                    ForeColor="#887679">
                                    <ClientSideEvents Validation="function(s, e) {
	if(s.GetValue() == '0'){
		e.errorText = '* Required';
		e.isValid = false;
	}
	else{
		e.isValid = true;
	}
}" />
                                    <Items>
                                        <dx:ListEditItem Text="(Select Category)" Value="0" />
                                        <dx:ListEditItem Text="Basic Science" Value="1" />
                                        <dx:ListEditItem Text="Clinical" Value="2" />
                                    </Items>
                                    <Paddings PaddingLeft="5px" />
                                    <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                        EnableCustomValidation="True" ErrorDisplayMode="Text" 
                                        ValidationGroup="Step1ValidationGroup">
                                        <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                        </ErrorFrameStyle>
                                        <RequiredField ErrorText="* Category Required" IsRequired="True" />
                                    </ValidationSettings>
                                </dx:ASPxComboBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                &nbsp;
                            </td>
                            <td>
                                <p>
                                    Select the Abstract Category</p>
                            </td>
                        </tr>
                    </table>
                </fieldset>
                <fieldset>
                    <legend>Author Infromation</legend>
                    <div class="rbmContactDetailsTable">
                    <table>
                        <tr>
                            <td width="18%" class="rbmContactInfoLabel" align="right">
                                
                                    First Name
                            </td>
                            <td width="82%" align="left" >
                                <dx:ASPxTextBox ID="AuthorFirstNameText" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                                    <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                        ErrorDisplayMode="Text" ValidationGroup="Step1ValidationGroup">
                                        <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                        </ErrorFrameStyle>
                                        <RequiredField ErrorText="* First Name Required" IsRequired="True" />
                                    </ValidationSettings>
                                </dx:ASPxTextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="rbmContactInfoLabel">
                                    Family Name
                            </td>
                            <td align="left" >
                                <dx:ASPxTextBox ID="AuthorFamilyNameText" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                                    <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                        ErrorDisplayMode="Text" ValidationGroup="Step1ValidationGroup">
                                        <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                        </ErrorFrameStyle>
                                        <RequiredField ErrorText="* Family Name Required" IsRequired="True" />
                                    </ValidationSettings>
                                </dx:ASPxTextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="rbmContactInfoLabel">
                                
                                    Title
                            </td>
                            <td align="left" >
                                <dx:ASPxComboBox ID="AuthorTitleCombo" runat="server" SelectedIndex="0"  
                                    ValueType="System.String" Font-Bold="False" Font-Size="15px" Width="100px"
                                    ForeColor="#887679">
                                    <Items>
                                        <dx:ListEditItem Text="Dr." Value="0" />
                                        <dx:ListEditItem Text="Prof." Value="1" />
                                        <dx:ListEditItem Text="Mr." Value="2" />
                                        <dx:ListEditItem Text="Miss." Value="3" />
                                        <dx:ListEditItem Text="Mrs." Value="4" />
                                        <dx:ListEditItem Text="Ms." Value="5" />
                                    </Items>
                                    <Paddings PaddingLeft="5px" />
                                </dx:ASPxComboBox>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="rbmContactInfoLabel">
                                
                                    Degree
                            </td>
                            <td align="left" >
                                <dx:ASPxTextBox ID="AuthorDegreeText" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                                </dx:ASPxTextBox>
                                
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="rbmContactInfoLabel">
                                
                                    Email
                            </td>
                            <td align="left" >
                                <dx:ASPxTextBox ID="AuthorEmailText" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                                    <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                        ErrorDisplayMode="Text" ValidationGroup="Step1ValidationGroup">
                                        <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                        </ErrorFrameStyle>
                                        <RequiredField ErrorText="* Email Required" IsRequired="True" />
                                    </ValidationSettings>
                                </dx:ASPxTextBox>
                                
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="rbmContactInfoLabel">
                                    PO BOX
                            </td>
                            <td align="left" > 
                                <dx:ASPxTextBox ID="AuthorPOBoxText" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                                </dx:ASPxTextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="rbmContactInfoLabel">
                                    Zip Code
                            </td>
                            <td align="left" >
                            <dx:ASPxTextBox ID="AuthorZipCodeText" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                                </dx:ASPxTextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="rbmContactInfoLabel">
                                    City
                            </td>
                            <td align="left" >
                            <dx:ASPxTextBox ID="AuthorCityText" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                            </dx:ASPxTextBox>
                                
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="rbmContactInfoLabel">
                                    Country
                            </td>
                            <td align="left" >
                                <dx:ASPxTextBox ID="AuthorCountryText" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                                </dx:ASPxTextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="rbmContactInfoLabel">
                                    Address
                            </td>
                            <td align="left" >
                                <dx:ASPxTextBox ID="AuthorAddressText" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                                </dx:ASPxTextBox>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="rbmContactInfoLabel">
                                
                                    Phone number
                            </td>
                            <td align="left" >
                                <table>
                                    <tr>
                                        <td>
                                        <dx:ASPxTextBox ID="AuthorPhoneNumberAreaCodeText" runat="server" Width="50px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                                            <ValidationSettings Display="Dynamic" 
                                                ErrorDisplayMode="Text" ValidationGroup="Step1ValidationGroup">
                                                <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                                </ErrorFrameStyle>
                                                <RequiredField ErrorText="Required" />
                                            </ValidationSettings>
                                </dx:ASPxTextBox>
                                        </td>
                                        <td style="padding-left:10px;">
                                        <dx:ASPxTextBox ID="AuthorPhoneNumberText" runat="server" Width="190px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887">
                                            <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                                ErrorDisplayMode="Text" ValidationGroup="Step1ValidationGroup">
                                                <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                                </ErrorFrameStyle>
                                                <RequiredField ErrorText="* Phone Number Required" IsRequired="True" />
                                            </ValidationSettings>
                                </dx:ASPxTextBox>
                                        </td>
                                    </tr>
                                </table>
                                
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                &nbsp;
                            </td>
                            <td>
                                <p>
                                     Code&nbsp; &nbsp;+ &nbsp;&nbsp;&nbsp;Phone Number</p>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="rbmContactInfoLabel">
                                    Affliation
                            </td>
                            <td align="left" >
                                <dx:ASPxTextBox ID="AuthorDepartmentText" runat="server" Width="250px" 
                                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887" NullText="Department">
                                </dx:ASPxTextBox>
                                
                                <br />
                            </td>
                        </tr>
                        
                        <tr>
                            <td align="right">
                                &nbsp;
                            </td>
                            <td >
                                <dx:ASPxTextBox ID="AuthorInstitutionHospitalText" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887"
                                     NullText="Institution / Hospital">
                                </dx:ASPxTextBox>
                                
                            </td>
                        </tr>
                        
                        <tr>
                            <td align="right">
                                &nbsp;
                            </td>
                            <td >
                                <dx:ASPxTextBox ID="AuthorAffilitationCityText" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887" NullText="City">
                                </dx:ASPxTextBox>
                                
                            </td>
                        </tr>
                        
                        <tr>
                            <td align="right">
                                &nbsp;
                            </td>
                            <td >
                                <dx:ASPxTextBox ID="AuthorAffilitationCountryText" runat="server" Width="250px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" ForeColor="#667887" NullText="Country">
                                </dx:ASPxTextBox>
                            </td>
                        </tr>
                       <tr>
                        <td colspan="2">
                            
                         <dx:ASPxValidationSummary ID="Step1AbstractValidationSummary" runat="server"  
                        ValidationGroup="Step1ValidationGroup" BackColor="#FBE3E4" 
                        ShowErrorsInEditors="True" Width="100%" HeaderText="Missing Information">
                        <HeaderStyle Font-Bold="False" Font-Size="16px" />
                        <Border BorderColor="#FBC2C4" BorderStyle="Solid" BorderWidth="2px" />
                    </dx:ASPxValidationSummary>
                        </td>
                       </tr>
                    </table>
                    </div>
                </fieldset>
                <br class="clear" />
                <table width="99%" border="0" cellspacing="0" cellpadding="0" class="formz">
                    <tr>
                        <td>
                            <input name="input" type="button" value="Back" class="newform-bot-01" onclick="NextStep('Step1','Step0',false)" />
                        </td>
                        <td align="right">
                            <input name="input" type="button" value="Next" class="newform-bot-01" onclick="NextStep('Step1','Step2',false)" />
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
        <div class="SingleStep" id="Step2" rel="Co Author">
            <div class="newform">
                <ul id="topmenu">
                    <li><a href="#">Authors</a></li>
                    <li><a href="#" class="active">Abstract</a></li>
                    <li><a href="#">Review</a></li>
                    <li><a href="#">Finish</a></li>
                </ul>
                <br class="clear" />
                <fieldset>
                    <div id="Div1">
                        <img src="images/step-icon-02.jpg" width="18" height="18" /><img src="images/step-line-02.jpg"
                            width="75" height="18" /><img src="images/step-icon-03.jpg" width="18" height="18" /><img
                                src="images/step-line-02.jpg" width="75" height="18" /><img src="images/step-icon-03.jpg"
                                    width="18" height="18" /><img src="images/step-line-02.jpg" width="75" height="18" /><img
                                        src="images/step-icon-03.jpg" width="18" height="18" />
                    </div>
                </fieldset>
                <br class="clear" />
                <br />
                <div id="readroot" style="display: none">
                    <div id="readroots" style="margin-bottom: 10px;">
                        <fieldset>
                            <legend>Co-Author</legend>
                            <table width="100%" border="0" cellspacing="5" cellpadding="5" class="formz">
                                <tr style="padding-top:5px;">
                                    <td width="18%" align="right">
                                        <label>
                                            First Name</label>
                                    </td>
                                    <td width="82%" align="left">
                                        <table style="width:100%;">
                                            <tr>
                                                <td>
                                                <table>
                                                    <tr>
                                                        <td>
                                                <input id="CoAuthorFirstNameText" name="textfield" type="text" class="newform-txt required"
                                            size="30" />        
                                                        </td>
                                                        <td>
                                                            <p style="color:#CC0000;font-size:12px;" id="CoAuthorFirstNameTextError"></p>
                                                        </td>
                                                    </tr>
                                                </table>
                                                
                                            
                                            </td>
                                            
                                                <td>
                                                <input type="button" id="close" onclick="this.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.removeChild(this.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode);"
                                            class="newform-close fixright" /><br class="clear" />
                                            </td>
                                            </tr>
                                        </table>
                                        
                                        
                                    </td>
                                </tr>
                                <tr style="padding-top:5px;">
                                    <td align="right" style="padding-top:5px;">
                                        <label>
                                            Family Name</label>
                                    </td>
                                    <td align="left" style="padding-top:5px;">
                                        
                                        <table>
                                            <tr>
                                                <td>
                                                    <input name="textfield2" type="text" class="newform-txt" id="CoAuthorFamilyNameText"
                                            size="30" />
                                                </td>
                                                <td>
                                                <p style="color:#CC0000;font-size:12px;" id="CoAuthorFamilyNameTextError"></p>
                                                </td>
                                            </tr>
                                        </table>
                                        
                                        <br />
                                    </td>
                                </tr>
                                <tr style="padding-top:5px;">
                                    <td align="right" style="padding-top:5px;">
                                        <label>
                                            Title</label>
                                    </td>
                                    <td align="left" style="padding-top:5px;">
                                        
                                        <select name="select3" class="newform-list" id="CoAuthorTitleCombo">
                                            <option>Dr.</option>
                                            <option>Prof.</option>
                                            <option>Mr.</option>
                                            <option>Miss.</option>
                                            <option>Mrs.</option>
                                            <option>Ms.</option>
                                        </select>
                                        <br />
                                    </td>
                                </tr>
                                <tr style="padding-top:5px;">
                                    <td align="right" style="padding-top:5px;">
                                        <label>
                                            Degree</label>
                                    </td>
                                    <td align="left" style="padding-top:5px;">
                                        <input name="textfield2" type="text" class="newform-txt" id="CoAuthorDegreeText"
                                            size="30" />
                                        <br />
                                    </td>
                                </tr>
                                <tr style="padding-top:5px;">
                                    <td align="right" style="padding-top:5px;">
                                        <label>
                                            Email</label>
                                    </td>
                                    <td align="left" style="padding-top:5px;">
                                        <table>
                                            <tr>
                                                <td>
                                                    <input name="textfield2" type="text" class="newform-txt" id="CoAuthorEmailText" size="30" />
                                                </td>
                                                <td>
                                                <p style="color:#CC0000;font-size:12px;" id="CoAuthorEmailTextError"></p>
                                                </td>
                                            </tr>
                                        </table>
                                        
                                        <br />
                                    </td>
                                </tr>
                                <tr style="padding-top:5px;">
                                    <td align="right" style="padding-top:5px;">
                                        &nbsp;
                                    </td>
                                    <td style="padding-top:5px;">
                                        <p>
                                            Enter your primary contact email address.</p>
                                    </td>
                                </tr>
                                <tr style="padding-top:5px;">
                                    <td align="right">
                                        <label>
                                            PO BOX</label>
                                    </td>
                                    <td align="left">
                                        <input name="textfield15" type="text" class="newform-txt" id="CoAuthorPOBoxText"
                                            size="30" />
                                    </td>
                                </tr>
                                <tr style="padding-top:5px;">
                                    <td align="right" style="padding-top:5px;">
                                        <label>
                                            Zip Code</label>
                                    </td>
                                    <td align="left" style="padding-top:5px;">
                                        <input name="textfield16" type="text" class="newform-txt" id="CoAuthorZipCodeText"
                                            size="30" />
                                    </td>
                                </tr>
                                <tr style="padding-top:5px;">
                                    <td align="right" style="padding-top:5px;">
                                        <label>
                                            City</label>
                                    </td>
                                    <td align="left" style="padding-top:5px;">
                                        <input name="textfield17" type="text" class="newform-txt" id="CoAuthorCityText" size="30" />
                                    </td>
                                </tr>
                                <tr style="padding-top:5px;">
                                    <td align="right" style="padding-top:5px;">
                                        <label>
                                            Country</label>
                                    </td>
                                    <td align="left" style="padding-top:5px;">
                                        <input name="textfield18" type="text" class="newform-txt" id="CoAuthorCountryText"
                                            size="30" />
                                    </td>
                                </tr>
                                <tr style="padding-top:5px;">
                                    <td align="right" style="padding-top:5px;">
                                        <label>
                                            Address</label>
                                    </td>
                                    <td align="left" style="padding-top:5px;">
                                        <input name="textfield3" type="text" class="newform-txt" id="CoAuthorAddressText"
                                            size="60" />
                                        <br />
                                    </td>
                                </tr>
                                <tr style="padding-top:5px;">
                                    <td align="right" style="padding-top:5px;">
                                        <label>
                                            Phone number</label>
                                    </td>
                                    <td align="left" style="padding-top:5px;">
                                        <table>
                                            <tr>
                                                <td>
                                                 <input name="textfield3" type="text" class="newform-txt" id="CoAuthorPhoneNumberAreaCodeText"
                                            size="4" />
                                                </td>
                                                <td>
                                                 <input name="textfield4" type="text" class="newform-txt" id="CoAuthorPhoneNumberText"
                                            size="22" />
                                                </td>
                                                <td>
                                                    <p style="color:#CC0000;font-size:12px;" id="CoAuthorPhoneNumberTextError"></p>
                                                </td>
                                            </tr>
                                        </table>
                                       
                                       
                                        <br />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        &nbsp;
                                    </td>
                                    <td>
                                        <p>
                                            Area code + Phone Number</p>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <label>
                                            Affliation</label>
                                    </td>
                                    <td align="left">
                                        <input name="textfield5" type="text" class="newform-txt" id="CoAuthorAffilitationDepartmentText"
                                            size="30" />
                                        <br />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        &nbsp;
                                    </td>
                                    <td>
                                        <p>
                                            Department</p>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        &nbsp;
                                    </td>
                                    <td>
                                        <input name="textfield6" type="text" class="newform-txt" id="CoAuthorAffilitationInstitutionHospitalText"
                                            size="30" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        &nbsp;
                                    </td>
                                    <td>
                                        <p>
                                            Institution/Hospital</p>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        &nbsp;
                                    </td>
                                    <td>
                                        <input name="textfield7" type="text" class="newform-txt" id="CoAuthorAffilitationCityText"
                                            size="30" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        &nbsp;
                                    </td>
                                    <td>
                                        <p>
                                            City</p>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        &nbsp;
                                    </td>
                                    <td>
                                        <input name="textfield8" type="text" class="newform-txt" id="CoAuthorAffilitationCountryText"
                                            size="30" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        &nbsp;
                                    </td>
                                    <td>
                                        <p>
                                            Country</p>
                                    </td>
                                </tr>
                            </table>
                        </fieldset>
                    </div>
                </div>
                <%--<div id="AppendCoauthors" style="width: 100%; background-color: Blue;height:20px;">
                                <div >&nbsp;</div>
                                <span>&nbsp;</span>
                            </div>--%>
                <div id="AppendCoauthors">
                    <div id="afterappendcoauthors">
                    </div>
                </div>
                <br />
                <fieldset>
                    <table width="100%" border="0" cellspacing="5" cellpadding="5">
                        <tr>
                            <td width="91%" align="right">
                                <label>
                                    Add Co Author</label>
                            </td>
                            <td width="9%" align="right">
                                <input type="button" name="add" id="add" onclick="moreFields();" class="newform-add" />
                            </td>
                        </tr>
                    </table>
                </fieldset>
                <p>
                    &nbsp;</p>
                <table width="99%" border="0" cellspacing="0" cellpadding="0" class="formz">
                    <tr>
                        <td>
                            <input name="input" type="button" value="Back" class="newform-bot-01" onclick="NextStep('Step2','Step1',true)" />
                        </td>
                        <td align="right">
                            <input name="input" type="button" value="Next" class="newform-bot-01" onclick="NextStep('Step2','Step3',true)" />
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
        <div class="SingleStep" id="Step3" rel="Abstract Data">
        <div class="newform" >
            <ul id="topmenu">
                <li><a href="#">Authors</a></li>
                <li><a href="#" class="active">Abstract</a></li>
                <li><a href="#">Review</a></li>
                <li><a href="#">Finish</a></li>
            </ul>
            <br class="clear" />
            <fieldset>
                <div id="Div2">
                    <img src="images/step-icon-01.jpg" width="18" height="18" /><img src="images/step-line-01.jpg"
                        width="75" height="18" /><img src="images/step-icon-01.jpg" width="18" height="18" /><img
                            src="images/step-line-01.jpg" width="75" height="18" /><img src="images/step-icon-02.jpg"
                                width="18" height="18" /><img src="images/step-line-02.jpg" width="75" height="18" /><img
                                    src="images/step-icon-03.jpg" width="18" height="18" />
                </div>
            </fieldset>
            <br class="clear" />
            <fieldset>
                <legend>Abstract</legend>
                <table width="100%" border="0" cellspacing="5" cellpadding="5" class="formz">
                    <tr>
                        <td width="18%" align="right">
                            <label>
                                Title</label>
                        </td>
                        <td width="82%" align="left" style="padding-left:12px;padding-top:15px;">
                        <dx:ASPxMemo ID="AbstractTitleText" runat="server" Height="71px" Width="350px">
                             <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                        ErrorDisplayMode="Text" ValidationGroup="Step3ValidationGroup">
                                        <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                        </ErrorFrameStyle>
                                        <RequiredField ErrorText="* Required" IsRequired="True" />
                                    </ValidationSettings>
                            </dx:ASPxMemo>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="padding-left:12px;padding-top:15px;">
                            <label>
                                Background</label>
                        </td>
                        <td align="left" style="padding-left:12px;padding-top:15px;">
                        <div>
                            <dx:ASPxMemo ID="AbstractBackgroundText" runat="server" Height="71px" Width="350px">
                             <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                        ErrorDisplayMode="Text" ValidationGroup="Step3ValidationGroup">
                                        <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                        </ErrorFrameStyle>
                                        <RequiredField ErrorText="* Required" IsRequired="True" />
                                    </ValidationSettings>
                            </dx:ASPxMemo>
                            
                            <%--<textarea runat="server" id="AbstractBackgroundText" rows="10" cols="5" style="width: 400px;"></textarea>--%>
                            
                            </div>
                            <%--<input name="textfield2" type="text" class="newform-txt" id="text14" size="30" />--%>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="padding-left:12px;padding-top:15px;">
                            <label>
                                Methods</label>
                        </td>
                        <td align="left" style="padding-left:12px;padding-top:15px;">
                            <dx:ASPxMemo ID="AbstractMethodsText" runat="server" Height="71px" Width="350px">
                             <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                        ErrorDisplayMode="Text" ValidationGroup="Step3ValidationGroup">
                                        <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                        </ErrorFrameStyle>
                                        <RequiredField ErrorText="* Required" IsRequired="True" />
                                    </ValidationSettings>
                            </dx:ASPxMemo>
                            
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="padding-left:12px;padding-top:15px;">
                            <label>
                                Results</label>
                        </td>
                        <td align="left" style="padding-left:12px;padding-top:15px;">
                            <dx:ASPxMemo ID="AbstractResultsText" runat="server" Height="71px" Width="350px">
                             <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                        ErrorDisplayMode="Text" ValidationGroup="Step3ValidationGroup">
                                        <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                        </ErrorFrameStyle>
                                        <RequiredField ErrorText="* Required" IsRequired="True" />
                                    </ValidationSettings>
                            </dx:ASPxMemo>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="padding-left:12px;padding-top:15px;">
                            <label>
                                Conclusion</label>
                        </td>
                        <td align="left" style="padding-left:12px;padding-top:15px;">
                            <dx:ASPxMemo ID="AbstractConclusionText" runat="server" Height="71px" Width="350px">
                             <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                        ErrorDisplayMode="Text" ValidationGroup="Step3ValidationGroup">
                                        <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                        </ErrorFrameStyle>
                                        <RequiredField ErrorText="* Required" IsRequired="True" />
                                    </ValidationSettings>
                            </dx:ASPxMemo>
                            
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <label>
                                Keywords</label>
                        </td>
                        <td align="left">
                            <input runat="server" name="textfield9" type="text" class="newform-txt" id="AbstractKeyword1"
                                size="30" />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            &nbsp;
                        </td>
                        <td>
                            <p>
                                Keyword 1</p>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            &nbsp;
                        </td>
                        <td>
                            <input name="textfield6" type="text" class="newform-txt" runat="server" id="AbstractKeyword2"
                                size="30" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            &nbsp;
                        </td>
                        <td>
                            <p>
                                Keyword 2</p>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            &nbsp;
                        </td>
                        <td>
                            <input name="textfield7" type="text" class="newform-txt" runat="server" id="AbstractKeyword3"
                                size="30" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            &nbsp;
                        </td>
                        <td>
                            <p>
                                Keyword 3</p>
                        </td>
                    </tr>
                </table>
            </fieldset>
            <br />
            <fieldset>
                <legend>Documents</legend>
                <table width="100%" border="0" cellpadding="5" cellspacing="5" class="formz">
                    <tr>
                        <td align="right" style="padding-left:12px;padding-top:15px;">
                           
                        </td>
                        <td align="left" style="padding-left:12px;padding-top:15px;">
                            <dx:ASPxUploadControl ID="conferenceLogoUpload" ClientInstanceName="conferenceLogoUpload"
                                runat="server" ShowProgressPanel="True" ShowUploadButton="True" OnFileUploadComplete="conferenceLogoUpload_FileUploadComplete">
                                <ClientSideEvents FileUploadComplete="function(s, e) {
	Uploader_OnUploadComplete(e);
}" />
                            </dx:ASPxUploadControl>
                            <br />
                            <p>Please select browse for a file then click on the upload link</p>
                            <br />
                            <dx:ASPxLabel ID="lblIconPath" runat="server" ClientInstanceName="lblIconPath">
                            </dx:ASPxLabel>
                            <br />
                        </td>
                        <td align="left">
                        </td>
                    </tr>
                </table>
            </fieldset>
            <p>
                &nbsp;</p>
            <table width="99%" border="0" cellspacing="0" cellpadding="0" class="formz">
                <tr>
                    <td>
                        <input name="input" type="button" value="Back" class="newform-bot-01" onclick="NextStep('Step3','Step2',false)" />
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
        <div class="SingleStep" id="Step4" rel="Review and Submit">
        <div class="newform">
                            <ul id="topmenu">
                                <li><a href="#">Authors</a></li>
                                <li><a href="#">Abstract</a></li>
                                <li><a href="#">Review</a></li>
                                <li><a href="#" class="active">Finish</a></li>
                            </ul>
                            <br class="clear" />
                            <fieldset>
                                <div id="Div3">
                                    <img src="images/step-icon-01.jpg" width="18" height="18" /><img src="images/step-line-01.jpg"
                                        width="75" height="18" /><img src="images/step-icon-01.jpg" width="18" height="18" /><img
                                            src="images/step-line-01.jpg" width="75" height="18" /><img src="images/step-icon-01.jpg"
                                                width="18" height="18" /><img src="images/step-line-01.jpg" width="75" height="18" /><img
                                                    src="images/step-icon-02.jpg" width="18" height="18" />
                                </div>
                            </fieldset>
                            <br class="clear" />
                            <div style="width:670px;overflow:auto;">
                            <fieldset >
                                <legend>Abstract Preview</legend>
                                <div>
                                <Rbm:ReportViewerControl runat="server" ID="AbstractPreviewReport"></Rbm:ReportViewerControl>
                                    <%--<dx:ASPxCallbackPanel runat="server" id="AbstractPreviewReportCallbackPanel" Width="100%" OnCallback="AbstractPreviewReportCallbackPanel_Callback">
                                        <PanelCollection>
                                            <dx:PanelContent ID="PanelContent2" runat="server">
                                                
                                            </dx:PanelContent>
                                        </PanelCollection>
                                    </dx:ASPxCallbackPanel>--%>
                                
                                </div>
                                <br />
                            </fieldset>
                            </div>
                            
                            <br class="clear" />
                            <fieldset>
                                <legend>
                                    Confirm Submission
                                </legend>
                                <p>
                                    <dx:ASPxCheckBox ID="chkConfirmSubmission" runat="server" Text="By checking this textbox you confirm that all the information entered is correct">
                                        <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                        ErrorDisplayMode="Text" ValidationGroup="Step4ValidationGroup">
                                        <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                        </ErrorFrameStyle>
                                        <RequiredField ErrorText="* Required" IsRequired="True" />
                                    </ValidationSettings>
                                    </dx:ASPxCheckBox>
                                    
                                </p>
                            </fieldset>
                            <p>
                                &nbsp;</p>
                             <table width="99%" border="0" cellspacing="0" cellpadding="0" class="formz">
                                <tr>
                                    <td>
                                        <input name="input" type="button" value="Back" class="newform-bot-01" onclick="NextStep('Step4','Step3',false)" />
                                    </td>
                                    <td align="right">
                                        <input name="input" type="button" value="Submit" class="newform-bot-01" onclick="NextStep('Step4','Step5',false)" />
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
        <div class="SingleStep" id="Step5" rel="Final Step">
        <div class="newform">
        <br class="clear" />
        <br />
            <div runat="server" id="AbstractSubmissionMessage"></div>
        </div>
        </div>
        </dx:PanelContent>
        </PanelCollection>
        </dx:ASPxCallbackPanel>

    </div>
    </div>
</asp:Content>
