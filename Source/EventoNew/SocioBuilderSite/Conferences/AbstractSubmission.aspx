<%@ Page Title="" EnableViewState="true" Language="C#" MasterPageFile="~/MasterPages/Conference.Master" AutoEventWireup="true" CodeBehind="AbstractSubmission.aspx.cs" Inherits="SocioBuilderSite.Conferences.AbstractSubmission" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script src="Scripts/custom-form-elements.js" type="text/javascript"></script>
<script type="text/javascript">
    var counter = 0;

    function moreFields() {
        counter++;
        var newFields = document.getElementById('readroot').cloneNode(true);
        newFields.id = 'author' + counter;
        newFields.style.display = 'block';
        var newField = newFields.childNodes;
        for (var i = 0; i < newField.length; i++) {
            var theName = newField[i].name
            if (theName)
                newField[i].name = theName + counter;
        }
        var insertHere = document.getElementById('AfterAppendCoauthors');
        insertHere.parentNode.insertBefore(newFields, insertHere);
    }

    function SaveStateForStep2() {
        var insertHere = document.getElementById('AppendCoauthors');
        alert(Step2HiddenField.Get('Step2'));
    }

    function LoadStateForStep2() {
        var insertHere = document.getElementById('AppendCoauthors');
        $(insertHere).html(Step2HiddenField.Get('Step2'));
    }

</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<dx:ASPxHiddenField ID="Step2HiddenField" ClientInstanceName="Step2HiddenField"  runat="server">
            </dx:ASPxHiddenField>
    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
        <asp:View runat="server" ID="Step1">
             <div class="newform">
				<ul id="topmenu">
                <li><a href="#" class="active">Authors</a></li>
                <li><a href="#">Abstract</a></li>
                <li><a href="#">Review</a></li>
                <li><a href="#">Finish</a></li>                                                
                </ul>
                <br class="clear" />
                
            <fieldset>
            <div id="steps">
              <img src="images/step-icon-02.jpg" width="18" height="18" /><img src="images/step-line-02.jpg" width="75" height="18" /><img src="images/step-icon-03.jpg" width="18" height="18" /><img src="images/step-line-02.jpg" width="75" height="18" /><img src="images/step-icon-03.jpg" width="18" height="18" /><img src="images/step-line-02.jpg" width="75" height="18" /><img src="images/step-icon-03.jpg" width="18" height="18" />  </div>
            </fieldset>
                        <br class="clear" />
                        
              <fieldset>
                <legend>Abstract Submission</legend>
                               <table width="100%" border="0" cellspacing="5" cellpadding="5">
                                 <tr>
                                   <td width="18%" align="right"><label>Catorgery</label></td>
                                   <td width="82%" align="left"><select runat="server"  name="select3" class="newform-list" id="AbstractCategoryCombo">
                                     <option value="0">(Select Category)</option>
                                     <option value="1">Basic Science</option>
                                     <option value="2">Clinical</option>
                                   </select>                                     
                                    </td>
                                 </tr>
                                 <tr>
                                   <td align="right">&nbsp;</td>
                                   <td><p>Select the Abstract Category</p></td>
                                 </tr>
                               </table>
                        </fieldset>
              <fieldset>
              <legend>Author Infromation</legend>

<table width="100%" border="0" cellspacing="5" cellpadding="5" class="formz">
  <tr>
    <td width="18%" align="right"><label>First Name</label>  </td>
    <td width="82%" align="left"><input runat="server" id="AuthorFirstNameText" name="textfield" type="text" class="newform-txt" size="30" /><br /> </td>
  </tr>
  <tr>
    <td align="right"><label>Family Name</label></td>
    <td align="left"><input name="textfield2" type="text" class="newform-txt" runat="server" id="AuthorFamilyNameText" size="30" />
      <br /></td>
  </tr>
  <tr>
    <td align="right"><label>Title</label></td>
    <td align="left">
        <select runat="server"  name="select3" class="newform-list" id="AuthorTitleCombo">
                                     <option>Dr.</option>
                                     <option>Prof.</option>
                                     <option>Mr.</option>
                                     <option>Miss.</option>
                                     <option>Mrs.</option>
                                     <option>Ms.</option>
                                   </select>                    
      <br /></td>
  </tr>
  <tr>
    <td align="right"><label>Degree</label></td>
    <td align="left"><input name="textfield2" type="text" class="newform-txt" runat="server" id="AuthorDegreeText" size="30" />
      <br /></td>
  </tr>
  <tr>
    <td align="right"><label>Email</label></td>
    <td align="left"><input name="textfield2" type="text" class="newform-txt" runat="server" id="AuthorEmailText" size="30" />
      <br /></td>
  </tr>
  <tr>
    <td align="right">&nbsp;</td>
    <td> <p>Enter your primary contact email address.</p></td>
  </tr>
   <tr>
    <td align="right"><label>PO BOX</label></td>
    <td align="left"><input name="textfield15" type="text" class="newform-txt" runat="server" id="AuthorPOBoxText" size="30" /></td>
  </tr>
  <tr>
    <td align="right"><label>Zip Code</label></td>
    <td align="left"><input name="textfield16" type="text" class="newform-txt" runat="server" id="AuthorZipCodeText" size="30" /></td>
  </tr>
  <tr>
    <td align="right"><label>City</label></td>
    <td align="left"><input name="textfield17" type="text" class="newform-txt" runat="server" id="AuthorCityText" size="30" /></td>
  </tr>
  <tr>
    <td align="right"><label>Country</label></td>
    <td align="left"><input name="textfield18" type="text" class="newform-txt" runat="server" id="AuthorCountryText" size="30" /></td>
  </tr>

  <tr>
    <td align="right"><label>Address</label></td>
    <td align="left"><input name="textfield3" type="text" class="newform-txt" runat="server" id="AuthorAddressText" size="60" />
      <br /></td>
  </tr>
  <tr>
    <td align="right"><label>Phone number</label></td>
    <td align="left"><input name="textfield3" type="text" class="newform-txt" runat="server" id="AuthorPhoneNumberAreaCodeText" size="4" />
      <input name="textfield4" type="text" class="newform-txt" runat="server" id="AuthorPhoneNumberText" size="22" />
      <br /></td>
  </tr>
  <tr>
    <td align="right">&nbsp;</td>
    <td><p>Area code + Phone Number</p></td>
  </tr>
  <tr>
    <td align="right"><label>Affliation</label></td>
    <td align="left"><input name="textfield5" type="text" class="newform-txt" runat="server" id="AuthorDepartmentText" size="30" />
      <br /></td>
  </tr>
   <tr>
    <td align="right">&nbsp;</td>
    <td><p>Department</p></td>
  </tr>
  <tr>
    <td align="right">&nbsp;</td>
    <td><input name="textfield6" type="text" class="newform-txt" runat="server" id="AuthorInstitutionHospitalText" size="30" /></td>
  </tr>
   <tr>
    <td align="right">&nbsp;</td>
    <td><p>Institution/Hospital</p></td>
  </tr>
  <tr>
    <td align="right">&nbsp;</td>
    <td><input name="textfield7" type="text" class="newform-txt" runat="server" id="AuthorAffilitationCityText" size="30" /></td>
  </tr>
   <tr>
    <td align="right">&nbsp;</td>
    <td><p>City</p></td>
  </tr>
  <tr>
    <td align="right">&nbsp;</td>
    <td><input name="textfield8" type="text" class="newform-txt" runat="server" id="AuthorAffilitationCountryText" size="30" /></td>
  </tr>
   <tr>
    <td align="right">&nbsp;</td>
    <td><p>Country</p></td>
  </tr>
</table>

                </fieldset>
                
                
                <table width="99%" border="0" cellspacing="0" cellpadding="0" class="formz">
  <tr>
    <td>&nbsp;</td>
    <td align="right">
    <asp:Button runat="server" ID="Step1Button" CssClass="newform-bot-01" Text="Next" 
            onclick="Step1Button_Click" />
    <%--<input name="input" type="button" value="Next" class="newform-bot-01" />--%></td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table>

            </div>
                

        </asp:View>
        <asp:View runat="server" ID="Step2">
            
         <div class="newform">
				<ul id="topmenu">
                <li><a href="#" class="active">Authors</a></li>
                <li><a href="#">Abstract</a></li>
                <li><a href="#">Review</a></li>
                <li><a href="#">Finish</a></li>                                                
                </ul>
                <br class="clear" />
                
            <fieldset>
            <div id="Div1">
              <img src="images/step-icon-02.jpg" width="18" height="18" /><img src="images/step-line-02.jpg" width="75" height="18" /><img src="images/step-icon-03.jpg" width="18" height="18" /><img src="images/step-line-02.jpg" width="75" height="18" /><img src="images/step-icon-03.jpg" width="18" height="18" /><img src="images/step-line-02.jpg" width="75" height="18" /><img src="images/step-icon-03.jpg" width="18" height="18" />  </div>

            </fieldset>
                        <br class="clear" />
              <br />          
                        <div id="readroot" style="display: none">
                        <div style="margin-bottom:10px;">
                        
              <fieldset>
                <legend>Co-Author</legend>
             
              <table width="100%" border="0" cellspacing="5" cellpadding="5" class="formz">
  <tr>
    <td width="18%" align="right"><label>First Name</label>  </td>
    <td width="82%" align="left"><input runat="server" id="CoAuthorFirstNameText" name="textfield" type="text" class="newform-txt" size="30" /> <input type="button" id="close"  onclick="this.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.removeChild(this.parentNode.parentNode.parentNode.parentNode.parentNode);" class="newform-close fixright" /><br class="clear" /> </td>
  </tr>
  <tr>
    <td align="right"><label>Family Name</label></td>
    <td align="left"><input name="textfield2" type="text" class="newform-txt" runat="server" id="CoAuthorFamilyNameText" size="30" />
      <br /></td>
  </tr>
  <tr>
    <td align="right"><label>Title</label></td>
    <td align="left">
        <select runat="server"  name="select3" class="newform-list" id="CoAuthorTitleCombo">
                                     <option>Dr.</option>
                                     <option>Prof.</option>
                                     <option>Mr.</option>
                                     <option>Miss.</option>
                                     <option>Mrs.</option>
                                     <option>Ms.</option>
                                   </select>                    
      <br /></td>
  </tr>
  <tr>
    <td align="right"><label>Degree</label></td>
    <td align="left"><input name="textfield2" type="text" class="newform-txt" runat="server" id="CoAuthorDegreeText" size="30" />
      <br /></td>
  </tr>
  <tr>
    <td align="right"><label>Email</label></td>
    <td align="left"><input name="textfield2" type="text" class="newform-txt" runat="server" id="CoAuthorEmailText" size="30" />
      <br /></td>
  </tr>
  <tr>
    <td align="right">&nbsp;</td>
    <td> <p>Enter your primary contact email address.</p></td>
  </tr>
   <tr>
    <td align="right"><label>PO BOX</label></td>
    <td align="left"><input name="textfield15" type="text" class="newform-txt" runat="server" id="CoAuthorPOBoxText" size="30" /></td>
  </tr>
  <tr>
    <td align="right"><label>Zip Code</label></td>
    <td align="left"><input name="textfield16" type="text" class="newform-txt" runat="server" id="CoAuthorZipCodeText" size="30" /></td>
  </tr>
  <tr>
    <td align="right"><label>City</label></td>
    <td align="left"><input name="textfield17" type="text" class="newform-txt" runat="server" id="CoAuthorCityText" size="30" /></td>
  </tr>
  <tr>
    <td align="right"><label>Country</label></td>
    <td align="left"><input name="textfield18" type="text" class="newform-txt" runat="server" id="CoAuthorCountryText" size="30" /></td>
  </tr>

  <tr>
    <td align="right"><label>Address</label></td>
    <td align="left"><input name="textfield3" type="text" class="newform-txt" runat="server" id="CoAuthorAddressText" size="60" />
      <br /></td>
  </tr>
  <tr>
    <td align="right"><label>Phone number</label></td>
    <td align="left"><input name="textfield3" type="text" class="newform-txt" runat="server" id="CoAuthorPhoneNumberAreaCodeText" size="4" />
      <input name="textfield4" type="text" class="newform-txt" runat="server" id="CoAuthorPhoneNumberText" size="22" />
      <br /></td>
  </tr>
  <tr>
    <td align="right">&nbsp;</td>
    <td><p>Area code + Phone Number</p></td>
  </tr>
  <tr>
    <td align="right"><label>Affliation</label></td>
    <td align="left"><input name="textfield5" type="text" class="newform-txt" runat="server" id="CoAuthorAffilitationDepartmentText" size="30" />
      <br /></td>
  </tr>
   <tr>
    <td align="right">&nbsp;</td>
    <td><p>Department</p></td>
  </tr>
  <tr>
    <td align="right">&nbsp;</td>
    <td><input name="textfield6" type="text" class="newform-txt" runat="server" id="CoAuthorAffilitationInstitutionHospitalText" size="30" /></td>
  </tr>
   <tr>
    <td align="right">&nbsp;</td>
    <td><p>Institution/Hospital</p></td>
  </tr>
  <tr>
    <td align="right">&nbsp;</td>
    <td><input name="textfield7" type="text" class="newform-txt" runat="server" id="CoAuthorAffilitationCityText" size="30" /></td>
  </tr>
   <tr>
    <td align="right">&nbsp;</td>
    <td><p>City</p></td>
  </tr>
  <tr>
    <td align="right">&nbsp;</td>
    <td><input name="textfield8" type="text" class="newform-txt" runat="server" id="CoAuthorAffilitationCountryText" size="30" /></td>
  </tr>
   <tr>
    <td align="right">&nbsp;</td>
    <td><p>Country</p></td>
  </tr>
</table>
                
                </fieldset>
                </div>
                </div>
                <div id="AppendCoauthors" onload="LoadStateForStep2();" >
                    <div id="AfterAppendCoauthors"></div>
                </div>
                <fieldset>
                  <table width="100%" border="0" cellspacing="5" cellpadding="5">
                    <tr>
                      <td width="91%" align="right"><label>Add Co Author</label></td>
                      <td width="9%" align="right"><input type="button" name="add" id="add"  onclick="moreFields();" class="newform-add"/></td>
                    </tr>
                  </table>
                </fieldset>
                <p>&nbsp;</p>
                <table width="99%" border="0" cellspacing="0" cellpadding="0" class="formz">
  <tr>
    <td>
    <asp:Button runat="server" ID="BackToStep1" Text="Back" CssClass="newform-bot-01" 
            onclick="BackToStep1_Click" />
    </td>
    <td align="right">
    <asp:Button runat="server" ID="NextToStep3" Text="Next" CssClass="newform-bot-01" 
            onclick="NextToStep3_Click" OnClientClick="SaveStateForStep2();" />
    </td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table>

            </div>


        </asp:View>
        <asp:View runat="server" ID="Step3" >
         <div class="newform" >
				<ul id="topmenu">
                <li><a href="#" >Authors</a></li>
                <li><a href="#" class="active">Abstract</a></li>
                <li><a href="#">Review</a></li>
                <li><a href="#">Finish</a></li>                                                
                </ul>
                <br class="clear" />
                
            <fieldset>
            <div id="Div2">
              <img src="images/step-icon-01.jpg" width="18" height="18" /><img src="images/step-line-01.jpg" width="75" height="18" /><img src="images/step-icon-01.jpg" width="18" height="18" /><img src="images/step-line-01.jpg" width="75" height="18" /><img src="images/step-icon-02.jpg" width="18" height="18" /><img src="images/step-line-02.jpg" width="75" height="18" /><img src="images/step-icon-03.jpg" width="18" height="18" />  </div>
            </fieldset>
                        <br class="clear" />
              <fieldset>
                <legend>Abstract</legend>
                <table width="100%" border="0" cellspacing="5" cellpadding="5" class="formz">
                <tr>
    <td width="18%" align="right"><label>Title</label>  </td>
    <td width="82%" align="left"><input name="textfield" type="text" class="newform-txt" runat="server" id="AbstractTitleText" size="30" />   <br /> </td>
  </tr>
  <tr>
    <td align="right"><label>Background</label></td>
    <td align="left">
    <textarea runat="server" id="AbstractBackgroundText" rows="10" cols="5" style="width:400px;" ></textarea>
    <%--<input name="textfield2" type="text" class="newform-txt" id="text14" size="30" />--%>
      <br /></td>
  </tr>
  <tr>
    <td align="right"><label>Methods</label></td>
    <td align="left">
    <textarea runat="server" id="AbstractMethodsText" rows="10" cols="5" style="width:400px;"></textarea>
    
      <br /></td>
  </tr>
  <tr>
    <td align="right"><label>Results</label></td>
    <td align="left">
    <textarea runat="server" id="AbstractResultsText" rows="10" cols="5" style="width:400px;"></textarea>
      <br /></td>
  </tr>
  <tr>
    <td align="right"><label>Consutlion</label></td>
    <td align="left"><textarea runat="server" id="AbstractConclusionText" rows="10" cols="5" style="width:400px;"></textarea>
      <br /></td>
  </tr>

  <tr>
    <td align="right"><label>Keywords</label></td>
    <td align="left"><input runat="server"  name="textfield9" type="text" class="newform-txt" id="AbstractKeyword1" size="30" />      <br /></td>
  </tr>
    <tr>
    <td align="right">&nbsp;</td>
    <td> <p>Keyword 1</p></td>
  </tr>
  <tr>
    <td align="right">&nbsp;</td>
    <td><input name="textfield6" type="text" class="newform-txt" runat="server" id="AbstractKeyword2" size="30" /></td>
  </tr>
    <tr>
    <td align="right">&nbsp;</td>
    <td> <p>Keyword 2</p></td>
  </tr>
  <tr>
    <td align="right">&nbsp;</td>
    <td><input name="textfield7" type="text" class="newform-txt" runat="server" id="AbstractKeyword3" size="30" /></td>
  </tr>
    <tr>
    <td align="right">&nbsp;</td>
    <td> <p>Keyword 3</p></td>
  </tr>
</table>

                </fieldset>
      
                <br />
                <fieldset>
                        <legend>Documents</legend>
                  <table width="100%" border="0" cellpadding="5" cellspacing="5" class="formz">
                    <tr>
                      <td width="18%" align="right">&nbsp;</td>
                      <td width="44%" align="left"><img src="images/bar-01.jpg" width="262" height="14"  class="imgcls6" /><br /></td>
                      <td width="38%" align="left"><p class="blue">File name &amp; Size | <span><a href="#">Delete</a></span></p></td>
                    </tr>
                    <tr>
                      <td align="right">&nbsp;</td>
                      <td align="left"><img src="images/bar-02.jpg" width="262" height="13" class="imgcls6" /><br /></td>
                      <td width="38%" align="left"><p class="blue">File name &amp; Size | <span><a href="#">Delete</a></span></p></td>
                    </tr>
                    <tr>
                      <td align="right"><label>Upload</label></td>
                      <td align="left"><input name="textfield3" type="text" class="newform-txt" id="text21" size="31" />
                        <br /></td>
                      <td align="left"><input name="input3" type="button" value="Browes" class="newform-bot-01" /></td>
                    </tr>
                  </table>
  </fieldset>
                <p>&nbsp;</p>
                <table width="99%" border="0" cellspacing="0" cellpadding="0" class="formz">
  <tr>
    <td>
    <asp:Button runat="server" id="BacktoStep2" Text="Back" CssClass="newform-bot-01" 
            onclick="BacktoStep2_Click" />
    </td>
    <td align="right">
    <asp:Button runat="server" ID="NextToStep4" Text="Next" CssClass="newform-bot-01" 
            onclick="NextToStep4_Click" />
    </td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table>

            </div>

        </asp:View>
        <asp:View runat="server" ID="Step4">
              <div class="newform">
				<ul id="topmenu">
                <li><a href="#" >Authors</a></li>
                <li><a href="#">Abstract</a></li>
                <li><a href="#">Review</a></li>
                <li><a href="#" class="active">Finish</a></li>                                                
                </ul>
                <br class="clear" />
                
            <fieldset>
            <div id="Div3">
              <img src="images/step-icon-01.jpg" width="18" height="18" /><img src="images/step-line-01.jpg" width="75" height="18" /><img src="images/step-icon-01.jpg" width="18" height="18" /><img src="images/step-line-01.jpg" width="75" height="18" /><img src="images/step-icon-01.jpg" width="18" height="18" /><img src="images/step-line-01.jpg" width="75" height="18" /><img src="images/step-icon-02.jpg" width="18" height="18" />  </div>
            </fieldset>
                        <br class="clear" />
              <fieldset>
                <legend>Tearms &amp; Condetions                </legend>
                <p>&nbsp;</p>
                <h2>Title</h2>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. In a sollicitudin purus. Morbi molestie auctor tellus sed aliquet. Morbi at nunc at tortor tincidunt sagittis. Fusce laoreet tincidunt mauris, non fermentum tellus semper sit amet. Morbi vitae risus sapien, eget convallis sem. Aenean nec augue at est congue fermentum. Vestibulum ut lacus libero, vitae dapibus diam. Fusce ullamcorper pellentesque ullamcorper. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus vulputate pharetra odio, quis feugiat odio egestas eu. Vivamus eget leo diam, vitae venenatis lorem. Sed adipiscing nulla sit amet nulla suscipit rhoncus. Vestibulum et lacus mauris. Maecenas quis lorem neque. Nunc porttitor nisl vulputate diam gravida iaculis. Sed malesuada, nibh eget tempor venenatis, eros justo elementum mauris, non aliquet quam risus at ligula. Duis condimentum suscipit urna nec suscipit. Maecenas pulvinar, sapien non bibendum semper, elit mi pharetra quam, id pretium dui ligula vel nibh. Mauris eget neque mi. Proin ullamcorper accumsan velit in luctus.</p>
                <h4>Title-sub</h4>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. In a sollicitudin purus. Morbi molestie auctor tellus sed aliquet. Morbi at nunc at tortor tincidunt sagittis. Fusce laoreet tincidunt mauris, non fermentum tellus semper sit amet. Morbi vitae risus sapien, eget convallis sem. Aenean nec augue at est congue fermentum. Vestibulum ut lacus libero, vitae dapibus diam. Fusce ullamcorper pellentesque ullamcorper. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus vulputate pharetra odio, quis feugiat odio egestas eu. Vivamus eget leo diam, vitae venenatis lorem. Sed adipiscing nulla sit amet nulla suscipit rhoncus. Vestibulum et lacus mauris. Maecenas quis lorem neque. Nunc porttitor nisl vulputate diam gravida iaculis. Sed malesuada, nibh eget tempor venenatis, eros justo elementum mauris, non aliquet quam risus at ligula. Duis condimentum suscipit urna nec suscipit. Maecenas pulvinar, sapien non bibendum semper, elit mi pharetra quam, id pretium dui ligula vel nibh. Mauris eget neque mi. Proin ullamcorper accumsan velit in luctus.</p>
                <p>&nbsp;</p>
                <table width="100%" border="0" cellpadding="5" cellspacing="5" class="formz">
                  <tr>
                    <td width="8%" align="right">
                   
                    <input type="checkbox" name="a2" class="styled" /></td>
                    <td width="92%" align="left"><label>Agree On terms</label>                      
                      <br /></td>
                  </tr>
                </table>
         <br />
            </fieldset>
                <p>&nbsp;</p>
                <table width="99%" border="0" cellspacing="0" cellpadding="0" class="formz">
  <tr>
    <td><input name="input2" type="button" value="Back" class="newform-bot-01"  /></td>
    <td align="right"><input name="input" type="button" value="Next" class="newform-bot-01" /></td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table>

            </div>

        </asp:View>
    </asp:MultiView>
</asp:Content>
