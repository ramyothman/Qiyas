using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.Eligibility;
using BusinessLogicLayer.Entities.Eligibility;
namespace BusinessLogicLayer.Components.Eligibility
{
	/// <summary>
	/// This is a Business Logic Component Class  for EligibilityStatus table
	/// This class RAPs the EligibilityStatusDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class EligibilityStatusLogic : BusinessLogic
	{
		public EligibilityStatusLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<EligibilityStatus> GetAll()
         {
             EligibilityStatusDAC _eligibilityStatusComponent = new EligibilityStatusDAC();
             IDataReader reader =  _eligibilityStatusComponent.GetAllEligibilityStatus().CreateDataReader();
             List<EligibilityStatus> _eligibilityStatusList = new List<EligibilityStatus>();
             while(reader.Read())
             {
             if(_eligibilityStatusList == null)
                 _eligibilityStatusList = new List<EligibilityStatus>();
                 EligibilityStatus _eligibilityStatus = new EligibilityStatus();
                 if(reader["EligibilityStatusId"] != DBNull.Value)
                     _eligibilityStatus.EligibilityStatusId = Convert.ToInt32(reader["EligibilityStatusId"]);
                 if(reader["Name"] != DBNull.Value)
                     _eligibilityStatus.Name = Convert.ToString(reader["Name"]);
             _eligibilityStatus.NewRecord = false;
             _eligibilityStatusList.Add(_eligibilityStatus);
             }             reader.Close();
             return _eligibilityStatusList;
         }

        #region Insert And Update
		public bool Insert(EligibilityStatus eligibilitystatus)
		{
			int autonumber = 0;
			EligibilityStatusDAC eligibilitystatusComponent = new EligibilityStatusDAC();
			bool endedSuccessfuly = eligibilitystatusComponent.InsertNewEligibilityStatus( ref autonumber,  eligibilitystatus.Name);
			if(endedSuccessfuly)
			{
				eligibilitystatus.EligibilityStatusId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int EligibilityStatusId,  string Name)
		{
			EligibilityStatusDAC eligibilitystatusComponent = new EligibilityStatusDAC();
			return eligibilitystatusComponent.InsertNewEligibilityStatus( ref EligibilityStatusId,  Name);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( string Name)
		{
			EligibilityStatusDAC eligibilitystatusComponent = new EligibilityStatusDAC();
            int EligibilityStatusId = 0;

			return eligibilitystatusComponent.InsertNewEligibilityStatus( ref EligibilityStatusId,  Name);
		}
		public bool Update(EligibilityStatus eligibilitystatus ,int old_eligibilityStatusId)
		{
			EligibilityStatusDAC eligibilitystatusComponent = new EligibilityStatusDAC();
			return eligibilitystatusComponent.UpdateEligibilityStatus( eligibilitystatus.Name,  old_eligibilityStatusId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( string Name,  int Original_EligibilityStatusId)
		{
			EligibilityStatusDAC eligibilitystatusComponent = new EligibilityStatusDAC();
			return eligibilitystatusComponent.UpdateEligibilityStatus( Name,  Original_EligibilityStatusId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_EligibilityStatusId)
		{
			EligibilityStatusDAC eligibilitystatusComponent = new EligibilityStatusDAC();
			eligibilitystatusComponent.DeleteEligibilityStatus(Original_EligibilityStatusId);
		}

        #endregion
         public EligibilityStatus GetByID(int _eligibilityStatusId)
         {
             EligibilityStatusDAC _eligibilityStatusComponent = new EligibilityStatusDAC();
             IDataReader reader = _eligibilityStatusComponent.GetByIDEligibilityStatus(_eligibilityStatusId);
             EligibilityStatus _eligibilityStatus = null;
             while(reader.Read())
             {
                 _eligibilityStatus = new EligibilityStatus();
                 if(reader["EligibilityStatusId"] != DBNull.Value)
                     _eligibilityStatus.EligibilityStatusId = Convert.ToInt32(reader["EligibilityStatusId"]);
                 if(reader["Name"] != DBNull.Value)
                     _eligibilityStatus.Name = Convert.ToString(reader["Name"]);
             _eligibilityStatus.NewRecord = false;             }             reader.Close();
             return _eligibilityStatus;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			EligibilityStatusDAC eligibilitystatuscomponent = new EligibilityStatusDAC();
			return eligibilitystatuscomponent.UpdateDataset(dataset);
		}



	}
}
