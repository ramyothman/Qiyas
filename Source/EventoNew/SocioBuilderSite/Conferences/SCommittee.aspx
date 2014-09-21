<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Conference.Master" AutoEventWireup="true" CodeBehind="SCommittee.aspx.cs" Inherits="SocioBuilderSite.Conferences.SCommittee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript" src="Scripts/javascript.js"> </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br class="clear" />
<div style="padding-top:10px;margin-top:10px;">
<h1>Scientific Committee</h1>
<div id="wrapper">
 <asp:ObjectDataSource ID="SpeakersObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    
                    TypeName="BusinessLogicLayer.Components.Conference.ConferenceSpeakersLogic" 
                    EnableCaching="True">
                      <SelectParameters>
                          <asp:SessionParameter DefaultValue="0" Name="ConferenceId" 
                              SessionField="CurrentApplicationConferenceId" Type="Int32" />
                      </SelectParameters>
                </asp:ObjectDataSource>
                  
                      
                     <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SpeakersObjectDS">
                        
                       <ItemTemplate>
                       <div class="accordionButton">
      <img src='<%# "../ContentData/Sites/Conferences/" + DataBinder.Eval(Container.DataItem, "SpeakerImage")%>' width="141" height="154" alt="speaker" class="imgcls5" />
      <h2><%# DataBinder.Eval(Container.DataItem, "CurrentPerson.DisplayName")%> </h2>
      <span><%# DataBinder.Eval(Container.DataItem, "SpeakerPosition")%></span>
      <%--<p>Short Bio Not Available</p>--%><br /><br />
<h5> More About</h5>

      </div>
      <div class="accordionContent">
      <p>
      <%# DataBinder.Eval(Container.DataItem, "SpeakerBio")%>
      </p>
      </div>
                       </ItemTemplate>
                      </asp:Repeater>
                            
	</div>
               </div>
</asp:Content>
