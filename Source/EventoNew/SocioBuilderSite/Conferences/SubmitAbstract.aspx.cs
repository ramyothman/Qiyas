using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.IO;

namespace SocioBuilderSite.Conferences
{
    public partial class SubmitAbstract : System.Web.UI.Page
    {
        class Authors
        {
            public string Author = "";
        }
        public BusinessLogicLayer.Entities.Persons.Person CurrentSpeaker
        {
            get
            {
                if (Session["CurrentSpeaker"] == null)
                {
                    Session["CurrentSpeaker"] = BusinessLogicLayer.Common.PersonLogic.GetByID(1);
                }
                return Session["CurrentSpeaker"] as BusinessLogicLayer.Entities.Persons.Person;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AbstractSave_Click(object sender, EventArgs e)
        {
            try
            {
                JsonSerializer serializer = new JsonSerializer();
                string jsonStringAuthor = AbstractHiddenField.Get("jsonStringSetAuthor").ToString();
                StringReader reader = new StringReader(jsonStringAuthor);
                List<Authors> authors = new List<Authors>();
                string authorList = "";
                using (JsonReader jsonReader = new JsonTextReader(reader))
                {
                    authors = (List<Authors>)serializer.Deserialize(jsonReader, typeof(List<Authors>));
                }
                foreach (Authors a in authors)
                {
                    if(!string.IsNullOrEmpty(a.Author.Trim()))
                    authorList += a.Author + ",";
                }
                authorList = authorList.Remove(authorList.Length - 1);
                BusinessLogicLayer.Entities.Conference.Conferences conference = Application["CurrentApplicationConference"] as BusinessLogicLayer.Entities.Conference.Conferences;
                BusinessLogicLayer.Entities.Conference.Abstracts abstracts = new BusinessLogicLayer.Entities.Conference.Abstracts();
                abstracts.AbstractTitle = AbstractTitleText.Text;
                abstracts.AbstractAuthors = authorList;
                abstracts.ConferenceId = conference.ConferenceId;
                abstracts.CoverLetter = AbstractCoveringLetterText.Text;
                abstracts.PersonId = CurrentSpeaker.BusinessEntityId;
                abstracts.AcceptanceType = "Pending";
                abstracts.AbstractIntro = AbstractText.Text;
                abstracts.Topic = AbstractTopicText.Text;
                BusinessLogicLayer.Common.AbstractsLogic.Insert(abstracts);
                //EmailManager.SendSubmitAbstractEmail(this, abstracts.AbstractId.ToString(), abstracts.AbstractIntro, abstracts.AbstractTitle, "Dr. Ghoneim","", BusinessLogicLayer.Common.ReceivingUser);
                EmailManager.SendSubmitAbstractAdministrationEmail(this, abstracts.AbstractId.ToString(), abstracts.AbstractIntro, abstracts.AbstractTitle, "Dr. Ghoneim", BusinessLogicLayer.Common.ReceivingUser);
            }
            catch (Exception ex)
            {

            }
            Response.Redirect("MyAbstracts.aspx");
        }
    }
}