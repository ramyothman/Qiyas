<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master" AutoEventWireup="true" CodeBehind="FinishRegistration.aspx.cs" Inherits="SocioBuilderSite.Conference.FinishRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1><asp:Literal ID="Literal16" runat="server" Text='<%$Resources:ConferenceFront, FinishRegistration_Title %>' ></asp:Literal></h1>
<br />
<div class="notice">
<h2><asp:Literal ID="LiteralPrice" runat="server"  ></asp:Literal> <asp:Literal ID="Literal3" runat="server" Text='<%$Resources:ConferenceFront, FinishRegistration_Currency %>' ></asp:Literal><br /><br /></h2>
<%--<asp:Literal ID="Literal1" runat="server" Text='<%$Resources:ConferenceFront, FinishRegistration_Content %>' ></asp:Literal>--%>
<asp:Literal ID="FinishText" runat="server" ></asp:Literal>
</div>

</asp:Content>
