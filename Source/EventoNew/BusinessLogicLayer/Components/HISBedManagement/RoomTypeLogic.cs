using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.HISBedManagement;
using BusinessLogicLayer.Entities.HISBedManagement;
namespace BusinessLogicLayer.Components.HISBedManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for RoomType table
	/// This class RAPs the RoomTypeDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class RoomTypeLogic : BusinessLogic
	{
		public RoomTypeLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<RoomType> GetAll()
         {
             RoomTypeDAC _roomTypeComponent = new RoomTypeDAC();
             IDataReader reader =  _roomTypeComponent.GetAllRoomType().CreateDataReader();
             List<RoomType> _roomTypeList = new List<RoomType>();
             while(reader.Read())
             {
             if(_roomTypeList == null)
                 _roomTypeList = new List<RoomType>();
                 RoomType _roomType = new RoomType();
                 if(reader["RoomTypeId"] != DBNull.Value)
                     _roomType.RoomTypeId = Convert.ToInt32(reader["RoomTypeId"]);
                 if(reader["RoomTypeName"] != DBNull.Value)
                     _roomType.RoomTypeName = Convert.ToString(reader["RoomTypeName"]);
             _roomType.NewRecord = false;
             _roomTypeList.Add(_roomType);
             }             reader.Close();
             return _roomTypeList;
         }

        #region Insert And Update
		public bool Insert(RoomType roomtype)
		{
			int autonumber = 0;
			RoomTypeDAC roomtypeComponent = new RoomTypeDAC();
			bool endedSuccessfuly = roomtypeComponent.InsertNewRoomType( ref autonumber,  roomtype.RoomTypeName);
			if(endedSuccessfuly)
			{
				roomtype.RoomTypeId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int RoomTypeId,  string RoomTypeName)
		{
			RoomTypeDAC roomtypeComponent = new RoomTypeDAC();
			return roomtypeComponent.InsertNewRoomType( ref RoomTypeId,  RoomTypeName);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( string RoomTypeName)
		{
			RoomTypeDAC roomtypeComponent = new RoomTypeDAC();
            int RoomTypeId = 0;

			return roomtypeComponent.InsertNewRoomType( ref RoomTypeId,  RoomTypeName);
		}
		public bool Update(RoomType roomtype ,int old_roomTypeId)
		{
			RoomTypeDAC roomtypeComponent = new RoomTypeDAC();
			return roomtypeComponent.UpdateRoomType( roomtype.RoomTypeName,  old_roomTypeId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( string RoomTypeName,  int Original_RoomTypeId)
		{
			RoomTypeDAC roomtypeComponent = new RoomTypeDAC();
			return roomtypeComponent.UpdateRoomType( RoomTypeName,  Original_RoomTypeId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_RoomTypeId)
		{
			RoomTypeDAC roomtypeComponent = new RoomTypeDAC();
			roomtypeComponent.DeleteRoomType(Original_RoomTypeId);
		}

        #endregion
         public RoomType GetByID(int _roomTypeId)
         {
             RoomTypeDAC _roomTypeComponent = new RoomTypeDAC();
             IDataReader reader = _roomTypeComponent.GetByIDRoomType(_roomTypeId);
             RoomType _roomType = null;
             while(reader.Read())
             {
                 _roomType = new RoomType();
                 if(reader["RoomTypeId"] != DBNull.Value)
                     _roomType.RoomTypeId = Convert.ToInt32(reader["RoomTypeId"]);
                 if(reader["RoomTypeName"] != DBNull.Value)
                     _roomType.RoomTypeName = Convert.ToString(reader["RoomTypeName"]);
             _roomType.NewRecord = false;             }             reader.Close();
             return _roomType;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			RoomTypeDAC roomtypecomponent = new RoomTypeDAC();
			return roomtypecomponent.UpdateDataset(dataset);
		}



	}
}
