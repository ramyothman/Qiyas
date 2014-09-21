using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.Eligibility
{
	/// <summary>
	/// This is a Data Access Class  for EligibleRequestStatusHistory table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the EligibleRequestStatusHistory table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class EligibleRequestStatusHistoryDAC : DataAccessComponent
	{
		#region Constructors
		public EligibleRequestStatusHistoryDAC(){}
		public EligibleRequestStatusHistoryDAC(string connectionString): base(connectionString){}
		public EligibleRequestStatusHistoryDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibleRequestStatusHistory using Stored Procedure
		/// and return a DataTable containing all EligibleRequestStatusHistory Data
		/// </summary>
		public DataTable GetAllEligibleRequestStatusHistory()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibleRequestStatusHistory";
         string query = " select * from GetAllEligibleRequestStatusHistory";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["EligibleRequestStatusHistory"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibleRequestStatusHistory using Stored Procedure
		/// and return a DataTable containing all EligibleRequestStatusHistory Data using a Transaction
		/// </summary>
		public DataTable GetAllEligibleRequestStatusHistory(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibleRequestStatusHistory";
         string query = " select * from GetAllEligibleRequestStatusHistory";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["EligibleRequestStatusHistory"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibleRequestStatusHistory using Stored Procedure
		/// and return a DataTable containing all EligibleRequestStatusHistory Data
		/// </summary>
		public DataTable GetAllEligibleRequestStatusHistory(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibleRequestStatusHistory";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllEligibleRequestStatusHistory" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["EligibleRequestStatusHistory"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibleRequestStatusHistory using Stored Procedure
		/// and return a DataTable containing all EligibleRequestStatusHistory Data using a Transaction
		/// </summary>
		public DataTable GetAllEligibleRequestStatusHistory(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibleRequestStatusHistory";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllEligibleRequestStatusHistory" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["EligibleRequestStatusHistory"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From EligibleRequestStatusHistory using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDEligibleRequestStatusHistory( int eligibilityRequestStatusId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDEligibleRequestStatusHistory");
				    Database.AddInParameter(command,"EligibilityRequestStatusId",DbType.Int32,eligibilityRequestStatusId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From EligibleRequestStatusHistory using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDEligibleRequestStatusHistory( int eligibilityRequestStatusId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDEligibleRequestStatusHistory");
				    Database.AddInParameter(command,"EligibilityRequestStatusId",DbType.Int32,eligibilityRequestStatusId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into EligibleRequestStatusHistory using Stored Procedure
		/// and return the auto number primary key of EligibleRequestStatusHistory inserted row
		/// </summary>
		public bool InsertNewEligibleRequestStatusHistory( ref int eligibilityRequestStatusId,  int eligibilityStatusId,  int eligibileId,  DateTime creationDate,  string notes)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligibleRequestStatusHistory");
				Database.AddOutParameter(command,"EligibilityRequestStatusId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"EligibilityStatusId",DbType.Int32,eligibilityStatusId);
				Database.AddInParameter(command,"EligibileId",DbType.Int32,eligibileId);
				Database.AddInParameter(command,"CreationDate",DbType.DateTime,creationDate);
				Database.AddInParameter(command,"Notes",DbType.String,notes);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 eligibilityRequestStatusId = Convert.ToInt32(Database.GetParameterValue(command, "EligibilityRequestStatusId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into EligibleRequestStatusHistory using Stored Procedure
		/// and return the auto number primary key of EligibleRequestStatusHistory inserted row using Transaction
		/// </summary>
		public bool InsertNewEligibleRequestStatusHistory( ref int eligibilityRequestStatusId,  int eligibilityStatusId,  int eligibileId,  DateTime creationDate,  string notes,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligibleRequestStatusHistory");
				Database.AddOutParameter(command,"EligibilityRequestStatusId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"EligibilityStatusId",DbType.Int32,eligibilityStatusId);
				Database.AddInParameter(command,"EligibileId",DbType.Int32,eligibileId);
				Database.AddInParameter(command,"CreationDate",DbType.DateTime,creationDate);
				Database.AddInParameter(command,"Notes",DbType.String,notes);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 eligibilityRequestStatusId = Convert.ToInt32(Database.GetParameterValue(command, "EligibilityRequestStatusId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for EligibleRequestStatusHistory using Stored Procedure
		/// and return DbCommand of the EligibleRequestStatusHistory
		/// </summary>
		public DbCommand InsertNewEligibleRequestStatusHistoryCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligibleRequestStatusHistory");

				Database.AddInParameter(command,"EligibilityStatusId",DbType.Int32,"EligibilityStatusId",DataRowVersion.Current);
				Database.AddInParameter(command,"EligibileId",DbType.Int32,"EligibileId",DataRowVersion.Current);
				Database.AddInParameter(command,"CreationDate",DbType.DateTime,"CreationDate",DataRowVersion.Current);
				Database.AddInParameter(command,"Notes",DbType.String,"Notes",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into EligibleRequestStatusHistory using Stored Procedure
		/// </summary>
		public bool UpdateEligibleRequestStatusHistory( int eligibilityStatusId, int eligibileId, DateTime creationDate, string notes, int oldeligibilityRequestStatusId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligibleRequestStatusHistory");

		    		Database.AddInParameter(command,"EligibilityStatusId",DbType.Int32,eligibilityStatusId);
		    		Database.AddInParameter(command,"EligibileId",DbType.Int32,eligibileId);
		    		Database.AddInParameter(command,"CreationDate",DbType.DateTime,creationDate);
		    		Database.AddInParameter(command,"Notes",DbType.String,notes);
				Database.AddInParameter(command,"oldEligibilityRequestStatusId",DbType.Int32,oldeligibilityRequestStatusId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into EligibleRequestStatusHistory using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateEligibleRequestStatusHistory( int eligibilityStatusId, int eligibileId, DateTime creationDate, string notes, int oldeligibilityRequestStatusId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligibleRequestStatusHistory");

		    		Database.AddInParameter(command,"EligibilityStatusId",DbType.Int32,eligibilityStatusId);
		    		Database.AddInParameter(command,"EligibileId",DbType.Int32,eligibileId);
		    		Database.AddInParameter(command,"CreationDate",DbType.DateTime,creationDate);
		    		Database.AddInParameter(command,"Notes",DbType.String,notes);
				Database.AddInParameter(command,"oldEligibilityRequestStatusId",DbType.Int32,oldeligibilityRequestStatusId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from EligibleRequestStatusHistory using Stored Procedure
		/// </summary>
		public DbCommand UpdateEligibleRequestStatusHistoryCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligibleRequestStatusHistory");

		    		Database.AddInParameter(command,"EligibilityStatusId",DbType.Int32,"EligibilityStatusId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"EligibileId",DbType.Int32,"EligibileId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"CreationDate",DbType.DateTime,"CreationDate",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Notes",DbType.String,"Notes",DataRowVersion.Current);
				Database.AddInParameter(command,"oldEligibilityRequestStatusId",DbType.Int32,"EligibilityRequestStatusId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From EligibleRequestStatusHistory using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteEligibleRequestStatusHistory( int eligibilityRequestStatusId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteEligibleRequestStatusHistory");
			Database.AddInParameter(command,"EligibilityRequestStatusId",DbType.Int32,eligibilityRequestStatusId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From EligibleRequestStatusHistory Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteEligibleRequestStatusHistoryCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteEligibleRequestStatusHistory");
				Database.AddInParameter(command,"EligibilityRequestStatusId",DbType.Int32,"EligibilityRequestStatusId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table EligibleRequestStatusHistory using Stored Procedure
		/// and return number of rows effected of the EligibleRequestStatusHistory
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"EligibleRequestStatusHistory",InsertNewEligibleRequestStatusHistoryCommand(),UpdateEligibleRequestStatusHistoryCommand(),DeleteEligibleRequestStatusHistoryCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table EligibleRequestStatusHistory using Stored Procedure
		/// and return number of rows effected of the EligibleRequestStatusHistory
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"EligibleRequestStatusHistory",InsertNewEligibleRequestStatusHistoryCommand(),UpdateEligibleRequestStatusHistoryCommand(),DeleteEligibleRequestStatusHistoryCommand(), transaction);
          return rowsAffected;
		}


	}
}
