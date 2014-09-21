using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.BedManagement;
using BusinessLogicLayer.Entities.BedManagement;
namespace BusinessLogicLayer.Components.BedManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for WardBed table
	/// This class RAPs the WardBedDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class WardBedLogic : BusinessLogic
	{
		public WardBedLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<WardBed> GetAll()
         {
             WardBedDAC _wardBedComponent = new WardBedDAC();
             IDataReader reader =  _wardBedComponent.GetAllWardBed().CreateDataReader();
             List<WardBed> _wardBedList = new List<WardBed>();
             while(reader.Read())
             {
             if(_wardBedList == null)
                 _wardBedList = new List<WardBed>();
                 WardBed _wardBed = new WardBed();
                 if(reader["WardBedId"] != DBNull.Value)
                     _wardBed.WardBedId = Convert.ToInt32(reader["WardBedId"]);
                 if(reader["WardRoomId"] != DBNull.Value)
                     _wardBed.WardRoomId = Convert.ToInt32(reader["WardRoomId"]);
                 if(reader["BedNumber"] != DBNull.Value)
                     _wardBed.BedNumber = Convert.ToInt32(reader["BedNumber"]);
                 if(reader["BedCode"] != DBNull.Value)
                     _wardBed.BedCode = Convert.ToString(reader["BedCode"]);
                 if(reader["BedStatus"] != DBNull.Value)
                     _wardBed.BedStatus = Convert.ToString(reader["BedStatus"]);
                 if(reader["BedType"] != DBNull.Value)
                     _wardBed.BedType = Convert.ToString(reader["BedType"]);
                 if(reader["BedStatusPercentage"] != DBNull.Value)
                     _wardBed.BedStatusPercentage = Convert.ToInt32(reader["BedStatusPercentage"]);
                 if(reader["CurrentPatientCode"] != DBNull.Value)
                     _wardBed.CurrentPatientCode = Convert.ToString(reader["CurrentPatientCode"]);
                 if(reader["SpecialityId"] != DBNull.Value)
                     _wardBed.SpecialityId = Convert.ToInt32(reader["SpecialityId"]);
             _wardBed.NewRecord = false;
             _wardBedList.Add(_wardBed);
             }             reader.Close();
             return _wardBedList;
         }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<WardBed> GetAllByWardRoomId(int WardRoomId)
        {
            WardBedDAC _wardBedComponent = new WardBedDAC();
            IDataReader reader = _wardBedComponent.GetAllWardBed(" WardRoomId = " + WardRoomId).CreateDataReader();
            List<WardBed> _wardBedList = new List<WardBed>();
            while (reader.Read())
            {
                if (_wardBedList == null)
                    _wardBedList = new List<WardBed>();
                WardBed _wardBed = new WardBed();
                if (reader["WardBedId"] != DBNull.Value)
                    _wardBed.WardBedId = Convert.ToInt32(reader["WardBedId"]);
                if (reader["WardRoomId"] != DBNull.Value)
                    _wardBed.WardRoomId = Convert.ToInt32(reader["WardRoomId"]);
                if (reader["BedNumber"] != DBNull.Value)
                    _wardBed.BedNumber = Convert.ToInt32(reader["BedNumber"]);
                if (reader["BedCode"] != DBNull.Value)
                    _wardBed.BedCode = Convert.ToString(reader["BedCode"]);
                if (reader["BedStatus"] != DBNull.Value)
                    _wardBed.BedStatus = Convert.ToString(reader["BedStatus"]);
                if (reader["BedType"] != DBNull.Value)
                    _wardBed.BedType = Convert.ToString(reader["BedType"]);
                if (reader["BedStatusPercentage"] != DBNull.Value)
                    _wardBed.BedStatusPercentage = Convert.ToInt32(reader["BedStatusPercentage"]);
                _wardBed.NewRecord = false;
                _wardBedList.Add(_wardBed);
            } reader.Close();
            return _wardBedList;
        }
        #region Insert And Update
		public bool Insert(WardBed wardbed)
		{
			int autonumber = 0;
			WardBedDAC wardbedComponent = new WardBedDAC();
			bool endedSuccessfuly = wardbedComponent.InsertNewWardBed( ref autonumber,  wardbed.WardRoomId,  wardbed.BedNumber,  wardbed.BedCode,  wardbed.BedStatus,  wardbed.BedType,  wardbed.BedStatusPercentage,  wardbed.CurrentPatientCode,  wardbed.SpecialityId);
			if(endedSuccessfuly)
			{
				wardbed.WardBedId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int WardBedId,  int WardRoomId,  int BedNumber,  string BedCode,  string BedStatus,  string BedType,  int BedStatusPercentage,  string CurrentPatientCode,  int SpecialityId)
		{
			WardBedDAC wardbedComponent = new WardBedDAC();
			return wardbedComponent.InsertNewWardBed( ref WardBedId,  WardRoomId,  BedNumber,  BedCode,  BedStatus,  BedType,  BedStatusPercentage,  CurrentPatientCode,  SpecialityId);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int WardRoomId,  int BedNumber,  string BedCode,  string BedStatus,  string BedType,  int BedStatusPercentage,  string CurrentPatientCode,  int SpecialityId)
		{
			WardBedDAC wardbedComponent = new WardBedDAC();
            int WardBedId = 0;

			return wardbedComponent.InsertNewWardBed( ref WardBedId,  WardRoomId,  BedNumber,  BedCode,  BedStatus,  BedType,  BedStatusPercentage,  CurrentPatientCode,  SpecialityId);
		}
		public bool Update(WardBed wardbed ,int old_wardBedId)
		{
			WardBedDAC wardbedComponent = new WardBedDAC();
			return wardbedComponent.UpdateWardBed( wardbed.WardRoomId,  wardbed.BedNumber,  wardbed.BedCode,  wardbed.BedStatus,  wardbed.BedType,  wardbed.BedStatusPercentage,  wardbed.CurrentPatientCode,  wardbed.SpecialityId,  old_wardBedId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int WardRoomId,  int BedNumber,  string BedCode,  string BedStatus,  string BedType,  int BedStatusPercentage,  string CurrentPatientCode,  int SpecialityId,  int Original_WardBedId)
		{
			WardBedDAC wardbedComponent = new WardBedDAC();
			return wardbedComponent.UpdateWardBed( WardRoomId,  BedNumber,  BedCode,  BedStatus,  BedType,  BedStatusPercentage,  CurrentPatientCode,  SpecialityId,  Original_WardBedId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_WardBedId)
		{
			WardBedDAC wardbedComponent = new WardBedDAC();
			wardbedComponent.DeleteWardBed(Original_WardBedId);
		}

        #endregion
         public WardBed GetByID(int _wardBedId)
         {
             WardBedDAC _wardBedComponent = new WardBedDAC();
             IDataReader reader = _wardBedComponent.GetByIDWardBed(_wardBedId);
             WardBed _wardBed = null;
             while(reader.Read())
             {
                 _wardBed = new WardBed();
                 if(reader["WardBedId"] != DBNull.Value)
                     _wardBed.WardBedId = Convert.ToInt32(reader["WardBedId"]);
                 if(reader["WardRoomId"] != DBNull.Value)
                     _wardBed.WardRoomId = Convert.ToInt32(reader["WardRoomId"]);
                 if(reader["BedNumber"] != DBNull.Value)
                     _wardBed.BedNumber = Convert.ToInt32(reader["BedNumber"]);
                 if(reader["BedCode"] != DBNull.Value)
                     _wardBed.BedCode = Convert.ToString(reader["BedCode"]);
                 if(reader["BedStatus"] != DBNull.Value)
                     _wardBed.BedStatus = Convert.ToString(reader["BedStatus"]);
                 if(reader["BedType"] != DBNull.Value)
                     _wardBed.BedType = Convert.ToString(reader["BedType"]);
                 if(reader["BedStatusPercentage"] != DBNull.Value)
                     _wardBed.BedStatusPercentage = Convert.ToInt32(reader["BedStatusPercentage"]);
                 if(reader["CurrentPatientCode"] != DBNull.Value)
                     _wardBed.CurrentPatientCode = Convert.ToString(reader["CurrentPatientCode"]);
                 if(reader["SpecialityId"] != DBNull.Value)
                     _wardBed.SpecialityId = Convert.ToInt32(reader["SpecialityId"]);
             _wardBed.NewRecord = false;             }             reader.Close();
             return _wardBed;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			WardBedDAC wardbedcomponent = new WardBedDAC();
			return wardbedcomponent.UpdateDataset(dataset);
		}



	}
}
