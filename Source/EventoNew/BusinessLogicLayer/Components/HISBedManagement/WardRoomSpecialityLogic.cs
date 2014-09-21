using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.HISBedManagement;
using BusinessLogicLayer.Entities.HISBedManagement;
namespace BusinessLogicLayer.Components.HISBedManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for WardRoomSpeciality table
	/// This class RAPs the WardRoomSpecialityDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class WardRoomSpecialityLogic : BusinessLogic
	{
		public WardRoomSpecialityLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<WardRoomSpeciality> GetAll()
         {
             WardRoomSpecialityDAC _wardRoomSpecialityComponent = new WardRoomSpecialityDAC();
             IDataReader reader =  _wardRoomSpecialityComponent.GetAllWardRoomSpeciality().CreateDataReader();
             List<WardRoomSpeciality> _wardRoomSpecialityList = new List<WardRoomSpeciality>();
             while(reader.Read())
             {
             if(_wardRoomSpecialityList == null)
                 _wardRoomSpecialityList = new List<WardRoomSpeciality>();
                 WardRoomSpeciality _wardRoomSpeciality = new WardRoomSpeciality();
                 if(reader["RoomSpecialityId"] != DBNull.Value)
                     _wardRoomSpeciality.RoomSpecialityId = Convert.ToInt32(reader["RoomSpecialityId"]);
                 if(reader["WardRoomId"] != DBNull.Value)
                     _wardRoomSpeciality.WardRoomId = Convert.ToInt32(reader["WardRoomId"]);
                 if(reader["SpecialityId"] != DBNull.Value)
                     _wardRoomSpeciality.SpecialityId = Convert.ToInt32(reader["SpecialityId"]);
                 if(reader["IsMainSpeciality"] != DBNull.Value)
                     _wardRoomSpeciality.IsMainSpeciality = Convert.ToBoolean(reader["IsMainSpeciality"]);
                 if(reader["SpecialityOrder"] != DBNull.Value)
                     _wardRoomSpeciality.SpecialityOrder = Convert.ToInt32(reader["SpecialityOrder"]);
             _wardRoomSpeciality.NewRecord = false;
             _wardRoomSpecialityList.Add(_wardRoomSpeciality);
             }             reader.Close();
             return _wardRoomSpecialityList;
         }

        #region Insert And Update
		public bool Insert(WardRoomSpeciality wardroomspeciality)
		{
			int autonumber = 0;
			WardRoomSpecialityDAC wardroomspecialityComponent = new WardRoomSpecialityDAC();
			bool endedSuccessfuly = wardroomspecialityComponent.InsertNewWardRoomSpeciality( ref autonumber,  wardroomspeciality.WardRoomId,  wardroomspeciality.SpecialityId,  wardroomspeciality.IsMainSpeciality,  wardroomspeciality.SpecialityOrder);
			if(endedSuccessfuly)
			{
				wardroomspeciality.RoomSpecialityId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int RoomSpecialityId,  int WardRoomId,  int SpecialityId,  bool IsMainSpeciality,  int SpecialityOrder)
		{
			WardRoomSpecialityDAC wardroomspecialityComponent = new WardRoomSpecialityDAC();
			return wardroomspecialityComponent.InsertNewWardRoomSpeciality( ref RoomSpecialityId,  WardRoomId,  SpecialityId,  IsMainSpeciality,  SpecialityOrder);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int WardRoomId,  int SpecialityId,  bool IsMainSpeciality,  int SpecialityOrder)
		{
			WardRoomSpecialityDAC wardroomspecialityComponent = new WardRoomSpecialityDAC();
            int RoomSpecialityId = 0;

			return wardroomspecialityComponent.InsertNewWardRoomSpeciality( ref RoomSpecialityId,  WardRoomId,  SpecialityId,  IsMainSpeciality,  SpecialityOrder);
		}
		public bool Update(WardRoomSpeciality wardroomspeciality ,int old_roomSpecialityId)
		{
			WardRoomSpecialityDAC wardroomspecialityComponent = new WardRoomSpecialityDAC();
			return wardroomspecialityComponent.UpdateWardRoomSpeciality( wardroomspeciality.WardRoomId,  wardroomspeciality.SpecialityId,  wardroomspeciality.IsMainSpeciality,  wardroomspeciality.SpecialityOrder,  old_roomSpecialityId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int WardRoomId,  int SpecialityId,  bool IsMainSpeciality,  int SpecialityOrder,  int Original_RoomSpecialityId)
		{
			WardRoomSpecialityDAC wardroomspecialityComponent = new WardRoomSpecialityDAC();
			return wardroomspecialityComponent.UpdateWardRoomSpeciality( WardRoomId,  SpecialityId,  IsMainSpeciality,  SpecialityOrder,  Original_RoomSpecialityId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_RoomSpecialityId)
		{
			WardRoomSpecialityDAC wardroomspecialityComponent = new WardRoomSpecialityDAC();
			wardroomspecialityComponent.DeleteWardRoomSpeciality(Original_RoomSpecialityId);
		}

        #endregion
         public WardRoomSpeciality GetByID(int _roomSpecialityId)
         {
             WardRoomSpecialityDAC _wardRoomSpecialityComponent = new WardRoomSpecialityDAC();
             IDataReader reader = _wardRoomSpecialityComponent.GetByIDWardRoomSpeciality(_roomSpecialityId);
             WardRoomSpeciality _wardRoomSpeciality = null;
             while(reader.Read())
             {
                 _wardRoomSpeciality = new WardRoomSpeciality();
                 if(reader["RoomSpecialityId"] != DBNull.Value)
                     _wardRoomSpeciality.RoomSpecialityId = Convert.ToInt32(reader["RoomSpecialityId"]);
                 if(reader["WardRoomId"] != DBNull.Value)
                     _wardRoomSpeciality.WardRoomId = Convert.ToInt32(reader["WardRoomId"]);
                 if(reader["SpecialityId"] != DBNull.Value)
                     _wardRoomSpeciality.SpecialityId = Convert.ToInt32(reader["SpecialityId"]);
                 if(reader["IsMainSpeciality"] != DBNull.Value)
                     _wardRoomSpeciality.IsMainSpeciality = Convert.ToBoolean(reader["IsMainSpeciality"]);
                 if(reader["SpecialityOrder"] != DBNull.Value)
                     _wardRoomSpeciality.SpecialityOrder = Convert.ToInt32(reader["SpecialityOrder"]);
             _wardRoomSpeciality.NewRecord = false;             }             reader.Close();
             return _wardRoomSpeciality;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			WardRoomSpecialityDAC wardroomspecialitycomponent = new WardRoomSpecialityDAC();
			return wardroomspecialitycomponent.UpdateDataset(dataset);
		}



	}
}
