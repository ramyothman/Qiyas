using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using System.Linq.Expressions;
namespace SocioBuilderSite.Conference
{
    public partial class Schedules : Code.RbmCommon.ConferenceBasePage
    {
        public class ConferenceDay
        {
            public int DayNumber;
            public DateTime DayDate;
        }
        public BusinessLogicLayer.Entities.Conference.Conferences CurrentConference
        {
            get
            {
                return Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this.Page);
            }
        }
        BusinessLogicLayer.Entities.Conference.ConferencePrograms _CurrentProgram;
        public BusinessLogicLayer.Entities.Conference.ConferencePrograms CurrentProgram
        {
            get
            {
                if (_CurrentProgram == null)
                {
                    int id = 0;
                    if (!string.IsNullOrEmpty(Request["program"]))
                    {
                        Int32.TryParse(Request["program"], out id);
                        _CurrentProgram = new BusinessLogicLayer.Components.Conference.ConferenceProgramsLogic().GetByID(id);
                    }
                    else
                    {
                        List<BusinessLogicLayer.Entities.Conference.ConferencePrograms> programs = new BusinessLogicLayer.Components.Conference.ConferenceProgramsLogic().GetAllByConferenceId(CurrentConference.ConferenceId);
                        if (programs.Count > 0)
                        {
                            _CurrentProgram = programs[0];
                        }
                    }
                    if (_CurrentProgram == null)
                        _CurrentProgram = new BusinessLogicLayer.Entities.Conference.ConferencePrograms();
                }
                return _CurrentProgram;
            }
        }
        List<BusinessLogicLayer.Entities.Conference.ConferenceSchedule> _CurrentSchedule;
        public List<BusinessLogicLayer.Entities.Conference.ConferenceSchedule> CurrentSchedule
        {
            get
            {
                if (_CurrentSchedule == null)
                {
                    _CurrentSchedule = new BusinessLogicLayer.Components.Conference.ConferenceScheduleLogic().GetAll(CurrentProgram.ConferenceProgramId);
                }
                return _CurrentSchedule;
            }
        }

        List<ConferenceDay> _ConferenceDays;
        public List<ConferenceDay> ConferenceDays
        {
            get
            {
                if (_ConferenceDays == null)
                {
                    _ConferenceDays = new List<ConferenceDay>();
                    var days = (from x in CurrentSchedule select x.StartTime.Date).Distinct();
                    //var daysDistinct = (from x in days select x).Distinct();
                    foreach (DateTime day in days)
                    {
                        TimeSpan span = day - CurrentConference.StartDate;
                        ConferenceDay cday = new ConferenceDay();
                        cday.DayNumber = span.Days;
                        cday.DayDate = day.Date;
                        _ConferenceDays.Add(cday);
                    }   
                }
                return _ConferenceDays;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                _ConferenceDays = null;
                _CurrentProgram = null;
                _CurrentSchedule = null;
                foreach (ConferenceDay day in ConferenceDays)
                {
                    DevExpress.Web.ASPxTabControl.TabPage tabPage = new DevExpress.Web.ASPxTabControl.TabPage();
                    tabPage.Text = "Day " + day.DayNumber;
                    PlaceHolder ph = new PlaceHolder();
                    #region controls
                    string result = @"<div class=""abs-schedule"">";
                    
                    var sched = from x in CurrentSchedule where x.StartTime.Date == day.DayDate select x;
                    foreach(BusinessLogicLayer.Entities.Conference.ConferenceSchedule item in sched)
                    {
                        result += String.Format(@"<div class='{0}'>
                                                                  <div class=""date-schedule"">
                                          <div class=""month-schedule"">{1}</div>
                                          <div class=""day-schedule"">{2}</div>
                                          <div class=""time-schedule"">{3} - {4}</div>
                                          </div>
                                          <div class=""sch-info"">
                                          <div class=""abs-icons "">
                                          <div class='{5}'></div>
                                        </div>  
                                            <h1>{6}</h1>
                                          <h3>{7}</h3>
                                          <h2>{8}</h2>
                                          <p>{9}</p>
                                        </div>
                                          <div class=""clear""></div>
                                      </div>", GetMainClasses(item.ScheduleSessionTypeId.ToString()), GetMonth(item.StartTime), GetDay(item.StartTime), GetStartTime(item.StartTime), GetStartTime(item.EndTime), GetIconClasses(item.ScheduleSessionTypeId.ToString()), item.Title, item.Description, item.SpeakerName, item.AllDescription);
                    }
                    
                    result += "</div>";
                    #endregion
                    ph.Controls.Add(new LiteralControl(result));
                    tabPage.Controls.Add(ph);
                    schedulePageControl.TabPages.Add(tabPage);
                }
            }
            //BusinessLogicLayer.Entities.Conference.ConferenceSchedule 
        }


        public string GetIconClasses(string typeid)
        {

            string result = "";
            switch (typeid)
            {
                case "6":
                    result += "abs-register";
                    break;
                case "2":
                    result += "abs-break";
                    break;
                case "1":
                    result += "abs-session";
                    break;
                case "3":
                    result += "abs-discussion";
                    break;
            }
            return result;
        }
        public string GetMainClasses(string typeid)
        {

            string result = "schedule";
            switch (typeid)
            {
                case "6":
                    result += " bg-register";
                    break;
                case "2":
                    result += " bg-break";
                    break;
                case "1":
                    result += " bg-session";
                    break;
                case "3":
                    result += " bg-discussion";
                    break;

            }
            return result;
        }
        public string GetMonth(object x)
        {
            DateTime dt = DateTime.MinValue;
            DateTime.TryParse(x.ToString(), out dt);
            string result = "October";
            result = dt.ToString("MMMM");
            return result;
        }

        public string GetStartTime(object x)
        {
            DateTime dt = DateTime.MinValue;
            DateTime.TryParse(x.ToString(), out dt);
            string result = "October";
            result = dt.ToString("HH:mm");
            return result;
        }

        public string GetDay(object x)
        {
            DateTime dt = DateTime.MinValue;
            DateTime.TryParse(x.ToString(), out dt);
            string result = "10";
            result = dt.ToString("dd");
            return result;
        }
    }
}