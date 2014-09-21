using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents
{
	/// <summary>
	/// This is a Data Access Class  for Aluminies table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the Aluminies table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class AluminiesDAC : DataAccessComponent
	{
		#region Constructors
		public AluminiesDAC(){}
		public AluminiesDAC(string connectionString): base(connectionString){}
		public AluminiesDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Aluminies using Stored Procedure
		/// and return a DataTable containing all Aluminies Data
		/// </summary>
		public DataTable GetAllAluminies()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Aluminies";
         string query = " select * from GetAllAluminies";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["Aluminies"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Aluminies using Stored Procedure
		/// and return a DataTable containing all Aluminies Data using a Transaction
		/// </summary>
		public DataTable GetAllAluminies(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Aluminies";
         string query = " select * from GetAllAluminies";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["Aluminies"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Aluminies using Stored Procedure
		/// and return a DataTable containing all Aluminies Data
		/// </summary>
		public DataTable GetAllAluminies(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Aluminies";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllAluminies" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["Aluminies"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Aluminies using Stored Procedure
		/// and return a DataTable containing all Aluminies Data using a Transaction
		/// </summary>
		public DataTable GetAllAluminies(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Aluminies";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllAluminies" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["Aluminies"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From Aluminies using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDAluminies( int id)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDAluminies");
				    Database.AddInParameter(command,"Id",DbType.Int32,id);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From Aluminies using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDAluminies( int id,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDAluminies");
				    Database.AddInParameter(command,"Id",DbType.Int32,id);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into Aluminies using Stored Procedure
		/// and return the auto number primary key of Aluminies inserted row
		/// </summary>
		public bool InsertNewAluminies( ref int id,  string aluminiFor,  string department,  string firstName,  string middleName,  string familyName,  int yearofJoining,  int yearofGraduation,  string universityNumber,  string speciality,  string email,  string contact1,  string contact2,  string contact3,  string medicalSchool,  string medicalSchoolCity,  string sponsor,  string currentPosition,  string currentWorkPlace,  string certificates,  string photo,  string scannedDocument,  string scannedDocumentTitle,  string scannedDocumentTitle2,  string scannedDocument2,  string scannedDocumentTitle3,  string scannedDocument3,  string scannedDocumentTitle4,  string scannedDocument4,  string scannedDocumentTitle5,  string scannedDocument5)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewAluminies");
				Database.AddOutParameter(command,"Id",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"AluminiFor",DbType.String,aluminiFor);
				Database.AddInParameter(command,"Department",DbType.String,department);
				Database.AddInParameter(command,"FirstName",DbType.String,firstName);
				Database.AddInParameter(command,"MiddleName",DbType.String,middleName);
				Database.AddInParameter(command,"FamilyName",DbType.String,familyName);
				Database.AddInParameter(command,"YearofJoining",DbType.Int32,yearofJoining);
				Database.AddInParameter(command,"YearofGraduation",DbType.Int32,yearofGraduation);
				Database.AddInParameter(command,"UniversityNumber",DbType.String,universityNumber);
				Database.AddInParameter(command,"Speciality",DbType.String,speciality);
				Database.AddInParameter(command,"Email",DbType.String,email);
				Database.AddInParameter(command,"Contact1",DbType.String,contact1);
				Database.AddInParameter(command,"Contact2",DbType.String,contact2);
				Database.AddInParameter(command,"Contact3",DbType.String,contact3);
				Database.AddInParameter(command,"MedicalSchool",DbType.String,medicalSchool);
				Database.AddInParameter(command,"MedicalSchoolCity",DbType.String,medicalSchoolCity);
				Database.AddInParameter(command,"Sponsor",DbType.String,sponsor);
				Database.AddInParameter(command,"CurrentPosition",DbType.String,currentPosition);
				Database.AddInParameter(command,"CurrentWorkPlace",DbType.String,currentWorkPlace);
				Database.AddInParameter(command,"Certificates",DbType.String,certificates);
				Database.AddInParameter(command,"Photo",DbType.String,photo);
				Database.AddInParameter(command,"ScannedDocument",DbType.String,scannedDocument);
				Database.AddInParameter(command,"ScannedDocumentTitle",DbType.String,scannedDocumentTitle);
				Database.AddInParameter(command,"ScannedDocumentTitle2",DbType.String,scannedDocumentTitle2);
				Database.AddInParameter(command,"ScannedDocument2",DbType.String,scannedDocument2);
				Database.AddInParameter(command,"ScannedDocumentTitle3",DbType.String,scannedDocumentTitle3);
				Database.AddInParameter(command,"ScannedDocument3",DbType.String,scannedDocument3);
				Database.AddInParameter(command,"ScannedDocumentTitle4",DbType.String,scannedDocumentTitle4);
				Database.AddInParameter(command,"ScannedDocument4",DbType.String,scannedDocument4);
				Database.AddInParameter(command,"ScannedDocumentTitle5",DbType.String,scannedDocumentTitle5);
				Database.AddInParameter(command,"ScannedDocument5",DbType.String,scannedDocument5);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 id = Convert.ToInt32(Database.GetParameterValue(command, "Id"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into Aluminies using Stored Procedure
		/// and return the auto number primary key of Aluminies inserted row using Transaction
		/// </summary>
		public bool InsertNewAluminies( ref int id,  string aluminiFor,  string department,  string firstName,  string middleName,  string familyName,  int yearofJoining,  int yearofGraduation,  string universityNumber,  string speciality,  string email,  string contact1,  string contact2,  string contact3,  string medicalSchool,  string medicalSchoolCity,  string sponsor,  string currentPosition,  string currentWorkPlace,  string certificates,  string photo,  string scannedDocument,  string scannedDocumentTitle,  string scannedDocumentTitle2,  string scannedDocument2,  string scannedDocumentTitle3,  string scannedDocument3,  string scannedDocumentTitle4,  string scannedDocument4,  string scannedDocumentTitle5,  string scannedDocument5,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewAluminies");
				Database.AddOutParameter(command,"Id",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"AluminiFor",DbType.String,aluminiFor);
				Database.AddInParameter(command,"Department",DbType.String,department);
				Database.AddInParameter(command,"FirstName",DbType.String,firstName);
				Database.AddInParameter(command,"MiddleName",DbType.String,middleName);
				Database.AddInParameter(command,"FamilyName",DbType.String,familyName);
				Database.AddInParameter(command,"YearofJoining",DbType.Int32,yearofJoining);
				Database.AddInParameter(command,"YearofGraduation",DbType.Int32,yearofGraduation);
				Database.AddInParameter(command,"UniversityNumber",DbType.String,universityNumber);
				Database.AddInParameter(command,"Speciality",DbType.String,speciality);
				Database.AddInParameter(command,"Email",DbType.String,email);
				Database.AddInParameter(command,"Contact1",DbType.String,contact1);
				Database.AddInParameter(command,"Contact2",DbType.String,contact2);
				Database.AddInParameter(command,"Contact3",DbType.String,contact3);
				Database.AddInParameter(command,"MedicalSchool",DbType.String,medicalSchool);
				Database.AddInParameter(command,"MedicalSchoolCity",DbType.String,medicalSchoolCity);
				Database.AddInParameter(command,"Sponsor",DbType.String,sponsor);
				Database.AddInParameter(command,"CurrentPosition",DbType.String,currentPosition);
				Database.AddInParameter(command,"CurrentWorkPlace",DbType.String,currentWorkPlace);
				Database.AddInParameter(command,"Certificates",DbType.String,certificates);
				Database.AddInParameter(command,"Photo",DbType.String,photo);
				Database.AddInParameter(command,"ScannedDocument",DbType.String,scannedDocument);
				Database.AddInParameter(command,"ScannedDocumentTitle",DbType.String,scannedDocumentTitle);
				Database.AddInParameter(command,"ScannedDocumentTitle2",DbType.String,scannedDocumentTitle2);
				Database.AddInParameter(command,"ScannedDocument2",DbType.String,scannedDocument2);
				Database.AddInParameter(command,"ScannedDocumentTitle3",DbType.String,scannedDocumentTitle3);
				Database.AddInParameter(command,"ScannedDocument3",DbType.String,scannedDocument3);
				Database.AddInParameter(command,"ScannedDocumentTitle4",DbType.String,scannedDocumentTitle4);
				Database.AddInParameter(command,"ScannedDocument4",DbType.String,scannedDocument4);
				Database.AddInParameter(command,"ScannedDocumentTitle5",DbType.String,scannedDocumentTitle5);
				Database.AddInParameter(command,"ScannedDocument5",DbType.String,scannedDocument5);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 id = Convert.ToInt32(Database.GetParameterValue(command, "Id"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for Aluminies using Stored Procedure
		/// and return DbCommand of the Aluminies
		/// </summary>
		public DbCommand InsertNewAluminiesCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewAluminies");

				Database.AddInParameter(command,"AluminiFor",DbType.String,"AluminiFor",DataRowVersion.Current);
				Database.AddInParameter(command,"Department",DbType.String,"Department",DataRowVersion.Current);
				Database.AddInParameter(command,"FirstName",DbType.String,"FirstName",DataRowVersion.Current);
				Database.AddInParameter(command,"MiddleName",DbType.String,"MiddleName",DataRowVersion.Current);
				Database.AddInParameter(command,"FamilyName",DbType.String,"FamilyName",DataRowVersion.Current);
				Database.AddInParameter(command,"YearofJoining",DbType.Int32,"YearofJoining",DataRowVersion.Current);
				Database.AddInParameter(command,"YearofGraduation",DbType.Int32,"YearofGraduation",DataRowVersion.Current);
				Database.AddInParameter(command,"UniversityNumber",DbType.String,"UniversityNumber",DataRowVersion.Current);
				Database.AddInParameter(command,"Speciality",DbType.String,"Speciality",DataRowVersion.Current);
				Database.AddInParameter(command,"Email",DbType.String,"Email",DataRowVersion.Current);
				Database.AddInParameter(command,"Contact1",DbType.String,"Contact1",DataRowVersion.Current);
				Database.AddInParameter(command,"Contact2",DbType.String,"Contact2",DataRowVersion.Current);
				Database.AddInParameter(command,"Contact3",DbType.String,"Contact3",DataRowVersion.Current);
				Database.AddInParameter(command,"MedicalSchool",DbType.String,"MedicalSchool",DataRowVersion.Current);
				Database.AddInParameter(command,"MedicalSchoolCity",DbType.String,"MedicalSchoolCity",DataRowVersion.Current);
				Database.AddInParameter(command,"Sponsor",DbType.String,"Sponsor",DataRowVersion.Current);
				Database.AddInParameter(command,"CurrentPosition",DbType.String,"CurrentPosition",DataRowVersion.Current);
				Database.AddInParameter(command,"CurrentWorkPlace",DbType.String,"CurrentWorkPlace",DataRowVersion.Current);
				Database.AddInParameter(command,"Certificates",DbType.String,"Certificates",DataRowVersion.Current);
				Database.AddInParameter(command,"Photo",DbType.String,"Photo",DataRowVersion.Current);
				Database.AddInParameter(command,"ScannedDocument",DbType.String,"ScannedDocument",DataRowVersion.Current);
				Database.AddInParameter(command,"ScannedDocumentTitle",DbType.String,"ScannedDocumentTitle",DataRowVersion.Current);
				Database.AddInParameter(command,"ScannedDocumentTitle2",DbType.String,"ScannedDocumentTitle2",DataRowVersion.Current);
				Database.AddInParameter(command,"ScannedDocument2",DbType.String,"ScannedDocument2",DataRowVersion.Current);
				Database.AddInParameter(command,"ScannedDocumentTitle3",DbType.String,"ScannedDocumentTitle3",DataRowVersion.Current);
				Database.AddInParameter(command,"ScannedDocument3",DbType.String,"ScannedDocument3",DataRowVersion.Current);
				Database.AddInParameter(command,"ScannedDocumentTitle4",DbType.String,"ScannedDocumentTitle4",DataRowVersion.Current);
				Database.AddInParameter(command,"ScannedDocument4",DbType.String,"ScannedDocument4",DataRowVersion.Current);
				Database.AddInParameter(command,"ScannedDocumentTitle5",DbType.String,"ScannedDocumentTitle5",DataRowVersion.Current);
				Database.AddInParameter(command,"ScannedDocument5",DbType.String,"ScannedDocument5",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into Aluminies using Stored Procedure
		/// </summary>
		public bool UpdateAluminies( string aluminiFor, string department, string firstName, string middleName, string familyName, int yearofJoining, int yearofGraduation, string universityNumber, string speciality, string email, string contact1, string contact2, string contact3, string medicalSchool, string medicalSchoolCity, string sponsor, string currentPosition, string currentWorkPlace, string certificates, string photo, string scannedDocument, string scannedDocumentTitle, string scannedDocumentTitle2, string scannedDocument2, string scannedDocumentTitle3, string scannedDocument3, string scannedDocumentTitle4, string scannedDocument4, string scannedDocumentTitle5, string scannedDocument5, int oldid)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateAluminies");

		    		Database.AddInParameter(command,"AluminiFor",DbType.String,aluminiFor);
		    		Database.AddInParameter(command,"Department",DbType.String,department);
		    		Database.AddInParameter(command,"FirstName",DbType.String,firstName);
		    		Database.AddInParameter(command,"MiddleName",DbType.String,middleName);
		    		Database.AddInParameter(command,"FamilyName",DbType.String,familyName);
		    		Database.AddInParameter(command,"YearofJoining",DbType.Int32,yearofJoining);
		    		Database.AddInParameter(command,"YearofGraduation",DbType.Int32,yearofGraduation);
		    		Database.AddInParameter(command,"UniversityNumber",DbType.String,universityNumber);
		    		Database.AddInParameter(command,"Speciality",DbType.String,speciality);
		    		Database.AddInParameter(command,"Email",DbType.String,email);
		    		Database.AddInParameter(command,"Contact1",DbType.String,contact1);
		    		Database.AddInParameter(command,"Contact2",DbType.String,contact2);
		    		Database.AddInParameter(command,"Contact3",DbType.String,contact3);
		    		Database.AddInParameter(command,"MedicalSchool",DbType.String,medicalSchool);
		    		Database.AddInParameter(command,"MedicalSchoolCity",DbType.String,medicalSchoolCity);
		    		Database.AddInParameter(command,"Sponsor",DbType.String,sponsor);
		    		Database.AddInParameter(command,"CurrentPosition",DbType.String,currentPosition);
		    		Database.AddInParameter(command,"CurrentWorkPlace",DbType.String,currentWorkPlace);
		    		Database.AddInParameter(command,"Certificates",DbType.String,certificates);
		    		Database.AddInParameter(command,"Photo",DbType.String,photo);
		    		Database.AddInParameter(command,"ScannedDocument",DbType.String,scannedDocument);
		    		Database.AddInParameter(command,"ScannedDocumentTitle",DbType.String,scannedDocumentTitle);
		    		Database.AddInParameter(command,"ScannedDocumentTitle2",DbType.String,scannedDocumentTitle2);
		    		Database.AddInParameter(command,"ScannedDocument2",DbType.String,scannedDocument2);
		    		Database.AddInParameter(command,"ScannedDocumentTitle3",DbType.String,scannedDocumentTitle3);
		    		Database.AddInParameter(command,"ScannedDocument3",DbType.String,scannedDocument3);
		    		Database.AddInParameter(command,"ScannedDocumentTitle4",DbType.String,scannedDocumentTitle4);
		    		Database.AddInParameter(command,"ScannedDocument4",DbType.String,scannedDocument4);
		    		Database.AddInParameter(command,"ScannedDocumentTitle5",DbType.String,scannedDocumentTitle5);
		    		Database.AddInParameter(command,"ScannedDocument5",DbType.String,scannedDocument5);
				Database.AddInParameter(command,"oldId",DbType.Int32,oldid);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into Aluminies using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateAluminies( string aluminiFor, string department, string firstName, string middleName, string familyName, int yearofJoining, int yearofGraduation, string universityNumber, string speciality, string email, string contact1, string contact2, string contact3, string medicalSchool, string medicalSchoolCity, string sponsor, string currentPosition, string currentWorkPlace, string certificates, string photo, string scannedDocument, string scannedDocumentTitle, string scannedDocumentTitle2, string scannedDocument2, string scannedDocumentTitle3, string scannedDocument3, string scannedDocumentTitle4, string scannedDocument4, string scannedDocumentTitle5, string scannedDocument5, int oldid,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateAluminies");

		    		Database.AddInParameter(command,"AluminiFor",DbType.String,aluminiFor);
		    		Database.AddInParameter(command,"Department",DbType.String,department);
		    		Database.AddInParameter(command,"FirstName",DbType.String,firstName);
		    		Database.AddInParameter(command,"MiddleName",DbType.String,middleName);
		    		Database.AddInParameter(command,"FamilyName",DbType.String,familyName);
		    		Database.AddInParameter(command,"YearofJoining",DbType.Int32,yearofJoining);
		    		Database.AddInParameter(command,"YearofGraduation",DbType.Int32,yearofGraduation);
		    		Database.AddInParameter(command,"UniversityNumber",DbType.String,universityNumber);
		    		Database.AddInParameter(command,"Speciality",DbType.String,speciality);
		    		Database.AddInParameter(command,"Email",DbType.String,email);
		    		Database.AddInParameter(command,"Contact1",DbType.String,contact1);
		    		Database.AddInParameter(command,"Contact2",DbType.String,contact2);
		    		Database.AddInParameter(command,"Contact3",DbType.String,contact3);
		    		Database.AddInParameter(command,"MedicalSchool",DbType.String,medicalSchool);
		    		Database.AddInParameter(command,"MedicalSchoolCity",DbType.String,medicalSchoolCity);
		    		Database.AddInParameter(command,"Sponsor",DbType.String,sponsor);
		    		Database.AddInParameter(command,"CurrentPosition",DbType.String,currentPosition);
		    		Database.AddInParameter(command,"CurrentWorkPlace",DbType.String,currentWorkPlace);
		    		Database.AddInParameter(command,"Certificates",DbType.String,certificates);
		    		Database.AddInParameter(command,"Photo",DbType.String,photo);
		    		Database.AddInParameter(command,"ScannedDocument",DbType.String,scannedDocument);
		    		Database.AddInParameter(command,"ScannedDocumentTitle",DbType.String,scannedDocumentTitle);
		    		Database.AddInParameter(command,"ScannedDocumentTitle2",DbType.String,scannedDocumentTitle2);
		    		Database.AddInParameter(command,"ScannedDocument2",DbType.String,scannedDocument2);
		    		Database.AddInParameter(command,"ScannedDocumentTitle3",DbType.String,scannedDocumentTitle3);
		    		Database.AddInParameter(command,"ScannedDocument3",DbType.String,scannedDocument3);
		    		Database.AddInParameter(command,"ScannedDocumentTitle4",DbType.String,scannedDocumentTitle4);
		    		Database.AddInParameter(command,"ScannedDocument4",DbType.String,scannedDocument4);
		    		Database.AddInParameter(command,"ScannedDocumentTitle5",DbType.String,scannedDocumentTitle5);
		    		Database.AddInParameter(command,"ScannedDocument5",DbType.String,scannedDocument5);
				Database.AddInParameter(command,"oldId",DbType.Int32,oldid);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from Aluminies using Stored Procedure
		/// </summary>
		public DbCommand UpdateAluminiesCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateAluminies");

		    		Database.AddInParameter(command,"AluminiFor",DbType.String,"AluminiFor",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Department",DbType.String,"Department",DataRowVersion.Current);
		    		Database.AddInParameter(command,"FirstName",DbType.String,"FirstName",DataRowVersion.Current);
		    		Database.AddInParameter(command,"MiddleName",DbType.String,"MiddleName",DataRowVersion.Current);
		    		Database.AddInParameter(command,"FamilyName",DbType.String,"FamilyName",DataRowVersion.Current);
		    		Database.AddInParameter(command,"YearofJoining",DbType.Int32,"YearofJoining",DataRowVersion.Current);
		    		Database.AddInParameter(command,"YearofGraduation",DbType.Int32,"YearofGraduation",DataRowVersion.Current);
		    		Database.AddInParameter(command,"UniversityNumber",DbType.String,"UniversityNumber",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Speciality",DbType.String,"Speciality",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Email",DbType.String,"Email",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Contact1",DbType.String,"Contact1",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Contact2",DbType.String,"Contact2",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Contact3",DbType.String,"Contact3",DataRowVersion.Current);
		    		Database.AddInParameter(command,"MedicalSchool",DbType.String,"MedicalSchool",DataRowVersion.Current);
		    		Database.AddInParameter(command,"MedicalSchoolCity",DbType.String,"MedicalSchoolCity",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Sponsor",DbType.String,"Sponsor",DataRowVersion.Current);
		    		Database.AddInParameter(command,"CurrentPosition",DbType.String,"CurrentPosition",DataRowVersion.Current);
		    		Database.AddInParameter(command,"CurrentWorkPlace",DbType.String,"CurrentWorkPlace",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Certificates",DbType.String,"Certificates",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Photo",DbType.String,"Photo",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ScannedDocument",DbType.String,"ScannedDocument",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ScannedDocumentTitle",DbType.String,"ScannedDocumentTitle",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ScannedDocumentTitle2",DbType.String,"ScannedDocumentTitle2",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ScannedDocument2",DbType.String,"ScannedDocument2",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ScannedDocumentTitle3",DbType.String,"ScannedDocumentTitle3",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ScannedDocument3",DbType.String,"ScannedDocument3",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ScannedDocumentTitle4",DbType.String,"ScannedDocumentTitle4",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ScannedDocument4",DbType.String,"ScannedDocument4",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ScannedDocumentTitle5",DbType.String,"ScannedDocumentTitle5",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ScannedDocument5",DbType.String,"ScannedDocument5",DataRowVersion.Current);
				Database.AddInParameter(command,"oldId",DbType.Int32,"Id",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From Aluminies using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteAluminies( int id)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteAluminies");
			Database.AddInParameter(command,"Id",DbType.Int32,id);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From Aluminies Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteAluminiesCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteAluminies");
				Database.AddInParameter(command,"Id",DbType.Int32,"Id",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table Aluminies using Stored Procedure
		/// and return number of rows effected of the Aluminies
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"Aluminies",InsertNewAluminiesCommand(),UpdateAluminiesCommand(),DeleteAluminiesCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table Aluminies using Stored Procedure
		/// and return number of rows effected of the Aluminies
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"Aluminies",InsertNewAluminiesCommand(),UpdateAluminiesCommand(),DeleteAluminiesCommand(), transaction);
          return rowsAffected;
		}


	}
}
