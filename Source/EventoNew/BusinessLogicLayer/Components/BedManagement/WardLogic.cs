using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.BedManagement;
using BusinessLogicLayer.Entities.BedManagement;
namespace BusinessLogicLayer.Components.BedManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for Ward table
	/// This class RAPs the WardDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class WardLogic : BusinessLogic
	{
		public WardLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<Ward> GetAll()
         {
             WardDAC _wardComponent = new WardDAC();
             IDataReader reader =  _wardComponent.GetAllWard().CreateDataReader();
             List<Ward> _wardList = new List<Ward>();
             while(reader.Read())
             {
             if(_wardList == null)
                 _wardList = new List<Ward>();
                 Ward _ward = new Ward();
                 if(reader["WardId"] != DBNull.Value)
                     _ward.WardId = Convert.ToInt32(reader["WardId"]);
                 if(reader["WardCode"] != DBNull.Value)
                     _ward.WardCode = Convert.ToString(reader["WardCode"]);
                 if(reader["WardDescription"] != DBNull.Value)
                     _ward.WardDescription = Convert.ToString(reader["WardDescription"]);
                 if(reader["BedsNumber"] != DBNull.Value)
                     _ward.BedsNumber = Convert.ToInt32(reader["BedsNumber"]);
                 if(reader["WardCapacity"] != DBNull.Value)
                     _ward.WardCapacity = Convert.ToInt32(reader["WardCapacity"]);
                 if(reader["RoomsNumber"] != DBNull.Value)
                     _ward.RoomsNumber = Convert.ToInt32(reader["RoomsNumber"]);
                 if(reader["WardType"] != DBNull.Value)
                     _ward.WardType = Convert.ToString(reader["WardType"]);
                 if(reader["WardPhone"] != DBNull.Value)
                     _ward.WardPhone = Convert.ToString(reader["WardPhone"]);
                 if(reader["WardColor"] != DBNull.Value)
                     _ward.WardColor = Convert.ToString(reader["WardColor"]);
                 if(reader["WardOrder"] != DBNull.Value)
                     _ward.WardOrder = Convert.ToInt32(reader["WardOrder"]);
             _ward.NewRecord = false;
             _wardList.Add(_ward);
             }             reader.Close();
             return _wardList;
         }

        #region Insert And Update
		public bool Insert(Ward ward)
		{
			int autonumber = 0;
			WardDAC wardComponent = new WardDAC();
			bool endedSuccessfuly = wardComponent.InsertNewWard( ref autonumber,  ward.WardCode,  ward.WardDescription,  ward.BedsNumber,  ward.WardCapacity,  ward.RoomsNumber,  ward.WardType,  ward.WardPhone,  ward.WardColor,  ward.WardOrder);
			if(endedSuccessfuly)
			{
				ward.WardId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int WardId,  string WardCode,  string WardDescription,  int BedsNumber,  int WardCapacity,  int RoomsNumber,  string WardType,  string WardPhone,  string WardColor,  int WardOrder)
		{
			WardDAC wardComponent = new WardDAC();
			return wardComponent.InsertNewWard( ref WardId,  WardCode,  WardDescription,  BedsNumber,  WardCapacity,  RoomsNumber,  WardType,  WardPhone,  WardColor,  WardOrder);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( string WardCode,  string WardDescription,  int BedsNumber,  int WardCapacity,  int RoomsNumber,  string WardType,  string WardPhone,  string WardColor,  int WardOrder)
		{
			WardDAC wardComponent = new WardDAC();
            int WardId = 0;

			return wardComponent.InsertNewWard( ref WardId,  WardCode,  WardDescription,  BedsNumber,  WardCapacity,  RoomsNumber,  WardType,  WardPhone,  WardColor,  WardOrder);
		}
		public bool Update(Ward ward ,int old_wardId)
		{
			WardDAC wardComponent = new WardDAC();
			return wardComponent.UpdateWard( ward.WardCode,  ward.WardDescription,  ward.BedsNumber,  ward.WardCapacity,  ward.RoomsNumber,  ward.WardType,  ward.WardPhone,  ward.WardColor,  ward.WardOrder,  old_wardId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( string WardCode,  string WardDescription,  int BedsNumber,  int WardCapacity,  int RoomsNumber,  string WardType,  string WardPhone,  string WardColor,  int WardOrder,  int Original_WardId)
		{
			WardDAC wardComponent = new WardDAC();
			return wardComponent.UpdateWard( WardCode,  WardDescription,  BedsNumber,  WardCapacity,  RoomsNumber,  WardType,  WardPhone,  WardColor,  WardOrder,  Original_WardId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_WardId)
		{
			WardDAC wardComponent = new WardDAC();
			wardComponent.DeleteWard(Original_WardId);
		}

        #endregion
         public Ward GetByID(int _wardId)
         {
             WardDAC _wardComponent = new WardDAC();
             IDataReader reader = _wardComponent.GetByIDWard(_wardId);
             Ward _ward = null;
             while(reader.Read())
             {
                 _ward = new Ward();
                 if(reader["WardId"] != DBNull.Value)
                     _ward.WardId = Convert.ToInt32(reader["WardId"]);
                 if(reader["WardCode"] != DBNull.Value)
                     _ward.WardCode = Convert.ToString(reader["WardCode"]);
                 if(reader["WardDescription"] != DBNull.Value)
                     _ward.WardDescription = Convert.ToString(reader["WardDescription"]);
                 if(reader["BedsNumber"] != DBNull.Value)
                     _ward.BedsNumber = Convert.ToInt32(reader["BedsNumber"]);
                 if(reader["WardCapacity"] != DBNull.Value)
                     _ward.WardCapacity = Convert.ToInt32(reader["WardCapacity"]);
                 if(reader["RoomsNumber"] != DBNull.Value)
                     _ward.RoomsNumber = Convert.ToInt32(reader["RoomsNumber"]);
                 if(reader["WardType"] != DBNull.Value)
                     _ward.WardType = Convert.ToString(reader["WardType"]);
                 if(reader["WardPhone"] != DBNull.Value)
                     _ward.WardPhone = Convert.ToString(reader["WardPhone"]);
                 if(reader["WardColor"] != DBNull.Value)
                     _ward.WardColor = Convert.ToString(reader["WardColor"]);
                 if(reader["WardOrder"] != DBNull.Value)
                     _ward.WardOrder = Convert.ToInt32(reader["WardOrder"]);
             _ward.NewRecord = false;             }             reader.Close();
             return _ward;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			WardDAC wardcomponent = new WardDAC();
			return wardcomponent.UpdateDataset(dataset);
		}



	}
}
