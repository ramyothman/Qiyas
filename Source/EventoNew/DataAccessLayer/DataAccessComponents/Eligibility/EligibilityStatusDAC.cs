using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.Eligibility
{
	/// <summary>
	/// This is a Data Access Class  for EligibilityStatus table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the EligibilityStatus table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class EligibilityStatusDAC : DataAccessComponent
	{
		#region Constructors
		public EligibilityStatusDAC(){}
		public EligibilityStatusDAC(string connectionString): base(connectionString){}
		public EligibilityStatusDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibilityStatus using Stored Procedure
		/// and return a DataTable containing all EligibilityStatus Data
		/// </summary>
		public DataTable GetAllEligibilityStatus()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibilityStatus";
         string query = " select * from GetAllEligibilityStatus";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["EligibilityStatus"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibilityStatus using Stored Procedure
		/// and return a DataTable containing all EligibilityStatus Data using a Transaction
		/// </summary>
		public DataTable GetAllEligibilityStatus(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibilityStatus";
         string query = " select * from GetAllEligibilityStatus";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["EligibilityStatus"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibilityStatus using Stored Procedure
		/// and return a DataTable containing all EligibilityStatus Data
		/// </summary>
		public DataTable GetAllEligibilityStatus(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibilityStatus";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllEligibilityStatus" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["EligibilityStatus"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibilityStatus using Stored Procedure
		/// and return a DataTable containing all EligibilityStatus Data using a Transaction
		/// </summary>
		public DataTable GetAllEligibilityStatus(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibilityStatus";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllEligibilityStatus" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["EligibilityStatus"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From EligibilityStatus using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDEligibilityStatus( int eligibilityStatusId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDEligibilityStatus");
				    Database.AddInParameter(command,"EligibilityStatusId",DbType.Int32,eligibilityStatusId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From EligibilityStatus using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDEligibilityStatus( int eligibilityStatusId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDEligibilityStatus");
				    Database.AddInParameter(command,"EligibilityStatusId",DbType.Int32,eligibilityStatusId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into EligibilityStatus using Stored Procedure
		/// and return the auto number primary key of EligibilityStatus inserted row
		/// </summary>
		public bool InsertNewEligibilityStatus( ref int eligibilityStatusId,  string name)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligibilityStatus");
				Database.AddOutParameter(command,"EligibilityStatusId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"Name",DbType.String,name);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 eligibilityStatusId = Convert.ToInt32(Database.GetParameterValue(command, "EligibilityStatusId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into EligibilityStatus using Stored Procedure
		/// and return the auto number primary key of EligibilityStatus inserted row using Transaction
		/// </summary>
		public bool InsertNewEligibilityStatus( ref int eligibilityStatusId,  string name,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligibilityStatus");
				Database.AddOutParameter(command,"EligibilityStatusId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"Name",DbType.String,name);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 eligibilityStatusId = Convert.ToInt32(Database.GetParameterValue(command, "EligibilityStatusId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for EligibilityStatus using Stored Procedure
		/// and return DbCommand of the EligibilityStatus
		/// </summary>
		public DbCommand InsertNewEligibilityStatusCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligibilityStatus");

				Database.AddInParameter(command,"Name",DbType.String,"Name",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into EligibilityStatus using Stored Procedure
		/// </summary>
		public bool UpdateEligibilityStatus( string name, int oldeligibilityStatusId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligibilityStatus");

		    		Database.AddInParameter(command,"Name",DbType.String,name);
				Database.AddInParameter(command,"oldEligibilityStatusId",DbType.Int32,oldeligibilityStatusId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into EligibilityStatus using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateEligibilityStatus( string name, int oldeligibilityStatusId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligibilityStatus");

		    		Database.AddInParameter(command,"Name",DbType.String,name);
				Database.AddInParameter(command,"oldEligibilityStatusId",DbType.Int32,oldeligibilityStatusId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from EligibilityStatus using Stored Procedure
		/// </summary>
		public DbCommand UpdateEligibilityStatusCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligibilityStatus");

		    		Database.AddInParameter(command,"Name",DbType.String,"Name",DataRowVersion.Current);
				Database.AddInParameter(command,"oldEligibilityStatusId",DbType.Int32,"EligibilityStatusId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From EligibilityStatus using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteEligibilityStatus( int eligibilityStatusId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteEligibilityStatus");
			Database.AddInParameter(command,"EligibilityStatusId",DbType.Int32,eligibilityStatusId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From EligibilityStatus Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteEligibilityStatusCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteEligibilityStatus");
				Database.AddInParameter(command,"EligibilityStatusId",DbType.Int32,"EligibilityStatusId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table EligibilityStatus using Stored Procedure
		/// and return number of rows effected of the EligibilityStatus
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"EligibilityStatus",InsertNewEligibilityStatusCommand(),UpdateEligibilityStatusCommand(),DeleteEligibilityStatusCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table EligibilityStatus using Stored Procedure
		/// and return number of rows effected of the EligibilityStatus
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"EligibilityStatus",InsertNewEligibilityStatusCommand(),UpdateEligibilityStatusCommand(),DeleteEligibilityStatusCommand(), transaction);
          return rowsAffected;
		}


	}
}
