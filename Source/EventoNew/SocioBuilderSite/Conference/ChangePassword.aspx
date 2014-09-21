﻿<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="SocioBuilderSite.Conference.ChangePassword" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

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

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div runat="server" id="SignupFormView">
     <h1><asp:Literal ID="Literal1" runat="server" Text='<%$Resources:ConferenceFront, ChangePassword_PageTitle %>' ></asp:Literal></h1>
 <div class="loginform" >
    <div class="frmHead"><asp:Literal ID="Literal2" runat="server" Text='<%$Resources:ConferenceFront, ChangePassword_Password %>' ></asp:Literal></div>
     <dx:ASPxTextBox ID="PasswordText" CssClass="blueInpReg" Password="True"
                            EnableDefaultAppearance="False" EnableTheming="False" runat="server" 
                            Height="45px" Width="647px" Font-Size="26px" 
         ClientInstanceName="PasswordText">
                             <ClientSideEvents Validation="function(s, e) {
	var confirmpass = new String(PasswordText.GetText());
	if(confirmpass.length &lt; 6)
	{
		e.isValid = false;
		e.errorText = 'Password must be at least 6 characters';
	}
	else
	{
		e.isValid = true;
	}
	ConfirmPasswordText.Validate();

}" />
                             <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                 ErrorDisplayMode="Text" ErrorTextPosition="Bottom" 
                                 EnableCustomValidation="True">
                                 <ErrorFrameStyle Font-Size="16px" ForeColor="Red">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText='<%$Resources:ConferenceFront, ChangePassword_PasswordError %>' IsRequired="True" />
                             </ValidationSettings>
    </dx:ASPxTextBox>
    <div class="frmHead"><asp:Literal ID="Literal3" runat="server" Text='<%$Resources:ConferenceFront, ChangePassword_ConfirmPassword %>' ></asp:Literal></div>
     <dx:ASPxTextBox ID="ConfirmPasswordText" CssClass="blueInpReg" Password="True"
                            EnableDefaultAppearance="False" EnableTheming="False" runat="server" 
                            Height="45px" Width="647px" Font-Size="26px" 
         ClientInstanceName="ConfirmPasswordText">
                             <ClientSideEvents Validation="function(s, e) {
	var confirmpass = new String(ConfirmPasswordText.GetText());
	var pass = new String(PasswordText.GetText());
	if(pass.length != 0)
	{
    
	if(ConfirmPasswordText.GetText() != PasswordText.GetText())
	{
		e.isValid = false;
		e.errorText = 'Password and Confirm Password Must Match';
	}
	else
	{
		e.isValid = true;
	}
	}
	
}" />
                             <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                 ErrorDisplayMode="Text" ErrorTextPosition="Bottom" 
                                 EnableCustomValidation="True">
                                 <ErrorFrameStyle Font-Size="16px" ForeColor="Red">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText='<%$Resources:ConferenceFront, ChangePassword_ConfirmPasswordError %>' IsRequired="True" />
                             </ValidationSettings>
    </dx:ASPxTextBox>
     <table style="text-align:right;width:95%;">
                        <tr><td align="right">
                       
                     <dx:ASPxButton ID="SignupButton" runat="server" Text='<%$Resources:ConferenceFront, ChangePassword_SaveButton %>' HorizontalAlign="Center"
                    Font-Bold="True" Font-Size="16px" 
                     Height="45px" Width="120px" onclick="Signup_Click" >
                    
                </dx:ASPxButton>   
                        </td></tr>
                     
                </table>
 </div>
 </div>
 <div class="loginform" runat="server" visible="false" id="NotificationMessage"></div>
</asp:Content>
