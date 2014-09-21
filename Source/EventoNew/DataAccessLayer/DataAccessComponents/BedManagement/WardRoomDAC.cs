using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.BedManagement
{
	/// <summary>
	/// This is a Data Access Class  for WardRoom table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the WardRoom table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class WardRoomDAC : DataAccessComponent
	{
		#region Constructors
		public WardRoomDAC(){}
		public WardRoomDAC(string connectionString): base(connectionString){}
		public WardRoomDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardRoom using Stored Procedure
		/// and return a DataTable containing all WardRoom Data
		/// </summary>
		public DataTable GetAllWardRoom()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardRoom";
         string query = " select * from GetAllWardRoom";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["WardRoom"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardRoom using Stored Procedure
		/// and return a DataTable containing all WardRoom Data using a Transaction
		/// </summary>
		public DataTable GetAllWardRoom(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardRoom";
         string query = " select * from GetAllWardRoom";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["WardRoom"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardRoom using Stored Procedure
		/// and return a DataTable containing all WardRoom Data
		/// </summary>
		public DataTable GetAllWardRoom(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardRoom";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllWardRoom" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["WardRoom"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardRoom using Stored Procedure
		/// and return a DataTable containing all WardRoom Data using a Transaction
		/// </summary>
		public DataTable GetAllWardRoom(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardRoom";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllWardRoom" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["WardRoom"];

		}

        public DataTable ViewWardRoomBeds()
        {
            return ViewWardRoomBeds("");
        }
        public DataTable ViewWardRoomBeds(string where)
        {

            DataSet ds = new DataSet();
            string[] tableNames = new string[1];
            tableNames[0] = "ViewWardRoomBeds";
            string whereClause = "";
            if (!string.IsNullOrEmpty(where))
                whereClause = " Where " + where;
            string query = " select * from ViewWardRoomBeds" + whereClause;
            DbCommand command = Database.GetSqlStringCommand(query);
            Database.LoadDataSet(command, ds, tableNames);
            return ds.Tables["ViewWardRoomBeds"];

        }

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From WardRoom using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDWardRoom( int wardRoomId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDWardRoom");
				    Database.AddInParameter(command,"WardRoomId",DbType.Int32,wardRoomId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From WardRoom using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDWardRoom( int wardRoomId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDWardRoom");
				    Database.AddInParameter(command,"WardRoomId",DbType.Int32,wardRoomId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into WardRoom using Stored Procedure
		/// and return the auto number primary key of WardRoom inserted row
		/// </summary>
		public bool InsertNewWardRoom( ref int wardRoomId,  int wardId,  string roomColor,  int roomNumber,  int bedsNumber,  int capacity,  bool isPrivate,  string roomPhone,  int wardRoomTypeId,  bool isClosed)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardRoom");
				Database.AddOutParameter(command,"WardRoomId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardId",DbType.Int32,wardId);
				Database.AddInParameter(command,"RoomColor",DbType.String,roomColor);
				Database.AddInParameter(command,"RoomNumber",DbType.Int32,roomNumber);
				Database.AddInParameter(command,"BedsNumber",DbType.Int32,bedsNumber);
				Database.AddInParameter(command,"Capacity",DbType.Int32,capacity);
				Database.AddInParameter(command,"IsPrivate",DbType.Boolean,isPrivate);
				Database.AddInParameter(command,"RoomPhone",DbType.String,roomPhone);
				Database.AddInParameter(command,"WardRoomTypeId",DbType.Int32,wardRoomTypeId);
				Database.AddInParameter(command,"IsClosed",DbType.Boolean,isClosed);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 wardRoomId = Convert.ToInt32(Database.GetParameterValue(command, "WardRoomId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into WardRoom using Stored Procedure
		/// and return the auto number primary key of WardRoom inserted row using Transaction
		/// </summary>
		public bool InsertNewWardRoom( ref int wardRoomId,  int wardId,  string roomColor,  int roomNumber,  int bedsNumber,  int capacity,  bool isPrivate,  string roomPhone,  int wardRoomTypeId,  bool isClosed,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardRoom");
				Database.AddOutParameter(command,"WardRoomId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardId",DbType.Int32,wardId);
				Database.AddInParameter(command,"RoomColor",DbType.String,roomColor);
				Database.AddInParameter(command,"RoomNumber",DbType.Int32,roomNumber);
				Database.AddInParameter(command,"BedsNumber",DbType.Int32,bedsNumber);
				Database.AddInParameter(command,"Capacity",DbType.Int32,capacity);
				Database.AddInParameter(command,"IsPrivate",DbType.Boolean,isPrivate);
				Database.AddInParameter(command,"RoomPhone",DbType.String,roomPhone);
				Database.AddInParameter(command,"WardRoomTypeId",DbType.Int32,wardRoomTypeId);
				Database.AddInParameter(command,"IsClosed",DbType.Boolean,isClosed);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 wardRoomId = Convert.ToInt32(Database.GetParameterValue(command, "WardRoomId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for WardRoom using Stored Procedure
		/// and return DbCommand of the WardRoom
		/// </summary>
		public DbCommand InsertNewWardRoomCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardRoom");

				Database.AddInParameter(command,"WardId",DbType.Int32,"WardId",DataRowVersion.Current);
				Database.AddInParameter(command,"RoomColor",DbType.String,"RoomColor",DataRowVersion.Current);
				Database.AddInParameter(command,"RoomNumber",DbType.Int32,"RoomNumber",DataRowVersion.Current);
				Database.AddInParameter(command,"BedsNumber",DbType.Int32,"BedsNumber",DataRowVersion.Current);
				Database.AddInParameter(command,"Capacity",DbType.Int32,"Capacity",DataRowVersion.Current);
				Database.AddInParameter(command,"IsPrivate",DbType.Boolean,"IsPrivate",DataRowVersion.Current);
				Database.AddInParameter(command,"RoomPhone",DbType.String,"RoomPhone",DataRowVersion.Current);
				Database.AddInParameter(command,"WardRoomTypeId",DbType.Int32,"WardRoomTypeId",DataRowVersion.Current);
				Database.AddInParameter(command,"IsClosed",DbType.Boolean,"IsClosed",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into WardRoom using Stored Procedure
		/// </summary>
		public bool UpdateWardRoom( int wardId, string roomColor, int roomNumber, int bedsNumber, int capacity, bool isPrivate, string roomPhone, int wardRoomTypeId, bool isClosed, int oldwardRoomId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardRoom");

		    		Database.AddInParameter(command,"WardId",DbType.Int32,wardId);
		    		Database.AddInParameter(command,"RoomColor",DbType.String,roomColor);
		    		Database.AddInParameter(command,"RoomNumber",DbType.Int32,roomNumber);
		    		Database.AddInParameter(command,"BedsNumber",DbType.Int32,bedsNumber);
		    		Database.AddInParameter(command,"Capacity",DbType.Int32,capacity);
		    		Database.AddInParameter(command,"IsPrivate",DbType.Boolean,isPrivate);
		    		Database.AddInParameter(command,"RoomPhone",DbType.String,roomPhone);
		    		Database.AddInParameter(command,"WardRoomTypeId",DbType.Int32,wardRoomTypeId);
		    		Database.AddInParameter(command,"IsClosed",DbType.Boolean,isClosed);
				Database.AddInParameter(command,"oldWardRoomId",DbType.Int32,oldwardRoomId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into WardRoom using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateWardRoom( int wardId, string roomColor, int roomNumber, int bedsNumber, int capacity, bool isPrivate, string roomPhone, int wardRoomTypeId, bool isClosed, int oldwardRoomId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardRoom");

		    		Database.AddInParameter(command,"WardId",DbType.Int32,wardId);
		    		Database.AddInParameter(command,"RoomColor",DbType.String,roomColor);
		    		Database.AddInParameter(command,"RoomNumber",DbType.Int32,roomNumber);
		    		Database.AddInParameter(command,"BedsNumber",DbType.Int32,bedsNumber);
		    		Database.AddInParameter(command,"Capacity",DbType.Int32,capacity);
		    		Database.AddInParameter(command,"IsPrivate",DbType.Boolean,isPrivate);
		    		Database.AddInParameter(command,"RoomPhone",DbType.String,roomPhone);
		    		Database.AddInParameter(command,"WardRoomTypeId",DbType.Int32,wardRoomTypeId);
		    		Database.AddInParameter(command,"IsClosed",DbType.Boolean,isClosed);
				Database.AddInParameter(command,"oldWardRoomId",DbType.Int32,oldwardRoomId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from WardRoom using Stored Procedure
		/// </summary>
		public DbCommand UpdateWardRoomCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardRoom");

		    		Database.AddInParameter(command,"WardId",DbType.Int32,"WardId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"RoomColor",DbType.String,"RoomColor",DataRowVersion.Current);
		    		Database.AddInParameter(command,"RoomNumber",DbType.Int32,"RoomNumber",DataRowVersion.Current);
		    		Database.AddInParameter(command,"BedsNumber",DbType.Int32,"BedsNumber",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Capacity",DbType.Int32,"Capacity",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsPrivate",DbType.Boolean,"IsPrivate",DataRowVersion.Current);
		    		Database.AddInParameter(command,"RoomPhone",DbType.String,"RoomPhone",DataRowVersion.Current);
		    		Database.AddInParameter(command,"WardRoomTypeId",DbType.Int32,"WardRoomTypeId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsClosed",DbType.Boolean,"IsClosed",DataRowVersion.Current);
				Database.AddInParameter(command,"oldWardRoomId",DbType.Int32,"WardRoomId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From WardRoom using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteWardRoom( int wardRoomId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteWardRoom");
			Database.AddInParameter(command,"WardRoomId",DbType.Int32,wardRoomId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From WardRoom Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteWardRoomCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteWardRoom");
				Database.AddInParameter(command,"WardRoomId",DbType.Int32,"WardRoomId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table WardRoom using Stored Procedure
		/// and return number of rows effected of the WardRoom
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"WardRoom",InsertNewWardRoomCommand(),UpdateWardRoomCommand(),DeleteWardRoomCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table WardRoom using Stored Procedure
		/// and return number of rows effected of the WardRoom
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"WardRoom",InsertNewWardRoomCommand(),UpdateWardRoomCommand(),DeleteWardRoomCommand(), transaction);
          return rowsAffected;
		}


	}
}
