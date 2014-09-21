//Registration
function OnBackButtonClick() {
    pc.SetActiveTabIndex(pc.GetActiveTabIndex() - 1);
    dxpError.SetVisible(false);
    UpdateButtonsEnabled();
}
function OnNextButtonClick() {
    var tabName = pc.GetActiveTab().name;
    var areEditorsValid = ASPxClientEdit.ValidateEditorsInContainerById(tabName);
    if (areEditorsValid) {
        var nextTab = pc.GetTab(pc.GetActiveTabIndex() + 1);
        nextTab.SetEnabled(true);
        if ((pc.GetActiveTabIndex() + 1) == 4) {
            GetCoAuthorsClientData();
            AbstractSubmissionHidden.Set("AbstractCategoryCombo", AbstractCategoryCombo.GetValue());
            AbstractSubmissionHidden.Set("AbstractTitleHtmlEditor", AbstractTitleMemoEditor.GetText());
            AbstractSubmissionHidden.Set("AbstractMethodsHtmlEditor", AbstractMethodsMemoEditor.GetText());
            AbstractSubmissionHidden.Set("AbstractBackgroundHtmlEditor", AbstractBackgroundMemoEditor.GetText());
            AbstractSubmissionHidden.Set("AbstractResultsHtmlEditor", AbstractResultsMemoEditor.GetText());
            AbstractSubmissionHidden.Set("AbstractConclusionHtmlEditor", AbstractConclusionMemoEditor.GetText());
            AbstractSubmissionHidden.Set("AbstractKeyWord1", AbstractKeyWord1.GetText());
            AbstractSubmissionHidden.Set("AbstractKeyWord2", AbstractKeyWord2.GetText());
            AbstractSubmissionHidden.Set("AbstractKeyWord3", AbstractKeyWord3.GetText());
        }
        pc.SetActiveTab(nextTab);
    }
    dxpError.SetVisible(!areEditorsValid);
    UpdateButtonsEnabled();
}
function OnFinishButtonClick(s, e) {
    var finishTab = pc.GetTabByName('Finish');
    DisableRegistrationTabs();
    finishTab.SetEnabled(true);
    pc.SetActiveTab(finishTab);
    UpdateButtonsEnabled();
}
function UpdateButtonsEnabled() {
    var tabName = pc.GetActiveTab().name;
    btnBack.SetVisible(tabName != 'Personal' && tabName != 'Finish');
    var isNextAllow = tabName != 'Confirmation' && tabName != 'Finish';
    btnNext.SetVisible(isNextAllow);
    btnNext.SetEnabled(isNextAllow);
    if (isNextAllow)
        btnNext.Focus();
    btnFinish.SetVisible(tabName == 'Confirmation');
}
function LoadCoAuthorsInitialData() {
    var tabName = pc.GetActiveTab().name;
    if (tabName != "COAuthors") return;
    if (AbstractAuthorCoAuthor.GetValue() != '0' && !coauthorLoaded) {
        LoadCoAuthorDataFromProfile();
        coauthorLoaded = true;
    }
}
function DisableRegistrationTabs() {
    var tabIndex = 0;
    while (pc.GetTab(tabIndex).name != 'Finish')
        pc.GetTab(tabIndex++).SetEnabled(false);
}
function OnActiveTabChanging(s, e) {
    e.reloadContentOnCallback = (e.tab.name == 'Confirmation');
}

/********************** Co Authors Code *********************/
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
    if (AbstractSubmissionHidden.Get("CoAuthorsDataFromProfile") == null || AbstractSubmissionHidden.Get("CoAuthorsDataFromProfile") == 'undefined')
        AbstractSubmissionHidden.Set("CoAuthorsDataFromProfile", hfRegInfo.Get("CoAuthorsDataFromProfile"));
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