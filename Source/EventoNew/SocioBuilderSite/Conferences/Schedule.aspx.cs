using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.Conferences
{
    public partial class Schedule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request["Program"]))
            {
                int program = 0;
                Int32.TryParse(Request["Program"], out program);
                switch (program)
                {
                    case 1:
                        Program1.Visible = true;
                        Program2.Visible = false;
                        Program3.Visible = false;
                        break;
                    case 2:
                        Program1.Visible = false;
                        Program2.Visible = true;
                        Program3.Visible = false;
                        break;
                    case 3:
                        Program1.Visible = false;
                        Program2.Visible = false;
                        Program3.Visible = true;
                        break;
                }


            }
        }

        public string GetIconClasses(string typeid)
        {
            
            string result =  "";
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
            
            string result =  "schedule";
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