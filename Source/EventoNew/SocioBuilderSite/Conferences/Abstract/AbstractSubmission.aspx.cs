using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocioBuilderSite.Code.RbmSecurity;
using DevExpress.Web.ASPxUploadControl;
using System.IO;
using Newtonsoft.Json;

namespace SocioBuilderSite.Conferences.Abstract
{
    public partial class AbstractSubmission : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("Submit.aspx");
            if (!IsPostBack)
            {
                if (!SecurityManager.isLogged(this.Page))
                {
                    Response.Redirect("~/Conferences/RequestLogin.aspx");
                    
                }
                LoadAuthorFromProfile();
                Session["AbstractDocumentUploadedFile"] = null;
            }
        }
        private BusinessLogicLayer.Entities.Conference.AbstractAuthors LoadAuthorFromProfile()
        {
            List<BusinessLogicLayer.Entities.Conference.AbstractAuthors> coauthors = new List<BusinessLogicLayer.Entities.Conference.AbstractAuthors>();
            BusinessLogicLayer.Entities.Conference.AbstractAuthors MainAuthor = new BusinessLogicLayer.Entities.Conference.AbstractAuthors();
            BusinessLogicLayer.Entities.Persons.Person person = SecurityManager.getUser(this.Page);

            MainAuthor.Address = person.MainPersonAddress.AddressLine1;
            
            MainAuthor.City = person.MainPersonAddress.City;
            MainAuthor.Country = person.MainPersonAddress.CountryName;
            if (!string.IsNullOrEmpty(person.EmailAddressPrimaryObject.Email))
                MainAuthor.Email = person.EmailAddressPrimaryObject.Email;
            else
                MainAuthor.Email = person.Credentials.Username;
            MainAuthor.FamilyName = person.LastName;
            MainAuthor.FirstName = person.FirstName;
            
            MainAuthor.POBox = person.MainPersonAddress.PostalCode;
            MainAuthor.Title = person.Title;
            MainAuthor.ZipCode = person.MainPersonAddress.ZipCode;
            string[] phones = person.PersonHomePhoneMain.Split('-');
            if (phones.Length == 1)
                MainAuthor.PhoneNumber = phones[0];
            else
            {
                MainAuthor.PhoneNumberAreaCode = phones[0];
                MainAuthor.PhoneNumber = phones[1];
            }
            coauthors.Add(MainAuthor);
            string json = JsonConvert.SerializeObject(coauthors);
            AbstractSubmissionHidden.Set("CoAuthorsDataFromProfile",json);
            return MainAuthor;
        }
        #region UploadFile
        private string SavePostedFile(UploadedFile uploadedFile)
        {

            Session["UploadedFile"] = null;
            string fileName = "";
            if (uploadedFile.IsValid)
            {
                Random random = new Random();
                //string _MenuGroupId = Session["MenuGroupId"].ToString();
                string dateString = String.Format("{0}{1}{2}", System.DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
                string timeString = String.Format("{0}{1}{2}", System.DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                fileName = String.Format("{0}-{1}-{2}-{3}", dateString, timeString, random.Next(), uploadedFile.FileName);
                Session["AbstractDocumentUploadedFile"] = fileName;
                //uploadedFile.SaveAs(Server.MapPath("~/ContentData/MenuImages/") + fileName, true);
                //byte[] thumb = Tools.CreateThumb(uploadedFile.FileBytes, 32, true);
                //MemoryStream stream = new MemoryStream(thumb);
                FileStream stream = new FileStream(Server.MapPath(BusinessLogicLayer.Common.ConferenceContentPath) + fileName, FileMode.Create);
                stream.Write(uploadedFile.FileBytes, 0, uploadedFile.FileBytes.Length);
                stream.Flush();
                stream.Close();


            }
            return fileName;
        }
        protected void conferenceLogoUpload_FileUploadComplete(object sender, DevExpress.Web.ASPxUploadControl.FileUploadCompleteEventArgs e)
        {
            e.CallbackData = SavePostedFile(e.UploadedFile);
        }
        #endregion

        #region Callbacks

        protected void AbstractPreviewReportCallbackPanel_Callback(object sender, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {

        }
        private BusinessLogicLayer.Entities.Conference.Abstracts _CurrentAbstract;
        public BusinessLogicLayer.Entities.Conference.Abstracts CurrentAbstract
        {
            get
            {
                if (Session["CurrentSubmitAbstract"] == null)
                {
                    Session["CurrentSubmitAbstract"] = new BusinessLogicLayer.Entities.Conference.Abstracts();
                }
                return Session["CurrentSubmitAbstract"] as BusinessLogicLayer.Entities.Conference.Abstracts;
            }
            set { Session["CurrentSubmitAbstract"] = value; }
        }
        protected void MainCallbackPanel_Callback(object sender, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            if (e.Parameter == "pre")
            {
                #region Step1
                CurrentAbstract.ConferenceCategoryId = Convert.ToInt32(AbstractCategoryCombo.Value);
                if (CurrentAbstract.NewRecord)
                    CurrentAbstract.AcceptanceType = "Pending";
                CurrentAbstract.PersonId = SecurityManager.getUser(this).BusinessEntityId;
                CurrentAbstract.MainAuthor.Address = AuthorAddressText.Text;
                CurrentAbstract.MainAuthor.AffilitationCity = AuthorAffilitationCityText.Text;
                CurrentAbstract.MainAuthor.AffilitationCountry = AuthorAffilitationCountryText.Text;
                CurrentAbstract.MainAuthor.AffilitationDepartment = AuthorDepartmentText.Text;
                CurrentAbstract.MainAuthor.AffilitationInstitutionHospital = AuthorInstitutionHospitalText.Text;
                CurrentAbstract.MainAuthor.City = AuthorCityText.Text;
                CurrentAbstract.MainAuthor.Country = AuthorCountryText.Text;
                CurrentAbstract.MainAuthor.Degree = AuthorDegreeText.Text;
                CurrentAbstract.MainAuthor.Email = AuthorEmailText.Text;
                CurrentAbstract.MainAuthor.FamilyName = AuthorFamilyNameText.Text;
                CurrentAbstract.MainAuthor.FirstName = AuthorFirstNameText.Text;
                CurrentAbstract.MainAuthor.PhoneNumber = AuthorPhoneNumberText.Text;
                CurrentAbstract.MainAuthor.POBox = AuthorPOBoxText.Text;
                CurrentAbstract.MainAuthor.Title = AuthorTitleCombo.Text;
                CurrentAbstract.MainAuthor.ZipCode = AuthorZipCodeText.Text;
                CurrentAbstract.MainAuthor.PhoneNumberAreaCode = AuthorPhoneNumberAreaCodeText.Text;
                #endregion

                #region Step2
                JsonSerializer serializer = new JsonSerializer();

                string jsonStringPhone = AbstractSubmissionHidden.Get("CoAuthorsData").ToString();
                StringReader reader = new StringReader(jsonStringPhone);
                List<BusinessLogicLayer.Entities.Conference.AbstractAuthors> coauthorsTemp = new List<BusinessLogicLayer.Entities.Conference.AbstractAuthors>();
                using (JsonReader jsonReader = new JsonTextReader(reader))
                {
                    coauthorsTemp = (List<BusinessLogicLayer.Entities.Conference.AbstractAuthors>)serializer.Deserialize(jsonReader, typeof(List<BusinessLogicLayer.Entities.Conference.AbstractAuthors>));
                }
                CurrentAbstract.DeleteCoAuthors();
                foreach (BusinessLogicLayer.Entities.Conference.AbstractAuthors at in coauthorsTemp)
                {
                    if (string.IsNullOrEmpty(at.FirstName.Trim()))
                        continue;
                    at.IsMainAuthor = false;
                    at.AbstractId = CurrentAbstract.AbstractId;
                    CurrentAbstract.CurrentAbstractAuthors.Add(at);
                }
                #endregion

                #region Step3
                CurrentAbstract.AbstractTitle = AbstractTitleText.Text;
                CurrentAbstract.Background = AbstractBackgroundText.Text;
                CurrentAbstract.Methods = AbstractMethodsText.Text;
                CurrentAbstract.Results = AbstractResultsText.Text;
                CurrentAbstract.Conclusions = AbstractConclusionText.Text;
                CurrentAbstract.AbstractKeywords = String.Format("{0}, {1}, {2}", AbstractKeyword1.Value, AbstractKeyword2.Value, AbstractKeyword3.Value);
                if (Session["AbstractDocumentUploadedFile"] != null)
                    CurrentAbstract.DocumentPath1 = Session["AbstractDocumentUploadedFile"].ToString();
                #endregion
                AbstractPreviewReport.ReportViewer.Report = CreateReport();
                //AbstractPreviewReport.ReportViewer.Style.Add("background-image", "url('abstractBackground.jpg')");
            }
            else if(e.Parameter == "save")
            {

                try
                {
                    BusinessLogicLayer.Entities.Conference.Conferences c = Application["CurrentApplicationConference"] as BusinessLogicLayer.Entities.Conference.Conferences;
                    CurrentAbstract.ConferenceId = c.ConferenceId;
                    BusinessLogicLayer.Common.AbstractsLogic.Insert(CurrentAbstract);
                    BusinessLogicLayer.Components.Conference.AbstractAuthorsLogic abstractAuthorLogic = new BusinessLogicLayer.Components.Conference.AbstractAuthorsLogic();
                    foreach (BusinessLogicLayer.Entities.Conference.AbstractAuthors a in CurrentAbstract.CurrentAbstractAuthors)
                    {
                        a.AbstractId = CurrentAbstract.AbstractId;
                        abstractAuthorLogic.Insert(a);
                    }
                    MemoryStream stream = new MemoryStream();
                    CreateReport().ExportToPdf(stream);
                    //AbstractPreviewReport.ReportViewer.Report.ExportToPdf(stream);
                    
                    EmailManager.SendSubmitAbstractEmail(this, CurrentAbstract,stream);
                    EmailManager.SendSubmitAbstractAdministrationEmail(this, CurrentAbstract.ABCode, CurrentAbstract.AbstractIntro, CurrentAbstract.AbstractTitle, "Dr. Ghoneim", BusinessLogicLayer.Common.ReceivingUser);
                    AbstractSubmissionMessage.Attributes.Remove("class");
                    AbstractSubmissionMessage.Attributes.Add("class","success");
                    AbstractSubmissionMessage.InnerHtml = "<strong style=\"font-size:14px;\">Success</strong><br /><br /><p>Thank you for submitting the abstract, you could follow and operate on your abstract using the <a href=\"../MyAbstracts.aspx\" style=\"font-size:12px;\">Abstract Status</a> Page</p>";
                }
                catch (Exception ex)
                {
                    AbstractSubmissionMessage.Attributes.Remove("class");
                    AbstractSubmissionMessage.Attributes.Add("class", "error");
                    AbstractSubmissionMessage.InnerHtml = String.Format("<strong style=\"font-size:14px;\">Failure</strong><br /><br /><p>{0} <br /> Please contact the administrator if you feeel this error shouldn't have appeared.</p>", ex.Message);
                }

                
                //Response.Redirect("~/Conferences/MyAbstracts.aspx");
            }
            else if (e.Parameter == "author")
            {
                BusinessLogicLayer.Entities.Conference.AbstractAuthors MainAuthor = LoadAuthorFromProfile();
                AuthorAddressText.Text = MainAuthor.Address;
                AuthorAffilitationCityText.Text = MainAuthor.AffilitationCity;
                AuthorAffilitationCountryText.Text = MainAuthor.AffilitationCountry;
                AuthorDepartmentText.Text = MainAuthor.AffilitationDepartment;
                AuthorInstitutionHospitalText.Text= MainAuthor.AffilitationInstitutionHospital;
                AuthorCityText.Text = MainAuthor.City;
                AuthorCountryText.Text= MainAuthor.Country;
                AuthorDegreeText.Text= MainAuthor.Degree;
                AuthorEmailText.Text = MainAuthor.Email;
                AuthorFamilyNameText.Text = MainAuthor.FamilyName;
                AuthorFirstNameText.Text = MainAuthor.FirstName;
                AuthorPhoneNumberText.Text = MainAuthor.PhoneNumber;
                AuthorPOBoxText.Text = MainAuthor.POBox;
                if(AuthorTitleCombo.Items.FindByText(MainAuthor.Title) != null)
                    AuthorTitleCombo.SelectedIndex = AuthorTitleCombo.Items.FindByText(MainAuthor.Title).Index;
                AuthorZipCodeText.Text = MainAuthor.ZipCode;
                AuthorPhoneNumberAreaCodeText.Text = MainAuthor.PhoneNumberAreaCode;
            }
               

        }

        DevExpress.XtraReports.UI.XtraReport CreateReport()
        {
            Reports.AbstractReport tableReport = new Reports.AbstractReport();
            tableReport.LoadData(CurrentAbstract);
            return tableReport;
        }
        #endregion
    }
}