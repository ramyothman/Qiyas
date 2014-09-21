<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master" AutoEventWireup="true" CodeBehind="ForgetPassword.aspx.cs" Inherits="SocioBuilderSite.Conference.ForgetPassword" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1><asp:Literal ID="Literal1" runat="server" Text='<%$Resources:ConferenceFront, ForgetPassword_Title %>' ></asp:Literal></h1>
 <div class="loginform" >
    <div class="frmHead"><asp:Literal ID="Literal2" runat="server" Text='<%$Resources:ConferenceFront, ForgetPassword_Email %>' ></asp:Literal></div>
                         <dx:ASPxTextBox ID="EmailText" CssClass="blueInpReg" 
                            EnableDefaultAppearance="false" EnableTheming="false" runat="server" 
                            Height="45px" Width="647px" Font-Size="26px">
                             <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                 ErrorDisplayMode="Text" ErrorTextPosition="Bottom">
                                 <ErrorFrameStyle Font-Size="16px" ForeColor="Red">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText='<%$Resources:ConferenceFront, ForgetPassword_EmailValidation %>' IsRequired="True" />
                             </ValidationSettings>
    </dx:ASPxTextBox>
    <div class="frmHead" style="font-style:italic;color:#023B68;"><asp:Literal ID="Literal3" runat="server" Text='<%$Resources:ConferenceFront, ForgetPassword_EmailHelp %>' ></asp:Literal> </div>
    <table style="text-align:right;width:95%;">
                        <tr><td align="right">
                       
                     <dx:ASPxButton ID="SendPasswordButton" runat="server" Text='<%$Resources:ConferenceFront, ForgetPassword_SendPassword %>' HorizontalAlign="Center"
                    
                     Height="35px" Width="180px" onclick="SendPasswordButton_Click" >
                    
                </dx:ASPxButton>   
                        </td></tr>
                     
                </table>
 </div>
 <div class="notice" runat="server" id="NoticeError" visible="false"></div>
</asp:Content>
