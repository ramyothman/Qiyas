using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents;
using BusinessLogicLayer.Entities;
namespace BusinessLogicLayer.Components
{
	/// <summary>
	/// This is a Business Logic Component Class  for Aluminies table
	/// This class RAPs the AluminiesDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class AluminiesLogic : BusinessLogic
	{
		public AluminiesLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<Aluminies> GetAll()
         {
             AluminiesDAC _aluminiesComponent = new AluminiesDAC();
             IDataReader reader =  _aluminiesComponent.GetAllAluminies().CreateDataReader();
             List<Aluminies> _aluminiesList = new List<Aluminies>();
             while(reader.Read())
             {
             if(_aluminiesList == null)
                 _aluminiesList = new List<Aluminies>();
                 Aluminies _aluminies = new Aluminies();
                 if(reader["Id"] != DBNull.Value)
                     _aluminies.Id = Convert.ToInt32(reader["Id"]);
                 if(reader["AluminiFor"] != DBNull.Value)
                     _aluminies.AluminiFor = Convert.ToString(reader["AluminiFor"]);
                 if(reader["Department"] != DBNull.Value)
                     _aluminies.Department = Convert.ToString(reader["Department"]);
                 if(reader["FirstName"] != DBNull.Value)
                     _aluminies.FirstName = Convert.ToString(reader["FirstName"]);
                 if(reader["MiddleName"] != DBNull.Value)
                     _aluminies.MiddleName = Convert.ToString(reader["MiddleName"]);
                 if(reader["FamilyName"] != DBNull.Value)
                     _aluminies.FamilyName = Convert.ToString(reader["FamilyName"]);
                 if(reader["YearofJoining"] != DBNull.Value)
                     _aluminies.YearofJoining = Convert.ToInt32(reader["YearofJoining"]);
                 if(reader["YearofGraduation"] != DBNull.Value)
                     _aluminies.YearofGraduation = Convert.ToInt32(reader["YearofGraduation"]);
                 if(reader["UniversityNumber"] != DBNull.Value)
                     _aluminies.UniversityNumber = Convert.ToString(reader["UniversityNumber"]);
                 if(reader["Speciality"] != DBNull.Value)
                     _aluminies.Speciality = Convert.ToString(reader["Speciality"]);
                 if(reader["Email"] != DBNull.Value)
                     _aluminies.Email = Convert.ToString(reader["Email"]);
                 if(reader["Contact1"] != DBNull.Value)
                     _aluminies.Contact1 = Convert.ToString(reader["Contact1"]);
                 if(reader["Contact2"] != DBNull.Value)
                     _aluminies.Contact2 = Convert.ToString(reader["Contact2"]);
                 if(reader["Contact3"] != DBNull.Value)
                     _aluminies.Contact3 = Convert.ToString(reader["Contact3"]);
                 if(reader["MedicalSchool"] != DBNull.Value)
                     _aluminies.MedicalSchool = Convert.ToString(reader["MedicalSchool"]);
                 if(reader["MedicalSchoolCity"] != DBNull.Value)
                     _aluminies.MedicalSchoolCity = Convert.ToString(reader["MedicalSchoolCity"]);
                 if(reader["Sponsor"] != DBNull.Value)
                     _aluminies.Sponsor = Convert.ToString(reader["Sponsor"]);
                 if(reader["CurrentPosition"] != DBNull.Value)
                     _aluminies.CurrentPosition = Convert.ToString(reader["CurrentPosition"]);
                 if(reader["CurrentWorkPlace"] != DBNull.Value)
                     _aluminies.CurrentWorkPlace = Convert.ToString(reader["CurrentWorkPlace"]);
                 if(reader["Certificates"] != DBNull.Value)
                     _aluminies.Certificates = Convert.ToString(reader["Certificates"]);
                 if(reader["Photo"] != DBNull.Value)
                     _aluminies.Photo = Convert.ToString(reader["Photo"]);
                 if(reader["ScannedDocument"] != DBNull.Value)
                     _aluminies.ScannedDocument = Convert.ToString(reader["ScannedDocument"]);
                 if(reader["ScannedDocumentTitle"] != DBNull.Value)
                     _aluminies.ScannedDocumentTitle = Convert.ToString(reader["ScannedDocumentTitle"]);
                 if(reader["ScannedDocumentTitle2"] != DBNull.Value)
                     _aluminies.ScannedDocumentTitle2 = Convert.ToString(reader["ScannedDocumentTitle2"]);
                 if(reader["ScannedDocument2"] != DBNull.Value)
                     _aluminies.ScannedDocument2 = Convert.ToString(reader["ScannedDocument2"]);
                 if(reader["ScannedDocumentTitle3"] != DBNull.Value)
                     _aluminies.ScannedDocumentTitle3 = Convert.ToString(reader["ScannedDocumentTitle3"]);
                 if(reader["ScannedDocument3"] != DBNull.Value)
                     _aluminies.ScannedDocument3 = Convert.ToString(reader["ScannedDocument3"]);
                 if(reader["ScannedDocumentTitle4"] != DBNull.Value)
                     _aluminies.ScannedDocumentTitle4 = Convert.ToString(reader["ScannedDocumentTitle4"]);
                 if(reader["ScannedDocument4"] != DBNull.Value)
                     _aluminies.ScannedDocument4 = Convert.ToString(reader["ScannedDocument4"]);
                 if(reader["ScannedDocumentTitle5"] != DBNull.Value)
                     _aluminies.ScannedDocumentTitle5 = Convert.ToString(reader["ScannedDocumentTitle5"]);
                 if(reader["ScannedDocument5"] != DBNull.Value)
                     _aluminies.ScannedDocument5 = Convert.ToString(reader["ScannedDocument5"]);
             _aluminies.NewRecord = false;
             _aluminiesList.Add(_aluminies);
             }             reader.Close();
             return _aluminiesList;
         }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Aluminies> GetAllByDepartmentYearAndType(string type,string department,string yearofJoining,string yearofGraduation)
        {
            string where = "";
            if (!string.IsNullOrEmpty(type))
            {
                where += " AluminiFor = '" + type + "' AND";
            }
            if (!string.IsNullOrEmpty(department))
            {
                where += " Department = '" + department + "' AND";
            }
            if (!string.IsNullOrEmpty(yearofJoining))
            {
                where += " YearofJoining = " + yearofJoining + " AND";
            }
            if (!string.IsNullOrEmpty(yearofGraduation))
            {
                where += " yearofGraduation = " + yearofGraduation + " AND";
            }
            if(!string.IsNullOrEmpty(where))
                where = where.Remove(where.Length - 3, 3);
            AluminiesDAC _aluminiesComponent = new AluminiesDAC();
            IDataReader reader = _aluminiesComponent.GetAllAluminies(where).CreateDataReader();
            List<Aluminies> _aluminiesList = new List<Aluminies>();
            while (reader.Read())
            {
                if (_aluminiesList == null)
                    _aluminiesList = new List<Aluminies>();
                Aluminies _aluminies = new Aluminies();
                if (reader["Id"] != DBNull.Value)
                    _aluminies.Id = Convert.ToInt32(reader["Id"]);
                if (reader["AluminiFor"] != DBNull.Value)
                    _aluminies.AluminiFor = Convert.ToString(reader["AluminiFor"]);
                if (reader["Department"] != DBNull.Value)
                    _aluminies.Department = Convert.ToString(reader["Department"]);
                if (reader["FirstName"] != DBNull.Value)
                    _aluminies.FirstName = Convert.ToString(reader["FirstName"]);
                if (reader["MiddleName"] != DBNull.Value)
                    _aluminies.MiddleName = Convert.ToString(reader["MiddleName"]);
                if (reader["FamilyName"] != DBNull.Value)
                    _aluminies.FamilyName = Convert.ToString(reader["FamilyName"]);
                if (reader["YearofJoining"] != DBNull.Value)
                    _aluminies.YearofJoining = Convert.ToInt32(reader["YearofJoining"]);
                if (reader["YearofGraduation"] != DBNull.Value)
                    _aluminies.YearofGraduation = Convert.ToInt32(reader["YearofGraduation"]);
                if (reader["UniversityNumber"] != DBNull.Value)
                    _aluminies.UniversityNumber = Convert.ToString(reader["UniversityNumber"]);
                if (reader["Speciality"] != DBNull.Value)
                    _aluminies.Speciality = Convert.ToString(reader["Speciality"]);
                if (reader["Email"] != DBNull.Value)
                    _aluminies.Email = Convert.ToString(reader["Email"]);
                if (reader["Contact1"] != DBNull.Value)
                    _aluminies.Contact1 = Convert.ToString(reader["Contact1"]);
                if (reader["Contact2"] != DBNull.Value)
                    _aluminies.Contact2 = Convert.ToString(reader["Contact2"]);
                if (reader["Contact3"] != DBNull.Value)
                    _aluminies.Contact3 = Convert.ToString(reader["Contact3"]);
                if (reader["MedicalSchool"] != DBNull.Value)
                    _aluminies.MedicalSchool = Convert.ToString(reader["MedicalSchool"]);
                if (reader["MedicalSchoolCity"] != DBNull.Value)
                    _aluminies.MedicalSchoolCity = Convert.ToString(reader["MedicalSchoolCity"]);
                if (reader["Sponsor"] != DBNull.Value)
                    _aluminies.Sponsor = Convert.ToString(reader["Sponsor"]);
                if (reader["CurrentPosition"] != DBNull.Value)
                    _aluminies.CurrentPosition = Convert.ToString(reader["CurrentPosition"]);
                if (reader["CurrentWorkPlace"] != DBNull.Value)
                    _aluminies.CurrentWorkPlace = Convert.ToString(reader["CurrentWorkPlace"]);
                if (reader["Certificates"] != DBNull.Value)
                    _aluminies.Certificates = Convert.ToString(reader["Certificates"]);
                if (reader["Photo"] != DBNull.Value)
                    _aluminies.Photo = Convert.ToString(reader["Photo"]);
                if (reader["ScannedDocument"] != DBNull.Value)
                    _aluminies.ScannedDocument = Convert.ToString(reader["ScannedDocument"]);
                if (reader["ScannedDocumentTitle"] != DBNull.Value)
                    _aluminies.ScannedDocumentTitle = Convert.ToString(reader["ScannedDocumentTitle"]);
                if (reader["ScannedDocumentTitle2"] != DBNull.Value)
                    _aluminies.ScannedDocumentTitle2 = Convert.ToString(reader["ScannedDocumentTitle2"]);
                if (reader["ScannedDocument2"] != DBNull.Value)
                    _aluminies.ScannedDocument2 = Convert.ToString(reader["ScannedDocument2"]);
                if (reader["ScannedDocumentTitle3"] != DBNull.Value)
                    _aluminies.ScannedDocumentTitle3 = Convert.ToString(reader["ScannedDocumentTitle3"]);
                if (reader["ScannedDocument3"] != DBNull.Value)
                    _aluminies.ScannedDocument3 = Convert.ToString(reader["ScannedDocument3"]);
                if (reader["ScannedDocumentTitle4"] != DBNull.Value)
                    _aluminies.ScannedDocumentTitle4 = Convert.ToString(reader["ScannedDocumentTitle4"]);
                if (reader["ScannedDocument4"] != DBNull.Value)
                    _aluminies.ScannedDocument4 = Convert.ToString(reader["ScannedDocument4"]);
                if (reader["ScannedDocumentTitle5"] != DBNull.Value)
                    _aluminies.ScannedDocumentTitle5 = Convert.ToString(reader["ScannedDocumentTitle5"]);
                if (reader["ScannedDocument5"] != DBNull.Value)
                    _aluminies.ScannedDocument5 = Convert.ToString(reader["ScannedDocument5"]);
                _aluminies.NewRecord = false;
                _aluminiesList.Add(_aluminies);
            } reader.Close();
            return _aluminiesList;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Aluminies> GetAllByAluminiId(int Id)
        {
            AluminiesDAC _aluminiesComponent = new AluminiesDAC();
            IDataReader reader = _aluminiesComponent.GetAllAluminies("Id = " + Id).CreateDataReader();
            List<Aluminies> _aluminiesList = new List<Aluminies>();
            while (reader.Read())
            {
                if (_aluminiesList == null)
                    _aluminiesList = new List<Aluminies>();
                Aluminies _aluminies = new Aluminies();
                if (reader["Id"] != DBNull.Value)
                    _aluminies.Id = Convert.ToInt32(reader["Id"]);
                if (reader["AluminiFor"] != DBNull.Value)
                    _aluminies.AluminiFor = Convert.ToString(reader["AluminiFor"]);
                if (reader["Department"] != DBNull.Value)
                    _aluminies.Department = Convert.ToString(reader["Department"]);
                if (reader["FirstName"] != DBNull.Value)
                    _aluminies.FirstName = Convert.ToString(reader["FirstName"]);
                if (reader["MiddleName"] != DBNull.Value)
                    _aluminies.MiddleName = Convert.ToString(reader["MiddleName"]);
                if (reader["FamilyName"] != DBNull.Value)
                    _aluminies.FamilyName = Convert.ToString(reader["FamilyName"]);
                if (reader["YearofJoining"] != DBNull.Value)
                    _aluminies.YearofJoining = Convert.ToInt32(reader["YearofJoining"]);
                if (reader["YearofGraduation"] != DBNull.Value)
                    _aluminies.YearofGraduation = Convert.ToInt32(reader["YearofGraduation"]);
                if (reader["UniversityNumber"] != DBNull.Value)
                    _aluminies.UniversityNumber = Convert.ToString(reader["UniversityNumber"]);
                if (reader["Speciality"] != DBNull.Value)
                    _aluminies.Speciality = Convert.ToString(reader["Speciality"]);
                if (reader["Email"] != DBNull.Value)
                    _aluminies.Email = Convert.ToString(reader["Email"]);
                if (reader["Contact1"] != DBNull.Value)
                    _aluminies.Contact1 = Convert.ToString(reader["Contact1"]);
                if (reader["Contact2"] != DBNull.Value)
                    _aluminies.Contact2 = Convert.ToString(reader["Contact2"]);
                if (reader["Contact3"] != DBNull.Value)
                    _aluminies.Contact3 = Convert.ToString(reader["Contact3"]);
                if (reader["MedicalSchool"] != DBNull.Value)
                    _aluminies.MedicalSchool = Convert.ToString(reader["MedicalSchool"]);
                if (reader["MedicalSchoolCity"] != DBNull.Value)
                    _aluminies.MedicalSchoolCity = Convert.ToString(reader["MedicalSchoolCity"]);
                if (reader["Sponsor"] != DBNull.Value)
                    _aluminies.Sponsor = Convert.ToString(reader["Sponsor"]);
                if (reader["CurrentPosition"] != DBNull.Value)
                    _aluminies.CurrentPosition = Convert.ToString(reader["CurrentPosition"]);
                if (reader["CurrentWorkPlace"] != DBNull.Value)
                    _aluminies.CurrentWorkPlace = Convert.ToString(reader["CurrentWorkPlace"]);
                if (reader["Certificates"] != DBNull.Value)
                    _aluminies.Certificates = Convert.ToString(reader["Certificates"]);
                if (reader["Photo"] != DBNull.Value)
                    _aluminies.Photo = Convert.ToString(reader["Photo"]);
                if (reader["ScannedDocument"] != DBNull.Value)
                    _aluminies.ScannedDocument = Convert.ToString(reader["ScannedDocument"]);
                if (reader["ScannedDocumentTitle"] != DBNull.Value)
                    _aluminies.ScannedDocumentTitle = Convert.ToString(reader["ScannedDocumentTitle"]);
                if (reader["ScannedDocumentTitle2"] != DBNull.Value)
                    _aluminies.ScannedDocumentTitle2 = Convert.ToString(reader["ScannedDocumentTitle2"]);
                if (reader["ScannedDocument2"] != DBNull.Value)
                    _aluminies.ScannedDocument2 = Convert.ToString(reader["ScannedDocument2"]);
                if (reader["ScannedDocumentTitle3"] != DBNull.Value)
                    _aluminies.ScannedDocumentTitle3 = Convert.ToString(reader["ScannedDocumentTitle3"]);
                if (reader["ScannedDocument3"] != DBNull.Value)
                    _aluminies.ScannedDocument3 = Convert.ToString(reader["ScannedDocument3"]);
                if (reader["ScannedDocumentTitle4"] != DBNull.Value)
                    _aluminies.ScannedDocumentTitle4 = Convert.ToString(reader["ScannedDocumentTitle4"]);
                if (reader["ScannedDocument4"] != DBNull.Value)
                    _aluminies.ScannedDocument4 = Convert.ToString(reader["ScannedDocument4"]);
                if (reader["ScannedDocumentTitle5"] != DBNull.Value)
                    _aluminies.ScannedDocumentTitle5 = Convert.ToString(reader["ScannedDocumentTitle5"]);
                if (reader["ScannedDocument5"] != DBNull.Value)
                    _aluminies.ScannedDocument5 = Convert.ToString(reader["ScannedDocument5"]);
                _aluminies.NewRecord = false;
                _aluminiesList.Add(_aluminies);
            } reader.Close();
            return _aluminiesList;
        }

        #region Insert And Update
		public bool Insert(Aluminies aluminies)
		{
			int autonumber = 0;
			AluminiesDAC aluminiesComponent = new AluminiesDAC();
			bool endedSuccessfuly = aluminiesComponent.InsertNewAluminies( ref autonumber,  aluminies.AluminiFor,  aluminies.Department,  aluminies.FirstName,  aluminies.MiddleName,  aluminies.FamilyName,  aluminies.YearofJoining,  aluminies.YearofGraduation,  aluminies.UniversityNumber,  aluminies.Speciality,  aluminies.Email,  aluminies.Contact1,  aluminies.Contact2,  aluminies.Contact3,  aluminies.MedicalSchool,  aluminies.MedicalSchoolCity,  aluminies.Sponsor,  aluminies.CurrentPosition,  aluminies.CurrentWorkPlace,  aluminies.Certificates,  aluminies.Photo,  aluminies.ScannedDocument,  aluminies.ScannedDocumentTitle,  aluminies.ScannedDocumentTitle2,  aluminies.ScannedDocument2,  aluminies.ScannedDocumentTitle3,  aluminies.ScannedDocument3,  aluminies.ScannedDocumentTitle4,  aluminies.ScannedDocument4,  aluminies.ScannedDocumentTitle5,  aluminies.ScannedDocument5);
			if(endedSuccessfuly)
			{
				aluminies.Id = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int Id,  string AluminiFor,  string Department,  string FirstName,  string MiddleName,  string FamilyName,  int YearofJoining,  int YearofGraduation,  string UniversityNumber,  string Speciality,  string Email,  string Contact1,  string Contact2,  string Contact3,  string MedicalSchool,  string MedicalSchoolCity,  string Sponsor,  string CurrentPosition,  string CurrentWorkPlace,  string Certificates,  string Photo,  string ScannedDocument,  string ScannedDocumentTitle,  string ScannedDocumentTitle2,  string ScannedDocument2,  string ScannedDocumentTitle3,  string ScannedDocument3,  string ScannedDocumentTitle4,  string ScannedDocument4,  string ScannedDocumentTitle5,  string ScannedDocument5)
		{
			AluminiesDAC aluminiesComponent = new AluminiesDAC();
			return aluminiesComponent.InsertNewAluminies( ref Id,  AluminiFor,  Department,  FirstName,  MiddleName,  FamilyName,  YearofJoining,  YearofGraduation,  UniversityNumber,  Speciality,  Email,  Contact1,  Contact2,  Contact3,  MedicalSchool,  MedicalSchoolCity,  Sponsor,  CurrentPosition,  CurrentWorkPlace,  Certificates,  Photo,  ScannedDocument,  ScannedDocumentTitle,  ScannedDocumentTitle2,  ScannedDocument2,  ScannedDocumentTitle3,  ScannedDocument3,  ScannedDocumentTitle4,  ScannedDocument4,  ScannedDocumentTitle5,  ScannedDocument5);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( string AluminiFor,  string Department,  string FirstName,  string MiddleName,  string FamilyName,  int YearofJoining,  int YearofGraduation,  string UniversityNumber,  string Speciality,  string Email,  string Contact1,  string Contact2,  string Contact3,  string MedicalSchool,  string MedicalSchoolCity,  string Sponsor,  string CurrentPosition,  string CurrentWorkPlace,  string Certificates,  string Photo,  string ScannedDocument,  string ScannedDocumentTitle,  string ScannedDocumentTitle2,  string ScannedDocument2,  string ScannedDocumentTitle3,  string ScannedDocument3,  string ScannedDocumentTitle4,  string ScannedDocument4,  string ScannedDocumentTitle5,  string ScannedDocument5)
		{
			AluminiesDAC aluminiesComponent = new AluminiesDAC();
            int Id = 0;

			return aluminiesComponent.InsertNewAluminies( ref Id,  AluminiFor,  Department,  FirstName,  MiddleName,  FamilyName,  YearofJoining,  YearofGraduation,  UniversityNumber,  Speciality,  Email,  Contact1,  Contact2,  Contact3,  MedicalSchool,  MedicalSchoolCity,  Sponsor,  CurrentPosition,  CurrentWorkPlace,  Certificates,  Photo,  ScannedDocument,  ScannedDocumentTitle,  ScannedDocumentTitle2,  ScannedDocument2,  ScannedDocumentTitle3,  ScannedDocument3,  ScannedDocumentTitle4,  ScannedDocument4,  ScannedDocumentTitle5,  ScannedDocument5);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
         public bool Insert(string AluminiFor, string Department, string FirstName, string MiddleName, string FamilyName, int YearofJoining, int YearofGraduation, string UniversityNumber, string Speciality, string Email, string Contact1, string Contact2, string Contact3, string MedicalSchool, string MedicalSchoolCity, string Sponsor, string CurrentPosition, string CurrentWorkPlace, string Certificates, string Photo, string ScannedDocument, string ScannedDocumentTitle, string ScannedDocumentTitle2, string ScannedDocument2, string ScannedDocumentTitle3, string ScannedDocument3, string ScannedDocumentTitle4, string ScannedDocument4, string ScannedDocumentTitle5, string ScannedDocument5,string FullName)
         {
             AluminiesDAC aluminiesComponent = new AluminiesDAC();
             int Id = 0;

             return aluminiesComponent.InsertNewAluminies(ref Id, AluminiFor, Department, FirstName, MiddleName, FamilyName, YearofJoining, YearofGraduation, UniversityNumber, Speciality, Email, Contact1, Contact2, Contact3, MedicalSchool, MedicalSchoolCity, Sponsor, CurrentPosition, CurrentWorkPlace, Certificates, Photo, ScannedDocument, ScannedDocumentTitle, ScannedDocumentTitle2, ScannedDocument2, ScannedDocumentTitle3, ScannedDocument3, ScannedDocumentTitle4, ScannedDocument4, ScannedDocumentTitle5, ScannedDocument5);
         }
		public bool Update(Aluminies aluminies ,int old_id)
		{
			AluminiesDAC aluminiesComponent = new AluminiesDAC();
			return aluminiesComponent.UpdateAluminies( aluminies.AluminiFor,  aluminies.Department,  aluminies.FirstName,  aluminies.MiddleName,  aluminies.FamilyName,  aluminies.YearofJoining,  aluminies.YearofGraduation,  aluminies.UniversityNumber,  aluminies.Speciality,  aluminies.Email,  aluminies.Contact1,  aluminies.Contact2,  aluminies.Contact3,  aluminies.MedicalSchool,  aluminies.MedicalSchoolCity,  aluminies.Sponsor,  aluminies.CurrentPosition,  aluminies.CurrentWorkPlace,  aluminies.Certificates,  aluminies.Photo,  aluminies.ScannedDocument,  aluminies.ScannedDocumentTitle,  aluminies.ScannedDocumentTitle2,  aluminies.ScannedDocument2,  aluminies.ScannedDocumentTitle3,  aluminies.ScannedDocument3,  aluminies.ScannedDocumentTitle4,  aluminies.ScannedDocument4,  aluminies.ScannedDocumentTitle5,  aluminies.ScannedDocument5,  old_id);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( string AluminiFor,  string Department,  string FirstName,  string MiddleName,  string FamilyName,  int YearofJoining,  int YearofGraduation,  string UniversityNumber,  string Speciality,  string Email,  string Contact1,  string Contact2,  string Contact3,  string MedicalSchool,  string MedicalSchoolCity,  string Sponsor,  string CurrentPosition,  string CurrentWorkPlace,  string Certificates,  string Photo,  string ScannedDocument,  string ScannedDocumentTitle,  string ScannedDocumentTitle2,  string ScannedDocument2,  string ScannedDocumentTitle3,  string ScannedDocument3,  string ScannedDocumentTitle4,  string ScannedDocument4,  string ScannedDocumentTitle5,  string ScannedDocument5,  int Original_Id)
		{
			AluminiesDAC aluminiesComponent = new AluminiesDAC();
			return aluminiesComponent.UpdateAluminies( AluminiFor,  Department,  FirstName,  MiddleName,  FamilyName,  YearofJoining,  YearofGraduation,  UniversityNumber,  Speciality,  Email,  Contact1,  Contact2,  Contact3,  MedicalSchool,  MedicalSchoolCity,  Sponsor,  CurrentPosition,  CurrentWorkPlace,  Certificates,  Photo,  ScannedDocument,  ScannedDocumentTitle,  ScannedDocumentTitle2,  ScannedDocument2,  ScannedDocumentTitle3,  ScannedDocument3,  ScannedDocumentTitle4,  ScannedDocument4,  ScannedDocumentTitle5,  ScannedDocument5,  Original_Id);
		}
        [DataObjectMethod(DataObjectMethodType.Update)]
        public bool Update(string AluminiFor, string Department, string FirstName, string MiddleName, string FamilyName, int YearofJoining, int YearofGraduation, string UniversityNumber, string Speciality, string Email, string Contact1, string Contact2, string Contact3, string MedicalSchool, string MedicalSchoolCity, string Sponsor, string CurrentPosition, string CurrentWorkPlace, string Certificates, string Photo, string ScannedDocument, string ScannedDocumentTitle, string ScannedDocumentTitle2, string ScannedDocument2, string ScannedDocumentTitle3, string ScannedDocument3, string ScannedDocumentTitle4, string ScannedDocument4, string ScannedDocumentTitle5, string ScannedDocument5,string FullName, int Original_Id)
        {
            AluminiesDAC aluminiesComponent = new AluminiesDAC();
            return aluminiesComponent.UpdateAluminies(AluminiFor, Department, FirstName, MiddleName, FamilyName, YearofJoining, YearofGraduation, UniversityNumber, Speciality, Email, Contact1, Contact2, Contact3, MedicalSchool, MedicalSchoolCity, Sponsor, CurrentPosition, CurrentWorkPlace, Certificates, Photo, ScannedDocument, ScannedDocumentTitle, ScannedDocumentTitle2, ScannedDocument2, ScannedDocumentTitle3, ScannedDocument3, ScannedDocumentTitle4, ScannedDocument4, ScannedDocumentTitle5, ScannedDocument5, Original_Id);
        }

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_Id)
		{
			AluminiesDAC aluminiesComponent = new AluminiesDAC();
			aluminiesComponent.DeleteAluminies(Original_Id);
		}

        #endregion
         public Aluminies GetByID(int _id)
         {
             AluminiesDAC _aluminiesComponent = new AluminiesDAC();
             IDataReader reader = _aluminiesComponent.GetByIDAluminies(_id);
             Aluminies _aluminies = null;
             while(reader.Read())
             {
                 _aluminies = new Aluminies();
                 if(reader["Id"] != DBNull.Value)
                     _aluminies.Id = Convert.ToInt32(reader["Id"]);
                 if(reader["AluminiFor"] != DBNull.Value)
                     _aluminies.AluminiFor = Convert.ToString(reader["AluminiFor"]);
                 if(reader["Department"] != DBNull.Value)
                     _aluminies.Department = Convert.ToString(reader["Department"]);
                 if(reader["FirstName"] != DBNull.Value)
                     _aluminies.FirstName = Convert.ToString(reader["FirstName"]);
                 if(reader["MiddleName"] != DBNull.Value)
                     _aluminies.MiddleName = Convert.ToString(reader["MiddleName"]);
                 if(reader["FamilyName"] != DBNull.Value)
                     _aluminies.FamilyName = Convert.ToString(reader["FamilyName"]);
                 if(reader["YearofJoining"] != DBNull.Value)
                     _aluminies.YearofJoining = Convert.ToInt32(reader["YearofJoining"]);
                 if(reader["YearofGraduation"] != DBNull.Value)
                     _aluminies.YearofGraduation = Convert.ToInt32(reader["YearofGraduation"]);
                 if(reader["UniversityNumber"] != DBNull.Value)
                     _aluminies.UniversityNumber = Convert.ToString(reader["UniversityNumber"]);
                 if(reader["Speciality"] != DBNull.Value)
                     _aluminies.Speciality = Convert.ToString(reader["Speciality"]);
                 if(reader["Email"] != DBNull.Value)
                     _aluminies.Email = Convert.ToString(reader["Email"]);
                 if(reader["Contact1"] != DBNull.Value)
                     _aluminies.Contact1 = Convert.ToString(reader["Contact1"]);
                 if(reader["Contact2"] != DBNull.Value)
                     _aluminies.Contact2 = Convert.ToString(reader["Contact2"]);
                 if(reader["Contact3"] != DBNull.Value)
                     _aluminies.Contact3 = Convert.ToString(reader["Contact3"]);
                 if(reader["MedicalSchool"] != DBNull.Value)
                     _aluminies.MedicalSchool = Convert.ToString(reader["MedicalSchool"]);
                 if(reader["MedicalSchoolCity"] != DBNull.Value)
                     _aluminies.MedicalSchoolCity = Convert.ToString(reader["MedicalSchoolCity"]);
                 if(reader["Sponsor"] != DBNull.Value)
                     _aluminies.Sponsor = Convert.ToString(reader["Sponsor"]);
                 if(reader["CurrentPosition"] != DBNull.Value)
                     _aluminies.CurrentPosition = Convert.ToString(reader["CurrentPosition"]);
                 if(reader["CurrentWorkPlace"] != DBNull.Value)
                     _aluminies.CurrentWorkPlace = Convert.ToString(reader["CurrentWorkPlace"]);
                 if(reader["Certificates"] != DBNull.Value)
                     _aluminies.Certificates = Convert.ToString(reader["Certificates"]);
                 if(reader["Photo"] != DBNull.Value)
                     _aluminies.Photo = Convert.ToString(reader["Photo"]);
                 if(reader["ScannedDocument"] != DBNull.Value)
                     _aluminies.ScannedDocument = Convert.ToString(reader["ScannedDocument"]);
                 if(reader["ScannedDocumentTitle"] != DBNull.Value)
                     _aluminies.ScannedDocumentTitle = Convert.ToString(reader["ScannedDocumentTitle"]);
                 if(reader["ScannedDocumentTitle2"] != DBNull.Value)
                     _aluminies.ScannedDocumentTitle2 = Convert.ToString(reader["ScannedDocumentTitle2"]);
                 if(reader["ScannedDocument2"] != DBNull.Value)
                     _aluminies.ScannedDocument2 = Convert.ToString(reader["ScannedDocument2"]);
                 if(reader["ScannedDocumentTitle3"] != DBNull.Value)
                     _aluminies.ScannedDocumentTitle3 = Convert.ToString(reader["ScannedDocumentTitle3"]);
                 if(reader["ScannedDocument3"] != DBNull.Value)
                     _aluminies.ScannedDocument3 = Convert.ToString(reader["ScannedDocument3"]);
                 if(reader["ScannedDocumentTitle4"] != DBNull.Value)
                     _aluminies.ScannedDocumentTitle4 = Convert.ToString(reader["ScannedDocumentTitle4"]);
                 if(reader["ScannedDocument4"] != DBNull.Value)
                     _aluminies.ScannedDocument4 = Convert.ToString(reader["ScannedDocument4"]);
                 if(reader["ScannedDocumentTitle5"] != DBNull.Value)
                     _aluminies.ScannedDocumentTitle5 = Convert.ToString(reader["ScannedDocumentTitle5"]);
                 if(reader["ScannedDocument5"] != DBNull.Value)
                     _aluminies.ScannedDocument5 = Convert.ToString(reader["ScannedDocument5"]);
             _aluminies.NewRecord = false;             }             reader.Close();
             return _aluminies;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			AluminiesDAC aluminiescomponent = new AluminiesDAC();
			return aluminiescomponent.UpdateDataset(dataset);
		}



	}
}
