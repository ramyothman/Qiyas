﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MainReportViewerControl.ascx.cs" Inherits="SocioBuilderSite.Controls.Reports.MainReportViewerControl" %>
<%@ Register Assembly="DevExpress.XtraReports.v11.1.Web, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dxwc"%>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<table cellpadding="0" cellspacing="0" border="0">
    <tr>
        <td></td>
        <td style="padding-left:6px; padding-right:6px;">
            
            <dxwc:ReportToolbar ID="ReportToolbar1" runat="server" ReportViewer="<%# ReportViewer1 %>" EnableViewState="False" Width="100%">
                <Items>
                    <dxwc:ReportToolbarButton ItemKind='Search' ToolTip='Display the search window' />
                    <dxwc:ReportToolbarSeparator />
                    <dxwc:ReportToolbarButton ItemKind='PrintReport' ToolTip='Print the report' />
                    <dxwc:ReportToolbarButton ItemKind='PrintPage' ToolTip='Print the current page' />
                    <dxwc:ReportToolbarSeparator />
                    <dxwc:ReportToolbarButton Enabled='False' ItemKind='FirstPage' ToolTip='First Page' />
                    <dxwc:ReportToolbarButton Enabled='False' ItemKind='PreviousPage' ToolTip='Previous Page' />
                    <dxwc:ReportToolbarLabel Text='Page' />
                    <dxwc:ReportToolbarComboBox ItemKind='PageNumber' Width='65px'>
                    </dxwc:ReportToolbarComboBox>
                    <dxwc:ReportToolbarLabel Text="of" />
                    <dxwc:ReportToolbarTextBox IsReadOnly='True' ItemKind='PageCount' />
                    <dxwc:ReportToolbarButton ItemKind='NextPage' ToolTip='Next Page' />
                    <dxwc:ReportToolbarButton ItemKind='LastPage' ToolTip='Last Page' />
                    <dxwc:ReportToolbarSeparator />
                    
                </Items>
            </dxwc:ReportToolbar>
        </td>
    </tr>
    <tr><td style="height:8px"></td></tr>
    <tr>
        <td>
            <asp:Panel ID="Panel1" runat="server" EnableTheming="False" Visible="false">
                <table cellspacing="0" cellpadding="0" border="0">
                    <tr>
	                    <td class="PageBorder_tlc" style="width:10px;height:10px;"><div style="width:10px;height:10px;font-size:1px"></div></td>
	                    <td class="PageBorder_t"></td>
	                    <td class="PageBorder_trc" style="width:10px;height:10px;"><div style="width:10px;height:10px;font-size:1px"></div></td>
                    </tr>
                    <tr>
	                    <td class="PageBorder_l"></td>
	                    <td style="background-color:white;">
                            <asp:PlaceHolder ID="DocumentMapPlaceHolder" runat="server"></asp:PlaceHolder>
                        </td>
	                    <td class="PageBorder_r"></td>
                    </tr>
                    <tr>
	                    <td class="PageBorder_blc" style="width:10px;height:10px;"></td>
	                    <td class="PageBorder_b"></td>
	                    <td class="PageBorder_brc" style="width:10px;height:10px;"></td>
                    </tr>
                </table>
            </asp:Panel>
        </td>
        <td style="height: 241px; width: 417px;">
           <table cellspacing="0" cellpadding="0" border="0">
                <tr>
	                <td class="PageBorder_tlc" style="width:10px;height:10px;"><div style="width:10px;height:10px;font-size:1px"></div></td>
	                <td class="PageBorder_t"></td>
	                <td class="PageBorder_trc" style="width:10px;height:10px;"><div style="width:10px;height:10px;font-size:1px"></div></td>
                </tr>
                <tr>
	                <td class="PageBorder_l"></td>
	                <td style="background-color:white;">
	                    <dxwc:ReportViewer id="ReportViewer1" style="width: 100%; height: 100%" runat="server" ClientInstanceName="ReportViewer1" EnableViewState="False">
                        </dxwc:ReportViewer>
                    </td>
	                <td class="PageBorder_r"></td>
                </tr>
                <tr>
	                <td class="PageBorder_blc" style="width:10px;height:10px;"></td>
	                <td class="PageBorder_b"></td>
	                <td class="PageBorder_brc" style="width:10px;height:10px;"></td>
                </tr>
            </table>
        </td>
    </tr>
    <tr><td style="height:8px"></td></tr>
    <tr>
        <td></td>
        <td valign="top" style="padding-left:6px; padding-right:6px;">
            <dxwc:ReportToolbar ID="ReportToolbar2" runat="server" ReportViewer="<%# ReportViewer1 %>" EnableViewState="False" Width="100%">
                <Items>
                    <dxwc:ReportToolbarButton ItemKind="Search" ToolTip="Display the search window" />
                    <dxwc:ReportToolbarSeparator />
                    <dxwc:ReportToolbarButton ItemKind="PrintReport" ToolTip="Print the report" />
                    <dxwc:ReportToolbarButton ItemKind="PrintPage" ToolTip="Print the current page" />
                    <dxwc:ReportToolbarSeparator />
                    <dxwc:ReportToolbarButton Enabled="False" ItemKind="FirstPage" ToolTip="First Page" />
                    <dxwc:ReportToolbarButton Enabled="False" ItemKind="PreviousPage" ToolTip="Previous Page" />
                    <dxwc:ReportToolbarLabel Text="Page" />
                    <dxwc:ReportToolbarComboBox ItemKind="PageNumber" Width="65px">
                    </dxwc:ReportToolbarComboBox>
                    <dxwc:ReportToolbarLabel Text="of" />
                    <dxwc:ReportToolbarTextBox IsReadOnly="True" ItemKind="PageCount" />
                    <dxwc:ReportToolbarButton ItemKind="NextPage" ToolTip="Next Page" />
                    <dxwc:ReportToolbarButton ItemKind="LastPage" ToolTip="Last Page" />
                    <dxwc:ReportToolbarSeparator />
                    
                </Items>
            </dxwc:ReportToolbar>
        </td>
    </tr>
</table>
