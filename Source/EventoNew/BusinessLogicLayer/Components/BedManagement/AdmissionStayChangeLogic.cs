using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.BedManagement;
using BusinessLogicLayer.Entities.BedManagement;
namespace BusinessLogicLayer.Components.BedManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for AdmissionStayChange table
	/// This class RAPs the AdmissionStayChangeDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class AdmissionStayChangeLogic : BusinessLogic
	{
		public AdmissionStayChangeLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<AdmissionStayChange> GetAll()
         {
             AdmissionStayChangeDAC _admissionStayChangeComponent = new AdmissionStayChangeDAC();
             IDataReader reader =  _admissionStayChangeComponent.GetAllAdmissionStayChange().CreateDataReader();
             List<AdmissionStayChange> _admissionStayChangeList = new List<AdmissionStayChange>();
             while(reader.Read())
             {
             if(_admissionStayChangeList == null)
                 _admissionStayChangeList = new List<AdmissionStayChange>();
                 AdmissionStayChange _admissionStayChange = new AdmissionStayChange();
                 if(reader["AdmissionStayChangeId"] != DBNull.Value)
                     _admissionStayChange.AdmissionStayChangeId = Convert.ToInt32(reader["AdmissionStayChangeId"]);
                 if(reader["PatientAdmissionId"] != DBNull.Value)
                     _admissionStayChange.PatientAdmissionId = Convert.ToInt32(reader["PatientAdmissionId"]);
                 if(reader["AdmissionStayTypeId"] != DBNull.Value)
                     _admissionStayChange.AdmissionStayTypeId = Convert.ToInt32(reader["AdmissionStayTypeId"]);
                 if(reader["ModifiedDate"] != DBNull.Value)
                     _admissionStayChange.ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"]);
             _admissionStayChange.NewRecord = false;
             _admissionStayChangeList.Add(_admissionStayChange);
             }             reader.Close();
             return _admissionStayChangeList;
         }

        #region Insert And Update
		public bool Insert(AdmissionStayChange admissionstaychange)
		{
			int autonumber = 0;
			AdmissionStayChangeDAC admissionstaychangeComponent = new AdmissionStayChangeDAC();
			bool endedSuccessfuly = admissionstaychangeComponent.InsertNewAdmissionStayChange( ref autonumber,  admissionstaychange.PatientAdmissionId,  admissionstaychange.AdmissionStayTypeId,  admissionstaychange.ModifiedDate);
			if(endedSuccessfuly)
			{
				admissionstaychange.AdmissionStayChangeId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int AdmissionStayChangeId,  int PatientAdmissionId,  int AdmissionStayTypeId,  DateTime ModifiedDate)
		{
			AdmissionStayChangeDAC admissionstaychangeComponent = new AdmissionStayChangeDAC();
			return admissionstaychangeComponent.InsertNewAdmissionStayChange( ref AdmissionStayChangeId,  PatientAdmissionId,  AdmissionStayTypeId,  ModifiedDate);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int PatientAdmissionId,  int AdmissionStayTypeId,  DateTime ModifiedDate)
		{
			AdmissionStayChangeDAC admissionstaychangeComponent = new AdmissionStayChangeDAC();
            int AdmissionStayChangeId = 0;

			return admissionstaychangeComponent.InsertNewAdmissionStayChange( ref AdmissionStayChangeId,  PatientAdmissionId,  AdmissionStayTypeId,  ModifiedDate);
		}
		public bool Update(AdmissionStayChange admissionstaychange ,int old_admissionStayChangeId)
		{
			AdmissionStayChangeDAC admissionstaychangeComponent = new AdmissionStayChangeDAC();
			return admissionstaychangeComponent.UpdateAdmissionStayChange( admissionstaychange.PatientAdmissionId,  admissionstaychange.AdmissionStayTypeId,  admissionstaychange.ModifiedDate,  old_admissionStayChangeId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int PatientAdmissionId,  int AdmissionStayTypeId,  DateTime ModifiedDate,  int Original_AdmissionStayChangeId)
		{
			AdmissionStayChangeDAC admissionstaychangeComponent = new AdmissionStayChangeDAC();
			return admissionstaychangeComponent.UpdateAdmissionStayChange( PatientAdmissionId,  AdmissionStayTypeId,  ModifiedDate,  Original_AdmissionStayChangeId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_AdmissionStayChangeId)
		{
			AdmissionStayChangeDAC admissionstaychangeComponent = new AdmissionStayChangeDAC();
			admissionstaychangeComponent.DeleteAdmissionStayChange(Original_AdmissionStayChangeId);
		}

        #endregion
         public AdmissionStayChange GetByID(int _admissionStayChangeId)
         {
             AdmissionStayChangeDAC _admissionStayChangeComponent = new AdmissionStayChangeDAC();
             IDataReader reader = _admissionStayChangeComponent.GetByIDAdmissionStayChange(_admissionStayChangeId);
             AdmissionStayChange _admissionStayChange = null;
             while(reader.Read())
             {
                 _admissionStayChange = new AdmissionStayChange();
                 if(reader["AdmissionStayChangeId"] != DBNull.Value)
                     _admissionStayChange.AdmissionStayChangeId = Convert.ToInt32(reader["AdmissionStayChangeId"]);
                 if(reader["PatientAdmissionId"] != DBNull.Value)
                     _admissionStayChange.PatientAdmissionId = Convert.ToInt32(reader["PatientAdmissionId"]);
                 if(reader["AdmissionStayTypeId"] != DBNull.Value)
                     _admissionStayChange.AdmissionStayTypeId = Convert.ToInt32(reader["AdmissionStayTypeId"]);
                 if(reader["ModifiedDate"] != DBNull.Value)
                     _admissionStayChange.ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"]);
             _admissionStayChange.NewRecord = false;             }             reader.Close();
             return _admissionStayChange;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			AdmissionStayChangeDAC admissionstaychangecomponent = new AdmissionStayChangeDAC();
			return admissionstaychangecomponent.UpdateDataset(dataset);
		}



	}
}
