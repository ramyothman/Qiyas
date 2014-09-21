<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdministrationMaster.Master" AutoEventWireup="true" CodeBehind="ManageWards.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.BedManagement.ManageWards" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MessagePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainPlaceHolder" runat="server">
<div class="portlet ui-widget ui-widget-content ui-helper-clearfix ui-corner-all form-container">
            <div class="portlet-header ui-widget-header">
                Manage Wards</div>
            <div class="portlet-content">
                <div>
                    <dx:ASPxGridView ID="WardsGrid" runat="server" Width="100%" 
                        AutoGenerateColumns="False" DataSourceID="WardsObjectDS" 
                        KeyFieldName="WardId" onhtmldatacellprepared="WardsGrid_HtmlDataCellPrepared">
                        <Columns>
                            <dx:GridViewCommandColumn VisibleIndex="0">
                                <EditButton Visible="True">
                                </EditButton>
                                <NewButton Visible="True">
                                </NewButton>
                                <DeleteButton Visible="True">
                                </DeleteButton>
                                <ClearFilterButton Visible="True">
                                </ClearFilterButton>
                            </dx:GridViewCommandColumn>
                            <dx:GridViewDataTextColumn FieldName="WardType" Caption=" " Width="32px" 
                                VisibleIndex="1">
                                <DataItemTemplate>
                                <img style="float:left;" runat="server" id="MaleImage" src="~/Images/Hospital/PatientMale.png" alt="M" width="16" height="16" />
                                <img style="float:left;" runat="server" ID="FemaleImage" src="~/Images/Hospital/PatientFemale.png" alt="F" width="16" height="16" />
                                
                                </DataItemTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="WardId" ReadOnly="True" VisibleIndex="2" 
                                Caption="Id" Width="50px">
                                <EditFormSettings Visible="False" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="WardCode" VisibleIndex="3" Caption="Code" 
                                Width="50px">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="WardDescription" VisibleIndex="4" 
                                Caption="Description">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="BedsNumber" VisibleIndex="5" 
                                Caption="Beds" Width="50px">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="WardCapacity" VisibleIndex="6" 
                                Caption="Capacity">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="RoomsNumber" VisibleIndex="7" 
                                Caption="Rooms">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="WardPhone" VisibleIndex="8" 
                                Caption="Phone">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="WardOrder" VisibleIndex="9" 
                                Caption="Order">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataHyperLinkColumn Caption="Configure" FieldName="WardId" 
                                ShowInCustomizationForm="True" VisibleIndex="10">
                                <PropertiesHyperLinkEdit NavigateUrlFormatString="ConfigureWard.aspx?Code={0}" 
                                    Text="Configure">
                                </PropertiesHyperLinkEdit>
                            </dx:GridViewDataHyperLinkColumn>
                            <dx:GridViewDataColorEditColumn FieldName="WardColor" VisibleIndex="11" 
                                Caption=" ">
                                <PropertiesColorEdit NullText="No Color">
                                </PropertiesColorEdit>
                                <Settings AllowAutoFilter="False" />
                            </dx:GridViewDataColorEditColumn>
                        </Columns>
                        <Settings ShowFilterRow="True" />
                    </dx:ASPxGridView>
                    <asp:ObjectDataSource ID="WardsObjectDS" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                        TypeName="BusinessLogicLayer.Components.BedManagement.WardLogic"></asp:ObjectDataSource>
                    <div class="clearfix"></div>
                    <div class="rbm-top-border" ></div>
                </div>
                <div class="clearfix"></div>
                
            </div>
        </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="DashBoardContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="LeftSideBar" runat="server">
    <div class="portlet ui-widget ui-widget-content ui-helper-clearfix ui-corner-all">
        <div class="portlet-header ui-widget-header">
            Ward Statistics</div>
        <div class="portlet-content">

        </div>
    </div>
</asp:Content>
