using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.PGME
{
	/// <summary>
	/// This is a Data Access Class  for PersonReference table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the PersonReference table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class PersonReferenceDAC : DataAccessComponent
	{
		#region Constructors
		public PersonReferenceDAC(){}
		public PersonReferenceDAC(string connectionString): base(connectionString){}
		public PersonReferenceDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all PersonReference using Stored Procedure
		/// and return a DataTable containing all PersonReference Data
		/// </summary>
		public DataTable GetAllPersonReference()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "PersonReference";
         string query = " select * from GetAllPersonReference";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["PersonReference"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all PersonReference using Stored Procedure
		/// and return a DataTable containing all PersonReference Data using a Transaction
		/// </summary>
		public DataTable GetAllPersonReference(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "PersonReference";
         string query = " select * from GetAllPersonReference";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["PersonReference"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all PersonReference using Stored Procedure
		/// and return a DataTable containing all PersonReference Data
		/// </summary>
		public DataTable GetAllPersonReference(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "PersonReference";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllPersonReference" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["PersonReference"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all PersonReference using Stored Procedure
		/// and return a DataTable containing all PersonReference Data using a Transaction
		/// </summary>
		public DataTable GetAllPersonReference(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "PersonReference";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllPersonReference" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["PersonReference"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From PersonReference using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDPersonReference( int personReferenceId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDPersonReference");
				    Database.AddInParameter(command,"PersonReferenceId",DbType.Int32,personReferenceId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From PersonReference using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDPersonReference( int personReferenceId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDPersonReference");
				    Database.AddInParameter(command,"PersonReferenceId",DbType.Int32,personReferenceId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into PersonReference using Stored Procedure
		/// and return the auto number primary key of PersonReference inserted row
		/// </summary>
		public bool InsertNewPersonReference( ref int personReferenceId,  int personId,  string referenceFullName,  string referenceEmail,  string referenceAddress,  string referenceContactNumber,  string referenceMobileNumber,  string referenceLetterPath,  string referenceLetterMessage,  bool referenceAcceptedPerson,  string referenceInstitution)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewPersonReference");
				Database.AddOutParameter(command,"PersonReferenceId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"PersonId",DbType.Int32,personId);
				Database.AddInParameter(command,"ReferenceFullName",DbType.String,referenceFullName);
				Database.AddInParameter(command,"ReferenceEmail",DbType.String,referenceEmail);
				Database.AddInParameter(command,"ReferenceAddress",DbType.String,referenceAddress);
				Database.AddInParameter(command,"ReferenceContactNumber",DbType.String,referenceContactNumber);
				Database.AddInParameter(command,"ReferenceMobileNumber",DbType.String,referenceMobileNumber);
				Database.AddInParameter(command,"ReferenceLetterPath",DbType.String,referenceLetterPath);
				Database.AddInParameter(command,"ReferenceLetterMessage",DbType.String,referenceLetterMessage);
				Database.AddInParameter(command,"ReferenceAcceptedPerson",DbType.Boolean,referenceAcceptedPerson);
				Database.AddInParameter(command,"ReferenceInstitution",DbType.String,referenceInstitution);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 personReferenceId = Convert.ToInt32(Database.GetParameterValue(command, "PersonReferenceId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into PersonReference using Stored Procedure
		/// and return the auto number primary key of PersonReference inserted row using Transaction
		/// </summary>
		public bool InsertNewPersonReference( ref int personReferenceId,  int personId,  string referenceFullName,  string referenceEmail,  string referenceAddress,  string referenceContactNumber,  string referenceMobileNumber,  string referenceLetterPath,  string referenceLetterMessage,  bool referenceAcceptedPerson,  string referenceInstitution,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewPersonReference");
				Database.AddOutParameter(command,"PersonReferenceId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"PersonId",DbType.Int32,personId);
				Database.AddInParameter(command,"ReferenceFullName",DbType.String,referenceFullName);
				Database.AddInParameter(command,"ReferenceEmail",DbType.String,referenceEmail);
				Database.AddInParameter(command,"ReferenceAddress",DbType.String,referenceAddress);
				Database.AddInParameter(command,"ReferenceContactNumber",DbType.String,referenceContactNumber);
				Database.AddInParameter(command,"ReferenceMobileNumber",DbType.String,referenceMobileNumber);
				Database.AddInParameter(command,"ReferenceLetterPath",DbType.String,referenceLetterPath);
				Database.AddInParameter(command,"ReferenceLetterMessage",DbType.String,referenceLetterMessage);
				Database.AddInParameter(command,"ReferenceAcceptedPerson",DbType.Boolean,referenceAcceptedPerson);
				Database.AddInParameter(command,"ReferenceInstitution",DbType.String,referenceInstitution);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 personReferenceId = Convert.ToInt32(Database.GetParameterValue(command, "PersonReferenceId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for PersonReference using Stored Procedure
		/// and return DbCommand of the PersonReference
		/// </summary>
		public DbCommand InsertNewPersonReferenceCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewPersonReference");

				Database.AddInParameter(command,"PersonId",DbType.Int32,"PersonId",DataRowVersion.Current);
				Database.AddInParameter(command,"ReferenceFullName",DbType.String,"ReferenceFullName",DataRowVersion.Current);
				Database.AddInParameter(command,"ReferenceEmail",DbType.String,"ReferenceEmail",DataRowVersion.Current);
				Database.AddInParameter(command,"ReferenceAddress",DbType.String,"ReferenceAddress",DataRowVersion.Current);
				Database.AddInParameter(command,"ReferenceContactNumber",DbType.String,"ReferenceContactNumber",DataRowVersion.Current);
				Database.AddInParameter(command,"ReferenceMobileNumber",DbType.String,"ReferenceMobileNumber",DataRowVersion.Current);
				Database.AddInParameter(command,"ReferenceLetterPath",DbType.String,"ReferenceLetterPath",DataRowVersion.Current);
				Database.AddInParameter(command,"ReferenceLetterMessage",DbType.String,"ReferenceLetterMessage",DataRowVersion.Current);
				Database.AddInParameter(command,"ReferenceAcceptedPerson",DbType.Boolean,"ReferenceAcceptedPerson",DataRowVersion.Current);
				Database.AddInParameter(command,"ReferenceInstitution",DbType.String,"ReferenceInstitution",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into PersonReference using Stored Procedure
		/// </summary>
		public bool UpdatePersonReference( int personId, string referenceFullName, string referenceEmail, string referenceAddress, string referenceContactNumber, string referenceMobileNumber, string referenceLetterPath, string referenceLetterMessage, bool referenceAcceptedPerson, string referenceInstitution, int oldpersonReferenceId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdatePersonReference");

		    		Database.AddInParameter(command,"PersonId",DbType.Int32,personId);
		    		Database.AddInParameter(command,"ReferenceFullName",DbType.String,referenceFullName);
		    		Database.AddInParameter(command,"ReferenceEmail",DbType.String,referenceEmail);
		    		Database.AddInParameter(command,"ReferenceAddress",DbType.String,referenceAddress);
		    		Database.AddInParameter(command,"ReferenceContactNumber",DbType.String,referenceContactNumber);
		    		Database.AddInParameter(command,"ReferenceMobileNumber",DbType.String,referenceMobileNumber);
		    		Database.AddInParameter(command,"ReferenceLetterPath",DbType.String,referenceLetterPath);
		    		Database.AddInParameter(command,"ReferenceLetterMessage",DbType.String,referenceLetterMessage);
		    		Database.AddInParameter(command,"ReferenceAcceptedPerson",DbType.Boolean,referenceAcceptedPerson);
		    		Database.AddInParameter(command,"ReferenceInstitution",DbType.String,referenceInstitution);
				Database.AddInParameter(command,"oldPersonReferenceId",DbType.Int32,oldpersonReferenceId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into PersonReference using Stored Procedure By Transaction
		/// </summary>
		public bool UpdatePersonReference( int personId, string referenceFullName, string referenceEmail, string referenceAddress, string referenceContactNumber, string referenceMobileNumber, string referenceLetterPath, string referenceLetterMessage, bool referenceAcceptedPerson, string referenceInstitution, int oldpersonReferenceId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdatePersonReference");

		    		Database.AddInParameter(command,"PersonId",DbType.Int32,personId);
		    		Database.AddInParameter(command,"ReferenceFullName",DbType.String,referenceFullName);
		    		Database.AddInParameter(command,"ReferenceEmail",DbType.String,referenceEmail);
		    		Database.AddInParameter(command,"ReferenceAddress",DbType.String,referenceAddress);
		    		Database.AddInParameter(command,"ReferenceContactNumber",DbType.String,referenceContactNumber);
		    		Database.AddInParameter(command,"ReferenceMobileNumber",DbType.String,referenceMobileNumber);
		    		Database.AddInParameter(command,"ReferenceLetterPath",DbType.String,referenceLetterPath);
		    		Database.AddInParameter(command,"ReferenceLetterMessage",DbType.String,referenceLetterMessage);
		    		Database.AddInParameter(command,"ReferenceAcceptedPerson",DbType.Boolean,referenceAcceptedPerson);
		    		Database.AddInParameter(command,"ReferenceInstitution",DbType.String,referenceInstitution);
				Database.AddInParameter(command,"oldPersonReferenceId",DbType.Int32,oldpersonReferenceId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from PersonReference using Stored Procedure
		/// </summary>
		public DbCommand UpdatePersonReferenceCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdatePersonReference");

		    		Database.AddInParameter(command,"PersonId",DbType.Int32,"PersonId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ReferenceFullName",DbType.String,"ReferenceFullName",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ReferenceEmail",DbType.String,"ReferenceEmail",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ReferenceAddress",DbType.String,"ReferenceAddress",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ReferenceContactNumber",DbType.String,"ReferenceContactNumber",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ReferenceMobileNumber",DbType.String,"ReferenceMobileNumber",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ReferenceLetterPath",DbType.String,"ReferenceLetterPath",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ReferenceLetterMessage",DbType.String,"ReferenceLetterMessage",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ReferenceAcceptedPerson",DbType.Boolean,"ReferenceAcceptedPerson",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ReferenceInstitution",DbType.String,"ReferenceInstitution",DataRowVersion.Current);
				Database.AddInParameter(command,"oldPersonReferenceId",DbType.Int32,"PersonReferenceId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From PersonReference using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeletePersonReference( int personReferenceId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeletePersonReference");
			Database.AddInParameter(command,"PersonReferenceId",DbType.Int32,personReferenceId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From PersonReference Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeletePersonReferenceCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeletePersonReference");
				Database.AddInParameter(command,"PersonReferenceId",DbType.Int32,"PersonReferenceId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table PersonReference using Stored Procedure
		/// and return number of rows effected of the PersonReference
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"PersonReference",InsertNewPersonReferenceCommand(),UpdatePersonReferenceCommand(),DeletePersonReferenceCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table PersonReference using Stored Procedure
		/// and return number of rows effected of the PersonReference
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"PersonReference",InsertNewPersonReferenceCommand(),UpdatePersonReferenceCommand(),DeletePersonReferenceCommand(), transaction);
          return rowsAffected;
		}


	}
}
