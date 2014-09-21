<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginFront.ascx.cs" Inherits="SocioBuilderSite.Conference.Controls.LoginFront" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>

<div runat="server" id="LoginScreen">
<h1><asp:Literal runat="server" Text='<%$Resources:ConferenceFront, LoginFront_LoginH1 %>' /></h1>
         
  <div class="log0">
    <div class="frmHead"><asp:Literal ID="Literal1" runat="server" Text='<%$Resources:ConferenceFront, LoginFront_LoginEmail %>' /></div>
    <dx:ASPxTextBox ID="EmailText" runat="server" Width="200px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" >
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" BorderWidth="2px" />
               <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="LoginGroup" 
                                 ErrorDisplayMode="Text" ErrorTextPosition="Bottom" 
                        EnableCustomValidation="True">
                                 <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000" >
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText="*" IsRequired="True" />
                             </ValidationSettings>
                </dx:ASPxTextBox>
    <div class="frmHead"><asp:Literal ID="Literal2" runat="server" Text='<%$Resources:ConferenceFront, LoginFront_LoginPassword %>' /></div>
    <dx:ASPxTextBox ID="PasswordText" runat="server" Width="200px" Password="true" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="16px">
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" BorderWidth="2px" />
                             <ValidationSettings CausesValidation="True" Display="Dynamic"  ValidationGroup="LoginGroup"
                                 ErrorDisplayMode="Text" ErrorTextPosition="Bottom" 
                                 EnableCustomValidation="True">
                                 <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText="*" IsRequired="True" />
                             </ValidationSettings>
                </dx:ASPxTextBox>
    <div class="forgot"><a href="~/Conference/ForgetPassword.aspx" runat="server" id="ForgetPasswordLink"><asp:Literal ID="Literal3" runat="server" Text='<%$Resources:ConferenceFront, LoginFront_LoginForgotPassword %>' /></a></div>
    <div class="forgot"><a href="~/Conference/RegisterSignup.aspx" runat="server" id="signupLink"><asp:Literal ID="Literal4" runat="server" Text='<%$Resources:ConferenceFront, LoginFront_LoginSignup %>' /></a><br /></div>
    <div class="error" runat="server" id="ErrorMessage" visible="false"></div>
    <div class="subBtn">
        <table style="width:90%;">
            <tr>
                <td align="right">
                <dx:ASPxButton ID="ASPxButton1" runat="server" Text='<%$Resources:ConferenceFront, LoginFront_LoginButton %>' ValidationGroup="LoginGroup" 
            onclick="ASPxButton1_Click">
        </dx:ASPxButton>
                </td>
            </tr>
        </table>
        
     
    </div>
  </div>

</div>
              <div runat="server" id="LoggedInScreen" visible="false">
              <h1 runat="server" id="UserNameLabel"></h1>
                <div class="log0">
   			      <div id="userboard">
   			          <div class="text">
                      
   			            <%--<h4><a href="~/Conferences/Profile.aspx" runat="server" id="EditProfileLink">Edit Profile</a></h4>--%>
                        <h4><a href="~/Conference/ChangePassword.aspx" runat="server" id="ChangePasswordLink" ><asp:Literal runat="server" Text='<%$Resources:ConferenceFront, ChangePassword_PageTitle %>'></asp:Literal> </a></h4>
   			            <h4><asp:LinkButton runat="server" ID="LogoutButton" Text='<%$Resources:ConferenceFront, LoginFront_Logout %>' 
                                onclick="LogoutButton_Click"></asp:LinkButton></h4>
		              </div>
		            </div>
                    </div>
   			  </div>


