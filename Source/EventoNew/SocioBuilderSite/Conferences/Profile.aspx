<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Conference.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="SocioBuilderSite.Conferences.Profile" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
    <%@ Register Src="~/Controls/Conference/ProfileInformation.ascx" TagName="ProfileControl" TagPrefix="Rbm" %>
    <%@ Register Src="~/Controls/Conference/MyAbstracts.ascx" TagName="MyAbstractsControl" TagPrefix="Rbm" %>
    <%@ Register Src="~/Controls/Reports/MainReportViewerControl.ascx" TagName="ReportViewerControl" TagPrefix="Rbm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script src="Scripts/ui.core.js" type="text/javascript"></script>
        <script src="Scripts/ui.tabs.js" type="text/javascript"></script>

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
        jQuery(document).ready(function () {
            $('#tabdivs1 > ul').tabs();
        });
        function StartEditGrid(key) {
            AbstractsGrid.StartEditRowByKey(key);
        }
        </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br class="clear" /> <br />
<h1>Profile Settings</h1><br />
<div id="tabdivs1" >
                  <ul>
                    <li><a href="#abs2-1"><span>Profile Information</span></a></li>
                    <li><a href="#abs2-2"><span>Abstract Status</span></a></li>
                    <li><a href="#abs2-3"><span>ID & Certificates</span></a></li>
                  </ul>
     <div id="abs2-1">
        <Rbm:ProfileControl runat="server" ID="ProfileControl1" />
     </div>
     <div id="abs2-2">
        <Rbm:MyAbstractsControl runat="server" id="MyCurrentAbstractsControl"></Rbm:MyAbstractsControl>
     </div>
     <div id="abs2-3">
        <asp:LinkButton runat="server" id="AbstractPDFView" Text="Abstract(PDF)"  
                                         onclick="AbstractPDFView_Click">
                                         <table>
                                         <tr>
                                         <td><img src="images/participantIDs.jpg"></td>
                                         <td><h3>Download ID (PDF Version)</h3></td>
                                         </tr>
                                         </table>
                                          
     </asp:LinkButton>
     </div>
     </div>
</asp:Content>
