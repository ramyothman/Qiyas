<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProfileInformation.ascx.cs" Inherits="SocioBuilderSite.Conference.Controls.ProfileInformation" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxUploadControl" TagPrefix="dx" %>
<%--<%@ Register Src="~/Controls/Conference/ContactInfo.ascx" TagName="ContactInfoControl" TagPrefix="Rbm" %>--%>
<%@ Register Src="~/Conference/Controls/ContactInfo.ascx" TagName="ContactInfoControl" TagPrefix="Rbm" %>
<asp:MultiView ID="ProfileMultiView" runat="server" ActiveViewIndex="0">
<asp:View runat="server" ID="ViewProfile">
<div id="abstract-accepted">
                  <div class="profile">
                  <div class="profile-img">
                      <dx:ASPxImage ID="currentProfileImage" ImageUrl="~/Conferences/images/ProfileImage.jpg" ClientInstanceName="currentProfileImage" Width="100" Height="115" runat="server">
                      </dx:ASPxImage>
                      <br />
                      <asp:LinkButton ID="currentLinkEdit" runat="server" 
                          onclick="currentLinkEdit_Click">Edit Profile</asp:LinkButton>
                      
                  </div>
        <div class="profile-data-small">
        <h1 runat="server" id="ContactName"><dx:ASPxLabel runat="server" ID="ContactNameLabel" Text="Full Name" EnableDefaultAppearance="false" ForeColor="#FF5400" Font-Size="24px" Font-Names="'Droid Sans',arial,serif"></dx:ASPxLabel> </h1>
        <h2 runat="server" id="ContactEmail"><dx:ASPxLabel runat="server" ID="ContactEmailLabel" Text="email@email.com" EnableDefaultAppearance="false" ForeColor="#023C68" Font-Size="18px" Font-Names="'Droid Sans',arial,serif"></dx:ASPxLabel></h2>
        <p class="profiletxt"><asp:Literal ID="Literal1" runat="server" Text='<%$Resources:ConferenceFront, ProfileInformation_Gender %>' ></asp:Literal>: <span runat="server" id="ContactGender"></span><dx:ASPxLabel runat="server" ID="ContactGenderLabel" Text="email@email.com" EnableDefaultAppearance="false" ForeColor="#122442" Font-Size="12px" Font-Names="'Droid Sans',arial,serif"></dx:ASPxLabel></p>
        <p class="profiletxt"><asp:Literal ID="Literal2" runat="server" Text='<%$Resources:ConferenceFront, ProfileInformation_DateofBirth %>' ></asp:Literal>: <span runat="server" id="ContactDateofBirth"></span><dx:ASPxLabel runat="server" ID="ContactDateofBirthLabel" Text="" EnableDefaultAppearance="false" ForeColor="#122442" Font-Size="12px" Font-Names="'Droid Sans',arial,serif"></dx:ASPxLabel></p>
        <p class="profiletxt"><asp:Literal ID="Literal3" runat="server" Text='<%$Resources:ConferenceFront, ProfileInformation_Address %>' ></asp:Literal>: <span runat="server" id="ContactAddress"></span><dx:ASPxLabel runat="server" ID="ContactAddressLabel" Text="" EnableDefaultAppearance="false" ForeColor="#122442" Font-Size="12px" Font-Names="'Droid Sans',arial,serif"></dx:ASPxLabel></p>
        <p class="profiletxt"><asp:Literal ID="Literal4" runat="server" Text='<%$Resources:ConferenceFront, ProfileInformation_POBox %>' ></asp:Literal>: <span runat="server" id="ContactPOBox"></span><dx:ASPxLabel runat="server" ID="ContactPOBoxLabel" Text="" EnableDefaultAppearance="false" ForeColor="#122442" Font-Size="12px" Font-Names="'Droid Sans',arial,serif"></dx:ASPxLabel></p>
        <p class="profiletxt"><asp:Literal ID="Literal5" runat="server" Text='<%$Resources:ConferenceFront, ProfileInformation_ZipCode %>' ></asp:Literal>: <span runat="server" id="ContactZipCode"></span><dx:ASPxLabel runat="server" ID="ContactZipCodeLabel" Text="" EnableDefaultAppearance="false" ForeColor="#122442" Font-Size="12px" Font-Names="'Droid Sans',arial,serif"></dx:ASPxLabel></p>
        <p class="profiletxt"><asp:Literal ID="Literal6" runat="server" Text='<%$Resources:ConferenceFront, ProfileInformation_City %>'></asp:Literal>: <span runat="server" id="ContactCity"></span><dx:ASPxLabel runat="server" ID="ContactCityLabel" Text="" EnableDefaultAppearance="false" ForeColor="#122442" Font-Size="12px" Font-Names="'Droid Sans',arial,serif"></dx:ASPxLabel></p>
        <p class="profiletxt"><asp:Literal ID="Literal7" runat="server" Text='<%$Resources:ConferenceFront, ProfileInformation_Country %>'></asp:Literal>: <span runat="server" id="ContactCountry"></span><dx:ASPxLabel runat="server" ID="ContactCountryLabel" Text="" EnableDefaultAppearance="false" ForeColor="#122442" Font-Size="12px" Font-Names="'Droid Sans',arial,serif"></dx:ASPxLabel></p>
        <p class="profiletxt"><asp:Literal ID="Literal8" runat="server" Text='<%$Resources:ConferenceFront, ProfileInformation_PhoneNumber %>'></asp:Literal>: <span runat="server" id="ContactPhoneNumber"></span><dx:ASPxLabel runat="server" ID="ContactPhoneNumberLabel" Text="" EnableDefaultAppearance="false" ForeColor="#122442" Font-Size="12px" Font-Names="'Droid Sans',arial,serif"></dx:ASPxLabel></p>
        <p class="profiletxt"><asp:Literal ID="Literal9" runat="server" Text='<%$Resources:ConferenceFront, ProfileInformation_FaxNumber %>'></asp:Literal>: <span runat="server" id="ContactFaxNumber"></span><dx:ASPxLabel runat="server" ID="ContactFaxNumberLabel" Text="" EnableDefaultAppearance="false" ForeColor="#122442" Font-Size="12px" Font-Names="'Droid Sans',arial,serif"></dx:ASPxLabel></p>
        <p class="profiletxt"><asp:Literal ID="Literal10" runat="server" Text='<%$Resources:ConferenceFront, ProfileInformation_MobileNumber %>'></asp:Literal>: <span runat="server" id="ContactMobileNumber"></span><dx:ASPxLabel runat="server" ID="ContactMobileNumberLabel" Text="" EnableDefaultAppearance="false" ForeColor="#122442" Font-Size="12px" Font-Names="'Droid Sans',arial,serif"></dx:ASPxLabel></p>
        </div>
        <div class="clear"></div>
    </div>
</div>
</asp:View>
<asp:View runat="server" ID="ViewEdit">
<div style="width:100%;">
<%--<h1><asp:Literal ID="Literal11" runat="server" Text='<%$Resources:ConferenceFront, ProfileInformation_EditProfile %>'></asp:Literal></h1><br />--%>
<Rbm:ContactInfoControl runat="server" ID="CIC1" IsInProfile="true" />
</div>
</asp:View>
</asp:MultiView>