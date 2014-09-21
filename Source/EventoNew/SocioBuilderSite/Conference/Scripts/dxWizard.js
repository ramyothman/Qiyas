function OnBackButtonClick() {
    pc.SetActiveTabIndex(pc.GetActiveTabIndex() - 1);
    //dxpError.SetVisible(false);
    UpdateButtonsEnabled();
}
function OnNextButtonClick() {
    var tabName = pc.GetActiveTab().name;
    var areEditorsValid = ASPxClientEdit.ValidateEditorsInContainerById(tabName, 'WizardValidation');
    if (areEditorsValid) {
        var nextTab = pc.GetTab(pc.GetActiveTabIndex() + 1);
        nextTab.SetEnabled(true);
        pc.SetActiveTab(nextTab);
        if (pc.GetActiveTabIndex() == pc.GetTabCount() - 1)
            callbackConfirmationPreview.PerformCallback();
    }
    //dxpError.SetVisible(!areEditorsValid);
    UpdateButtonsEnabled();
}
function OnFinishButtonClick(s, e) {

    var areEditorsValid = ASPxClientEdit.ValidateEditorsInContainerById(tabName, 'WizardValidation');
    alert(areEditorsValid);
return areEditorsValid;
//    var finishTab = pc.GetTabByName('RegisterationConfirmation');
//    DisableRegistrationTabs();
//    finishTab.SetEnabled(true);
//    pc.SetActiveTab(finishTab);
//    UpdateButtonsEnabled();
}
function UpdateButtonsEnabled() {
    var tabName = pc.GetActiveTab().name;
    btnBack.SetVisible(pc.GetActiveTabIndex() != 0 && pc.GetActiveTabIndex() != (pc.GetTabCount() - 1));
    
    var isNextAllow = pc.GetActiveTabIndex() != (pc.GetTabCount() - 1); //tabName != 'Confirmation' && tabName != 'Finish';
    btnNext.SetVisible(isNextAllow);
    btnNext.SetEnabled(isNextAllow);
    if (isNextAllow)
        btnNext.Focus();
    btnFinish.SetVisible(pc.GetActiveTabIndex() == (pc.GetTabCount() - 1));
    if(btnFinish.GetVisible())
        SetConfirmationDisplay();
}

function DisableRegistrationTabs() {
    var tabIndex = 0;
    var i = 0;
    for(i = 1; i < pc.GetTabCount() - 1;i++)
    {
        pc.GetTab(i).SetEnabled(false);
    }
    
//    while (pc.GetTab(tabIndex).name != 'Finish')
//        pc.GetTab(tabIndex++).SetEnabled(false);
}
function OnActiveTabChanging(s, e) {
    e.reloadContentOnCallback = (e.tab.name == 'Confirmation');
}
