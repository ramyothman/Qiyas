<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SocioBuilderSite.Conference.Login" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>Sign up</h1>
     
 <div class="loginform">
    <div class="frmHead">Email</div>
                         <dx:ASPxTextBox ID="EmailText" CssClass="blueInpReg" 
                            EnableDefaultAppearance="false" EnableTheming="false" runat="server" 
                            Height="45px" Width="647px" Font-Size="26px">
                             <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                 ErrorDisplayMode="Text" ErrorTextPosition="Bottom">
                                 <ErrorFrameStyle Font-Size="16px" ForeColor="Red">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText="Please Enter Email" IsRequired="True" />
                             </ValidationSettings>
    </dx:ASPxTextBox>
    <div class="frmHead">The email will act as the username too. an email will be send for verification</div>
    <div class="frmHead">Password</div>
     <dx:ASPxTextBox ID="PasswordText" CssClass="blueInpReg" Password="true"
                            EnableDefaultAppearance="false" EnableTheming="false" runat="server" 
                            Height="45px" Width="647px" Font-Size="26px">
                             <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                 ErrorDisplayMode="Text" ErrorTextPosition="Bottom">
                                 <ErrorFrameStyle Font-Size="16px" ForeColor="Red">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText="Please Enter Password" IsRequired="True" />
                             </ValidationSettings>
    </dx:ASPxTextBox>
    <div class="frmHead">Confirm Password</div>
     <dx:ASPxTextBox ID="ASPxTextBox1" CssClass="blueInpReg" Password="true"
                            EnableDefaultAppearance="false" EnableTheming="false" runat="server" 
                            Height="45px" Width="647px" Font-Size="26px">
                             <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                 ErrorDisplayMode="Text" ErrorTextPosition="Bottom">
                                 <ErrorFrameStyle Font-Size="16px" ForeColor="Red">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText="Please Confirm Password" IsRequired="True" />
                             </ValidationSettings>
    </dx:ASPxTextBox>
    <div class="frmHead">Name</div>
     <dx:ASPxTextBox ID="ASPxTextBox2" CssClass="blueInpReg" 
                            EnableDefaultAppearance="false" EnableTheming="false" runat="server" 
                            Height="45px" Width="647px" Font-Size="26px">
                             <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                 ErrorDisplayMode="Text" ErrorTextPosition="Bottom">
                                 <ErrorFrameStyle Font-Size="16px" ForeColor="Red">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText="Please Enter Your Full Name" IsRequired="True" />
                             </ValidationSettings>
    </dx:ASPxTextBox>
    <div class="frmHead">Mobile</div>
     <dx:ASPxTextBox ID="MobileText" CssClass="blueInp" 
                            EnableDefaultAppearance="false" EnableTheming="false" runat="server" 
                            Height="45px" Width="245px" Font-Size="20px">
                             <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                 ErrorDisplayMode="Text" ErrorTextPosition="Bottom">
                                 <ErrorFrameStyle Font-Size="16px" ForeColor="Red">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText="Please Enter Your Mobile Number" IsRequired="True" />
                             </ValidationSettings>
    </dx:ASPxTextBox>
 </div>

</asp:Content>
