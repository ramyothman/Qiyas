using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.HISBedManagement;
using BusinessLogicLayer.Entities.HISBedManagement;
namespace BusinessLogicLayer.Components.HISBedManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for WardType table
	/// This class RAPs the WardTypeDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class WardTypeLogic : BusinessLogic
	{
		public WardTypeLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<WardType> GetAll()
         {
             WardTypeDAC _wardTypeComponent = new WardTypeDAC();
             IDataReader reader =  _wardTypeComponent.GetAllWardType().CreateDataReader();
             List<WardType> _wardTypeList = new List<WardType>();
             while(reader.Read())
             {
             if(_wardTypeList == null)
                 _wardTypeList = new List<WardType>();
                 WardType _wardType = new WardType();
                 if(reader["WardTypeId"] != DBNull.Value)
                     _wardType.WardTypeId = Convert.ToInt32(reader["WardTypeId"]);
                 if(reader["WardTypeName"] != DBNull.Value)
                     _wardType.WardTypeName = Convert.ToString(reader["WardTypeName"]);
             _wardType.NewRecord = false;
             _wardTypeList.Add(_wardType);
             }             reader.Close();
             return _wardTypeList;
         }

        #region Insert And Update
		public bool Insert(WardType wardtype)
		{
			int autonumber = 0;
			WardTypeDAC wardtypeComponent = new WardTypeDAC();
			bool endedSuccessfuly = wardtypeComponent.InsertNewWardType( ref autonumber,  wardtype.WardTypeName);
			if(endedSuccessfuly)
			{
				wardtype.WardTypeId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int WardTypeId,  string WardTypeName)
		{
			WardTypeDAC wardtypeComponent = new WardTypeDAC();
			return wardtypeComponent.InsertNewWardType( ref WardTypeId,  WardTypeName);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( string WardTypeName)
		{
			WardTypeDAC wardtypeComponent = new WardTypeDAC();
            int WardTypeId = 0;

			return wardtypeComponent.InsertNewWardType( ref WardTypeId,  WardTypeName);
		}
		public bool Update(WardType wardtype ,int old_wardTypeId)
		{
			WardTypeDAC wardtypeComponent = new WardTypeDAC();
			return wardtypeComponent.UpdateWardType( wardtype.WardTypeName,  old_wardTypeId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( string WardTypeName,  int Original_WardTypeId)
		{
			WardTypeDAC wardtypeComponent = new WardTypeDAC();
			return wardtypeComponent.UpdateWardType( WardTypeName,  Original_WardTypeId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_WardTypeId)
		{
			WardTypeDAC wardtypeComponent = new WardTypeDAC();
			wardtypeComponent.DeleteWardType(Original_WardTypeId);
		}

        #endregion
         public WardType GetByID(int _wardTypeId)
         {
             WardTypeDAC _wardTypeComponent = new WardTypeDAC();
             IDataReader reader = _wardTypeComponent.GetByIDWardType(_wardTypeId);
             WardType _wardType = null;
             while(reader.Read())
             {
                 _wardType = new WardType();
                 if(reader["WardTypeId"] != DBNull.Value)
                     _wardType.WardTypeId = Convert.ToInt32(reader["WardTypeId"]);
                 if(reader["WardTypeName"] != DBNull.Value)
                     _wardType.WardTypeName = Convert.ToString(reader["WardTypeName"]);
             _wardType.NewRecord = false;             }             reader.Close();
             return _wardType;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			WardTypeDAC wardtypecomponent = new WardTypeDAC();
			return wardtypecomponent.UpdateDataset(dataset);
		}



	}
}
