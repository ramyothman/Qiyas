<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Conference.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="SocioBuilderSite.Conferences.Signup" %>

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
<br class="clear" />
<br />
<div runat="server" id="SignupFormView">
     <h1>Sign up</h1>
 <div class="loginform" >
    <div class="frmHead">Email</div>
                         <dx:ASPxTextBox ID="EmailText" CssClass="blueInpReg" 
                            EnableDefaultAppearance="false" EnableTheming="false" runat="server" 
                            Height="45px" Width="647px" Font-Size="26px">
                             <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                 ErrorDisplayMode="Text" ErrorTextPosition="Bottom">
                                 <ErrorFrameStyle Font-Size="16px" ForeColor="Red">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText="Please Enter Email" IsRequired="True" />
                             </ValidationSettings>
    </dx:ASPxTextBox>
    <div class="frmHead" style="font-style:italic;color:#023B68;">The email will act as the username too. </div>
    <div class="frmHead">Password</div>
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
                                 <RequiredField ErrorText="Please Enter Password" IsRequired="True" />
                             </ValidationSettings>
    </dx:ASPxTextBox>
    <div class="frmHead">Confirm Password</div>
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
                                 <RequiredField ErrorText="Please Confirm Password" IsRequired="True" />
                             </ValidationSettings>
    </dx:ASPxTextBox>
    <div class="frmHead">Name</div>
     <dx:ASPxTextBox ID="NameText" CssClass="blueInpReg" 
                            EnableDefaultAppearance="false" EnableTheming="false" runat="server" 
                            Height="45px" Width="647px" Font-Size="26px">
                             <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                 ErrorDisplayMode="Text" ErrorTextPosition="Bottom">
                                 <ErrorFrameStyle Font-Size="16px" ForeColor="Red">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText="Please Enter Your Full Name" IsRequired="True" />
                             </ValidationSettings>
    </dx:ASPxTextBox>
    <div class="frmHead">Mobile</div>
     <dx:ASPxTextBox ID="MobileText" CssClass="blueInp" 
                            EnableDefaultAppearance="false" EnableTheming="false" runat="server" 
                            Height="45px" Width="207px" Font-Size="20px">
                             <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                 ErrorDisplayMode="Text" ErrorTextPosition="Bottom">
                                 <ErrorFrameStyle Font-Size="16px" ForeColor="Red">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText="Please Enter Your Mobile Number" IsRequired="True" />
                             </ValidationSettings>
    </dx:ASPxTextBox>

     <table style="text-align:right;width:95%;">
                        <tr><td align="right">
                       
                     <dx:ASPxButton ID="SignupButton" runat="server" Text="Save" HorizontalAlign="Center"
                    Font-Bold="True" Font-Size="16px" 
                     Height="45px" Width="120px" onclick="Signup_Click" >
                    
                </dx:ASPxButton>   
                        </td></tr>
                     
                </table>
 </div>
 </div>
 <div class="loginform" runat="server" visible="false" id="NotificationMessage"></div>
</asp:Content>
