<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdministrationMaster.Master" AutoEventWireup="true" CodeBehind="BedDetailDisplay.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.BedManagement.BedDetailDisplay" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxDataView" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>


<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MessagePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainPlaceHolder" runat="server">

<div class="title title-spacing">
        <h2>
            <span runat="server" id="titleProfileHolder"></span> Patient Information (Ward A11 - Room 1 - Bed 2)
        </h2>
        Patient and admission information
    </div>
    <div class="rbmcenterform">
        <table>
            <tr >
                <td>
                    <table>
                        <tr>
                        <td class="rbmcenterform-tr-td">
                     <label class="rbmcenter-label">Title</label>   
                     </td>
                        </tr>
                        <tr>
                        <td class="rbmcenterform-tr-td"><dx:ASPxComboBox ID="upTitle" runat="server" 
                              >
                    </dx:ASPxComboBox>

                            </td>
                        </tr>
                    </table>
                     
                    
                </td>
            </tr>
            <tr>
                <td>
                    <table>
                        <tr>
                            <td class="rbmcenterform-tr-td">
                                <label class="rbmcenter-label">
                                    First Name</label>
                            </td>
                            <td class="rbmcenterform-tr-td">
                                <label class="rbmcenter-label">
                                    Middle Name</label>
                            </td>
                            <td class="rbmcenterform-tr-td">
                                <label class="rbmcenter-label">
                                    Last Name</label>
                            </td>
                        </tr>
                        <tr>
                            <td class="rbmcenterform-tr-td">
                                <dx:ASPxTextBox ID="upFirstName" runat="server" Width="170px">
                                </dx:ASPxTextBox>
                            </td>
                            <td class="rbmcenterform-tr-td">
                                <dx:ASPxTextBox ID="upMiddleName" runat="server" Width="170px">
                                </dx:ASPxTextBox>
                            </td>
                            <td class="rbmcenterform-tr-td">
                                <dx:ASPxTextBox ID="upLastName" runat="server" Width="170px">
                                </dx:ASPxTextBox>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    
                </td>
            </tr>
            
        </table>
<div class="portlet ui-widget ui-widget-content ui-helper-clearfix ui-corner-all form-container">
                        <div class="portlet-header ui-widget-header">Admission Information</div>
                        <div class="portlet-content">
                            <table>
                                <tr>
                                    <td class="rbmcenter-label">Start Date</td>
                                    <td class="rbmcenterform-tr-td">
                                        <dx:ASPxComboBox ID="eiOrganization" ClientInstanceName="eiOrganization" runat="server" 
                                           
                                            
                                           >
                                            <ClientSideEvents SelectedIndexChanged="function(s, e) {
	eiDepartment.PerformCallback(s.GetValue());
	eiDivision.ClearItems();
	eiManager.PerformCallback(s.GetValue() + ',0');
}" />
                                        </dx:ASPxComboBox>
                                      
                                    </td>
                                    <td class="rbmcenter-label rbmcenterform-tr-td">Expected End Date</td>
                                    <td class="rbmcenterform-tr-td">
                                        <dx:ASPxComboBox ID="eiDepartment" runat="server" 
                                            DropDownStyle="DropDown" 
                                             ValueField="DepartmentId" 
                                             
                                             IncrementalFilteringMode="StartsWith">
                                            <ClientSideEvents SelectedIndexChanged="function(s, e) {
	eiDivision.PerformCallback(s.GetValue());
	eiManager.PerformCallback(eiOrganization.GetValue() + ',' + s.GetValue());
}" />
                                        </dx:ASPxComboBox>
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="rbmcenter-label">Marital Status</td>
                                    <td class="rbmcenterform-tr-td">
                                        <dx:ASPxComboBox ID="eiMaritalStatus" runat="server" 
                                            
                                             ValueType="System.String">
                                        </dx:ASPxComboBox>
                                        
                                    </td>
                                    <td class="rbmcenter-label rbmcenterform-tr-td">Gender</td>
                                    <td class="rbmcenterform-tr-td">
                                        <dx:ASPxComboBox ID="eiGender" runat="server" 
                                            TextField="LookupValueDescription" ValueField="LookupValue" 
                                            ValueType="System.String">
                                        </dx:ASPxComboBox>
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="rbmcenter-label">National Id Type</td>
                                    <td class="rbmcenterform-tr-td">
                                        <dx:ASPxComboBox ID="eiNationalIdType" runat="server" 
                                           
                                           ValueType="System.String">
                                        </dx:ASPxComboBox>
                                       
                                    </td>
                                    <td class="rbmcenter-label rbmcenterform-tr-td">National Id</td>
                                    <td class="rbmcenterform-tr-td">
                                        <dx:ASPxTextBox ID="eiNationalId" runat="server" Width="170px">
                                        </dx:ASPxTextBox>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="DashBoardContentPlaceHolder" runat="server">
<div class="two-column">
    <div class="column">
        <div class="portlet ui-widget ui-widget-content ui-helper-clearfix ui-corner-all form-container">
            <div class="portlet-header ui-widget-header">
                Expected Admission Days/Hours</div>
            <div class="portlet-content">
                <div>
                    <dx:ASPxRadioButtonList ID="ASPxRadioButtonList1" runat="server">
                    <Items>
                        <dx:ListEditItem Text="Less than 48 hours" Value="0" />
                        <dx:ListEditItem Text="48 Hours" Value="1" />
                        <dx:ListEditItem Text="72 Hours" Value="2" />
                        <dx:ListEditItem Text="1 Week" Value="3" />
                        <dx:ListEditItem Text="10 Days" Value="4" />
                        <dx:ListEditItem Text="Non Expected Admission Time" Value="5" />
                    </Items>
                    </dx:ASPxRadioButtonList>
                    <div class="clearfix"></div>
                    <div class="rbm-top-border" ></div>
                </div>
                <div class="clearfix"></div><br />
                <table>
                    <tr>
                        <td>
                            Changed from Less than 48 hours to 72 hours
                        </td>
                        <td>
                            10/5/2010
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Changed from 72 hours hours to 96 hours
                        </td>
                        <td>
                            10/5/2010
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <div class="column">
        <div class="portlet ui-widget ui-widget-content ui-helper-clearfix ui-corner-all form-container">
            <div class="portlet-header ui-widget-header">
                Discharge Information</div>
            <div class="portlet-content">
                
                <div>
                    <dx:ASPxRadioButtonList ID="ASPxRadioButtonList2" runat="server">
                    <Items>
                        <dx:ListEditItem Text="Discharged to home for self-care" Value="0" />
                        <dx:ListEditItem Text="Discharged home with PCC appointment" Value="1" />
                        <dx:ListEditItem Text="Discharged to hom with planning admission" Value="2" />
                        <dx:ListEditItem Text="Discharged to home for nursing care" Value="3" />
                        <dx:ListEditItem Text="Discharged to other medical specialist inside hospital" Value="4" />
                        <dx:ListEditItem Text="Discharged to other medical specialist outside hospital" Value="5" />
                        <dx:ListEditItem Text="DAMA" Value="6" />
                        <dx:ListEditItem Text="Expired" Value="7" />
                    </Items>
                    </dx:ASPxRadioButtonList>
                    <div class="clearfix"></div>
                    <div class="rbm-top-border"></div>
                    
                </div>
                <div class="clearfix">
                </div>
            </div>
        </div>
    </div>
</div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="LeftSideBar" runat="server">
<div class="portlet ui-widget ui-widget-content ui-helper-clearfix ui-corner-all">
        <div class="portlet-header ui-widget-header">
            Save Information</div>
        <div class="portlet-content">
        <div class="rbmleft-menu-text">
            User Name: <span class="rbmleft-menu-value">rmothman</span><br /><br /><span><a href="javascript:void(0);" onclick="pcChangePassword.Show();">Change Password</a></span>
         </div>
         <div class="rbmleft-menu-text">
            Is Active: <span class="rbmleft-menu-value">Yes</span>
         </div>
         <div class="rbmleft-menu-text">
            Is Activated: <span class="rbmleft-menu-value">Yes</span> <span><a href="">Activate</a></span>
         </div>
        <div class="rbmleft-menu-text">
            User Type: <span class="rbmleft-menu-value">Technical Staff</span> <span><a href="">Edit</a></span>
         </div>
          <div class="rbmleft-menu-text">
            Last Modified: <span class="rbmleft-menu-value">10 April 2010</span>
         </div>
                <dx:ASPxButton ID="btnSave" runat="server" Text="Save">
                </dx:ASPxButton>
        </div>
    </div>
</asp:Content>
