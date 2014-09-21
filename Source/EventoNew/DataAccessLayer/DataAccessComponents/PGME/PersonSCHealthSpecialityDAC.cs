using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.PGME
{
	/// <summary>
	/// This is a Data Access Class  for PersonSCHealthSpeciality table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the PersonSCHealthSpeciality table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class PersonSCHealthSpecialityDAC : DataAccessComponent
	{
		#region Constructors
		public PersonSCHealthSpecialityDAC(){}
		public PersonSCHealthSpecialityDAC(string connectionString): base(connectionString){}
		public PersonSCHealthSpecialityDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all PersonSCHealthSpeciality using Stored Procedure
		/// and return a DataTable containing all PersonSCHealthSpeciality Data
		/// </summary>
		public DataTable GetAllPersonSCHealthSpeciality()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "PersonSCHealthSpeciality";
         string query = " select * from GetAllPersonSCHealthSpeciality";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["PersonSCHealthSpeciality"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all PersonSCHealthSpeciality using Stored Procedure
		/// and return a DataTable containing all PersonSCHealthSpeciality Data using a Transaction
		/// </summary>
		public DataTable GetAllPersonSCHealthSpeciality(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "PersonSCHealthSpeciality";
         string query = " select * from GetAllPersonSCHealthSpeciality";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["PersonSCHealthSpeciality"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all PersonSCHealthSpeciality using Stored Procedure
		/// and return a DataTable containing all PersonSCHealthSpeciality Data
		/// </summary>
		public DataTable GetAllPersonSCHealthSpeciality(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "PersonSCHealthSpeciality";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllPersonSCHealthSpeciality" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["PersonSCHealthSpeciality"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all PersonSCHealthSpeciality using Stored Procedure
		/// and return a DataTable containing all PersonSCHealthSpeciality Data using a Transaction
		/// </summary>
		public DataTable GetAllPersonSCHealthSpeciality(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "PersonSCHealthSpeciality";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllPersonSCHealthSpeciality" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["PersonSCHealthSpeciality"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From PersonSCHealthSpeciality using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDPersonSCHealthSpeciality( int personSCHealthSpecialityId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDPersonSCHealthSpeciality");
				    Database.AddInParameter(command,"PersonSCHealthSpecialityId",DbType.Int32,personSCHealthSpecialityId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From PersonSCHealthSpeciality using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDPersonSCHealthSpeciality( int personSCHealthSpecialityId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDPersonSCHealthSpeciality");
				    Database.AddInParameter(command,"PersonSCHealthSpecialityId",DbType.Int32,personSCHealthSpecialityId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into PersonSCHealthSpeciality using Stored Procedure
		/// and return the auto number primary key of PersonSCHealthSpeciality inserted row
		/// </summary>
		public bool InsertNewPersonSCHealthSpeciality( ref int personSCHealthSpecialityId,  int personId,  decimal score,  DateTime dateTaken,  string licensingNumber,  string registerationNumber)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewPersonSCHealthSpeciality");
				Database.AddOutParameter(command,"PersonSCHealthSpecialityId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"PersonId",DbType.Int32,personId);
				Database.AddInParameter(command,"Score",DbType.Decimal,score);
				Database.AddInParameter(command,"DateTaken",DbType.DateTime,dateTaken);
				Database.AddInParameter(command,"LicensingNumber",DbType.String,licensingNumber);
				Database.AddInParameter(command,"RegisterationNumber",DbType.String,registerationNumber);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 personSCHealthSpecialityId = Convert.ToInt32(Database.GetParameterValue(command, "PersonSCHealthSpecialityId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into PersonSCHealthSpeciality using Stored Procedure
		/// and return the auto number primary key of PersonSCHealthSpeciality inserted row using Transaction
		/// </summary>
		public bool InsertNewPersonSCHealthSpeciality( ref int personSCHealthSpecialityId,  int personId,  decimal score,  DateTime dateTaken,  string licensingNumber,  string registerationNumber,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewPersonSCHealthSpeciality");
				Database.AddOutParameter(command,"PersonSCHealthSpecialityId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"PersonId",DbType.Int32,personId);
				Database.AddInParameter(command,"Score",DbType.Decimal,score);
				Database.AddInParameter(command,"DateTaken",DbType.DateTime,dateTaken);
				Database.AddInParameter(command,"LicensingNumber",DbType.String,licensingNumber);
				Database.AddInParameter(command,"RegisterationNumber",DbType.String,registerationNumber);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 personSCHealthSpecialityId = Convert.ToInt32(Database.GetParameterValue(command, "PersonSCHealthSpecialityId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for PersonSCHealthSpeciality using Stored Procedure
		/// and return DbCommand of the PersonSCHealthSpeciality
		/// </summary>
		public DbCommand InsertNewPersonSCHealthSpecialityCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewPersonSCHealthSpeciality");

				Database.AddInParameter(command,"PersonId",DbType.Int32,"PersonId",DataRowVersion.Current);
				Database.AddInParameter(command,"Score",DbType.Decimal,"Score",DataRowVersion.Current);
				Database.AddInParameter(command,"DateTaken",DbType.DateTime,"DateTaken",DataRowVersion.Current);
				Database.AddInParameter(command,"LicensingNumber",DbType.String,"LicensingNumber",DataRowVersion.Current);
				Database.AddInParameter(command,"RegisterationNumber",DbType.String,"RegisterationNumber",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into PersonSCHealthSpeciality using Stored Procedure
		/// </summary>
		public bool UpdatePersonSCHealthSpeciality( int personId, decimal score, DateTime dateTaken, string licensingNumber, string registerationNumber, int oldpersonSCHealthSpecialityId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdatePersonSCHealthSpeciality");

		    		Database.AddInParameter(command,"PersonId",DbType.Int32,personId);
		    		Database.AddInParameter(command,"Score",DbType.Decimal,score);
		    		Database.AddInParameter(command,"DateTaken",DbType.DateTime,dateTaken);
		    		Database.AddInParameter(command,"LicensingNumber",DbType.String,licensingNumber);
		    		Database.AddInParameter(command,"RegisterationNumber",DbType.String,registerationNumber);
				Database.AddInParameter(command,"oldPersonSCHealthSpecialityId",DbType.Int32,oldpersonSCHealthSpecialityId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into PersonSCHealthSpeciality using Stored Procedure By Transaction
		/// </summary>
		public bool UpdatePersonSCHealthSpeciality( int personId, decimal score, DateTime dateTaken, string licensingNumber, string registerationNumber, int oldpersonSCHealthSpecialityId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdatePersonSCHealthSpeciality");

		    		Database.AddInParameter(command,"PersonId",DbType.Int32,personId);
		    		Database.AddInParameter(command,"Score",DbType.Decimal,score);
		    		Database.AddInParameter(command,"DateTaken",DbType.DateTime,dateTaken);
		    		Database.AddInParameter(command,"LicensingNumber",DbType.String,licensingNumber);
		    		Database.AddInParameter(command,"RegisterationNumber",DbType.String,registerationNumber);
				Database.AddInParameter(command,"oldPersonSCHealthSpecialityId",DbType.Int32,oldpersonSCHealthSpecialityId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from PersonSCHealthSpeciality using Stored Procedure
		/// </summary>
		public DbCommand UpdatePersonSCHealthSpecialityCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdatePersonSCHealthSpeciality");

		    		Database.AddInParameter(command,"PersonId",DbType.Int32,"PersonId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Score",DbType.Decimal,"Score",DataRowVersion.Current);
		    		Database.AddInParameter(command,"DateTaken",DbType.DateTime,"DateTaken",DataRowVersion.Current);
		    		Database.AddInParameter(command,"LicensingNumber",DbType.String,"LicensingNumber",DataRowVersion.Current);
		    		Database.AddInParameter(command,"RegisterationNumber",DbType.String,"RegisterationNumber",DataRowVersion.Current);
				Database.AddInParameter(command,"oldPersonSCHealthSpecialityId",DbType.Int32,"PersonSCHealthSpecialityId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From PersonSCHealthSpeciality using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeletePersonSCHealthSpeciality( int personSCHealthSpecialityId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeletePersonSCHealthSpeciality");
			Database.AddInParameter(command,"PersonSCHealthSpecialityId",DbType.Int32,personSCHealthSpecialityId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From PersonSCHealthSpeciality Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeletePersonSCHealthSpecialityCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeletePersonSCHealthSpeciality");
				Database.AddInParameter(command,"PersonSCHealthSpecialityId",DbType.Int32,"PersonSCHealthSpecialityId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table PersonSCHealthSpeciality using Stored Procedure
		/// and return number of rows effected of the PersonSCHealthSpeciality
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"PersonSCHealthSpeciality",InsertNewPersonSCHealthSpecialityCommand(),UpdatePersonSCHealthSpecialityCommand(),DeletePersonSCHealthSpecialityCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table PersonSCHealthSpeciality using Stored Procedure
		/// and return number of rows effected of the PersonSCHealthSpeciality
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"PersonSCHealthSpeciality",InsertNewPersonSCHealthSpecialityCommand(),UpdatePersonSCHealthSpecialityCommand(),DeletePersonSCHealthSpecialityCommand(), transaction);
          return rowsAffected;
		}


	}
}
