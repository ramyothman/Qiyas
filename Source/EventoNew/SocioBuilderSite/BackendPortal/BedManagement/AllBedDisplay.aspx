<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdministrationMaster.Master" AutoEventWireup="true" CodeBehind="AllBedDisplay.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.BedManagement.AllBedDisplay" %>
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
<asp:Content ID="Content2" ContentPlaceHolderID="MessagePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainPlaceHolder" runat="server">
<div runat="server" id="BedManagementView" class="rbmward">
    <table>
    <tr>
        <td></td>
        <td>Ward</td>
        <td>Tel Ex.</td>
        <td>Specialities</td>
        <td>CP</td>
        <td colspan="6">Room 1</td>
        <td colspan="6">Room 2</td>
        <td colspan="6">Room 3</td>
        <td colspan="6">Room 4</td>
        <td>Room 5</td>
        <td>Room 6</td>
        <td>Room 7</td>
        <td>Room 8</td>
        <td>Room 9</td>
        <td>Room 10</td>
        <td>Room 11</td>
        <td>Room 12</td>
        <td>Room 13</td>
    </tr>
    <% foreach (BusinessLogicLayer.Entities.BedManagement.Ward ward in CurrentWards)
       { %>
       <tr style="background-color:<%= ward.WardColor %>;">
        <td>
            <img style="float:left;display:<%= ViewTypeMale(ward.WardType) %>;"  src="Images/Hospital/PatientMale.png" alt="M" width="16" height="16" />
            <img style="float:left;display:<%= ViewTypeFemale(ward.WardType) %>;" src="Images/Hospital/PatientFemale.png" alt="F" width="16" height="16" />
        </td>
        <td  class="rbmward-makebold">
            <%= ward.WardCode %>
        </td>
        <td class="rbmward-makebold">
            <%= ward.WardPhone %>
        </td>
        <td>
            <%= ward.WardDescription %>
        </td>
        <td>
            <%= ward.WardCapacity %>
        </td>
        <% foreach (BusinessLogicLayer.Entities.BedManagement.WardRoom room in ward.WardRooms)
           {bool isFirst = true; %>
            <% foreach (BusinessLogicLayer.Entities.BedManagement.WardBed bed in room.WardBeds)
               { %>
           <td title="" valign="top" align="right" class="<%= GetClassForTD(isFirst,room.IsPrivate,bed.BedStatus,bed.BedStatusPercentage) %>" tooltip="<%= GeToolTip(ward.WardCode,bed.BedCode,ward.WardDescription,bed.BedStatus) %>">
                <%= bed.BedCode %><div>GSPS</div>
                
           </td>
           <%isFirst = false;} %>
        <%} %>
       </tr>
    <%} %>
    </table>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="DashBoardContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="LeftSideBar" runat="server">
</asp:Content>
