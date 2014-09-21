using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.IO;
using DevExpress.Web.ASPxUploadControl;

namespace SocioBuilderSite.Conferences
{
    public partial class AbstractSubmissions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Step2HiddenField.Add("Step2", "");
                Session["AbstractDocumentUploadedFile"] = "";
                
            }
        }

        protected void SubmitAbstractbtn_Click(object sender, EventArgs e)
        {
            
            BusinessLogicLayer.Common.AbstractsLogic.Insert(CurrentAbstract);
            BusinessLogicLayer.Components.Conference.AbstractAuthorsLogic abstractAuthorLogic = new BusinessLogicLayer.Components.Conference.AbstractAuthorsLogic();
            foreach (BusinessLogicLayer.Entities.Conference.AbstractAuthors a in CurrentAbstract.CurrentAbstractAuthors)
            {
                a.AbstractId = CurrentAbstract.AbstractId;
                abstractAuthorLogic.Insert(a);    
            }
            //EmailManager.SendSubmitAbstractEmail(this, CurrentAbstract.AbstractId.ToString(), CurrentAbstract.AbstractIntro, CurrentAbstract.AbstractTitle, "Dr. Ghoneim","", BusinessLogicLayer.Common.ReceivingUser);
            EmailManager.SendSubmitAbstractAdministrationEmail(this, CurrentAbstract.AbstractId.ToString(), CurrentAbstract.AbstractIntro, CurrentAbstract.AbstractTitle, "Dr. Ghoneim", BusinessLogicLayer.Common.ReceivingUser);
            Response.Redirect("MyAbstracts.aspx");
        }

        protected void NextToStep3_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }

        protected void BackToStep1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void NextToStep4_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 3;
        }

        protected void BacktoStep2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }
        private BusinessLogicLayer.Entities.Conference.Abstracts _CurrentAbstract;
        public BusinessLogicLayer.Entities.Conference.Abstracts CurrentAbstract
        {
            get {
                if (Session["CurrentSubmitAbstract"] == null)
                {
                    Session["CurrentSubmitAbstract"] = new BusinessLogicLayer.Entities.Conference.Abstracts();
                }
                return Session["CurrentSubmitAbstract"] as BusinessLogicLayer.Entities.Conference.Abstracts;
            }
            set { Session["CurrentSubmitAbstract"] = value; }
        }
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

        protected void MainCallbackPanel_Callback(object sender, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            string[] splits = e.Parameter.Split(';');
            switch (splits[1])
            {
                case "step1":
                    CurrentAbstract.ConferenceCategoryId = Convert.ToInt32(AbstractCategoryCombo.Value);
                    if (CurrentAbstract.NewRecord)
                        CurrentAbstract.AcceptanceType = "Pending";
                    CurrentAbstract.MainAuthor.Address = AuthorAddressText.Value;
                    CurrentAbstract.MainAuthor.AffilitationCity = AuthorAffilitationCityText.Value;
                    CurrentAbstract.MainAuthor.AffilitationCountry = AuthorAffilitationCountryText.Value;
                    CurrentAbstract.MainAuthor.AffilitationDepartment = AuthorDepartmentText.Value;
                    CurrentAbstract.MainAuthor.AffilitationInstitutionHospital = AuthorInstitutionHospitalText.Value;
                    CurrentAbstract.MainAuthor.City = AuthorCityText.Value;
                    CurrentAbstract.MainAuthor.Country = AuthorCountryText.Value;
                    CurrentAbstract.MainAuthor.Degree = AuthorDegreeText.Value;
                    CurrentAbstract.MainAuthor.Email = AuthorEmailText.Value;
                    CurrentAbstract.MainAuthor.FamilyName = AuthorFamilyNameText.Value;
                    CurrentAbstract.MainAuthor.FirstName = AuthorFirstNameText.Text;
                    CurrentAbstract.MainAuthor.PhoneNumber = AuthorPhoneNumberText.Value;
                    CurrentAbstract.MainAuthor.POBox = AuthorPOBoxText.Value;
                    CurrentAbstract.MainAuthor.Title = AuthorTitleCombo.Value;
                    CurrentAbstract.MainAuthor.ZipCode = AuthorZipCodeText.Value;
                    CurrentAbstract.MainAuthor.PhoneNumberAreaCode = AuthorPhoneNumberAreaCodeText.Value;
                    break;
                case "step2":
                    JsonSerializer serializer = new JsonSerializer();

                    string jsonStringPhone = Step2HiddenField.Get("CoAuthorsData").ToString();
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

                    break;
                case "step3":
                    CurrentAbstract.AbstractTitle = AbstractTitleText.Value;
                    CurrentAbstract.Background = AbstractBackgroundText.Value;
                    CurrentAbstract.Methods = AbstractMethodsText.Value;
                    CurrentAbstract.Results = AbstractResultsText.Value;
                    CurrentAbstract.Conclusions = AbstractConclusionText.Value;
                    CurrentAbstract.AbstractKeywords = String.Format("{0}, {1}, {2}", AbstractKeyword1.Value, AbstractKeyword2.Value, AbstractKeyword3.Value);
                    CurrentAbstract.DocumentPath1 = Session["AbstractDocumentUploadedFile"].ToString();
                    break;
                case "step4":
                    break;

            }
            switch (splits[0])
            {
                case "step1":
                    MultiView1.ActiveViewIndex = 0;
                    
                    
                    AbstractCategoryCombo.Value = CurrentAbstract.ConferenceCategoryId.ToString();
                     
                     AuthorAddressText.Value= CurrentAbstract.MainAuthor.Address ;
                     AuthorAffilitationCityText.Value = CurrentAbstract.MainAuthor.AffilitationCity;
                     AuthorAffilitationCountryText.Value = CurrentAbstract.MainAuthor.AffilitationCountry;
                     AuthorDepartmentText.Value = CurrentAbstract.MainAuthor.AffilitationDepartment;
                     AuthorInstitutionHospitalText.Value = CurrentAbstract.MainAuthor.AffilitationInstitutionHospital;
                     AuthorCityText.Value = CurrentAbstract.MainAuthor.City;
                     AuthorCountryText.Value = CurrentAbstract.MainAuthor.Country;
                     AuthorDegreeText.Value = CurrentAbstract.MainAuthor.Degree;
                     AuthorEmailText.Value = CurrentAbstract.MainAuthor.Email;
                     AuthorFamilyNameText.Value = CurrentAbstract.MainAuthor.FamilyName;
                     AuthorFirstNameText.Text= CurrentAbstract.MainAuthor.FirstName;
                     AuthorPhoneNumberText.Value= CurrentAbstract.MainAuthor.PhoneNumber;
                     AuthorPOBoxText.Value = CurrentAbstract.MainAuthor.POBox;
                     AuthorTitleCombo.Value = CurrentAbstract.MainAuthor.Title;
                     AuthorZipCodeText.Value = CurrentAbstract.MainAuthor.ZipCode;
                     AuthorPhoneNumberAreaCodeText.Value= CurrentAbstract.MainAuthor.PhoneNumberAreaCode;
                    break;
                case "step2":
                    
                    MultiView1.ActiveViewIndex = 1;
                    break;
                case "step3":
                    MultiView1.ActiveViewIndex = 2;
                    break;
                case "step4":
                    MultiView1.ActiveViewIndex = 3;
                    AbstractPreviewReport.ReportViewer.Report = CreateReport();

                    break;
            }
            
        }

        DevExpress.XtraReports.UI.XtraReport CreateReport()
        {
            Reports.AbstractReport tableReport = new Reports.AbstractReport();
            tableReport.LoadData(CurrentAbstract);
            return tableReport;
        }

    }
}