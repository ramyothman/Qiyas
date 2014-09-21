using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocioBuilderSite.Code.RbmSecurity;
using System.IO;
using SocioBuilderSite.Code.RbmCommon;
using DevExpress.Web.ASPxUploadControl;
using System.Web.UI.HtmlControls;

namespace SocioBuilderSite.Conference
{
    public partial class VisaRequest : Code.RbmCommon.ConferenceBasePage
    {
        #region UploadFile
        private string SavePostedFile(UploadedFile uploadedFile)
        {

            Session["VisaUpload"] = null;
            string fileName = "";
            if (uploadedFile.IsValid)
            {
                Random random = new Random();
                //string _MenuGroupId = Session["MenuGroupId"].ToString();
                string dateString = String.Format("{0}{1}{2}", System.DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
                string timeString = String.Format("{0}{1}{2}", System.DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                fileName = String.Format("{0}-{1}-{2}-{3}", dateString, timeString, random.Next(), uploadedFile.FileName);
                if (Tools.IsImage(uploadedFile.FileBytes))
                {
                    Session["VisaUpload"] = fileName;
                    //uploadedFile.SaveAs(Server.MapPath("~/ContentData/Sites/Conferences/") + fileName, true);
                    byte[] thumb = Tools.CreateThumb(uploadedFile.FileBytes, 100, false);
                    //MemoryStream stream = new MemoryStream(thumb);
                    FileStream stream = new FileStream(Server.MapPath(BusinessLogicLayer.Common.PersonContentPath) + fileName, FileMode.Create);
                    byte[] thumbImage = Tools.CreateThumb(uploadedFile.FileBytes, 100, false);
                    stream.Write(uploadedFile.FileBytes, 0, uploadedFile.FileBytes.Length);
                    stream.Flush();
                    stream.Close();
                    BusinessLogicLayer.Entities.Persons.Person person = SecurityManager.getUser(this.Page);
                    person.PersonImage = fileName;
                    BusinessLogicLayer.Common.PersonLogic.Update(person, person.BusinessEntityId);
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
                    monitorLogic.Insert(userid, false, ip, fileName, DateTime.Now);
                    EmailManager.sendMail(String.Format("wrong file uploaded: {0} From IP: {1}", fileName, ip), "Qiyas File Upload Attempt", "ramy.mostafa@gmail.com");
                    fileName = "";
                }
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
                fileName = uploadedFile.FileName;
                monitorLogic.Insert(userid, false, ip, fileName, DateTime.Now);
                EmailManager.sendMail(String.Format("wrong file uploaded: {0} From IP: {1}", fileName, ip), "Qiyas File Upload Attempt", "ramy.mostafa@gmail.com");
                fileName = "";

            }
            return fileName;
        }
        protected void VisaUpload_FileUploadComplete(object sender, DevExpress.Web.ASPxUploadControl.FileUploadCompleteEventArgs e)
        {
            e.CallbackData = SavePostedFile(e.UploadedFile);
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Signup_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.Entities.Persons.Person person = SecurityManager.getUser(this.Page);
            if (person == null) Response.Redirect("~/Conference/RequestLogin.aspx");
            BusinessLogicLayer.Entities.Conference.Conferences conference = Code.RbmCommon.ConferenceBasePage.GetConferenceFromPage(this);
            BusinessLogicLayer.Entities.Conference.ConferenceRegisterations registration = BusinessLogicLayer.Common.ConferenceRegisterationsLogic.GetByID(conference.ConferenceId, person.BusinessEntityId);
            if (registration == null) Response.Redirect("~/Conference/Register.aspx");
            BusinessLogicLayer.Entities.Conference.VisaRequest visa = new BusinessLogicLayer.Components.Conference.VisaRequestLogic().GetAllByConferenceIdPersonId(conference.ConferenceId, person.BusinessEntityId);
            visa.City = VisaRequestCity.Text;
            visa.Company = VisaRequestCompany.Text;
            visa.ConferenceID = conference.ConferenceId;
            visa.Country = VisaRequestCountry.Text;
            visa.JobTitle = VisaRequestJob.Text;
            if(PassportUpload.HasFile)
                visa.PassportAttachment = SavePostedFile(PassportUpload.UploadedFiles[0]);
            visa.PersonID = person.BusinessEntityId;
            visa.Religion = VisaRequestReligion.Text;
            if(visa.NewRecord)
                new BusinessLogicLayer.Components.Conference.VisaRequestLogic().Insert(visa);
            else
                new BusinessLogicLayer.Components.Conference.VisaRequestLogic().Update(visa,visa.VisaRequestID);
            VisaRequestDiv.Visible = false;
            NoticeMessage.Visible = true;
            NoticeMessage.InnerText = Resources.ConferenceFront.VisaRequest_SuccessMessage;
        }
    }
}