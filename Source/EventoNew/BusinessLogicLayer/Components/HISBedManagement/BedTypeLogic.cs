using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.HISBedManagement;
using BusinessLogicLayer.Entities.HISBedManagement;
namespace BusinessLogicLayer.Components.HISBedManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for BedType table
	/// This class RAPs the BedTypeDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class BedTypeLogic : BusinessLogic
	{
		public BedTypeLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<BedType> GetAll()
         {
             BedTypeDAC _bedTypeComponent = new BedTypeDAC();
             IDataReader reader =  _bedTypeComponent.GetAllBedType().CreateDataReader();
             List<BedType> _bedTypeList = new List<BedType>();
             while(reader.Read())
             {
             if(_bedTypeList == null)
                 _bedTypeList = new List<BedType>();
                 BedType _bedType = new BedType();
                 if(reader["BedTypeId"] != DBNull.Value)
                     _bedType.BedTypeId = Convert.ToInt32(reader["BedTypeId"]);
                 if(reader["BedTypeName"] != DBNull.Value)
                     _bedType.BedTypeName = Convert.ToString(reader["BedTypeName"]);
             _bedType.NewRecord = false;
             _bedTypeList.Add(_bedType);
             }             reader.Close();
             return _bedTypeList;
         }

        #region Insert And Update
		public bool Insert(BedType bedtype)
		{
			int autonumber = 0;
			BedTypeDAC bedtypeComponent = new BedTypeDAC();
			bool endedSuccessfuly = bedtypeComponent.InsertNewBedType( ref autonumber,  bedtype.BedTypeName);
			if(endedSuccessfuly)
			{
				bedtype.BedTypeId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int BedTypeId,  string BedTypeName)
		{
			BedTypeDAC bedtypeComponent = new BedTypeDAC();
			return bedtypeComponent.InsertNewBedType( ref BedTypeId,  BedTypeName);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( string BedTypeName)
		{
			BedTypeDAC bedtypeComponent = new BedTypeDAC();
            int BedTypeId = 0;

			return bedtypeComponent.InsertNewBedType( ref BedTypeId,  BedTypeName);
		}
		public bool Update(BedType bedtype ,int old_bedTypeId)
		{
			BedTypeDAC bedtypeComponent = new BedTypeDAC();
			return bedtypeComponent.UpdateBedType( bedtype.BedTypeName,  old_bedTypeId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( string BedTypeName,  int Original_BedTypeId)
		{
			BedTypeDAC bedtypeComponent = new BedTypeDAC();
			return bedtypeComponent.UpdateBedType( BedTypeName,  Original_BedTypeId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_BedTypeId)
		{
			BedTypeDAC bedtypeComponent = new BedTypeDAC();
			bedtypeComponent.DeleteBedType(Original_BedTypeId);
		}

        #endregion
         public BedType GetByID(int _bedTypeId)
         {
             BedTypeDAC _bedTypeComponent = new BedTypeDAC();
             IDataReader reader = _bedTypeComponent.GetByIDBedType(_bedTypeId);
             BedType _bedType = null;
             while(reader.Read())
             {
                 _bedType = new BedType();
                 if(reader["BedTypeId"] != DBNull.Value)
                     _bedType.BedTypeId = Convert.ToInt32(reader["BedTypeId"]);
                 if(reader["BedTypeName"] != DBNull.Value)
                     _bedType.BedTypeName = Convert.ToString(reader["BedTypeName"]);
             _bedType.NewRecord = false;             }             reader.Close();
             return _bedType;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			BedTypeDAC bedtypecomponent = new BedTypeDAC();
			return bedtypecomponent.UpdateDataset(dataset);
		}



	}
}
