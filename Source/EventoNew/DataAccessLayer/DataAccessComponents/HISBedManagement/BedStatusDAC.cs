using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.HISBedManagement
{
	/// <summary>
	/// This is a Data Access Class  for BedStatus table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the BedStatus table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class BedStatusDAC : DataAccessComponent
	{
		#region Constructors
		public BedStatusDAC(){}
		public BedStatusDAC(string connectionString): base(connectionString){}
		public BedStatusDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all BedStatus using Stored Procedure
		/// and return a DataTable containing all BedStatus Data
		/// </summary>
		public DataTable GetAllBedStatus()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "BedStatus";
         string query = " select * from GetAllBedStatus";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["BedStatus"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all BedStatus using Stored Procedure
		/// and return a DataTable containing all BedStatus Data using a Transaction
		/// </summary>
		public DataTable GetAllBedStatus(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "BedStatus";
         string query = " select * from GetAllBedStatus";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["BedStatus"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all BedStatus using Stored Procedure
		/// and return a DataTable containing all BedStatus Data
		/// </summary>
		public DataTable GetAllBedStatus(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "BedStatus";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllBedStatus" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["BedStatus"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all BedStatus using Stored Procedure
		/// and return a DataTable containing all BedStatus Data using a Transaction
		/// </summary>
		public DataTable GetAllBedStatus(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "BedStatus";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllBedStatus" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["BedStatus"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From BedStatus using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDBedStatus( int bedStatusId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDBedStatus");
				    Database.AddInParameter(command,"BedStatusId",DbType.Int32,bedStatusId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From BedStatus using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDBedStatus( int bedStatusId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDBedStatus");
				    Database.AddInParameter(command,"BedStatusId",DbType.Int32,bedStatusId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into BedStatus using Stored Procedure
		/// and return the auto number primary key of BedStatus inserted row
		/// </summary>
		public bool InsertNewBedStatus( ref int bedStatusId,  string bedStatusName)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewBedStatus");
				Database.AddOutParameter(command,"BedStatusId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"BedStatusName",DbType.String,bedStatusName);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 bedStatusId = Convert.ToInt32(Database.GetParameterValue(command, "BedStatusId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into BedStatus using Stored Procedure
		/// and return the auto number primary key of BedStatus inserted row using Transaction
		/// </summary>
		public bool InsertNewBedStatus( ref int bedStatusId,  string bedStatusName,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewBedStatus");
				Database.AddOutParameter(command,"BedStatusId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"BedStatusName",DbType.String,bedStatusName);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 bedStatusId = Convert.ToInt32(Database.GetParameterValue(command, "BedStatusId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for BedStatus using Stored Procedure
		/// and return DbCommand of the BedStatus
		/// </summary>
		public DbCommand InsertNewBedStatusCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewBedStatus");

				Database.AddInParameter(command,"BedStatusName",DbType.String,"BedStatusName",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into BedStatus using Stored Procedure
		/// </summary>
		public bool UpdateBedStatus( string bedStatusName, int oldbedStatusId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateBedStatus");

		    		Database.AddInParameter(command,"BedStatusName",DbType.String,bedStatusName);
				Database.AddInParameter(command,"oldBedStatusId",DbType.Int32,oldbedStatusId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into BedStatus using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateBedStatus( string bedStatusName, int oldbedStatusId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateBedStatus");

		    		Database.AddInParameter(command,"BedStatusName",DbType.String,bedStatusName);
				Database.AddInParameter(command,"oldBedStatusId",DbType.Int32,oldbedStatusId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from BedStatus using Stored Procedure
		/// </summary>
		public DbCommand UpdateBedStatusCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateBedStatus");

		    		Database.AddInParameter(command,"BedStatusName",DbType.String,"BedStatusName",DataRowVersion.Current);
				Database.AddInParameter(command,"oldBedStatusId",DbType.Int32,"BedStatusId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From BedStatus using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteBedStatus( int bedStatusId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteBedStatus");
			Database.AddInParameter(command,"BedStatusId",DbType.Int32,bedStatusId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From BedStatus Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteBedStatusCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteBedStatus");
				Database.AddInParameter(command,"BedStatusId",DbType.Int32,"BedStatusId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table BedStatus using Stored Procedure
		/// and return number of rows effected of the BedStatus
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"BedStatus",InsertNewBedStatusCommand(),UpdateBedStatusCommand(),DeleteBedStatusCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table BedStatus using Stored Procedure
		/// and return number of rows effected of the BedStatus
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"BedStatus",InsertNewBedStatusCommand(),UpdateBedStatusCommand(),DeleteBedStatusCommand(), transaction);
          return rowsAffected;
		}


	}
}
