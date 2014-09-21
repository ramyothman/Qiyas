<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SpeakersMain.ascx.cs" Inherits="SocioBuilderSite.Controls.Conference.SpeakersMain" %>


<div id="slide">
            <h1>Speakers</h1>
            <p><a href="~/Conferences/Speakers.aspx" runat="server" id="BrowseAllLink">Browse All</a></p>
          
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
                        <HeaderTemplate>
                            <ul id="mycarousel" class="jcarousel-skin-tango">      
                        </HeaderTemplate>
                       <ItemTemplate>
                       <li><img src='<%# "../ContentData/Sites/Conferences/" + DataBinder.Eval(Container.DataItem, "SpeakerImage")%>' width="141" height="154" alt="speaker" /><br /> <p><%# DataBinder.Eval(Container.DataItem, "CurrentPerson.DisplayName")%>
<br /></p></li>
                       </ItemTemplate>
                       <FooterTemplate>
                        </ul>
                       </FooterTemplate>
                      </asp:Repeater>
                                  
                  <%--  <li><img src="images/speaker-03.jpg" width="141" height="154" /><Br /> <p>First Last Name<Br />Tilte</p></li>
                    <li><img src="images/speaker-04.jpg" width="141" height="154" /><Br /> <p>First Last Name<Br />Tilte</p></li>
                    <li><img src="images/speaker-01.jpg" width="141" height="154" /><Br /> <p>First Last Name<Br />Tilte</p></li>                
                    <li><img src="images/speaker-01.jpg" width="141" height="154" /><Br /> <p>First Last Name<Br />Tilte</p></li>  --%>
                 
            </div>
            <div class="clear"></div>