<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MyAbstracts.ascx.cs" Inherits="SocioBuilderSite.Controls.Conference.MyAbstracts" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.XtraReports.v14.1.Web, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxSpellChecker.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSpellChecker" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dx" %>

         <dx:ASPxCallbackPanel ID="callBackPanel" ClientInstanceName="callBackPanel" runat="server" >
         <ClientSideEvents EndCallback="function(s,e){ReportViewer1.SaveToDisk('PDFAbstract');ReportViewer1.Print();}" />
             <PanelCollection>
<dx:PanelContent ID="PanelContent1" runat="server" SupportsDisabledAttribute="True">
<div id="wrapper" style="margin-left: 10px;">
<br class="clear" /><br />
<div style="min-width:400px;">
             <dx:ASPxGridView ID="AbstractsGrid" ClientInstanceName="AbstractsGrid" runat="server"
                 AutoGenerateColumns="False" DataSourceID="AbstractsObjectDS" KeyFieldName="AbstractId"
                 OnRowUpdating="AbstractsGrid_RowUpdating">
                 <SettingsText CommandDelete="Are you sure you want to delete this record?" />
                 <Templates>
                     <DataRow>
                         <div class="schedule">
                              <div class="date">
        <div class="month"><%# Eval("ABCode")%></div>
        <asp:LinkButton runat="server" id="LinkButton1" Text="Abstract(PDF)" CommandArgument="<%# Container.KeyValue %>" 
                                         onclick="AbstractPDFView_Click">
                                         Abstract PDF
                                         </asp:LinkButton>
        <a href="javascript:void(0);" onclick="StartEditGrid('<%# Container.KeyValue %>');">Withdraw</a>

      </div>

                             <%--<div class="date">
                                 <div style="text-align: left;">
                                    <h3>
                                     </h3><br />
                                    <span>
                                        
                                    </span><br />
                                    <span>
                                        <a href="javascript:void(0);" onclick="callBackPanel.PerformCallback('<%# Container.KeyValue %>');">
                                          Print Abstract</a>
                                    </span><br />
                                     <span style="padding-top: 10px;"><a href="javascript:void(0);" onclick="StartEditGrid('<%# Container.KeyValue %>');">
                                          Withdrawal</a></span><br />
                                     
                                 </div>
                             </div>--%>
                             <div class="sch-info">
                                <div class="abs-icons">
        <div class='<%# GetStatusIcon(Eval("AcceptanceType").ToString(), Eval("PosterPath").ToString()) %>'></div>
      </div>
      <table style="width:400px;">
      <tr>
      <td>
       <h1>
            <%# Eval("AbstractTitle") %></h1>
                                           </td>
      </tr>
                                
             </table>
                                 <p>
                                     <%# Eval("Background")%></p>
                                 <p>
                                     <%# Eval("AbstractIntro") %>
                                 </p>
                                 <h3>
                                     Authors:</h3>
                                 <p>
                                     <%# Eval("AbstractAuthors") %></p>
                         



<div id="new-info">

        <a href="javascript:void(0);" onclick="callBackPanel.PerformCallback('<%# Container.KeyValue %>');" title="Print"><div class="abs-print"></div></a>
        <a href="#"><div class="abs-mail" title="Email"></div></a>
        <asp:LinkButton runat="server" id="AbstractPDFView" Text="Abstract(PDF)" ToolTip="Abstract Pdf" CommandArgument="<%# Container.KeyValue %>" 
                                         onclick="AbstractPDFView_Click"><div class="abs-pdf">
        
        </div></asp:LinkButton>
        <a href="javascript:void(0);" onclick="StartEditGrid('<%# Container.KeyValue %>');" title="Withdraw"><div class="abs-withdraw"></div></a>
</div>

    </div>
                             <div class="clear">
                             </div>
                         </div>
                     </DataRow>

                     <EmptyDataRow>
                        You haven't submitted any abstracts yet. To Submit an Abstract go the Abstract Submission Page.
                     </EmptyDataRow>
                 </Templates>
                 <Columns>
                     <dx:GridViewCommandColumn VisibleIndex="0">
                         <EditButton Visible="True">
                         </EditButton>
                     </dx:GridViewCommandColumn>
                     <dx:GridViewDataTextColumn FieldName="AbstractId" ReadOnly="True" VisibleIndex="1"
                         SortIndex="0" SortOrder="Descending">
                         <EditFormSettings Visible="False" />
                     </dx:GridViewDataTextColumn>
                     <dx:GridViewDataTextColumn Caption="Conference" FieldName="ConferenceName" VisibleIndex="2">
                         <EditFormSettings Visible="False" />
                     </dx:GridViewDataTextColumn>
                     <dx:GridViewDataTextColumn FieldName="ConferenceId" VisibleIndex="3" Caption="Conference">
                         <EditFormSettings Visible="False" />
                     </dx:GridViewDataTextColumn>
                     <dx:GridViewDataTextColumn FieldName="PersonId" VisibleIndex="3" Visible="False"
                         Caption="Person Id">
                         <EditFormSettings Visible="False" />
                     </dx:GridViewDataTextColumn>
                     <dx:GridViewDataTextColumn FieldName="DisplayName" VisibleIndex="6" Caption="Speaker"
                         Name="Display Name">
                         <EditFormSettings Visible="False" />
                     </dx:GridViewDataTextColumn>
                     <dx:GridViewDataTextColumn FieldName="AbstractTitle" ShowInCustomizationForm="True"
                         VisibleIndex="4">
                         <EditFormSettings Visible="False" />
                     </dx:GridViewDataTextColumn>
                     <dx:GridViewDataTextColumn FieldName="Topic" VisibleIndex="5">
                         <EditFormSettings Visible="False" />
                     </dx:GridViewDataTextColumn>
                     <dx:GridViewDataTextColumn FieldName="AbstractIntro" VisibleIndex="3" Visible="False">
                         <EditFormSettings Visible="False" />
                     </dx:GridViewDataTextColumn>
                     <dx:GridViewDataTextColumn FieldName="AbstractAuthors" VisibleIndex="3" Visible="False">
                         <EditFormSettings Visible="False" />
                     </dx:GridViewDataTextColumn>
                     <dx:GridViewDataTextColumn FieldName="CoverLetter" VisibleIndex="4" Visible="False">
                         <EditFormSettings Visible="False" />
                     </dx:GridViewDataTextColumn>
                     <dx:GridViewDataCheckColumn FieldName="IsAccepted" VisibleIndex="7" Visible="False">
                     </dx:GridViewDataCheckColumn>
                     <dx:GridViewDataComboBoxColumn FieldName="AcceptanceType" VisibleIndex="7" Caption="Status">
                         <PropertiesComboBox ValueType="System.String">
                             <Items>
                                 <dx:ListEditItem Text="Cancel" Value="Cancelled" />
                             </Items>
                         </PropertiesComboBox>
                     </dx:GridViewDataComboBoxColumn>
                     <dx:GridViewDataTextColumn FieldName="PresentationPath" Visible="False" VisibleIndex="10">
                         <EditFormSettings Visible="False" />
                     </dx:GridViewDataTextColumn>
                     <dx:GridViewDataTextColumn FieldName="PosterPath" Visible="False" VisibleIndex="10">
                         <EditFormSettings Visible="False" />
                     </dx:GridViewDataTextColumn>
                 </Columns>
                 <SettingsBehavior AllowFocusedRow="True" ConfirmDelete="True" />
                 <SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="450px" />
                 <Settings ShowFilterRowMenu="True" ShowColumnHeaders="False" />
             </dx:ASPxGridView>
             </div>
             <asp:ObjectDataSource ID="AbstractsObjectDS" runat="server" OldValuesParameterFormatString="original_{0}"
                 SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.Conference.AbstractsLogic"
                 DeleteMethod="Delete" UpdateMethod="Update">
                 <DeleteParameters>
                     <asp:Parameter Name="Original_AbstractId" Type="Int32" />
                 </DeleteParameters>
                 <SelectParameters>
                     <asp:SessionParameter Name="PersonId" SessionField="CurrentPersonId" Type="String" />
                 </SelectParameters>
                 <UpdateParameters>
                     <asp:Parameter Name="PersonId" Type="Int32" />
                     <asp:Parameter Name="ConferenceId" Type="Int32" />
                     <asp:Parameter Name="ConferenceCategoryId" Type="Int32" />
                     <asp:Parameter Name="AbstractTitle" Type="String" />
                     <asp:Parameter Name="AbstractIntro" Type="String" />
                     <asp:Parameter Name="AbstractAuthors" Type="String" />
                     <asp:Parameter Name="CoverLetter" Type="String" />
                     <asp:Parameter Name="IsAccepted" Type="Boolean" />
                     <asp:Parameter Name="AcceptanceType" Type="String" />
                     <asp:Parameter Name="PresentationPath" Type="String" />
                     <asp:Parameter Name="PosterPath" Type="String" />
                     <asp:Parameter Name="Topic" Type="String" />
                     <asp:Parameter Name="Background" Type="String" />
                     <asp:Parameter Name="Methods" Type="String" />
                     <asp:Parameter Name="Results" Type="String" />
                     <asp:Parameter Name="Conclusions" Type="String" />
                     <asp:Parameter Name="AbstractTerms" Type="String" />
                     <asp:Parameter Name="AbstractKeywords" Type="String" />
                     <asp:Parameter Name="DocumentPath1" Type="String" />
                     <asp:Parameter Name="DocumentPath2" Type="String" />
                     <asp:Parameter Name="DocumentPath3" Type="String" />
                     <asp:Parameter Name="Original_AbstractId" Type="Int32" />
                 </UpdateParameters>
             </asp:ObjectDataSource>
         </div>
         <dx:ReportViewer ID="ReportViewer1" ClientInstanceName="ReportViewer1" runat="server">
    </dx:ReportViewer>
</dx:PanelContent>
</PanelCollection>
         </dx:ASPxCallbackPanel>
