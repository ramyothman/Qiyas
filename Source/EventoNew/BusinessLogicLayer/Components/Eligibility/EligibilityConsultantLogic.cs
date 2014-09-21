using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.Eligibility;
using BusinessLogicLayer.Entities.Eligibility;
namespace BusinessLogicLayer.Components.Eligibility
{
	/// <summary>
	/// This is a Business Logic Component Class  for EligibilityConsultant table
	/// This class RAPs the EligibilityConsultantDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class EligibilityConsultantLogic : BusinessLogic
	{
		public EligibilityConsultantLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<EligibilityConsultant> GetAll()
         {
             EligibilityConsultantDAC _eligibilityConsultantComponent = new EligibilityConsultantDAC();
             IDataReader reader =  _eligibilityConsultantComponent.GetAllEligibilityConsultant().CreateDataReader();
             List<EligibilityConsultant> _eligibilityConsultantList = new List<EligibilityConsultant>();
             while(reader.Read())
             {
             if(_eligibilityConsultantList == null)
                 _eligibilityConsultantList = new List<EligibilityConsultant>();
                 EligibilityConsultant _eligibilityConsultant = new EligibilityConsultant();
                 if(reader["EligibilityConsultantId"] != DBNull.Value)
                     _eligibilityConsultant.EligibilityConsultantId = Convert.ToInt32(reader["EligibilityConsultantId"]);
                 if(reader["EligibilityDepartmentId"] != DBNull.Value)
                     _eligibilityConsultant.EligibilityDepartmentId = Convert.ToInt32(reader["EligibilityDepartmentId"]);
                 if(reader["PersonId"] != DBNull.Value)
                     _eligibilityConsultant.PersonId = Convert.ToInt32(reader["PersonId"]);
                 if(reader["DateAssigned"] != DBNull.Value)
                     _eligibilityConsultant.DateAssigned = Convert.ToDateTime(reader["DateAssigned"]);
             _eligibilityConsultant.NewRecord = false;
             _eligibilityConsultantList.Add(_eligibilityConsultant);
             }             reader.Close();
             return _eligibilityConsultantList;
         }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<EligibilityConsultant> GetAllByDivision(int DivisionID)
        {
            EligibilityConsultantDAC _eligibilityConsultantComponent = new EligibilityConsultantDAC();
            IDataReader reader = _eligibilityConsultantComponent.GetAllEligibilityConsultant("DivisionID = " + DivisionID).CreateDataReader();
            List<EligibilityConsultant> _eligibilityConsultantList = new List<EligibilityConsultant>();
            while (reader.Read())
            {
                if (_eligibilityConsultantList == null)
                    _eligibilityConsultantList = new List<EligibilityConsultant>();
                EligibilityConsultant _eligibilityConsultant = new EligibilityConsultant();
                if (reader["EligibilityConsultantId"] != DBNull.Value)
                    _eligibilityConsultant.EligibilityConsultantId = Convert.ToInt32(reader["EligibilityConsultantId"]);
                if (reader["EligibilityDepartmentId"] != DBNull.Value)
                    _eligibilityConsultant.EligibilityDepartmentId = Convert.ToInt32(reader["EligibilityDepartmentId"]);
                if (reader["DivisionID"] != DBNull.Value)
                    _eligibilityConsultant.DivisionID = Convert.ToInt32(reader["DivisionID"]);
                if (reader["PersonId"] != DBNull.Value)
                    _eligibilityConsultant.PersonId = Convert.ToInt32(reader["PersonId"]);
                if (reader["DateAssigned"] != DBNull.Value)
                    _eligibilityConsultant.DateAssigned = Convert.ToDateTime(reader["DateAssigned"]);
                _eligibilityConsultant.NewRecord = false;
                _eligibilityConsultantList.Add(_eligibilityConsultant);
            } reader.Close();
            return _eligibilityConsultantList;
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<EligibilityConsultant> GetAllByDepartmentId(int EligibilityDepartmentId)
        {
            EligibilityConsultantDAC _eligibilityConsultantComponent = new EligibilityConsultantDAC();
            IDataReader reader = _eligibilityConsultantComponent.GetAllEligibilityConsultant("EligibilityDepartmentId = " + EligibilityDepartmentId).CreateDataReader();
            List<EligibilityConsultant> _eligibilityConsultantList = new List<EligibilityConsultant>();
            while (reader.Read())
            {
                if (_eligibilityConsultantList == null)
                    _eligibilityConsultantList = new List<EligibilityConsultant>();
                EligibilityConsultant _eligibilityConsultant = new EligibilityConsultant();
                if (reader["EligibilityConsultantId"] != DBNull.Value)
                    _eligibilityConsultant.EligibilityConsultantId = Convert.ToInt32(reader["EligibilityConsultantId"]);
                if (reader["EligibilityDepartmentId"] != DBNull.Value)
                    _eligibilityConsultant.EligibilityDepartmentId = Convert.ToInt32(reader["EligibilityDepartmentId"]);
                if (reader["PersonId"] != DBNull.Value)
                    _eligibilityConsultant.PersonId = Convert.ToInt32(reader["PersonId"]);
                if (reader["DateAssigned"] != DBNull.Value)
                    _eligibilityConsultant.DateAssigned = Convert.ToDateTime(reader["DateAssigned"]);
                _eligibilityConsultant.NewRecord = false;
                _eligibilityConsultantList.Add(_eligibilityConsultant);
            } reader.Close();
            return _eligibilityConsultantList;
        }
        #region Insert And Update
		public bool Insert(EligibilityConsultant eligibilityconsultant)
		{
			int autonumber = 0;
			EligibilityConsultantDAC eligibilityconsultantComponent = new EligibilityConsultantDAC();
			bool endedSuccessfuly = eligibilityconsultantComponent.InsertNewEligibilityConsultant( ref autonumber,  eligibilityconsultant.EligibilityDepartmentId,eligibilityconsultant.DivisionID,  eligibilityconsultant.PersonId,  eligibilityconsultant.DateAssigned,eligibilityconsultant.Poisition);
			if(endedSuccessfuly)
			{
				eligibilityconsultant.EligibilityConsultantId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int EligibilityConsultantId,  int EligibilityDepartmentId,int DivisionID,  int PersonId,string Position,  DateTime DateAssigned)
		{
			EligibilityConsultantDAC eligibilityconsultantComponent = new EligibilityConsultantDAC();
			return eligibilityconsultantComponent.InsertNewEligibilityConsultant( ref EligibilityConsultantId,  EligibilityDepartmentId,DivisionID,  PersonId,  DateAssigned,Position);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int EligibilityDepartmentId,int DivisionID,  int PersonId,  DateTime DateAssigned,string Position)
		{
			EligibilityConsultantDAC eligibilityconsultantComponent = new EligibilityConsultantDAC();
            int EligibilityConsultantId = 0;

			return eligibilityconsultantComponent.InsertNewEligibilityConsultant( ref EligibilityConsultantId,  EligibilityDepartmentId,DivisionID,  PersonId,  DateTime.Now,Position);
		}
		public bool Update(EligibilityConsultant eligibilityconsultant ,int old_eligibilityConsultantId)
		{
			EligibilityConsultantDAC eligibilityconsultantComponent = new EligibilityConsultantDAC();
			return eligibilityconsultantComponent.UpdateEligibilityConsultant( eligibilityconsultant.EligibilityDepartmentId,eligibilityconsultant.DivisionID,  eligibilityconsultant.PersonId,  eligibilityconsultant.DateAssigned,eligibilityconsultant.Poisition,  old_eligibilityConsultantId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int EligibilityDepartmentId,int DivisionID,  int PersonId,  DateTime DateAssigned,string Position,  int Original_EligibilityConsultantId)
		{
			EligibilityConsultantDAC eligibilityconsultantComponent = new EligibilityConsultantDAC();
			return eligibilityconsultantComponent.UpdateEligibilityConsultant( EligibilityDepartmentId,DivisionID,  PersonId,  DateTime.Now,Position,  Original_EligibilityConsultantId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_EligibilityConsultantId)
		{
			EligibilityConsultantDAC eligibilityconsultantComponent = new EligibilityConsultantDAC();
			eligibilityconsultantComponent.DeleteEligibilityConsultant(Original_EligibilityConsultantId);
		}

        #endregion
         public EligibilityConsultant GetByID(int _eligibilityConsultantId)
         {
             EligibilityConsultantDAC _eligibilityConsultantComponent = new EligibilityConsultantDAC();
             IDataReader reader = _eligibilityConsultantComponent.GetByIDEligibilityConsultant(_eligibilityConsultantId);
             EligibilityConsultant _eligibilityConsultant = null;
             while(reader.Read())
             {
                 _eligibilityConsultant = new EligibilityConsultant();
                 if(reader["EligibilityConsultantId"] != DBNull.Value)
                     _eligibilityConsultant.EligibilityConsultantId = Convert.ToInt32(reader["EligibilityConsultantId"]);
                 if(reader["EligibilityDepartmentId"] != DBNull.Value)
                     _eligibilityConsultant.EligibilityDepartmentId = Convert.ToInt32(reader["EligibilityDepartmentId"]);
                 if(reader["PersonId"] != DBNull.Value)
                     _eligibilityConsultant.PersonId = Convert.ToInt32(reader["PersonId"]);
                 if(reader["DateAssigned"] != DBNull.Value)
                     _eligibilityConsultant.DateAssigned = Convert.ToDateTime(reader["DateAssigned"]);
             _eligibilityConsultant.NewRecord = false;             }             reader.Close();
             return _eligibilityConsultant;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			EligibilityConsultantDAC eligibilityconsultantcomponent = new EligibilityConsultantDAC();
			return eligibilityconsultantcomponent.UpdateDataset(dataset);
		}



	}
}
