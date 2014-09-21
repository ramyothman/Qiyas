<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master" AutoEventWireup="true" CodeBehind="SiteForm.aspx.cs" Inherits="SocioBuilderSite.Conference.SiteForm" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><asp:Literal ID="FormTitle" runat="server"  ></asp:Literal></h1>
    <div class="QuestionsGeneratedArea">
        <div id="HeaderArea" runat="server">
        </div>
        <div id="ValidationResults" runat="server">
            <br />
            <asp:Label ID="LblValidation"
                runat="server" Text="" Style="color: #CC0000"></asp:Label><br />
        </div>
        <dx:ASPxCallbackPanel ID="SavingCallbackPanel"
            ClientInstanceName="SavingCallbackPanel" runat="server"
            OnCallback="SavingCallbackPanel_Callback">

            <PanelCollection>
                <dx:PanelContent ID="PanelContent1" runat="server" SupportsDisabledAttribute="True">
                    <div id="resultsAreaContainer">
                        <asp:Panel ID="ResultsAreas" runat="server">
                        </asp:Panel>
                        <div runat="server" id="ResultsAreasSuccess" visible="false" class="success">
                        </div>
                    </div>
                </dx:PanelContent>
            </PanelCollection>

        </dx:ASPxCallbackPanel>


        <br />
        <dx:ASPxButton ID="btnSubmitForm" Width="120px" runat="server" Text="Submit"
            CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css" CssPostfix="SoftOrange"
            Font-Bold="True"
            SpriteCssFilePath="~/App_Themes/SoftOrange/{0}/sprite.css"
            OnClick="btnSubmitForm_Click">
            <ClientSideEvents Click="function(s, e) {
	/* var areEditorsValid = ASPxClientEdit.ValidateEditorsInContainerById('resultsAreaContainer');
    if (areEditorsValid) {
		SavingCallbackPanel.PerformCallback('');
	}*/
}" />
        </dx:ASPxButton>
        </div>
</asp:Content>
