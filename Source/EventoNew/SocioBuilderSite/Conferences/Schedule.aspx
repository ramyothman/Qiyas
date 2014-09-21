<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Conference.Master" AutoEventWireup="true" CodeBehind="Schedule.aspx.cs" Inherits="SocioBuilderSite.Conferences.Schedule" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <script src="Scripts/ui.core.js" type="text/javascript"></script>
        <script src="Scripts/ui.tabs.js" type="text/javascript"></script>

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
        jQuery(document).ready(function () {
            $('#tabdivs1 > ul').tabs();
            $('#tabdivs2 > ul').tabs();
            $('#tabdivs3 > ul').tabs();
        });

        </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br class="clear" /><br />

<div runat="server" id="Program1" >
<h1 runat="server" id="ProgramName">Pre-Conference Course</h1>
<%--<h1 runat="server" id="ProgramName">Schedule</h1>--%>
<div id="tabdivs1" >
                  <ul>
                    <li><a href="#abs-1"><span>Day 1</span></a></li>
                  </ul>
     <div id="abs-1">
        <asp:Repeater runat="server" ID="Day0Program1" 
             DataSourceID="Program1ObjectDSDay0">
            <ItemTemplate>
                <div class='<%# GetMainClasses(DataBinder.Eval(Container.DataItem, "ScheduleSessionTypeId").ToString()) %>'>
        <div class="date">
        <div class="month"><%# GetMonth(DataBinder.Eval(Container.DataItem, "StartTime")) %></div>
        <div class="day"><%# GetDay(DataBinder.Eval(Container.DataItem, "StartTime"))%></div>
        <div class="time"><%# GetStartTime(DataBinder.Eval(Container.DataItem, "StartTime"))%> - <%# GetStartTime(DataBinder.Eval(Container.DataItem, "EndTime"))%></div>
        
        </div>
        <div class="sch-info">
        <div class="abs-icons ">
        <div class='<%# GetIconClasses(DataBinder.Eval(Container.DataItem, "ScheduleSessionTypeId").ToString()) %>'></div>
      </div>
          
          <h1><%# DataBinder.Eval(Container.DataItem, "Title") %></h1>
        <h3><%# DataBinder.Eval(Container.DataItem, "Description") %> </h3>
        <h2><%# DataBinder.Eval(Container.DataItem, "SpeakerName") %> </h2>
        <p><%# DataBinder.Eval(Container.DataItem, "AllDescription") %></p>
      </div>
        <div class="clear"></div>
    </div>

                <%--<div class="schedule">

        <div class="date">
        <div class="month"></div>
        <div class="day"></div>
        <div class="time">Start </div>
        <div class="time">End </div>
        </div>
      
        <div class="sch-img" style='<%# Convert.ToInt32(DataBinder.Eval(Container.DataItem, "PersonId")) > 0 ? "display:block;" : "display:none;"  %>'
             visible='<%# Convert.ToInt32(DataBinder.Eval(Container.DataItem, "PersonId")) > 0  %>'><img runat="server" id="SpeakerImage" src="images/speaker-th.jpg" width="100" height="115" /></div>
      
        <div class="sch-info">
        <h1>()</h1>
        <h2></h2>
        <p></p>
        </div>
        <div class="clear"></div>

                </div>--%>
            </ItemTemplate>
        </asp:Repeater>
         <asp:ObjectDataSource ID="Program1ObjectDSDay0" runat="server" 
             OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
             TypeName="BusinessLogicLayer.Components.Conference.ConferenceScheduleLogic">
             <SelectParameters>
                 <asp:Parameter DefaultValue="1" Name="programId" Type="Int32" />
                 <asp:Parameter DefaultValue="19" Name="day" Type="Int32" />
             </SelectParameters>
         </asp:ObjectDataSource>
     </div>
     </div>
</div>
<div runat="server" id="Program2" visible="false">
<h1 runat="server" id="H1">Annual Meeting Program</h1>
<div id="tabdivs2" >
                  <ul>
                    <li><a href="#abs2-1"><span>Day 2</span></a></li>
                    <li><a href="#abs2-2"><span>Day 3</span></a></li>
                    <li><a href="#abs2-3"><span>Day 4</span></a></li>
                  </ul>
     <div id="abs2-1">
        <asp:Repeater runat="server" ID="Repeater1" 
             DataSourceID="ObjectDataSource1">
            <ItemTemplate>
            <div class='<%# GetMainClasses(DataBinder.Eval(Container.DataItem, "ScheduleSessionTypeId").ToString()) %>'>
        <div class="date">
        <div class="month"><%# GetMonth(DataBinder.Eval(Container.DataItem, "StartTime")) %></div>
        <div class="day"><%# GetDay(DataBinder.Eval(Container.DataItem, "StartTime"))%></div>
        <div class="time"><%# GetStartTime(DataBinder.Eval(Container.DataItem, "StartTime"))%> - <%# GetStartTime(DataBinder.Eval(Container.DataItem, "EndTime"))%></div>
        
        </div>
        <div class="sch-info">
        <div class="abs-icons ">
        <div class='<%# GetIconClasses(DataBinder.Eval(Container.DataItem, "ScheduleSessionTypeId").ToString()) %>'></div>
      </div>
          
          <h1><%# DataBinder.Eval(Container.DataItem, "Title") %></h1>
        <h3><%# DataBinder.Eval(Container.DataItem, "Description") %> </h3>
        <h2><%# DataBinder.Eval(Container.DataItem, "SpeakerName") %> </h2>
        <p><%# DataBinder.Eval(Container.DataItem, "AllDescription") %></p>
      </div>
        <div class="clear"></div>
    </div>
                <%--<div class="schedule">
                    <div class="date">
                        <div class="month">
                            <%# GetMonth(DataBinder.Eval(Container.DataItem, "StartTime")) %></div>
                        <div class="day">
                            <%# GetDay(DataBinder.Eval(Container.DataItem, "StartTime"))%></div>
                        <div class="time">
                            <%# GetStartTime(DataBinder.Eval(Container.DataItem, "StartTime"))%></div>
                    </div>
                    <div class="sch-info">
                        <h1>
                            <%# DataBinder.Eval(Container.DataItem, "Title") %></h1>
                        <h2>
                            <%# DataBinder.Eval(Container.DataItem, "Description") %></h2>
                         <h3>
                            <%# DataBinder.Eval(Container.DataItem, "SpeakerName") %></h3>
                        <p>
                            <%# DataBinder.Eval(Container.DataItem, "AllDescription") %>
                        </p>
                    </div>
                    <div class="clear">
                    </div>
                    </div>--%>
            </ItemTemplate>
        </asp:Repeater>
         <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
             OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
             TypeName="BusinessLogicLayer.Components.Conference.ConferenceScheduleLogic">
             <SelectParameters>
                 <asp:Parameter DefaultValue="2" Name="programId" Type="Int32" />
                 <asp:Parameter DefaultValue="20" Name="day" Type="Int32" />
             </SelectParameters>
         </asp:ObjectDataSource>
     </div>
     <div id="abs2-2">
        <asp:Repeater runat="server" ID="Repeater2" 
             DataSourceID="ObjectDataSource2">
            <ItemTemplate>
            <div class='<%# GetMainClasses(DataBinder.Eval(Container.DataItem, "ScheduleSessionTypeId").ToString()) %>'>
        <div class="date">
        <div class="month"><%# GetMonth(DataBinder.Eval(Container.DataItem, "StartTime")) %></div>
        <div class="day"><%# GetDay(DataBinder.Eval(Container.DataItem, "StartTime"))%></div>
        <div class="time"><%# GetStartTime(DataBinder.Eval(Container.DataItem, "StartTime"))%> - <%# GetStartTime(DataBinder.Eval(Container.DataItem, "EndTime"))%></div>
        
        </div>
        <div class="sch-info">
        <div class="abs-icons ">
        <div class='<%# GetIconClasses(DataBinder.Eval(Container.DataItem, "ScheduleSessionTypeId").ToString()) %>'></div>
      </div>
          
          <h1><%# DataBinder.Eval(Container.DataItem, "Title") %></h1>
        <h3><%# DataBinder.Eval(Container.DataItem, "Description") %> </h3>
        <h2><%# DataBinder.Eval(Container.DataItem, "SpeakerName") %> </h2>
        <p><%# DataBinder.Eval(Container.DataItem, "AllDescription") %></p>
      </div>
        <div class="clear"></div>
    </div>
                <%--<div class="schedule">
                    <div class="date">
                        <div class="month">
                            <%# GetMonth(DataBinder.Eval(Container.DataItem, "StartTime")) %></div>
                        <div class="day">
                            <%# GetDay(DataBinder.Eval(Container.DataItem, "StartTime"))%></div>
                        <div class="time">
                            <%# GetStartTime(DataBinder.Eval(Container.DataItem, "StartTime"))%></div>
                    </div>
                    <div class="sch-info">
                        <h1>
                            <%# DataBinder.Eval(Container.DataItem, "Title") %></h1>
                        <h2>
                            <%# DataBinder.Eval(Container.DataItem, "Description") %></h2>
                         <h3>
                            <%# DataBinder.Eval(Container.DataItem, "SpeakerName") %></h3>
                        <p>
                            <%# DataBinder.Eval(Container.DataItem, "AllDescription") %>
                        </p>
                    </div>
                    <div class="clear">
                    </div>
                    </div>--%>
            </ItemTemplate>
        </asp:Repeater>
         <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
             OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
             TypeName="BusinessLogicLayer.Components.Conference.ConferenceScheduleLogic">
             <SelectParameters>
                 <asp:Parameter DefaultValue="2" Name="programId" Type="Int32" />
                 <asp:Parameter DefaultValue="21" Name="day" Type="Int32" />
             </SelectParameters>
         </asp:ObjectDataSource>
     </div>
     <div id="abs2-3">
        <asp:Repeater runat="server" ID="Repeater3" 
             DataSourceID="ObjectDataSource3">
            <ItemTemplate>
            <div class='<%# GetMainClasses(DataBinder.Eval(Container.DataItem, "ScheduleSessionTypeId").ToString()) %>'>
        <div class="date">
        <div class="month"><%# GetMonth(DataBinder.Eval(Container.DataItem, "StartTime")) %></div>
        <div class="day"><%# GetDay(DataBinder.Eval(Container.DataItem, "StartTime"))%></div>
        <div class="time"><%# GetStartTime(DataBinder.Eval(Container.DataItem, "StartTime"))%> - <%# GetStartTime(DataBinder.Eval(Container.DataItem, "EndTime"))%></div>
        
        </div>
        <div class="sch-info">
        <div class="abs-icons ">
        <div class='<%# GetIconClasses(DataBinder.Eval(Container.DataItem, "ScheduleSessionTypeId").ToString()) %>'></div>
      </div>
          
          <h1><%# DataBinder.Eval(Container.DataItem, "Title") %></h1>
        <h3><%# DataBinder.Eval(Container.DataItem, "Description") %> </h3>
        <h2><%# DataBinder.Eval(Container.DataItem, "SpeakerName") %> </h2>
        <p><%# DataBinder.Eval(Container.DataItem, "AllDescription") %></p>
      </div>
        <div class="clear"></div>
    </div>
                <%--<div class="schedule">
                    <div class="date">
                        <div class="month">
                            <%# GetMonth(DataBinder.Eval(Container.DataItem, "StartTime")) %></div>
                        <div class="day">
                            <%# GetDay(DataBinder.Eval(Container.DataItem, "StartTime"))%></div>
                        <div class="time">
                            <%# GetStartTime(DataBinder.Eval(Container.DataItem, "StartTime"))%></div>
                    </div>
                    <div class="sch-info">
                        <h1>
                            <%# DataBinder.Eval(Container.DataItem, "Title") %></h1>
                        <h2>
                            <%# DataBinder.Eval(Container.DataItem, "Description") %></h2>
                         <h3>
                            <%# DataBinder.Eval(Container.DataItem, "SpeakerName") %></h3>
                        <p>
                            <%# DataBinder.Eval(Container.DataItem, "AllDescription") %>
                        </p>
                    </div>
                    <div class="clear">
                    </div>
                    </div>--%>
            </ItemTemplate>
        </asp:Repeater>
         <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" 
             OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
             TypeName="BusinessLogicLayer.Components.Conference.ConferenceScheduleLogic">
             <SelectParameters>
                 <asp:Parameter DefaultValue="2" Name="programId" Type="Int32" />
                 <asp:Parameter DefaultValue="22" Name="day" Type="Int32" />
             </SelectParameters>
         </asp:ObjectDataSource>
     </div>
     </div>
</div>
<div runat="server" id="Program3" visible="false">
<h1 runat="server" id="H2">Nursing Program</h1>
<div id="tabdivs3" >
                  <ul runat="server" id="Ul2">
                  <li><a href="#abs3-1"><span>Day 1</span></a></li>
                    <li><a href="#abs3-2"><span>Day 2</span></a></li>
                    <li><a href="#abs3-3"><span>Day 3</span></a></li>
                  </ul>
     <div id="abs3-1">
     <asp:Repeater runat="server" ID="Repeater4" 
             DataSourceID="ObjectDataSource4">
            <ItemTemplate>
            <div class='<%# GetMainClasses(DataBinder.Eval(Container.DataItem, "ScheduleSessionTypeId").ToString()) %>'>
        <div class="date">
        <div class="month"><%# GetMonth(DataBinder.Eval(Container.DataItem, "StartTime")) %></div>
        <div class="day"><%# GetDay(DataBinder.Eval(Container.DataItem, "StartTime"))%></div>
        <div class="time"><%# GetStartTime(DataBinder.Eval(Container.DataItem, "StartTime"))%> - <%# GetStartTime(DataBinder.Eval(Container.DataItem, "EndTime"))%></div>
        </div>
        <div class="sch-info">
        <div class="abs-icons ">
        <div class='<%# GetIconClasses(DataBinder.Eval(Container.DataItem, "ScheduleSessionTypeId").ToString()) %>'></div>
      </div>
          
          <h1><%# DataBinder.Eval(Container.DataItem, "Title") %></h1>
        <h3><%# DataBinder.Eval(Container.DataItem, "Description") %> </h3>
        <h2><%# DataBinder.Eval(Container.DataItem, "SpeakerName") %> </h2>
        <p><%# DataBinder.Eval(Container.DataItem, "AllDescription") %></p>
      </div>
        <div class="clear"></div>
    </div>
                <%--<div class="schedule">
                    <div class="date">
                        <div class="month">
                            <%# GetMonth(DataBinder.Eval(Container.DataItem, "StartTime")) %></div>
                        <div class="day">
                            <%# GetDay(DataBinder.Eval(Container.DataItem, "StartTime"))%></div>
                        <div class="time">
                            <%# GetStartTime(DataBinder.Eval(Container.DataItem, "StartTime"))%></div>
                    </div>
                    <div class="sch-info">
                        <h1>
                            <%# DataBinder.Eval(Container.DataItem, "Title") %></h1>
                        <h2>
                            <%# DataBinder.Eval(Container.DataItem, "Description") %></h2>
                         <h3>
                            <%# DataBinder.Eval(Container.DataItem, "SpeakerName") %></h3>
                        <p>
                            <%# DataBinder.Eval(Container.DataItem, "AllDescription") %>
                        </p>
                    </div>
                    <div class="clear">
                    </div>
                    </div>--%>
            </ItemTemplate>
        </asp:Repeater>
         <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" 
             OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
             TypeName="BusinessLogicLayer.Components.Conference.ConferenceScheduleLogic">
             <SelectParameters>
                 <asp:Parameter DefaultValue="3" Name="programId" Type="Int32" />
                 <asp:Parameter DefaultValue="19" Name="day" Type="Int32" />
             </SelectParameters>
         </asp:ObjectDataSource>
     </div>
     <div id="abs3-2">
     <asp:Repeater runat="server" ID="Repeater5" 
             DataSourceID="ObjectDataSource5">
            <ItemTemplate>
            <div class='<%# GetMainClasses(DataBinder.Eval(Container.DataItem, "ScheduleSessionTypeId").ToString()) %>'>
        <div class="date">
        <div class="month"><%# GetMonth(DataBinder.Eval(Container.DataItem, "StartTime")) %></div>
        <div class="day"><%# GetDay(DataBinder.Eval(Container.DataItem, "StartTime"))%></div>
        <div class="time"><%# GetStartTime(DataBinder.Eval(Container.DataItem, "StartTime"))%> - <%# GetStartTime(DataBinder.Eval(Container.DataItem, "EndTime"))%></div>
        </div>
        <div class="sch-info">
        <div class="abs-icons ">
        <div class='<%# GetIconClasses(DataBinder.Eval(Container.DataItem, "ScheduleSessionTypeId").ToString()) %>'></div>
      </div>
          
          <h1><%# DataBinder.Eval(Container.DataItem, "Title") %></h1>
        <h3><%# DataBinder.Eval(Container.DataItem, "Description") %> </h3>
        <h2><%# DataBinder.Eval(Container.DataItem, "SpeakerName") %> </h2>
        <p><%# DataBinder.Eval(Container.DataItem, "AllDescription") %></p>
      </div>
        <div class="clear"></div>
    </div>
                <%--<div class="schedule">
                    <div class="date">
                        <div class="month">
                            <%# GetMonth(DataBinder.Eval(Container.DataItem, "StartTime")) %></div>
                        <div class="day">
                            <%# GetDay(DataBinder.Eval(Container.DataItem, "StartTime"))%></div>
                        <div class="time">
                            <%# GetStartTime(DataBinder.Eval(Container.DataItem, "StartTime"))%></div>
                    </div>
                    <div class="sch-info">
                        <h1>
                            <%# DataBinder.Eval(Container.DataItem, "Title") %></h1>
                        <h2>
                            <%# DataBinder.Eval(Container.DataItem, "Description") %></h2>
                         <h3>
                            <%# DataBinder.Eval(Container.DataItem, "SpeakerName") %></h3>
                        <p>
                            <%# DataBinder.Eval(Container.DataItem, "AllDescription") %>
                        </p>
                    </div>
                    <div class="clear">
                    </div>
                    </div>--%>
            </ItemTemplate>
        </asp:Repeater>
         <asp:ObjectDataSource ID="ObjectDataSource5" runat="server" 
             OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
             TypeName="BusinessLogicLayer.Components.Conference.ConferenceScheduleLogic">
             <SelectParameters>
                 <asp:Parameter DefaultValue="3" Name="programId" Type="Int32" />
                 <asp:Parameter DefaultValue="20" Name="day" Type="Int32" />
             </SelectParameters>
         </asp:ObjectDataSource>
     </div>
     <div id="abs3-3">
     <asp:Repeater runat="server" ID="Repeater6" 
             DataSourceID="ObjectDataSource5">
            <ItemTemplate>
            <div class='<%# GetMainClasses(DataBinder.Eval(Container.DataItem, "ScheduleSessionTypeId").ToString()) %>'>
        <div class="date">
        <div class="month"><%# GetMonth(DataBinder.Eval(Container.DataItem, "StartTime")) %></div>
        <div class="day"><%# GetDay(DataBinder.Eval(Container.DataItem, "StartTime"))%></div>
        <div class="time"><%# GetStartTime(DataBinder.Eval(Container.DataItem, "StartTime"))%> - <%# GetStartTime(DataBinder.Eval(Container.DataItem, "EndTime"))%></div>
        </div>
        <div class="sch-info">
        <div class="abs-icons ">
        <div class='<%# GetIconClasses(DataBinder.Eval(Container.DataItem, "ScheduleSessionTypeId").ToString()) %>'></div>
      </div>
          
          <h1><%# DataBinder.Eval(Container.DataItem, "Title") %></h1>
        <h3><%# DataBinder.Eval(Container.DataItem, "Description") %> </h3>
        <h2><%# DataBinder.Eval(Container.DataItem, "SpeakerName") %> </h2>
        <p><%# DataBinder.Eval(Container.DataItem, "AllDescription") %></p>
      </div>
        <div class="clear"></div>
    </div>
                <%--<div class="schedule">
                    <div class="date">
                        <div class="month">
                            <%# GetMonth(DataBinder.Eval(Container.DataItem, "StartTime")) %></div>
                        <div class="day">
                            <%# GetDay(DataBinder.Eval(Container.DataItem, "StartTime"))%></div>
                        <div class="time">
                            <%# GetStartTime(DataBinder.Eval(Container.DataItem, "StartTime"))%></div>
                    </div>
                    <div class="sch-info">
                        <h1>
                            <%# DataBinder.Eval(Container.DataItem, "Title") %></h1>
                        <h2>
                            <%# DataBinder.Eval(Container.DataItem, "Description") %></h2>
                         <h3>
                            <%# DataBinder.Eval(Container.DataItem, "SpeakerName") %></h3>
                        <p>
                            <%# DataBinder.Eval(Container.DataItem, "AllDescription") %>
                        </p>
                    </div>
                    <div class="clear">
                    </div>
                    </div>--%>
            </ItemTemplate>
        </asp:Repeater>
         <asp:ObjectDataSource ID="ObjectDataSource6" runat="server" 
             OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
             TypeName="BusinessLogicLayer.Components.Conference.ConferenceScheduleLogic">
             <SelectParameters>
                 <asp:Parameter DefaultValue="3" Name="programId" Type="Int32" />
                 <asp:Parameter DefaultValue="21" Name="day" Type="Int32" />
             </SelectParameters>
         </asp:ObjectDataSource>
     </div>
     </div>
</div>
 
</asp:Content>
