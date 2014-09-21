using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.HISBedManagement
{
	/// <summary>
	/// This is a Data Access Class  for RoomType table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the RoomType table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class RoomTypeDAC : DataAccessComponent
	{
		#region Constructors
		public RoomTypeDAC(){}
		public RoomTypeDAC(string connectionString): base(connectionString){}
		public RoomTypeDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all RoomType using Stored Procedure
		/// and return a DataTable containing all RoomType Data
		/// </summary>
		public DataTable GetAllRoomType()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "RoomType";
         string query = " select * from GetAllRoomType";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["RoomType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all RoomType using Stored Procedure
		/// and return a DataTable containing all RoomType Data using a Transaction
		/// </summary>
		public DataTable GetAllRoomType(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "RoomType";
         string query = " select * from GetAllRoomType";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["RoomType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all RoomType using Stored Procedure
		/// and return a DataTable containing all RoomType Data
		/// </summary>
		public DataTable GetAllRoomType(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "RoomType";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllRoomType" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["RoomType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all RoomType using Stored Procedure
		/// and return a DataTable containing all RoomType Data using a Transaction
		/// </summary>
		public DataTable GetAllRoomType(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "RoomType";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllRoomType" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["RoomType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From RoomType using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDRoomType( int roomTypeId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDRoomType");
				    Database.AddInParameter(command,"RoomTypeId",DbType.Int32,roomTypeId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From RoomType using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDRoomType( int roomTypeId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDRoomType");
				    Database.AddInParameter(command,"RoomTypeId",DbType.Int32,roomTypeId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into RoomType using Stored Procedure
		/// and return the auto number primary key of RoomType inserted row
		/// </summary>
		public bool InsertNewRoomType( ref int roomTypeId,  string roomTypeName)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewRoomType");
				Database.AddOutParameter(command,"RoomTypeId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"RoomTypeName",DbType.String,roomTypeName);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 roomTypeId = Convert.ToInt32(Database.GetParameterValue(command, "RoomTypeId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into RoomType using Stored Procedure
		/// and return the auto number primary key of RoomType inserted row using Transaction
		/// </summary>
		public bool InsertNewRoomType( ref int roomTypeId,  string roomTypeName,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewRoomType");
				Database.AddOutParameter(command,"RoomTypeId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"RoomTypeName",DbType.String,roomTypeName);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 roomTypeId = Convert.ToInt32(Database.GetParameterValue(command, "RoomTypeId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for RoomType using Stored Procedure
		/// and return DbCommand of the RoomType
		/// </summary>
		public DbCommand InsertNewRoomTypeCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewRoomType");

				Database.AddInParameter(command,"RoomTypeName",DbType.String,"RoomTypeName",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into RoomType using Stored Procedure
		/// </summary>
		public bool UpdateRoomType( string roomTypeName, int oldroomTypeId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateRoomType");

		    		Database.AddInParameter(command,"RoomTypeName",DbType.String,roomTypeName);
				Database.AddInParameter(command,"oldRoomTypeId",DbType.Int32,oldroomTypeId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into RoomType using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateRoomType( string roomTypeName, int oldroomTypeId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateRoomType");

		    		Database.AddInParameter(command,"RoomTypeName",DbType.String,roomTypeName);
				Database.AddInParameter(command,"oldRoomTypeId",DbType.Int32,oldroomTypeId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from RoomType using Stored Procedure
		/// </summary>
		public DbCommand UpdateRoomTypeCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateRoomType");

		    		Database.AddInParameter(command,"RoomTypeName",DbType.String,"RoomTypeName",DataRowVersion.Current);
				Database.AddInParameter(command,"oldRoomTypeId",DbType.Int32,"RoomTypeId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From RoomType using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteRoomType( int roomTypeId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteRoomType");
			Database.AddInParameter(command,"RoomTypeId",DbType.Int32,roomTypeId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From RoomType Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteRoomTypeCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteRoomType");
				Database.AddInParameter(command,"RoomTypeId",DbType.Int32,"RoomTypeId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table RoomType using Stored Procedure
		/// and return number of rows effected of the RoomType
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"RoomType",InsertNewRoomTypeCommand(),UpdateRoomTypeCommand(),DeleteRoomTypeCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table RoomType using Stored Procedure
		/// and return number of rows effected of the RoomType
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"RoomType",InsertNewRoomTypeCommand(),UpdateRoomTypeCommand(),DeleteRoomTypeCommand(), transaction);
          return rowsAffected;
		}


	}
}
