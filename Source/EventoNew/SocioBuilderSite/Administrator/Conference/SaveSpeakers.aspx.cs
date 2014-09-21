using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer.Entities.Conference;
using BusinessLogicLayer.Components.Conference;
using SocioBuilderSite.Code.RbmCommon;
using SocioBuilderSite.Code.RbmSecurity;

namespace SocioBuilderSite.BackendPortal.Conference
{
    public partial class SaveSpeakers : AdminBasePage
    {
        #region Members
        private int SpeakerID
        {
            get
            {
                try
                {
                    return Convert.ToInt32(Request.QueryString["ID"]);
                }
                catch
                {
                    return -1;
                }
            }
        }
        private int ParentID
        {
            get
            {
                try
                {
                    return Convert.ToInt32(Request.QueryString["ParentID"]);
                }
                catch
                {
                    return -1;
                }
            }
        }
        private ConferenceSpeakers SpeakerObj;
        private ConferenceSpeakersLanguage SpeakerLanguageObj;
        private ConferenceSpeakersLogic SpeakerLogicObj;
        private ConferenceSpeakersLanguageLogic SpeakerLogicLanguageObj;
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillControlsData();
                if (ParentID > 0)
                    trParent.Visible = true;
            }

        }

        private void FillControlsData()
        {

            cbConfernece.DataBind();
            cbAirLine.DataBind();
            cbHotel.DataBind();
            cbResponsiblePerson.DataBind();
            cbLanguage.DataBind();
            if (SpeakerID != -1 && SpeakerID != 0)
            {
                if (ParentID != -1 && ParentID != 0)
                {
                    SpeakerLogicLanguageObj = new ConferenceSpeakersLanguageLogic();
                    SpeakerLanguageObj = SpeakerLogicLanguageObj.GetByID(SpeakerID);
                    txtBio.Text = SpeakerLanguageObj.SpeakerBio;
                    txtFlightFromCity.Text = SpeakerLanguageObj.FlightFromCity;
                    txtFlightFromCountry.Text = SpeakerLanguageObj.FlightfromCountry;
                    txtFlightNumber.Text = SpeakerLanguageObj.FlightNO;
                    txtFlightToCity.Text = SpeakerLanguageObj.FlightToCity;
                    txtFlightToCountry.Text = SpeakerLanguageObj.FlightToCountry;
                    txtPosition.Text = SpeakerLanguageObj.SpeakerPosition;
                    if (cbAirLine.Items.FindByValue(SpeakerLanguageObj.AirllineID) != null)
                        cbAirLine.SelectedIndex = cbAirLine.Items.FindByValue(SpeakerLanguageObj.AirllineID).Index;
                    if (cbConfernece.Items.FindByValue(SpeakerLanguageObj.ConferenceId) != null)
                        cbConfernece.SelectedIndex = cbConfernece.Items.FindByValue(SpeakerLanguageObj.ConferenceId).Index;
                    if (cbHotel.Items.FindByValue(SpeakerLanguageObj.HotelID) != null)
                        cbHotel.SelectedIndex = cbHotel.Items.FindByValue(SpeakerLanguageObj.HotelID).Index;
                    if (cbResponsiblePerson.Items.FindByValue(SpeakerLanguageObj.ResponsiblePersonID) != null)
                        cbResponsiblePerson.SelectedIndex = cbResponsiblePerson.Items.FindByValue(SpeakerLanguageObj.ResponsiblePersonID).Index;
                    cbPMOrAMArrival.Value = SpeakerLanguageObj.ArrivalTimeAMorPM;
                    cbPMorAMDeprature.Value = SpeakerLanguageObj.DepratureTimeAMorPM;
                    
                    dtArrivalDate.Text = SpeakerLanguageObj.ArrivalDate != DateTime.MinValue ? SpeakerLanguageObj.ArrivalDate.ToShortDateString() : "";
                    dtArrivalTime.Text = SpeakerLanguageObj.ArrivalTime;
                    dtDepratureDate.Text = SpeakerLanguageObj.DepratureDate != DateTime.MinValue ? SpeakerLanguageObj.DepratureDate.ToShortDateString() : "";
                    dtDepratureTime.Text = SpeakerLanguageObj.DepratureTime;
                    dtRegisterartionDate.Text = SpeakerLanguageObj.DateRegistered != DateTime.MinValue ? SpeakerLanguageObj.DateRegistered.ToShortDateString() : "";
                    if (SpeakerLanguageObj.SpeakerImage != null && SpeakerLanguageObj.SpeakerImage != "")
                    {
                        imgSpeaker.ImageUrl = "~/ContentData/Sites/Conferences/" + SpeakerLanguageObj.SpeakerImage;
                        imgSpeaker.Visible = true;
                    }
                    txtName.Text = SpeakerLanguageObj.CurrentPerson.DisplayName;
                    if (cbLanguage.Items.FindByValue(SpeakerLanguageObj.LanguageID) != null)
                        cbLanguage.SelectedIndex = cbLanguage.Items.FindByValue(SpeakerLanguageObj.LanguageID).Index;
                    trParent.Visible = true;
                }
                else
                {
                    SpeakerLogicObj = new ConferenceSpeakersLogic();
                    SpeakerObj = SpeakerLogicObj.GetByID(SpeakerID);
                    txtBio.Text = SpeakerObj.SpeakerBio;
                    txtFlightFromCity.Text = SpeakerObj.FlightFromCity;
                    txtFlightFromCountry.Text = SpeakerObj.FlightfromCountry;
                    txtFlightNumber.Text = SpeakerObj.FlightNO;
                    txtFlightToCity.Text = SpeakerObj.FlightToCity;
                    txtFlightToCountry.Text = SpeakerObj.FlightToCountry;
                    txtPosition.Text = SpeakerObj.SpeakerPosition;
                    if (cbAirLine.Items.FindByValue(SpeakerObj.AirllineID) != null)
                        cbAirLine.SelectedIndex = cbAirLine.Items.FindByValue(SpeakerObj.AirllineID).Index;
                    if (cbConfernece.Items.FindByValue(SpeakerObj.ConferenceId) != null)
                        cbConfernece.SelectedIndex = cbConfernece.Items.FindByValue(SpeakerObj.ConferenceId).Index;
                    if (cbHotel.Items.FindByValue(SpeakerObj.HotelID) != null)
                        cbHotel.SelectedIndex = cbHotel.Items.FindByValue(SpeakerObj.HotelID).Index;
                    if (cbResponsiblePerson.Items.FindByValue(SpeakerObj.ResponsiblePersonID) != null)
                        cbResponsiblePerson.SelectedIndex = cbResponsiblePerson.Items.FindByValue(SpeakerObj.ResponsiblePersonID).Index;

                    cbPMOrAMArrival.Value = SpeakerObj.ArrivalTimeAMorPM;
                    cbPMorAMDeprature.Value = SpeakerObj.DepratureTimeAMorPM;
                    
                    dtArrivalDate.Text = SpeakerObj.ArrivalDate != DateTime.MinValue ? SpeakerObj.ArrivalDate.ToShortDateString() : "";
                    dtArrivalTime.Text = SpeakerObj.ArrivalTime;
                    dtDepratureDate.Text = SpeakerObj.DepratureDate != DateTime.MinValue ? SpeakerObj.DepratureDate.ToShortDateString() : "";
                    dtDepratureTime.Text = SpeakerObj.DepratureTime;
                    dtRegisterartionDate.Text = SpeakerObj.DateRegistered != DateTime.MinValue ? SpeakerObj.DateRegistered.ToShortDateString() : "";
                    if (SpeakerObj.SpeakerImage != null && SpeakerObj.SpeakerImage != "")
                    {
                        imgSpeaker.ImageUrl = "~/ContentData/Sites/Conferences/" + SpeakerObj.SpeakerImage;
                        imgSpeaker.Visible = true;
                    }
                    if(SpeakerObj.CurrentPerson != null)
                        txtName.Text = SpeakerObj.CurrentPerson.DisplayName;
                }
            }

        }
        private void GetFormValues()
        {
            if (ParentID != -1 && ParentID != 0)
            {
                if(SpeakerLanguageObj == null)
                    SpeakerLanguageObj = new ConferenceSpeakersLanguage();
                SpeakerLanguageObj.SpeakerBio = txtBio.Text;
                SpeakerLanguageObj.FlightFromCity = txtFlightFromCity.Text;
                SpeakerLanguageObj.FlightfromCountry = txtFlightFromCountry.Text;
                SpeakerLanguageObj.FlightNO = txtFlightNumber.Text;
                SpeakerLanguageObj.FlightToCity = txtFlightToCity.Text;
                SpeakerLanguageObj.FlightToCountry = txtFlightToCountry.Text;
                SpeakerLanguageObj.SpeakerPosition = txtPosition.Text;
                if (cbAirLine.SelectedIndex != -1)
                    SpeakerLanguageObj.AirllineID = Convert.ToInt32(cbAirLine.Value);
                if (cbConfernece.SelectedIndex != -1)
                    SpeakerLanguageObj.ConferenceId = Convert.ToInt32(cbConfernece.Value);
                if (cbHotel.SelectedIndex != -1)
                    SpeakerLanguageObj.HotelID = Convert.ToInt32(cbHotel.Value);
                SpeakerLanguageObj.ArrivalTimeAMorPM = cbPMOrAMArrival.Value.ToString();
                SpeakerLanguageObj.DepratureTimeAMorPM = cbPMorAMDeprature.Value.ToString();
                SpeakerLanguageObj.ResponsiblePersonID = Convert.ToInt32(cbResponsiblePerson.Value);
                SpeakerLanguageObj.ArrivalDate = dtArrivalDate.Text != "" ? Convert.ToDateTime(dtArrivalDate.Text) : DateTime.MinValue;
                SpeakerLanguageObj.ArrivalTime = dtArrivalTime.Text;
                SpeakerLanguageObj.DepratureDate = dtDepratureDate.Text != "" ? Convert.ToDateTime(dtDepratureDate.Text) : DateTime.MinValue;
                SpeakerLanguageObj.DepratureTime = dtDepratureTime.Text;
                SpeakerLanguageObj.DateRegistered = dtRegisterartionDate.Text != "" ? Convert.ToDateTime(dtRegisterartionDate.Text) : DateTime.MinValue;
                if (SpeakerImageUpload.UploadedFiles.Length > 0 && SpeakerImageUpload.UploadedFiles[0].FileName != "")
                {
                    if (SpeakerImageUpload.UploadedFiles[0].IsValid)
                    {
                        if (Tools.IsImage(SpeakerImageUpload.UploadedFiles[0].FileBytes))
                        {
                            SpeakerImageUpload.UploadedFiles[0].SaveAs(Server.MapPath("~/uploads/Speakers/") + SpeakerImageUpload.UploadedFiles[0].FileName);
                            SpeakerLanguageObj.SpeakerImage = "~/uploads/Speakers/" + SpeakerImageUpload.UploadedFiles[0].FileName;
                        }
                        else
                        {
                            BusinessLogicLayer.Components.UserMonitorLogic monitorLogic = new BusinessLogicLayer.Components.UserMonitorLogic();
                            string ipMain = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                            string IpForwardedFor = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                            string ip = String.Format("{0}-{1}", ipMain, IpForwardedFor);
                            int userid = 0;
                            if (SecurityManager.isLogged(this.Page))
                                userid = SecurityManager.getUser(this.Page).BusinessEntityId;
                            monitorLogic.Insert(userid, false, ip, SpeakerImageUpload.UploadedFiles[0].FileName, DateTime.Now);
                        }
                    }
                }
                SpeakerLanguageObj.LanguageID = Convert.ToInt32(cbLanguage.Value);
                SpeakerLanguageObj.ConferenceSpeakerParentId = ParentID;
            }
            else
            {
                if(SpeakerObj == null)
                    SpeakerObj = new ConferenceSpeakers();
                SpeakerObj.SpeakerBio = txtBio.Text;
                SpeakerObj.FlightFromCity = txtFlightFromCity.Text;
                SpeakerObj.FlightfromCountry = txtFlightFromCountry.Text;
                SpeakerObj.FlightNO = txtFlightNumber.Text;
                SpeakerObj.FlightToCity = txtFlightToCity.Text;
                SpeakerObj.FlightToCountry = txtFlightToCountry.Text;
                SpeakerObj.SpeakerPosition = txtPosition.Text;
                if (cbAirLine.SelectedIndex != -1)
                    SpeakerObj.AirllineID = Convert.ToInt32(cbAirLine.Value);
                if (cbConfernece.SelectedIndex != -1)
                    SpeakerObj.ConferenceId = Convert.ToInt32(cbConfernece.Value);
                if (cbHotel.SelectedIndex != -1)
                    SpeakerObj.HotelID = Convert.ToInt32(cbHotel.Value);
                SpeakerObj.ArrivalTimeAMorPM = cbPMOrAMArrival.Value.ToString();
                SpeakerObj.DepratureTimeAMorPM = cbPMorAMDeprature.Value.ToString();
                SpeakerObj.ResponsiblePersonID = Convert.ToInt32(cbResponsiblePerson.Value);
                SpeakerObj.ArrivalDate = dtArrivalDate.Text != "" ? Convert.ToDateTime(dtArrivalDate.Text) : DateTime.MinValue;
                SpeakerObj.ArrivalTime = dtArrivalTime.Text;
                SpeakerObj.DepratureDate = dtDepratureDate.Text != "" ? Convert.ToDateTime(dtDepratureDate.Text) : DateTime.MinValue;
                SpeakerObj.DepratureTime = dtDepratureTime.Text;
                SpeakerObj.DateRegistered = dtRegisterartionDate.Text != "" ? Convert.ToDateTime(dtRegisterartionDate.Text) : DateTime.MinValue;
                if (SpeakerImageUpload.UploadedFiles.Length > 0 && SpeakerImageUpload.UploadedFiles[0].FileName != "")
                {
                    SpeakerImageUpload.UploadedFiles[0].SaveAs(Server.MapPath("~/ContentData/Sites/Conferences/") + SpeakerImageUpload.UploadedFiles[0].FileName);
                    SpeakerObj.SpeakerImage =  SpeakerImageUpload.UploadedFiles[0].FileName;
                }
            }
        }
        void ResolveString(string name, out string title, out string firstName, out string middleName, out string lastName)
        {

            string[] split = name.Trim().Split(' ');
            title = "";
            firstName = "";
            middleName = "";
            lastName = "";
            if (split.Length > 0)
            {
                int startIndex = 1;
                if (split[0].StartsWith("Mr") || split[0].StartsWith("Ms") || split[0].StartsWith("Miss") || split[0].StartsWith("Dr") || split[0].StartsWith("Prof") || split[0].StartsWith("Sir") || split[0].StartsWith("أستاذ") || split[0].StartsWith("أستاذة") || split[0].StartsWith("د.") || split[0].StartsWith("د .") || split[0].StartsWith("دكتور") || split[0].StartsWith("دكتورة") || split[0].StartsWith("انسة") || split[0].StartsWith("أنسة") || split[0].StartsWith("مهندس") || split[0].StartsWith("م."))
                {
                    title = split[0];
                    if(split.Length >=2)
                        firstName = split[1];
                    startIndex = 2;
                }
                else
                {
                    title = "";
                    firstName = split[0];
                }
                middleName = "";
                for (int i = startIndex; i <= split.Length - 2; i++)
                {
                    middleName += split[i] + " ";
                }
                middleName = middleName.Trim();
                if(split.Length >=2)
                    lastName = split[split.Length - 1];
            }
        }

        private void SaveData()
        {
            string FirstName, MiddleName, LastName, Title;
            ResolveString(txtName.Text, out Title, out FirstName, out MiddleName, out LastName);
            int PersonID = 0;
            if (ParentID > 0)
            {
                SpeakerLanguageObj = SpeakerLogicLanguageObj.GetByID(SpeakerID);
                if (SpeakerLanguageObj != null)
                    PersonID = SpeakerLanguageObj.PersonId;
            }
            else
            {
                SpeakerObj = BusinessLogicLayer.Common.ConferenceSpeakersLogic.GetByID(SpeakerID);
                if (SpeakerObj != null)
                    PersonID = SpeakerObj.PersonId;
            }
             
            BusinessLogicLayer.Entities.Persons.Person p = BusinessLogicLayer.Common.PersonLogic.GetByID(PersonID);
            bool isNewPerson = false;
            if (p == null)
            {
                p = new BusinessLogicLayer.Entities.Persons.Person();
                p.CreatedDate = DateTime.Now;
                new BusinessLogicLayer.Components.Persons.PersonLogic().Insert(p);
                isNewPerson = true;
            }
            
            if (ParentID > 0)
            {
                //SpeakerLanguage
                
                GetFormValues();
                #region PersonLanguage 
                BusinessLogicLayer.Entities.Persons.PersonLanguages personLang = p.GetByLanguageID(SpeakerLanguageObj.LanguageID);
                personLang.Title = Title;
                personLang.FirstName = FirstName;
                personLang.MiddleName = MiddleName;
                personLang.LastName = LastName;
                personLang.DisplayName = txtName.Text;
                if (personLang.NewRecord)
                {
                    personLang.PersonId = p.BusinessEntityId;
                    personLang.LanguageId = Convert.ToInt32(BusinessLogicLayer.Common.DefaultLanguageId);
                    BusinessLogicLayer.Common.PersonLanguagesLogic.Insert(personLang);
                }
                else
                    BusinessLogicLayer.Common.PersonLanguagesLogic.Update(personLang, personLang.PersonLanguageId);
                #endregion

                if (SpeakerLanguageObj.NewRecord)
                {
                    SpeakerLanguageObj.PersonId = PersonID;
                    SpeakerLanguageObj.ConferenceSpeakerParentId = ParentID;
                    SpeakerLogicLanguageObj.Insert(SpeakerLanguageObj);
                }
                else
                {
                    
                    SpeakerLogicLanguageObj.Update(SpeakerLanguageObj, SpeakerLanguageObj.ConferenceSpeakerId);
                }
            }
            else
            {
                //Speaker
                
                GetFormValues();
                #region Person Information
                if (isNewPerson)
                {
                    SpeakerObj.PersonId = p.BusinessEntityId;
                    PersonID = SpeakerObj.PersonId;
                    BusinessLogicLayer.Common.ConferenceSpeakersLogic.Update(SpeakerObj, SpeakerObj.ConferenceSpeakerId);
                }
                BusinessLogicLayer.Entities.Persons.PersonLanguages personLang = p.GetByLanguageID(0);
                personLang.Title = Title;
                personLang.FirstName = FirstName;
                personLang.MiddleName = MiddleName;
                personLang.LastName = LastName;
                personLang.DisplayName = txtName.Text;
                if (personLang.NewRecord)
                {
                    personLang.PersonId = p.BusinessEntityId;
                    personLang.LanguageId = Convert.ToInt32(BusinessLogicLayer.Common.DefaultLanguageId);
                    BusinessLogicLayer.Common.PersonLanguagesLogic.Insert(personLang);
                }
                else
                    BusinessLogicLayer.Common.PersonLanguagesLogic.Update(personLang, personLang.PersonLanguageId);
                #endregion
                if (SpeakerObj.NewRecord)
                    BusinessLogicLayer.Common.ConferenceSpeakersLogic.Insert(SpeakerObj);
                else
                    BusinessLogicLayer.Common.ConferenceSpeakersLogic.Update(SpeakerObj, SpeakerObj.ConferenceSpeakerId);
            }
            Response.Redirect("ManageSpeakers.aspx");
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            //bool isSaved;
            //SpeakerObj = BusinessLogicLayer.Common.ConferenceSpeakersLogic.GetByID(SpeakerID);
            //GetFormValues();
            
            //BusinessLogicLayer.Components.Persons.PersonLanguagesLogic newPersonLanguagesLogic = new BusinessLogicLayer.Components.Persons.PersonLanguagesLogic();
            //SpeakerLogicObj = new ConferenceSpeakersLogic();
            //SpeakerLogicLanguageObj = new ConferenceSpeakersLanguageLogic();
            //if (SpeakerID != -1 && SpeakerID != 0)
            //{
            //    if (ParentID != -1 && ParentID != 0)
            //    {
            //        BusinessLogicLayer.Entities.Conference.ConferenceSpeakersLanguage csLang = SpeakerLogicLanguageObj.GetByID(SpeakerID);
            //        int PersonID = csLang.PersonId;
            //        int LanguageID = csLang.LanguageID;
            //        BusinessLogicLayer.Entities.Persons.Person person = BusinessLogicLayer.Common.PersonLogic.GetByID(PersonID);
                    
            //        BusinessLogicLayer.Entities.Persons.PersonLanguages personLang = null;
            //        if(person != null)
            //            personLang = person.GetByLanguageID(csLang.LanguageID);
            //        if (personLang == null || personLang.NewRecord)
            //        {
                        
            //            person.CreatedDate = DateTime.Now;
            //            new BusinessLogicLayer.Components.Persons.PersonLogic().Insert(person);
            //            personLang = new BusinessLogicLayer.Entities.Persons.PersonLanguages() { DisplayName = txtName.Text, PersonId = person.BusinessEntityId, LanguageId = 1 };
            //            newPersonLanguagesLogic.Insert(personLang);
            //            if (SpeakerLanguageObj != null)
            //                SpeakerLanguageObj.PersonId = person.BusinessEntityId;
            //        }
            //        personLang.Title = Title;
            //        personLang.FirstName = FirstName;
            //        personLang.MiddleName = MiddleName;
            //        personLang.LastName = LastName;
            //        personLang.DisplayName = txtName.Text;
            //        newPersonLanguagesLogic.Update(personLang, personLang.PersonLanguageId);
            //        SpeakerLanguageObj.PersonId = PersonID;
            //        isSaved = SpeakerLogicLanguageObj.Update(SpeakerLanguageObj, SpeakerID);

            //    }
            //    else
            //    {
            //        int PersonID = SpeakerObj.PersonId;
            //        BusinessLogicLayer.Entities.Persons.Person p = BusinessLogicLayer.Common.PersonLogic.GetByID(PersonID);
            //        if (p == null)
            //        {
            //            p = new BusinessLogicLayer.Entities.Persons.Person();
            //            p.CreatedDate = DateTime.Now;
            //            new BusinessLogicLayer.Components.Persons.PersonLogic().Insert(p);
            //            SpeakerObj.PersonId = p.BusinessEntityId;
            //            PersonID = SpeakerObj.PersonId;
            //            BusinessLogicLayer.Common.ConferenceSpeakersLogic.Update(SpeakerObj, SpeakerObj.ConferenceSpeakerId);
            //        }
            //        BusinessLogicLayer.Entities.Persons.PersonLanguages personLang = p.GetByLanguageID(0);
            //        //List<BusinessLogicLayer.Entities.Persons.PersonLanguages> plangs = newPersonLanguagesLogic.GetAllByPersonId(PersonID);
            //        //BusinessLogicLayer.Entities.Persons.PersonLanguages personLang = null;
            //        //if (plangs.Count > 0)
            //        //    personLang = plangs[0];
            //        if (personLang == null || personLang.NewRecord)
            //        {
            //            //BusinessLogicLayer.Entities.Persons.Person person = new BusinessLogicLayer.Entities.Persons.Person();
            //            //person.CreatedDate = DateTime.Now;
            //            //new BusinessLogicLayer.Components.Persons.PersonLogic().Insert(person);
            //            personLang.PersonId = p.BusinessEntityId;
            //            personLang.FirstName = FirstName;
            //            personLang.MiddleName = MiddleName;
            //            personLang.LastName = LastName;
            //            personLang.Title = Title;
            //            personLang.DisplayName = txtName.Text;
            //            personLang.LanguageId = Convert.ToInt32(BusinessLogicLayer.Common.DefaultLanguageId);
            //            //personLang = new BusinessLogicLayer.Entities.Persons.PersonLanguages() { DisplayName = txtName.Text, PersonId = person.BusinessEntityId, LanguageId = 1 };
            //            newPersonLanguagesLogic.Insert(personLang);
            //            if (SpeakerLanguageObj != null)
            //                SpeakerLanguageObj.PersonId = p.BusinessEntityId;
            //        }
            //        else
            //        {
            //            personLang.FirstName = FirstName;
            //            personLang.MiddleName = MiddleName;
            //            personLang.LastName = LastName;
            //            personLang.Title = Title;
            //            personLang.DisplayName = txtName.Text;
            //            newPersonLanguagesLogic.Update(personLang, personLang.PersonLanguageId);
            //        }
            //        SpeakerObj.PersonId = PersonID;
            //        isSaved = SpeakerLogicObj.Update(SpeakerObj, SpeakerID);
            //    }
            //}
            //else
            //{
            //    if (ParentID != -1 && ParentID != 0)
            //    {
            //        BusinessLogicLayer.Entities.Persons.Person person = new BusinessLogicLayer.Entities.Persons.Person();
            //        new BusinessLogicLayer.Components.Persons.PersonLogic().Insert(person);
            //        BusinessLogicLayer.Entities.Persons.PersonLanguages personLang = new BusinessLogicLayer.Entities.Persons.PersonLanguages() { DisplayName = txtName.Text, PersonId = person.BusinessEntityId, LanguageId = 1 };
            //        personLang.Title = Title;
            //        personLang.FirstName = FirstName;
            //        personLang.MiddleName = MiddleName;
            //        personLang.LastName = LastName;

            //        newPersonLanguagesLogic.Insert(personLang);
            //        if (SpeakerLanguageObj != null)
            //            SpeakerLanguageObj.PersonId = person.BusinessEntityId;
            //        isSaved = SpeakerLogicLanguageObj.Insert(SpeakerLanguageObj);
            //    }
            //    else
            //    {
            //        BusinessLogicLayer.Entities.Persons.Person person = new BusinessLogicLayer.Entities.Persons.Person();
            //        new BusinessLogicLayer.Components.Persons.PersonLogic().Insert(person);
            //        BusinessLogicLayer.Entities.Persons.PersonLanguages personLang = new BusinessLogicLayer.Entities.Persons.PersonLanguages() { DisplayName = txtName.Text, PersonId = person.BusinessEntityId, LanguageId = 1 };
            //        personLang.Title = Title;
            //        personLang.FirstName = FirstName;
            //        personLang.MiddleName = MiddleName;
            //        personLang.LastName = LastName;
            //        newPersonLanguagesLogic.Insert(personLang);
            //        SpeakerObj.PersonId = person.BusinessEntityId;
            //        isSaved = SpeakerLogicObj.Insert(SpeakerObj);
            //    }
            //}
            //if (isSaved)
            //    Response.Redirect("ManageSpeakers.aspx");
        }
    }
}