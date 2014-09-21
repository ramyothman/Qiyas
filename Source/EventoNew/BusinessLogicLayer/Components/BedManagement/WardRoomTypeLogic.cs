using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.BedManagement;
using BusinessLogicLayer.Entities.BedManagement;
namespace BusinessLogicLayer.Components.BedManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for WardRoomType table
	/// This class RAPs the WardRoomTypeDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class WardRoomTypeLogic : BusinessLogic
	{
		public WardRoomTypeLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<WardRoomType> GetAll()
         {
             WardRoomTypeDAC _wardRoomTypeComponent = new WardRoomTypeDAC();
             IDataReader reader =  _wardRoomTypeComponent.GetAllWardRoomType().CreateDataReader();
             List<WardRoomType> _wardRoomTypeList = new List<WardRoomType>();
             while(reader.Read())
             {
             if(_wardRoomTypeList == null)
                 _wardRoomTypeList = new List<WardRoomType>();
                 WardRoomType _wardRoomType = new WardRoomType();
                 if(reader["WardRoomTypeId"] != DBNull.Value)
                     _wardRoomType.WardRoomTypeId = Convert.ToInt32(reader["WardRoomTypeId"]);
                 if(reader["WardRoomTypeName"] != DBNull.Value)
                     _wardRoomType.WardRoomTypeName = Convert.ToString(reader["WardRoomTypeName"]);
             _wardRoomType.NewRecord = false;
             _wardRoomTypeList.Add(_wardRoomType);
             }             reader.Close();
             return _wardRoomTypeList;
         }

        #region Insert And Update
		public bool Insert(WardRoomType wardroomtype)
		{
			int autonumber = 0;
			WardRoomTypeDAC wardroomtypeComponent = new WardRoomTypeDAC();
			bool endedSuccessfuly = wardroomtypeComponent.InsertNewWardRoomType( ref autonumber,  wardroomtype.WardRoomTypeName);
			if(endedSuccessfuly)
			{
				wardroomtype.WardRoomTypeId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int WardRoomTypeId,  string WardRoomTypeName)
		{
			WardRoomTypeDAC wardroomtypeComponent = new WardRoomTypeDAC();
			return wardroomtypeComponent.InsertNewWardRoomType( ref WardRoomTypeId,  WardRoomTypeName);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( string WardRoomTypeName)
		{
			WardRoomTypeDAC wardroomtypeComponent = new WardRoomTypeDAC();
            int WardRoomTypeId = 0;

			return wardroomtypeComponent.InsertNewWardRoomType( ref WardRoomTypeId,  WardRoomTypeName);
		}
		public bool Update(WardRoomType wardroomtype ,int old_wardRoomTypeId)
		{
			WardRoomTypeDAC wardroomtypeComponent = new WardRoomTypeDAC();
			return wardroomtypeComponent.UpdateWardRoomType( wardroomtype.WardRoomTypeName,  old_wardRoomTypeId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( string WardRoomTypeName,  int Original_WardRoomTypeId)
		{
			WardRoomTypeDAC wardroomtypeComponent = new WardRoomTypeDAC();
			return wardroomtypeComponent.UpdateWardRoomType( WardRoomTypeName,  Original_WardRoomTypeId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_WardRoomTypeId)
		{
			WardRoomTypeDAC wardroomtypeComponent = new WardRoomTypeDAC();
			wardroomtypeComponent.DeleteWardRoomType(Original_WardRoomTypeId);
		}

        #endregion
         public WardRoomType GetByID(int _wardRoomTypeId)
         {
             WardRoomTypeDAC _wardRoomTypeComponent = new WardRoomTypeDAC();
             IDataReader reader = _wardRoomTypeComponent.GetByIDWardRoomType(_wardRoomTypeId);
             WardRoomType _wardRoomType = null;
             while(reader.Read())
             {
                 _wardRoomType = new WardRoomType();
                 if(reader["WardRoomTypeId"] != DBNull.Value)
                     _wardRoomType.WardRoomTypeId = Convert.ToInt32(reader["WardRoomTypeId"]);
                 if(reader["WardRoomTypeName"] != DBNull.Value)
                     _wardRoomType.WardRoomTypeName = Convert.ToString(reader["WardRoomTypeName"]);
             _wardRoomType.NewRecord = false;             }             reader.Close();
             return _wardRoomType;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			WardRoomTypeDAC wardroomtypecomponent = new WardRoomTypeDAC();
			return wardroomtypecomponent.UpdateDataset(dataset);
		}



	}
}
