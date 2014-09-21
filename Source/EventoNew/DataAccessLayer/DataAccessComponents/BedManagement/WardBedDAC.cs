using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.BedManagement
{
	/// <summary>
	/// This is a Data Access Class  for WardBed table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the WardBed table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class WardBedDAC : DataAccessComponent
	{
		#region Constructors
		public WardBedDAC(){}
		public WardBedDAC(string connectionString): base(connectionString){}
		public WardBedDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardBed using Stored Procedure
		/// and return a DataTable containing all WardBed Data
		/// </summary>
		public DataTable GetAllWardBed()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardBed";
         string query = " select * from GetAllWardBed";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["WardBed"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardBed using Stored Procedure
		/// and return a DataTable containing all WardBed Data using a Transaction
		/// </summary>
		public DataTable GetAllWardBed(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardBed";
         string query = " select * from GetAllWardBed";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["WardBed"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardBed using Stored Procedure
		/// and return a DataTable containing all WardBed Data
		/// </summary>
		public DataTable GetAllWardBed(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardBed";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllWardBed" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["WardBed"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardBed using Stored Procedure
		/// and return a DataTable containing all WardBed Data using a Transaction
		/// </summary>
		public DataTable GetAllWardBed(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardBed";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllWardBed" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["WardBed"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From WardBed using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDWardBed( int wardBedId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDWardBed");
				    Database.AddInParameter(command,"WardBedId",DbType.Int32,wardBedId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From WardBed using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDWardBed( int wardBedId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDWardBed");
				    Database.AddInParameter(command,"WardBedId",DbType.Int32,wardBedId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into WardBed using Stored Procedure
		/// and return the auto number primary key of WardBed inserted row
		/// </summary>
		public bool InsertNewWardBed( ref int wardBedId,  int wardRoomId,  int bedNumber,  string bedCode,  string bedStatus,  string bedType,  int bedStatusPercentage,  string currentPatientCode,  int specialityId)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardBed");
				Database.AddOutParameter(command,"WardBedId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardRoomId",DbType.Int32,wardRoomId);
				Database.AddInParameter(command,"BedNumber",DbType.Int32,bedNumber);
				Database.AddInParameter(command,"BedCode",DbType.String,bedCode);
				Database.AddInParameter(command,"BedStatus",DbType.String,bedStatus);
				Database.AddInParameter(command,"BedType",DbType.String,bedType);
				Database.AddInParameter(command,"BedStatusPercentage",DbType.Int32,bedStatusPercentage);
				Database.AddInParameter(command,"CurrentPatientCode",DbType.String,currentPatientCode);
				Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 wardBedId = Convert.ToInt32(Database.GetParameterValue(command, "WardBedId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into WardBed using Stored Procedure
		/// and return the auto number primary key of WardBed inserted row using Transaction
		/// </summary>
		public bool InsertNewWardBed( ref int wardBedId,  int wardRoomId,  int bedNumber,  string bedCode,  string bedStatus,  string bedType,  int bedStatusPercentage,  string currentPatientCode,  int specialityId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardBed");
				Database.AddOutParameter(command,"WardBedId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardRoomId",DbType.Int32,wardRoomId);
				Database.AddInParameter(command,"BedNumber",DbType.Int32,bedNumber);
				Database.AddInParameter(command,"BedCode",DbType.String,bedCode);
				Database.AddInParameter(command,"BedStatus",DbType.String,bedStatus);
				Database.AddInParameter(command,"BedType",DbType.String,bedType);
				Database.AddInParameter(command,"BedStatusPercentage",DbType.Int32,bedStatusPercentage);
				Database.AddInParameter(command,"CurrentPatientCode",DbType.String,currentPatientCode);
				Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 wardBedId = Convert.ToInt32(Database.GetParameterValue(command, "WardBedId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for WardBed using Stored Procedure
		/// and return DbCommand of the WardBed
		/// </summary>
		public DbCommand InsertNewWardBedCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardBed");

				Database.AddInParameter(command,"WardRoomId",DbType.Int32,"WardRoomId",DataRowVersion.Current);
				Database.AddInParameter(command,"BedNumber",DbType.Int32,"BedNumber",DataRowVersion.Current);
				Database.AddInParameter(command,"BedCode",DbType.String,"BedCode",DataRowVersion.Current);
				Database.AddInParameter(command,"BedStatus",DbType.String,"BedStatus",DataRowVersion.Current);
				Database.AddInParameter(command,"BedType",DbType.String,"BedType",DataRowVersion.Current);
				Database.AddInParameter(command,"BedStatusPercentage",DbType.Int32,"BedStatusPercentage",DataRowVersion.Current);
				Database.AddInParameter(command,"CurrentPatientCode",DbType.String,"CurrentPatientCode",DataRowVersion.Current);
				Database.AddInParameter(command,"SpecialityId",DbType.Int32,"SpecialityId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into WardBed using Stored Procedure
		/// </summary>
		public bool UpdateWardBed( int wardRoomId, int bedNumber, string bedCode, string bedStatus, string bedType, int bedStatusPercentage, string currentPatientCode, int specialityId, int oldwardBedId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardBed");

		    		Database.AddInParameter(command,"WardRoomId",DbType.Int32,wardRoomId);
		    		Database.AddInParameter(command,"BedNumber",DbType.Int32,bedNumber);
		    		Database.AddInParameter(command,"BedCode",DbType.String,bedCode);
		    		Database.AddInParameter(command,"BedStatus",DbType.String,bedStatus);
		    		Database.AddInParameter(command,"BedType",DbType.String,bedType);
		    		Database.AddInParameter(command,"BedStatusPercentage",DbType.Int32,bedStatusPercentage);
		    		Database.AddInParameter(command,"CurrentPatientCode",DbType.String,currentPatientCode);
		    		Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
				Database.AddInParameter(command,"oldWardBedId",DbType.Int32,oldwardBedId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into WardBed using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateWardBed( int wardRoomId, int bedNumber, string bedCode, string bedStatus, string bedType, int bedStatusPercentage, string currentPatientCode, int specialityId, int oldwardBedId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardBed");

		    		Database.AddInParameter(command,"WardRoomId",DbType.Int32,wardRoomId);
		    		Database.AddInParameter(command,"BedNumber",DbType.Int32,bedNumber);
		    		Database.AddInParameter(command,"BedCode",DbType.String,bedCode);
		    		Database.AddInParameter(command,"BedStatus",DbType.String,bedStatus);
		    		Database.AddInParameter(command,"BedType",DbType.String,bedType);
		    		Database.AddInParameter(command,"BedStatusPercentage",DbType.Int32,bedStatusPercentage);
		    		Database.AddInParameter(command,"CurrentPatientCode",DbType.String,currentPatientCode);
		    		Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
				Database.AddInParameter(command,"oldWardBedId",DbType.Int32,oldwardBedId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from WardBed using Stored Procedure
		/// </summary>
		public DbCommand UpdateWardBedCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardBed");

		    		Database.AddInParameter(command,"WardRoomId",DbType.Int32,"WardRoomId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"BedNumber",DbType.Int32,"BedNumber",DataRowVersion.Current);
		    		Database.AddInParameter(command,"BedCode",DbType.String,"BedCode",DataRowVersion.Current);
		    		Database.AddInParameter(command,"BedStatus",DbType.String,"BedStatus",DataRowVersion.Current);
		    		Database.AddInParameter(command,"BedType",DbType.String,"BedType",DataRowVersion.Current);
		    		Database.AddInParameter(command,"BedStatusPercentage",DbType.Int32,"BedStatusPercentage",DataRowVersion.Current);
		    		Database.AddInParameter(command,"CurrentPatientCode",DbType.String,"CurrentPatientCode",DataRowVersion.Current);
		    		Database.AddInParameter(command,"SpecialityId",DbType.Int32,"SpecialityId",DataRowVersion.Current);
				Database.AddInParameter(command,"oldWardBedId",DbType.Int32,"WardBedId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From WardBed using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteWardBed( int wardBedId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteWardBed");
			Database.AddInParameter(command,"WardBedId",DbType.Int32,wardBedId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From WardBed Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteWardBedCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteWardBed");
				Database.AddInParameter(command,"WardBedId",DbType.Int32,"WardBedId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table WardBed using Stored Procedure
		/// and return number of rows effected of the WardBed
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"WardBed",InsertNewWardBedCommand(),UpdateWardBedCommand(),DeleteWardBedCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table WardBed using Stored Procedure
		/// and return number of rows effected of the WardBed
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"WardBed",InsertNewWardBedCommand(),UpdateWardBedCommand(),DeleteWardBedCommand(), transaction);
          return rowsAffected;
		}


	}
}
