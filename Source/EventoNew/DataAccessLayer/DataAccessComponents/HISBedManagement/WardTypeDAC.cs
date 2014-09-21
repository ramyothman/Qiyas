using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.HISBedManagement
{
	/// <summary>
	/// This is a Data Access Class  for WardType table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the WardType table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class WardTypeDAC : DataAccessComponent
	{
		#region Constructors
		public WardTypeDAC(){}
		public WardTypeDAC(string connectionString): base(connectionString){}
		public WardTypeDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardType using Stored Procedure
		/// and return a DataTable containing all WardType Data
		/// </summary>
		public DataTable GetAllWardType()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardType";
         string query = " select * from GetAllWardType";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["WardType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardType using Stored Procedure
		/// and return a DataTable containing all WardType Data using a Transaction
		/// </summary>
		public DataTable GetAllWardType(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardType";
         string query = " select * from GetAllWardType";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["WardType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardType using Stored Procedure
		/// and return a DataTable containing all WardType Data
		/// </summary>
		public DataTable GetAllWardType(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardType";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllWardType" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["WardType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardType using Stored Procedure
		/// and return a DataTable containing all WardType Data using a Transaction
		/// </summary>
		public DataTable GetAllWardType(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardType";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllWardType" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["WardType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From WardType using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDWardType( int wardTypeId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDWardType");
				    Database.AddInParameter(command,"WardTypeId",DbType.Int32,wardTypeId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From WardType using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDWardType( int wardTypeId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDWardType");
				    Database.AddInParameter(command,"WardTypeId",DbType.Int32,wardTypeId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into WardType using Stored Procedure
		/// and return the auto number primary key of WardType inserted row
		/// </summary>
		public bool InsertNewWardType( ref int wardTypeId,  string wardTypeName)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardType");
				Database.AddOutParameter(command,"WardTypeId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardTypeName",DbType.String,wardTypeName);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 wardTypeId = Convert.ToInt32(Database.GetParameterValue(command, "WardTypeId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into WardType using Stored Procedure
		/// and return the auto number primary key of WardType inserted row using Transaction
		/// </summary>
		public bool InsertNewWardType( ref int wardTypeId,  string wardTypeName,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardType");
				Database.AddOutParameter(command,"WardTypeId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardTypeName",DbType.String,wardTypeName);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 wardTypeId = Convert.ToInt32(Database.GetParameterValue(command, "WardTypeId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for WardType using Stored Procedure
		/// and return DbCommand of the WardType
		/// </summary>
		public DbCommand InsertNewWardTypeCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardType");

				Database.AddInParameter(command,"WardTypeName",DbType.String,"WardTypeName",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into WardType using Stored Procedure
		/// </summary>
		public bool UpdateWardType( string wardTypeName, int oldwardTypeId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardType");

		    		Database.AddInParameter(command,"WardTypeName",DbType.String,wardTypeName);
				Database.AddInParameter(command,"oldWardTypeId",DbType.Int32,oldwardTypeId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into WardType using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateWardType( string wardTypeName, int oldwardTypeId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardType");

		    		Database.AddInParameter(command,"WardTypeName",DbType.String,wardTypeName);
				Database.AddInParameter(command,"oldWardTypeId",DbType.Int32,oldwardTypeId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from WardType using Stored Procedure
		/// </summary>
		public DbCommand UpdateWardTypeCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardType");

		    		Database.AddInParameter(command,"WardTypeName",DbType.String,"WardTypeName",DataRowVersion.Current);
				Database.AddInParameter(command,"oldWardTypeId",DbType.Int32,"WardTypeId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From WardType using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteWardType( int wardTypeId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteWardType");
			Database.AddInParameter(command,"WardTypeId",DbType.Int32,wardTypeId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From WardType Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteWardTypeCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteWardType");
				Database.AddInParameter(command,"WardTypeId",DbType.Int32,"WardTypeId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table WardType using Stored Procedure
		/// and return number of rows effected of the WardType
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"WardType",InsertNewWardTypeCommand(),UpdateWardTypeCommand(),DeleteWardTypeCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table WardType using Stored Procedure
		/// and return number of rows effected of the WardType
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"WardType",InsertNewWardTypeCommand(),UpdateWardTypeCommand(),DeleteWardTypeCommand(), transaction);
          return rowsAffected;
		}


	}
}
