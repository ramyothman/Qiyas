using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.BedManagement
{
	/// <summary>
	/// This is a Data Access Class  for DischargeType table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the DischargeType table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class DischargeTypeDAC : DataAccessComponent
	{
		#region Constructors
		public DischargeTypeDAC(){}
		public DischargeTypeDAC(string connectionString): base(connectionString){}
		public DischargeTypeDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all DischargeType using Stored Procedure
		/// and return a DataTable containing all DischargeType Data
		/// </summary>
		public DataTable GetAllDischargeType()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "DischargeType";
         string query = " select * from GetAllDischargeType";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["DischargeType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all DischargeType using Stored Procedure
		/// and return a DataTable containing all DischargeType Data using a Transaction
		/// </summary>
		public DataTable GetAllDischargeType(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "DischargeType";
         string query = " select * from GetAllDischargeType";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["DischargeType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all DischargeType using Stored Procedure
		/// and return a DataTable containing all DischargeType Data
		/// </summary>
		public DataTable GetAllDischargeType(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "DischargeType";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllDischargeType" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["DischargeType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all DischargeType using Stored Procedure
		/// and return a DataTable containing all DischargeType Data using a Transaction
		/// </summary>
		public DataTable GetAllDischargeType(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "DischargeType";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllDischargeType" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["DischargeType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From DischargeType using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDDischargeType( int dischargeTypeId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDDischargeType");
				    Database.AddInParameter(command,"DischargeTypeId",DbType.Int32,dischargeTypeId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From DischargeType using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDDischargeType( int dischargeTypeId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDDischargeType");
				    Database.AddInParameter(command,"DischargeTypeId",DbType.Int32,dischargeTypeId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into DischargeType using Stored Procedure
		/// and return the auto number primary key of DischargeType inserted row
		/// </summary>
		public bool InsertNewDischargeType( ref int dischargeTypeId,  string name,  string dischargeCode,  int dischargeOrder)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewDischargeType");
				Database.AddOutParameter(command,"DischargeTypeId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"Name",DbType.String,name);
				Database.AddInParameter(command,"DischargeCode",DbType.String,dischargeCode);
				Database.AddInParameter(command,"DischargeOrder",DbType.Int32,dischargeOrder);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 dischargeTypeId = Convert.ToInt32(Database.GetParameterValue(command, "DischargeTypeId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into DischargeType using Stored Procedure
		/// and return the auto number primary key of DischargeType inserted row using Transaction
		/// </summary>
		public bool InsertNewDischargeType( ref int dischargeTypeId,  string name,  string dischargeCode,  int dischargeOrder,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewDischargeType");
				Database.AddOutParameter(command,"DischargeTypeId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"Name",DbType.String,name);
				Database.AddInParameter(command,"DischargeCode",DbType.String,dischargeCode);
				Database.AddInParameter(command,"DischargeOrder",DbType.Int32,dischargeOrder);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 dischargeTypeId = Convert.ToInt32(Database.GetParameterValue(command, "DischargeTypeId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for DischargeType using Stored Procedure
		/// and return DbCommand of the DischargeType
		/// </summary>
		public DbCommand InsertNewDischargeTypeCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewDischargeType");

				Database.AddInParameter(command,"Name",DbType.String,"Name",DataRowVersion.Current);
				Database.AddInParameter(command,"DischargeCode",DbType.String,"DischargeCode",DataRowVersion.Current);
				Database.AddInParameter(command,"DischargeOrder",DbType.Int32,"DischargeOrder",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into DischargeType using Stored Procedure
		/// </summary>
		public bool UpdateDischargeType( string name, string dischargeCode, int dischargeOrder, int olddischargeTypeId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateDischargeType");

		    		Database.AddInParameter(command,"Name",DbType.String,name);
		    		Database.AddInParameter(command,"DischargeCode",DbType.String,dischargeCode);
		    		Database.AddInParameter(command,"DischargeOrder",DbType.Int32,dischargeOrder);
				Database.AddInParameter(command,"oldDischargeTypeId",DbType.Int32,olddischargeTypeId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into DischargeType using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateDischargeType( string name, string dischargeCode, int dischargeOrder, int olddischargeTypeId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateDischargeType");

		    		Database.AddInParameter(command,"Name",DbType.String,name);
		    		Database.AddInParameter(command,"DischargeCode",DbType.String,dischargeCode);
		    		Database.AddInParameter(command,"DischargeOrder",DbType.Int32,dischargeOrder);
				Database.AddInParameter(command,"oldDischargeTypeId",DbType.Int32,olddischargeTypeId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from DischargeType using Stored Procedure
		/// </summary>
		public DbCommand UpdateDischargeTypeCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateDischargeType");

		    		Database.AddInParameter(command,"Name",DbType.String,"Name",DataRowVersion.Current);
		    		Database.AddInParameter(command,"DischargeCode",DbType.String,"DischargeCode",DataRowVersion.Current);
		    		Database.AddInParameter(command,"DischargeOrder",DbType.Int32,"DischargeOrder",DataRowVersion.Current);
				Database.AddInParameter(command,"oldDischargeTypeId",DbType.Int32,"DischargeTypeId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From DischargeType using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteDischargeType( int dischargeTypeId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteDischargeType");
			Database.AddInParameter(command,"DischargeTypeId",DbType.Int32,dischargeTypeId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From DischargeType Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteDischargeTypeCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteDischargeType");
				Database.AddInParameter(command,"DischargeTypeId",DbType.Int32,"DischargeTypeId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table DischargeType using Stored Procedure
		/// and return number of rows effected of the DischargeType
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"DischargeType",InsertNewDischargeTypeCommand(),UpdateDischargeTypeCommand(),DeleteDischargeTypeCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table DischargeType using Stored Procedure
		/// and return number of rows effected of the DischargeType
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"DischargeType",InsertNewDischargeTypeCommand(),UpdateDischargeTypeCommand(),DeleteDischargeTypeCommand(), transaction);
          return rowsAffected;
		}


	}
}
