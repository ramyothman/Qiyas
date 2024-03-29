﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Conference.Master"
    AutoEventWireup="true" CodeBehind="AbstractSubmissions.aspx.cs" Inherits="SocioBuilderSite.Conferences.AbstractSubmissions" %>

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
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<script src="Scripts/custom-form-elements.js" type="text/javascript"></script>--%>
    <%--<script src="Scripts/formToWizard.js" type="text/javascript"></script>--%>
    <script type="text/javascript" src="Scripts/JSON.js"></script>
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
        var counter = 0;
        var currentstep = 'step1';
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

        function SaveStateForStep2() {
            var insertHere = document.getElementById('AppendCoauthors');
            Step2HiddenField.Set('Step2', $(insertHere).html());
            GetContactData();
        }
        function GetContactData() {
            /*
            CurrentAbstract.MainAuthor.FamilyName = AuthorFamilyNameText.Value;
            CurrentAbstract.MainAuthor.FirstName = AuthorFirstNameText.Value;
            CurrentAbstract.MainAuthor.Title = AuthorTitleCombo.Value;
            CurrentAbstract.MainAuthor.Degree = AuthorDegreeText.Value;
            CurrentAbstract.MainAuthor.Email = AuthorEmailText.Value;
            CurrentAbstract.MainAuthor.POBox = AuthorPOBoxText.Value;
            CurrentAbstract.MainAuthor.ZipCode = AuthorZipCodeText.Value;
            CurrentAbstract.MainAuthor.City = AuthorCityText.Value;
            CurrentAbstract.MainAuthor.Country = AuthorCountryText.Value;
            CurrentAbstract.MainAuthor.Address = AuthorAddressText.Value;
            CurrentAbstract.MainAuthor.PhoneNumber = AuthorPhoneNumberText.Value;
            CurrentAbstract.MainAuthor.PhoneNumberAreaCode = AuthorPhoneNumberAreaCodeText.Value;
            CurrentAbstract.MainAuthor.AffilitationCity = AuthorAffilitationCityText.Value;
            CurrentAbstract.MainAuthor.AffilitationCountry = AuthorAffilitationCountryText.Value;
            CurrentAbstract.MainAuthor.AffilitationDepartment = AuthorDepartmentText.Value;
            CurrentAbstract.MainAuthor.AffilitationInstitutionHospital = AuthorInstitutionHospitalText.Value;
            ====================================================================
            */

            var CurrentAbstract = new Array();
            CurrentAbstractAuthors = new Array();
            var divCoAuthorsMain = $('#AppendCoauthors').children().each(function () {
                var tableControl = $(this).find('fieldset').find('table');
                var ico = 0;
                var coAuthor = new Object();
                var tableRows = $(this).find('fieldset').find('table tr');
                var divCoAuthors = tableRows.each(function () {
                    var typeTD = $(this).find('td').eq(1);
                    ico++;
                    var controlMain = null;
                    if (ico == 1) {
                        controlMain = typeTD.find('#CoAuthorFirstNameText');
                        coAuthor.FirstName = controlMain.attr('value');
                    }
                    else if (ico == 2) {
                        controlMain = typeTD.find('#CoAuthorFamilyNameText');
                        coAuthor.FamilyName = controlMain.attr('value');
                    }
                    else if (ico == 3) {
                        controlMain = typeTD.find('#CoAuthorTitleCombo option:selected');
                        coAuthor.Title = controlMain.text();
                    }
                    else if (ico == 4) {
                        controlMain = typeTD.find('#CoAuthorDegreeText');
                        coAuthor.Degree = controlMain.attr('value');
                    }
                    else if (ico == 5) {
                        controlMain = typeTD.find('#CoAuthorEmailText');
                        coAuthor.Email = controlMain.attr('value');
                    }
                    else if (ico == 7) {
                        controlMain = typeTD.find('#CoAuthorPOBoxText');
                        coAuthor.POBox = controlMain.attr('value');
                    }
                    else if (ico == 8) {
                        controlMain = typeTD.find('#CoAuthorZipCodeText');
                        coAuthor.ZipCode = controlMain.attr('value');
                    }
                    else if (ico == 9) {
                        controlMain = typeTD.find('#CoAuthorCityText');
                        coAuthor.City = controlMain.attr('value');
                    }
                    else if (ico == 10) {
                        controlMain = typeTD.find('#CoAuthorCountryText');
                        coAuthor.Country = controlMain.attr('value');
                    }
                    else if (ico == 11) {
                        controlMain = typeTD.find('#CoAuthorAddressText');
                        coAuthor.Address = controlMain.attr('value');
                    }
                    else if (ico == 12) {
                        controlMain = typeTD.find('#CoAuthorPhoneNumberAreaCodeText');
                        coAuthor.PhoneNumberAreaCode = controlMain.attr('value');
                        controlMain = typeTD.find('#CoAuthorPhoneNumberText');
                        coAuthor.PhoneNumber = controlMain.attr('value');
                    }
                    else if (ico == 14) {
                        controlMain = typeTD.find('#CoAuthorAffilitationDepartmentText');
                        coAuthor.AffilitationDepartment = controlMain.attr('value');
                    }
                    else if (ico == 16) {
                        controlMain = typeTD.find('#CoAuthorAffilitationInstitutionHospitalText');
                        coAuthor.AffilitationInstitutionHospital = controlMain.attr('value');
                    }
                    else if (ico == 18) {
                        controlMain = typeTD.find('#CoAuthorAffilitationCityText');
                        coAuthor.AffilitationCity = controlMain.attr('value');
                    }
                    else if (ico == 20) {
                        controlMain = typeTD.find('#CoAuthorAffilitationCountryText');
                        coAuthor.AffilitationCountry = controlMain.attr('value');
                    }

                });
                //alert(coAuthor.FirstName + ' ' + coAuthor.FamilyName);
                CurrentAbstractAuthors.push(coAuthor);
            });
            var jsonphone = JSON.stringify(CurrentAbstractAuthors, function (key, value) {
                return value;
            });
            Step2HiddenField.Set("CoAuthorsData", jsonphone);
            /*
            var i = 0;
            var personPhones = new Array();
            var personEmails = new Array();
            $('#personPhoneTable tr').each(function () {
                if (i == 0) {
                    i = i + 1;
                }
                else {
                    var type = $(this).find("td").eq(0).attr('rel');
                    var phone = $(this).find("td").eq(1).html();
                    var personphone = new Object();
                    personphone.PhoneNumber = phone;
                    personphone.PhoneNumberTypeId = type;
                    personPhones.push(personphone);
                }
            });
            i = 0;
            $('#personEmailTable tr').each(function () {
                if (i == 0) {
                    i = i + 1;
                }
                else {
                    var type = $(this).find("td").eq(0).attr('rel');
                    var email = $(this).find("td").eq(1).html();
                    var personemail = new Object();
                    personemail.EmailAddressTypeId = type;
                    personemail.Email = email;
                    personEmails.push(personemail);
                }
            });

            
            personPhoneHiddenField.Set("jsonStringSetPhone", jsonphone);
            var jsonemail = JSON.stringify(personEmails, function (key, value) {
                return value;
            });
            personEmailHiddenField.Set("jsonStringSetEmail", jsonemail);
            */
        }
        function MoveStep(step,savestep,oldstep) {
            currentstep = step;
            if (savestep) {
                SaveStateForStep2();
                var jsonData = Step2HiddenField.Get("CoAuthorsData");
                MainCallbackPanel.PerformCallback(step + ';' + oldstep + ';' + jsonData);
            }
            else {
                MainCallbackPanel.PerformCallback(step + ';' + oldstep);
            }
        }

        function LoadStateForStep2() {

            if (currentstep != 'step2')
                return;
            var insertHere = document.getElementById('AppendCoauthors');

            if (Step2HiddenField.Get('Step2') != null && Step2HiddenField.Get('Step2') != 'undefined')
                if (Step2HiddenField.Get('Step2') != '') {
                    $(insertHere).html(Step2HiddenField.Get('Step2'));
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
    <dx:ASPxHiddenField ID="Step2HiddenField" ClientInstanceName="Step2HiddenField" runat="server">
    </dx:ASPxHiddenField>
    <dx:ASPxCallbackPanel ID="MainCallbackPanel" ClientInstanceName="MainCallbackPanel"
        runat="server" Width="100%" LoadingDivStyle-BackColor="#A0A0A0" LoadingDivStyle-Opacity="50"
        OnCallback="MainCallbackPanel_Callback">
        <ClientSideEvents EndCallback="function(s,e){ LoadStateForStep2();}" />
        <PanelCollection>
            <dx:PanelContent runat="server">
            
            
            
                                                
                                                
                <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                    <asp:View runat="server" ID="Step1">
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
                                        <td width="82%" align="left">
                                            <select runat="server" name="select3" class="newform-list" id="AbstractCategoryCombo">
                                                <option value="0">(Select Category)</option>
                                                <option value="1">Basic Science</option>
                                                <option value="2">Clinical</option>
                                            </select>
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
                                <table width="100%" border="0" cellspacing="5" cellpadding="5" class="formz">
                                    <tr>
                                        <td width="18%" align="right">
                                            <label>
                                                First Name</label>
                                        </td>
                                        <td width="82%" align="left">
                                            
                                            <asp:TextBox runat="server" ID="AuthorFirstNameText" CssClass="newform-txt" Font-Size="19"></asp:TextBox>
                                            <%--<input runat="server" id="AuthorFirstNameText" name="textfield" type="text" class="newform-txt"
                                                size="30" />--%><br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <label>
                                                Family Name</label>
                                        </td>
                                        <td align="left">
                                            <input name="textfield2" type="text" class="newform-txt" runat="server" id="AuthorFamilyNameText"
                                                size="30" />
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <label>
                                                Title</label>
                                        </td>
                                        <td align="left">
                                            <select runat="server" name="select3" class="newform-list" id="AuthorTitleCombo">
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
                                    <tr>
                                        <td align="right">
                                            <label>
                                                Degree</label>
                                        </td>
                                        <td align="left">
                                            <input name="textfield2" type="text" class="newform-txt" runat="server" id="AuthorDegreeText"
                                                size="30" />
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <label>
                                                Email</label>
                                        </td>
                                        <td align="left">
                                            <input name="textfield2" type="text" class="newform-txt" runat="server" id="AuthorEmailText"
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
                                                Enter your primary contact email address.</p>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <label>
                                                PO BOX</label>
                                        </td>
                                        <td align="left">
                                            <input name="textfield15" type="text" class="newform-txt" runat="server" id="AuthorPOBoxText"
                                                size="30" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <label>
                                                Zip Code</label>
                                        </td>
                                        <td align="left">
                                            <input name="textfield16" type="text" class="newform-txt" runat="server" id="AuthorZipCodeText"
                                                size="30" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <label>
                                                City</label>
                                        </td>
                                        <td align="left">
                                            <input name="textfield17" type="text" class="newform-txt" runat="server" id="AuthorCityText"
                                                size="30" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <label>
                                                Country</label>
                                        </td>
                                        <td align="left">
                                            <input name="textfield18" type="text" class="newform-txt" runat="server" id="AuthorCountryText"
                                                size="30" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <label>
                                                Address</label>
                                        </td>
                                        <td align="left">
                                            <input name="textfield3" type="text" class="newform-txt" runat="server" id="AuthorAddressText"
                                                size="60" />
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <label>
                                                Phone number</label>
                                        </td>
                                        <td align="left">
                                            <input name="textfield3" type="text" class="newform-txt" runat="server" id="AuthorPhoneNumberAreaCodeText"
                                                size="4" />
                                            <input name="textfield4" type="text" class="newform-txt" runat="server" id="AuthorPhoneNumberText"
                                                size="22" />
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
                                            <input name="textfield5" type="text" class="newform-txt" runat="server" id="AuthorDepartmentText"
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
                                            <input name="textfield6" type="text" class="newform-txt" runat="server" id="AuthorInstitutionHospitalText"
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
                                            <input name="textfield7" type="text" class="newform-txt" runat="server" id="AuthorAffilitationCityText"
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
                                            <input name="textfield8" type="text" class="newform-txt" runat="server" id="AuthorAffilitationCountryText"
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
                            <table width="99%" border="0" cellspacing="0" cellpadding="0" class="formz">
                                <tr>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td align="right">
                                        <input name="input" type="button" value="Next" class="newform-bot-01" onclick="MoveStep('step2',false,'step1');" />
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
                    </asp:View>
                    <asp:View runat="server" ID="Step2">
                        <div class="newform">
                            <ul id="topmenu">
                                <li><a href="#" class="active">Authors</a></li>
                                <li><a href="#">Abstract</a></li>
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
                                            <tr>
                                                <td width="18%" align="right">
                                                    <label>
                                                        First Name</label>
                                                </td>
                                                <td width="82%" align="left">
                                                    <input  id="CoAuthorFirstNameText" name="textfield" type="text" class="newform-txt"
                                                        size="30" />
                                                    <input type="button" id="close" onclick="this.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.removeChild(this.parentNode.parentNode.parentNode.parentNode.parentNode);"
                                                        class="newform-close fixright" /><br class="clear" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <label>
                                                        Family Name</label>
                                                </td>
                                                <td align="left">
                                                    <input name="textfield2" type="text" class="newform-txt" id="CoAuthorFamilyNameText"
                                                        size="30" />
                                                    <br />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <label>
                                                        Title</label>
                                                </td>
                                                <td align="left">
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
                                            <tr>
                                                <td align="right">
                                                    <label>
                                                        Degree</label>
                                                </td>
                                                <td align="left">
                                                    <input name="textfield2" type="text" class="newform-txt"  id="CoAuthorDegreeText"
                                                        size="30" />
                                                    <br />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <label>
                                                        Email</label>
                                                </td>
                                                <td align="left">
                                                    <input name="textfield2" type="text" class="newform-txt"  id="CoAuthorEmailText"
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
                                                        Enter your primary contact email address.</p>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <label>
                                                        PO BOX</label>
                                                </td>
                                                <td align="left">
                                                    <input name="textfield15" type="text" class="newform-txt"  id="CoAuthorPOBoxText"
                                                        size="30" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <label>
                                                        Zip Code</label>
                                                </td>
                                                <td align="left">
                                                    <input name="textfield16" type="text" class="newform-txt" id="CoAuthorZipCodeText"
                                                        size="30" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <label>
                                                        City</label>
                                                </td>
                                                <td align="left">
                                                    <input name="textfield17" type="text" class="newform-txt"  id="CoAuthorCityText"
                                                        size="30" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <label>
                                                        Country</label>
                                                </td>
                                                <td align="left">
                                                    <input name="textfield18" type="text" class="newform-txt"  id="CoAuthorCountryText"
                                                        size="30" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <label>
                                                        Address</label>
                                                </td>
                                                <td align="left">
                                                    <input name="textfield3" type="text" class="newform-txt"  id="CoAuthorAddressText"
                                                        size="60" />
                                                    <br />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <label>
                                                        Phone number</label>
                                                </td>
                                                <td align="left">
                                                    <input name="textfield3" type="text" class="newform-txt"  id="CoAuthorPhoneNumberAreaCodeText"
                                                        size="4" />
                                                    <input name="textfield4" type="text" class="newform-txt"  id="CoAuthorPhoneNumberText"
                                                        size="22" />
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
                                                    <input name="textfield5" type="text" class="newform-txt"  id="CoAuthorAffilitationDepartmentText"
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
                                                    <input name="textfield6" type="text" class="newform-txt"  id="CoAuthorAffilitationInstitutionHospitalText"
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
                                                    <input name="textfield7" type="text" class="newform-txt"  id="CoAuthorAffilitationCityText"
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
                                                    <input name="textfield8" type="text" class="newform-txt"  id="CoAuthorAffilitationCountryText"
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
                                        <input name="input" type="button" value="Back" class="newform-bot-01" onclick="MoveStep('step1',true,'step2');" />
                                        
                                    </td>
                                    <td align="right">
                                        <input name="input" type="button" value="Next" class="newform-bot-01" onclick="MoveStep('step3',true,'step2');" />
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
                    </asp:View>
                    <asp:View runat="server" ID="Step3">
                        <div class="newform">
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
                                        <td width="82%" align="left">
                                            <input name="textfield" type="text" class="newform-txt" runat="server" id="AbstractTitleText" 
                                                size="30" />
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <label>
                                                Background</label>
                                        </td>
                                        <td align="left">
                                            <textarea runat="server" id="AbstractBackgroundText" rows="10" cols="5" style="width: 400px;"></textarea>
                                            <%--<input name="textfield2" type="text" class="newform-txt" id="text14" size="30" />--%>
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <label>
                                                Methods</label>
                                        </td>
                                        <td align="left">
                                            <textarea runat="server" id="AbstractMethodsText" rows="10" cols="5" style="width: 400px;"></textarea>
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <label>
                                                Results</label>
                                        </td>
                                        <td align="left">
                                            <textarea runat="server" id="AbstractResultsText" rows="10" cols="5" style="width: 400px;"></textarea>
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <label>
                                                Conclusion</label>
                                        </td>
                                        <td align="left">
                                            <textarea runat="server" id="AbstractConclusionText" rows="10" cols="5" style="width: 400px;"></textarea>
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
                                        <td align="right">
                                            <label>
                                                Upload</label>
                                        </td>
                                        <td align="left">
                                            <dx:ASPxUploadControl ID="conferenceLogoUpload" 
                                ClientInstanceName="conferenceLogoUpload" runat="server" 
                                ShowProgressPanel="True" ShowUploadButton="True" 
                                onfileuploadcomplete="conferenceLogoUpload_FileUploadComplete">
                                 <ClientSideEvents FileUploadComplete="function(s, e) {
	Uploader_OnUploadComplete(e);
}" />
                            </dx:ASPxUploadControl><br />
                                            
                            <dx:ASPxLabel ID="lblIconPath" runat="server" 
                        ClientInstanceName="lblIconPath">
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
                                        <input name="input" type="button" value="Back" class="newform-bot-01" onclick="MoveStep('step2',false,'step3');" />
                                    </td>
                                    <td align="right">
                                        <input name="input" type="button" value="Next" class="newform-bot-01" onclick="MoveStep('step4',false,'step3');" />
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
                    </asp:View>
                    <asp:View runat="server" ID="Step4">
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
                            <fieldset>
                                <legend>Abstract Preview</legend>
                                <div>
                                <Rbm:ReportViewerControl runat="server" ID="AbstractPreviewReport"></Rbm:ReportViewerControl>
                                </div>
                                <br />
                            </fieldset>
                            <br class="clear" />
                            <fieldset>
                                <legend>
                                    Confirm Submission
                                </legend>
                                <p>
                                    <asp:CheckBox ID="chkConfirmSubmission" runat="server" Text="By checking this textbox you confirm that all the information entered is correct" />
                                </p>
                            </fieldset>
                            <p>
                                &nbsp;</p>
                             <table width="99%" border="0" cellspacing="0" cellpadding="0" class="formz">
                                <tr>
                                    <td>
                                        <input name="input" type="button" value="Back" class="newform-bot-01" onclick="MoveStep('step3',false,'step4');" />
                                    </td>
                                    <td align="right">
                                        <asp:Button runat="server" ID="SubmitAbstractbtn" Text="Submit" CssClass="newform-bot-01" OnClick="SubmitAbstractbtn_Click" />
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
                    </asp:View>
                </asp:MultiView>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxCallbackPanel>
   

</asp:Content>
