using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.PGME;
using BusinessLogicLayer.Entities.PGME;
namespace BusinessLogicLayer.Components.PGME
{
	/// <summary>
	/// This is a Business Logic Component Class  for PersonRegisterationStatus table
	/// This class RAPs the PersonRegisterationStatusDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class PersonRegisterationStatusLogic : BusinessLogic
	{
		public PersonRegisterationStatusLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<PersonRegisterationStatus> GetAll()
         {
             PersonRegisterationStatusDAC _personRegisterationStatusComponent = new PersonRegisterationStatusDAC();
             IDataReader reader =  _personRegisterationStatusComponent.GetAllPersonRegisterationStatus().CreateDataReader();
             List<PersonRegisterationStatus> _personRegisterationStatusList = new List<PersonRegisterationStatus>();
             while(reader.Read())
             {
             if(_personRegisterationStatusList == null)
                 _personRegisterationStatusList = new List<PersonRegisterationStatus>();
                 PersonRegisterationStatus _personRegisterationStatus = new PersonRegisterationStatus();
                 if(reader["PersonRegisterationStatusId"] != DBNull.Value)
                     _personRegisterationStatus.PersonRegisterationStatusId = Convert.ToInt32(reader["PersonRegisterationStatusId"]);
                 if(reader["Status"] != DBNull.Value)
                     _personRegisterationStatus.Status = Convert.ToString(reader["Status"]);
             _personRegisterationStatus.NewRecord = false;
             _personRegisterationStatusList.Add(_personRegisterationStatus);
             }             reader.Close();
             return _personRegisterationStatusList;
         }

        #region Insert And Update
		public bool Insert(PersonRegisterationStatus personregisterationstatus)
		{
			int autonumber = 0;
			PersonRegisterationStatusDAC personregisterationstatusComponent = new PersonRegisterationStatusDAC();
			bool endedSuccessfuly = personregisterationstatusComponent.InsertNewPersonRegisterationStatus( ref autonumber,  personregisterationstatus.Status);
			if(endedSuccessfuly)
			{
				personregisterationstatus.PersonRegisterationStatusId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int PersonRegisterationStatusId,  string Status)
		{
			PersonRegisterationStatusDAC personregisterationstatusComponent = new PersonRegisterationStatusDAC();
			return personregisterationstatusComponent.InsertNewPersonRegisterationStatus( ref PersonRegisterationStatusId,  Status);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( string Status)
		{
			PersonRegisterationStatusDAC personregisterationstatusComponent = new PersonRegisterationStatusDAC();
            int PersonRegisterationStatusId = 0;

			return personregisterationstatusComponent.InsertNewPersonRegisterationStatus( ref PersonRegisterationStatusId,  Status);
		}
		public bool Update(PersonRegisterationStatus personregisterationstatus ,int old_personRegisterationStatusId)
		{
			PersonRegisterationStatusDAC personregisterationstatusComponent = new PersonRegisterationStatusDAC();
			return personregisterationstatusComponent.UpdatePersonRegisterationStatus( personregisterationstatus.Status,  old_personRegisterationStatusId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( string Status,  int Original_PersonRegisterationStatusId)
		{
			PersonRegisterationStatusDAC personregisterationstatusComponent = new PersonRegisterationStatusDAC();
			return personregisterationstatusComponent.UpdatePersonRegisterationStatus( Status,  Original_PersonRegisterationStatusId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_PersonRegisterationStatusId)
		{
			PersonRegisterationStatusDAC personregisterationstatusComponent = new PersonRegisterationStatusDAC();
			personregisterationstatusComponent.DeletePersonRegisterationStatus(Original_PersonRegisterationStatusId);
		}

        #endregion
         public PersonRegisterationStatus GetByID(int _personRegisterationStatusId)
         {
             PersonRegisterationStatusDAC _personRegisterationStatusComponent = new PersonRegisterationStatusDAC();
             IDataReader reader = _personRegisterationStatusComponent.GetByIDPersonRegisterationStatus(_personRegisterationStatusId);
             PersonRegisterationStatus _personRegisterationStatus = null;
             while(reader.Read())
             {
                 _personRegisterationStatus = new PersonRegisterationStatus();
                 if(reader["PersonRegisterationStatusId"] != DBNull.Value)
                     _personRegisterationStatus.PersonRegisterationStatusId = Convert.ToInt32(reader["PersonRegisterationStatusId"]);
                 if(reader["Status"] != DBNull.Value)
                     _personRegisterationStatus.Status = Convert.ToString(reader["Status"]);
             _personRegisterationStatus.NewRecord = false;             }             reader.Close();
             return _personRegisterationStatus;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			PersonRegisterationStatusDAC personregisterationstatuscomponent = new PersonRegisterationStatusDAC();
			return personregisterationstatuscomponent.UpdateDataset(dataset);
		}



	}
}
