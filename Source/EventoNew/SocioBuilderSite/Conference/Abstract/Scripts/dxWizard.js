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
