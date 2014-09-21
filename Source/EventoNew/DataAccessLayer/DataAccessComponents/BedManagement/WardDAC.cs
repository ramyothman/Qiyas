using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.BedManagement
{
	/// <summary>
	/// This is a Data Access Class  for Ward table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the Ward table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class WardDAC : DataAccessComponent
	{
		#region Constructors
		public WardDAC(){}
		public WardDAC(string connectionString): base(connectionString){}
		public WardDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Ward using Stored Procedure
		/// and return a DataTable containing all Ward Data
		/// </summary>
		public DataTable GetAllWard()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Ward";
         string query = " select * from GetAllWard";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["Ward"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Ward using Stored Procedure
		/// and return a DataTable containing all Ward Data using a Transaction
		/// </summary>
		public DataTable GetAllWard(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Ward";
         string query = " select * from GetAllWard";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["Ward"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Ward using Stored Procedure
		/// and return a DataTable containing all Ward Data
		/// </summary>
		public DataTable GetAllWard(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Ward";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllWard" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["Ward"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Ward using Stored Procedure
		/// and return a DataTable containing all Ward Data using a Transaction
		/// </summary>
		public DataTable GetAllWard(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Ward";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllWard" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["Ward"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From Ward using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDWard( int wardId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDWard");
				    Database.AddInParameter(command,"WardId",DbType.Int32,wardId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From Ward using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDWard( int wardId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDWard");
				    Database.AddInParameter(command,"WardId",DbType.Int32,wardId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into Ward using Stored Procedure
		/// and return the auto number primary key of Ward inserted row
		/// </summary>
		public bool InsertNewWard( ref int wardId,  string wardCode,  string wardDescription,  int bedsNumber,  int wardCapacity,  int roomsNumber,  string wardType,  string wardPhone,  string wardColor,  int wardOrder)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWard");
				Database.AddOutParameter(command,"WardId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardCode",DbType.String,wardCode);
				Database.AddInParameter(command,"WardDescription",DbType.String,wardDescription);
				Database.AddInParameter(command,"BedsNumber",DbType.Int32,bedsNumber);
				Database.AddInParameter(command,"WardCapacity",DbType.Int32,wardCapacity);
				Database.AddInParameter(command,"RoomsNumber",DbType.Int32,roomsNumber);
				Database.AddInParameter(command,"WardType",DbType.String,wardType);
				Database.AddInParameter(command,"WardPhone",DbType.String,wardPhone);
				Database.AddInParameter(command,"WardColor",DbType.String,wardColor);
				Database.AddInParameter(command,"WardOrder",DbType.Int32,wardOrder);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 wardId = Convert.ToInt32(Database.GetParameterValue(command, "WardId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into Ward using Stored Procedure
		/// and return the auto number primary key of Ward inserted row using Transaction
		/// </summary>
		public bool InsertNewWard( ref int wardId,  string wardCode,  string wardDescription,  int bedsNumber,  int wardCapacity,  int roomsNumber,  string wardType,  string wardPhone,  string wardColor,  int wardOrder,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWard");
				Database.AddOutParameter(command,"WardId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardCode",DbType.String,wardCode);
				Database.AddInParameter(command,"WardDescription",DbType.String,wardDescription);
				Database.AddInParameter(command,"BedsNumber",DbType.Int32,bedsNumber);
				Database.AddInParameter(command,"WardCapacity",DbType.Int32,wardCapacity);
				Database.AddInParameter(command,"RoomsNumber",DbType.Int32,roomsNumber);
				Database.AddInParameter(command,"WardType",DbType.String,wardType);
				Database.AddInParameter(command,"WardPhone",DbType.String,wardPhone);
				Database.AddInParameter(command,"WardColor",DbType.String,wardColor);
				Database.AddInParameter(command,"WardOrder",DbType.Int32,wardOrder);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 wardId = Convert.ToInt32(Database.GetParameterValue(command, "WardId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for Ward using Stored Procedure
		/// and return DbCommand of the Ward
		/// </summary>
		public DbCommand InsertNewWardCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWard");

				Database.AddInParameter(command,"WardCode",DbType.String,"WardCode",DataRowVersion.Current);
				Database.AddInParameter(command,"WardDescription",DbType.String,"WardDescription",DataRowVersion.Current);
				Database.AddInParameter(command,"BedsNumber",DbType.Int32,"BedsNumber",DataRowVersion.Current);
				Database.AddInParameter(command,"WardCapacity",DbType.Int32,"WardCapacity",DataRowVersion.Current);
				Database.AddInParameter(command,"RoomsNumber",DbType.Int32,"RoomsNumber",DataRowVersion.Current);
				Database.AddInParameter(command,"WardType",DbType.String,"WardType",DataRowVersion.Current);
				Database.AddInParameter(command,"WardPhone",DbType.String,"WardPhone",DataRowVersion.Current);
				Database.AddInParameter(command,"WardColor",DbType.String,"WardColor",DataRowVersion.Current);
				Database.AddInParameter(command,"WardOrder",DbType.Int32,"WardOrder",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into Ward using Stored Procedure
		/// </summary>
		public bool UpdateWard( string wardCode, string wardDescription, int bedsNumber, int wardCapacity, int roomsNumber, string wardType, string wardPhone, string wardColor, int wardOrder, int oldwardId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWard");

		    		Database.AddInParameter(command,"WardCode",DbType.String,wardCode);
		    		Database.AddInParameter(command,"WardDescription",DbType.String,wardDescription);
		    		Database.AddInParameter(command,"BedsNumber",DbType.Int32,bedsNumber);
		    		Database.AddInParameter(command,"WardCapacity",DbType.Int32,wardCapacity);
		    		Database.AddInParameter(command,"RoomsNumber",DbType.Int32,roomsNumber);
		    		Database.AddInParameter(command,"WardType",DbType.String,wardType);
		    		Database.AddInParameter(command,"WardPhone",DbType.String,wardPhone);
		    		Database.AddInParameter(command,"WardColor",DbType.String,wardColor);
		    		Database.AddInParameter(command,"WardOrder",DbType.Int32,wardOrder);
				Database.AddInParameter(command,"oldWardId",DbType.Int32,oldwardId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into Ward using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateWard( string wardCode, string wardDescription, int bedsNumber, int wardCapacity, int roomsNumber, string wardType, string wardPhone, string wardColor, int wardOrder, int oldwardId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWard");

		    		Database.AddInParameter(command,"WardCode",DbType.String,wardCode);
		    		Database.AddInParameter(command,"WardDescription",DbType.String,wardDescription);
		    		Database.AddInParameter(command,"BedsNumber",DbType.Int32,bedsNumber);
		    		Database.AddInParameter(command,"WardCapacity",DbType.Int32,wardCapacity);
		    		Database.AddInParameter(command,"RoomsNumber",DbType.Int32,roomsNumber);
		    		Database.AddInParameter(command,"WardType",DbType.String,wardType);
		    		Database.AddInParameter(command,"WardPhone",DbType.String,wardPhone);
		    		Database.AddInParameter(command,"WardColor",DbType.String,wardColor);
		    		Database.AddInParameter(command,"WardOrder",DbType.Int32,wardOrder);
				Database.AddInParameter(command,"oldWardId",DbType.Int32,oldwardId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from Ward using Stored Procedure
		/// </summary>
		public DbCommand UpdateWardCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWard");

		    		Database.AddInParameter(command,"WardCode",DbType.String,"WardCode",DataRowVersion.Current);
		    		Database.AddInParameter(command,"WardDescription",DbType.String,"WardDescription",DataRowVersion.Current);
		    		Database.AddInParameter(command,"BedsNumber",DbType.Int32,"BedsNumber",DataRowVersion.Current);
		    		Database.AddInParameter(command,"WardCapacity",DbType.Int32,"WardCapacity",DataRowVersion.Current);
		    		Database.AddInParameter(command,"RoomsNumber",DbType.Int32,"RoomsNumber",DataRowVersion.Current);
		    		Database.AddInParameter(command,"WardType",DbType.String,"WardType",DataRowVersion.Current);
		    		Database.AddInParameter(command,"WardPhone",DbType.String,"WardPhone",DataRowVersion.Current);
		    		Database.AddInParameter(command,"WardColor",DbType.String,"WardColor",DataRowVersion.Current);
		    		Database.AddInParameter(command,"WardOrder",DbType.Int32,"WardOrder",DataRowVersion.Current);
				Database.AddInParameter(command,"oldWardId",DbType.Int32,"WardId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From Ward using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteWard( int wardId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteWard");
			Database.AddInParameter(command,"WardId",DbType.Int32,wardId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From Ward Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteWardCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteWard");
				Database.AddInParameter(command,"WardId",DbType.Int32,"WardId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table Ward using Stored Procedure
		/// and return number of rows effected of the Ward
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"Ward",InsertNewWardCommand(),UpdateWardCommand(),DeleteWardCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table Ward using Stored Procedure
		/// and return number of rows effected of the Ward
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"Ward",InsertNewWardCommand(),UpdateWardCommand(),DeleteWardCommand(), transaction);
          return rowsAffected;
		}


	}
}
