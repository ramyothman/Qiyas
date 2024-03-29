﻿<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="ManageReviewers.aspx.cs" Inherits="SocioBuilderSite.Administrator.Conference.ManageReviewers" %>

<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

    <div class="g12 widgets">
        <div class="widget widget-header-blue" id="widget_charts">
            <h3 class="handle">
                Manage Reviewers</h3>
            <div class="inner-content">
                <dx:ASPxGridView ID="gridReviewers" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="ReviewersObjectDS" KeyFieldName="AbstractReviewerId">
                    <Columns>
                        <dx:GridViewCommandColumn VisibleIndex="0">
                            <DeleteButton Visible="True">
                            </DeleteButton>
                            <EditButton Visible="True">
                            </EditButton>
                            <NewButton Visible="True">
                            </NewButton>
                            <ClearFilterButton Visible="True">
                            </ClearFilterButton>
                        </dx:GridViewCommandColumn>
                        <dx:GridViewDataTextColumn FieldName="AbstractReviewerId" ReadOnly="True" 
                            Visible="False" VisibleIndex="1">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataComboBoxColumn Caption="Reviewer" FieldName="PersonId" 
                            VisibleIndex="2" Width="300px">
                            <PropertiesComboBox DataSourceID="PersonObjectDS" 
                                IncrementalFilteringMode="Contains" TextField="FullName" 
                                ValueField="BusinessEntityId" ValueType="System.Int32">
                                <Columns>
                                    <dx:ListBoxColumn FieldName="FullName" />
                                    <dx:ListBoxColumn FieldName="UserName" />
                                </Columns>
                                <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                    ErrorDisplayMode="Text">
                                    <RequiredField IsRequired="True" />
                                </ValidationSettings>
                            </PropertiesComboBox>
                        </dx:GridViewDataComboBoxColumn>
                        <dx:GridViewDataCheckColumn FieldName="IsInternal" VisibleIndex="3">
                        </dx:GridViewDataCheckColumn>
                        <dx:GridViewDataDateColumn FieldName="DateCreated" Visible="False" 
                            VisibleIndex="4">
                        </dx:GridViewDataDateColumn>
                        <dx:GridViewDataCheckColumn FieldName="IsActive" VisibleIndex="5">
                        </dx:GridViewDataCheckColumn>
                    </Columns>
                    <SettingsBehavior ConfirmDelete="True" />
                    <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" 
                        PopupEditFormWidth="400px" />
                    <Settings ShowFilterRow="True" />
                    <SettingsText ConfirmDelete="Are you sure you want to delete this reviewer?" />
                </dx:ASPxGridView>
                <asp:ObjectDataSource ID="ReviewersObjectDS" runat="server" 
                    DeleteMethod="Delete" InsertMethod="Insert" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.Conference.AbstractReviewerLogic" 
                    UpdateMethod="Update">
                    <DeleteParameters>
                        <asp:Parameter Name="Original_AbstractReviewerId" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="PersonId" Type="Int32" />
                        <asp:Parameter Name="IsInternal" Type="Boolean" />
                        <asp:Parameter Name="DateCreated" Type="DateTime" />
                        <asp:Parameter Name="IsActive" Type="Boolean" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="PersonId" Type="Int32" />
                        <asp:Parameter Name="IsInternal" Type="Boolean" />
                        <asp:Parameter Name="DateCreated" Type="DateTime" />
                        <asp:Parameter Name="IsActive" Type="Boolean" />
                        <asp:Parameter Name="Original_AbstractReviewerId" Type="Int32" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="PersonObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.Persons.PersonLogic">
                </asp:ObjectDataSource>
            </div>
        </div>
    </div>
</asp:Content>
