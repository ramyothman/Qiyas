using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.Eligibility
{
	/// <summary>
	/// This is a Data Access Class  for EligibleFiles table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the EligibleFiles table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class EligibleFilesDAC : DataAccessComponent
	{
		#region Constructors
		public EligibleFilesDAC(){}
		public EligibleFilesDAC(string connectionString): base(connectionString){}
		public EligibleFilesDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibleFiles using Stored Procedure
		/// and return a DataTable containing all EligibleFiles Data
		/// </summary>
		public DataTable GetAllEligibleFiles()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibleFiles";
         string query = " select * from GetAllEligibleFiles";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["EligibleFiles"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibleFiles using Stored Procedure
		/// and return a DataTable containing all EligibleFiles Data using a Transaction
		/// </summary>
		public DataTable GetAllEligibleFiles(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibleFiles";
         string query = " select * from GetAllEligibleFiles";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["EligibleFiles"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibleFiles using Stored Procedure
		/// and return a DataTable containing all EligibleFiles Data
		/// </summary>
		public DataTable GetAllEligibleFiles(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibleFiles";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllEligibleFiles" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["EligibleFiles"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibleFiles using Stored Procedure
		/// and return a DataTable containing all EligibleFiles Data using a Transaction
		/// </summary>
		public DataTable GetAllEligibleFiles(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibleFiles";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllEligibleFiles" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["EligibleFiles"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From EligibleFiles using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDEligibleFiles( int eligibleFileId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDEligibleFiles");
				    Database.AddInParameter(command,"EligibleFileId",DbType.Int32,eligibleFileId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From EligibleFiles using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDEligibleFiles( int eligibleFileId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDEligibleFiles");
				    Database.AddInParameter(command,"EligibleFileId",DbType.Int32,eligibleFileId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into EligibleFiles using Stored Procedure
		/// and return the auto number primary key of EligibleFiles inserted row
		/// </summary>
		public bool InsertNewEligibleFiles( ref int eligibleFileId,  int eligibleId,  string fileName,  string fileDescription,  string filePath)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligibleFiles");
				Database.AddOutParameter(command,"EligibleFileId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"EligibleId",DbType.Int32,eligibleId);
				Database.AddInParameter(command,"FileName",DbType.String,fileName);
				Database.AddInParameter(command,"FileDescription",DbType.String,fileDescription);
				Database.AddInParameter(command,"FilePath",DbType.String,filePath);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 eligibleFileId = Convert.ToInt32(Database.GetParameterValue(command, "EligibleFileId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into EligibleFiles using Stored Procedure
		/// and return the auto number primary key of EligibleFiles inserted row using Transaction
		/// </summary>
		public bool InsertNewEligibleFiles( ref int eligibleFileId,  int eligibleId,  string fileName,  string fileDescription,  string filePath,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligibleFiles");
				Database.AddOutParameter(command,"EligibleFileId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"EligibleId",DbType.Int32,eligibleId);
				Database.AddInParameter(command,"FileName",DbType.String,fileName);
				Database.AddInParameter(command,"FileDescription",DbType.String,fileDescription);
				Database.AddInParameter(command,"FilePath",DbType.String,filePath);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 eligibleFileId = Convert.ToInt32(Database.GetParameterValue(command, "EligibleFileId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for EligibleFiles using Stored Procedure
		/// and return DbCommand of the EligibleFiles
		/// </summary>
		public DbCommand InsertNewEligibleFilesCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligibleFiles");

				Database.AddInParameter(command,"EligibleId",DbType.Int32,"EligibleId",DataRowVersion.Current);
				Database.AddInParameter(command,"FileName",DbType.String,"FileName",DataRowVersion.Current);
				Database.AddInParameter(command,"FileDescription",DbType.String,"FileDescription",DataRowVersion.Current);
				Database.AddInParameter(command,"FilePath",DbType.String,"FilePath",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into EligibleFiles using Stored Procedure
		/// </summary>
		public bool UpdateEligibleFiles( int eligibleId, string fileName, string fileDescription, string filePath, int oldeligibleFileId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligibleFiles");

		    		Database.AddInParameter(command,"EligibleId",DbType.Int32,eligibleId);
		    		Database.AddInParameter(command,"FileName",DbType.String,fileName);
		    		Database.AddInParameter(command,"FileDescription",DbType.String,fileDescription);
		    		Database.AddInParameter(command,"FilePath",DbType.String,filePath);
				Database.AddInParameter(command,"oldEligibleFileId",DbType.Int32,oldeligibleFileId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into EligibleFiles using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateEligibleFiles( int eligibleId, string fileName, string fileDescription, string filePath, int oldeligibleFileId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligibleFiles");

		    		Database.AddInParameter(command,"EligibleId",DbType.Int32,eligibleId);
		    		Database.AddInParameter(command,"FileName",DbType.String,fileName);
		    		Database.AddInParameter(command,"FileDescription",DbType.String,fileDescription);
		    		Database.AddInParameter(command,"FilePath",DbType.String,filePath);
				Database.AddInParameter(command,"oldEligibleFileId",DbType.Int32,oldeligibleFileId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from EligibleFiles using Stored Procedure
		/// </summary>
		public DbCommand UpdateEligibleFilesCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligibleFiles");

		    		Database.AddInParameter(command,"EligibleId",DbType.Int32,"EligibleId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"FileName",DbType.String,"FileName",DataRowVersion.Current);
		    		Database.AddInParameter(command,"FileDescription",DbType.String,"FileDescription",DataRowVersion.Current);
		    		Database.AddInParameter(command,"FilePath",DbType.String,"FilePath",DataRowVersion.Current);
				Database.AddInParameter(command,"oldEligibleFileId",DbType.Int32,"EligibleFileId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From EligibleFiles using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteEligibleFiles( int eligibleFileId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteEligibleFiles");
			Database.AddInParameter(command,"EligibleFileId",DbType.Int32,eligibleFileId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From EligibleFiles Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteEligibleFilesCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteEligibleFiles");
				Database.AddInParameter(command,"EligibleFileId",DbType.Int32,"EligibleFileId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table EligibleFiles using Stored Procedure
		/// and return number of rows effected of the EligibleFiles
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"EligibleFiles",InsertNewEligibleFilesCommand(),UpdateEligibleFilesCommand(),DeleteEligibleFilesCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table EligibleFiles using Stored Procedure
		/// and return number of rows effected of the EligibleFiles
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"EligibleFiles",InsertNewEligibleFilesCommand(),UpdateEligibleFilesCommand(),DeleteEligibleFilesCommand(), transaction);
          return rowsAffected;
		}


	}
}
