<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Conference.Master"
    AutoEventWireup="true" CodeBehind="Submit.aspx.cs" Inherits="SocioBuilderSite.Conferences.Abstract.Submit" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxUploadControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxSpellChecker.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxSpellChecker" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxClasses" TagPrefix="dx" %>
<%@ Register Src="~/Controls/Conference/ProfileInformation.ascx" TagName="ProfileInformationControl"
    TagPrefix="Rbm" %>
<%@ Register Src="~/Controls/Reports/MainReportViewerControl.ascx" TagName="ReportViewerControl" TagPrefix="Rbm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <script type="text/javascript" src="Scripts/JSON.js"></script>
    <script src="Scripts/abstractScript.js" type="text/javascript"></script>
    <script type="text/javascript">
        function Uploader_OnUploadComplete(args) {
            if (args.isValid) {
                //            txtImageUploadPath.SetText(args.callbackData);
                lblIconPath.SetText('file uploaded');
            }
        }
</script>

<script type="text/javascript">
    // <![CDATA[
    var MaxLength = 50;
    var CustomErrorText = "HTML content&prime;s length must exceed " + MaxLength.toString() + " characters.";
    function ValidationHandler(s, e) {
        if (e.html.length < MaxLength) {
            e.isValid = false;
            e.errorText = CustomErrorText;
        }
    }
    function HtmlChangedHandler(s, e) {
        ContentLength.SetText(s.GetHtml().length);
    }
    // ]]>
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<dx:ASPxHiddenField ID="AbstractSubmissionHidden" ClientInstanceName="AbstractSubmissionHidden" runat="server"  SyncWithServer="true" ViewStateMode="Enabled">
    </dx:ASPxHiddenField> 
    <br class="clear" />
    <br />
    <h1>
        Abstract Submission</h1>
    <br />
    <div class="mainContent registration">
        <dx:ASPxPageControl ID="pc" ClientInstanceName="pc" runat="server" ActiveTabIndex="0"
            EnableCallBacks="True" Width="100%" OnInit="pc_Init" 
            CssClass="pageControl" EnableDefaultAppearance="False"
            LoadingPanelText="" onbeforegetcallbackresult="pc_BeforeGetCallbackResult">
            <ClientSideEvents ActiveTabChanged="UpdateButtonsEnabled" 
                ActiveTabChanging="OnActiveTabChanging" EndCallback="function(s, e) {
   if(pc.GetActiveTabIndex() == 2)
		LoadCoAuthorsInitialData();
}" />
            <TabTemplate>
                <site:UnselectedTab ID="UnselectedTab1" runat="server" />
            </TabTemplate>
            <ActiveTabTemplate>
                <site:SelectedTab ID="SelectedTab1" runat="server" />
            </ActiveTabTemplate>
            <TabPages>
                <dx:TabPage Text="Personal" Name="Personal">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControlPersonalInfo" runat="server" SupportsDisabledAttribute="True">
                            <div class="tabPageContent" id="Personal" >
                                <div class="regFields">
                                    <div class="regFieldHolder">
                                        <p style="font-size: 18px; font-weight: bold;">
                                            Please Choose One of The Following</p>
                                        <dx:ASPxRadioButtonList ID="AbstractAuthorCoAuthor" ClientInstanceName="AbstractAuthorCoAuthor"
                                            runat="server" SelectedIndex="0" Width="450px">
                                            <Items>
                                                <dx:ListEditItem Text="I am the primary author" Selected="true" Value="0" />
                                                <dx:ListEditItem Text="I am submitting the abstract as co author" Value="1" />
                                            </Items>
                                            <Border BorderStyle="None" />
                                        </dx:ASPxRadioButtonList>
                                    </div>
                                    <br />
                                    <div class="clear">
                                    </div>
                                    <div class="regFieldHolder" style="margin-top: 50px;">
                                        <Rbm:ProfileInformationControl runat="server" ID="pf1" />
                                    </div>
                                    <div class="clear">
                                    </div>
                                    <br />
                                </div>
                            </div>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage ClientEnabled="False" Text="Pr. Author" Name="PrimaryAuthor">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControlPrimaryAuthor" runat="server" SupportsDisabledAttribute="True">
                            <div class="tabPageContent" id="PrimaryAuthor" style="height:380px;">
                                <div class="regFields">
                                    <div class="regColumn left">
                                        <div class="regFieldHolder">
                                            <dx:ASPxLabel runat="server" ID="lblFirstName" AssociatedControlID="AuthorFirstNameText"
                                                Text="First Name:" CssClass="regLabel" />
                                            <dx:ASPxTextBox ID="AuthorFirstNameText" CssClass="regInput" runat="server">
                                                <ValidationSettings ErrorDisplayMode="None" ValidateOnLeave="true" SetFocusOnError="true">
                                                    <RequiredField IsRequired="true" />
                                                </ValidationSettings>
                                            </dx:ASPxTextBox>
                                        </div>
                                        <div class="regFieldHolder">
                                            <dx:ASPxLabel runat="server" ID="lblTitle" AssociatedControlID="AuthorTitleCombo"
                                                Text="Title:" CssClass="regLabel" />
                                            <dx:ASPxComboBox ID="AuthorTitleCombo" runat="server" SelectedIndex="0" ValueType="System.String"
                                                CssClass="regInput">
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
                                        </div>
                                        <div class="regFieldHolder">
                                            <dx:ASPxLabel runat="server" ID="lblEmail" AssociatedControlID="AuthorEmailText"
                                                Text="Email:" CssClass="regLabel" />
                                            <dx:ASPxTextBox ID="AuthorEmailText" runat="server" CssClass="regInput">
                                                <ValidationSettings ErrorDisplayMode="None" ValidateOnLeave="true" SetFocusOnError="true">
                                                    <RequiredField IsRequired="true" />
                                                </ValidationSettings>
                                            </dx:ASPxTextBox>
                                        </div>
                                        <div class="regFieldHolder">
                                            <dx:ASPxLabel runat="server" ID="lblZipCode" AssociatedControlID="AuthorZipCodeText"
                                                Text="Zip Code:" CssClass="regLabel" />
                                            <dx:ASPxTextBox ID="AuthorZipCodeText" runat="server" CssClass="regInput">
                                            </dx:ASPxTextBox>
                                        </div>
                                        <div class="regFieldHolder">
                                            <dx:ASPxLabel runat="server" ID="lblCountry" AssociatedControlID="AuthorPhoneNumberText"
                                                Text="Country:" CssClass="regLabel" />
                                            <dx:ASPxTextBox ID="AuthorCountryText" runat="server" CssClass="regInput">
                                            </dx:ASPxTextBox>
                                        </div>
                                        <div class="regFieldHolder">
                                            <dx:ASPxLabel runat="server" ID="lblPhoneNumber" AssociatedControlID="AuthorFirstNameText"
                                                Text="Phone Number:" CssClass="regLabel" />
                                            <dx:ASPxTextBox ID="AuthorPhoneNumberAreaCodeText" Visible="false" runat="server" Width="50px" CssClass="regInput">
                                                        </dx:ASPxTextBox>

                                                        <dx:ASPxTextBox ID="AuthorPhoneNumberText" runat="server"  CssClass="regInput">
                                                            <ValidationSettings ErrorDisplayMode="None" ValidateOnLeave="true" SetFocusOnError="true">
                                                                <RequiredField IsRequired="true" />
                                                            </ValidationSettings>
                                                        </dx:ASPxTextBox>
                                           
                                        </div>
                                        
                                    </div>
                                    <div class="regColumn left">
                                        <div class="regFieldHolder">
                                            <dx:ASPxLabel runat="server" ID="lblLastName" AssociatedControlID="AuthorFamilyNameText"
                                                Text="Family Name:" CssClass="regLabel" />
                                            <dx:ASPxTextBox ID="AuthorFamilyNameText" runat="server" CssClass="regInput">
                                                <ValidationSettings ErrorDisplayMode="None" ValidateOnLeave="true" SetFocusOnError="true">
                                                    <RequiredField IsRequired="true" />
                                                </ValidationSettings>
                                            </dx:ASPxTextBox>
                                        </div>
                                        <div class="regFieldHolder">
                                            <dx:ASPxLabel runat="server" ID="ASPxLabel1" AssociatedControlID="AuthorDegreeText"
                                                Text="Degree:" CssClass="regLabel" />
                                            <dx:ASPxTextBox ID="AuthorDegreeText" runat="server" CssClass="regInput">
                                            </dx:ASPxTextBox>
                                        </div>
                                        <div class="regFieldHolder">
                                            <dx:ASPxLabel runat="server" ID="ASPxLabel2" AssociatedControlID="AuthorPOBoxText"
                                                Text="PO Box:" CssClass="regLabel" />
                                            <dx:ASPxTextBox ID="AuthorPOBoxText" runat="server" CssClass="regInput">
                                            </dx:ASPxTextBox>
                                        </div>
                                        <div class="regFieldHolder">
                                            <dx:ASPxLabel runat="server" ID="ASPxLabel3" AssociatedControlID="AuthorCityText"
                                                Text="City:" CssClass="regLabel" />
                                            <dx:ASPxTextBox ID="AuthorCityText" runat="server">
                                            </dx:ASPxTextBox>
                                        </div>
                                        <div class="regFieldHolder">
                                            <dx:ASPxLabel runat="server" ID="ASPxLabel4" AssociatedControlID="AuthorAddressText"
                                                Text="Address:" CssClass="regLabel" />
                                            <dx:ASPxTextBox ID="AuthorAddressText" runat="server" CssClass="regInput">
                                            </dx:ASPxTextBox>
                                        </div>

                                        <div class="regFieldHolder">
                                            <dx:ASPxLabel runat="server" ID="ASPxLabel5" Text="Affiliation:" CssClass="regLabel" />
                                            <table>
                                                <tr>
                                                    <td align="left">
                                                        <dx:ASPxTextBox CssClass="regInput" ID="AuthorDepartmentText" runat="server" NullText="Department">
                                                        </dx:ASPxTextBox>
                                                        <br />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxTextBox CssClass="regInput" ID="AuthorInstitutionHospitalText" runat="server"
                                                            NullText="Institution / Hospital">
                                                        </dx:ASPxTextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxTextBox CssClass="regInput" ID="AuthorAffilitationCityText" runat="server"
                                                            NullText="City">
                                                        </dx:ASPxTextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxTextBox CssClass="regInput" ID="AuthorAffilitationCountryText" runat="server"
                                                            NullText="Country">
                                                        </dx:ASPxTextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage ClientEnabled="False" Name="COAuthors" Text="Co Authors">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControlCoAuthors" runat="server" SupportsDisabledAttribute="True">
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
               
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage ClientEnabled="False" Name="Abstract" Text="Abstract">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControlAbstract" runat="server" SupportsDisabledAttribute="True">
                             <div class="tabPageContent-New" id="Abstract"  >
                             <div class="regFields">
                             <div class="regFieldHolder">
                                    <dx:ASPxLabel runat="server" ID="ASPxLabel9" AssociatedControlID="AbstractCategoryCombo"
                                                Text="Abstract Category:" CssClass="regLabel" />
                                                   
                                <dx:ASPxComboBox CssClass="regInput" ID="AbstractCategoryCombo" ClientInstanceName="AbstractCategoryCombo" runat="server" SelectedIndex="0"  >
                                    <ClientSideEvents Validation="function(s, e) {
	if(s.GetValue() == '0'){
		e.errorText = '*';
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
                                    <ValidationSettings ErrorDisplayMode="None" ValidateOnLeave="true" SetFocusOnError="true" >
                                    <RequiredField ErrorText="*" IsRequired="True" />
                                    </ValidationSettings>
                                    
                                </dx:ASPxComboBox>
                                      <br />
                                    </div>
                                <div class="regFieldHolder-New">
                                    <label class="label-main">Title</label>
                                               
                                        <dx:ASPxHtmlEditor ID="AbstractTitleHtmlEditor" ClientInstanceName="AbstractTitleHtmlEditor" runat="server" Width="600px" Height="250px">
                <ClientSideEvents Validation="ValidationHandler" />
                <Toolbars>
                    <dx:HtmlEditorToolbar Name="StandardToolbar2">
                        <Items>
                            <dx:ToolbarFontNameEdit>
                                <Items>
                                    <dx:ToolbarListEditItem Text="Times New Roman" Value="Times New Roman" />
                                    <dx:ToolbarListEditItem Text="Tahoma" Value="Tahoma" />
                                    <dx:ToolbarListEditItem Text="Verdana" Value="Verdana" />
                                    <dx:ToolbarListEditItem Text="Arial" Value="Arial" />
                                    <dx:ToolbarListEditItem Text="MS Sans Serif" Value="MS Sans Serif" />
                                    <dx:ToolbarListEditItem Text="Courier" Value="Courier" />
                                </Items>
                            </dx:ToolbarFontNameEdit>
                            <dx:ToolbarFontSizeEdit>
                                <Items>
                                    <dx:ToolbarListEditItem Text="1 (8pt)" Value="1" />
                                    <dx:ToolbarListEditItem Text="2 (10pt)" Value="2" />
                                    <dx:ToolbarListEditItem Text="3 (12pt)" Value="3" />
                                    <dx:ToolbarListEditItem Text="4 (14pt)" Value="4" />
                                    <dx:ToolbarListEditItem Text="5 (18pt)" Value="5" />
                                    <dx:ToolbarListEditItem Text="6 (24pt)" Value="6" />
                                    <dx:ToolbarListEditItem Text="7 (36pt)" Value="7" />
                                </Items>
                            </dx:ToolbarFontSizeEdit>
                            <dx:ToolbarBoldButton BeginGroup="True"></dx:ToolbarBoldButton>
                            <dx:ToolbarItalicButton></dx:ToolbarItalicButton>
                            <dx:ToolbarUnderlineButton></dx:ToolbarUnderlineButton>
                            <dx:ToolbarStrikethroughButton></dx:ToolbarStrikethroughButton>
                            <dx:ToolbarJustifyLeftButton BeginGroup="True"></dx:ToolbarJustifyLeftButton>
                            <dx:ToolbarJustifyCenterButton></dx:ToolbarJustifyCenterButton>
                            <dx:ToolbarJustifyRightButton></dx:ToolbarJustifyRightButton>
                            <dx:ToolbarJustifyFullButton></dx:ToolbarJustifyFullButton>
                        </Items>
                    </dx:HtmlEditorToolbar>
                </Toolbars>
                
<SettingsImageUpload>
<ValidationSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></ValidationSettings>
</SettingsImageUpload>

                <SettingsValidation>
                    <RequiredField ErrorText="This Field is Mandatory" IsRequired="True" />
                </SettingsValidation>

<SettingsImageSelector>
<CommonSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></CommonSettings>
</SettingsImageSelector>

<SettingsDocumentSelector>
<CommonSettings AllowedFileExtensions=".rtf, .pdf, .doc, .docx, .odt, .txt, .xls, .xlsx, .ods, .ppt, .pptx, .odp"></CommonSettings>
</SettingsDocumentSelector>
            </dx:ASPxHtmlEditor>
                                    </div>
                                    
                                    <div class="regFieldHolder-New">
                                    <label class="label-main">Background</label>
                                        <dx:ASPxHtmlEditor ID="AbstractBackgroundHtmlEditor" ClientInstanceName="AbstractBackgroundHtmlEditor" runat="server" Width="600px" Height="250px">
                
                <Toolbars>
                    <dx:HtmlEditorToolbar Name="StandardToolbar2">
                        <Items>
                            <dx:ToolbarFontNameEdit>
                                <Items>
                                    <dx:ToolbarListEditItem Text="Times New Roman" Value="Times New Roman" />
                                    <dx:ToolbarListEditItem Text="Tahoma" Value="Tahoma" />
                                    <dx:ToolbarListEditItem Text="Verdana" Value="Verdana" />
                                    <dx:ToolbarListEditItem Text="Arial" Value="Arial" />
                                    <dx:ToolbarListEditItem Text="MS Sans Serif" Value="MS Sans Serif" />
                                    <dx:ToolbarListEditItem Text="Courier" Value="Courier" />
                                </Items>
                            </dx:ToolbarFontNameEdit>
                            <dx:ToolbarFontSizeEdit>
                                <Items>
                                    <dx:ToolbarListEditItem Text="1 (8pt)" Value="1" />
                                    <dx:ToolbarListEditItem Text="2 (10pt)" Value="2" />
                                    <dx:ToolbarListEditItem Text="3 (12pt)" Value="3" />
                                    <dx:ToolbarListEditItem Text="4 (14pt)" Value="4" />
                                    <dx:ToolbarListEditItem Text="5 (18pt)" Value="5" />
                                    <dx:ToolbarListEditItem Text="6 (24pt)" Value="6" />
                                    <dx:ToolbarListEditItem Text="7 (36pt)" Value="7" />
                                </Items>
                            </dx:ToolbarFontSizeEdit>
                            <dx:ToolbarBoldButton BeginGroup="True"></dx:ToolbarBoldButton>
                            <dx:ToolbarItalicButton></dx:ToolbarItalicButton>
                            <dx:ToolbarUnderlineButton></dx:ToolbarUnderlineButton>
                            <dx:ToolbarStrikethroughButton></dx:ToolbarStrikethroughButton>
                            <dx:ToolbarJustifyLeftButton BeginGroup="True"></dx:ToolbarJustifyLeftButton>
                            <dx:ToolbarJustifyCenterButton></dx:ToolbarJustifyCenterButton>
                            <dx:ToolbarJustifyRightButton></dx:ToolbarJustifyRightButton>
                            <dx:ToolbarJustifyFullButton></dx:ToolbarJustifyFullButton>
                        </Items>
                    </dx:HtmlEditorToolbar>
                </Toolbars>
                
<SettingsImageUpload>
<ValidationSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></ValidationSettings>
</SettingsImageUpload>

                <SettingsValidation>
                    <RequiredField IsRequired="True" />
                </SettingsValidation>

<SettingsImageSelector>
<CommonSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></CommonSettings>
</SettingsImageSelector>

<SettingsDocumentSelector>
<CommonSettings AllowedFileExtensions=".rtf, .pdf, .doc, .docx, .odt, .txt, .xls, .xlsx, .ods, .ppt, .pptx, .odp"></CommonSettings>
</SettingsDocumentSelector>
            </dx:ASPxHtmlEditor>
                                    </div>

                                    <div class="regFieldHolder-New">
                                    <label class="label-main">Methods</label>
                                        <dx:ASPxHtmlEditor ID="AbstractMethodsHtmlEditor" ClientInstanceName="AbstractMethodsHtmlEditor" runat="server" Width="600px" Height="250px">
                
                <Toolbars>
                    <dx:HtmlEditorToolbar Name="StandardToolbar2">
                        <Items>
                            <dx:ToolbarFontNameEdit>
                                <Items>
                                    <dx:ToolbarListEditItem Text="Times New Roman" Value="Times New Roman" />
                                    <dx:ToolbarListEditItem Text="Tahoma" Value="Tahoma" />
                                    <dx:ToolbarListEditItem Text="Verdana" Value="Verdana" />
                                    <dx:ToolbarListEditItem Text="Arial" Value="Arial" />
                                    <dx:ToolbarListEditItem Text="MS Sans Serif" Value="MS Sans Serif" />
                                    <dx:ToolbarListEditItem Text="Courier" Value="Courier" />
                                </Items>
                            </dx:ToolbarFontNameEdit>
                            <dx:ToolbarFontSizeEdit>
                                <Items>
                                    <dx:ToolbarListEditItem Text="1 (8pt)" Value="1" />
                                    <dx:ToolbarListEditItem Text="2 (10pt)" Value="2" />
                                    <dx:ToolbarListEditItem Text="3 (12pt)" Value="3" />
                                    <dx:ToolbarListEditItem Text="4 (14pt)" Value="4" />
                                    <dx:ToolbarListEditItem Text="5 (18pt)" Value="5" />
                                    <dx:ToolbarListEditItem Text="6 (24pt)" Value="6" />
                                    <dx:ToolbarListEditItem Text="7 (36pt)" Value="7" />
                                </Items>
                            </dx:ToolbarFontSizeEdit>
                            <dx:ToolbarBoldButton BeginGroup="True"></dx:ToolbarBoldButton>
                            <dx:ToolbarItalicButton></dx:ToolbarItalicButton>
                            <dx:ToolbarUnderlineButton></dx:ToolbarUnderlineButton>
                            <dx:ToolbarStrikethroughButton></dx:ToolbarStrikethroughButton>
                            <dx:ToolbarJustifyLeftButton BeginGroup="True"></dx:ToolbarJustifyLeftButton>
                            <dx:ToolbarJustifyCenterButton></dx:ToolbarJustifyCenterButton>
                            <dx:ToolbarJustifyRightButton></dx:ToolbarJustifyRightButton>
                            <dx:ToolbarJustifyFullButton></dx:ToolbarJustifyFullButton>
                        </Items>
                    </dx:HtmlEditorToolbar>
                </Toolbars>
                
<SettingsImageUpload>
<ValidationSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></ValidationSettings>
</SettingsImageUpload>

                <SettingsValidation>
                    <RequiredField IsRequired="True" />
                </SettingsValidation>

<SettingsImageSelector>
<CommonSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></CommonSettings>
</SettingsImageSelector>

<SettingsDocumentSelector>
<CommonSettings AllowedFileExtensions=".rtf, .pdf, .doc, .docx, .odt, .txt, .xls, .xlsx, .ods, .ppt, .pptx, .odp"></CommonSettings>
</SettingsDocumentSelector>
            </dx:ASPxHtmlEditor>
                                    </div>

                                    <div class="regFieldHolder-New">
                                    <label class="label-main">Results</label>
                                        <dx:ASPxHtmlEditor ID="AbstractResultsHtmlEditor" ClientInstanceName="AbstractResultsHtmlEditor" runat="server" Width="600px" Height="250px">
                
                <Toolbars>
                    <dx:HtmlEditorToolbar Name="StandardToolbar2">
                        <Items>
                            <dx:ToolbarFontNameEdit>
                                <Items>
                                    <dx:ToolbarListEditItem Text="Times New Roman" Value="Times New Roman" />
                                    <dx:ToolbarListEditItem Text="Tahoma" Value="Tahoma" />
                                    <dx:ToolbarListEditItem Text="Verdana" Value="Verdana" />
                                    <dx:ToolbarListEditItem Text="Arial" Value="Arial" />
                                    <dx:ToolbarListEditItem Text="MS Sans Serif" Value="MS Sans Serif" />
                                    <dx:ToolbarListEditItem Text="Courier" Value="Courier" />
                                </Items>
                            </dx:ToolbarFontNameEdit>
                            <dx:ToolbarFontSizeEdit>
                                <Items>
                                    <dx:ToolbarListEditItem Text="1 (8pt)" Value="1" />
                                    <dx:ToolbarListEditItem Text="2 (10pt)" Value="2" />
                                    <dx:ToolbarListEditItem Text="3 (12pt)" Value="3" />
                                    <dx:ToolbarListEditItem Text="4 (14pt)" Value="4" />
                                    <dx:ToolbarListEditItem Text="5 (18pt)" Value="5" />
                                    <dx:ToolbarListEditItem Text="6 (24pt)" Value="6" />
                                    <dx:ToolbarListEditItem Text="7 (36pt)" Value="7" />
                                </Items>
                            </dx:ToolbarFontSizeEdit>
                            <dx:ToolbarBoldButton BeginGroup="True"></dx:ToolbarBoldButton>
                            <dx:ToolbarItalicButton></dx:ToolbarItalicButton>
                            <dx:ToolbarUnderlineButton></dx:ToolbarUnderlineButton>
                            <dx:ToolbarStrikethroughButton></dx:ToolbarStrikethroughButton>
                            <dx:ToolbarJustifyLeftButton BeginGroup="True"></dx:ToolbarJustifyLeftButton>
                            <dx:ToolbarJustifyCenterButton></dx:ToolbarJustifyCenterButton>
                            <dx:ToolbarJustifyRightButton></dx:ToolbarJustifyRightButton>
                            <dx:ToolbarJustifyFullButton></dx:ToolbarJustifyFullButton>
                        </Items>
                    </dx:HtmlEditorToolbar>
                </Toolbars>
                
<SettingsImageUpload>
<ValidationSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></ValidationSettings>
</SettingsImageUpload>

                <SettingsValidation>
                    <RequiredField IsRequired="True" />
                </SettingsValidation>

<SettingsImageSelector>
<CommonSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></CommonSettings>
</SettingsImageSelector>

<SettingsDocumentSelector>
<CommonSettings AllowedFileExtensions=".rtf, .pdf, .doc, .docx, .odt, .txt, .xls, .xlsx, .ods, .ppt, .pptx, .odp"></CommonSettings>
</SettingsDocumentSelector>
            </dx:ASPxHtmlEditor>
                                    </div>

                                    <div class="regFieldHolder-New">
                                    <label class="label-main">Conclusion</label>
                                        <dx:ASPxHtmlEditor ID="AbstractConclusionHtmlEditor" ClientInstanceName="AbstractConclusionHtmlEditor" runat="server" Width="600px" Height="250px">
                
                <Toolbars>
                    <dx:HtmlEditorToolbar Name="StandardToolbar2">
                        <Items>
                            <dx:ToolbarFontNameEdit>
                                <Items>
                                    <dx:ToolbarListEditItem Text="Times New Roman" Value="Times New Roman" />
                                    <dx:ToolbarListEditItem Text="Tahoma" Value="Tahoma" />
                                    <dx:ToolbarListEditItem Text="Verdana" Value="Verdana" />
                                    <dx:ToolbarListEditItem Text="Arial" Value="Arial" />
                                    <dx:ToolbarListEditItem Text="MS Sans Serif" Value="MS Sans Serif" />
                                    <dx:ToolbarListEditItem Text="Courier" Value="Courier" />
                                </Items>
                            </dx:ToolbarFontNameEdit>
                            <dx:ToolbarFontSizeEdit>
                                <Items>
                                    <dx:ToolbarListEditItem Text="1 (8pt)" Value="1" />
                                    <dx:ToolbarListEditItem Text="2 (10pt)" Value="2" />
                                    <dx:ToolbarListEditItem Text="3 (12pt)" Value="3" />
                                    <dx:ToolbarListEditItem Text="4 (14pt)" Value="4" />
                                    <dx:ToolbarListEditItem Text="5 (18pt)" Value="5" />
                                    <dx:ToolbarListEditItem Text="6 (24pt)" Value="6" />
                                    <dx:ToolbarListEditItem Text="7 (36pt)" Value="7" />
                                </Items>
                            </dx:ToolbarFontSizeEdit>
                            <dx:ToolbarBoldButton BeginGroup="True"></dx:ToolbarBoldButton>
                            <dx:ToolbarItalicButton></dx:ToolbarItalicButton>
                            <dx:ToolbarUnderlineButton></dx:ToolbarUnderlineButton>
                            <dx:ToolbarStrikethroughButton></dx:ToolbarStrikethroughButton>
                            <dx:ToolbarJustifyLeftButton BeginGroup="True"></dx:ToolbarJustifyLeftButton>
                            <dx:ToolbarJustifyCenterButton></dx:ToolbarJustifyCenterButton>
                            <dx:ToolbarJustifyRightButton></dx:ToolbarJustifyRightButton>
                            <dx:ToolbarJustifyFullButton></dx:ToolbarJustifyFullButton>
                        </Items>
                    </dx:HtmlEditorToolbar>
                </Toolbars>
                
<SettingsImageUpload>
<ValidationSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></ValidationSettings>
</SettingsImageUpload>

                <SettingsValidation>
                    <RequiredField IsRequired="True" />
                </SettingsValidation>

<SettingsImageSelector>
<CommonSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></CommonSettings>
</SettingsImageSelector>

<SettingsDocumentSelector>
<CommonSettings AllowedFileExtensions=".rtf, .pdf, .doc, .docx, .odt, .txt, .xls, .xlsx, .ods, .ppt, .pptx, .odp"></CommonSettings>
</SettingsDocumentSelector>
            </dx:ASPxHtmlEditor>
                                    </div>
                                    
                                    
                                    <div class="regFieldHolder">
                                    <dx:ASPxLabel runat="server" ID="ASPxLabel6" AssociatedControlID="AbstractKeyWord1"
                                                Text="KeyWord 1:" CssClass="regLabel" />
                                            <dx:ASPxTextBox ID="AbstractKeyWord1" ClientInstanceName="AbstractKeyWord1" CssClass="regInput" runat="server" NullText="Keyword 1">
                                                
                                            </dx:ASPxTextBox><br />
                                    </div>
                                    <div class="regFieldHolder">
                                    <dx:ASPxLabel runat="server" ID="ASPxLabel7" AssociatedControlID="AbstractKeyWord3"
                                                Text="KeyWord 2:" CssClass="regLabel" />
                                            <dx:ASPxTextBox ID="AbstractKeyWord2" ClientInstanceName="AbstractKeyWord2" CssClass="regInput" runat="server" NullText="Keyword 1">
                                                
                                            </dx:ASPxTextBox>
                                    </div>
                                    <div class="regFieldHolder">
                                    <dx:ASPxLabel runat="server" ID="ASPxLabel8" AssociatedControlID="AbstractKeyWord3"
                                                Text="KeyWord 3:" CssClass="regLabel" />
                                            <dx:ASPxTextBox ID="AbstractKeyWord3" ClientInstanceName="AbstractKeyWord3" CssClass="regInput" runat="server" NullText="Keyword 1">
                                                
                                            </dx:ASPxTextBox>
                                    </div>
                                    <div class="regFieldHolder">
                                    <dx:ASPxLabel runat="server" ID="ASPxLabel10" AssociatedControlID="conferenceLogoUpload"
                                                Text="Abstract Document:" CssClass="regLabel" />
                                            <dx:ASPxUploadControl ID="conferenceLogoUpload" ClientInstanceName="conferenceLogoUpload"
                                runat="server" ShowProgressPanel="True" ShowUploadButton="True" OnFileUploadComplete="conferenceLogoUpload_FileUploadComplete">
                                <ClientSideEvents FileUploadComplete="function(s, e) {
	Uploader_OnUploadComplete(e);
}" />
                            </dx:ASPxUploadControl>
                            <dx:ASPxLabel ID="lblIconPath" runat="server" ClientInstanceName="lblIconPath">
                            </dx:ASPxLabel>
                                    </div>
                                    
                                    </div>
                            </div>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage ClientEnabled="False" Text="Confirmation" Name="Confirmation">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControlConfirmation" runat="server" SupportsDisabledAttribute="True">
                        <div style="width:670px;overflow:auto;">
                        <Rbm:ReportViewerControl runat="server" ID="AbstractPreviewReport"></Rbm:ReportViewerControl>
                        </div>
                        <dx:ASPxCheckBox CssClass="regCheckBox" ID="chkConfirmSubmission" runat="server" Text="By checking this textbox you confirm that all the information entered is correct">
                                        <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                        ErrorDisplayMode="Text" ValidationGroup="Step4ValidationGroup">
                                        <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                        </ErrorFrameStyle>
                                        <RequiredField ErrorText="* Required" IsRequired="True" />
                                    </ValidationSettings>
                                    </dx:ASPxCheckBox>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage ClientEnabled="False" Name="Finish" Text="Finish">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControlFinish" runat="server">
                        <div class="tabPageContent finishArea">
                                    <p>
                                        Congratulation.</p>
                                    <p>
                                        Abstract Submission is completed.</p>
                                    <dx:ASPxButton ID="btnGoToSchedule" runat="server" Text="Abstract Status"
                                        OnClick="btnGoToSchedule_Click" CssClass="finishAreaButton" HorizontalAlign="Center" UseSubmitBehavior="False">
                                    </dx:ASPxButton>
                                </div>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
            </TabPages>
            <TabStyle>
                <Paddings Padding="0px" />
                <BorderBottom BorderStyle="None" BorderWidth="0px" />
            </TabStyle>
            <Paddings Padding="0px" />
        </dx:ASPxPageControl>
        
        <div class="clear" style="margin-bottom: 40px;">
        </div>
        <br />
        <div class="buttonsArea clear">
            <div class="buttons">
                <table cellpadding="0" cellspacing="0" border="0" class="buttonsTable">
                    <tr>
                        <td>
                            <dx:ASPxButton ID="btnBack" ClientInstanceName="btnBack" runat="server" Image-Url="~/images/buttons/back.png"
                                AutoPostBack="false" ClientVisible="false" CausesValidation="false" UseSubmitBehavior="False">
                                <ClientSideEvents Click="OnBackButtonClick" />
                            </dx:ASPxButton>
                        </td>
                        <td>
                            <dx:ASPxButton ID="btnNext" ClientInstanceName="btnNext" runat="server" Image-Url="~/images/buttons/next.png"
                                AutoPostBack="false" CausesValidation="false" UseSubmitBehavior="true">
                                <ClientSideEvents Click="OnNextButtonClick" />
                            </dx:ASPxButton>
                        </td>
                        <td>
                            <dx:ASPxButton ID="btnFinish" ClientInstanceName="btnFinish" runat="server" Image-Url="~/images/buttons/finish.png"
                                AutoPostBack="false" ClientVisible="false" UseSubmitBehavior="false">
                                <ClientSideEvents Click="OnFinishButtonClick" />
                            </dx:ASPxButton>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <dx:ASPxPanel ID="dxpError" ClientInstanceName="dxpError" runat="server" CssClass="errorPanel"
            ClientVisible="false">
            <PanelCollection>
                <dx:PanelContent>
                    Please complete or correct the fields highlighted in red.
                </dx:PanelContent>
            </PanelCollection>
        </dx:ASPxPanel>
        <dx:ASPxHiddenField ID="hfRegInfo" ClientInstanceName="hfRegInfo" runat="server"
            SyncWithServer="true" ViewStateMode="Enabled">
        </dx:ASPxHiddenField>
    </div>
</asp:Content>
