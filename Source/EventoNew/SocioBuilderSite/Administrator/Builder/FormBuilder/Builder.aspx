<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Builder.aspx.cs" Inherits="SocioBuilderSite.Administrator.Builder.FormBuilder.Builder" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxCallback" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Form Builder</title>
    <link href="Styles/style.css" rel="stylesheet" type="text/css" />
    <link href="Styles/Main.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/JQuery/jquery.min.js" type="text/javascript"></script>
    <script src="Scripts/JQuery/jquery-ui.min.js" type="text/javascript"></script>
    <script src="Scripts/Rbm/Tools.js" type="text/javascript"></script>
    <script src="Scripts/JQuery/JSON.js" type="text/javascript"></script>
    <script src="Scripts/JQuery/SurveyQuestion.js" type="text/javascript"></script>
    <script src="Scripts/JQuery/GeneralBuilderScript.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="top_menu">
            <div class="content">
                <a href="ManageForms.aspx" class="selected" style="float: right;">Forms</a>
                <div class="commandpanelleft">
                    <a href="javascript:AddElement()">Add Question</a>
                    <select id="QuestionAddOption" style="font-size: 16px;" name="QuestionAddOption">
                        <option value="Text">Text</option>
                        <option value="Paragraph">Paragraph</option>
                        <option value="MultipleChoice">Option</option>
                        <option value="CheckBoxes">Checkbox</option>
                        <option value="DropDown">DropDown</option>
                        <option value="Grid">Grid</option>
                    </select>
                </div>
                <div class="commandpanelright">
                   <a href="javascript:SaveData();"><img src="images/filesaveas.png" class="ImageLink" alt="Save" /></a><a href="javascript:popupSurveySettings.Show();"><img src="images/page_accept.png" class="ImageLink" alt="Edit Confirmation" /></a>
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
    <div id="MainParts" style="padding-left:20px;padding-right:20px;">
    <input id="TitleText" type="text" value="Untitled Form" style="width:100%;color:#666666;font-size:1.1em;font-family: Trebuchet MS;" onfocus="TextChanged(this,'Untitled Form')" onblur="TextLeave(this,'Untitled Form')" /><br /><br />
    <textarea rows="3" cols="1" id="SubTitleText" style="width:100%;height:50px;color:#666666;font-size:0.9em;font-family: Trebuchet MS;" onfocus="TextChanged(this,'You can include any text or message that will help people fill this out')" onblur="TextLeave(this,'You can include any text or message that will help people fill this out')" >
You can include any text or message that will help people fill this out</textarea><br /><br />
    
    </div>
    
    <div id="ContainerDiv" >
          
    </div>
    <div id="OtherContent">
    
        <dx:ASPxCallback ID="saveCallBack" runat="server" 
            ClientInstanceName="saveCallBack" oncallback="saveCallBack_Callback">
            <ClientSideEvents BeginCallback="function(s, e) {
	SavingLoadingPanel.Show();
}" CallbackComplete="function(s, e) {
		SavingLoadingPanel.Hide();
}" />
        </dx:ASPxCallback>
        <dx:ASPxPopupControl ID="popupSurveySettings" 
            ClientInstanceName="popupSurveySettings" runat="server" 
            
            HeaderText="Edit Confirmation" 
            AllowDragging="True" Modal="True" PopupHorizontalAlign="WindowCenter" 
            PopupVerticalAlign="WindowCenter">
            <ContentStyle VerticalAlign="Top">
            </ContentStyle>
            <SizeGripImage Height="12px" Width="12px" />
            <ContentCollection>
<dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">

<div id="MainSurveyInformation">
    <dx:ASPxCallbackPanel runat="server" id="callbackPanelSettings" 
        ClientInstanceName="callbackPanelSettings" width="550"
        OnCallback="callbackPanelSettings_Callback"  ><PanelCollection>
<dx:PanelContent ID="PanelContent1" runat="server">
    <dx:ASPxMemo ID="txtSurveySubmitReply" runat="server" Height="250" 
        Width="100%" Text="Thanks!

Your response are submitted successfully.">
    </dx:ASPxMemo>
</dx:PanelContent>
</PanelCollection>
    </dx:ASPxCallbackPanel>

        
    </div>

</dx:PopupControlContentControl>
</ContentCollection>
            <CloseButtonImage Height="16px" Width="17px" />
        </dx:ASPxPopupControl>
    </div>
    
    </div>
            </div>
            
            <div class="fix">
            </div>
        </div>
        <div class="footer">
            <div class="content700">
                Form Builder - &copy; all rights reserved<br />
                <div class="fix">
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
