﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Conference.Master" AutoEventWireup="true" CodeBehind="SubmitAbstract.aspx.cs" Inherits="SocioBuilderSite.Conferences.SubmitAbstract" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Scripts/JSON.js" type="text/javascript"></script>
		<script type="text/javascript">
		    function PatchJQuery() {

		        if (!window.jQuery || !window.jQuery.clean)
		            return;

		        var original = window.jQuery.clean;
		        window.jQuery.clean = function (elems, context, fragment, scripts) {
		            var execResult = original.call(jQuery, elems, context, fragment, scripts);
		            if (scripts && scripts.length) {
		                for (var i = scripts.length - 1; i >= 0; i--) {
		                    var script = scripts[i];
		                    if (IsDXScript(script))
		                        ArrayRemoveAt(scripts, i);
		                }
		            }
		            return execResult;
		        };
		    }

		    // Utils
		    function IsDXScript(script) {
		        return script && script.id && script.id.indexOf("dx") == 0;
		    }
		    function ArrayRemoveAt(array, index) {
		        if (index >= 0 && index < array.length) {
		            for (var i = index; i < array.length - 1; i++)
		                array[i] = array[i + 1];
		            array.pop();
		        }
		    }

		    PatchJQuery();
    </script>
    <script type="text/javascript">
        function GetContactData() {

            var i = 0;
            var personPhones = new Array();
            $('#personAbstractTable tr').each(function () {
                if (i == 0) {
                    i = i + 1;
                }
                else {
                    var phone = $(this).find("td").eq(0).html();
                    var authorObject = new Object();
                    authorObject.Author = phone;
                    personPhones.push(authorObject);
                }
            });
            i = 0;
            

            var jsonphone = JSON.stringify(personPhones, function (key, value) {
                return value;
            });
            AbstractHiddenField.Set("jsonStringSetAuthor", jsonphone);

        }
        function AddAuthor(phone) {

            var authorText = new String($('#authors1').val());

            if (authorText == '') {
                alert('Please enter data into the author');
                return;
            }
            var tr = document.createElement('tr');
           
            var tdPhoneNumber = document.createElement('td');
            $(tdPhoneNumber).html(phone);
            $(tdPhoneNumber).addClass('authortext');
            var tdClosePhone = document.createElement('td');
            $(tdClosePhone).addClass('rbm-tableleft');
            $(tdClosePhone).html('<a href="javascript:void(0);" onclick="$(this).parent().parent().remove();"><img src="images/aDelete.png" alt="add" class="addremove" /></a>');
            tr.appendChild(tdPhoneNumber);
            tr.appendChild(tdClosePhone);
            $(tr).attr('class', 'even-row');
          
            $('#authors1').val('');
            $('#personAbstractTable tr:last').after(tr);
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>Submit Abstracts</h1>
     <dx:ASPxHiddenField ID="AbstractHiddenField" ClientInstanceName="AbstractHiddenField" runat="server">
     </dx:ASPxHiddenField>
 <div class="loginform">

                        <div class="frmHead">Abstract Title</div>
                         <dx:ASPxTextBox ID="AbstractTitleText" CssClass="blueInpReg" 
                            EnableDefaultAppearance="false" EnableTheming="false" runat="server" 
                            Height="45px" Width="647px" Font-Size="26px">
                             <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                 ErrorDisplayMode="Text" ErrorTextPosition="Bottom">
                                 <ErrorFrameStyle Font-Size="16px" ForeColor="Red">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText="Please Enter Abstract Title" IsRequired="True" />
                             </ValidationSettings>
                         </dx:ASPxTextBox>
                        <div class="frmHead">Topic</div>
                        <dx:ASPxTextBox ID="AbstractTopicText" CssClass="blueInpReg" EnableDefaultAppearance="false" EnableTheming="false" runat="server" Height="45px" Width="647px" Font-Size="26px">
                            <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                ErrorDisplayMode="Text" ErrorTextPosition="Bottom">
                                <ErrorFrameStyle Font-Size="16px" ForeColor="Red">
                                </ErrorFrameStyle>
                                <RequiredField ErrorText="Please Enter Abstract Topic" IsRequired="True" />
                            </ValidationSettings>
                         </dx:ASPxTextBox>
                        <div class="frmHead">Authors</div>
                        <table>
                            <tr>
                                <td> <input value="" id="authors1" class="blueInp" name="authors1" type="text" />
                                </td>
                                <td>
                                    <a href="javascript:void(0);" onclick="AddAuthor($('#authors1').val());">
                                    <img src="images/aAdd.png" alt="add" class="addremove" />
                                    </a>
                                </td>
                                <td>
                                    
                                </td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    <table id="personAbstractTable" style="width:100%;">
                                        <tr></tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                        
                        <div class="frmHead">Abstract </div>
                         <dx:ASPxMemo ID="AbstractText" CssClass="blueInpRegTA" 
                            EnableDefaultAppearance="false" EnableTheming="false" runat="server" 
                            Height="165px" Width="648px" Native="True">
                             <ValidationSettings CausesValidation="True" Display="Dynamic" 
                                 ErrorDisplayMode="Text" ErrorTextPosition="Bottom">
                                 <ErrorFrameStyle Font-Size="16px" ForeColor="Red">
                                 </ErrorFrameStyle>
                                 <RequiredField ErrorText="Please Enter Abstract" IsRequired="True" />
                             </ValidationSettings>
                         </dx:ASPxMemo>
                         <div class="frmHead">Cover Letter </div>
                         <dx:ASPxMemo ID="AbstractCoveringLetterText" CssClass="blueInpRegTA" 
                            EnableDefaultAppearance="false" EnableTheming="false" runat="server" 
                            Height="165px" Width="648px" Native="True">
                         </dx:ASPxMemo>
                         <dx:ASPxCheckBox ID="AbstractVerifyCheck" EnableDefaultAppearance="false" 
                            EnableTheming="false" runat="server" 
                            Text="By clicking this checkbox you verify that all the information you entered is correct" 
                            Width="648px" Height="30px" SpriteCssFilePath="~/CSS/checkboxsprit.css" 
                            SpriteImageUrl="~/images/checkbox.png">
                         </dx:ASPxCheckBox>
                        
                        <br class="clear" />
                        <table style="text-align:right;width:95%;">
                        <tr><td align="right">
                     <dx:ASPxButton ID="AbstractSave" runat="server" Text="Save" HorizontalAlign="Center"
                    Font-Bold="True" Font-Size="16px" 
                     Height="45px" Width="120px" onclick="AbstractSave_Click">
                    <ClientSideEvents Click="function(s, e) {
	GetContactData();
}" />
                </dx:ASPxButton>   
                        </td></tr>
                     
                </table>
                      <br class="clear" />
                    </div>
                   

</asp:Content>