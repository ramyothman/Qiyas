<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllBedFull.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.BedManagement.AllBedFull" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="../Scripts/jquery-1.4.1.js"></script>
    <script src="../Scripts/jquery-ui-1.8.custom.min.js" type="text/javascript"></script>
	<script type="text/javascript" src="../Scripts/tooltip.js"></script>
	<script type="text/javascript" src="../Scripts/cookie.js"></script>
	<script type="text/javascript" src="../Scripts/custom.js"></script>
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

    <script type="text/javascript" src="../Scripts/easySlider1.5.js"></script>
<script type="text/javascript" charset="utf-8">
// <![CDATA[
    $(document).ready(function () {
        $("#slider").easySlider({
            controlsBefore: '<p id="controls">',
            controlsAfter: '</p>',
            auto: true,
            continuous: true
        });
    });
// ]]>
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
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
           <a href="AllWardRoomsDisplay.aspx"> <%= ward.WardCode %></a>
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
           <td  valign="top" align="right" class="<%= GetClassForTD(isFirst,room.IsPrivate,bed.BedStatus,bed.BedStatusPercentage) %>" title="<%= GeToolTip(ward.WardCode,bed.BedCode,ward.WardDescription,bed.BedStatus) %>">
               <a href="BedDetailDisplay.aspx"> <%= bed.BedCode %></a><br /><div><%= GetSpeciality(ward.WardDescription) %></div>
                
           </td>
           <%isFirst = false;} %>
        <%} %>
       </tr>
    <%} %>
    </table>
    </div></div>
    <br />
    <center>
    <div style="padding-left:40px;height:40px;background-color:#014596;font-weight:bold;color:White;text-align:left;">
    <div id="slider" style="width:425px;overflow:hidden;" >

        <ul style="margin-left:0px;">
          <li>
          <div>  
        <table cellpadding="5px" cellspacing="5px">
            <tr>
                <td colspan="2">Ward 11A</td>
            </tr>
            <tr>
                <td>Ward Capacity: 16</td>
                <td>Free Beds: 2</td>
                 <td>Occupied Beds:13</td>
                <td>Closed Beds: 1</td>
            </tr>
           
        </table>
        </div>
        </li>
        <li>
        <div>
        <table cellpadding="5px" cellspacing="5px">
            <tr>
                <td colspan="2">Ward 24A</td>
            </tr>
            <tr>
                <td>Ward Capacity: 15</td>
                <td>Free Beds: 3</td>
                 <td>Occupied Beds:11</td>
                <td>Closed Beds: 2</td>
            </tr>
           
        </table>
        </div>
        </li>
        </ul>
   
        
    </div>
   </div>
    </center>
    </form>
</body>
</html>
