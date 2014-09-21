using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.HISBedManagement;
using BusinessLogicLayer.Entities.HISBedManagement;
namespace BusinessLogicLayer.Components.HISBedManagement
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
                 if(reader["WardSpeciality"] != DBNull.Value)
                     _wardSpeciality.WardSpecialityId = Convert.ToInt32(reader["WardSpeciality"]);
                 if(reader["WardId"] != DBNull.Value)
                     _wardSpeciality.WardId = Convert.ToInt32(reader["WardId"]);
                 if(reader["SpecialityId"] != DBNull.Value)
                     _wardSpeciality.SpecialityId = Convert.ToInt32(reader["SpecialityId"]);
                 if(reader["IsMainSpeciality"] != DBNull.Value)
                     _wardSpeciality.IsMainSpeciality = Convert.ToBoolean(reader["IsMainSpeciality"]);
                 if(reader["SpecialityOrder"] != DBNull.Value)
                     _wardSpeciality.SpecialityOrder = Convert.ToInt32(reader["SpecialityOrder"]);
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
			bool endedSuccessfuly = wardspecialityComponent.InsertNewWardSpeciality( ref autonumber,  wardspeciality.WardId,  wardspeciality.SpecialityId,  wardspeciality.IsMainSpeciality,  wardspeciality.SpecialityOrder);
			if(endedSuccessfuly)
			{
				wardspeciality.WardSpecialityId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int WardSpeciality,  int WardId,  int SpecialityId,  bool IsMainSpeciality,  int SpecialityOrder)
		{
			WardSpecialityDAC wardspecialityComponent = new WardSpecialityDAC();
			return wardspecialityComponent.InsertNewWardSpeciality( ref WardSpeciality,  WardId,  SpecialityId,  IsMainSpeciality,  SpecialityOrder);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int WardId,  int SpecialityId,  bool IsMainSpeciality,  int SpecialityOrder)
		{
			WardSpecialityDAC wardspecialityComponent = new WardSpecialityDAC();
            int WardSpeciality = 0;

			return wardspecialityComponent.InsertNewWardSpeciality( ref WardSpeciality,  WardId,  SpecialityId,  IsMainSpeciality,  SpecialityOrder);
		}
		public bool Update(WardSpeciality wardspeciality ,int old_wardSpeciality)
		{
			WardSpecialityDAC wardspecialityComponent = new WardSpecialityDAC();
			return wardspecialityComponent.UpdateWardSpeciality( wardspeciality.WardId,  wardspeciality.SpecialityId,  wardspeciality.IsMainSpeciality,  wardspeciality.SpecialityOrder,  old_wardSpeciality);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int WardId,  int SpecialityId,  bool IsMainSpeciality,  int SpecialityOrder,  int Original_WardSpeciality)
		{
			WardSpecialityDAC wardspecialityComponent = new WardSpecialityDAC();
			return wardspecialityComponent.UpdateWardSpeciality( WardId,  SpecialityId,  IsMainSpeciality,  SpecialityOrder,  Original_WardSpeciality);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_WardSpeciality)
		{
			WardSpecialityDAC wardspecialityComponent = new WardSpecialityDAC();
			wardspecialityComponent.DeleteWardSpeciality(Original_WardSpeciality);
		}

        #endregion
         public WardSpeciality GetByID(int _wardSpeciality)
         {
             WardSpecialityDAC _wardSpecialityComponent = new WardSpecialityDAC();
             IDataReader reader = _wardSpecialityComponent.GetByIDWardSpeciality(_wardSpeciality);
             WardSpeciality _wardSpecialitys = null;
             while(reader.Read())
             {
                 _wardSpecialitys = new WardSpeciality();
                 if(reader["WardSpeciality"] != DBNull.Value)
                     _wardSpecialitys.WardSpecialityId = Convert.ToInt32(reader["WardSpeciality"]);
                 if(reader["WardId"] != DBNull.Value)
                     _wardSpecialitys.WardId = Convert.ToInt32(reader["WardId"]);
                 if(reader["SpecialityId"] != DBNull.Value)
                     _wardSpecialitys.SpecialityId = Convert.ToInt32(reader["SpecialityId"]);
                 if(reader["IsMainSpeciality"] != DBNull.Value)
                     _wardSpecialitys.IsMainSpeciality = Convert.ToBoolean(reader["IsMainSpeciality"]);
                 if(reader["SpecialityOrder"] != DBNull.Value)
                     _wardSpecialitys.SpecialityOrder = Convert.ToInt32(reader["SpecialityOrder"]);
                 _wardSpecialitys.NewRecord = false;
             } reader.Close();
             return _wardSpecialitys;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			WardSpecialityDAC wardspecialitycomponent = new WardSpecialityDAC();
			return wardspecialitycomponent.UpdateDataset(dataset);
		}



	}
}
