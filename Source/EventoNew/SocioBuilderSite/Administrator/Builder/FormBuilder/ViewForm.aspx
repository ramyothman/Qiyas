<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="ViewForm.aspx.cs" Inherits="SocioBuilderSite.Administrator.Builder.FormBuilder.ViewForm" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView.Export" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

    <div class="g12 widgets">
        <div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
            <h3 class="handle">View Form - <span runat="server" id="FormTitle"></span>
               
                <span style="float:right;margin-right:5px;margin-left:5px;">
                    <dx:ASPxButton ID="btnDownloadList" runat="server" Text="Download List" 
                        onclick="btnDownloadList_Click" >
                    </dx:ASPxButton>
                </span>
               
            </h3>
            <div class="inner-content">
                <dx:ASPxGridView ID="FormViewerGrid" runat="server"></dx:ASPxGridView>
                <br />
            </div>
        </div>
    </div>
    <dx:ASPxGridViewExporter ID="ASPxGridViewExporter1" runat="server"></dx:ASPxGridViewExporter>
</asp:Content>
