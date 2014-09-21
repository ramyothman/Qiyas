using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.PGME;
using BusinessLogicLayer.Entities.PGME;
namespace BusinessLogicLayer.Components.PGME
{
	/// <summary>
	/// This is a Business Logic Component Class  for PersonSCHealthSpeciality table
	/// This class RAPs the PersonSCHealthSpecialityDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class PersonSCHealthSpecialityLogic : BusinessLogic
	{
		public PersonSCHealthSpecialityLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<PersonSCHealthSpeciality> GetAll()
         {
             PersonSCHealthSpecialityDAC _personSCHealthSpecialityComponent = new PersonSCHealthSpecialityDAC();
             IDataReader reader =  _personSCHealthSpecialityComponent.GetAllPersonSCHealthSpeciality().CreateDataReader();
             List<PersonSCHealthSpeciality> _personSCHealthSpecialityList = new List<PersonSCHealthSpeciality>();
             while(reader.Read())
             {
             if(_personSCHealthSpecialityList == null)
                 _personSCHealthSpecialityList = new List<PersonSCHealthSpeciality>();
                 PersonSCHealthSpeciality _personSCHealthSpeciality = new PersonSCHealthSpeciality();
                 if(reader["PersonSCHealthSpecialityId"] != DBNull.Value)
                     _personSCHealthSpeciality.PersonSCHealthSpecialityId = Convert.ToInt32(reader["PersonSCHealthSpecialityId"]);
                 if(reader["PersonId"] != DBNull.Value)
                     _personSCHealthSpeciality.PersonId = Convert.ToInt32(reader["PersonId"]);
                 if(reader["Score"] != DBNull.Value)
                     _personSCHealthSpeciality.Score = Convert.ToDecimal(reader["Score"]);
                 if(reader["DateTaken"] != DBNull.Value)
                     _personSCHealthSpeciality.DateTaken = Convert.ToDateTime(reader["DateTaken"]);
                 if(reader["LicensingNumber"] != DBNull.Value)
                     _personSCHealthSpeciality.LicensingNumber = Convert.ToString(reader["LicensingNumber"]);
                 if(reader["RegisterationNumber"] != DBNull.Value)
                     _personSCHealthSpeciality.RegisterationNumber = Convert.ToString(reader["RegisterationNumber"]);
             _personSCHealthSpeciality.NewRecord = false;
             _personSCHealthSpecialityList.Add(_personSCHealthSpeciality);
             }             reader.Close();
             return _personSCHealthSpecialityList;
         }

        #region Insert And Update
		public bool Insert(PersonSCHealthSpeciality personschealthspeciality)
		{
			int autonumber = 0;
			PersonSCHealthSpecialityDAC personschealthspecialityComponent = new PersonSCHealthSpecialityDAC();
			bool endedSuccessfuly = personschealthspecialityComponent.InsertNewPersonSCHealthSpeciality( ref autonumber,  personschealthspeciality.PersonId,  personschealthspeciality.Score,  personschealthspeciality.DateTaken,  personschealthspeciality.LicensingNumber,  personschealthspeciality.RegisterationNumber);
			if(endedSuccessfuly)
			{
				personschealthspeciality.PersonSCHealthSpecialityId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int PersonSCHealthSpecialityId,  int PersonId,  decimal Score,  DateTime DateTaken,  string LicensingNumber,  string RegisterationNumber)
		{
			PersonSCHealthSpecialityDAC personschealthspecialityComponent = new PersonSCHealthSpecialityDAC();
			return personschealthspecialityComponent.InsertNewPersonSCHealthSpeciality( ref PersonSCHealthSpecialityId,  PersonId,  Score,  DateTaken,  LicensingNumber,  RegisterationNumber);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int PersonId,  decimal Score,  DateTime DateTaken,  string LicensingNumber,  string RegisterationNumber)
		{
			PersonSCHealthSpecialityDAC personschealthspecialityComponent = new PersonSCHealthSpecialityDAC();
            int PersonSCHealthSpecialityId = 0;

			return personschealthspecialityComponent.InsertNewPersonSCHealthSpeciality( ref PersonSCHealthSpecialityId,  PersonId,  Score,  DateTaken,  LicensingNumber,  RegisterationNumber);
		}
		public bool Update(PersonSCHealthSpeciality personschealthspeciality ,int old_personSCHealthSpecialityId)
		{
			PersonSCHealthSpecialityDAC personschealthspecialityComponent = new PersonSCHealthSpecialityDAC();
			return personschealthspecialityComponent.UpdatePersonSCHealthSpeciality( personschealthspeciality.PersonId,  personschealthspeciality.Score,  personschealthspeciality.DateTaken,  personschealthspeciality.LicensingNumber,  personschealthspeciality.RegisterationNumber,  old_personSCHealthSpecialityId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int PersonId,  decimal Score,  DateTime DateTaken,  string LicensingNumber,  string RegisterationNumber,  int Original_PersonSCHealthSpecialityId)
		{
			PersonSCHealthSpecialityDAC personschealthspecialityComponent = new PersonSCHealthSpecialityDAC();
			return personschealthspecialityComponent.UpdatePersonSCHealthSpeciality( PersonId,  Score,  DateTaken,  LicensingNumber,  RegisterationNumber,  Original_PersonSCHealthSpecialityId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_PersonSCHealthSpecialityId)
		{
			PersonSCHealthSpecialityDAC personschealthspecialityComponent = new PersonSCHealthSpecialityDAC();
			personschealthspecialityComponent.DeletePersonSCHealthSpeciality(Original_PersonSCHealthSpecialityId);
		}

        #endregion
         public PersonSCHealthSpeciality GetByID(int _personSCHealthSpecialityId)
         {
             PersonSCHealthSpecialityDAC _personSCHealthSpecialityComponent = new PersonSCHealthSpecialityDAC();
             IDataReader reader = _personSCHealthSpecialityComponent.GetByIDPersonSCHealthSpeciality(_personSCHealthSpecialityId);
             PersonSCHealthSpeciality _personSCHealthSpeciality = null;
             while(reader.Read())
             {
                 _personSCHealthSpeciality = new PersonSCHealthSpeciality();
                 if(reader["PersonSCHealthSpecialityId"] != DBNull.Value)
                     _personSCHealthSpeciality.PersonSCHealthSpecialityId = Convert.ToInt32(reader["PersonSCHealthSpecialityId"]);
                 if(reader["PersonId"] != DBNull.Value)
                     _personSCHealthSpeciality.PersonId = Convert.ToInt32(reader["PersonId"]);
                 if(reader["Score"] != DBNull.Value)
                     _personSCHealthSpeciality.Score = Convert.ToDecimal(reader["Score"]);
                 if(reader["DateTaken"] != DBNull.Value)
                     _personSCHealthSpeciality.DateTaken = Convert.ToDateTime(reader["DateTaken"]);
                 if(reader["LicensingNumber"] != DBNull.Value)
                     _personSCHealthSpeciality.LicensingNumber = Convert.ToString(reader["LicensingNumber"]);
                 if(reader["RegisterationNumber"] != DBNull.Value)
                     _personSCHealthSpeciality.RegisterationNumber = Convert.ToString(reader["RegisterationNumber"]);
             _personSCHealthSpeciality.NewRecord = false;             }             reader.Close();
             return _personSCHealthSpeciality;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			PersonSCHealthSpecialityDAC personschealthspecialitycomponent = new PersonSCHealthSpecialityDAC();
			return personschealthspecialitycomponent.UpdateDataset(dataset);
		}



	}
}
