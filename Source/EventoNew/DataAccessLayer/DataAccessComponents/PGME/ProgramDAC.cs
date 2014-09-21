using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.PGME
{
	/// <summary>
	/// This is a Data Access Class  for Program table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the Program table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class ProgramDAC : DataAccessComponent
	{
		#region Constructors
		public ProgramDAC(){}
		public ProgramDAC(string connectionString): base(connectionString){}
		public ProgramDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Program using Stored Procedure
		/// and return a DataTable containing all Program Data
		/// </summary>
		public DataTable GetAllProgram()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Program";
         string query = " select * from GetAllProgram";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["Program"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Program using Stored Procedure
		/// and return a DataTable containing all Program Data using a Transaction
		/// </summary>
		public DataTable GetAllProgram(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Program";
         string query = " select * from GetAllProgram";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["Program"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Program using Stored Procedure
		/// and return a DataTable containing all Program Data
		/// </summary>
		public DataTable GetAllProgram(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Program";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllProgram" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["Program"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Program using Stored Procedure
		/// and return a DataTable containing all Program Data using a Transaction
		/// </summary>
		public DataTable GetAllProgram(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Program";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllProgram" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["Program"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From Program using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDProgram( int programId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDProgram");
				    Database.AddInParameter(command,"ProgramId",DbType.Int32,programId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From Program using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDProgram( int programId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDProgram");
				    Database.AddInParameter(command,"ProgramId",DbType.Int32,programId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into Program using Stored Procedure
		/// and return the auto number primary key of Program inserted row
		/// </summary>
		public bool InsertNewProgram( ref int programId,  int programTypeId,  int departmentId,  string programName,  string programDescription)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewProgram");
				Database.AddOutParameter(command,"ProgramId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"ProgramTypeId",DbType.Int32,programTypeId);
				Database.AddInParameter(command,"DepartmentId",DbType.Int32,departmentId);
				Database.AddInParameter(command,"ProgramName",DbType.String,programName);
				Database.AddInParameter(command,"ProgramDescription",DbType.String,programDescription);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 programId = Convert.ToInt32(Database.GetParameterValue(command, "ProgramId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into Program using Stored Procedure
		/// and return the auto number primary key of Program inserted row using Transaction
		/// </summary>
		public bool InsertNewProgram( ref int programId,  int programTypeId,  int departmentId,  string programName,  string programDescription,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewProgram");
				Database.AddOutParameter(command,"ProgramId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"ProgramTypeId",DbType.Int32,programTypeId);
				Database.AddInParameter(command,"DepartmentId",DbType.Int32,departmentId);
				Database.AddInParameter(command,"ProgramName",DbType.String,programName);
				Database.AddInParameter(command,"ProgramDescription",DbType.String,programDescription);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 programId = Convert.ToInt32(Database.GetParameterValue(command, "ProgramId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for Program using Stored Procedure
		/// and return DbCommand of the Program
		/// </summary>
		public DbCommand InsertNewProgramCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewProgram");

				Database.AddInParameter(command,"ProgramTypeId",DbType.Int32,"ProgramTypeId",DataRowVersion.Current);
				Database.AddInParameter(command,"DepartmentId",DbType.Int32,"DepartmentId",DataRowVersion.Current);
				Database.AddInParameter(command,"ProgramName",DbType.String,"ProgramName",DataRowVersion.Current);
				Database.AddInParameter(command,"ProgramDescription",DbType.String,"ProgramDescription",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into Program using Stored Procedure
		/// </summary>
		public bool UpdateProgram( int programTypeId, int departmentId, string programName, string programDescription, int oldprogramId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateProgram");

		    		Database.AddInParameter(command,"ProgramTypeId",DbType.Int32,programTypeId);
		    		Database.AddInParameter(command,"DepartmentId",DbType.Int32,departmentId);
		    		Database.AddInParameter(command,"ProgramName",DbType.String,programName);
		    		Database.AddInParameter(command,"ProgramDescription",DbType.String,programDescription);
				Database.AddInParameter(command,"oldProgramId",DbType.Int32,oldprogramId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into Program using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateProgram( int programTypeId, int departmentId, string programName, string programDescription, int oldprogramId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateProgram");

		    		Database.AddInParameter(command,"ProgramTypeId",DbType.Int32,programTypeId);
		    		Database.AddInParameter(command,"DepartmentId",DbType.Int32,departmentId);
		    		Database.AddInParameter(command,"ProgramName",DbType.String,programName);
		    		Database.AddInParameter(command,"ProgramDescription",DbType.String,programDescription);
				Database.AddInParameter(command,"oldProgramId",DbType.Int32,oldprogramId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from Program using Stored Procedure
		/// </summary>
		public DbCommand UpdateProgramCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateProgram");

		    		Database.AddInParameter(command,"ProgramTypeId",DbType.Int32,"ProgramTypeId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"DepartmentId",DbType.Int32,"DepartmentId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ProgramName",DbType.String,"ProgramName",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ProgramDescription",DbType.String,"ProgramDescription",DataRowVersion.Current);
				Database.AddInParameter(command,"oldProgramId",DbType.Int32,"ProgramId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From Program using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteProgram( int programId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteProgram");
			Database.AddInParameter(command,"ProgramId",DbType.Int32,programId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From Program Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteProgramCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteProgram");
				Database.AddInParameter(command,"ProgramId",DbType.Int32,"ProgramId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table Program using Stored Procedure
		/// and return number of rows effected of the Program
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"Program",InsertNewProgramCommand(),UpdateProgramCommand(),DeleteProgramCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table Program using Stored Procedure
		/// and return number of rows effected of the Program
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"Program",InsertNewProgramCommand(),UpdateProgramCommand(),DeleteProgramCommand(), transaction);
          return rowsAffected;
		}


	}
}
