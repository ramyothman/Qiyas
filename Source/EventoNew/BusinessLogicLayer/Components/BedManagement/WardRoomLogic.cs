using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.BedManagement;
using BusinessLogicLayer.Entities.BedManagement;
namespace BusinessLogicLayer.Components.BedManagement
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
                 if(reader["RoomColor"] != DBNull.Value)
                     _wardRoom.RoomColor = Convert.ToString(reader["RoomColor"]);
                 if(reader["RoomNumber"] != DBNull.Value)
                     _wardRoom.RoomNumber = Convert.ToInt32(reader["RoomNumber"]);
                 if(reader["BedsNumber"] != DBNull.Value)
                     _wardRoom.BedsNumber = Convert.ToInt32(reader["BedsNumber"]);
                 if(reader["Capacity"] != DBNull.Value)
                     _wardRoom.Capacity = Convert.ToInt32(reader["Capacity"]);
                 if(reader["IsPrivate"] != DBNull.Value)
                     _wardRoom.IsPrivate = Convert.ToBoolean(reader["IsPrivate"]);
                 if(reader["RoomPhone"] != DBNull.Value)
                     _wardRoom.RoomPhone = Convert.ToString(reader["RoomPhone"]);
                 if(reader["WardRoomTypeId"] != DBNull.Value)
                     _wardRoom.WardRoomTypeId = Convert.ToInt32(reader["WardRoomTypeId"]);
                 if(reader["IsClosed"] != DBNull.Value)
                     _wardRoom.IsClosed = Convert.ToBoolean(reader["IsClosed"]);
             _wardRoom.NewRecord = false;
             _wardRoomList.Add(_wardRoom);
             }             reader.Close();
             return _wardRoomList;
         }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<WardRoom> GetAllByWardId(int WardId)
        {
            WardRoomDAC _wardRoomComponent = new WardRoomDAC();
            IDataReader reader = _wardRoomComponent.GetAllWardRoom(" WardId = " + WardId).CreateDataReader();
            List<WardRoom> _wardRoomList = new List<WardRoom>();
            while (reader.Read())
            {
                if (_wardRoomList == null)
                    _wardRoomList = new List<WardRoom>();
                WardRoom _wardRoom = new WardRoom();
                if (reader["WardRoomId"] != DBNull.Value)
                    _wardRoom.WardRoomId = Convert.ToInt32(reader["WardRoomId"]);
                if (reader["WardId"] != DBNull.Value)
                    _wardRoom.WardId = Convert.ToInt32(reader["WardId"]);
                if (reader["RoomNumber"] != DBNull.Value)
                    _wardRoom.RoomNumber = Convert.ToInt32(reader["RoomNumber"]);
                if (reader["RoomColor"] != DBNull.Value)
                    _wardRoom.RoomColor = Convert.ToString(reader["RoomColor"]);
                if (reader["BedsNumber"] != DBNull.Value)
                    _wardRoom.BedsNumber = Convert.ToInt32(reader["BedsNumber"]);
                if (reader["Capacity"] != DBNull.Value)
                    _wardRoom.Capacity = Convert.ToInt32(reader["Capacity"]);
                if (reader["IsPrivate"] != DBNull.Value)
                    _wardRoom.IsPrivate = Convert.ToBoolean(reader["IsPrivate"]);
                if (reader["RoomPhone"] != DBNull.Value)
                    _wardRoom.RoomPhone = Convert.ToString(reader["RoomPhone"]);
                if (reader["WardRoomTypeId"] != DBNull.Value)
                    _wardRoom.WardRoomTypeId = Convert.ToInt32(reader["WardRoomTypeId"]);
                _wardRoom.NewRecord = false;
                _wardRoomList.Add(_wardRoom);
            } reader.Close();
            return _wardRoomList;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public void GetAllWardRoomDetails(List<Ward> wards)
        {
            WardRoomDAC _wardRoomComponent = new WardRoomDAC();
            IDataReader reader = _wardRoomComponent.ViewWardRoomBeds().CreateDataReader();
            List<WardRoom> _wardRoomList = new List<WardRoom>();
            while (reader.Read())
            {
                if (_wardRoomList == null)
                    _wardRoomList = new List<WardRoom>();

                int wardId = Convert.ToInt32(reader["WardId"]);
                Ward ward = GetWardFromListById(wards, wardId);
                if (ward != null)
                {
                    ward.SetWardRooms();
                    int wardRoomId = Convert.ToInt32(reader["WardRoomId"]);
                    WardRoom _wardRoom = GetWardRoomFromListById(ward.WardRooms, wardRoomId);
                    if (_wardRoom.NewRecord)
                    {
                        if (reader["WardRoomId"] != DBNull.Value)
                            _wardRoom.WardRoomId = Convert.ToInt32(reader["WardRoomId"]);
                        if (reader["WardId"] != DBNull.Value)
                            _wardRoom.WardId = Convert.ToInt32(reader["WardId"]);
                        if (reader["RoomNumber"] != DBNull.Value)
                            _wardRoom.RoomNumber = Convert.ToInt32(reader["RoomNumber"]);
                        if (reader["RoomColor"] != DBNull.Value)
                            _wardRoom.RoomColor = Convert.ToString(reader["RoomColor"]);
                        if (reader["BedsNumber"] != DBNull.Value)
                            _wardRoom.BedsNumber = Convert.ToInt32(reader["BedsNumber"]);
                        if (reader["Capacity"] != DBNull.Value)
                            _wardRoom.Capacity = Convert.ToInt32(reader["Capacity"]);
                        if (reader["IsPrivate"] != DBNull.Value)
                            _wardRoom.IsPrivate = Convert.ToBoolean(reader["IsPrivate"]);
                        if (reader["RoomPhone"] != DBNull.Value)
                            _wardRoom.RoomPhone = Convert.ToString(reader["RoomPhone"]);
                        if (reader["WardRoomTypeId"] != DBNull.Value)
                            _wardRoom.WardRoomTypeId = Convert.ToInt32(reader["WardRoomTypeId"]);
                        _wardRoom.NewRecord = false;
                        ward.WardRooms.Add(_wardRoom);
                    }
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
                    _wardRoom.SetWardBeds();
                    _wardRoom.WardBeds.Add(_wardBed);
                }
            } reader.Close();
        }

        private Ward GetWardFromListById(List<Ward> wards, int id)
        {
            foreach (Ward ward in wards)
            {
                if (ward.WardId == id)
                    return ward;
            }
            return null;
        }

        private WardRoom GetWardRoomFromListById(List<WardRoom> wardRooms, int id)
        {
            foreach (WardRoom wardRoom in wardRooms)
            {
                if (wardRoom.WardRoomId == id)
                    return wardRoom;
            }
            return new WardRoom();
        }
        #region Insert And Update
		public bool Insert(WardRoom wardroom)
		{
			int autonumber = 0;
			WardRoomDAC wardroomComponent = new WardRoomDAC();
			bool endedSuccessfuly = wardroomComponent.InsertNewWardRoom( ref autonumber,  wardroom.WardId,  wardroom.RoomColor,  wardroom.RoomNumber,  wardroom.BedsNumber,  wardroom.Capacity,  wardroom.IsPrivate,  wardroom.RoomPhone,  wardroom.WardRoomTypeId,  wardroom.IsClosed);
			if(endedSuccessfuly)
			{
				wardroom.WardRoomId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int WardRoomId,  int WardId,  string RoomColor,  int RoomNumber,  int BedsNumber,  int Capacity,  bool IsPrivate,  string RoomPhone,  int WardRoomTypeId,  bool IsClosed)
		{
			WardRoomDAC wardroomComponent = new WardRoomDAC();
			return wardroomComponent.InsertNewWardRoom( ref WardRoomId,  WardId,  RoomColor,  RoomNumber,  BedsNumber,  Capacity,  IsPrivate,  RoomPhone,  WardRoomTypeId,  IsClosed);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int WardId,  string RoomColor,  int RoomNumber,  int BedsNumber,  int Capacity,  bool IsPrivate,  string RoomPhone,  int WardRoomTypeId,  bool IsClosed)
		{
			WardRoomDAC wardroomComponent = new WardRoomDAC();
            int WardRoomId = 0;

			return wardroomComponent.InsertNewWardRoom( ref WardRoomId,  WardId,  RoomColor,  RoomNumber,  BedsNumber,  Capacity,  IsPrivate,  RoomPhone,  WardRoomTypeId,  IsClosed);
		}
		public bool Update(WardRoom wardroom ,int old_wardRoomId)
		{
			WardRoomDAC wardroomComponent = new WardRoomDAC();
			return wardroomComponent.UpdateWardRoom( wardroom.WardId,  wardroom.RoomColor,  wardroom.RoomNumber,  wardroom.BedsNumber,  wardroom.Capacity,  wardroom.IsPrivate,  wardroom.RoomPhone,  wardroom.WardRoomTypeId,  wardroom.IsClosed,  old_wardRoomId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int WardId,  string RoomColor,  int RoomNumber,  int BedsNumber,  int Capacity,  bool IsPrivate,  string RoomPhone,  int WardRoomTypeId,  bool IsClosed,  int Original_WardRoomId)
		{
			WardRoomDAC wardroomComponent = new WardRoomDAC();
			return wardroomComponent.UpdateWardRoom( WardId,  RoomColor,  RoomNumber,  BedsNumber,  Capacity,  IsPrivate,  RoomPhone,  WardRoomTypeId,  IsClosed,  Original_WardRoomId);
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
                 if(reader["RoomColor"] != DBNull.Value)
                     _wardRoom.RoomColor = Convert.ToString(reader["RoomColor"]);
                 if(reader["RoomNumber"] != DBNull.Value)
                     _wardRoom.RoomNumber = Convert.ToInt32(reader["RoomNumber"]);
                 if(reader["BedsNumber"] != DBNull.Value)
                     _wardRoom.BedsNumber = Convert.ToInt32(reader["BedsNumber"]);
                 if(reader["Capacity"] != DBNull.Value)
                     _wardRoom.Capacity = Convert.ToInt32(reader["Capacity"]);
                 if(reader["IsPrivate"] != DBNull.Value)
                     _wardRoom.IsPrivate = Convert.ToBoolean(reader["IsPrivate"]);
                 if(reader["RoomPhone"] != DBNull.Value)
                     _wardRoom.RoomPhone = Convert.ToString(reader["RoomPhone"]);
                 if(reader["WardRoomTypeId"] != DBNull.Value)
                     _wardRoom.WardRoomTypeId = Convert.ToInt32(reader["WardRoomTypeId"]);
                 if(reader["IsClosed"] != DBNull.Value)
                     _wardRoom.IsClosed = Convert.ToBoolean(reader["IsClosed"]);
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
