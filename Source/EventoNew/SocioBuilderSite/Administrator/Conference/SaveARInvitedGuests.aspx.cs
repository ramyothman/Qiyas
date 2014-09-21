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
    public partial class SaveARInvitedGuests : AdminBasePage
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

                    txtPosition.Text = InvitedGuestsLanguageObj.SpeakerPosition;

                    txtName.Text = InvitedGuestsLanguageObj.CurrentPerson.DisplayName;
                    cbLanguage.Value = InvitedGuestsLanguageObj.LanguageID;
                }

            }
        }
        private void GetFormValues()
        {
            if (ParentID != -1 && ParentID != 0)
            {
                InvitedGuestsLanguageObj = new InvitedGuestsLanguage();
                InvitedGuestsLanguageObj.SpeakerBio = txtBio.Text; 
                InvitedGuestsLanguageObj.SpeakerPosition = txtPosition.Text;
               
                InvitedGuestsLanguageObj.LanguageID = Convert.ToInt32(cbLanguage.Value);
                InvitedGuestsLanguageObj.parentID = ParentID;

            }
           
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            bool isSaved=false;
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

            }
            if (isSaved)
                Response.Redirect("ManageInvitedGuests.aspx");
        }
    }
}