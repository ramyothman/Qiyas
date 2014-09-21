using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.HISBedManagement
{
	/// <summary>
	/// This is a Data Access Class  for WardRoomSpeciality table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the WardRoomSpeciality table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class WardRoomSpecialityDAC : DataAccessComponent
	{
		#region Constructors
		public WardRoomSpecialityDAC(){}
		public WardRoomSpecialityDAC(string connectionString): base(connectionString){}
		public WardRoomSpecialityDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardRoomSpeciality using Stored Procedure
		/// and return a DataTable containing all WardRoomSpeciality Data
		/// </summary>
		public DataTable GetAllWardRoomSpeciality()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardRoomSpeciality";
         string query = " select * from GetAllWardRoomSpeciality";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["WardRoomSpeciality"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardRoomSpeciality using Stored Procedure
		/// and return a DataTable containing all WardRoomSpeciality Data using a Transaction
		/// </summary>
		public DataTable GetAllWardRoomSpeciality(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardRoomSpeciality";
         string query = " select * from GetAllWardRoomSpeciality";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["WardRoomSpeciality"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardRoomSpeciality using Stored Procedure
		/// and return a DataTable containing all WardRoomSpeciality Data
		/// </summary>
		public DataTable GetAllWardRoomSpeciality(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardRoomSpeciality";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllWardRoomSpeciality" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["WardRoomSpeciality"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardRoomSpeciality using Stored Procedure
		/// and return a DataTable containing all WardRoomSpeciality Data using a Transaction
		/// </summary>
		public DataTable GetAllWardRoomSpeciality(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardRoomSpeciality";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllWardRoomSpeciality" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["WardRoomSpeciality"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From WardRoomSpeciality using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDWardRoomSpeciality( int roomSpecialityId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDWardRoomSpeciality");
				    Database.AddInParameter(command,"RoomSpecialityId",DbType.Int32,roomSpecialityId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From WardRoomSpeciality using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDWardRoomSpeciality( int roomSpecialityId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDWardRoomSpeciality");
				    Database.AddInParameter(command,"RoomSpecialityId",DbType.Int32,roomSpecialityId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into WardRoomSpeciality using Stored Procedure
		/// and return the auto number primary key of WardRoomSpeciality inserted row
		/// </summary>
		public bool InsertNewWardRoomSpeciality( ref int roomSpecialityId,  int wardRoomId,  int specialityId,  bool isMainSpeciality,  int specialityOrder)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardRoomSpeciality");
				Database.AddOutParameter(command,"RoomSpecialityId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardRoomId",DbType.Int32,wardRoomId);
				Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
				Database.AddInParameter(command,"IsMainSpeciality",DbType.Boolean,isMainSpeciality);
				Database.AddInParameter(command,"SpecialityOrder",DbType.Int32,specialityOrder);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 roomSpecialityId = Convert.ToInt32(Database.GetParameterValue(command, "RoomSpecialityId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into WardRoomSpeciality using Stored Procedure
		/// and return the auto number primary key of WardRoomSpeciality inserted row using Transaction
		/// </summary>
		public bool InsertNewWardRoomSpeciality( ref int roomSpecialityId,  int wardRoomId,  int specialityId,  bool isMainSpeciality,  int specialityOrder,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardRoomSpeciality");
				Database.AddOutParameter(command,"RoomSpecialityId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardRoomId",DbType.Int32,wardRoomId);
				Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
				Database.AddInParameter(command,"IsMainSpeciality",DbType.Boolean,isMainSpeciality);
				Database.AddInParameter(command,"SpecialityOrder",DbType.Int32,specialityOrder);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 roomSpecialityId = Convert.ToInt32(Database.GetParameterValue(command, "RoomSpecialityId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for WardRoomSpeciality using Stored Procedure
		/// and return DbCommand of the WardRoomSpeciality
		/// </summary>
		public DbCommand InsertNewWardRoomSpecialityCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardRoomSpeciality");

				Database.AddInParameter(command,"WardRoomId",DbType.Int32,"WardRoomId",DataRowVersion.Current);
				Database.AddInParameter(command,"SpecialityId",DbType.Int32,"SpecialityId",DataRowVersion.Current);
				Database.AddInParameter(command,"IsMainSpeciality",DbType.Boolean,"IsMainSpeciality",DataRowVersion.Current);
				Database.AddInParameter(command,"SpecialityOrder",DbType.Int32,"SpecialityOrder",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into WardRoomSpeciality using Stored Procedure
		/// </summary>
		public bool UpdateWardRoomSpeciality( int wardRoomId, int specialityId, bool isMainSpeciality, int specialityOrder, int oldroomSpecialityId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardRoomSpeciality");

		    		Database.AddInParameter(command,"WardRoomId",DbType.Int32,wardRoomId);
		    		Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
		    		Database.AddInParameter(command,"IsMainSpeciality",DbType.Boolean,isMainSpeciality);
		    		Database.AddInParameter(command,"SpecialityOrder",DbType.Int32,specialityOrder);
				Database.AddInParameter(command,"oldRoomSpecialityId",DbType.Int32,oldroomSpecialityId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into WardRoomSpeciality using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateWardRoomSpeciality( int wardRoomId, int specialityId, bool isMainSpeciality, int specialityOrder, int oldroomSpecialityId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardRoomSpeciality");

		    		Database.AddInParameter(command,"WardRoomId",DbType.Int32,wardRoomId);
		    		Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
		    		Database.AddInParameter(command,"IsMainSpeciality",DbType.Boolean,isMainSpeciality);
		    		Database.AddInParameter(command,"SpecialityOrder",DbType.Int32,specialityOrder);
				Database.AddInParameter(command,"oldRoomSpecialityId",DbType.Int32,oldroomSpecialityId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from WardRoomSpeciality using Stored Procedure
		/// </summary>
		public DbCommand UpdateWardRoomSpecialityCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardRoomSpeciality");

		    		Database.AddInParameter(command,"WardRoomId",DbType.Int32,"WardRoomId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"SpecialityId",DbType.Int32,"SpecialityId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsMainSpeciality",DbType.Boolean,"IsMainSpeciality",DataRowVersion.Current);
		    		Database.AddInParameter(command,"SpecialityOrder",DbType.Int32,"SpecialityOrder",DataRowVersion.Current);
				Database.AddInParameter(command,"oldRoomSpecialityId",DbType.Int32,"RoomSpecialityId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From WardRoomSpeciality using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteWardRoomSpeciality( int roomSpecialityId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteWardRoomSpeciality");
			Database.AddInParameter(command,"RoomSpecialityId",DbType.Int32,roomSpecialityId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From WardRoomSpeciality Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteWardRoomSpecialityCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteWardRoomSpeciality");
				Database.AddInParameter(command,"RoomSpecialityId",DbType.Int32,"RoomSpecialityId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table WardRoomSpeciality using Stored Procedure
		/// and return number of rows effected of the WardRoomSpeciality
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"WardRoomSpeciality",InsertNewWardRoomSpecialityCommand(),UpdateWardRoomSpecialityCommand(),DeleteWardRoomSpecialityCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table WardRoomSpeciality using Stored Procedure
		/// and return number of rows effected of the WardRoomSpeciality
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"WardRoomSpeciality",InsertNewWardRoomSpecialityCommand(),UpdateWardRoomSpecialityCommand(),DeleteWardRoomSpecialityCommand(), transaction);
          return rowsAffected;
		}


	}
}
