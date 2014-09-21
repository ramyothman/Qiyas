using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer.Entities.Conference;
using BusinessLogicLayer.Components.Conference;

namespace SocioBuilderSite.BackendPortal.Conference
{
    public partial class SaveInvitedGuests : AdminBasePage
    {
        #region Members
        private int ID
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
        private InvitedGuests InvitedGuestsObj;
        private InvitedGuestsLogic InvitedGuestsLogicObj;
        private InvitedGuestsLanguage InvitedGuestsLanguageObj;
        private InvitedGuestsLanguageLogic InvitedGuestsLogicLanguageObj;
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

            if (ID != -1 && ID != 0)
            {
                if (ParentID != -1 && ParentID != 0)
                {
                    InvitedGuestsLogicLanguageObj = new InvitedGuestsLanguageLogic();
                    InvitedGuestsLanguageObj = InvitedGuestsLogicLanguageObj.GetByID(ID);
                    txtBio.Text = InvitedGuestsLanguageObj.SpeakerBio;
                    txtFlightFromCity.Text = InvitedGuestsLanguageObj.FlightFromCity;
                    txtFlightFromCountry.Text = InvitedGuestsLanguageObj.FlightfromCountry;
                    txtFlightNumber.Text = InvitedGuestsLanguageObj.FlightNO;
                    txtFlightToCity.Text = InvitedGuestsLanguageObj.FlightToCity;
                    txtFlightToCountry.Text = InvitedGuestsLanguageObj.FlightToCountry;
                    txtPosition.Text = InvitedGuestsLanguageObj.SpeakerPosition;
                    cbAirLine.Value = InvitedGuestsLanguageObj.AirllineID;
                    cbConfernece.Value = InvitedGuestsLanguageObj.ConferenceId;
                    cbHotel.Value = InvitedGuestsLanguageObj.HotelID;
                    cbPMOrAMArrival.Value = InvitedGuestsLanguageObj.ArrivalTimeAMorPM;
                    cbPMorAMDeprature.Value = InvitedGuestsLanguageObj.DepratureTimeAMorPM;
                    cbResponsiblePerson.Value = InvitedGuestsLanguageObj.ResponsiblePersonID;
                    dtArrivalDate.Text = InvitedGuestsLanguageObj.ArrivalDate != DateTime.MinValue ? InvitedGuestsLanguageObj.ArrivalDate.ToShortDateString() : "";
                    dtArrivalTime.Text = InvitedGuestsLanguageObj.ArrivalTime;
                    dtDepratureDate.Text = InvitedGuestsLanguageObj.DepratureDate != DateTime.MinValue ? InvitedGuestsLanguageObj.DepratureDate.ToShortDateString() : "";
                    dtDepratureTime.Text = InvitedGuestsLanguageObj.DepratureTime;
                    dtRegisterartionDate.Text = InvitedGuestsLanguageObj.DateRegistered != DateTime.MinValue ? InvitedGuestsLanguageObj.DateRegistered.ToShortDateString() : "";
                    if (InvitedGuestsLanguageObj.SpeakerImage != null && InvitedGuestsLanguageObj.SpeakerImage != "")
                    {
                        imgSpeaker.ImageUrl = InvitedGuestsLanguageObj.SpeakerImage;
                        imgSpeaker.Visible = true;
                    }
                    txtName.Text = InvitedGuestsLanguageObj.CurrentPerson.DisplayName;
                    cbLanguage.Value = InvitedGuestsLanguageObj.LanguageID;
                }
                else
                {
                    InvitedGuestsLogicObj = new InvitedGuestsLogic();
                    InvitedGuestsObj = InvitedGuestsLogicObj.GetByID(ID);
                    txtBio.Text = InvitedGuestsObj.SpeakerBio;
                    txtFlightFromCity.Text = InvitedGuestsObj.FlightFromCity;
                    txtFlightFromCountry.Text = InvitedGuestsObj.FlightfromCountry;
                    txtFlightNumber.Text = InvitedGuestsObj.FlightNO;
                    txtFlightToCity.Text = InvitedGuestsObj.FlightToCity;
                    txtFlightToCountry.Text = InvitedGuestsObj.FlightToCountry;
                    txtPosition.Text = InvitedGuestsObj.SpeakerPosition;
                    cbAirLine.Value = InvitedGuestsObj.AirllineID;
                    cbConfernece.Value = InvitedGuestsObj.ConferenceId;
                    cbHotel.Value = InvitedGuestsObj.HotelID;
                    cbPMOrAMArrival.Value = InvitedGuestsObj.ArrivalTimeAMorPM;
                    cbPMorAMDeprature.Value = InvitedGuestsObj.DepratureTimeAMorPM;
                    cbResponsiblePerson.Value = InvitedGuestsObj.ResponsiblePersonID;
                    dtArrivalDate.Text = InvitedGuestsObj.ArrivalDate != DateTime.MinValue ? InvitedGuestsObj.ArrivalDate.ToShortDateString() : "";
                    dtArrivalTime.Text = InvitedGuestsObj.ArrivalTime;
                    dtDepratureDate.Text = InvitedGuestsObj.DepratureDate != DateTime.MinValue ? InvitedGuestsObj.DepratureDate.ToShortDateString() : "";
                    dtDepratureTime.Text = InvitedGuestsObj.DepratureTime;
                    dtRegisterartionDate.Text = InvitedGuestsObj.DateRegistered != DateTime.MinValue ? InvitedGuestsObj.DateRegistered.ToShortDateString() : "";
                    if (InvitedGuestsObj.SpeakerImage != null && InvitedGuestsObj.SpeakerImage != "")
                    {
                        imgSpeaker.ImageUrl = InvitedGuestsObj.SpeakerImage;
                        imgSpeaker.Visible = true;
                    }
                    txtName.Text = InvitedGuestsObj.CurrentPerson.DisplayName;
                }
            }
        }
        private void GetFormValues()
        {
            if (ParentID != -1 && ParentID != 0)
            {
                InvitedGuestsLanguageObj = new InvitedGuestsLanguage();
                InvitedGuestsLanguageObj.SpeakerBio = txtBio.Text;
                InvitedGuestsLanguageObj.FlightFromCity = txtFlightFromCity.Text;
                InvitedGuestsLanguageObj.FlightfromCountry = txtFlightFromCountry.Text;
                InvitedGuestsLanguageObj.FlightNO = txtFlightNumber.Text;
                InvitedGuestsLanguageObj.FlightToCity = txtFlightToCity.Text;
                InvitedGuestsLanguageObj.FlightToCountry = txtFlightToCountry.Text;
                InvitedGuestsLanguageObj.SpeakerPosition = txtPosition.Text;
                if (cbAirLine.SelectedIndex != -1)
                    InvitedGuestsLanguageObj.AirllineID = Convert.ToInt32(cbAirLine.Value);
                if (cbConfernece.SelectedIndex != -1)
                    InvitedGuestsLanguageObj.ConferenceId = Convert.ToInt32(cbConfernece.Value);
                if (cbHotel.SelectedIndex != -1)
                    InvitedGuestsLanguageObj.HotelID = Convert.ToInt32(cbHotel.Value);
                InvitedGuestsLanguageObj.ArrivalTimeAMorPM = cbPMOrAMArrival.Value.ToString();
                InvitedGuestsLanguageObj.DepratureTimeAMorPM = cbPMorAMDeprature.Value.ToString();
                InvitedGuestsLanguageObj.ResponsiblePersonID = Convert.ToInt32(cbResponsiblePerson.Value);
                InvitedGuestsLanguageObj.ArrivalDate = dtArrivalDate.Text != "" ? Convert.ToDateTime(dtArrivalDate.Text) : DateTime.MinValue;
                InvitedGuestsLanguageObj.ArrivalTime = dtArrivalTime.Text;
                InvitedGuestsLanguageObj.DepratureDate = dtDepratureDate.Text != "" ? Convert.ToDateTime(dtDepratureDate.Text) : DateTime.MinValue;
                InvitedGuestsLanguageObj.DepratureTime = dtDepratureTime.Text;
                InvitedGuestsLanguageObj.DateRegistered = dtRegisterartionDate.Text != "" ? Convert.ToDateTime(dtRegisterartionDate.Text) : DateTime.MinValue;
                if (SpeakerImageUpload.UploadedFiles.Length > 0 && SpeakerImageUpload.UploadedFiles[0].FileName != "")
                {
                    SpeakerImageUpload.UploadedFiles[0].SaveAs(Server.MapPath("~/uploads/InvitedGuests/") + SpeakerImageUpload.UploadedFiles[0].FileName);
                    InvitedGuestsLanguageObj.SpeakerImage = "~/uploads/InvitedGuests/" + SpeakerImageUpload.UploadedFiles[0].FileName;
                }
                InvitedGuestsLanguageObj.LanguageID = Convert.ToInt32(cbLanguage.Value);
                InvitedGuestsLanguageObj.parentID = ParentID;

            }
            else
            {
                InvitedGuestsObj = new InvitedGuests();
                InvitedGuestsObj.SpeakerBio = txtBio.Text;
                InvitedGuestsObj.FlightFromCity = txtFlightFromCity.Text;
                InvitedGuestsObj.FlightfromCountry = txtFlightFromCountry.Text;
                InvitedGuestsObj.FlightNO = txtFlightNumber.Text;
                InvitedGuestsObj.FlightToCity = txtFlightToCity.Text;
                InvitedGuestsObj.FlightToCountry = txtFlightToCountry.Text;
                InvitedGuestsObj.SpeakerPosition = txtPosition.Text;
                if (cbAirLine.SelectedIndex != -1)
                    InvitedGuestsObj.AirllineID = Convert.ToInt32(cbAirLine.Value);
                if (cbConfernece.SelectedIndex != -1)
                    InvitedGuestsObj.ConferenceId = Convert.ToInt32(cbConfernece.Value);
                if (cbHotel.SelectedIndex != -1)
                    InvitedGuestsObj.HotelID = Convert.ToInt32(cbHotel.Value);
                InvitedGuestsObj.ArrivalTimeAMorPM = cbPMOrAMArrival.Value.ToString();
                InvitedGuestsObj.DepratureTimeAMorPM = cbPMorAMDeprature.Value.ToString();
                InvitedGuestsObj.ResponsiblePersonID = Convert.ToInt32(cbResponsiblePerson.Value);
                InvitedGuestsObj.ArrivalDate = dtArrivalDate.Text != "" ? Convert.ToDateTime(dtArrivalDate.Text) : DateTime.MinValue;
                InvitedGuestsObj.ArrivalTime = dtArrivalTime.Text;
                InvitedGuestsObj.DepratureDate = dtDepratureDate.Text != "" ? Convert.ToDateTime(dtDepratureDate.Text) : DateTime.MinValue;
                InvitedGuestsObj.DepratureTime = dtDepratureTime.Text;
                InvitedGuestsObj.DateRegistered = dtRegisterartionDate.Text != "" ? Convert.ToDateTime(dtRegisterartionDate.Text) : DateTime.MinValue;
                if (SpeakerImageUpload.UploadedFiles.Length > 0 && SpeakerImageUpload.UploadedFiles[0].FileName != "")
                {
                    SpeakerImageUpload.UploadedFiles[0].SaveAs(Server.MapPath("~/uploads/InvitedGuests/") + SpeakerImageUpload.UploadedFiles[0].FileName);
                    InvitedGuestsObj.SpeakerImage = "~/uploads/InvitedGuests/" + SpeakerImageUpload.UploadedFiles[0].FileName;
                }
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            bool isSaved;
            GetFormValues();
            BusinessLogicLayer.Components.Persons.PersonLanguagesLogic newPersonLanguagesLogic = new BusinessLogicLayer.Components.Persons.PersonLanguagesLogic();
            InvitedGuestsLogicObj = new InvitedGuestsLogic();
            InvitedGuestsLogicLanguageObj = new InvitedGuestsLanguageLogic();
            if (ID != -1 && ID != 0)
            {
                if (ParentID != -1 && ParentID != 0)
                {
                    int PersonID = InvitedGuestsLogicObj.GetByID(ID).PersonId;
                    BusinessLogicLayer.Entities.Persons.PersonLanguages personLang = newPersonLanguagesLogic.GetAllByPersonId(PersonID)[0];
                    personLang.DisplayName = txtName.Text;
                    newPersonLanguagesLogic.Update(personLang, personLang.PersonLanguageId);
                    InvitedGuestsLanguageObj.PersonId = PersonID;
                    isSaved = InvitedGuestsLogicLanguageObj.Update(InvitedGuestsLanguageObj, ID);
                }
                else
                {
                    int PersonID = InvitedGuestsLogicObj.GetByID(ID).PersonId;
                    BusinessLogicLayer.Entities.Persons.PersonLanguages personLang = newPersonLanguagesLogic.GetAllByPersonId(PersonID)[0];
                    personLang.DisplayName = txtName.Text;
                    newPersonLanguagesLogic.Update(personLang, personLang.PersonLanguageId);
                    InvitedGuestsObj.PersonId = PersonID;
                    isSaved = InvitedGuestsLogicObj.Update(InvitedGuestsObj, ID);
                }
            }
            else
            {
                if (ParentID != -1 && ParentID != 0)
                {
                    BusinessLogicLayer.Entities.Persons.Person person = new BusinessLogicLayer.Entities.Persons.Person();
                    new BusinessLogicLayer.Components.Persons.PersonLogic().Insert(person);
                    BusinessLogicLayer.Entities.Persons.PersonLanguages personLang = new BusinessLogicLayer.Entities.Persons.PersonLanguages() { DisplayName = txtName.Text, PersonId = person.BusinessEntityId, LanguageId = 1 };
                    newPersonLanguagesLogic.Insert(personLang);
                    InvitedGuestsLanguageObj.PersonId = person.BusinessEntityId;
                    isSaved = InvitedGuestsLogicLanguageObj.Insert(InvitedGuestsLanguageObj);
                }
                else
                {
                    BusinessLogicLayer.Entities.Persons.Person person = new BusinessLogicLayer.Entities.Persons.Person();
                    new BusinessLogicLayer.Components.Persons.PersonLogic().Insert(person);
                    BusinessLogicLayer.Entities.Persons.PersonLanguages personLang = new BusinessLogicLayer.Entities.Persons.PersonLanguages() { DisplayName = txtName.Text, PersonId = person.BusinessEntityId, LanguageId = 1 };
                    newPersonLanguagesLogic.Insert(personLang);
                    InvitedGuestsObj.PersonId = person.BusinessEntityId;
                    isSaved = InvitedGuestsLogicObj.Insert(InvitedGuestsObj);
                }
            }
            if (isSaved)
                Response.Redirect("ManageInvitedGuests.aspx");
        }
    }
}