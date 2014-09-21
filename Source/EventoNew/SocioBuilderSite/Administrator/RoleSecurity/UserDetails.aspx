<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="UserDetails.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.RoleSecurity.UserDetails" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript" src="../Scripts/JSON.js"></script>
    <% if (DesignMode)
   { %>
   <script src="../Scripts/ASPxScriptIntelliSense.js" type="text/javascript"></script>
    <%} %>
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
    //personPhoneTable
    $(document).ready(function () {
        LoadPhones();
        LoadEmails();
    });
    function LoadPhones() {

        var jsonString = personPhoneHiddenField.Get("jsonStringPhone");
        var personPhones = JSON.parse(jsonString, function (key, value) { return value; });
        if (personPhones != null) {
            var i = 0;
            for (i = 0; i < personPhones.length; i++) {
                var tr = document.createElement('tr');
                var tdPhoneType = document.createElement('td');
                $(tdPhoneType).attr('rel', personPhones[i].PhoneNumberTypeId);
                $(tdPhoneType).html(personPhones[i].PhoneNumberType);
                var tdPhoneNumber = document.createElement('td');
                $(tdPhoneNumber).html(personPhones[i].PhoneNumber);
                var tdClosePhone = document.createElement('td');
                $(tdClosePhone).addClass('rbm-tableleft');
                $(tdClosePhone).html('<a href="javascript:void();" onclick="$(this).parent().parent().remove();"><span class="ui-icon ui-icon-circle-close rbmiconhover"></span></a>');
                tr.appendChild(tdPhoneType);
                tr.appendChild(tdPhoneNumber);
                tr.appendChild(tdClosePhone);
                $(tr).attr('class', 'even-row');
                $('#personPhoneTable tr:last').after(tr);
            }
        }
    }

    function AddPhone(type, phone) {
        if (!ASPxClientEdit.ValidateGroup('PhonesGroup',false)) {
            return;
        }
        var tr = document.createElement('tr');
        var tdPhoneType = document.createElement('td');
        $(tdPhoneType).html(type);
        $(tdPhoneType).attr('rel', pnType.GetValue());
        var tdPhoneNumber = document.createElement('td');
        $(tdPhoneNumber).html(phone);
        var tdClosePhone = document.createElement('td');
        $(tdClosePhone).addClass('rbm-tableleft');
        $(tdClosePhone).html('<a href="javascript:void(0);" onclick="$(this).parent().parent().remove();"><span class="ui-icon ui-icon-circle-close rbmiconhover"></span></a>');
        tr.appendChild(tdPhoneType);
        tr.appendChild(tdPhoneNumber);
        tr.appendChild(tdClosePhone);
        $(tr).attr('class', 'even-row');
        pnType.SetText('');
        pnNumber.SetText('');
        $('#personPhoneTable tr:last').after(tr);
    }
    function LoadEmails() {
        var jsonString = personEmailHiddenField.Get("jsonStringEmail");
        var personPhones = JSON.parse(jsonString, function (key, value) { return value; });
        if (personPhones != null) {
            var i = 0;
            for (i = 0; i < personPhones.length; i++) {
                var tr = document.createElement('tr'); 
                var tdPhoneType = document.createElement('td');
                $(tdPhoneType).html(personPhones[i].EmailType);
                $(tdPhoneType).attr('rel', personPhones[i].EmailAddressTypeId);
                var tdPhoneNumber = document.createElement('td');
                $(tdPhoneNumber).html(personPhones[i].Email);
                var tdClosePhone = document.createElement('td');
                $(tdClosePhone).addClass('rbm-tableleft');
                $(tdClosePhone).html('<a href="javascript:void(0);" onclick="$(this).parent().parent().remove();"><span class="ui-icon ui-icon-circle-close rbmiconhover"></span></a>');
                tr.appendChild(tdPhoneType);
                tr.appendChild(tdPhoneNumber);
                tr.appendChild(tdClosePhone);
                $(tr).attr('class', 'even-row');
                $('#personEmailTable tr:last').after(tr);
            }
        }

    }

    function AddEmail(type, email) {
        if (!ASPxClientEdit.ValidateGroup('EmailesGroup', false)) {
            return;
        }
        var tr = document.createElement('tr');
        var tdPhoneType = document.createElement('td');
        $(tdPhoneType).html(type);
        $(tdPhoneType).attr('rel', peType.GetValue());
        var tdPhoneNumber = document.createElement('td');
        $(tdPhoneNumber).html(email);
        var tdClosePhone = document.createElement('td');
        $(tdClosePhone).addClass('rbm-tableleft');
        $(tdClosePhone).html('<a href="javascript:void(0);" onclick="$(this).parent().parent().remove();"><span class="ui-icon ui-icon-circle-close rbmiconhover"></span></a>');
        tr.appendChild(tdPhoneType);
        tr.appendChild(tdPhoneNumber);
        tr.appendChild(tdClosePhone);
        $(tr).attr('class', 'even-row');
        peType.SetText('');
        peEmail.SetText('');
        $('#personEmailTable tr:last').after(tr);
    }

    function GetContactData() {
        
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

        var jsonphone = JSON.stringify(personPhones, function(key, value) {
               return value;
           });
          
                personPhoneHiddenField.Set("jsonStringSetPhone", jsonphone);
           var jsonemail = JSON.stringify(personEmails, function (key, value) {
               return value;
           });
           personEmailHiddenField.Set("jsonStringSetEmail", jsonemail);
    }
</script>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
<div class="g8">
<div class="widgets">
			<div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
				<h3 class="handle">Save User Details</h3>
				<div class="inner-content">			
    <table>
        <tr>
            <td class="rbm-editformtitle">Title:</td>
            <td>
                <dx:ASPxComboBox ID="userTitle" runat="server" DataSourceID="TitleObjectDS" 
                    DropDownStyle="DropDown" TextField="LookupValue" ValueField="LookupValue" 
                    ValueType="System.String">
                </dx:ASPxComboBox>
                <asp:ObjectDataSource ID="TitleObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllByLookupName" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.LookupLanguagesLogic">
                    <SelectParameters>
                        <asp:Parameter Name="LookupName" Type="String" />
                        <asp:Parameter Name="LanguageId" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td class="rbm-editformtitle">
                First Name:
            </td>
            <td>
                <dx:ASPxTextBox ID="userFirstName" runat="server" Width="170px">
                    <ValidationSettings CausesValidation="True" Display="Dynamic">
                        <RequiredField ErrorText="Enter First Name" IsRequired="True" />
                    </ValidationSettings>
                </dx:ASPxTextBox>
            </td>
        </tr>
        <tr>
            <td class="rbm-editformtitle">
                Middle Name:
            </td>
            <td>
                <dx:ASPxTextBox ID="userMiddleName" runat="server" Width="170px">
                </dx:ASPxTextBox>
            </td>
        </tr>
        <tr>
            <td class="rbm-editformtitle">
                Last Name:
            </td>
            <td>
                <dx:ASPxTextBox ID="userLastName" runat="server" Width="170px">
                    <ValidationSettings CausesValidation="True" Display="Dynamic">
                        <RequiredField ErrorText="Enter Last Name" IsRequired="True" />
                    </ValidationSettings>
                </dx:ASPxTextBox>
            </td>
        </tr>
        <tr>
            <td class="rbm-editformtitle">
                Suffix:
            </td>
            <td>
                <dx:ASPxTextBox ID="userSuffix" runat="server" Width="170px">
                </dx:ASPxTextBox>
            </td>
        </tr>
        <tr>
            <td class="rbm-editformtitle">
                Display Name:
            </td>
            <td>
                <dx:ASPxTextBox ID="userDisplayName" runat="server" Width="170px">
                    <ValidationSettings CausesValidation="True" Display="Dynamic">
                        <RequiredField ErrorText="Enter Display Name" IsRequired="True" />
                    </ValidationSettings>
                </dx:ASPxTextBox>
            </td>
        </tr>
    </table>
  
            </div>
            </div>
            <div class="clear"></div>
            <div class="g6 widgets">
			<div class="widget widget-header-blue" id="Div1" data-icon="graph-dark">
				<h3 class="handle">Phone Numbers</h3>
				<div class="inner-content">			
                <div>
                    <ul>
                        <li>
                            <div class="float-left rbmcenterform-tr-td">
                                <span>
                                    <label class="rbmcenter-label">
                                        Type</label><br />
                                    <dx:ASPxComboBox ID="pnType" runat="server" ClientInstanceName="pnType" 
                                    TextField="Name" 
                                    ValueField="PhoneNumberTypeId" ValueType="System.String" 
                                    DataSourceID="PhoneNumberTypesObjectDS">
                                        <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                            ErrorDisplayMode="Text" ValidationGroup="PhonesGroup">

                                            <RequiredField IsRequired="True" />
                                        </ValidationSettings>
                                    </dx:ASPxComboBox>
                                
                                <asp:ObjectDataSource ID="PhoneNumberTypesObjectDS" runat="server" 
                                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                                    TypeName="BusinessLogicLayer.Components.Persons.PhoneNumberTypeLogic">
                                </asp:ObjectDataSource>
                                
                                </span>
                            </div>
                            <div class="float-left rbmcenterform-tr-td">
                                <span>
                                    <label class="rbmcenter-label">
                                        Number</label><br />
                                    <dx:ASPxTextBox ID="pnNumber" ClientInstanceName="pnNumber" runat="server" Width="200px">
                                        <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                            ErrorDisplayMode="Text" ValidationGroup="PhonesGroup">

                                            <RequiredField IsRequired="True" />
                                        </ValidationSettings>
                                    </dx:ASPxTextBox>
                                </span>
                            </div>
                            <div class="float-left rbmcenterform-tr-td">
                                <label>
                                </label>
                                <br />
                                <div class="ui-state-default ui-corner-all">
                                    <a href="javascript:void(0);" onclick="AddPhone(pnType.GetText(),pnNumber.GetText());"><span class="ui-icon ui-icon-plusthick rbmiconhover">
                                    </span></a>
                                </div>
                            </div>
                        </li>
                    </ul>
                    <div class="clearfix"></div>
                    <div class="rbm-top-border" ></div>
                </div>
                <div class="clearfix"></div>
                <dx:ASPxHiddenField ID="personPhoneHiddenField" ClientInstanceName="personPhoneHiddenField" runat="server">
                </dx:ASPxHiddenField>
                <table id="personPhoneTable" style="margin-top:20px;width:100%;" class="rbmward-makebold rbm-makesmall rbm-tablehover">
                    <tbody>
                        <tr><td></td><td></td></tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>

    <div class="g6 widgets">
			<div class="widget widget-header-blue" id="Div2" data-icon="graph-dark">
				<h3 class="handle">EMails</h3>
				<div class="inner-content">	
                
                <div>
                    <ul>
                        <li>
                            <div class="float-left rbmcenterform-tr-td">
                                <span>
                                    <label class="rbmcenter-label">
                                        Type</label><br />
                                    <dx:ASPxComboBox ID="peType" ClientInstanceName="peType" runat="server" 
                                     TextField="Name" 
                                    ValueField="EmailAddressTypeId" ValueType="System.String" 
                                    DataSourceID="EmailObjectDS">
                                        <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                            ErrorDisplayMode="Text" ValidationGroup="EmailesGroup">
                                            <RequiredField IsRequired="True" />
                                        </ValidationSettings>
                                    </dx:ASPxComboBox>
                               
                                <asp:ObjectDataSource ID="EmailObjectDS" runat="server" 
                                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                                    TypeName="BusinessLogicLayer.Components.Persons.EmailAddressTypeLogic">
                                </asp:ObjectDataSource>
                               
                                </span>
                            </div>
                            <div class="float-left rbmcenterform-tr-td">
                                <span>
                                    <label class="rbmcenter-label">
                                      Email</label><br />
                                    <dx:ASPxTextBox ID="peEmail" ClientInstanceName="peEmail" runat="server" Width="200px">
                                        <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                            ValidationGroup="EmailesGroup">
                                            <RequiredField IsRequired="True" />
                                        </ValidationSettings>
                                    </dx:ASPxTextBox>
                                </span>
                            </div>
                            <div class="float-left rbmcenterform-tr-td">
                                <label>
                                </label>
                                <br />
                                <div class="ui-state-default ui-corner-all">
                                    <a href="javascript:void(0);" onclick="AddEmail(peType.GetText(),peEmail.GetText());"><span class="ui-icon ui-icon-plusthick rbmiconhover">
                                    </span></a>
                                </div>
                            </div>
                        </li>
                    </ul>
                    <div class="clearfix"></div>
                    <div class="rbm-top-border"></div>
                    <dx:ASPxHiddenField ID="personEmailHiddenField" ClientInstanceName="personEmailHiddenField" runat="server">
                    </dx:ASPxHiddenField>
                    <table id="personEmailTable" style="margin-top:20px;width:100%;" class="rbmward-makebold rbm-makesmall rbm-tablehover">
                    <tbody>
                        <tr><td></td><td></td></tr>
                    </tbody>
                </table>
                </div>
                <div class="clearfix">
                </div>
            </div>
        </div>
    </div>

</div>
</div>
<div class="g3">
  <div class="widgets">
			<div class="widget widget-header-blue" id="Div3" data-icon="graph-dark">
				<h3 class="handle">Action</h3>
				<div class="inner-content">		
                <table style="width:100%;">
                    <tr>
                        <td align="center" style="text-align:center;">
                            
                            <dx:ASPxButton ID="SaveButton" runat="server" BackColor="Transparent" ToolTip="Save"
                                     EnableDefaultAppearance="False" Width="48px" Height="48px" onclick="SaveButton_Click">

                                    <ClientSideEvents Click="function(s, e) {
	GetContactData()
}" />

                                    <HoverStyle BackColor="#CDE9FF">
                                       
                                    </HoverStyle>
                                    <FocusRectBorder BorderStyle="None" />
                                    <BackgroundImage HorizontalPosition="0px" ImageUrl="~/images/filesave.png" Repeat="NoRepeat"/>
                                    <Border BorderStyle="None" />
                                </dx:ASPxButton>
                        </td>
                       
                        <td align="center" style="text-align:center;">
                            <dx:ASPxButton ID="CancelButton" runat="server" BackColor="Transparent" ToolTip="Cancel"
                                     EnableDefaultAppearance="False" Width="48px" Height="48px" 
                                onclick="CancelButton_Click">
                                    <HoverStyle BackColor="#CDE9FF">
                                       
                                    </HoverStyle>
                                    <FocusRectBorder BorderStyle="None" />
                                    <BackgroundImage HorizontalPosition="0px" ImageUrl="~/images/cancelsave.png" Repeat="NoRepeat"/>
                                    <Border BorderStyle="None" />
                                </dx:ASPxButton>
                        </td>
                    </tr>
                </table>
                
                <div class="clearfix"></div>
       
            
            </div>
        </div>
        </div>
        <div class="clearfix"></div>
        <div class="widgets">
			<div class="widget widget-header-blue" id="Div4" data-icon="graph-dark">
				<h3 class="handle">Settings</h3>
				<div class="inner-content">	
                
                <table>
                    <tr>
                        <td>Name Style:</td>
                        
                    </tr>
                    <tr>
                        <td>
                            <dx:ASPxComboBox ID="personNameStyle" ClientInstanceName="personNameStyle" SelectedIndex="0" runat="server">
                                <Items>
                                    <dx:ListEditItem Text="First Name, Last Name" Value="False" Selected="true" />
                                    <dx:ListEditItem Text="Last Name, First Name" Value="True" />
                                </Items>
                            </dx:ASPxComboBox>
                        </td>
                        </tr>
                        <tr>
                        <td>Promotion:</td>
                        </tr>
                        <tr>
                        <td>
                            <dx:ASPxComboBox ID="personPromotion" runat="server" SelectedIndex="0" 
                                DataSourceID="PromotionObjectDS" TextField="LookupValueDescription" 
                                ValueField="LookupValue" ValueType="System.String">
                            </dx:ASPxComboBox>
                            <asp:ObjectDataSource ID="PromotionObjectDS" runat="server" 
                                OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllByLookupName" 
                                TypeName="BusinessLogicLayer.Components.ContentManagement.LookupLanguagesLogic">
                                <SelectParameters>
                                    <asp:Parameter Name="LookupName" Type="String" />
                                    <asp:Parameter Name="LanguageId" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                        </td>
                    </tr>
                     <tr>
                        <td>Nationality:</td>
                        </tr>
                        <tr>
                        <td>
                            <dx:ASPxComboBox ID="personNationality" runat="server" 
                                DataSourceID="CountriesObjectDS" TextField="Name" IncrementalFilteringMode="Contains" 
                                ValueField="CountryRegionCode" ValueType="System.String">
                            </dx:ASPxComboBox>
                            <asp:ObjectDataSource ID="CountriesObjectDS" runat="server" 
                                OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                                TypeName="BusinessLogicLayer.Components.Persons.CountryRegionLogic">
                            </asp:ObjectDataSource>
                        </td>
                    </tr>
                   
                </table>
                <div class="clearfix"></div>
       
            
            </div>
        </div>
        </div>
        <div class="clear"></div>
        <div class="widgets">
			<div class="widget widget-header-blue" id="Div5" data-icon="graph-dark">
				<h3 class="handle">Credentials</h3>
				<div class="inner-content">
                
                <table>
                    <tr>
                        <td>Username:</td>
                        
                    </tr>
                    <tr>
                        <td>
                            <dx:ASPxTextBox ID="credUsername" runat="server" Width="170px">
                            </dx:ASPxTextBox>
                        </td>
                        </tr>
                        <tr>
                        <td>Password:</td>
                        </tr>
                        <tr>
                        <td>
                            <dx:ASPxTextBox ID="credPassword" runat="server" Width="170px" Password="true">
                            </dx:ASPxTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Confirm Password:</td>
                    </tr>
                    <tr>
                        <td>
                            <dx:ASPxTextBox ID="credConfirmPassword" runat="server" Width="170px" Password="true">
                            </dx:ASPxTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <dx:ASPxCheckBox ID="credUserActive" runat="server" Text="Active">
                            </dx:ASPxCheckBox>
                        </td>
                    </tr>
                </table>
                <div class="clearfix"></div>
       
            
            </div>
        </div>
        </div>
</div>
      
    
   

         
</asp:Content>
      
       

