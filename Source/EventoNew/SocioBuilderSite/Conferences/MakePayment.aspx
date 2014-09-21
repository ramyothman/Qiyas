<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Conference.Master" AutoEventWireup="true" CodeBehind="MakePayment.aspx.cs" Inherits="SocioBuilderSite.Conferences.MakePayment" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br class="clear" />
<br />
<%--<h1>Make Registration Payment</h1>--%>
<h1>Registration Completed</h1>
<br />
<div class="notice">
Thank you for registering with us.
</div>
<div class="loginform">
<div class="notice">Please place a payment with <span runat="server" id="AmountPayment" style="font-weight:bold;">600 SR</span><br />
</div>

<h3>
In Favor of Saudi Society of Nephrology
</h3>
<h3>
SAMBA A/C no:268 078 6564, Olaya Branch, Riyadh, KSA
IBAN: SA234000000000 - 2680786564
</h3>
<h4>
Please mention the name of your sponsor in case you have one also please reference the below reference code:
</h4>
<h3 runat="server" id="ReferenceCode">

</h3>

   
    <br />
   
    </div>
    
    

    <input type="hidden" name="pay_to_email" value="<%=System.Web.Configuration.WebConfigurationManager.AppSettings["moneybookersAccount"] %>" />
    <input type="hidden" name="recipient_description" value="<%=System.Web.Configuration.WebConfigurationManager.AppSettings["PayForName"] %>" />
    <input type="hidden" name="transaction_id" value="<%=SelectedInvoice.InvoiceId.ToString()%>" />
    <input type="hidden" name="return_url" value="<%=System.Web.Configuration.WebConfigurationManager.AppSettings["websiteUrl"] %>" />
    <input type="hidden" name="return_url_text" value="Back to SSN Conference" />
    <input type="hidden" name="cancel_url" value="<%=System.Web.Configuration.WebConfigurationManager.AppSettings["websiteUrl"] %>/PaymentCancelled.aspx" />
    <input type="hidden" name="status_url" value="<%=System.Web.Configuration.WebConfigurationManager.AppSettings["websiteUrl"] %>/ThankYou.aspx" />
    <input type="hidden" name="pay_from_email" value="<%= SelectedInvoice.ContactEmail.ToString()%>" />
    <input type="hidden" name="title" value="<%= SelectedInvoice.ContactTitle.ToString()%>" />
    <input type="hidden" name="firstname" value="<%= SelectedInvoice.ContactFirstName.ToString()%>" />
    <input type="hidden" name="lastname" value="<%= SelectedInvoice.ContactLastName.ToString()%>" />
    <input type="hidden" name="address" value="<%= SelectedInvoice.ContactAddress1.ToString()%>" />
    <input type="hidden" name="phone_number" value="<%= SelectedInvoice.ContactPhone.ToString()%>" />
    <input type="hidden" name="postal_code" value="<%= SelectedInvoice.ContactZip.ToString()%>" />
    <input type="hidden" name="city" value="<%= SelectedInvoice.ContactCity.ToString()%>" />
    <input type="hidden" name="country" value="<%= SelectedInvoice.ContactCountry.ToString()%>" />
    <input type="hidden" name="amount" value="<%= SelectedInvoice.Total.ToString()%>" />
    <input type="hidden" name="currency" value="<%=SelectedInvoice.Currency %>" />
    
    
    <%=SelectedInvoice.MoneyBookersItemList%>

<%--
    <input type="hidden" name="cmd" value="_cart" />
			<input type="hidden" name="upload" value="1" />
			
			<!-- The following is for aggregated PayPal data instead of itemized -->
			<!--
			<input type="hidden" name="item_name" value="Aggregated Items" />
			<input type="hidden" name="amount" value="<%=SelectedInvoice.Total.ToString("#.00") %>" />
			-->
			
			<!-- The following is for itemized PayPal data instead of the aggregated version -->
			<%=SelectedInvoice.PaypalItemList%>
			<input type="hidden" name="tax_cart" value="<%=SelectedInvoice.Taxes.ToString("#.00")%>" />
			
			<!-- STANDARD DATA -->
			<input type="hidden" name="business" value="<%=System.Web.Configuration.WebConfigurationManager.AppSettings["paypalAccount"] %>" />
									
			<input type="hidden" name="invoice" value="<%=SelectedInvoice.InvoiceId.ToString()%>" />
			<input type="hidden" name="no_note" value="0" /> 
			<input type="hidden" name="currency_code" value="<%=SelectedInvoice.Currency %>" />
			<input type="hidden" name="lc" value="<%=SelectedInvoice.ShipToCountry %>" /> 
			<input type="hidden" name="return" value="<%=System.Web.Configuration.WebConfigurationManager.AppSettings["websiteUrl"] %>/ThankYou.aspx" />
			<input type="hidden" name="cancel_return" value="<%=System.Web.Configuration.WebConfigurationManager.AppSettings["websiteUrl"] %>" />
			<input type="hidden" name="email" value="<%=System.Web.Configuration.WebConfigurationManager.AppSettings["paypalAccount"] %>" /> 
			<input type="hidden" name="cn" value="How did you hear about us?" />--%>
</asp:Content>
