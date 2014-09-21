<%@ Page Title="AICSSN-2010 User Verification" Language="C#" MasterPageFile="~/MasterPages/Conference.Master" AutoEventWireup="true" CodeBehind="Verification.aspx.cs" Inherits="SocioBuilderSite.Conferences.Verification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br class="clear" />
<br />
<h1>Verification</h1>
<br />
  <div class="loginform success" runat="server" visible="false" id="NotificationMessageSuccess">
   <strong>Success</strong><br /><p>Your Account Has Been Activated Successfully. Please Login to start using site features</p>
   </div>
   
   <div class="loginform error" runat="server" visible="false" id="NotificationMessageError">
   <strong>Error</strong><br /><p runat="server" id="ErrorMessage">Error Verifying User, Activation Code is Not Valid</p>
   </div>
   
</asp:Content>
