using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.PGME
{
	/// <summary>
	/// This is a Data Access Class  for PersonRegisterationStatus table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the PersonRegisterationStatus table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class PersonRegisterationStatusDAC : DataAccessComponent
	{
		#region Constructors
		public PersonRegisterationStatusDAC(){}
		public PersonRegisterationStatusDAC(string connectionString): base(connectionString){}
		public PersonRegisterationStatusDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all PersonRegisterationStatus using Stored Procedure
		/// and return a DataTable containing all PersonRegisterationStatus Data
		/// </summary>
		public DataTable GetAllPersonRegisterationStatus()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "PersonRegisterationStatus";
         string query = " select * from GetAllPersonRegisterationStatus";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["PersonRegisterationStatus"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all PersonRegisterationStatus using Stored Procedure
		/// and return a DataTable containing all PersonRegisterationStatus Data using a Transaction
		/// </summary>
		public DataTable GetAllPersonRegisterationStatus(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "PersonRegisterationStatus";
         string query = " select * from GetAllPersonRegisterationStatus";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["PersonRegisterationStatus"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all PersonRegisterationStatus using Stored Procedure
		/// and return a DataTable containing all PersonRegisterationStatus Data
		/// </summary>
		public DataTable GetAllPersonRegisterationStatus(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "PersonRegisterationStatus";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllPersonRegisterationStatus" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["PersonRegisterationStatus"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all PersonRegisterationStatus using Stored Procedure
		/// and return a DataTable containing all PersonRegisterationStatus Data using a Transaction
		/// </summary>
		public DataTable GetAllPersonRegisterationStatus(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "PersonRegisterationStatus";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllPersonRegisterationStatus" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["PersonRegisterationStatus"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From PersonRegisterationStatus using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDPersonRegisterationStatus( int personRegisterationStatusId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDPersonRegisterationStatus");
				    Database.AddInParameter(command,"PersonRegisterationStatusId",DbType.Int32,personRegisterationStatusId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From PersonRegisterationStatus using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDPersonRegisterationStatus( int personRegisterationStatusId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDPersonRegisterationStatus");
				    Database.AddInParameter(command,"PersonRegisterationStatusId",DbType.Int32,personRegisterationStatusId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into PersonRegisterationStatus using Stored Procedure
		/// and return the auto number primary key of PersonRegisterationStatus inserted row
		/// </summary>
		public bool InsertNewPersonRegisterationStatus( ref int personRegisterationStatusId,  string status)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewPersonRegisterationStatus");
				Database.AddOutParameter(command,"PersonRegisterationStatusId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"Status",DbType.String,status);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 personRegisterationStatusId = Convert.ToInt32(Database.GetParameterValue(command, "PersonRegisterationStatusId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into PersonRegisterationStatus using Stored Procedure
		/// and return the auto number primary key of PersonRegisterationStatus inserted row using Transaction
		/// </summary>
		public bool InsertNewPersonRegisterationStatus( ref int personRegisterationStatusId,  string status,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewPersonRegisterationStatus");
				Database.AddOutParameter(command,"PersonRegisterationStatusId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"Status",DbType.String,status);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 personRegisterationStatusId = Convert.ToInt32(Database.GetParameterValue(command, "PersonRegisterationStatusId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for PersonRegisterationStatus using Stored Procedure
		/// and return DbCommand of the PersonRegisterationStatus
		/// </summary>
		public DbCommand InsertNewPersonRegisterationStatusCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewPersonRegisterationStatus");

				Database.AddInParameter(command,"Status",DbType.String,"Status",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into PersonRegisterationStatus using Stored Procedure
		/// </summary>
		public bool UpdatePersonRegisterationStatus( string status, int oldpersonRegisterationStatusId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdatePersonRegisterationStatus");

		    		Database.AddInParameter(command,"Status",DbType.String,status);
				Database.AddInParameter(command,"oldPersonRegisterationStatusId",DbType.Int32,oldpersonRegisterationStatusId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into PersonRegisterationStatus using Stored Procedure By Transaction
		/// </summary>
		public bool UpdatePersonRegisterationStatus( string status, int oldpersonRegisterationStatusId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdatePersonRegisterationStatus");

		    		Database.AddInParameter(command,"Status",DbType.String,status);
				Database.AddInParameter(command,"oldPersonRegisterationStatusId",DbType.Int32,oldpersonRegisterationStatusId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from PersonRegisterationStatus using Stored Procedure
		/// </summary>
		public DbCommand UpdatePersonRegisterationStatusCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdatePersonRegisterationStatus");

		    		Database.AddInParameter(command,"Status",DbType.String,"Status",DataRowVersion.Current);
				Database.AddInParameter(command,"oldPersonRegisterationStatusId",DbType.Int32,"PersonRegisterationStatusId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From PersonRegisterationStatus using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeletePersonRegisterationStatus( int personRegisterationStatusId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeletePersonRegisterationStatus");
			Database.AddInParameter(command,"PersonRegisterationStatusId",DbType.Int32,personRegisterationStatusId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From PersonRegisterationStatus Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeletePersonRegisterationStatusCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeletePersonRegisterationStatus");
				Database.AddInParameter(command,"PersonRegisterationStatusId",DbType.Int32,"PersonRegisterationStatusId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table PersonRegisterationStatus using Stored Procedure
		/// and return number of rows effected of the PersonRegisterationStatus
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"PersonRegisterationStatus",InsertNewPersonRegisterationStatusCommand(),UpdatePersonRegisterationStatusCommand(),DeletePersonRegisterationStatusCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table PersonRegisterationStatus using Stored Procedure
		/// and return number of rows effected of the PersonRegisterationStatus
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"PersonRegisterationStatus",InsertNewPersonRegisterationStatusCommand(),UpdatePersonRegisterationStatusCommand(),DeletePersonRegisterationStatusCommand(), transaction);
          return rowsAffected;
		}


	}
}
