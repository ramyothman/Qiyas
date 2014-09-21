using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.Eligibility
{
	/// <summary>
	/// This is a Data Access Class  for Division table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the Division table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class DivisionDAC : DataAccessComponent
	{
		#region Constructors
		public DivisionDAC(){}
		public DivisionDAC(string connectionString): base(connectionString){}
		public DivisionDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Division using Stored Procedure
		/// and return a DataTable containing all Division Data
		/// </summary>
		public DataTable GetAllDivision()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Division";
         string query = " select * from GetAllDivision";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["Division"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Division using Stored Procedure
		/// and return a DataTable containing all Division Data using a Transaction
		/// </summary>
		public DataTable GetAllDivision(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Division";
         string query = " select * from GetAllDivision";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["Division"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Division using Stored Procedure
		/// and return a DataTable containing all Division Data
		/// </summary>
		public DataTable GetAllDivision(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Division";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllDivision" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["Division"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Division using Stored Procedure
		/// and return a DataTable containing all Division Data using a Transaction
		/// </summary>
		public DataTable GetAllDivision(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Division";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllDivision" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["Division"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From Division using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDDivision( int divisionID)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDDivision");
				    Database.AddInParameter(command,"DivisionID",DbType.Int32,divisionID);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From Division using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDDivision( int divisionID,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDDivision");
				    Database.AddInParameter(command,"DivisionID",DbType.Int32,divisionID);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into Division using Stored Procedure
		/// and return the auto number primary key of Division inserted row
		/// </summary>
		public bool InsertNewDivision( ref int divisionID,  int departmentID,  string name,  string siteUrl)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewDivision");
				Database.AddOutParameter(command,"DivisionID",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"DepartmentID",DbType.Int32,departmentID);
				Database.AddInParameter(command,"Name",DbType.String,name);
				Database.AddInParameter(command,"SiteUrl",DbType.String,siteUrl);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 divisionID = Convert.ToInt32(Database.GetParameterValue(command, "DivisionID"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into Division using Stored Procedure
		/// and return the auto number primary key of Division inserted row using Transaction
		/// </summary>
		public bool InsertNewDivision( ref int divisionID,  int departmentID,  string name,  string siteUrl,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewDivision");
				Database.AddOutParameter(command,"DivisionID",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"DepartmentID",DbType.Int32,departmentID);
				Database.AddInParameter(command,"Name",DbType.String,name);
				Database.AddInParameter(command,"SiteUrl",DbType.String,siteUrl);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 divisionID = Convert.ToInt32(Database.GetParameterValue(command, "DivisionID"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for Division using Stored Procedure
		/// and return DbCommand of the Division
		/// </summary>
		public DbCommand InsertNewDivisionCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewDivision");

				Database.AddInParameter(command,"DepartmentID",DbType.Int32,"DepartmentID",DataRowVersion.Current);
				Database.AddInParameter(command,"Name",DbType.String,"Name",DataRowVersion.Current);
				Database.AddInParameter(command,"SiteUrl",DbType.String,"SiteUrl",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into Division using Stored Procedure
		/// </summary>
		public bool UpdateDivision( int departmentID, string name, string siteUrl, int olddivisionID)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateDivision");

		    		Database.AddInParameter(command,"DepartmentID",DbType.Int32,departmentID);
		    		Database.AddInParameter(command,"Name",DbType.String,name);
		    		Database.AddInParameter(command,"SiteUrl",DbType.String,siteUrl);
				Database.AddInParameter(command,"oldDivisionID",DbType.Int32,olddivisionID);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into Division using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateDivision( int departmentID, string name, string siteUrl, int olddivisionID,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateDivision");

		    		Database.AddInParameter(command,"DepartmentID",DbType.Int32,departmentID);
		    		Database.AddInParameter(command,"Name",DbType.String,name);
		    		Database.AddInParameter(command,"SiteUrl",DbType.String,siteUrl);
				Database.AddInParameter(command,"oldDivisionID",DbType.Int32,olddivisionID);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from Division using Stored Procedure
		/// </summary>
		public DbCommand UpdateDivisionCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateDivision");

		    		Database.AddInParameter(command,"DepartmentID",DbType.Int32,"DepartmentID",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Name",DbType.String,"Name",DataRowVersion.Current);
		    		Database.AddInParameter(command,"SiteUrl",DbType.String,"SiteUrl",DataRowVersion.Current);
				Database.AddInParameter(command,"oldDivisionID",DbType.Int32,"DivisionID",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From Division using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteDivision( int divisionID)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteDivision");
			Database.AddInParameter(command,"DivisionID",DbType.Int32,divisionID);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From Division Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteDivisionCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteDivision");
				Database.AddInParameter(command,"DivisionID",DbType.Int32,"DivisionID",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table Division using Stored Procedure
		/// and return number of rows effected of the Division
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"Division",InsertNewDivisionCommand(),UpdateDivisionCommand(),DeleteDivisionCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table Division using Stored Procedure
		/// and return number of rows effected of the Division
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"Division",InsertNewDivisionCommand(),UpdateDivisionCommand(),DeleteDivisionCommand(), transaction);
          return rowsAffected;
		}


	}
}
