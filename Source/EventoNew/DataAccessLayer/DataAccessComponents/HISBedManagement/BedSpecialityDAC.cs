using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.HISBedManagement
{
	/// <summary>
	/// This is a Data Access Class  for BedSpeciality table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the BedSpeciality table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class BedSpecialityDAC : DataAccessComponent
	{
		#region Constructors
		public BedSpecialityDAC(){}
		public BedSpecialityDAC(string connectionString): base(connectionString){}
		public BedSpecialityDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all BedSpeciality using Stored Procedure
		/// and return a DataTable containing all BedSpeciality Data
		/// </summary>
		public DataTable GetAllBedSpeciality()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "BedSpeciality";
         string query = " select * from GetAllBedSpeciality";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["BedSpeciality"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all BedSpeciality using Stored Procedure
		/// and return a DataTable containing all BedSpeciality Data using a Transaction
		/// </summary>
		public DataTable GetAllBedSpeciality(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "BedSpeciality";
         string query = " select * from GetAllBedSpeciality";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["BedSpeciality"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all BedSpeciality using Stored Procedure
		/// and return a DataTable containing all BedSpeciality Data
		/// </summary>
		public DataTable GetAllBedSpeciality(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "BedSpeciality";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllBedSpeciality" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["BedSpeciality"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all BedSpeciality using Stored Procedure
		/// and return a DataTable containing all BedSpeciality Data using a Transaction
		/// </summary>
		public DataTable GetAllBedSpeciality(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "BedSpeciality";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllBedSpeciality" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["BedSpeciality"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From BedSpeciality using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDBedSpeciality( int bedSpecialityId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDBedSpeciality");
				    Database.AddInParameter(command,"BedSpecialityId",DbType.Int32,bedSpecialityId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From BedSpeciality using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDBedSpeciality( int bedSpecialityId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDBedSpeciality");
				    Database.AddInParameter(command,"BedSpecialityId",DbType.Int32,bedSpecialityId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into BedSpeciality using Stored Procedure
		/// and return the auto number primary key of BedSpeciality inserted row
		/// </summary>
		public bool InsertNewBedSpeciality( ref int bedSpecialityId,  int wardRoomBedId,  int specialityId,  bool isMainSpeciality,  int specialityOrder)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewBedSpeciality");
				Database.AddOutParameter(command,"BedSpecialityId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardRoomBedId",DbType.Int32,wardRoomBedId);
				Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
				Database.AddInParameter(command,"IsMainSpeciality",DbType.Boolean,isMainSpeciality);
				Database.AddInParameter(command,"SpecialityOrder",DbType.Int32,specialityOrder);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 bedSpecialityId = Convert.ToInt32(Database.GetParameterValue(command, "BedSpecialityId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into BedSpeciality using Stored Procedure
		/// and return the auto number primary key of BedSpeciality inserted row using Transaction
		/// </summary>
		public bool InsertNewBedSpeciality( ref int bedSpecialityId,  int wardRoomBedId,  int specialityId,  bool isMainSpeciality,  int specialityOrder,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewBedSpeciality");
				Database.AddOutParameter(command,"BedSpecialityId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardRoomBedId",DbType.Int32,wardRoomBedId);
				Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
				Database.AddInParameter(command,"IsMainSpeciality",DbType.Boolean,isMainSpeciality);
				Database.AddInParameter(command,"SpecialityOrder",DbType.Int32,specialityOrder);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 bedSpecialityId = Convert.ToInt32(Database.GetParameterValue(command, "BedSpecialityId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for BedSpeciality using Stored Procedure
		/// and return DbCommand of the BedSpeciality
		/// </summary>
		public DbCommand InsertNewBedSpecialityCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewBedSpeciality");

				Database.AddInParameter(command,"WardRoomBedId",DbType.Int32,"WardRoomBedId",DataRowVersion.Current);
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
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into BedSpeciality using Stored Procedure
		/// </summary>
		public bool UpdateBedSpeciality( int wardRoomBedId, int specialityId, bool isMainSpeciality, int specialityOrder, int oldbedSpecialityId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateBedSpeciality");

		    		Database.AddInParameter(command,"WardRoomBedId",DbType.Int32,wardRoomBedId);
		    		Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
		    		Database.AddInParameter(command,"IsMainSpeciality",DbType.Boolean,isMainSpeciality);
		    		Database.AddInParameter(command,"SpecialityOrder",DbType.Int32,specialityOrder);
				Database.AddInParameter(command,"oldBedSpecialityId",DbType.Int32,oldbedSpecialityId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into BedSpeciality using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateBedSpeciality( int wardRoomBedId, int specialityId, bool isMainSpeciality, int specialityOrder, int oldbedSpecialityId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateBedSpeciality");

		    		Database.AddInParameter(command,"WardRoomBedId",DbType.Int32,wardRoomBedId);
		    		Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
		    		Database.AddInParameter(command,"IsMainSpeciality",DbType.Boolean,isMainSpeciality);
		    		Database.AddInParameter(command,"SpecialityOrder",DbType.Int32,specialityOrder);
				Database.AddInParameter(command,"oldBedSpecialityId",DbType.Int32,oldbedSpecialityId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from BedSpeciality using Stored Procedure
		/// </summary>
		public DbCommand UpdateBedSpecialityCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateBedSpeciality");

		    		Database.AddInParameter(command,"WardRoomBedId",DbType.Int32,"WardRoomBedId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"SpecialityId",DbType.Int32,"SpecialityId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsMainSpeciality",DbType.Boolean,"IsMainSpeciality",DataRowVersion.Current);
		    		Database.AddInParameter(command,"SpecialityOrder",DbType.Int32,"SpecialityOrder",DataRowVersion.Current);
				Database.AddInParameter(command,"oldBedSpecialityId",DbType.Int32,"BedSpecialityId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From BedSpeciality using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteBedSpeciality( int bedSpecialityId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteBedSpeciality");
			Database.AddInParameter(command,"BedSpecialityId",DbType.Int32,bedSpecialityId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From BedSpeciality Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteBedSpecialityCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteBedSpeciality");
				Database.AddInParameter(command,"BedSpecialityId",DbType.Int32,"BedSpecialityId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table BedSpeciality using Stored Procedure
		/// and return number of rows effected of the BedSpeciality
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"BedSpeciality",InsertNewBedSpecialityCommand(),UpdateBedSpecialityCommand(),DeleteBedSpecialityCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table BedSpeciality using Stored Procedure
		/// and return number of rows effected of the BedSpeciality
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"BedSpeciality",InsertNewBedSpecialityCommand(),UpdateBedSpecialityCommand(),DeleteBedSpecialityCommand(), transaction);
          return rowsAffected;
		}


	}
}
