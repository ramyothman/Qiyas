using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.PGME;
using BusinessLogicLayer.Entities.PGME;
namespace BusinessLogicLayer.Components.PGME
{
	/// <summary>
	/// This is a Business Logic Component Class  for PersonReference table
	/// This class RAPs the PersonReferenceDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class PersonReferenceLogic : BusinessLogic
	{
		public PersonReferenceLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<PersonReference> GetAll()
         {
             PersonReferenceDAC _personReferenceComponent = new PersonReferenceDAC();
             IDataReader reader =  _personReferenceComponent.GetAllPersonReference().CreateDataReader();
             List<PersonReference> _personReferenceList = new List<PersonReference>();
             while(reader.Read())
             {
             if(_personReferenceList == null)
                 _personReferenceList = new List<PersonReference>();
                 PersonReference _personReference = new PersonReference();
                 if(reader["PersonReferenceId"] != DBNull.Value)
                     _personReference.PersonReferenceId = Convert.ToInt32(reader["PersonReferenceId"]);
                 if(reader["PersonId"] != DBNull.Value)
                     _personReference.PersonId = Convert.ToInt32(reader["PersonId"]);
                 if(reader["ReferenceFullName"] != DBNull.Value)
                     _personReference.ReferenceFullName = Convert.ToString(reader["ReferenceFullName"]);
                 if(reader["ReferenceEmail"] != DBNull.Value)
                     _personReference.ReferenceEmail = Convert.ToString(reader["ReferenceEmail"]);
                 if(reader["ReferenceAddress"] != DBNull.Value)
                     _personReference.ReferenceAddress = Convert.ToString(reader["ReferenceAddress"]);
                 if(reader["ReferenceContactNumber"] != DBNull.Value)
                     _personReference.ReferenceContactNumber = Convert.ToString(reader["ReferenceContactNumber"]);
                 if(reader["ReferenceMobileNumber"] != DBNull.Value)
                     _personReference.ReferenceMobileNumber = Convert.ToString(reader["ReferenceMobileNumber"]);
                 if(reader["ReferenceLetterPath"] != DBNull.Value)
                     _personReference.ReferenceLetterPath = Convert.ToString(reader["ReferenceLetterPath"]);
                 if(reader["ReferenceLetterMessage"] != DBNull.Value)
                     _personReference.ReferenceLetterMessage = Convert.ToString(reader["ReferenceLetterMessage"]);
                 if(reader["ReferenceAcceptedPerson"] != DBNull.Value)
                     _personReference.ReferenceAcceptedPerson = Convert.ToBoolean(reader["ReferenceAcceptedPerson"]);
                 if(reader["ReferenceInstitution"] != DBNull.Value)
                     _personReference.ReferenceInstitution = Convert.ToString(reader["ReferenceInstitution"]);
             _personReference.NewRecord = false;
             _personReferenceList.Add(_personReference);
             }             reader.Close();
             return _personReferenceList;
         }

        #region Insert And Update
		public bool Insert(PersonReference personreference)
		{
			int autonumber = 0;
			PersonReferenceDAC personreferenceComponent = new PersonReferenceDAC();
			bool endedSuccessfuly = personreferenceComponent.InsertNewPersonReference( ref autonumber,  personreference.PersonId,  personreference.ReferenceFullName,  personreference.ReferenceEmail,  personreference.ReferenceAddress,  personreference.ReferenceContactNumber,  personreference.ReferenceMobileNumber,  personreference.ReferenceLetterPath,  personreference.ReferenceLetterMessage,  personreference.ReferenceAcceptedPerson,  personreference.ReferenceInstitution);
			if(endedSuccessfuly)
			{
				personreference.PersonReferenceId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int PersonReferenceId,  int PersonId,  string ReferenceFullName,  string ReferenceEmail,  string ReferenceAddress,  string ReferenceContactNumber,  string ReferenceMobileNumber,  string ReferenceLetterPath,  string ReferenceLetterMessage,  bool ReferenceAcceptedPerson,  string ReferenceInstitution)
		{
			PersonReferenceDAC personreferenceComponent = new PersonReferenceDAC();
			return personreferenceComponent.InsertNewPersonReference( ref PersonReferenceId,  PersonId,  ReferenceFullName,  ReferenceEmail,  ReferenceAddress,  ReferenceContactNumber,  ReferenceMobileNumber,  ReferenceLetterPath,  ReferenceLetterMessage,  ReferenceAcceptedPerson,  ReferenceInstitution);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int PersonId,  string ReferenceFullName,  string ReferenceEmail,  string ReferenceAddress,  string ReferenceContactNumber,  string ReferenceMobileNumber,  string ReferenceLetterPath,  string ReferenceLetterMessage,  bool ReferenceAcceptedPerson,  string ReferenceInstitution)
		{
			PersonReferenceDAC personreferenceComponent = new PersonReferenceDAC();
            int PersonReferenceId = 0;

			return personreferenceComponent.InsertNewPersonReference( ref PersonReferenceId,  PersonId,  ReferenceFullName,  ReferenceEmail,  ReferenceAddress,  ReferenceContactNumber,  ReferenceMobileNumber,  ReferenceLetterPath,  ReferenceLetterMessage,  ReferenceAcceptedPerson,  ReferenceInstitution);
		}
		public bool Update(PersonReference personreference ,int old_personReferenceId)
		{
			PersonReferenceDAC personreferenceComponent = new PersonReferenceDAC();
			return personreferenceComponent.UpdatePersonReference( personreference.PersonId,  personreference.ReferenceFullName,  personreference.ReferenceEmail,  personreference.ReferenceAddress,  personreference.ReferenceContactNumber,  personreference.ReferenceMobileNumber,  personreference.ReferenceLetterPath,  personreference.ReferenceLetterMessage,  personreference.ReferenceAcceptedPerson,  personreference.ReferenceInstitution,  old_personReferenceId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int PersonId,  string ReferenceFullName,  string ReferenceEmail,  string ReferenceAddress,  string ReferenceContactNumber,  string ReferenceMobileNumber,  string ReferenceLetterPath,  string ReferenceLetterMessage,  bool ReferenceAcceptedPerson,  string ReferenceInstitution,  int Original_PersonReferenceId)
		{
			PersonReferenceDAC personreferenceComponent = new PersonReferenceDAC();
			return personreferenceComponent.UpdatePersonReference( PersonId,  ReferenceFullName,  ReferenceEmail,  ReferenceAddress,  ReferenceContactNumber,  ReferenceMobileNumber,  ReferenceLetterPath,  ReferenceLetterMessage,  ReferenceAcceptedPerson,  ReferenceInstitution,  Original_PersonReferenceId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_PersonReferenceId)
		{
			PersonReferenceDAC personreferenceComponent = new PersonReferenceDAC();
			personreferenceComponent.DeletePersonReference(Original_PersonReferenceId);
		}

        #endregion
         public PersonReference GetByID(int _personReferenceId)
         {
             PersonReferenceDAC _personReferenceComponent = new PersonReferenceDAC();
             IDataReader reader = _personReferenceComponent.GetByIDPersonReference(_personReferenceId);
             PersonReference _personReference = null;
             while(reader.Read())
             {
                 _personReference = new PersonReference();
                 if(reader["PersonReferenceId"] != DBNull.Value)
                     _personReference.PersonReferenceId = Convert.ToInt32(reader["PersonReferenceId"]);
                 if(reader["PersonId"] != DBNull.Value)
                     _personReference.PersonId = Convert.ToInt32(reader["PersonId"]);
                 if(reader["ReferenceFullName"] != DBNull.Value)
                     _personReference.ReferenceFullName = Convert.ToString(reader["ReferenceFullName"]);
                 if(reader["ReferenceEmail"] != DBNull.Value)
                     _personReference.ReferenceEmail = Convert.ToString(reader["ReferenceEmail"]);
                 if(reader["ReferenceAddress"] != DBNull.Value)
                     _personReference.ReferenceAddress = Convert.ToString(reader["ReferenceAddress"]);
                 if(reader["ReferenceContactNumber"] != DBNull.Value)
                     _personReference.ReferenceContactNumber = Convert.ToString(reader["ReferenceContactNumber"]);
                 if(reader["ReferenceMobileNumber"] != DBNull.Value)
                     _personReference.ReferenceMobileNumber = Convert.ToString(reader["ReferenceMobileNumber"]);
                 if(reader["ReferenceLetterPath"] != DBNull.Value)
                     _personReference.ReferenceLetterPath = Convert.ToString(reader["ReferenceLetterPath"]);
                 if(reader["ReferenceLetterMessage"] != DBNull.Value)
                     _personReference.ReferenceLetterMessage = Convert.ToString(reader["ReferenceLetterMessage"]);
                 if(reader["ReferenceAcceptedPerson"] != DBNull.Value)
                     _personReference.ReferenceAcceptedPerson = Convert.ToBoolean(reader["ReferenceAcceptedPerson"]);
                 if(reader["ReferenceInstitution"] != DBNull.Value)
                     _personReference.ReferenceInstitution = Convert.ToString(reader["ReferenceInstitution"]);
             _personReference.NewRecord = false;             }             reader.Close();
             return _personReference;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			PersonReferenceDAC personreferencecomponent = new PersonReferenceDAC();
			return personreferencecomponent.UpdateDataset(dataset);
		}



	}
}
