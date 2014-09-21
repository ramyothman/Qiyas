using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.BedManagement
{
	/// <summary>
	/// This is a Data Access Class  for WardSpeciality table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the WardSpeciality table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class WardSpecialityDAC : DataAccessComponent
	{
		#region Constructors
		public WardSpecialityDAC(){}
		public WardSpecialityDAC(string connectionString): base(connectionString){}
		public WardSpecialityDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardSpeciality using Stored Procedure
		/// and return a DataTable containing all WardSpeciality Data
		/// </summary>
		public DataTable GetAllWardSpeciality()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardSpeciality";
         string query = " select * from GetAllWardSpeciality";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["WardSpeciality"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardSpeciality using Stored Procedure
		/// and return a DataTable containing all WardSpeciality Data using a Transaction
		/// </summary>
		public DataTable GetAllWardSpeciality(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardSpeciality";
         string query = " select * from GetAllWardSpeciality";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["WardSpeciality"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardSpeciality using Stored Procedure
		/// and return a DataTable containing all WardSpeciality Data
		/// </summary>
		public DataTable GetAllWardSpeciality(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardSpeciality";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllWardSpeciality" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["WardSpeciality"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all WardSpeciality using Stored Procedure
		/// and return a DataTable containing all WardSpeciality Data using a Transaction
		/// </summary>
		public DataTable GetAllWardSpeciality(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "WardSpeciality";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllWardSpeciality" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["WardSpeciality"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From WardSpeciality using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDWardSpeciality( int wardSpecialityId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDWardSpeciality");
				    Database.AddInParameter(command,"WardSpecialityId",DbType.Int32,wardSpecialityId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From WardSpeciality using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDWardSpeciality( int wardSpecialityId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDWardSpeciality");
				    Database.AddInParameter(command,"WardSpecialityId",DbType.Int32,wardSpecialityId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into WardSpeciality using Stored Procedure
		/// and return the auto number primary key of WardSpeciality inserted row
		/// </summary>
		public bool InsertNewWardSpeciality( ref int wardSpecialityId,  int wardId,  int specialityId,  bool isMain)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardSpeciality");
				Database.AddOutParameter(command,"WardSpecialityId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardId",DbType.Int32,wardId);
				Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
				Database.AddInParameter(command,"IsMain",DbType.Boolean,isMain);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 wardSpecialityId = Convert.ToInt32(Database.GetParameterValue(command, "WardSpecialityId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into WardSpeciality using Stored Procedure
		/// and return the auto number primary key of WardSpeciality inserted row using Transaction
		/// </summary>
		public bool InsertNewWardSpeciality( ref int wardSpecialityId,  int wardId,  int specialityId,  bool isMain,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardSpeciality");
				Database.AddOutParameter(command,"WardSpecialityId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"WardId",DbType.Int32,wardId);
				Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
				Database.AddInParameter(command,"IsMain",DbType.Boolean,isMain);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 wardSpecialityId = Convert.ToInt32(Database.GetParameterValue(command, "WardSpecialityId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for WardSpeciality using Stored Procedure
		/// and return DbCommand of the WardSpeciality
		/// </summary>
		public DbCommand InsertNewWardSpecialityCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewWardSpeciality");

				Database.AddInParameter(command,"WardId",DbType.Int32,"WardId",DataRowVersion.Current);
				Database.AddInParameter(command,"SpecialityId",DbType.Int32,"SpecialityId",DataRowVersion.Current);
				Database.AddInParameter(command,"IsMain",DbType.Boolean,"IsMain",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into WardSpeciality using Stored Procedure
		/// </summary>
		public bool UpdateWardSpeciality( int wardId, int specialityId, bool isMain, int oldwardSpecialityId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardSpeciality");

		    		Database.AddInParameter(command,"WardId",DbType.Int32,wardId);
		    		Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
		    		Database.AddInParameter(command,"IsMain",DbType.Boolean,isMain);
				Database.AddInParameter(command,"oldWardSpecialityId",DbType.Int32,oldwardSpecialityId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into WardSpeciality using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateWardSpeciality( int wardId, int specialityId, bool isMain, int oldwardSpecialityId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardSpeciality");

		    		Database.AddInParameter(command,"WardId",DbType.Int32,wardId);
		    		Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
		    		Database.AddInParameter(command,"IsMain",DbType.Boolean,isMain);
				Database.AddInParameter(command,"oldWardSpecialityId",DbType.Int32,oldwardSpecialityId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from WardSpeciality using Stored Procedure
		/// </summary>
		public DbCommand UpdateWardSpecialityCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateWardSpeciality");

		    		Database.AddInParameter(command,"WardId",DbType.Int32,"WardId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"SpecialityId",DbType.Int32,"SpecialityId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsMain",DbType.Boolean,"IsMain",DataRowVersion.Current);
				Database.AddInParameter(command,"oldWardSpecialityId",DbType.Int32,"WardSpecialityId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From WardSpeciality using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteWardSpeciality( int wardSpecialityId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteWardSpeciality");
			Database.AddInParameter(command,"WardSpecialityId",DbType.Int32,wardSpecialityId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From WardSpeciality Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteWardSpecialityCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteWardSpeciality");
				Database.AddInParameter(command,"WardSpecialityId",DbType.Int32,"WardSpecialityId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table WardSpeciality using Stored Procedure
		/// and return number of rows effected of the WardSpeciality
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"WardSpeciality",InsertNewWardSpecialityCommand(),UpdateWardSpecialityCommand(),DeleteWardSpecialityCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table WardSpeciality using Stored Procedure
		/// and return number of rows effected of the WardSpeciality
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"WardSpeciality",InsertNewWardSpecialityCommand(),UpdateWardSpecialityCommand(),DeleteWardSpecialityCommand(), transaction);
          return rowsAffected;
		}


	}
}
