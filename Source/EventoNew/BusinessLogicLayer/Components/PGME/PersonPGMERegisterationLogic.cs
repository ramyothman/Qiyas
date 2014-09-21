using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.PGME;
using BusinessLogicLayer.Entities.PGME;
namespace BusinessLogicLayer.Components.PGME
{
	/// <summary>
	/// This is a Business Logic Component Class  for PersonPGMERegisteration table
	/// This class RAPs the PersonPGMERegisterationDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class PersonPGMERegisterationLogic : BusinessLogic
	{
		public PersonPGMERegisterationLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<PersonPGMERegisteration> GetAll()
         {
             PersonPGMERegisterationDAC _personPGMERegisterationComponent = new PersonPGMERegisterationDAC();
             IDataReader reader =  _personPGMERegisterationComponent.GetAllPersonPGMERegisteration().CreateDataReader();
             List<PersonPGMERegisteration> _personPGMERegisterationList = new List<PersonPGMERegisteration>();
             while(reader.Read())
             {
             if(_personPGMERegisterationList == null)
                 _personPGMERegisterationList = new List<PersonPGMERegisteration>();
                 PersonPGMERegisteration _personPGMERegisteration = new PersonPGMERegisteration();
                 if(reader["PersonRegisterationId"] != DBNull.Value)
                     _personPGMERegisteration.PersonRegisterationId = Convert.ToInt32(reader["PersonRegisterationId"]);
                 if(reader["PersonId"] != DBNull.Value)
                     _personPGMERegisteration.PersonId = Convert.ToInt32(reader["PersonId"]);
                 if(reader["PersonProgramId"] != DBNull.Value)
                     _personPGMERegisteration.PersonProgramId = Convert.ToInt32(reader["PersonProgramId"]);
                 if(reader["PersonRegisterationStatusId"] != DBNull.Value)
                     _personPGMERegisteration.PersonRegisterationStatusId = Convert.ToInt32(reader["PersonRegisterationStatusId"]);
                 if(reader["RegisterationNumber"] != DBNull.Value)
                     _personPGMERegisteration.RegisterationNumber = Convert.ToString(reader["RegisterationNumber"]);
                 if(reader["UniRegisterationNumber"] != DBNull.Value)
                     _personPGMERegisteration.UniRegisterationNumber = Convert.ToString(reader["UniRegisterationNumber"]);
             _personPGMERegisteration.NewRecord = false;
             _personPGMERegisterationList.Add(_personPGMERegisteration);
             }             reader.Close();
             return _personPGMERegisterationList;
         }

        #region Insert And Update
		public bool Insert(PersonPGMERegisteration personpgmeregisteration)
		{
			int autonumber = 0;
			PersonPGMERegisterationDAC personpgmeregisterationComponent = new PersonPGMERegisterationDAC();
			bool endedSuccessfuly = personpgmeregisterationComponent.InsertNewPersonPGMERegisteration( ref autonumber,  personpgmeregisteration.PersonId,  personpgmeregisteration.PersonProgramId,  personpgmeregisteration.PersonRegisterationStatusId,  personpgmeregisteration.RegisterationNumber,  personpgmeregisteration.UniRegisterationNumber);
			if(endedSuccessfuly)
			{
				personpgmeregisteration.PersonRegisterationId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int PersonRegisterationId,  int PersonId,  int PersonProgramId,  int PersonRegisterationStatusId,  string RegisterationNumber,  string UniRegisterationNumber)
		{
			PersonPGMERegisterationDAC personpgmeregisterationComponent = new PersonPGMERegisterationDAC();
			return personpgmeregisterationComponent.InsertNewPersonPGMERegisteration( ref PersonRegisterationId,  PersonId,  PersonProgramId,  PersonRegisterationStatusId,  RegisterationNumber,  UniRegisterationNumber);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int PersonId,  int PersonProgramId,  int PersonRegisterationStatusId,  string RegisterationNumber,  string UniRegisterationNumber)
		{
			PersonPGMERegisterationDAC personpgmeregisterationComponent = new PersonPGMERegisterationDAC();
            int PersonRegisterationId = 0;

			return personpgmeregisterationComponent.InsertNewPersonPGMERegisteration( ref PersonRegisterationId,  PersonId,  PersonProgramId,  PersonRegisterationStatusId,  RegisterationNumber,  UniRegisterationNumber);
		}
		public bool Update(PersonPGMERegisteration personpgmeregisteration ,int old_personRegisterationId)
		{
			PersonPGMERegisterationDAC personpgmeregisterationComponent = new PersonPGMERegisterationDAC();
			return personpgmeregisterationComponent.UpdatePersonPGMERegisteration( personpgmeregisteration.PersonId,  personpgmeregisteration.PersonProgramId,  personpgmeregisteration.PersonRegisterationStatusId,  personpgmeregisteration.RegisterationNumber,  personpgmeregisteration.UniRegisterationNumber,  old_personRegisterationId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int PersonId,  int PersonProgramId,  int PersonRegisterationStatusId,  string RegisterationNumber,  string UniRegisterationNumber,  int Original_PersonRegisterationId)
		{
			PersonPGMERegisterationDAC personpgmeregisterationComponent = new PersonPGMERegisterationDAC();
			return personpgmeregisterationComponent.UpdatePersonPGMERegisteration( PersonId,  PersonProgramId,  PersonRegisterationStatusId,  RegisterationNumber,  UniRegisterationNumber,  Original_PersonRegisterationId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_PersonRegisterationId)
		{
			PersonPGMERegisterationDAC personpgmeregisterationComponent = new PersonPGMERegisterationDAC();
			personpgmeregisterationComponent.DeletePersonPGMERegisteration(Original_PersonRegisterationId);
		}

        #endregion
         public PersonPGMERegisteration GetByID(int _personRegisterationId)
         {
             PersonPGMERegisterationDAC _personPGMERegisterationComponent = new PersonPGMERegisterationDAC();
             IDataReader reader = _personPGMERegisterationComponent.GetByIDPersonPGMERegisteration(_personRegisterationId);
             PersonPGMERegisteration _personPGMERegisteration = null;
             while(reader.Read())
             {
                 _personPGMERegisteration = new PersonPGMERegisteration();
                 if(reader["PersonRegisterationId"] != DBNull.Value)
                     _personPGMERegisteration.PersonRegisterationId = Convert.ToInt32(reader["PersonRegisterationId"]);
                 if(reader["PersonId"] != DBNull.Value)
                     _personPGMERegisteration.PersonId = Convert.ToInt32(reader["PersonId"]);
                 if(reader["PersonProgramId"] != DBNull.Value)
                     _personPGMERegisteration.PersonProgramId = Convert.ToInt32(reader["PersonProgramId"]);
                 if(reader["PersonRegisterationStatusId"] != DBNull.Value)
                     _personPGMERegisteration.PersonRegisterationStatusId = Convert.ToInt32(reader["PersonRegisterationStatusId"]);
                 if(reader["RegisterationNumber"] != DBNull.Value)
                     _personPGMERegisteration.RegisterationNumber = Convert.ToString(reader["RegisterationNumber"]);
                 if(reader["UniRegisterationNumber"] != DBNull.Value)
                     _personPGMERegisteration.UniRegisterationNumber = Convert.ToString(reader["UniRegisterationNumber"]);
             _personPGMERegisteration.NewRecord = false;             }             reader.Close();
             return _personPGMERegisteration;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			PersonPGMERegisterationDAC personpgmeregisterationcomponent = new PersonPGMERegisterationDAC();
			return personpgmeregisterationcomponent.UpdateDataset(dataset);
		}



	}
}
