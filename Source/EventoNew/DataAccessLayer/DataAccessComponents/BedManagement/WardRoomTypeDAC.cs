using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.BedManagement
{
	/// <summary>
	/// This is a Data Access Class  for WardRoomType table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the WardRoomType table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class WardRoomTypeDAC : DataAccessComponent
	{
		#region Constructors
		public WardRoomTypeDAC(){}
		public WardRoomTypeDAC(string connectionString): base(connectionString){}
		public WardRoomTypeDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardRoomType using Stored Procedure
		/// and return a DataTable containing all WardRoomType Data
		/// </summary>
		public DataTable GetAllWardRoomType()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardRoomType";
         string query = " select * from GetAllWardRoomType";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["WardRoomType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardRoomType using Stored Procedure
		/// and return a DataTable containing all WardRoomType Data using a Transaction
		/// </summary>
		public DataTable GetAllWardRoomType(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardRoomType";
         string query = " select * from GetAllWardRoomType";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["WardRoomType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardRoomType using Stored Procedure
		/// and return a DataTable containing all WardRoomType Data
		/// </summary>
		public DataTable GetAllWardRoomType(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardRoomType";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllWardRoomType" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["WardRoomType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardRoomType using Stored Procedure
		/// and return a DataTable containing all WardRoomType Data using a Transaction
		/// </summary>
		public DataTable GetAllWardRoomType(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardRoomType";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllWardRoomType" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["WardRoomType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From WardRoomType using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDWardRoomType( int wardRoomTypeId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDWardRoomType");
				    Database.AddInParameter(command,"WardRoomTypeId",DbType.Int32,wardRoomTypeId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From WardRoomType using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDWardRoomType( int wardRoomTypeId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDWardRoomType");
				    Database.AddInParameter(command,"WardRoomTypeId",DbType.Int32,wardRoomTypeId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into WardRoomType using Stored Procedure
		/// and return the auto number primary key of WardRoomType inserted row
		/// </summary>
		public bool InsertNewWardRoomType( ref int wardRoomTypeId,  string wardRoomTypeName)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardRoomType");
				Database.AddOutParameter(command,"WardRoomTypeId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardRoomTypeName",DbType.String,wardRoomTypeName);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 wardRoomTypeId = Convert.ToInt32(Database.GetParameterValue(command, "WardRoomTypeId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into WardRoomType using Stored Procedure
		/// and return the auto number primary key of WardRoomType inserted row using Transaction
		/// </summary>
		public bool InsertNewWardRoomType( ref int wardRoomTypeId,  string wardRoomTypeName,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardRoomType");
				Database.AddOutParameter(command,"WardRoomTypeId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardRoomTypeName",DbType.String,wardRoomTypeName);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 wardRoomTypeId = Convert.ToInt32(Database.GetParameterValue(command, "WardRoomTypeId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for WardRoomType using Stored Procedure
		/// and return DbCommand of the WardRoomType
		/// </summary>
		public DbCommand InsertNewWardRoomTypeCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardRoomType");

				Database.AddInParameter(command,"WardRoomTypeName",DbType.String,"WardRoomTypeName",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into WardRoomType using Stored Procedure
		/// </summary>
		public bool UpdateWardRoomType( string wardRoomTypeName, int oldwardRoomTypeId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardRoomType");

		    		Database.AddInParameter(command,"WardRoomTypeName",DbType.String,wardRoomTypeName);
				Database.AddInParameter(command,"oldWardRoomTypeId",DbType.Int32,oldwardRoomTypeId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into WardRoomType using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateWardRoomType( string wardRoomTypeName, int oldwardRoomTypeId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardRoomType");

		    		Database.AddInParameter(command,"WardRoomTypeName",DbType.String,wardRoomTypeName);
				Database.AddInParameter(command,"oldWardRoomTypeId",DbType.Int32,oldwardRoomTypeId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from WardRoomType using Stored Procedure
		/// </summary>
		public DbCommand UpdateWardRoomTypeCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardRoomType");

		    		Database.AddInParameter(command,"WardRoomTypeName",DbType.String,"WardRoomTypeName",DataRowVersion.Current);
				Database.AddInParameter(command,"oldWardRoomTypeId",DbType.Int32,"WardRoomTypeId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From WardRoomType using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteWardRoomType( int wardRoomTypeId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteWardRoomType");
			Database.AddInParameter(command,"WardRoomTypeId",DbType.Int32,wardRoomTypeId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From WardRoomType Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteWardRoomTypeCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteWardRoomType");
				Database.AddInParameter(command,"WardRoomTypeId",DbType.Int32,"WardRoomTypeId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table WardRoomType using Stored Procedure
		/// and return number of rows effected of the WardRoomType
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"WardRoomType",InsertNewWardRoomTypeCommand(),UpdateWardRoomTypeCommand(),DeleteWardRoomTypeCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table WardRoomType using Stored Procedure
		/// and return number of rows effected of the WardRoomType
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"WardRoomType",InsertNewWardRoomTypeCommand(),UpdateWardRoomTypeCommand(),DeleteWardRoomTypeCommand(), transaction);
          return rowsAffected;
		}


	}
}
