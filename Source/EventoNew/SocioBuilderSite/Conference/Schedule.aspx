<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoMain.Master" AutoEventWireup="true" CodeBehind="Schedule.aspx.cs" Inherits="SocioBuilderSite.Conference.Schedule" %>

<%@ Register Assembly="DevExpress.Web.ASPxScheduler.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxScheduler" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.XtraScheduler.v14.1.Core, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraScheduler" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1><asp:Literal ID="TitleLiteral" runat="server" Text='<%$Resources:ConferenceFront, SchedulerSectionHeader %>'></asp:Literal>
    </h1>
<div class="content-all">
    <dx:aspxscheduler ID="ASPxScheduler1" runat="server" Width="100%" ActiveViewType="Day"
        Start="2012-02-19"  ClientInstanceName="ASPxClientScheduler1" 
        AppointmentDataSourceID="ScheduleObjectDS" 
        ResourceDataSourceID="ProgramsObjectDS">
        <Views>
            <DayView>
                <TimeRulers>
                    <dx:TimeRuler />
                </TimeRulers>
            </DayView>
            <WorkWeekView Enabled="False">
                <TimeRulers>
                    <dx:TimeRuler />
                </TimeRulers>
            </WorkWeekView>
            <WeekView Enabled="False" />
            <MonthView Enabled="False" />
            <TimelineView Enabled="False">
            </TimelineView>
        </Views>
        <OptionsBehavior ShowViewSelector="False" />
        <Storage EnableReminders="false" >
            <Appointments>
                <Mappings AllDay="IsAllDay" AppointmentId="ScheduleId" 
                    Description="Description" End="EndTime" Label="SpeakerName" 
                    Location="ConferenceHallName" ResourceId="ScheduleSessionTypeId" 
                    Start="StartTime" Subject="Title" Type="ConferenceProgramId" />
            </Appointments>
        </Storage>
    </dx:aspxscheduler>
			
    <asp:ObjectDataSource ID="ScheduleObjectDS" runat="server" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
        TypeName="BusinessLogicLayer.Components.Conference.ConferenceScheduleLogic">
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ProgramsObjectDS" runat="server" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
        TypeName="BusinessLogicLayer.Components.Conference.ScheduleSessionTypeLogic">
    </asp:ObjectDataSource>
			
    <div class="clear">
    </div>
</div>
				<div class="clear"></div>
</asp:Content>
