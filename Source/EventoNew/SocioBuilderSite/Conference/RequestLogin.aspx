<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master" AutoEventWireup="true" CodeBehind="RequestLogin.aspx.cs" Inherits="SocioBuilderSite.Conference.RequestLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1><asp:Literal ID="Literal1" runat="server" Text='<%$Resources:ConferenceFront, RequestLogin_Title %>' ></asp:Literal></h1>
 <div class="loginform" >
<span style="font-size:14px;color:#CC0000;">
    <span style="color:#0A3EB1;">
    <asp:Literal ID="Literal2" runat="server" Text='<%$Resources:ConferenceFront, RequestLogin_Content %>' ></asp:Literal>
    <%--In order to register online or submit an abstract for <strong>The Conference</strong>, you must be <strong>logged in</strong>.</span><br /><br />Please <strong>login</strong> with your email address and password using the form on the left.<br />If you cannot remember your password you can retrieve it using the <strong><a runat="server" id="A1" href="ForgetPassword.aspx">forgot password</a></strong> form.<br />If you don't have an account yet kindly use the <strong><a runat="server" id="SignupFormLink" href="RegisterSignup.aspx">Sign up</a></strong> form.--%>
</span>
</div>

</asp:Content>
