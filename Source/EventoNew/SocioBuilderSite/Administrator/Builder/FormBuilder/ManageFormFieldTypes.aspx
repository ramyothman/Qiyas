﻿<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="ManageFormFieldTypes.aspx.cs" Inherits="SocioBuilderSite.Administrator.Builder.FormBuilder.ManageFormFieldTypes" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

     <div class="g12 widgets">
			<div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
				<h3 class="handle">Manage Form Field Types</h3>
				<div class="inner-content">
                <dx:ASPxGridView ID="gridDocumentStatus" runat="server" 
        AutoGenerateColumns="False" DataSourceID="DocumentObjectDS" 
        KeyFieldName="FormFieldTypeId">
        <Columns>
           <dx:GridViewCommandColumn ButtonType="Image" VisibleIndex="0" Width="60px" Caption=" ">
                        <DeleteButton Visible="True">
                            <Image Height="16px" Url="~/images/griddelete.png" Width="16px">
                            </Image>
                        </DeleteButton>
                        <EditButton Visible="True">
                            <Image Height="16px" Url="~/images/editgrid.png" Width="16px">
                            </Image>
                        </EditButton>
                        <NewButton Visible="True">
                            <Image Height="16px" Url="~/images/newgrid.png" Width="16px">
                            </Image>
                        </NewButton>
                        <CancelButton>
                            <Image Height="32px" Url="~/images/cancelsave32.png" Width="32px">
                            </Image>
                        </CancelButton>
                        <UpdateButton>
                            <Image Height="32px" Url="~/images/filesave32.png" Width="32px">
                            </Image>
                        </UpdateButton>
                        <ClearFilterButton Visible="True">
                        </ClearFilterButton>
                    </dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn Caption="Id" FieldName="FormFieldTypeId" 
                VisibleIndex="1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Name" VisibleIndex="2" Width="200px">
                <EditFormSettings ColumnSpan="2" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Template" Visible="False" 
                VisibleIndex="3">
                <EditFormSettings ColumnSpan="2" />
            </dx:GridViewDataTextColumn>
        </Columns>
        <Settings ShowFilterRow="True" />
    </dx:ASPxGridView>
    <asp:ObjectDataSource ID="DocumentObjectDS" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
        TypeName="BusinessLogicLayer.Components.FormBuilder.FormFieldTypeLogic" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_FormFieldTypeId" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="FormFieldTypeId" Type="Int32" />
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Template" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="FormFieldTypeId" Type="Int32" />
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Template" Type="String" />
            <asp:Parameter Name="Original_FormFieldTypeId" Type="Int32" />
        </UpdateParameters>
    </asp:ObjectDataSource>
           
            <br />
        </div>
    </div>
     </div>
</asp:Content>
