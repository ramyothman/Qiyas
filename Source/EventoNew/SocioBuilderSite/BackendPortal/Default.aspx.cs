using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;

namespace SocioBuilderSite.BackendPortal
{
    [DataObject(true)]
    public class PatientPendingAdmission
    {
       
        private string _Code;
         [DataObjectField(true)]
        public string Code
        {
            get { return _Code; }
            set
            {
                _Code = value;
            }
        }
        
        
        private string _PatientName;
        [DataObjectField(false)]
        public string PatientName
        {
            get { return _PatientName; }
            set
            {
                _PatientName = value;
            }
        }
        
        
        private string _Speciality;
        [DataObjectField(false)]
        public string Speciality
        {
            get { return _Speciality; }
            set
            {
                _Speciality = value;
            }
        }

        private string _Ward;
        [DataObjectField(false)]
        public string Ward
        {
            get { return _Ward; }
            set
            {
                _Ward = value;
            }
        }

        private string _Room;
        [DataObjectField(false)]
        public string Room
        {
            get { return _Room; }
            set
            {
                _Room = value;
            }
        }

        private string _Bed;
        [DataObjectField(false)]
        public string Bed
        {
            get { return _Bed; }
            set
            {
                _Bed = value;
            }
        }
        
        
        public PatientPendingAdmission(string c, string pname, string s)
        {
            Code = c;
            PatientName = pname;
            Speciality = s;
        }
        public PatientPendingAdmission(string c, string pname, string s,string w,string r,string b)
        {
            Code = c;
            PatientName = pname;
            Speciality = s;
            Ward = w;
            Room = r;
            Bed = b;
        }

    }
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<PatientPendingAdmission> patientpending = new List<PatientPendingAdmission>();
            patientpending.Add(new PatientPendingAdmission("ABC001", "Mohamed Mostafa", "Surgery"));
            patientpending.Add(new PatientPendingAdmission("ABC020", "Abullah Hussein", "Emergency"));
            patientpending.Add(new PatientPendingAdmission("ABC204", "Ahmed Hassanein", "Neuro"));
           

            List<PatientPendingAdmission> patientpendingDischarge = new List<PatientPendingAdmission>();
            patientpendingDischarge.Add(new PatientPendingAdmission("ABC001", "Mohamed Mostafa", "Surgery","A11","Room 1","1"));
            patientpendingDischarge.Add(new PatientPendingAdmission("ABC020", "Abullah Hussein", "Emergency", "B24", "Room 3", "4"));
            patientpendingDischarge.Add(new PatientPendingAdmission("ABC204", "Ahmed Hassanein", "Neuro", "C21", "Room 2", "3"));
            

        }
    }
}