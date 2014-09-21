using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.BedManagement;
using BusinessLogicLayer.Entities.BedManagement;
namespace BusinessLogicLayer.Components.BedManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for PatientAdmission table
	/// This class RAPs the PatientAdmissionDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class PatientAdmissionLogic : BusinessLogic
	{
		public PatientAdmissionLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<PatientAdmission> GetAll()
         {
             PatientAdmissionDAC _patientAdmissionComponent = new PatientAdmissionDAC();
             IDataReader reader =  _patientAdmissionComponent.GetAllPatientAdmission().CreateDataReader();
             List<PatientAdmission> _patientAdmissionList = new List<PatientAdmission>();
             while(reader.Read())
             {
             if(_patientAdmissionList == null)
                 _patientAdmissionList = new List<PatientAdmission>();
                 PatientAdmission _patientAdmission = new PatientAdmission();
                 if(reader["PatientAdmissionId"] != DBNull.Value)
                     _patientAdmission.PatientAdmissionId = Convert.ToInt32(reader["PatientAdmissionId"]);
                 if(reader["AdmissionStartDate"] != DBNull.Value)
                     _patientAdmission.AdmissionStartDate = Convert.ToDateTime(reader["AdmissionStartDate"]);
                 if(reader["DischargeDate"] != DBNull.Value)
                     _patientAdmission.DischargeDate = Convert.ToDateTime(reader["DischargeDate"]);
                 if(reader["AdmissionStayTypeId"] != DBNull.Value)
                     _patientAdmission.AdmissionStayTypeId = Convert.ToInt32(reader["AdmissionStayTypeId"]);
                 if(reader["DischargeTypeId"] != DBNull.Value)
                     _patientAdmission.DischargeTypeId = Convert.ToInt32(reader["DischargeTypeId"]);
                 if(reader["PatientCode"] != DBNull.Value)
                     _patientAdmission.PatientCode = Convert.ToString(reader["PatientCode"]);
                 if(reader["ConsultantId"] != DBNull.Value)
                     _patientAdmission.ConsultantId = Convert.ToInt32(reader["ConsultantId"]);
                 if(reader["SpecialityId"] != DBNull.Value)
                     _patientAdmission.SpecialityId = Convert.ToInt32(reader["SpecialityId"]);
                 if(reader["WardBedId"] != DBNull.Value)
                     _patientAdmission.WardBedId = Convert.ToInt32(reader["WardBedId"]);
             _patientAdmission.NewRecord = false;
             _patientAdmissionList.Add(_patientAdmission);
             }             reader.Close();
             return _patientAdmissionList;
         }

        #region Insert And Update
		public bool Insert(PatientAdmission patientadmission)
		{
			int autonumber = 0;
			PatientAdmissionDAC patientadmissionComponent = new PatientAdmissionDAC();
			bool endedSuccessfuly = patientadmissionComponent.InsertNewPatientAdmission( ref autonumber,  patientadmission.AdmissionStartDate,  patientadmission.DischargeDate,  patientadmission.AdmissionStayTypeId,  patientadmission.DischargeTypeId,  patientadmission.PatientCode,  patientadmission.ConsultantId,  patientadmission.SpecialityId,  patientadmission.WardBedId);
			if(endedSuccessfuly)
			{
				patientadmission.PatientAdmissionId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int PatientAdmissionId,  DateTime AdmissionStartDate,  DateTime DischargeDate,  int AdmissionStayTypeId,  int DischargeTypeId,  string PatientCode,  int ConsultantId,  int SpecialityId,  int WardBedId)
		{
			PatientAdmissionDAC patientadmissionComponent = new PatientAdmissionDAC();
			return patientadmissionComponent.InsertNewPatientAdmission( ref PatientAdmissionId,  AdmissionStartDate,  DischargeDate,  AdmissionStayTypeId,  DischargeTypeId,  PatientCode,  ConsultantId,  SpecialityId,  WardBedId);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( DateTime AdmissionStartDate,  DateTime DischargeDate,  int AdmissionStayTypeId,  int DischargeTypeId,  string PatientCode,  int ConsultantId,  int SpecialityId,  int WardBedId)
		{
			PatientAdmissionDAC patientadmissionComponent = new PatientAdmissionDAC();
            int PatientAdmissionId = 0;

			return patientadmissionComponent.InsertNewPatientAdmission( ref PatientAdmissionId,  AdmissionStartDate,  DischargeDate,  AdmissionStayTypeId,  DischargeTypeId,  PatientCode,  ConsultantId,  SpecialityId,  WardBedId);
		}
		public bool Update(PatientAdmission patientadmission ,int old_patientAdmissionId)
		{
			PatientAdmissionDAC patientadmissionComponent = new PatientAdmissionDAC();
			return patientadmissionComponent.UpdatePatientAdmission( patientadmission.AdmissionStartDate,  patientadmission.DischargeDate,  patientadmission.AdmissionStayTypeId,  patientadmission.DischargeTypeId,  patientadmission.PatientCode,  patientadmission.ConsultantId,  patientadmission.SpecialityId,  patientadmission.WardBedId,  old_patientAdmissionId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( DateTime AdmissionStartDate,  DateTime DischargeDate,  int AdmissionStayTypeId,  int DischargeTypeId,  string PatientCode,  int ConsultantId,  int SpecialityId,  int WardBedId,  int Original_PatientAdmissionId)
		{
			PatientAdmissionDAC patientadmissionComponent = new PatientAdmissionDAC();
			return patientadmissionComponent.UpdatePatientAdmission( AdmissionStartDate,  DischargeDate,  AdmissionStayTypeId,  DischargeTypeId,  PatientCode,  ConsultantId,  SpecialityId,  WardBedId,  Original_PatientAdmissionId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_PatientAdmissionId)
		{
			PatientAdmissionDAC patientadmissionComponent = new PatientAdmissionDAC();
			patientadmissionComponent.DeletePatientAdmission(Original_PatientAdmissionId);
		}

        #endregion
         public PatientAdmission GetByID(int _patientAdmissionId)
         {
             PatientAdmissionDAC _patientAdmissionComponent = new PatientAdmissionDAC();
             IDataReader reader = _patientAdmissionComponent.GetByIDPatientAdmission(_patientAdmissionId);
             PatientAdmission _patientAdmission = null;
             while(reader.Read())
             {
                 _patientAdmission = new PatientAdmission();
                 if(reader["PatientAdmissionId"] != DBNull.Value)
                     _patientAdmission.PatientAdmissionId = Convert.ToInt32(reader["PatientAdmissionId"]);
                 if(reader["AdmissionStartDate"] != DBNull.Value)
                     _patientAdmission.AdmissionStartDate = Convert.ToDateTime(reader["AdmissionStartDate"]);
                 if(reader["DischargeDate"] != DBNull.Value)
                     _patientAdmission.DischargeDate = Convert.ToDateTime(reader["DischargeDate"]);
                 if(reader["AdmissionStayTypeId"] != DBNull.Value)
                     _patientAdmission.AdmissionStayTypeId = Convert.ToInt32(reader["AdmissionStayTypeId"]);
                 if(reader["DischargeTypeId"] != DBNull.Value)
                     _patientAdmission.DischargeTypeId = Convert.ToInt32(reader["DischargeTypeId"]);
                 if(reader["PatientCode"] != DBNull.Value)
                     _patientAdmission.PatientCode = Convert.ToString(reader["PatientCode"]);
                 if(reader["ConsultantId"] != DBNull.Value)
                     _patientAdmission.ConsultantId = Convert.ToInt32(reader["ConsultantId"]);
                 if(reader["SpecialityId"] != DBNull.Value)
                     _patientAdmission.SpecialityId = Convert.ToInt32(reader["SpecialityId"]);
                 if(reader["WardBedId"] != DBNull.Value)
                     _patientAdmission.WardBedId = Convert.ToInt32(reader["WardBedId"]);
             _patientAdmission.NewRecord = false;             }             reader.Close();
             return _patientAdmission;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			PatientAdmissionDAC patientadmissioncomponent = new PatientAdmissionDAC();
			return patientadmissioncomponent.UpdateDataset(dataset);
		}



	}
}
