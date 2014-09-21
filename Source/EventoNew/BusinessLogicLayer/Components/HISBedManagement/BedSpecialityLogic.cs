using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.HISBedManagement;
using BusinessLogicLayer.Entities.HISBedManagement;
namespace BusinessLogicLayer.Components.HISBedManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for BedSpeciality table
	/// This class RAPs the BedSpecialityDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class BedSpecialityLogic : BusinessLogic
	{
		public BedSpecialityLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<BedSpeciality> GetAll()
         {
             BedSpecialityDAC _bedSpecialityComponent = new BedSpecialityDAC();
             IDataReader reader =  _bedSpecialityComponent.GetAllBedSpeciality().CreateDataReader();
             List<BedSpeciality> _bedSpecialityList = new List<BedSpeciality>();
             while(reader.Read())
             {
             if(_bedSpecialityList == null)
                 _bedSpecialityList = new List<BedSpeciality>();
                 BedSpeciality _bedSpeciality = new BedSpeciality();
                 if(reader["BedSpecialityId"] != DBNull.Value)
                     _bedSpeciality.BedSpecialityId = Convert.ToInt32(reader["BedSpecialityId"]);
                 if(reader["WardRoomBedId"] != DBNull.Value)
                     _bedSpeciality.WardRoomBedId = Convert.ToInt32(reader["WardRoomBedId"]);
                 if(reader["SpecialityId"] != DBNull.Value)
                     _bedSpeciality.SpecialityId = Convert.ToInt32(reader["SpecialityId"]);
                 if(reader["IsMainSpeciality"] != DBNull.Value)
                     _bedSpeciality.IsMainSpeciality = Convert.ToBoolean(reader["IsMainSpeciality"]);
                 if(reader["SpecialityOrder"] != DBNull.Value)
                     _bedSpeciality.SpecialityOrder = Convert.ToInt32(reader["SpecialityOrder"]);
             _bedSpeciality.NewRecord = false;
             _bedSpecialityList.Add(_bedSpeciality);
             }             reader.Close();
             return _bedSpecialityList;
         }

        #region Insert And Update
		public bool Insert(BedSpeciality bedspeciality)
		{
			int autonumber = 0;
			BedSpecialityDAC bedspecialityComponent = new BedSpecialityDAC();
			bool endedSuccessfuly = bedspecialityComponent.InsertNewBedSpeciality( ref autonumber,  bedspeciality.WardRoomBedId,  bedspeciality.SpecialityId,  bedspeciality.IsMainSpeciality,  bedspeciality.SpecialityOrder);
			if(endedSuccessfuly)
			{
				bedspeciality.BedSpecialityId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int BedSpecialityId,  int WardRoomBedId,  int SpecialityId,  bool IsMainSpeciality,  int SpecialityOrder)
		{
			BedSpecialityDAC bedspecialityComponent = new BedSpecialityDAC();
			return bedspecialityComponent.InsertNewBedSpeciality( ref BedSpecialityId,  WardRoomBedId,  SpecialityId,  IsMainSpeciality,  SpecialityOrder);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int WardRoomBedId,  int SpecialityId,  bool IsMainSpeciality,  int SpecialityOrder)
		{
			BedSpecialityDAC bedspecialityComponent = new BedSpecialityDAC();
            int BedSpecialityId = 0;

			return bedspecialityComponent.InsertNewBedSpeciality( ref BedSpecialityId,  WardRoomBedId,  SpecialityId,  IsMainSpeciality,  SpecialityOrder);
		}
		public bool Update(BedSpeciality bedspeciality ,int old_bedSpecialityId)
		{
			BedSpecialityDAC bedspecialityComponent = new BedSpecialityDAC();
			return bedspecialityComponent.UpdateBedSpeciality( bedspeciality.WardRoomBedId,  bedspeciality.SpecialityId,  bedspeciality.IsMainSpeciality,  bedspeciality.SpecialityOrder,  old_bedSpecialityId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int WardRoomBedId,  int SpecialityId,  bool IsMainSpeciality,  int SpecialityOrder,  int Original_BedSpecialityId)
		{
			BedSpecialityDAC bedspecialityComponent = new BedSpecialityDAC();
			return bedspecialityComponent.UpdateBedSpeciality( WardRoomBedId,  SpecialityId,  IsMainSpeciality,  SpecialityOrder,  Original_BedSpecialityId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_BedSpecialityId)
		{
			BedSpecialityDAC bedspecialityComponent = new BedSpecialityDAC();
			bedspecialityComponent.DeleteBedSpeciality(Original_BedSpecialityId);
		}

        #endregion
         public BedSpeciality GetByID(int _bedSpecialityId)
         {
             BedSpecialityDAC _bedSpecialityComponent = new BedSpecialityDAC();
             IDataReader reader = _bedSpecialityComponent.GetByIDBedSpeciality(_bedSpecialityId);
             BedSpeciality _bedSpeciality = null;
             while(reader.Read())
             {
                 _bedSpeciality = new BedSpeciality();
                 if(reader["BedSpecialityId"] != DBNull.Value)
                     _bedSpeciality.BedSpecialityId = Convert.ToInt32(reader["BedSpecialityId"]);
                 if(reader["WardRoomBedId"] != DBNull.Value)
                     _bedSpeciality.WardRoomBedId = Convert.ToInt32(reader["WardRoomBedId"]);
                 if(reader["SpecialityId"] != DBNull.Value)
                     _bedSpeciality.SpecialityId = Convert.ToInt32(reader["SpecialityId"]);
                 if(reader["IsMainSpeciality"] != DBNull.Value)
                     _bedSpeciality.IsMainSpeciality = Convert.ToBoolean(reader["IsMainSpeciality"]);
                 if(reader["SpecialityOrder"] != DBNull.Value)
                     _bedSpeciality.SpecialityOrder = Convert.ToInt32(reader["SpecialityOrder"]);
             _bedSpeciality.NewRecord = false;             }             reader.Close();
             return _bedSpeciality;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			BedSpecialityDAC bedspecialitycomponent = new BedSpecialityDAC();
			return bedspecialitycomponent.UpdateDataset(dataset);
		}



	}
}
