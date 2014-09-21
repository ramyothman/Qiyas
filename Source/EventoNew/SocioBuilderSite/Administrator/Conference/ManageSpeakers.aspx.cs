﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxUploadControl;
using System.IO;
using SocioBuilderSite.Code.RbmCommon;
using DevExpress.Web.ASPxGridView;

namespace SocioBuilderSite.BackendPortal.Conference
{
    public partial class ManageSpeakers : AdminBasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                object values = SpeakersGrid.GetRowValues(Convert.ToInt32(0), new string[] { "ConferenceSpeakerId" });
                if (values == null)
                    values = "0";
                Session["ParentID"] = values.ToString();
            }

        }
        protected void ASPxGridView1_BeforePerformDataSelect(object sender, EventArgs e)
        {

            Session["ParentID"] = (sender as ASPxGridView).GetMasterRowKeyValue();
        }
        #region old Code
        //private string SavePostedFile(UploadedFile uploadedFile)
        //{

        //    Session["UploadedFileSpeakers"] = null;
        //    string fileName = "";
        //    if (uploadedFile.IsValid)
        //    {
        //        Random random = new Random();
        //        //string _MenuGroupId = Session["MenuGroupId"].ToString();
        //        string dateString = String.Format("{0}{1}{2}", System.DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
        //        string timeString = String.Format("{0}{1}{2}", System.DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        //        fileName = String.Format("{0}-{1}-{2}-{3}", dateString, timeString, random.Next(), uploadedFile.FileName);
        //        Session["UploadedFileSpeakers"] = fileName;
        //        //uploadedFile.SaveAs(Server.MapPath(BusinessLogicLayer.Common.ConferenceContentPath) + fileName, true);
        //        byte[] thumb = Tools.CreateThumb(uploadedFile.FileBytes, 141, false);
        //        //MemoryStream stream = new MemoryStream(thumb);
        //        FileStream stream = new FileStream(Server.MapPath(BusinessLogicLayer.Common.ConferenceContentPath) + fileName, FileMode.Create);
        //        stream.Write(thumb, 0, thumb.Length);
        //        stream.Flush();
        //        stream.Close();


        //    }
        //    return fileName;
        //}
        //protected void conferenceLogoUpload_FileUploadComplete(object sender, DevExpress.Web.ASPxUploadControl.FileUploadCompleteEventArgs e)
        //{
        //    e.CallbackData = SavePostedFile(e.UploadedFile);
        //}

        //protected void SpeakersGrid_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        //{
        //    if (Session["UploadedFileSpeakers"] != null)
        //    {
        //        e.NewValues["SpeakerImage"] = Session["UploadedFileSpeakers"];
        //        Session["UploadedFileSpeakers"] = null;

        //    }
        //}

        //protected void SpeakersGrid_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        //{
        //    if (Session["UploadedFileSpeakers"] != null)
        //    {
        //        e.NewValues["SpeakerImage"] = Session["UploadedFileSpeakers"];
        //        Session["UploadedFileSpeakers"] = null;

        //    }
        //}

        //protected void SpeakersGrid_StartRowEditing(object sender, DevExpress.Web.Data.ASPxStartRowEditingEventArgs e)
        //{
        //    Session["UploadedFileSpeakers"] = null;
        //}

        #endregion

    }
}