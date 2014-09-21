using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.HISBedManagement;
using BusinessLogicLayer.Entities.HISBedManagement;
namespace BusinessLogicLayer.Components.HISBedManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for WardRoom table
	/// This class RAPs the WardRoomDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class WardRoomLogic : BusinessLogic
	{
		public WardRoomLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<WardRoom> GetAll()
         {
             WardRoomDAC _wardRoomComponent = new WardRoomDAC();
             IDataReader reader =  _wardRoomComponent.GetAllWardRoom().CreateDataReader();
             List<WardRoom> _wardRoomList = new List<WardRoom>();
             while(reader.Read())
             {
             if(_wardRoomList == null)
                 _wardRoomList = new List<WardRoom>();
                 WardRoom _wardRoom = new WardRoom();
                 if(reader["WardRoomId"] != DBNull.Value)
                     _wardRoom.WardRoomId = Convert.ToInt32(reader["WardRoomId"]);
                 if(reader["WardId"] != DBNull.Value)
                     _wardRoom.WardId = Convert.ToInt32(reader["WardId"]);
                 if(reader["RoomTypeId"] != DBNull.Value)
                     _wardRoom.RoomTypeId = Convert.ToInt32(reader["RoomTypeId"]);
                 if(reader["RoomCode"] != DBNull.Value)
                     _wardRoom.RoomCode = Convert.ToString(reader["RoomCode"]);
                 if(reader["RoomDescription"] != DBNull.Value)
                     _wardRoom.RoomDescription = Convert.ToString(reader["RoomDescription"]);
                 if(reader["RoomColor"] != DBNull.Value)
                     _wardRoom.RoomColor = Convert.ToString(reader["RoomColor"]);
                 if(reader["Capacity"] != DBNull.Value)
                     _wardRoom.Capacity = Convert.ToInt32(reader["Capacity"]);
                 if(reader["BedsNumber"] != DBNull.Value)
                     _wardRoom.BedsNumber = Convert.ToInt32(reader["BedsNumber"]);
                 if(reader["RoomPhone"] != DBNull.Value)
                     _wardRoom.RoomPhone = Convert.ToString(reader["RoomPhone"]);
                 if(reader["IsClosed"] != DBNull.Value)
                     _wardRoom.IsClosed = Convert.ToBoolean(reader["IsClosed"]);
                 if(reader["ClosingReason"] != DBNull.Value)
                     _wardRoom.ClosingReason = Convert.ToString(reader["ClosingReason"]);
             _wardRoom.NewRecord = false;
             _wardRoomList.Add(_wardRoom);
             }             reader.Close();
             return _wardRoomList;
         }

        #region Insert And Update
		public bool Insert(WardRoom wardroom)
		{
			int autonumber = 0;
			WardRoomDAC wardroomComponent = new WardRoomDAC();
			bool endedSuccessfuly = wardroomComponent.InsertNewWardRoom( ref autonumber,  wardroom.WardId,  wardroom.RoomTypeId,  wardroom.RoomCode,  wardroom.RoomDescription,  wardroom.RoomColor,  wardroom.Capacity,  wardroom.BedsNumber,  wardroom.RoomPhone,  wardroom.IsClosed,  wardroom.ClosingReason);
			if(endedSuccessfuly)
			{
				wardroom.WardRoomId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int WardRoomId,  int WardId,  int RoomTypeId,  string RoomCode,  string RoomDescription,  string RoomColor,  int Capacity,  int BedsNumber,  string RoomPhone,  bool IsClosed,  string ClosingReason)
		{
			WardRoomDAC wardroomComponent = new WardRoomDAC();
			return wardroomComponent.InsertNewWardRoom( ref WardRoomId,  WardId,  RoomTypeId,  RoomCode,  RoomDescription,  RoomColor,  Capacity,  BedsNumber,  RoomPhone,  IsClosed,  ClosingReason);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int WardId,  int RoomTypeId,  string RoomCode,  string RoomDescription,  string RoomColor,  int Capacity,  int BedsNumber,  string RoomPhone,  bool IsClosed,  string ClosingReason)
		{
			WardRoomDAC wardroomComponent = new WardRoomDAC();
            int WardRoomId = 0;

			return wardroomComponent.InsertNewWardRoom( ref WardRoomId,  WardId,  RoomTypeId,  RoomCode,  RoomDescription,  RoomColor,  Capacity,  BedsNumber,  RoomPhone,  IsClosed,  ClosingReason);
		}
		public bool Update(WardRoom wardroom ,int old_wardRoomId)
		{
			WardRoomDAC wardroomComponent = new WardRoomDAC();
			return wardroomComponent.UpdateWardRoom( wardroom.WardId,  wardroom.RoomTypeId,  wardroom.RoomCode,  wardroom.RoomDescription,  wardroom.RoomColor,  wardroom.Capacity,  wardroom.BedsNumber,  wardroom.RoomPhone,  wardroom.IsClosed,  wardroom.ClosingReason,  old_wardRoomId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int WardId,  int RoomTypeId,  string RoomCode,  string RoomDescription,  string RoomColor,  int Capacity,  int BedsNumber,  string RoomPhone,  bool IsClosed,  string ClosingReason,  int Original_WardRoomId)
		{
			WardRoomDAC wardroomComponent = new WardRoomDAC();
			return wardroomComponent.UpdateWardRoom( WardId,  RoomTypeId,  RoomCode,  RoomDescription,  RoomColor,  Capacity,  BedsNumber,  RoomPhone,  IsClosed,  ClosingReason,  Original_WardRoomId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_WardRoomId)
		{
			WardRoomDAC wardroomComponent = new WardRoomDAC();
			wardroomComponent.DeleteWardRoom(Original_WardRoomId);
		}

        #endregion
         public WardRoom GetByID(int _wardRoomId)
         {
             WardRoomDAC _wardRoomComponent = new WardRoomDAC();
             IDataReader reader = _wardRoomComponent.GetByIDWardRoom(_wardRoomId);
             WardRoom _wardRoom = null;
             while(reader.Read())
             {
                 _wardRoom = new WardRoom();
                 if(reader["WardRoomId"] != DBNull.Value)
                     _wardRoom.WardRoomId = Convert.ToInt32(reader["WardRoomId"]);
                 if(reader["WardId"] != DBNull.Value)
                     _wardRoom.WardId = Convert.ToInt32(reader["WardId"]);
                 if(reader["RoomTypeId"] != DBNull.Value)
                     _wardRoom.RoomTypeId = Convert.ToInt32(reader["RoomTypeId"]);
                 if(reader["RoomCode"] != DBNull.Value)
                     _wardRoom.RoomCode = Convert.ToString(reader["RoomCode"]);
                 if(reader["RoomDescription"] != DBNull.Value)
                     _wardRoom.RoomDescription = Convert.ToString(reader["RoomDescription"]);
                 if(reader["RoomColor"] != DBNull.Value)
                     _wardRoom.RoomColor = Convert.ToString(reader["RoomColor"]);
                 if(reader["Capacity"] != DBNull.Value)
                     _wardRoom.Capacity = Convert.ToInt32(reader["Capacity"]);
                 if(reader["BedsNumber"] != DBNull.Value)
                     _wardRoom.BedsNumber = Convert.ToInt32(reader["BedsNumber"]);
                 if(reader["RoomPhone"] != DBNull.Value)
                     _wardRoom.RoomPhone = Convert.ToString(reader["RoomPhone"]);
                 if(reader["IsClosed"] != DBNull.Value)
                     _wardRoom.IsClosed = Convert.ToBoolean(reader["IsClosed"]);
                 if(reader["ClosingReason"] != DBNull.Value)
                     _wardRoom.ClosingReason = Convert.ToString(reader["ClosingReason"]);
             _wardRoom.NewRecord = false;             }             reader.Close();
             return _wardRoom;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			WardRoomDAC wardroomcomponent = new WardRoomDAC();
			return wardroomcomponent.UpdateDataset(dataset);
		}



	}
}
