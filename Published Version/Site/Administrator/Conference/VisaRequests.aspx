<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="VisaRequests.aspx.cs" Inherits="SocioBuilderSite.Administrator.Conference.VisaRequests" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1.Export, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView.Export" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
				<h3 class="handle">Registrations Details

                    <span style="float:right;margin-right:5px;margin-left:5px;">
                    <dx:ASPxButton ID="btnDownloadList" runat="server" Text="Download List" 
                        onclick="btnDownloadList_Click" >
                    </dx:ASPxButton>
                </span>
				</h3>
				<div class="inner-content">
                    <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="VisaRequestsObjectDS" KeyFieldName="VisaRequestID">
                        <Columns>
                            <dx:GridViewDataTextColumn FieldName="VisaRequestID" ReadOnly="True" VisibleIndex="0">
                                <EditFormSettings Visible="False" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="ConferenceID" Caption="ID" VisibleIndex="1">
                                <DataItemTemplate>
                                    <%# Eval("ConferenceID") %> <a href='<%# BusinessLogicLayer.Common.PersonContentPath + Eval("PassportAttachment").ToString() %>' runat="server">Download</a>
                                </DataItemTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="PersonID" VisibleIndex="2">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="PersonName" VisibleIndex="2">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="PersonPhone" VisibleIndex="2">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="PersonEmail" VisibleIndex="2">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="Country" VisibleIndex="3">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="City" VisibleIndex="4">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="Religion" VisibleIndex="5">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="JobTitle" VisibleIndex="6">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="Company" VisibleIndex="7">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="PassportAttachment" VisibleIndex="8">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataCheckColumn FieldName="IsOrganizationApproved" VisibleIndex="9">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataCheckColumn FieldName="IsTaken" VisibleIndex="10">
                            </dx:GridViewDataCheckColumn>
                            <dx:GridViewDataTextColumn FieldName="VisaAttachment" Visible="false" VisibleIndex="11">
                            </dx:GridViewDataTextColumn>
                            
                        </Columns>
                     </dx:ASPxGridView>
                    <dx:ASPxGridViewExporter ID="ASPxGridViewExporter1" runat="server" 
        GridViewID="ASPxGridView1">
    </dx:ASPxGridViewExporter>
                    <asp:ObjectDataSource ID="VisaRequestsObjectDS" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" TypeName="BusinessLogicLayer.Components.Conference.VisaRequestLogic" UpdateMethod="Update">
                        <DeleteParameters>
                            <asp:Parameter Name="Original_VisaRequestID" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="ConferenceID" Type="Int32" />
                            <asp:Parameter Name="PersonID" Type="Int32" />
                            <asp:Parameter Name="Country" Type="String" />
                            <asp:Parameter Name="City" Type="String" />
                            <asp:Parameter Name="Religion" Type="String" />
                            <asp:Parameter Name="JobTitle" Type="String" />
                            <asp:Parameter Name="Company" Type="String" />
                            <asp:Parameter Name="PassportAttachment" Type="String" />
                            <asp:Parameter Name="IsOrganizationApproved" Type="Boolean" />
                            <asp:Parameter Name="IsTaken" Type="Boolean" />
                            <asp:Parameter Name="VisaAttachment" Type="String" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="ConferenceID" Type="Int32" />
                            <asp:Parameter Name="PersonID" Type="Int32" />
                            <asp:Parameter Name="Country" Type="String" />
                            <asp:Parameter Name="City" Type="String" />
                            <asp:Parameter Name="Religion" Type="String" />
                            <asp:Parameter Name="JobTitle" Type="String" />
                            <asp:Parameter Name="Company" Type="String" />
                            <asp:Parameter Name="PassportAttachment" Type="String" />
                            <asp:Parameter Name="IsOrganizationApproved" Type="Boolean" />
                            <asp:Parameter Name="IsTaken" Type="Boolean" />
                            <asp:Parameter Name="VisaAttachment" Type="String" />
                            <asp:Parameter Name="Original_VisaRequestID" Type="Int32" />
                        </UpdateParameters>
                    </asp:ObjectDataSource>
                    </div>
        </div>
    
</asp:Content>
