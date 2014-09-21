using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.HISBedManagement
{
	/// <summary>
	/// This is a Data Access Class  for WardFor table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the WardFor table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class WardForDAC : DataAccessComponent
	{
		#region Constructors
		public WardForDAC(){}
		public WardForDAC(string connectionString): base(connectionString){}
		public WardForDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardFor using Stored Procedure
		/// and return a DataTable containing all WardFor Data
		/// </summary>
		public DataTable GetAllWardFor()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardFor";
         string query = " select * from GetAllWardFor";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["WardFor"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardFor using Stored Procedure
		/// and return a DataTable containing all WardFor Data using a Transaction
		/// </summary>
		public DataTable GetAllWardFor(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardFor";
         string query = " select * from GetAllWardFor";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["WardFor"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardFor using Stored Procedure
		/// and return a DataTable containing all WardFor Data
		/// </summary>
		public DataTable GetAllWardFor(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardFor";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllWardFor" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["WardFor"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardFor using Stored Procedure
		/// and return a DataTable containing all WardFor Data using a Transaction
		/// </summary>
		public DataTable GetAllWardFor(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardFor";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllWardFor" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["WardFor"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From WardFor using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDWardFor( int wardForId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDWardFor");
				    Database.AddInParameter(command,"WardForId",DbType.Int32,wardForId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From WardFor using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDWardFor( int wardForId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDWardFor");
				    Database.AddInParameter(command,"WardForId",DbType.Int32,wardForId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into WardFor using Stored Procedure
		/// and return the auto number primary key of WardFor inserted row
		/// </summary>
		public bool InsertNewWardFor( ref int wardForId,  string wardForName)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardFor");
				Database.AddOutParameter(command,"WardForId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardForName",DbType.String,wardForName);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 wardForId = Convert.ToInt32(Database.GetParameterValue(command, "WardForId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into WardFor using Stored Procedure
		/// and return the auto number primary key of WardFor inserted row using Transaction
		/// </summary>
		public bool InsertNewWardFor( ref int wardForId,  string wardForName,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardFor");
				Database.AddOutParameter(command,"WardForId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardForName",DbType.String,wardForName);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 wardForId = Convert.ToInt32(Database.GetParameterValue(command, "WardForId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for WardFor using Stored Procedure
		/// and return DbCommand of the WardFor
		/// </summary>
		public DbCommand InsertNewWardForCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardFor");

				Database.AddInParameter(command,"WardForName",DbType.String,"WardForName",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into WardFor using Stored Procedure
		/// </summary>
		public bool UpdateWardFor( string wardForName, int oldwardForId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardFor");

		    		Database.AddInParameter(command,"WardForName",DbType.String,wardForName);
				Database.AddInParameter(command,"oldWardForId",DbType.Int32,oldwardForId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into WardFor using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateWardFor( string wardForName, int oldwardForId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardFor");

		    		Database.AddInParameter(command,"WardForName",DbType.String,wardForName);
				Database.AddInParameter(command,"oldWardForId",DbType.Int32,oldwardForId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from WardFor using Stored Procedure
		/// </summary>
		public DbCommand UpdateWardForCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardFor");

		    		Database.AddInParameter(command,"WardForName",DbType.String,"WardForName",DataRowVersion.Current);
				Database.AddInParameter(command,"oldWardForId",DbType.Int32,"WardForId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From WardFor using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteWardFor( int wardForId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteWardFor");
			Database.AddInParameter(command,"WardForId",DbType.Int32,wardForId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From WardFor Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteWardForCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteWardFor");
				Database.AddInParameter(command,"WardForId",DbType.Int32,"WardForId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table WardFor using Stored Procedure
		/// and return number of rows effected of the WardFor
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"WardFor",InsertNewWardForCommand(),UpdateWardForCommand(),DeleteWardForCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table WardFor using Stored Procedure
		/// and return number of rows effected of the WardFor
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"WardFor",InsertNewWardForCommand(),UpdateWardForCommand(),DeleteWardForCommand(), transaction);
          return rowsAffected;
		}


	}
}
