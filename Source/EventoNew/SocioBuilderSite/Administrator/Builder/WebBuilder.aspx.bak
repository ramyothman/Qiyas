<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebBuilder.aspx.cs" Inherits="SocioBuilderSite.Administrator.Builder.WebBuilder" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxCallback" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link rel="stylesheet" href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.7.2/themes/base/jquery-ui.css" type="text/css" />
    <link href="Styles/style.css" rel="stylesheet" type="text/css" />
    <link href="Styles/Main.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/JQuery/jquery.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.7.2/jquery-ui.min.js"></script>
    <script src="Scripts/Rbm/Tools.js" type="text/javascript"></script>
    <script src="Scripts/JQuery/JSON.js" type="text/javascript"></script>
    <script src="Scripts/BoxWidget.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            // Handler for .ready() called.
            // Using the boxer plugin
//            $('#FormContainer').boxer({
//                stop: function (event, ui) {
//                    var offset = ui.box.offset();
//                    ui.box.css({ border: '1px solid black' })
			//.append('x:' + offset.left + ', y:' + offset.top)
			//.append('<br>')
			//.append('w:' + ui.box.width() + ', h:' + ui.box.height());
                }
            });
        });
        
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="top_menu">
            <div class="content">
                <a href="ManageForms.aspx" class="selected" style="float: right;">Forms</a>
                <div class="commandpanelleft">
                    
                    
                </div>
                <div class="commandpanelright">
                   
                </div>
            </div>
            <div class="fix">
            </div>
        </div>
        <div class="page">
            <div class="contentpage">
                
            <dx:ASPxHiddenField ID="hiddenJSONLoad" runat="server" ClientInstanceName="hiddenJSONLoad">
    </dx:ASPxHiddenField>
                
    <dx:ASPxLoadingPanel ID="SavingLoadingPanel" 
        ClientInstanceName="SavingLoadingPanel" Modal="True" runat="server" 
      Text="">
    </dx:ASPxLoadingPanel>
                <div id="FormContainer">
    <div id="ContainerDiv" >
          
    </div>
    <div id="OtherContent">
    
       
    </div>
    
    </div>
            </div>
            
            <div class="fix">
            </div>
        </div>
        <div class="footer">
            <div class="content700">
                Website Builder - &copy; all rights reserved<br />
                <div class="fix">
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
