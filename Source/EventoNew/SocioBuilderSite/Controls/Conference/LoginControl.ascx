<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginControl.ascx.cs" Inherits="SocioBuilderSite.Controls.Conference.LoginControl" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<div runat="server" id="LoginScreen">
<h2>Login</h2>
            <br />
            <div class="rightside-top">&nbsp;</div>
            <div class="ads1">
                    <div class="loginform">
  <div>
    <div class="frmHead">Email Address</div>
    <dx:ASPxTextBox ID="EmailText" runat="server" Width="200px" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="15px" >
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" BorderWidth="2px" />
               <ValidationSettings CausesValidation="True" Display="Dynamic" ValidationGroup="LoginGroup" 
                                 ErrorDisplayMode="Text" ErrorTextPosition="Bottom" 
                        EnableCustomValidation="True">
                                 <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000" >
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText="Please Enter Email" IsRequired="True" />
                             </ValidationSettings>
                </dx:ASPxTextBox>
    <div class="frmHead">Password</div>
    <dx:ASPxTextBox ID="PasswordText" runat="server" Width="200px" Password="true" 
                    Font-Names="Trebuchet MS,Trebuchet,Verdana,Helvetica,Arial,Sans-Serif" 
                    Font-Size="16px">
                    <Border BorderColor="#0D98ED" BorderStyle="Solid" BorderWidth="2px" />
                             <ValidationSettings CausesValidation="True" Display="Dynamic"  ValidationGroup="LoginGroup"
                                 ErrorDisplayMode="Text" ErrorTextPosition="Bottom" 
                                 EnableCustomValidation="True">
                                 <ErrorFrameStyle Font-Size="12px" ForeColor="#CC0000">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText="Please Enter Password" IsRequired="True" />
                             </ValidationSettings>
                </dx:ASPxTextBox>
    <div class="forgot"><a href="~/Conferences/ForgetPassword.aspx" runat="server" id="ForgetPasswordLink">Forgot Password?</a></div>
    <div class="forgot"><a href="~/Conferences/RegisterSignup.aspx" runat="server" id="signupLink">Signup for a new account?</a><br /></div>
    <div class="error" runat="server" id="ErrorMessage" visible="false"></div>
    <div class="subBtn">
        <table style="width:90%;">
            <tr>
                <td align="right">
                <dx:ASPxButton ID="ASPxButton1" runat="server" Text="LOGIN" ValidationGroup="LoginGroup" 
            onclick="ASPxButton1_Click">
        </dx:ASPxButton>
                </td>
            </tr>
        </table>
        
     
    </div>
  </div>
</div>
                    </div>
              <div class="rightside-down">&nbsp;</div>
              <br />
</div>


              <div runat="server" id="LoggedInScreen" visible="false">
              <h2 runat="server" id="UserNameLabel"></h2>
   			      <br />
   			      <div class="rightside-top">&nbsp;</div>
   			      <div class="rightside-back">
   			        <div id="userboard">
   			          <div class="text">
   			            <h4><a href="~/Conferences/Profile.aspx" runat="server" id="EditProfileLink">Edit Profile</a></h4>
                        <h4><a href="~/Conferences/ChangePassword.aspx" runat="server" id="ChangePasswordLink" >Change Password</a></h4>
   			            <h4><asp:LinkButton runat="server" ID="LogoutButton" Text="Logout" 
                                onclick="LogoutButton_Click"></asp:LinkButton></h4>
		              </div>
		            </div>
		          </div>
   			      <div class="rightside-down">&nbsp;</div>
   			      <br />

              </div>


