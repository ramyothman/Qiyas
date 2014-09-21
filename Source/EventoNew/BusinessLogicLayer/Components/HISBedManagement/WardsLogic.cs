using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.HISBedManagement;
using BusinessLogicLayer.Entities.HISBedManagement;
namespace BusinessLogicLayer.Components.HISBedManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for Wards table
	/// This class RAPs the WardsDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class WardsLogic : BusinessLogic
	{
		public WardsLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<Wards> GetAll()
         {
             WardsDAC _wardsComponent = new WardsDAC();
             IDataReader reader =  _wardsComponent.GetAllWards().CreateDataReader();
             List<Wards> _wardsList = new List<Wards>();
             while(reader.Read())
             {
             if(_wardsList == null)
                 _wardsList = new List<Wards>();
                 Wards _wards = new Wards();
                 if(reader["WardId"] != DBNull.Value)
                     _wards.WardId = Convert.ToInt32(reader["WardId"]);
                 if(reader["WardCode"] != DBNull.Value)
                     _wards.WardCode = Convert.ToString(reader["WardCode"]);
                 if(reader["WardDescription"] != DBNull.Value)
                     _wards.WardDescription = Convert.ToString(reader["WardDescription"]);
                 if(reader["WardTypeId"] != DBNull.Value)
                     _wards.WardTypeId = Convert.ToInt32(reader["WardTypeId"]);
                 if(reader["WardForId"] != DBNull.Value)
                     _wards.WardForId = Convert.ToInt32(reader["WardForId"]);
                 if(reader["BedsNumber"] != DBNull.Value)
                     _wards.BedsNumber = Convert.ToInt32(reader["BedsNumber"]);
                 if(reader["WardCapacity"] != DBNull.Value)
                     _wards.WardCapacity = Convert.ToInt32(reader["WardCapacity"]);
                 if(reader["RoomsNumber"] != DBNull.Value)
                     _wards.RoomsNumber = Convert.ToInt32(reader["RoomsNumber"]);
                 if(reader["WardPhone"] != DBNull.Value)
                     _wards.WardPhone = Convert.ToString(reader["WardPhone"]);
                 if(reader["WardColor"] != DBNull.Value)
                     _wards.WardColor = Convert.ToString(reader["WardColor"]);
                 if(reader["WardOrder"] != DBNull.Value)
                     _wards.WardOrder = Convert.ToInt32(reader["WardOrder"]);
             _wards.NewRecord = false;
             _wardsList.Add(_wards);
             }             reader.Close();
             return _wardsList;
         }

        #region Insert And Update
		public bool Insert(Wards wards)
		{
			int autonumber = 0;
			WardsDAC wardsComponent = new WardsDAC();
			bool endedSuccessfuly = wardsComponent.InsertNewWards( ref autonumber,  wards.WardCode,  wards.WardDescription,  wards.WardTypeId,  wards.WardForId,  wards.BedsNumber,  wards.WardCapacity,  wards.RoomsNumber,  wards.WardPhone,  wards.WardColor,  wards.WardOrder);
			if(endedSuccessfuly)
			{
				wards.WardId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int WardId,  string WardCode,  string WardDescription,  int WardTypeId,  int WardForId,  int BedsNumber,  int WardCapacity,  int RoomsNumber,  string WardPhone,  string WardColor,  int WardOrder)
		{
			WardsDAC wardsComponent = new WardsDAC();
			return wardsComponent.InsertNewWards( ref WardId,  WardCode,  WardDescription,  WardTypeId,  WardForId,  BedsNumber,  WardCapacity,  RoomsNumber,  WardPhone,  WardColor,  WardOrder);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( string WardCode,  string WardDescription,  int WardTypeId,  int WardForId,  int BedsNumber,  int WardCapacity,  int RoomsNumber,  string WardPhone,  string WardColor,  int WardOrder)
		{
			WardsDAC wardsComponent = new WardsDAC();
            int WardId = 0;

			return wardsComponent.InsertNewWards( ref WardId,  WardCode,  WardDescription,  WardTypeId,  WardForId,  BedsNumber,  WardCapacity,  RoomsNumber,  WardPhone,  WardColor,  WardOrder);
		}
		public bool Update(Wards wards ,int old_wardId)
		{
			WardsDAC wardsComponent = new WardsDAC();
			return wardsComponent.UpdateWards( wards.WardCode,  wards.WardDescription,  wards.WardTypeId,  wards.WardForId,  wards.BedsNumber,  wards.WardCapacity,  wards.RoomsNumber,  wards.WardPhone,  wards.WardColor,  wards.WardOrder,  old_wardId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( string WardCode,  string WardDescription,  int WardTypeId,  int WardForId,  int BedsNumber,  int WardCapacity,  int RoomsNumber,  string WardPhone,  string WardColor,  int WardOrder,  int Original_WardId)
		{
			WardsDAC wardsComponent = new WardsDAC();
			return wardsComponent.UpdateWards( WardCode,  WardDescription,  WardTypeId,  WardForId,  BedsNumber,  WardCapacity,  RoomsNumber,  WardPhone,  WardColor,  WardOrder,  Original_WardId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_WardId)
		{
			WardsDAC wardsComponent = new WardsDAC();
			wardsComponent.DeleteWards(Original_WardId);
		}

        #endregion
         public Wards GetByID(int _wardId)
         {
             WardsDAC _wardsComponent = new WardsDAC();
             IDataReader reader = _wardsComponent.GetByIDWards(_wardId);
             Wards _wards = null;
             while(reader.Read())
             {
                 _wards = new Wards();
                 if(reader["WardId"] != DBNull.Value)
                     _wards.WardId = Convert.ToInt32(reader["WardId"]);
                 if(reader["WardCode"] != DBNull.Value)
                     _wards.WardCode = Convert.ToString(reader["WardCode"]);
                 if(reader["WardDescription"] != DBNull.Value)
                     _wards.WardDescription = Convert.ToString(reader["WardDescription"]);
                 if(reader["WardTypeId"] != DBNull.Value)
                     _wards.WardTypeId = Convert.ToInt32(reader["WardTypeId"]);
                 if(reader["WardForId"] != DBNull.Value)
                     _wards.WardForId = Convert.ToInt32(reader["WardForId"]);
                 if(reader["BedsNumber"] != DBNull.Value)
                     _wards.BedsNumber = Convert.ToInt32(reader["BedsNumber"]);
                 if(reader["WardCapacity"] != DBNull.Value)
                     _wards.WardCapacity = Convert.ToInt32(reader["WardCapacity"]);
                 if(reader["RoomsNumber"] != DBNull.Value)
                     _wards.RoomsNumber = Convert.ToInt32(reader["RoomsNumber"]);
                 if(reader["WardPhone"] != DBNull.Value)
                     _wards.WardPhone = Convert.ToString(reader["WardPhone"]);
                 if(reader["WardColor"] != DBNull.Value)
                     _wards.WardColor = Convert.ToString(reader["WardColor"]);
                 if(reader["WardOrder"] != DBNull.Value)
                     _wards.WardOrder = Convert.ToInt32(reader["WardOrder"]);
             _wards.NewRecord = false;             }             reader.Close();
             return _wards;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			WardsDAC wardscomponent = new WardsDAC();
			return wardscomponent.UpdateDataset(dataset);
		}



	}
}
