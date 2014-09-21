﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Conference.Master" AutoEventWireup="true" CodeBehind="ForgetPassword.aspx.cs" Inherits="SocioBuilderSite.Conferences.ForgetPassword" %>
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
     <h1>Forget Password</h1>
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
    <div class="frmHead" style="font-style:italic;color:#023B68;">Please enter the email you signed up with here. An email will be send with the new generated password. </div>
    <table style="text-align:right;width:95%;">
                        <tr><td align="right">
                       
                     <dx:ASPxButton ID="SendPasswordButton" runat="server" Text="Send Password" HorizontalAlign="Center"
                    Font-Bold="True" Font-Size="16px" 
                     Height="35px" Width="180px" onclick="SendPasswordButton_Click" >
                    
                </dx:ASPxButton>   
                        </td></tr>
                     
                </table>
 </div>
 <div class="notice" runat="server" id="NoticeError" visible="false"></div>
</asp:Content>