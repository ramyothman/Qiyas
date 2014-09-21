using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.PGME
{
	/// <summary>
	/// This is a Data Access Class  for ProgramType table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the ProgramType table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class ProgramTypeDAC : DataAccessComponent
	{
		#region Constructors
		public ProgramTypeDAC(){}
		public ProgramTypeDAC(string connectionString): base(connectionString){}
		public ProgramTypeDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all ProgramType using Stored Procedure
		/// and return a DataTable containing all ProgramType Data
		/// </summary>
		public DataTable GetAllProgramType()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "ProgramType";
         string query = " select * from GetAllProgramType";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["ProgramType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all ProgramType using Stored Procedure
		/// and return a DataTable containing all ProgramType Data using a Transaction
		/// </summary>
		public DataTable GetAllProgramType(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "ProgramType";
         string query = " select * from GetAllProgramType";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["ProgramType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all ProgramType using Stored Procedure
		/// and return a DataTable containing all ProgramType Data
		/// </summary>
		public DataTable GetAllProgramType(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "ProgramType";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllProgramType" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["ProgramType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all ProgramType using Stored Procedure
		/// and return a DataTable containing all ProgramType Data using a Transaction
		/// </summary>
		public DataTable GetAllProgramType(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "ProgramType";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllProgramType" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["ProgramType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From ProgramType using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDProgramType( int programTypeId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDProgramType");
				    Database.AddInParameter(command,"ProgramTypeId",DbType.Int32,programTypeId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From ProgramType using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDProgramType( int programTypeId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDProgramType");
				    Database.AddInParameter(command,"ProgramTypeId",DbType.Int32,programTypeId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into ProgramType using Stored Procedure
		/// and return the auto number primary key of ProgramType inserted row
		/// </summary>
		public bool InsertNewProgramType( ref int programTypeId,  string programTypeName)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewProgramType");
				Database.AddOutParameter(command,"ProgramTypeId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"ProgramTypeName",DbType.String,programTypeName);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 programTypeId = Convert.ToInt32(Database.GetParameterValue(command, "ProgramTypeId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into ProgramType using Stored Procedure
		/// and return the auto number primary key of ProgramType inserted row using Transaction
		/// </summary>
		public bool InsertNewProgramType( ref int programTypeId,  string programTypeName,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewProgramType");
				Database.AddOutParameter(command,"ProgramTypeId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"ProgramTypeName",DbType.String,programTypeName);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 programTypeId = Convert.ToInt32(Database.GetParameterValue(command, "ProgramTypeId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for ProgramType using Stored Procedure
		/// and return DbCommand of the ProgramType
		/// </summary>
		public DbCommand InsertNewProgramTypeCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewProgramType");

				Database.AddInParameter(command,"ProgramTypeName",DbType.String,"ProgramTypeName",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into ProgramType using Stored Procedure
		/// </summary>
		public bool UpdateProgramType( string programTypeName, int oldprogramTypeId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateProgramType");

		    		Database.AddInParameter(command,"ProgramTypeName",DbType.String,programTypeName);
				Database.AddInParameter(command,"oldProgramTypeId",DbType.Int32,oldprogramTypeId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into ProgramType using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateProgramType( string programTypeName, int oldprogramTypeId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateProgramType");

		    		Database.AddInParameter(command,"ProgramTypeName",DbType.String,programTypeName);
				Database.AddInParameter(command,"oldProgramTypeId",DbType.Int32,oldprogramTypeId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from ProgramType using Stored Procedure
		/// </summary>
		public DbCommand UpdateProgramTypeCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateProgramType");

		    		Database.AddInParameter(command,"ProgramTypeName",DbType.String,"ProgramTypeName",DataRowVersion.Current);
				Database.AddInParameter(command,"oldProgramTypeId",DbType.Int32,"ProgramTypeId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From ProgramType using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteProgramType( int programTypeId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteProgramType");
			Database.AddInParameter(command,"ProgramTypeId",DbType.Int32,programTypeId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From ProgramType Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteProgramTypeCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteProgramType");
				Database.AddInParameter(command,"ProgramTypeId",DbType.Int32,"ProgramTypeId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table ProgramType using Stored Procedure
		/// and return number of rows effected of the ProgramType
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"ProgramType",InsertNewProgramTypeCommand(),UpdateProgramTypeCommand(),DeleteProgramTypeCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table ProgramType using Stored Procedure
		/// and return number of rows effected of the ProgramType
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"ProgramType",InsertNewProgramTypeCommand(),UpdateProgramTypeCommand(),DeleteProgramTypeCommand(), transaction);
          return rowsAffected;
		}


	}
}
