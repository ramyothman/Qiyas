<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="ManageUsers.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.RoleSecurity.ManageUsers" %>

<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
 <div class="g12 widgets">
			<div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
				<h3 class="handle">Manage Users</h3>
				<div class="inner-content">		
                <a href="UserDetails.aspx">New User</a>	<br /><br />
            <dx:ASPxGridView ID="manageUsersGrid" runat="server" 
    AutoGenerateColumns="False" DataSourceID="ManageUsersObjectDS" 
    KeyFieldName="BusinessEntityId" 
                    oncustombuttoncallback="manageUsersGrid_CustomButtonCallback">
                <ClientSideEvents CustomButtonClick="function(s, e) {
	window.location.href ='UserDetails.aspx?User=' + s.GetRowKey(s.GetFocusedRowIndex());
}" />
        <Columns>
            <dx:GridViewCommandColumn VisibleIndex="0" ButtonType="Image">
                <DeleteButton Visible="True">
                    <Image AlternateText="Delete" Url="~/images/griddelete.png">
                    </Image>
                </DeleteButton>
                <ClearFilterButton Visible="True">
                </ClearFilterButton>
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton Text="Update" ID="btnUpdate">
                        
                        <Image AlternateText="Update" Url="~/images/editgrid.png">
                        </Image>
                        
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
            </dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn Caption="Id" FieldName="BusinessEntityId" 
                ReadOnly="True" VisibleIndex="1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="UserName" VisibleIndex="2" Width="150px">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="DisplayName" VisibleIndex="3" 
                Width="200px">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataComboBoxColumn FieldName="NameStyle" VisibleIndex="4">
                <PropertiesComboBox EnableFocusedStyle="False" ValueType="System.String">
                    <Items>
                        <dx:ListEditItem Selected="True" Text="First Name, Last Name" Value="False" />
                        <dx:ListEditItem Text="Last Name, First Name" Value="True" />
                    </Items>
                </PropertiesComboBox>
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataComboBoxColumn Caption="Nationality" 
                FieldName="NationalityCode" VisibleIndex="5">
                <PropertiesComboBox DataSourceID="CountryObjectDS" DropDownStyle="DropDown" 
                    TextField="Name" ValueField="CountryRegionCode" ValueType="System.String">
                </PropertiesComboBox>
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataTextColumn Caption="Promotion" FieldName="EmailPromotion" 
                VisibleIndex="6">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn FieldName="ModifiedDate" VisibleIndex="7">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataDateColumn FieldName="CreatedDate" VisibleIndex="8">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn FieldName="Title" Visible="False" VisibleIndex="8">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="FirstName" Visible="False" 
                VisibleIndex="8">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="MiddleName" Visible="False" 
                VisibleIndex="8">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="LastName" Visible="False" 
                VisibleIndex="8">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Suffix" Visible="False" VisibleIndex="8">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="FullName" Visible="False" 
                VisibleIndex="10">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="RowGuid" Visible="False" 
                VisibleIndex="14">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
        </Columns>
                <SettingsBehavior AllowFocusedRow="True" ConfirmDelete="True" 
                    EnableRowHotTrack="True" />
        <Settings ShowFilterRow="True" />
                <SettingsText ConfirmDelete="Are you sure you want to delete this record?" />
    </dx:ASPxGridView>
                
            </div>
        </div>

    

<asp:ObjectDataSource ID="ManageUsersObjectDS" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
    TypeName="BusinessLogicLayer.Components.Persons.PersonLogic" 
        DeleteMethod="Delete">
    <DeleteParameters>
        <asp:Parameter Name="Original_BusinessEntityId" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
    <asp:ObjectDataSource ID="CountryObjectDS" runat="server" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
        TypeName="BusinessLogicLayer.Components.Persons.CountryRegionLogic">
    </asp:ObjectDataSource>
    <br />
    </div>
</asp:Content>

