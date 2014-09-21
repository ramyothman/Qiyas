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
    public partial class SaveARSpeakers : AdminBasePage
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


            if (SpeakerID != -1 && SpeakerID != 0)
            {
                if (ParentID != -1 && ParentID != 0)
                {
                    SpeakerLogicLanguageObj = new ConferenceSpeakersLanguageLogic();
                    SpeakerLanguageObj = SpeakerLogicLanguageObj.GetByID(SpeakerID);
                    txtBio.Text = SpeakerLanguageObj.SpeakerBio;
                   
                    txtPosition.Text = SpeakerLanguageObj.SpeakerPosition;
                   
                    txtName.Text = SpeakerLanguageObj.SpeakerName;
                    cbLanguage.SelectedIndex = cbLanguage.Items.IndexOfValue(SpeakerLanguageObj.LanguageID);
                    trParent.Visible = true;
                }
                else
                {
                    SpeakerLogicObj = new ConferenceSpeakersLogic();
                    SpeakerObj = SpeakerLogicObj.GetByID(SpeakerID);
                    txtBio.Text = SpeakerObj.SpeakerBio;
                   
                    txtPosition.Text = SpeakerObj.SpeakerPosition;
                   
                    txtName.Text = SpeakerObj.CurrentPerson.DisplayName;
                }
            }

        }
        private void GetFormValues()
        {
            if (ParentID != -1 && ParentID != 0)
            {
                SpeakerLanguageObj = new ConferenceSpeakersLanguage();
                SpeakerLanguageObj.SpeakerBio = txtBio.Text;
               
                SpeakerLanguageObj.SpeakerPosition = txtPosition.Text;
             
                SpeakerLanguageObj.LanguageID = Convert.ToInt32(cbLanguage.Value);
                SpeakerLanguageObj.ConferenceSpeakerParentId = ParentID;
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
                    if (split.Length >= 2)
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
                if (split.Length >= 2)
                    lastName = split[split.Length - 1];
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            bool isSaved=false;
            GetFormValues();
            BusinessLogicLayer.Components.Persons.PersonLanguagesLogic newPersonLanguagesLogic = new BusinessLogicLayer.Components.Persons.PersonLanguagesLogic();
            SpeakerLogicObj = new ConferenceSpeakersLogic();
            SpeakerLogicLanguageObj = new ConferenceSpeakersLanguageLogic();
            string name, title, firstName, middleName, lastName;
            name = title = firstName = middleName = lastName = "";
            name = txtName.Text;
            ResolveString(name, out title,out firstName, out middleName, out lastName);
            if (ParentID != -1 && ParentID != 0)
            {
                BusinessLogicLayer.Entities.Conference.ConferenceSpeakers speaker = SpeakerLogicObj.GetByID(ParentID);
                int PersonID = speaker.PersonId;
                BusinessLogicLayer.Entities.Persons.Person p = BusinessLogicLayer.Common.PersonLogic.GetByID(PersonID);
                
                BusinessLogicLayer.Entities.Persons.PersonLanguages personLang = p.GetByLanguageID(Convert.ToInt32(cbLanguage.SelectedItem.Value));
                personLang.FirstName = firstName;
                personLang.LastName = lastName;
                personLang.LanguageId = Convert.ToInt32(cbLanguage.Value);
                personLang.MiddleName = middleName;
                personLang.Title = title;
                personLang.PersonId = p.BusinessEntityId;
                personLang.DisplayName = txtName.Text;

                if (!personLang.NewRecord)
                {                                        
                    newPersonLanguagesLogic.Update(personLang, personLang.PersonLanguageId);
                }
                else
                {                    
                    newPersonLanguagesLogic.Insert(personLang);
                }
                SpeakerLanguageObj.PersonId = PersonID;
                if (SpeakerID != -1 && SpeakerID != 0)
                {
                    isSaved = SpeakerLogicLanguageObj.Update(SpeakerLanguageObj, SpeakerID);

                }
                else
                {
                    SpeakerLanguageObj.PersonId = p.BusinessEntityId;
                    isSaved = SpeakerLogicLanguageObj.Insert(SpeakerLanguageObj);

                }
                

            }
            
            
            if (isSaved)
                Response.Redirect("ManageSpeakers.aspx");
        }
    }
}