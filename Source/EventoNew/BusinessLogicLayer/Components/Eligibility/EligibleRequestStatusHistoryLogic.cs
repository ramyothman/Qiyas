using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.Eligibility;
using BusinessLogicLayer.Entities.Eligibility;
namespace BusinessLogicLayer.Components.Eligibility
{
	/// <summary>
	/// This is a Business Logic Component Class  for EligibleRequestStatusHistory table
	/// This class RAPs the EligibleRequestStatusHistoryDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class EligibleRequestStatusHistoryLogic : BusinessLogic
	{
		public EligibleRequestStatusHistoryLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<EligibleRequestStatusHistory> GetAll()
         {
             EligibleRequestStatusHistoryDAC _eligibleRequestStatusHistoryComponent = new EligibleRequestStatusHistoryDAC();
             IDataReader reader =  _eligibleRequestStatusHistoryComponent.GetAllEligibleRequestStatusHistory().CreateDataReader();
             List<EligibleRequestStatusHistory> _eligibleRequestStatusHistoryList = new List<EligibleRequestStatusHistory>();
             while(reader.Read())
             {
             if(_eligibleRequestStatusHistoryList == null)
                 _eligibleRequestStatusHistoryList = new List<EligibleRequestStatusHistory>();
                 EligibleRequestStatusHistory _eligibleRequestStatusHistory = new EligibleRequestStatusHistory();
                 if(reader["EligibilityRequestStatusId"] != DBNull.Value)
                     _eligibleRequestStatusHistory.EligibilityRequestStatusId = Convert.ToInt32(reader["EligibilityRequestStatusId"]);
                 if(reader["EligibilityStatusId"] != DBNull.Value)
                     _eligibleRequestStatusHistory.EligibilityStatusId = Convert.ToInt32(reader["EligibilityStatusId"]);
                 if(reader["EligibileId"] != DBNull.Value)
                     _eligibleRequestStatusHistory.EligibileId = Convert.ToInt32(reader["EligibileId"]);
                 if(reader["CreationDate"] != DBNull.Value)
                     _eligibleRequestStatusHistory.CreationDate = Convert.ToDateTime(reader["CreationDate"]);
                 if(reader["Notes"] != DBNull.Value)
                     _eligibleRequestStatusHistory.Notes = Convert.ToString(reader["Notes"]);
             _eligibleRequestStatusHistory.NewRecord = false;
             _eligibleRequestStatusHistoryList.Add(_eligibleRequestStatusHistory);
             }             reader.Close();
             return _eligibleRequestStatusHistoryList;
         }

        #region Insert And Update
		public bool Insert(EligibleRequestStatusHistory eligiblerequeststatushistory)
		{
			int autonumber = 0;
			EligibleRequestStatusHistoryDAC eligiblerequeststatushistoryComponent = new EligibleRequestStatusHistoryDAC();
			bool endedSuccessfuly = eligiblerequeststatushistoryComponent.InsertNewEligibleRequestStatusHistory( ref autonumber,  eligiblerequeststatushistory.EligibilityStatusId,  eligiblerequeststatushistory.EligibileId,  eligiblerequeststatushistory.CreationDate,  eligiblerequeststatushistory.Notes);
			if(endedSuccessfuly)
			{
				eligiblerequeststatushistory.EligibilityRequestStatusId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int EligibilityRequestStatusId,  int EligibilityStatusId,  int EligibileId,  DateTime CreationDate,  string Notes)
		{
			EligibleRequestStatusHistoryDAC eligiblerequeststatushistoryComponent = new EligibleRequestStatusHistoryDAC();
			return eligiblerequeststatushistoryComponent.InsertNewEligibleRequestStatusHistory( ref EligibilityRequestStatusId,  EligibilityStatusId,  EligibileId,  CreationDate,  Notes);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int EligibilityStatusId,  int EligibileId,  DateTime CreationDate,  string Notes)
		{
			EligibleRequestStatusHistoryDAC eligiblerequeststatushistoryComponent = new EligibleRequestStatusHistoryDAC();
            int EligibilityRequestStatusId = 0;

			return eligiblerequeststatushistoryComponent.InsertNewEligibleRequestStatusHistory( ref EligibilityRequestStatusId,  EligibilityStatusId,  EligibileId,  CreationDate,  Notes);
		}
		public bool Update(EligibleRequestStatusHistory eligiblerequeststatushistory ,int old_eligibilityRequestStatusId)
		{
			EligibleRequestStatusHistoryDAC eligiblerequeststatushistoryComponent = new EligibleRequestStatusHistoryDAC();
			return eligiblerequeststatushistoryComponent.UpdateEligibleRequestStatusHistory( eligiblerequeststatushistory.EligibilityStatusId,  eligiblerequeststatushistory.EligibileId,  eligiblerequeststatushistory.CreationDate,  eligiblerequeststatushistory.Notes,  old_eligibilityRequestStatusId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int EligibilityStatusId,  int EligibileId,  DateTime CreationDate,  string Notes,  int Original_EligibilityRequestStatusId)
		{
			EligibleRequestStatusHistoryDAC eligiblerequeststatushistoryComponent = new EligibleRequestStatusHistoryDAC();
			return eligiblerequeststatushistoryComponent.UpdateEligibleRequestStatusHistory( EligibilityStatusId,  EligibileId,  CreationDate,  Notes,  Original_EligibilityRequestStatusId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_EligibilityRequestStatusId)
		{
			EligibleRequestStatusHistoryDAC eligiblerequeststatushistoryComponent = new EligibleRequestStatusHistoryDAC();
			eligiblerequeststatushistoryComponent.DeleteEligibleRequestStatusHistory(Original_EligibilityRequestStatusId);
		}

        #endregion
         public EligibleRequestStatusHistory GetByID(int _eligibilityRequestStatusId)
         {
             EligibleRequestStatusHistoryDAC _eligibleRequestStatusHistoryComponent = new EligibleRequestStatusHistoryDAC();
             IDataReader reader = _eligibleRequestStatusHistoryComponent.GetByIDEligibleRequestStatusHistory(_eligibilityRequestStatusId);
             EligibleRequestStatusHistory _eligibleRequestStatusHistory = null;
             while(reader.Read())
             {
                 _eligibleRequestStatusHistory = new EligibleRequestStatusHistory();
                 if(reader["EligibilityRequestStatusId"] != DBNull.Value)
                     _eligibleRequestStatusHistory.EligibilityRequestStatusId = Convert.ToInt32(reader["EligibilityRequestStatusId"]);
                 if(reader["EligibilityStatusId"] != DBNull.Value)
                     _eligibleRequestStatusHistory.EligibilityStatusId = Convert.ToInt32(reader["EligibilityStatusId"]);
                 if(reader["EligibileId"] != DBNull.Value)
                     _eligibleRequestStatusHistory.EligibileId = Convert.ToInt32(reader["EligibileId"]);
                 if(reader["CreationDate"] != DBNull.Value)
                     _eligibleRequestStatusHistory.CreationDate = Convert.ToDateTime(reader["CreationDate"]);
                 if(reader["Notes"] != DBNull.Value)
                     _eligibleRequestStatusHistory.Notes = Convert.ToString(reader["Notes"]);
             _eligibleRequestStatusHistory.NewRecord = false;             }             reader.Close();
             return _eligibleRequestStatusHistory;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			EligibleRequestStatusHistoryDAC eligiblerequeststatushistorycomponent = new EligibleRequestStatusHistoryDAC();
			return eligiblerequeststatushistorycomponent.UpdateDataset(dataset);
		}



	}
}
