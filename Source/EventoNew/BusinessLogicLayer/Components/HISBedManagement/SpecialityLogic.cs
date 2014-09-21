using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.HISBedManagement;
using BusinessLogicLayer.Entities.HISBedManagement;
namespace BusinessLogicLayer.Components.HISBedManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for Speciality table
	/// This class RAPs the SpecialityDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class SpecialityLogic : BusinessLogic
	{
		public SpecialityLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<Speciality> GetAll()
         {
             SpecialityDAC _specialityComponent = new SpecialityDAC();
             IDataReader reader =  _specialityComponent.GetAllSpeciality().CreateDataReader();
             List<Speciality> _specialityList = new List<Speciality>();
             while(reader.Read())
             {
             if(_specialityList == null)
                 _specialityList = new List<Speciality>();
                 Speciality _speciality = new Speciality();
                 if(reader["SpecialityId"] != DBNull.Value)
                     _speciality.SpecialityId = Convert.ToInt32(reader["SpecialityId"]);
                 if(reader["SpecialityCode"] != DBNull.Value)
                     _speciality.SpecialityCode = Convert.ToString(reader["SpecialityCode"]);
                 if(reader["SpecialityName"] != DBNull.Value)
                     _speciality.SpecialityName = Convert.ToString(reader["SpecialityName"]);
                 if(reader["SpecialityAbbreviation"] != DBNull.Value)
                     _speciality.SpecialityAbbreviation = Convert.ToString(reader["SpecialityAbbreviation"]);
             _speciality.NewRecord = false;
             _specialityList.Add(_speciality);
             }             reader.Close();
             return _specialityList;
         }

        #region Insert And Update
		public bool Insert(Speciality speciality)
		{
			int autonumber = 0;
			SpecialityDAC specialityComponent = new SpecialityDAC();
			bool endedSuccessfuly = specialityComponent.InsertNewSpeciality( ref autonumber,  speciality.SpecialityCode,  speciality.SpecialityName,  speciality.SpecialityAbbreviation);
			if(endedSuccessfuly)
			{
				speciality.SpecialityId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int SpecialityId,  string SpecialityCode,  string SpecialityName,  string SpecialityAbbreviation)
		{
			SpecialityDAC specialityComponent = new SpecialityDAC();
			return specialityComponent.InsertNewSpeciality( ref SpecialityId,  SpecialityCode,  SpecialityName,  SpecialityAbbreviation);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( string SpecialityCode,  string SpecialityName,  string SpecialityAbbreviation)
		{
			SpecialityDAC specialityComponent = new SpecialityDAC();
            int SpecialityId = 0;

			return specialityComponent.InsertNewSpeciality( ref SpecialityId,  SpecialityCode,  SpecialityName,  SpecialityAbbreviation);
		}
		public bool Update(Speciality speciality ,int old_specialityId)
		{
			SpecialityDAC specialityComponent = new SpecialityDAC();
			return specialityComponent.UpdateSpeciality( speciality.SpecialityCode,  speciality.SpecialityName,  speciality.SpecialityAbbreviation,  old_specialityId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( string SpecialityCode,  string SpecialityName,  string SpecialityAbbreviation,  int Original_SpecialityId)
		{
			SpecialityDAC specialityComponent = new SpecialityDAC();
			return specialityComponent.UpdateSpeciality( SpecialityCode,  SpecialityName,  SpecialityAbbreviation,  Original_SpecialityId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_SpecialityId)
		{
			SpecialityDAC specialityComponent = new SpecialityDAC();
			specialityComponent.DeleteSpeciality(Original_SpecialityId);
		}

        #endregion
         public Speciality GetByID(int _specialityId)
         {
             SpecialityDAC _specialityComponent = new SpecialityDAC();
             IDataReader reader = _specialityComponent.GetByIDSpeciality(_specialityId);
             Speciality _speciality = null;
             while(reader.Read())
             {
                 _speciality = new Speciality();
                 if(reader["SpecialityId"] != DBNull.Value)
                     _speciality.SpecialityId = Convert.ToInt32(reader["SpecialityId"]);
                 if(reader["SpecialityCode"] != DBNull.Value)
                     _speciality.SpecialityCode = Convert.ToString(reader["SpecialityCode"]);
                 if(reader["SpecialityName"] != DBNull.Value)
                     _speciality.SpecialityName = Convert.ToString(reader["SpecialityName"]);
                 if(reader["SpecialityAbbreviation"] != DBNull.Value)
                     _speciality.SpecialityAbbreviation = Convert.ToString(reader["SpecialityAbbreviation"]);
             _speciality.NewRecord = false;             }             reader.Close();
             return _speciality;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			SpecialityDAC specialitycomponent = new SpecialityDAC();
			return specialitycomponent.UpdateDataset(dataset);
		}



	}
}
