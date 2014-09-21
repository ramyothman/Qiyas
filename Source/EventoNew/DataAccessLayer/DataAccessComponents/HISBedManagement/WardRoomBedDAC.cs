using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.HISBedManagement
{
	/// <summary>
	/// This is a Data Access Class  for WardRoomBed table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the WardRoomBed table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class WardRoomBedDAC : DataAccessComponent
	{
		#region Constructors
		public WardRoomBedDAC(){}
		public WardRoomBedDAC(string connectionString): base(connectionString){}
		public WardRoomBedDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardRoomBed using Stored Procedure
		/// and return a DataTable containing all WardRoomBed Data
		/// </summary>
		public DataTable GetAllWardRoomBed()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardRoomBed";
         string query = " select * from GetAllWardRoomBed";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["WardRoomBed"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardRoomBed using Stored Procedure
		/// and return a DataTable containing all WardRoomBed Data using a Transaction
		/// </summary>
		public DataTable GetAllWardRoomBed(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardRoomBed";
         string query = " select * from GetAllWardRoomBed";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["WardRoomBed"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardRoomBed using Stored Procedure
		/// and return a DataTable containing all WardRoomBed Data
		/// </summary>
		public DataTable GetAllWardRoomBed(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardRoomBed";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllWardRoomBed" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["WardRoomBed"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardRoomBed using Stored Procedure
		/// and return a DataTable containing all WardRoomBed Data using a Transaction
		/// </summary>
		public DataTable GetAllWardRoomBed(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardRoomBed";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllWardRoomBed" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["WardRoomBed"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From WardRoomBed using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDWardRoomBed( int wardRoomBedId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDWardRoomBed");
				    Database.AddInParameter(command,"WardRoomBedId",DbType.Int32,wardRoomBedId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From WardRoomBed using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDWardRoomBed( int wardRoomBedId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDWardRoomBed");
				    Database.AddInParameter(command,"WardRoomBedId",DbType.Int32,wardRoomBedId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into WardRoomBed using Stored Procedure
		/// and return the auto number primary key of WardRoomBed inserted row
		/// </summary>
		public bool InsertNewWardRoomBed( ref int wardRoomBedId,  int wardRoomId,  int bedStatusId,  int bedTypeId,  string bedCode)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardRoomBed");
				Database.AddOutParameter(command,"WardRoomBedId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardRoomId",DbType.Int32,wardRoomId);
				Database.AddInParameter(command,"BedStatusId",DbType.Int32,bedStatusId);
				Database.AddInParameter(command,"BedTypeId",DbType.Int32,bedTypeId);
				Database.AddInParameter(command,"BedCode",DbType.String,bedCode);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 wardRoomBedId = Convert.ToInt32(Database.GetParameterValue(command, "WardRoomBedId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into WardRoomBed using Stored Procedure
		/// and return the auto number primary key of WardRoomBed inserted row using Transaction
		/// </summary>
		public bool InsertNewWardRoomBed( ref int wardRoomBedId,  int wardRoomId,  int bedStatusId,  int bedTypeId,  string bedCode,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardRoomBed");
				Database.AddOutParameter(command,"WardRoomBedId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardRoomId",DbType.Int32,wardRoomId);
				Database.AddInParameter(command,"BedStatusId",DbType.Int32,bedStatusId);
				Database.AddInParameter(command,"BedTypeId",DbType.Int32,bedTypeId);
				Database.AddInParameter(command,"BedCode",DbType.String,bedCode);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 wardRoomBedId = Convert.ToInt32(Database.GetParameterValue(command, "WardRoomBedId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for WardRoomBed using Stored Procedure
		/// and return DbCommand of the WardRoomBed
		/// </summary>
		public DbCommand InsertNewWardRoomBedCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardRoomBed");

				Database.AddInParameter(command,"WardRoomId",DbType.Int32,"WardRoomId",DataRowVersion.Current);
				Database.AddInParameter(command,"BedStatusId",DbType.Int32,"BedStatusId",DataRowVersion.Current);
				Database.AddInParameter(command,"BedTypeId",DbType.Int32,"BedTypeId",DataRowVersion.Current);
				Database.AddInParameter(command,"BedCode",DbType.String,"BedCode",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into WardRoomBed using Stored Procedure
		/// </summary>
		public bool UpdateWardRoomBed( int wardRoomId, int bedStatusId, int bedTypeId, string bedCode, int oldwardRoomBedId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardRoomBed");

		    		Database.AddInParameter(command,"WardRoomId",DbType.Int32,wardRoomId);
		    		Database.AddInParameter(command,"BedStatusId",DbType.Int32,bedStatusId);
		    		Database.AddInParameter(command,"BedTypeId",DbType.Int32,bedTypeId);
		    		Database.AddInParameter(command,"BedCode",DbType.String,bedCode);
				Database.AddInParameter(command,"oldWardRoomBedId",DbType.Int32,oldwardRoomBedId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into WardRoomBed using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateWardRoomBed( int wardRoomId, int bedStatusId, int bedTypeId, string bedCode, int oldwardRoomBedId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardRoomBed");

		    		Database.AddInParameter(command,"WardRoomId",DbType.Int32,wardRoomId);
		    		Database.AddInParameter(command,"BedStatusId",DbType.Int32,bedStatusId);
		    		Database.AddInParameter(command,"BedTypeId",DbType.Int32,bedTypeId);
		    		Database.AddInParameter(command,"BedCode",DbType.String,bedCode);
				Database.AddInParameter(command,"oldWardRoomBedId",DbType.Int32,oldwardRoomBedId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from WardRoomBed using Stored Procedure
		/// </summary>
		public DbCommand UpdateWardRoomBedCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardRoomBed");

		    		Database.AddInParameter(command,"WardRoomId",DbType.Int32,"WardRoomId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"BedStatusId",DbType.Int32,"BedStatusId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"BedTypeId",DbType.Int32,"BedTypeId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"BedCode",DbType.String,"BedCode",DataRowVersion.Current);
				Database.AddInParameter(command,"oldWardRoomBedId",DbType.Int32,"WardRoomBedId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From WardRoomBed using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteWardRoomBed( int wardRoomBedId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteWardRoomBed");
			Database.AddInParameter(command,"WardRoomBedId",DbType.Int32,wardRoomBedId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From WardRoomBed Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteWardRoomBedCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteWardRoomBed");
				Database.AddInParameter(command,"WardRoomBedId",DbType.Int32,"WardRoomBedId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table WardRoomBed using Stored Procedure
		/// and return number of rows effected of the WardRoomBed
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"WardRoomBed",InsertNewWardRoomBedCommand(),UpdateWardRoomBedCommand(),DeleteWardRoomBedCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table WardRoomBed using Stored Procedure
		/// and return number of rows effected of the WardRoomBed
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"WardRoomBed",InsertNewWardRoomBedCommand(),UpdateWardRoomBedCommand(),DeleteWardRoomBedCommand(), transaction);
          return rowsAffected;
		}


	}
}
