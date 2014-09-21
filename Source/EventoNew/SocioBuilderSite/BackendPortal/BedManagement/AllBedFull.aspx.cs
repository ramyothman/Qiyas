using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocioBuilderSite.BackendPortal.BedManagement
{
    public partial class AllBedFull : System.Web.UI.Page
    {
        public List<BusinessLogicLayer.Entities.BedManagement.Ward> CurrentWards
        {
            set { Session["CurrentWards"] = value; }
            get
            {
                if (Session["CurrentWards"] == null)
                {
                    Session["CurrentWards"] = BusinessLogicLayer.Common.WardLogic.GetAll();
                    BusinessLogicLayer.Common.WardRoomLogic.GetAllWardRoomDetails(Session["CurrentWards"] as List<BusinessLogicLayer.Entities.BedManagement.Ward>);
                }
                return Session["CurrentWards"] as List<BusinessLogicLayer.Entities.BedManagement.Ward>;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        public string GetColor(string color)
        {
            return "background-color:" + color;
        }

        public string ViewTypeMale(string type)
        {
            if (type == "M")
                return "block";
            else return "none";
        }

        public string ViewTypeFemale(string type)
        {
            if (type == "F")
                return "block";
            else return "none";
        }
        public string GetSpeciality(string specialities)
        {
            string[] split = specialities.Split('+');
            Random random = new Random();
            int r = random.Next(split.Length);
            string result = "";
            if (split[r].Length > 4)
                result = split[r].Substring(0, 4);
            else
                result = split[r];
            return result;
        }
        public string GeToolTip(string wardCode, string bedCode, string speciality, string bedtype)
        {
            //var ward = from n in CurrentWards
            //           where n.WardId == wardId
            //           select n;
            string bedTypeString = "";
            switch (bedtype)
            {
                case "O":
                    bedTypeString = "Occupied";
                    break;
                case "U":
                    bedTypeString = "Un Occupied";
                    break;
                case "C":
                    bedTypeString = "Closed";
                    break;
            }
            string patientInformation = "There is no patient information available";
            if (bedtype == "O")
            {
                patientInformation = "Ramy Mohamed Mostafa - Age:26 - Gender: M -  Consultant: Dr. Hussein Zanoon";
            }
            string tooltip = string.Format("{0} ({1}) {2} [{3}] - {4}", wardCode, bedCode, speciality, bedTypeString, patientInformation);

            return tooltip;

        }

        public string GetClassForTD(bool isNew, bool isPrivate, string bedType, int bedpercentage)
        {
            string result = "tooltip ";
            if (bedType == "C")
            {
                result += " rbm-bedmanagement-closed";
            }
            else if (bedType == "U")
                result += "";
            else if (bedType == "O")
            {
                result += "";
                if (bedpercentage >= 0 && bedpercentage < 66)
                    result += " rbm-bedmanagement-greenstatus";
                else if (bedpercentage < 91)
                    result += " rbm-bedmanagement-yellowstatus";
                else
                    result += " rbm-bedmanagement-redstatus";
            }
            return result;
        }
    }
}