<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AbstractControl.ascx.cs"
    Inherits="SocioBuilderSite.Administrator.Conference.Abstracts.Controls.AbstractControl" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxSpellChecker.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSpellChecker" tagprefix="dx" %>
<div class="g8">
    <div class="widgets">
        <div class="widget widget-header-blue" id="widget_charts">
            <h3 class="handle" runat="server" id="MainAbstractCode">
            </h3>
            <div class="inner-content">
                <div class="form">
                    <fieldset class="fieldset">
                        <%--<label class="label">Text Fields</label>--%>
                        <section><label class="label" for="text_field">Category</label>
							<div>
                            <dx:ASPxComboBox ID="MainCategoryCombo" runat="server" 
                                    DataSourceID="ConferenceCategoryObjectDS" TextField="CategoryName" 
                                    ValueField="ConferenceCategoryId" ValueType="System.Int32"></dx:ASPxComboBox>
                                <asp:ObjectDataSource ID="ConferenceCategoryObjectDS" runat="server" 
                                    OldValuesParameterFormatString="original_{0}" 
                                    SelectMethod="GetAllByConferenceId" 
                                    TypeName="BusinessLogicLayer.Components.Conference.ConferenceCategoryLogic">
                                    <SelectParameters>
                                        <asp:QueryStringParameter DefaultValue="0" Name="ConferenceId" 
                                            QueryStringField="code" Type="Int32" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                            </div>
						</section>
                        <section><label class="label" for="text_field">Title</label>
							<div>
                            <dx:ASPxHtmlEditor Width="480px" runat="server" ID="MainTitleHtml">
                                <Toolbars>
                                    <dx:HtmlEditorToolbar Name="StandardToolbar1">
                                        <Items>
                                            <dx:ToolbarCutButton>
                                            </dx:ToolbarCutButton>
                                            <dx:ToolbarCopyButton>
                                            </dx:ToolbarCopyButton>
                                            <dx:ToolbarPasteButton>
                                            </dx:ToolbarPasteButton>
                                            <dx:ToolbarPasteFromWordButton>
                                            </dx:ToolbarPasteFromWordButton>
                                            <dx:ToolbarRemoveFormatButton BeginGroup="True">
                                            </dx:ToolbarRemoveFormatButton>
                                            <dx:ToolbarInsertOrderedListButton BeginGroup="True">
                                            </dx:ToolbarInsertOrderedListButton>
                                            <dx:ToolbarInsertUnorderedListButton>
                                            </dx:ToolbarInsertUnorderedListButton>
                                            <dx:ToolbarInsertLinkDialogButton BeginGroup="True">
                                            </dx:ToolbarInsertLinkDialogButton>
                                        </Items>
                                    </dx:HtmlEditorToolbar>
                                    <dx:HtmlEditorToolbar Name="StandardToolbar2">
                                        <Items>
                                            <dx:ToolbarBoldButton BeginGroup="True">
                                            </dx:ToolbarBoldButton>
                                            <dx:ToolbarItalicButton>
                                            </dx:ToolbarItalicButton>
                                            <dx:ToolbarUnderlineButton>
                                            </dx:ToolbarUnderlineButton>
                                            <dx:ToolbarStrikethroughButton>
                                            </dx:ToolbarStrikethroughButton>
                                            <dx:ToolbarJustifyLeftButton BeginGroup="True">
                                            </dx:ToolbarJustifyLeftButton>
                                            <dx:ToolbarJustifyCenterButton>
                                            </dx:ToolbarJustifyCenterButton>
                                            <dx:ToolbarJustifyRightButton>
                                            </dx:ToolbarJustifyRightButton>
                                            <dx:ToolbarBackColorButton BeginGroup="True">
                                            </dx:ToolbarBackColorButton>
                                            <dx:ToolbarFontColorButton>
                                            </dx:ToolbarFontColorButton>
                                        </Items>
                                    </dx:HtmlEditorToolbar>
                                </Toolbars>
<SettingsImageUpload>
<ValidationSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></ValidationSettings>
</SettingsImageUpload>

<SettingsImageSelector>
<CommonSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></CommonSettings>
</SettingsImageSelector>

<SettingsDocumentSelector>
<CommonSettings AllowedFileExtensions=".rtf, .pdf, .doc, .docx, .odt, .txt, .xls, .xlsx, .ods, .ppt, .pptx, .odp"></CommonSettings>
</SettingsDocumentSelector>
                                </dx:ASPxHtmlEditor>
                            <dx:ASPxMemo ID="MainTitleMemo" Visible="false" runat="server" Width="100%" Height="71px"></dx:ASPxMemo>
                            </div>
						</section>
                        <section><label class="label" for="text_tooltip">Background</label>
							<div>
                            <dx:ASPxHtmlEditor Width="480px" runat="server" ID="MainBackgroundHtml">
                             <Toolbars>
                                    <dx:HtmlEditorToolbar Name="StandardToolbar1">
                                        <Items>
                                            <dx:ToolbarCutButton>
                                            </dx:ToolbarCutButton>
                                            <dx:ToolbarCopyButton>
                                            </dx:ToolbarCopyButton>
                                            <dx:ToolbarPasteButton>
                                            </dx:ToolbarPasteButton>
                                            <dx:ToolbarPasteFromWordButton>
                                            </dx:ToolbarPasteFromWordButton>
                                            <dx:ToolbarRemoveFormatButton BeginGroup="True">
                                            </dx:ToolbarRemoveFormatButton>
                                            <dx:ToolbarInsertOrderedListButton BeginGroup="True">
                                            </dx:ToolbarInsertOrderedListButton>
                                            <dx:ToolbarInsertUnorderedListButton>
                                            </dx:ToolbarInsertUnorderedListButton>
                                            <dx:ToolbarInsertLinkDialogButton BeginGroup="True">
                                            </dx:ToolbarInsertLinkDialogButton>
                                        </Items>
                                    </dx:HtmlEditorToolbar>
                                    <dx:HtmlEditorToolbar Name="StandardToolbar2">
                                        <Items>
                                            <dx:ToolbarBoldButton BeginGroup="True">
                                            </dx:ToolbarBoldButton>
                                            <dx:ToolbarItalicButton>
                                            </dx:ToolbarItalicButton>
                                            <dx:ToolbarUnderlineButton>
                                            </dx:ToolbarUnderlineButton>
                                            <dx:ToolbarStrikethroughButton>
                                            </dx:ToolbarStrikethroughButton>
                                            <dx:ToolbarJustifyLeftButton BeginGroup="True">
                                            </dx:ToolbarJustifyLeftButton>
                                            <dx:ToolbarJustifyCenterButton>
                                            </dx:ToolbarJustifyCenterButton>
                                            <dx:ToolbarJustifyRightButton>
                                            </dx:ToolbarJustifyRightButton>
                                            <dx:ToolbarBackColorButton BeginGroup="True">
                                            </dx:ToolbarBackColorButton>
                                            <dx:ToolbarFontColorButton>
                                            </dx:ToolbarFontColorButton>
                                        </Items>
                                    </dx:HtmlEditorToolbar>
                                </Toolbars>
<SettingsImageUpload>
<ValidationSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></ValidationSettings>
</SettingsImageUpload>

<SettingsImageSelector>
<CommonSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></CommonSettings>
</SettingsImageSelector>

<SettingsDocumentSelector>
<CommonSettings AllowedFileExtensions=".rtf, .pdf, .doc, .docx, .odt, .txt, .xls, .xlsx, .ods, .ppt, .pptx, .odp"></CommonSettings>
</SettingsDocumentSelector>
                            </dx:ASPxHtmlEditor>
                            <dx:ASPxMemo ID="MainBackgroundMemo" Visible="false" runat="server" Width="100%" Height="150px"></dx:ASPxMemo>
							<%--<span>Just specify a title attribut to get a Tooltip</span>--%>
							</div>
						</section>
                        <section><label class="label" for="text_tooltip">Methods</label>
							<div>
                            <dx:ASPxHtmlEditor Width="480px" runat="server" ID="MainMethodsHtml">
                             <Toolbars>
                                    <dx:HtmlEditorToolbar Name="StandardToolbar1">
                                        <Items>
                                            <dx:ToolbarCutButton>
                                            </dx:ToolbarCutButton>
                                            <dx:ToolbarCopyButton>
                                            </dx:ToolbarCopyButton>
                                            <dx:ToolbarPasteButton>
                                            </dx:ToolbarPasteButton>
                                            <dx:ToolbarPasteFromWordButton>
                                            </dx:ToolbarPasteFromWordButton>
                                            <dx:ToolbarRemoveFormatButton BeginGroup="True">
                                            </dx:ToolbarRemoveFormatButton>
                                            <dx:ToolbarInsertOrderedListButton BeginGroup="True">
                                            </dx:ToolbarInsertOrderedListButton>
                                            <dx:ToolbarInsertUnorderedListButton>
                                            </dx:ToolbarInsertUnorderedListButton>
                                            <dx:ToolbarInsertLinkDialogButton BeginGroup="True">
                                            </dx:ToolbarInsertLinkDialogButton>
                                        </Items>
                                    </dx:HtmlEditorToolbar>
                                    <dx:HtmlEditorToolbar Name="StandardToolbar2">
                                        <Items>
                                            <dx:ToolbarBoldButton BeginGroup="True">
                                            </dx:ToolbarBoldButton>
                                            <dx:ToolbarItalicButton>
                                            </dx:ToolbarItalicButton>
                                            <dx:ToolbarUnderlineButton>
                                            </dx:ToolbarUnderlineButton>
                                            <dx:ToolbarStrikethroughButton>
                                            </dx:ToolbarStrikethroughButton>
                                            <dx:ToolbarJustifyLeftButton BeginGroup="True">
                                            </dx:ToolbarJustifyLeftButton>
                                            <dx:ToolbarJustifyCenterButton>
                                            </dx:ToolbarJustifyCenterButton>
                                            <dx:ToolbarJustifyRightButton>
                                            </dx:ToolbarJustifyRightButton>
                                            <dx:ToolbarBackColorButton BeginGroup="True">
                                            </dx:ToolbarBackColorButton>
                                            <dx:ToolbarFontColorButton>
                                            </dx:ToolbarFontColorButton>
                                        </Items>
                                    </dx:HtmlEditorToolbar>
                                </Toolbars>
<SettingsImageUpload>
<ValidationSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></ValidationSettings>
</SettingsImageUpload>

<SettingsImageSelector>
<CommonSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></CommonSettings>
</SettingsImageSelector>

<SettingsDocumentSelector>
<CommonSettings AllowedFileExtensions=".rtf, .pdf, .doc, .docx, .odt, .txt, .xls, .xlsx, .ods, .ppt, .pptx, .odp"></CommonSettings>
</SettingsDocumentSelector>
                            </dx:ASPxHtmlEditor>
                            <dx:ASPxMemo ID="MainMethodsMemo" Visible="false" runat="server" Width="100%" Height="150px"></dx:ASPxMemo>
							<%--<span>Just specify a title attribut to get a Tooltip</span>--%>
							</div>
						</section>
                        <section><label class="label" for="text_tooltip">Results</label>
							<div>
                            <dx:ASPxHtmlEditor Width="480px" runat="server" ID="MainResultsHtml">
                             <Toolbars>
                                    <dx:HtmlEditorToolbar Name="StandardToolbar1">
                                        <Items>
                                            <dx:ToolbarCutButton>
                                            </dx:ToolbarCutButton>
                                            <dx:ToolbarCopyButton>
                                            </dx:ToolbarCopyButton>
                                            <dx:ToolbarPasteButton>
                                            </dx:ToolbarPasteButton>
                                            <dx:ToolbarPasteFromWordButton>
                                            </dx:ToolbarPasteFromWordButton>
                                            <dx:ToolbarRemoveFormatButton BeginGroup="True">
                                            </dx:ToolbarRemoveFormatButton>
                                            <dx:ToolbarInsertOrderedListButton BeginGroup="True">
                                            </dx:ToolbarInsertOrderedListButton>
                                            <dx:ToolbarInsertUnorderedListButton>
                                            </dx:ToolbarInsertUnorderedListButton>
                                            <dx:ToolbarInsertLinkDialogButton BeginGroup="True">
                                            </dx:ToolbarInsertLinkDialogButton>
                                        </Items>
                                    </dx:HtmlEditorToolbar>
                                    <dx:HtmlEditorToolbar Name="StandardToolbar2">
                                        <Items>
                                            <dx:ToolbarBoldButton BeginGroup="True">
                                            </dx:ToolbarBoldButton>
                                            <dx:ToolbarItalicButton>
                                            </dx:ToolbarItalicButton>
                                            <dx:ToolbarUnderlineButton>
                                            </dx:ToolbarUnderlineButton>
                                            <dx:ToolbarStrikethroughButton>
                                            </dx:ToolbarStrikethroughButton>
                                            <dx:ToolbarJustifyLeftButton BeginGroup="True">
                                            </dx:ToolbarJustifyLeftButton>
                                            <dx:ToolbarJustifyCenterButton>
                                            </dx:ToolbarJustifyCenterButton>
                                            <dx:ToolbarJustifyRightButton>
                                            </dx:ToolbarJustifyRightButton>
                                            <dx:ToolbarBackColorButton BeginGroup="True">
                                            </dx:ToolbarBackColorButton>
                                            <dx:ToolbarFontColorButton>
                                            </dx:ToolbarFontColorButton>
                                        </Items>
                                    </dx:HtmlEditorToolbar>
                                </Toolbars>
<SettingsImageUpload>
<ValidationSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></ValidationSettings>
</SettingsImageUpload>

<SettingsImageSelector>
<CommonSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></CommonSettings>
</SettingsImageSelector>

<SettingsDocumentSelector>
<CommonSettings AllowedFileExtensions=".rtf, .pdf, .doc, .docx, .odt, .txt, .xls, .xlsx, .ods, .ppt, .pptx, .odp"></CommonSettings>
</SettingsDocumentSelector>
                            </dx:ASPxHtmlEditor>
                            <dx:ASPxMemo ID="MainResultsMemo" Visible="false" runat="server" Width="100%" Height="150px"></dx:ASPxMemo>
							<%--<span>Just specify a title attribut to get a Tooltip</span>--%>
							</div>
						</section>
                        <section><label class="label" for="text_tooltip">Conclusion</label>
							<div>
                            <dx:ASPxHtmlEditor Width="480px" runat="server" ID="MainConclusionHtml">
                             <Toolbars>
                                    <dx:HtmlEditorToolbar Name="StandardToolbar1">
                                        <Items>
                                            <dx:ToolbarCutButton>
                                            </dx:ToolbarCutButton>
                                            <dx:ToolbarCopyButton>
                                            </dx:ToolbarCopyButton>
                                            <dx:ToolbarPasteButton>
                                            </dx:ToolbarPasteButton>
                                            <dx:ToolbarPasteFromWordButton>
                                            </dx:ToolbarPasteFromWordButton>
                                            <dx:ToolbarRemoveFormatButton BeginGroup="True">
                                            </dx:ToolbarRemoveFormatButton>
                                            <dx:ToolbarInsertOrderedListButton BeginGroup="True">
                                            </dx:ToolbarInsertOrderedListButton>
                                            <dx:ToolbarInsertUnorderedListButton>
                                            </dx:ToolbarInsertUnorderedListButton>
                                            <dx:ToolbarInsertLinkDialogButton BeginGroup="True">
                                            </dx:ToolbarInsertLinkDialogButton>
                                        </Items>
                                    </dx:HtmlEditorToolbar>
                                    <dx:HtmlEditorToolbar Name="StandardToolbar2">
                                        <Items>
                                            <dx:ToolbarBoldButton BeginGroup="True">
                                            </dx:ToolbarBoldButton>
                                            <dx:ToolbarItalicButton>
                                            </dx:ToolbarItalicButton>
                                            <dx:ToolbarUnderlineButton>
                                            </dx:ToolbarUnderlineButton>
                                            <dx:ToolbarStrikethroughButton>
                                            </dx:ToolbarStrikethroughButton>
                                            <dx:ToolbarJustifyLeftButton BeginGroup="True">
                                            </dx:ToolbarJustifyLeftButton>
                                            <dx:ToolbarJustifyCenterButton>
                                            </dx:ToolbarJustifyCenterButton>
                                            <dx:ToolbarJustifyRightButton>
                                            </dx:ToolbarJustifyRightButton>
                                            <dx:ToolbarBackColorButton BeginGroup="True">
                                            </dx:ToolbarBackColorButton>
                                            <dx:ToolbarFontColorButton>
                                            </dx:ToolbarFontColorButton>
                                        </Items>
                                    </dx:HtmlEditorToolbar>
                                </Toolbars>
<SettingsImageUpload>
<ValidationSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></ValidationSettings>
</SettingsImageUpload>

<SettingsImageSelector>
<CommonSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></CommonSettings>
</SettingsImageSelector>

<SettingsDocumentSelector>
<CommonSettings AllowedFileExtensions=".rtf, .pdf, .doc, .docx, .odt, .txt, .xls, .xlsx, .ods, .ppt, .pptx, .odp"></CommonSettings>
</SettingsDocumentSelector>
                            </dx:ASPxHtmlEditor>
                            <dx:ASPxMemo ID="MainConclusionMemo" Visible="false" runat="server" Width="100%" Height="150px"></dx:ASPxMemo>
							<%--<span>Just specify a title attribut to get a Tooltip</span>--%>
							</div>
						</section>
                        <section><label class="label" for="text_tooltip">KeyWords</label>
							<div><dx:ASPxTextBox ID="MainKeyWordsText" runat="server" Width="100%"></dx:ASPxTextBox>
							<%--<span>Just specify a title attribut to get a Tooltip</span>--%>
							</div>
						</section>
                    </fieldset>
                </div>
            </div>
        </div>
    </div>
</div>
<div class="g4">
    <div class="widget widget-header-blue">
        <h3 class="handle">
            Abstract Action</h3>
        <div class="inner-content">
            <table>
                <tr>
                    <td>
                        <dx:ASPxButton ID="btnAbstractSave" runat="server" Text="Save" Font-Bold="True" HorizontalAlign="Center"
                            ImagePosition="Top" onclick="btnAbstractSave_Click" >
                            <Image Url="~/Administrator/images/detailSave.png">
                            </Image>
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="btnAbstractCancel" runat="server" Text="Cancel" CausesValidation="False"
                            Font-Bold="True" HorizontalAlign="Center" ImagePosition="Top" 
                            onclick="btnAbstractCancel_Click">
                            <Image Url="~/Administrator/images/detailcancel.png">
                            </Image>
                        </dx:ASPxButton>
                    </td>
                    
                    
                </tr>
                <tr>
                <td>
                        <dx:ASPxButton ID="btnAbstractPDF" runat="server" Text="Doc" Font-Bold="True" HorizontalAlign="Center"
                            ImagePosition="Top" onclick="btnAbstractPDF_Click">
                            <Image Url="~/Administrator/images/Word.png">
                            </Image>
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="btnAbstractAttachment" runat="server" Text="Attachment" Font-Bold="True" HorizontalAlign="Center"
                            ImagePosition="Top" onclick="btnAbstractAttachmentPDF_Click">
                            <Image Url="~/Administrator/images/detailpdf.png">
                            </Image>
                        </dx:ASPxButton>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    <div class="clear">
    </div>
    <div class="widget widget-header-blue">
        <h3 class="handle">
            Abstract Reviewers</h3>
        <div class="inner-content">
            <dx:ASPxGridView ID="gridReviewers" runat="server" AutoGenerateColumns="False" DataSourceID="ReviewersObjectDS"
                KeyFieldName="AbstractReviewerId" ClientInstanceName="gridReviewers">
                <Columns>
                    <dx:GridViewCommandColumn ShowInCustomizationForm="True" ShowSelectCheckbox="True"
                        VisibleIndex="0">
                        <ClearFilterButton Visible="True">
                        </ClearFilterButton>
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn FieldName="AbstractReviewerId" ReadOnly="True" ShowInCustomizationForm="True"
                        Visible="False" VisibleIndex="1">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Reviewer" FieldName="PersonId" ShowInCustomizationForm="True"
                        VisibleIndex="2" Width="300px">
                        <PropertiesComboBox DataSourceID="PersonObjectDS" IncrementalFilteringMode="Contains"
                            TextField="FullName" ValueField="BusinessEntityId" ValueType="System.Int32">
                            <Columns>
                                <dx:ListBoxColumn FieldName="FullName" />
                                <dx:ListBoxColumn FieldName="UserName" />
                            </Columns>
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataCheckColumn FieldName="IsInternal" ShowInCustomizationForm="True"
                        VisibleIndex="3">
                    </dx:GridViewDataCheckColumn>
                    <dx:GridViewDataDateColumn FieldName="DateCreated" ShowInCustomizationForm="True"
                        Visible="False" VisibleIndex="4">
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataCheckColumn FieldName="IsActive" ShowInCustomizationForm="True" Visible="False"
                        VisibleIndex="5">
                    </dx:GridViewDataCheckColumn>
                </Columns>
                <Settings ShowFilterRow="True" />
            </dx:ASPxGridView>
            <asp:ObjectDataSource ID="ReviewersObjectDS" runat="server" OldValuesParameterFormatString="original_{0}"
                SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.Conference.AbstractReviewerLogic">
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="PersonObjectDS" runat="server" OldValuesParameterFormatString="original_{0}"
                SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.Persons.PersonLogic">
            </asp:ObjectDataSource>
            <br />
            <dx:ASPxButton ID="btnSaveReviewers" runat="server" Text="Assign Reviewers">
            </dx:ASPxButton>
        </div>
    </div>
    <div class="clear">
    </div>
    <div class="widget widget-header-blue">
        <h3 class="handle">
            Abstract Authors</h3>
        <div class="inner-content">
            <dx:ASPxGridView ID="gridAuthors" runat="server" AutoGenerateColumns="False" DataSourceID="AbstractAuthorsObjectDS"
                KeyFieldName="AbstractAuthorId">
                <Columns>
                    <dx:GridViewDataTextColumn FieldName="AbstractAuthorId" ReadOnly="True" Visible="False"
                        VisibleIndex="3">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="AbstractId" Visible="False" VisibleIndex="4">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="FirstName" Visible="False" VisibleIndex="5">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="FamilyName" Visible="False" VisibleIndex="6">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Title" Visible="False" VisibleIndex="7">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Author" FieldName="CompleteName" VisibleIndex="0">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Degree" Visible="False" VisibleIndex="8">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Email" VisibleIndex="1">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Address" Visible="False" VisibleIndex="9">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="PhoneNumber" Visible="False" VisibleIndex="10">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="AffilitationDepartment" Visible="False" VisibleIndex="11">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="AffilitationInstitutionHospital" Visible="False"
                        VisibleIndex="12">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="AffilitationCity" Visible="False" VisibleIndex="13">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="AffilitationCountry" Visible="False" VisibleIndex="14">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Country" Visible="False" VisibleIndex="15">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="POBox" Visible="False" VisibleIndex="16">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ZipCode" Visible="False" VisibleIndex="17">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="City" Visible="False" VisibleIndex="18">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataCheckColumn Caption="Main Author" FieldName="IsMainAuthor" VisibleIndex="2">
                    </dx:GridViewDataCheckColumn>
                    <dx:GridViewDataTextColumn FieldName="PhoneNumberAreaCode" Visible="False" VisibleIndex="19">
                    </dx:GridViewDataTextColumn>
                </Columns>
            </dx:ASPxGridView>
            <asp:ObjectDataSource ID="AbstractAuthorsObjectDS" runat="server" OldValuesParameterFormatString="original_{0}"
                SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.Conference.AbstractAuthorsLogic">
                <SelectParameters>
                    <asp:QueryStringParameter DefaultValue="0" Name="AbstractId" QueryStringField="abstract"
                        Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
    </div>
    <div class="clear">
    </div>
    <div class="widget widget-header-blue">
        <h3 class="handle">
            Abstract Review</h3>
        <div class="inner-content">
        <table style="width:100%;">
            <tr>
                <td>Status</td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxComboBox ID="cmbStatus" runat="server" DataSourceID="statusObjectDS" 
                        TextField="Name" ValueField="AbstractStatusId" ValueType="System.Int32">
                    </dx:ASPxComboBox>
                    <asp:ObjectDataSource ID="statusObjectDS" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.Conference.AbstractStatusLogic">
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td></td>
            </tr>
            <tr runat="server" visible="false">
                <td>
                Feedback
                </td>
            </tr>
            <tr runat="server" visible="false">
                <td>
                <dx:ASPxMemo  runat="server" ID="memoFeedback" Width="100%" Height="150px"></dx:ASPxMemo>
                </td>
            </tr>
            <tr>
            <td></td>
            </tr>
            <tr>
                <td align="right">
                    <dx:ASPxButton ID="btnSaveFeedback" runat="server" Text="Save Feedback" 
                        onclick="btnSaveFeedback_Click">
                    </dx:ASPxButton>
                </td>
            </tr>
        </table>
        </div>
        </div>
</div>
