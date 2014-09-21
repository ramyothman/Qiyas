<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master" AutoEventWireup="true" CodeBehind="Speakers.aspx.cs" Inherits="SocioBuilderSite.Conference.Speakers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript" src="/_Scripts/Front/javascript.js"> </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>
<asp:Literal runat="server" ID="SpeakersTitle" Text='<%$Resources:ConferenceFront, SpeakersTitle %>'></asp:Literal>
</h1>
<div id="wrapper">
 <asp:ObjectDataSource ID="SpeakersObjectDS2" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    
                    TypeName="BusinessLogicLayer.Components.Conference.ConferenceSpeakersLogic" >
                      <SelectParameters>
                          <asp:SessionParameter DefaultValue="0" Name="ConferenceId" 
                              SessionField="CurrentApplicationConferenceId" Type="Int32" />
                          <asp:SessionParameter DefaultValue="1" Name="LanguageId" 
                              SessionField="LanguageID" Type="Int32" />
                      </SelectParameters>
                </asp:ObjectDataSource>
                  
                     
                     <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SpeakersObjectDS2">
                        
                       <ItemTemplate>
                       <div class="accordionButton">
      <img src='<%# "../ContentData/Sites/Conferences/" + DataBinder.Eval(Container.DataItem, "SpeakerImage")%>' width="141" height="154" alt="speaker" class="imgcls5" />
      <h2><%# DataBinder.Eval(Container.DataItem, "CurrentPerson.DisplayName")%> </h2>
      <h3><%# DataBinder.Eval(Container.DataItem, "SpeakerPosition")%></h3>
      <%--<p>Short Bio Not Available</p>--%>
<h5><asp:Literal runat="server" Text='<%$Resources:ConferenceFront, Speakers_MoreAbout  %>'></asp:Literal></h5>

      </div>
      <div class="accordionContent">
      <p>
      <%# DataBinder.Eval(Container.DataItem, "SpeakerBio")%>
      </p>
      </div>
                       </ItemTemplate>
                      </asp:Repeater>
                            
	</div>
</asp:Content>
