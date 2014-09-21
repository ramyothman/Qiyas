<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="SendEmails.aspx.cs" Inherits="SocioBuilderSite.Administrator.ContentManagement.SendEmails" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxSpellChecker.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSpellChecker" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript">
    function OnCustomDialogOpened() {
        RestoreInsertTemplateFormDialogState();
    }

    function OnCustomDialogClosed(s, e) {
        if (e.name == "InsertTemplate" && (e.status == "ok" || e.status == "dbl")) {
            if (e.data) {
                if (e.data.overwrite) {
                    HtmlEditor.SetHtml(e.data.html, false)
                }
                else
                    HtmlEditor.ExecuteCommand(ASPxClientCommandConsts.PASTEHTML_COMMAND, e.data.html);
            }

            SaveInsertTemplateFormDialogState();
        }
    }

    function OnCustomDialogClosing(s, e) {
        if (e.name == "InsertTemplate" && e.status == "ok") {
            RetrieveTemplateHtml(e.status);
            e.handled = true;
        }
    }

    function OnGridRowDblClick(s, e) {
        RetrieveTemplateHtml("dbl");
    }

    function RetrieveTemplateHtml(status) {
        loadingPanel.ShowInElement(templatesGrid.GetMainElement().parentNode);

        templatesGrid.GetRowValues(
        templatesGrid.GetFocusedRowIndex(),
        "EmailContent",
        function (html) {
            loadingPanel.Hide();

            ASPxClientHtmlEditor.CustomDialogComplete(
                status,
                {
                    "html": html,
                    "overwrite": overwriteCheckBox.GetChecked()
                }
            );
        }
    );
    }

    var insertTemplateFormDialogState = {};

    function SaveInsertTemplateFormDialogState() {
        insertTemplateFormDialogState.focusedRow = templatesGrid.GetFocusedRowIndex();
        insertTemplateFormDialogState.overwrite = overwriteCheckBox.GetChecked();
    }

    function RestoreInsertTemplateFormDialogState() {
        if (insertTemplateFormDialogState.focusedRow)
            templatesGrid.SetFocusedRowIndex(insertTemplateFormDialogState.focusedRow);

        if (insertTemplateFormDialogState.overwrite != undefined)
            overwriteCheckBox.SetChecked(insertTemplateFormDialogState.overwrite);
    }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <div class="g12 widgets">
        <div class="widget widget-header-blue">
            <h3 class="handle">
                Send Email</h3>
            <div class="inner-content">
            <div class="alert success" runat="server" visible="false" id="SuccessMessage"></div>
            <table>
            <tr>
            <td><strong>Subject</strong></td>
            </tr>
            <tr>
            <td>
                <dx:ASPxTextBox ID="txtSubject" runat="server" Width="100%">
                </dx:ASPxTextBox>
            </td>
            </tr>
    <tr>
        <td><strong>Content:</strong></td>
    </tr>
    <tr>
        <td>

             <dx:ASPxHtmlEditor ID="EmailContentHtmlEditor" runat="server" ClientInstanceName="HtmlEditor">
           <Toolbars>
            <dx:HtmlEditorToolbar Caption="DemoToolbar" Name="DemoToolbar">
                <Items>
                    <dx:ToolbarUndoButton>
                    </dx:ToolbarUndoButton>
                    <dx:ToolbarRedoButton>
                    </dx:ToolbarRedoButton>
                    <dx:ToolbarJustifyLeftButton BeginGroup="True">
                    </dx:ToolbarJustifyLeftButton>
                    <dx:ToolbarJustifyCenterButton>
                    </dx:ToolbarJustifyCenterButton>
                    <dx:ToolbarJustifyRightButton>
                    </dx:ToolbarJustifyRightButton>
                    <dx:ToolbarJustifyFullButton>
                    </dx:ToolbarJustifyFullButton>
                    <dx:ToolbarInsertLinkDialogButton></dx:ToolbarInsertLinkDialogButton>
                    <dx:ToolbarPasteButton></dx:ToolbarPasteButton>
                    <dx:ToolbarPasteFromWordButton></dx:ToolbarPasteFromWordButton>
                    <dx:ToolbarRemoveFormatButton></dx:ToolbarRemoveFormatButton>
                    <dx:ToolbarCustomDialogButton Name="InsertTemplate" BeginGroup="True" ToolTip="Insert Template">
                        <Image Url="template.png">
                        </Image>
                    </dx:ToolbarCustomDialogButton>
                </Items>
            </dx:HtmlEditorToolbar>
        </Toolbars>
           <CustomDialogs>
            <dx:HtmlEditorCustomDialog Caption="Insert Template" Name="InsertTemplate" FormPath="../Controls/InsertTemplate.ascx"
                OkButtonText="Insert">
            </dx:HtmlEditorCustomDialog>
        </CustomDialogs>
        <ClientSideEvents CustomDialogOpened="OnCustomDialogOpened" CustomDialogClosed="OnCustomDialogClosed"
            CustomDialogClosing="OnCustomDialogClosing" />
          </dx:ASPxHtmlEditor>
        </td>
    </tr>
    
    <tr>
        <td>
        <strong>Contacts</strong>
        </td>
        
    </tr>
    <tr>
        <td>
            <dx:ASPxTextBox ID="txtEmail" runat="server" Width="100%">
            </dx:ASPxTextBox>
        </td>
    </tr>
    <tr>
    <td>
            <dx:ASPxGridView ID="gridContacts" runat="server" AutoGenerateColumns="False" 
                ClientInstanceName="gridUsers" KeyFieldName="BusinessEntityId" 
                Width="100%">
                <Columns>
                    <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" 
                        Width="50px">
                        <ClearFilterButton Visible="True">
                        </ClearFilterButton>
                        <HeaderCaptionTemplate>
                        <center>
                            <dx:ASPxCheckBox ID="chkUserSelect" runat="server" CheckState="Unchecked" 
                                Text=" ">
                                <ClientSideEvents CheckedChanged="function(s, e) {
	if(s.GetChecked())
		gridUsers.SelectRows();
	else
		gridUsers.UnselectRows(); 

        
}" />
                            </dx:ASPxCheckBox>
                            </center>
                        </HeaderCaptionTemplate>
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn FieldName="BusinessEntityId" ReadOnly="True" 
                        Visible="False" VisibleIndex="1">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Email" VisibleIndex="15" Width="200px">
                        <Settings AutoFilterCondition="Contains" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DisplayName" VisibleIndex="10" 
                        Width="200px">
                        <Settings AutoFilterCondition="Contains" />
                    </dx:GridViewDataTextColumn>
                </Columns>
                <Settings ShowFilterRow="True" />
            </dx:ASPxGridView>
            <asp:ObjectDataSource ID="ManageUsersObjectDS" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
    TypeName="BusinessLogicLayer.Components.Persons.PersonLogic" 
        DeleteMethod="Delete">
    <DeleteParameters>
        <asp:Parameter Name="Original_BusinessEntityId" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
        </td>
    </tr>
    <tr>
        <td align="right">
            <dx:ASPxButton ID="btnSendEmails" runat="server" Text="Send Emails" 
                onclick="btnSendEmails_Click" Width="191px">
            </dx:ASPxButton>
        </td>
    </tr>
 </table>
            </div>
        </div>
    </div>

 
</asp:Content>
