<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master" AutoEventWireup="true" CodeBehind="RegisterSignup.aspx.cs" Inherits="SocioBuilderSite.Conference.RegisterSignup" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<%@ Register Src="~/Conference/Controls/ContactInfo.ascx" TagName="ContactInfoControl" TagPrefix="Rbm" %>
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
<h1><asp:Literal ID="Literal1" runat="server" Text='<%$Resources:ConferenceFront, RegisterPage_Signup %>' ></asp:Literal></h1>
<br />
<Rbm:ContactInfoControl runat="server" ID="ContactInfoControl1" />
<table style="width:60%;">
        <tr>
        <td runat="server" align='<%$Resources:ConferenceFront, Direction %>'>
        <dx:ASPxButton ID="SignupButton" runat="server" Font-Bold="True" 
                        Font-Size="16px" Height="45px" HorizontalAlign="Center" onclick="Signup_Click" 
                        Text='<%$Resources:ConferenceFront, ContactInfo_Save %>' Width="120px" ValidationGroup="WizardValidation">
                    </dx:ASPxButton>
        </td>
        </tr>

    </table>
   
   
   <div class="loginform success" runat="server" visible="false" id="NotificationMessageProfileUpdated">
   <strong>Success</strong><br /><p><asp:Literal ID="Literal25" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_ProfileUpdatedSuccessfully %>' ></asp:Literal></p>
   </div>
   <div class="loginform success" runat="server" visible="false" id="NotificationMessageSuccess">
   <strong>Success</strong><br /><p><asp:Literal ID="Literal26" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_ProfileSavedSuccessfully %>' ></asp:Literal></p>
   </div>
   
   <div class="loginform error" runat="server" visible="false" id="NotificationMessageError">
   <strong>Error</strong><br /><p runat="server" id="ErrorMessage"><asp:Literal ID="Literal27" runat="server" Text='<%$Resources:ConferenceFront, ContactInfo_ErrorMessage %>' ></asp:Literal></p>
   </div>
   

</asp:Content>
