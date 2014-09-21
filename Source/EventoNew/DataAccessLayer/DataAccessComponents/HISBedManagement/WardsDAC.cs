using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.HISBedManagement
{
	/// <summary>
	/// This is a Data Access Class  for Wards table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the Wards table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class WardsDAC : DataAccessComponent
	{
		#region Constructors
		public WardsDAC(){}
		public WardsDAC(string connectionString): base(connectionString){}
		public WardsDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Wards using Stored Procedure
		/// and return a DataTable containing all Wards Data
		/// </summary>
		public DataTable GetAllWards()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Wards";
         string query = " select * from GetAllWards";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["Wards"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Wards using Stored Procedure
		/// and return a DataTable containing all Wards Data using a Transaction
		/// </summary>
		public DataTable GetAllWards(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Wards";
         string query = " select * from GetAllWards";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["Wards"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Wards using Stored Procedure
		/// and return a DataTable containing all Wards Data
		/// </summary>
		public DataTable GetAllWards(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Wards";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllWards" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["Wards"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Wards using Stored Procedure
		/// and return a DataTable containing all Wards Data using a Transaction
		/// </summary>
		public DataTable GetAllWards(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Wards";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllWards" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["Wards"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From Wards using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDWards( int wardId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDWards");
				    Database.AddInParameter(command,"WardId",DbType.Int32,wardId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From Wards using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDWards( int wardId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDWards");
				    Database.AddInParameter(command,"WardId",DbType.Int32,wardId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into Wards using Stored Procedure
		/// and return the auto number primary key of Wards inserted row
		/// </summary>
		public bool InsertNewWards( ref int wardId,  string wardCode,  string wardDescription,  int wardTypeId,  int wardForId,  int bedsNumber,  int wardCapacity,  int roomsNumber,  string wardPhone,  string wardColor,  int wardOrder)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWards");
				Database.AddOutParameter(command,"WardId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardCode",DbType.String,wardCode);
				Database.AddInParameter(command,"WardDescription",DbType.String,wardDescription);
				Database.AddInParameter(command,"WardTypeId",DbType.Int32,wardTypeId);
				Database.AddInParameter(command,"WardForId",DbType.Int32,wardForId);
				Database.AddInParameter(command,"BedsNumber",DbType.Int32,bedsNumber);
				Database.AddInParameter(command,"WardCapacity",DbType.Int32,wardCapacity);
				Database.AddInParameter(command,"RoomsNumber",DbType.Int32,roomsNumber);
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
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into Wards using Stored Procedure
		/// and return the auto number primary key of Wards inserted row using Transaction
		/// </summary>
		public bool InsertNewWards( ref int wardId,  string wardCode,  string wardDescription,  int wardTypeId,  int wardForId,  int bedsNumber,  int wardCapacity,  int roomsNumber,  string wardPhone,  string wardColor,  int wardOrder,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWards");
				Database.AddOutParameter(command,"WardId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardCode",DbType.String,wardCode);
				Database.AddInParameter(command,"WardDescription",DbType.String,wardDescription);
				Database.AddInParameter(command,"WardTypeId",DbType.Int32,wardTypeId);
				Database.AddInParameter(command,"WardForId",DbType.Int32,wardForId);
				Database.AddInParameter(command,"BedsNumber",DbType.Int32,bedsNumber);
				Database.AddInParameter(command,"WardCapacity",DbType.Int32,wardCapacity);
				Database.AddInParameter(command,"RoomsNumber",DbType.Int32,roomsNumber);
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
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for Wards using Stored Procedure
		/// and return DbCommand of the Wards
		/// </summary>
		public DbCommand InsertNewWardsCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWards");

				Database.AddInParameter(command,"WardCode",DbType.String,"WardCode",DataRowVersion.Current);
				Database.AddInParameter(command,"WardDescription",DbType.String,"WardDescription",DataRowVersion.Current);
				Database.AddInParameter(command,"WardTypeId",DbType.Int32,"WardTypeId",DataRowVersion.Current);
				Database.AddInParameter(command,"WardForId",DbType.Int32,"WardForId",DataRowVersion.Current);
				Database.AddInParameter(command,"BedsNumber",DbType.Int32,"BedsNumber",DataRowVersion.Current);
				Database.AddInParameter(command,"WardCapacity",DbType.Int32,"WardCapacity",DataRowVersion.Current);
				Database.AddInParameter(command,"RoomsNumber",DbType.Int32,"RoomsNumber",DataRowVersion.Current);
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
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into Wards using Stored Procedure
		/// </summary>
		public bool UpdateWards( string wardCode, string wardDescription, int wardTypeId, int wardForId, int bedsNumber, int wardCapacity, int roomsNumber, string wardPhone, string wardColor, int wardOrder, int oldwardId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWards");

		    		Database.AddInParameter(command,"WardCode",DbType.String,wardCode);
		    		Database.AddInParameter(command,"WardDescription",DbType.String,wardDescription);
		    		Database.AddInParameter(command,"WardTypeId",DbType.Int32,wardTypeId);
		    		Database.AddInParameter(command,"WardForId",DbType.Int32,wardForId);
		    		Database.AddInParameter(command,"BedsNumber",DbType.Int32,bedsNumber);
		    		Database.AddInParameter(command,"WardCapacity",DbType.Int32,wardCapacity);
		    		Database.AddInParameter(command,"RoomsNumber",DbType.Int32,roomsNumber);
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
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into Wards using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateWards( string wardCode, string wardDescription, int wardTypeId, int wardForId, int bedsNumber, int wardCapacity, int roomsNumber, string wardPhone, string wardColor, int wardOrder, int oldwardId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWards");

		    		Database.AddInParameter(command,"WardCode",DbType.String,wardCode);
		    		Database.AddInParameter(command,"WardDescription",DbType.String,wardDescription);
		    		Database.AddInParameter(command,"WardTypeId",DbType.Int32,wardTypeId);
		    		Database.AddInParameter(command,"WardForId",DbType.Int32,wardForId);
		    		Database.AddInParameter(command,"BedsNumber",DbType.Int32,bedsNumber);
		    		Database.AddInParameter(command,"WardCapacity",DbType.Int32,wardCapacity);
		    		Database.AddInParameter(command,"RoomsNumber",DbType.Int32,roomsNumber);
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
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from Wards using Stored Procedure
		/// </summary>
		public DbCommand UpdateWardsCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWards");

		    		Database.AddInParameter(command,"WardCode",DbType.String,"WardCode",DataRowVersion.Current);
		    		Database.AddInParameter(command,"WardDescription",DbType.String,"WardDescription",DataRowVersion.Current);
		    		Database.AddInParameter(command,"WardTypeId",DbType.Int32,"WardTypeId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"WardForId",DbType.Int32,"WardForId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"BedsNumber",DbType.Int32,"BedsNumber",DataRowVersion.Current);
		    		Database.AddInParameter(command,"WardCapacity",DbType.Int32,"WardCapacity",DataRowVersion.Current);
		    		Database.AddInParameter(command,"RoomsNumber",DbType.Int32,"RoomsNumber",DataRowVersion.Current);
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
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From Wards using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteWards( int wardId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteWards");
			Database.AddInParameter(command,"WardId",DbType.Int32,wardId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From Wards Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteWardsCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteWards");
				Database.AddInParameter(command,"WardId",DbType.Int32,"WardId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table Wards using Stored Procedure
		/// and return number of rows effected of the Wards
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"Wards",InsertNewWardsCommand(),UpdateWardsCommand(),DeleteWardsCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table Wards using Stored Procedure
		/// and return number of rows effected of the Wards
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"Wards",InsertNewWardsCommand(),UpdateWardsCommand(),DeleteWardsCommand(), transaction);
          return rowsAffected;
		}


	}
}
