using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.BedManagement;
using BusinessLogicLayer.Entities.BedManagement;
namespace BusinessLogicLayer.Components.BedManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for WardSpeciality table
	/// This class RAPs the WardSpecialityDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class WardSpecialityLogic : BusinessLogic
	{
		public WardSpecialityLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<WardSpeciality> GetAll()
         {
             WardSpecialityDAC _wardSpecialityComponent = new WardSpecialityDAC();
             IDataReader reader =  _wardSpecialityComponent.GetAllWardSpeciality().CreateDataReader();
             List<WardSpeciality> _wardSpecialityList = new List<WardSpeciality>();
             while(reader.Read())
             {
             if(_wardSpecialityList == null)
                 _wardSpecialityList = new List<WardSpeciality>();
                 WardSpeciality _wardSpeciality = new WardSpeciality();
                 if(reader["WardSpecialityId"] != DBNull.Value)
                     _wardSpeciality.WardSpecialityId = Convert.ToInt32(reader["WardSpecialityId"]);
                 if(reader["WardId"] != DBNull.Value)
                     _wardSpeciality.WardId = Convert.ToInt32(reader["WardId"]);
                 if(reader["SpecialityId"] != DBNull.Value)
                     _wardSpeciality.SpecialityId = Convert.ToInt32(reader["SpecialityId"]);
                 if(reader["IsMain"] != DBNull.Value)
                     _wardSpeciality.IsMain = Convert.ToBoolean(reader["IsMain"]);
             _wardSpeciality.NewRecord = false;
             _wardSpecialityList.Add(_wardSpeciality);
             }             reader.Close();
             return _wardSpecialityList;
         }

        #region Insert And Update
		public bool Insert(WardSpeciality wardspeciality)
		{
			int autonumber = 0;
			WardSpecialityDAC wardspecialityComponent = new WardSpecialityDAC();
			bool endedSuccessfuly = wardspecialityComponent.InsertNewWardSpeciality( ref autonumber,  wardspeciality.WardId,  wardspeciality.SpecialityId,  wardspeciality.IsMain);
			if(endedSuccessfuly)
			{
				wardspeciality.WardSpecialityId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int WardSpecialityId,  int WardId,  int SpecialityId,  bool IsMain)
		{
			WardSpecialityDAC wardspecialityComponent = new WardSpecialityDAC();
			return wardspecialityComponent.InsertNewWardSpeciality( ref WardSpecialityId,  WardId,  SpecialityId,  IsMain);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int WardId,  int SpecialityId,  bool IsMain)
		{
			WardSpecialityDAC wardspecialityComponent = new WardSpecialityDAC();
            int WardSpecialityId = 0;

			return wardspecialityComponent.InsertNewWardSpeciality( ref WardSpecialityId,  WardId,  SpecialityId,  IsMain);
		}
		public bool Update(WardSpeciality wardspeciality ,int old_wardSpecialityId)
		{
			WardSpecialityDAC wardspecialityComponent = new WardSpecialityDAC();
			return wardspecialityComponent.UpdateWardSpeciality( wardspeciality.WardId,  wardspeciality.SpecialityId,  wardspeciality.IsMain,  old_wardSpecialityId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int WardId,  int SpecialityId,  bool IsMain,  int Original_WardSpecialityId)
		{
			WardSpecialityDAC wardspecialityComponent = new WardSpecialityDAC();
			return wardspecialityComponent.UpdateWardSpeciality( WardId,  SpecialityId,  IsMain,  Original_WardSpecialityId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_WardSpecialityId)
		{
			WardSpecialityDAC wardspecialityComponent = new WardSpecialityDAC();
			wardspecialityComponent.DeleteWardSpeciality(Original_WardSpecialityId);
		}

        #endregion
         public WardSpeciality GetByID(int _wardSpecialityId)
         {
             WardSpecialityDAC _wardSpecialityComponent = new WardSpecialityDAC();
             IDataReader reader = _wardSpecialityComponent.GetByIDWardSpeciality(_wardSpecialityId);
             WardSpeciality _wardSpeciality = null;
             while(reader.Read())
             {
                 _wardSpeciality = new WardSpeciality();
                 if(reader["WardSpecialityId"] != DBNull.Value)
                     _wardSpeciality.WardSpecialityId = Convert.ToInt32(reader["WardSpecialityId"]);
                 if(reader["WardId"] != DBNull.Value)
                     _wardSpeciality.WardId = Convert.ToInt32(reader["WardId"]);
                 if(reader["SpecialityId"] != DBNull.Value)
                     _wardSpeciality.SpecialityId = Convert.ToInt32(reader["SpecialityId"]);
                 if(reader["IsMain"] != DBNull.Value)
                     _wardSpeciality.IsMain = Convert.ToBoolean(reader["IsMain"]);
             _wardSpeciality.NewRecord = false;             }             reader.Close();
             return _wardSpeciality;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			WardSpecialityDAC wardspecialitycomponent = new WardSpecialityDAC();
			return wardspecialitycomponent.UpdateDataset(dataset);
		}



	}
}
