using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.HISBedManagement;
using BusinessLogicLayer.Entities.HISBedManagement;
namespace BusinessLogicLayer.Components.HISBedManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for WardRoomBed table
	/// This class RAPs the WardRoomBedDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class WardRoomBedLogic : BusinessLogic
	{
		public WardRoomBedLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<WardRoomBed> GetAll()
         {
             WardRoomBedDAC _wardRoomBedComponent = new WardRoomBedDAC();
             IDataReader reader =  _wardRoomBedComponent.GetAllWardRoomBed().CreateDataReader();
             List<WardRoomBed> _wardRoomBedList = new List<WardRoomBed>();
             while(reader.Read())
             {
             if(_wardRoomBedList == null)
                 _wardRoomBedList = new List<WardRoomBed>();
                 WardRoomBed _wardRoomBed = new WardRoomBed();
                 if(reader["WardRoomBedId"] != DBNull.Value)
                     _wardRoomBed.WardRoomBedId = Convert.ToInt32(reader["WardRoomBedId"]);
                 if(reader["WardRoomId"] != DBNull.Value)
                     _wardRoomBed.WardRoomId = Convert.ToInt32(reader["WardRoomId"]);
                 if(reader["BedStatusId"] != DBNull.Value)
                     _wardRoomBed.BedStatusId = Convert.ToInt32(reader["BedStatusId"]);
                 if(reader["BedTypeId"] != DBNull.Value)
                     _wardRoomBed.BedTypeId = Convert.ToInt32(reader["BedTypeId"]);
                 if(reader["BedCode"] != DBNull.Value)
                     _wardRoomBed.BedCode = Convert.ToString(reader["BedCode"]);
             _wardRoomBed.NewRecord = false;
             _wardRoomBedList.Add(_wardRoomBed);
             }             reader.Close();
             return _wardRoomBedList;
         }

        #region Insert And Update
		public bool Insert(WardRoomBed wardroombed)
		{
			int autonumber = 0;
			WardRoomBedDAC wardroombedComponent = new WardRoomBedDAC();
			bool endedSuccessfuly = wardroombedComponent.InsertNewWardRoomBed( ref autonumber,  wardroombed.WardRoomId,  wardroombed.BedStatusId,  wardroombed.BedTypeId,  wardroombed.BedCode);
			if(endedSuccessfuly)
			{
				wardroombed.WardRoomBedId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int WardRoomBedId,  int WardRoomId,  int BedStatusId,  int BedTypeId,  string BedCode)
		{
			WardRoomBedDAC wardroombedComponent = new WardRoomBedDAC();
			return wardroombedComponent.InsertNewWardRoomBed( ref WardRoomBedId,  WardRoomId,  BedStatusId,  BedTypeId,  BedCode);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int WardRoomId,  int BedStatusId,  int BedTypeId,  string BedCode)
		{
			WardRoomBedDAC wardroombedComponent = new WardRoomBedDAC();
            int WardRoomBedId = 0;

			return wardroombedComponent.InsertNewWardRoomBed( ref WardRoomBedId,  WardRoomId,  BedStatusId,  BedTypeId,  BedCode);
		}
		public bool Update(WardRoomBed wardroombed ,int old_wardRoomBedId)
		{
			WardRoomBedDAC wardroombedComponent = new WardRoomBedDAC();
			return wardroombedComponent.UpdateWardRoomBed( wardroombed.WardRoomId,  wardroombed.BedStatusId,  wardroombed.BedTypeId,  wardroombed.BedCode,  old_wardRoomBedId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int WardRoomId,  int BedStatusId,  int BedTypeId,  string BedCode,  int Original_WardRoomBedId)
		{
			WardRoomBedDAC wardroombedComponent = new WardRoomBedDAC();
			return wardroombedComponent.UpdateWardRoomBed( WardRoomId,  BedStatusId,  BedTypeId,  BedCode,  Original_WardRoomBedId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_WardRoomBedId)
		{
			WardRoomBedDAC wardroombedComponent = new WardRoomBedDAC();
			wardroombedComponent.DeleteWardRoomBed(Original_WardRoomBedId);
		}

        #endregion
         public WardRoomBed GetByID(int _wardRoomBedId)
         {
             WardRoomBedDAC _wardRoomBedComponent = new WardRoomBedDAC();
             IDataReader reader = _wardRoomBedComponent.GetByIDWardRoomBed(_wardRoomBedId);
             WardRoomBed _wardRoomBed = null;
             while(reader.Read())
             {
                 _wardRoomBed = new WardRoomBed();
                 if(reader["WardRoomBedId"] != DBNull.Value)
                     _wardRoomBed.WardRoomBedId = Convert.ToInt32(reader["WardRoomBedId"]);
                 if(reader["WardRoomId"] != DBNull.Value)
                     _wardRoomBed.WardRoomId = Convert.ToInt32(reader["WardRoomId"]);
                 if(reader["BedStatusId"] != DBNull.Value)
                     _wardRoomBed.BedStatusId = Convert.ToInt32(reader["BedStatusId"]);
                 if(reader["BedTypeId"] != DBNull.Value)
                     _wardRoomBed.BedTypeId = Convert.ToInt32(reader["BedTypeId"]);
                 if(reader["BedCode"] != DBNull.Value)
                     _wardRoomBed.BedCode = Convert.ToString(reader["BedCode"]);
             _wardRoomBed.NewRecord = false;             }             reader.Close();
             return _wardRoomBed;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			WardRoomBedDAC wardroombedcomponent = new WardRoomBedDAC();
			return wardroombedcomponent.UpdateDataset(dataset);
		}



	}
}
