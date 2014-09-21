using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Conference.Controls
{
    public partial class TopDateControl : System.Web.UI.UserControl
    {
        public BusinessLogicLayer.Entities.Conference.Conferences CurrentConference
        {
            get
            {
                return Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this.Page);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               if (Session["LanguageId"].ToString() == "2")
                {
                    string hijri = Code.RbmCommon.ConferenceBasePage.GregToHijri(CurrentConference.EndDate);
                    
                    string hijriStart = Code.RbmCommon.ConferenceBasePage.GregToHijri(CurrentConference.StartDate);
                    string []datesplit = hijri.Split('/');
                    string day = Code.RbmCommon.ConferenceBasePage.TranslateNumerals(datesplit[0]);
                    string month = Code.RbmCommon.ConferenceBasePage.TranslateNumerals(datesplit[1]);
                    
                    string year = Code.RbmCommon.ConferenceBasePage.TranslateNumerals(datesplit[2]);
                    datesplit = hijriStart.Split('/');
                    string dayStart = Code.RbmCommon.ConferenceBasePage.TranslateNumerals(datesplit[0]);
                    string monthStart = Code.RbmCommon.ConferenceBasePage.TranslateNumerals(datesplit[1]);
                    System.Globalization.UmAlQuraCalendar calHijri = new System.Globalization.UmAlQuraCalendar();
                    System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("ar-sa");
                    cultureInfo.DateTimeFormat.Calendar = calHijri;



                    string MonthName = cultureInfo.DateTimeFormat.MonthNames[Convert.ToInt32(datesplit[1]) - 1];
                    string yearStart = Code.RbmCommon.ConferenceBasePage.TranslateNumerals(datesplit[2]);
                    confMonthYearSpan.InnerText = String.Format("{0} {1}", MonthName, year);
                    if (CurrentConference.StartDate.Day != CurrentConference.EndDate.Day)
                        confDateLiteral.Text = String.Format("{0}-{1}", dayStart, day);
                    else
                        confDateLiteral.Text = String.Format("{0}", dayStart);
                }
                else
                {
                    confMonthYearSpan.InnerText = String.Format("{0:MMM} {1}", CurrentConference.EndDate, CurrentConference.EndDate.Year);
                    if (CurrentConference.StartDate.Day != CurrentConference.EndDate.Day)
                        confDateLiteral.Text = String.Format("{0}-{1}", CurrentConference.StartDate.Day, CurrentConference.EndDate.Day);
                    else
                        confDateLiteral.Text = String.Format("{0}", CurrentConference.StartDate.Day);
                }
            
            }
            //confDateEndLiteral.Text = CurrentConference.
            BusinessLogicLayer.Entities.Conference.ConferencesLanguage confLanguage = CurrentConference.GetConferenceByLanguageId(Code.RbmCommon.ConferenceBasePage.GetCurrentPageLanguageId(this.Page));
            if (confLanguage != null)
            {
                confNameParagraph.InnerText = confLanguage.ConferenceName;
            }
            else
            {
                confNameParagraph.InnerText = CurrentConference.ConferenceName;
            }
        }
    }
}