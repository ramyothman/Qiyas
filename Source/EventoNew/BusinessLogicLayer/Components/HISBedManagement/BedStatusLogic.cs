using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.HISBedManagement;
using BusinessLogicLayer.Entities.HISBedManagement;
namespace BusinessLogicLayer.Components.HISBedManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for BedStatus table
	/// This class RAPs the BedStatusDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class BedStatusLogic : BusinessLogic
	{
		public BedStatusLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<BedStatus> GetAll()
         {
             BedStatusDAC _bedStatusComponent = new BedStatusDAC();
             IDataReader reader =  _bedStatusComponent.GetAllBedStatus().CreateDataReader();
             List<BedStatus> _bedStatusList = new List<BedStatus>();
             while(reader.Read())
             {
             if(_bedStatusList == null)
                 _bedStatusList = new List<BedStatus>();
                 BedStatus _bedStatus = new BedStatus();
                 if(reader["BedStatusId"] != DBNull.Value)
                     _bedStatus.BedStatusId = Convert.ToInt32(reader["BedStatusId"]);
                 if(reader["BedStatusName"] != DBNull.Value)
                     _bedStatus.BedStatusName = Convert.ToString(reader["BedStatusName"]);
             _bedStatus.NewRecord = false;
             _bedStatusList.Add(_bedStatus);
             }             reader.Close();
             return _bedStatusList;
         }

        #region Insert And Update
		public bool Insert(BedStatus bedstatus)
		{
			int autonumber = 0;
			BedStatusDAC bedstatusComponent = new BedStatusDAC();
			bool endedSuccessfuly = bedstatusComponent.InsertNewBedStatus( ref autonumber,  bedstatus.BedStatusName);
			if(endedSuccessfuly)
			{
				bedstatus.BedStatusId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int BedStatusId,  string BedStatusName)
		{
			BedStatusDAC bedstatusComponent = new BedStatusDAC();
			return bedstatusComponent.InsertNewBedStatus( ref BedStatusId,  BedStatusName);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( string BedStatusName)
		{
			BedStatusDAC bedstatusComponent = new BedStatusDAC();
            int BedStatusId = 0;

			return bedstatusComponent.InsertNewBedStatus( ref BedStatusId,  BedStatusName);
		}
		public bool Update(BedStatus bedstatus ,int old_bedStatusId)
		{
			BedStatusDAC bedstatusComponent = new BedStatusDAC();
			return bedstatusComponent.UpdateBedStatus( bedstatus.BedStatusName,  old_bedStatusId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( string BedStatusName,  int Original_BedStatusId)
		{
			BedStatusDAC bedstatusComponent = new BedStatusDAC();
			return bedstatusComponent.UpdateBedStatus( BedStatusName,  Original_BedStatusId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_BedStatusId)
		{
			BedStatusDAC bedstatusComponent = new BedStatusDAC();
			bedstatusComponent.DeleteBedStatus(Original_BedStatusId);
		}

        #endregion
         public BedStatus GetByID(int _bedStatusId)
         {
             BedStatusDAC _bedStatusComponent = new BedStatusDAC();
             IDataReader reader = _bedStatusComponent.GetByIDBedStatus(_bedStatusId);
             BedStatus _bedStatus = null;
             while(reader.Read())
             {
                 _bedStatus = new BedStatus();
                 if(reader["BedStatusId"] != DBNull.Value)
                     _bedStatus.BedStatusId = Convert.ToInt32(reader["BedStatusId"]);
                 if(reader["BedStatusName"] != DBNull.Value)
                     _bedStatus.BedStatusName = Convert.ToString(reader["BedStatusName"]);
             _bedStatus.NewRecord = false;             }             reader.Close();
             return _bedStatus;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			BedStatusDAC bedstatuscomponent = new BedStatusDAC();
			return bedstatuscomponent.UpdateDataset(dataset);
		}



	}
}
