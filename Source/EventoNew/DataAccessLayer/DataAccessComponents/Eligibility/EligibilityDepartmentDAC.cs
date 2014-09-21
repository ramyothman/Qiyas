using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.Eligibility
{
	/// <summary>
	/// This is a Data Access Class  for EligibilityDepartment table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the EligibilityDepartment table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class EligibilityDepartmentDAC : DataAccessComponent
	{
		#region Constructors
		public EligibilityDepartmentDAC(){}
		public EligibilityDepartmentDAC(string connectionString): base(connectionString){}
		public EligibilityDepartmentDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibilityDepartment using Stored Procedure
		/// and return a DataTable containing all EligibilityDepartment Data
		/// </summary>
		public DataTable GetAllEligibilityDepartment()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibilityDepartment";
         string query = " select * from GetAllEligibilityDepartment";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["EligibilityDepartment"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibilityDepartment using Stored Procedure
		/// and return a DataTable containing all EligibilityDepartment Data using a Transaction
		/// </summary>
		public DataTable GetAllEligibilityDepartment(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibilityDepartment";
         string query = " select * from GetAllEligibilityDepartment";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["EligibilityDepartment"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibilityDepartment using Stored Procedure
		/// and return a DataTable containing all EligibilityDepartment Data
		/// </summary>
		public DataTable GetAllEligibilityDepartment(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibilityDepartment";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllEligibilityDepartment" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["EligibilityDepartment"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibilityDepartment using Stored Procedure
		/// and return a DataTable containing all EligibilityDepartment Data using a Transaction
		/// </summary>
		public DataTable GetAllEligibilityDepartment(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibilityDepartment";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllEligibilityDepartment" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["EligibilityDepartment"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From EligibilityDepartment using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDEligibilityDepartment( int eligibilityDepartmentId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDEligibilityDepartment");
				    Database.AddInParameter(command,"EligibilityDepartmentId",DbType.Int32,eligibilityDepartmentId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From EligibilityDepartment using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDEligibilityDepartment( int eligibilityDepartmentId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDEligibilityDepartment");
				    Database.AddInParameter(command,"EligibilityDepartmentId",DbType.Int32,eligibilityDepartmentId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into EligibilityDepartment using Stored Procedure
		/// and return the auto number primary key of EligibilityDepartment inserted row
		/// </summary>
		public bool InsertNewEligibilityDepartment( ref int eligibilityDepartmentId,  string departmentName)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligibilityDepartment");
				Database.AddOutParameter(command,"EligibilityDepartmentId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"DepartmentName",DbType.String,departmentName);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 eligibilityDepartmentId = Convert.ToInt32(Database.GetParameterValue(command, "EligibilityDepartmentId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into EligibilityDepartment using Stored Procedure
		/// and return the auto number primary key of EligibilityDepartment inserted row using Transaction
		/// </summary>
		public bool InsertNewEligibilityDepartment( ref int eligibilityDepartmentId,  string departmentName,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligibilityDepartment");
				Database.AddOutParameter(command,"EligibilityDepartmentId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"DepartmentName",DbType.String,departmentName);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 eligibilityDepartmentId = Convert.ToInt32(Database.GetParameterValue(command, "EligibilityDepartmentId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for EligibilityDepartment using Stored Procedure
		/// and return DbCommand of the EligibilityDepartment
		/// </summary>
		public DbCommand InsertNewEligibilityDepartmentCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligibilityDepartment");

				Database.AddInParameter(command,"DepartmentName",DbType.String,"DepartmentName",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into EligibilityDepartment using Stored Procedure
		/// </summary>
		public bool UpdateEligibilityDepartment( string departmentName, int oldeligibilityDepartmentId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligibilityDepartment");

		    		Database.AddInParameter(command,"DepartmentName",DbType.String,departmentName);
				Database.AddInParameter(command,"oldEligibilityDepartmentId",DbType.Int32,oldeligibilityDepartmentId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into EligibilityDepartment using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateEligibilityDepartment( string departmentName, int oldeligibilityDepartmentId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligibilityDepartment");

		    		Database.AddInParameter(command,"DepartmentName",DbType.String,departmentName);
				Database.AddInParameter(command,"oldEligibilityDepartmentId",DbType.Int32,oldeligibilityDepartmentId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from EligibilityDepartment using Stored Procedure
		/// </summary>
		public DbCommand UpdateEligibilityDepartmentCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligibilityDepartment");

		    		Database.AddInParameter(command,"DepartmentName",DbType.String,"DepartmentName",DataRowVersion.Current);
				Database.AddInParameter(command,"oldEligibilityDepartmentId",DbType.Int32,"EligibilityDepartmentId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From EligibilityDepartment using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteEligibilityDepartment( int eligibilityDepartmentId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteEligibilityDepartment");
			Database.AddInParameter(command,"EligibilityDepartmentId",DbType.Int32,eligibilityDepartmentId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From EligibilityDepartment Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteEligibilityDepartmentCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteEligibilityDepartment");
				Database.AddInParameter(command,"EligibilityDepartmentId",DbType.Int32,"EligibilityDepartmentId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table EligibilityDepartment using Stored Procedure
		/// and return number of rows effected of the EligibilityDepartment
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"EligibilityDepartment",InsertNewEligibilityDepartmentCommand(),UpdateEligibilityDepartmentCommand(),DeleteEligibilityDepartmentCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table EligibilityDepartment using Stored Procedure
		/// and return number of rows effected of the EligibilityDepartment
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"EligibilityDepartment",InsertNewEligibilityDepartmentCommand(),UpdateEligibilityDepartmentCommand(),DeleteEligibilityDepartmentCommand(), transaction);
          return rowsAffected;
		}


	}
}
