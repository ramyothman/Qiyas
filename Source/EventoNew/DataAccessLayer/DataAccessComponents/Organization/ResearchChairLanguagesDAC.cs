using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.Organization
{
	/// <summary>
	/// This is a Data Access Class  for ResearchChairLanguages table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the ResearchChairLanguages table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class ResearchChairLanguagesDAC : DataAccessComponent
	{
		#region Constructors
		public ResearchChairLanguagesDAC(){}
		public ResearchChairLanguagesDAC(string connectionString): base(connectionString){}
		public ResearchChairLanguagesDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all ResearchChairLanguages using Stored Procedure
		/// and return a DataTable containing all ResearchChairLanguages Data
		/// </summary>
		public DataTable GetAllResearchChairLanguages()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "ResearchChairLanguages";
         string query = " select * from GetAllResearchChairLanguages";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["ResearchChairLanguages"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all ResearchChairLanguages using Stored Procedure
		/// and return a DataTable containing all ResearchChairLanguages Data using a Transaction
		/// </summary>
		public DataTable GetAllResearchChairLanguages(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "ResearchChairLanguages";
         string query = " select * from GetAllResearchChairLanguages";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["ResearchChairLanguages"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all ResearchChairLanguages using Stored Procedure
		/// and return a DataTable containing all ResearchChairLanguages Data
		/// </summary>
		public DataTable GetAllResearchChairLanguages(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "ResearchChairLanguages";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllResearchChairLanguages" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["ResearchChairLanguages"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all ResearchChairLanguages using Stored Procedure
		/// and return a DataTable containing all ResearchChairLanguages Data using a Transaction
		/// </summary>
		public DataTable GetAllResearchChairLanguages(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "ResearchChairLanguages";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllResearchChairLanguages" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["ResearchChairLanguages"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From ResearchChairLanguages using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDResearchChairLanguages( int researchChairLanguagesId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDResearchChairLanguages");
				    Database.AddInParameter(command,"ResearchChairLanguagesId",DbType.Int32,researchChairLanguagesId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From ResearchChairLanguages using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDResearchChairLanguages( int researchChairLanguagesId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDResearchChairLanguages");
				    Database.AddInParameter(command,"ResearchChairLanguagesId",DbType.Int32,researchChairLanguagesId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into ResearchChairLanguages using Stored Procedure
		/// and return the auto number primary key of ResearchChairLanguages inserted row
		/// </summary>
		public bool InsertNewResearchChairLanguages( ref int researchChairLanguagesId,  int researchChairId,  int languageId,  string name,  string description)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewResearchChairLanguages");
				Database.AddOutParameter(command,"ResearchChairLanguagesId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"ResearchChairId",DbType.Int32,researchChairId);
				Database.AddInParameter(command,"LanguageId",DbType.Int32,languageId);
				Database.AddInParameter(command,"Name",DbType.String,name);
				Database.AddInParameter(command,"Description",DbType.String,description);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 researchChairLanguagesId = Convert.ToInt32(Database.GetParameterValue(command, "ResearchChairLanguagesId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into ResearchChairLanguages using Stored Procedure
		/// and return the auto number primary key of ResearchChairLanguages inserted row using Transaction
		/// </summary>
		public bool InsertNewResearchChairLanguages( ref int researchChairLanguagesId,  int researchChairId,  int languageId,  string name,  string description,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewResearchChairLanguages");
				Database.AddOutParameter(command,"ResearchChairLanguagesId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"ResearchChairId",DbType.Int32,researchChairId);
				Database.AddInParameter(command,"LanguageId",DbType.Int32,languageId);
				Database.AddInParameter(command,"Name",DbType.String,name);
				Database.AddInParameter(command,"Description",DbType.String,description);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 researchChairLanguagesId = Convert.ToInt32(Database.GetParameterValue(command, "ResearchChairLanguagesId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for ResearchChairLanguages using Stored Procedure
		/// and return DbCommand of the ResearchChairLanguages
		/// </summary>
		public DbCommand InsertNewResearchChairLanguagesCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewResearchChairLanguages");

				Database.AddInParameter(command,"ResearchChairId",DbType.Int32,"ResearchChairId",DataRowVersion.Current);
				Database.AddInParameter(command,"LanguageId",DbType.Int32,"LanguageId",DataRowVersion.Current);
				Database.AddInParameter(command,"Name",DbType.String,"Name",DataRowVersion.Current);
				Database.AddInParameter(command,"Description",DbType.String,"Description",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into ResearchChairLanguages using Stored Procedure
		/// </summary>
		public bool UpdateResearchChairLanguages( int researchChairId, int languageId, string name, string description, int oldresearchChairLanguagesId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateResearchChairLanguages");

		    		Database.AddInParameter(command,"ResearchChairId",DbType.Int32,researchChairId);
		    		Database.AddInParameter(command,"LanguageId",DbType.Int32,languageId);
		    		Database.AddInParameter(command,"Name",DbType.String,name);
		    		Database.AddInParameter(command,"Description",DbType.String,description);
				Database.AddInParameter(command,"oldResearchChairLanguagesId",DbType.Int32,oldresearchChairLanguagesId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into ResearchChairLanguages using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateResearchChairLanguages( int researchChairId, int languageId, string name, string description, int oldresearchChairLanguagesId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateResearchChairLanguages");

		    		Database.AddInParameter(command,"ResearchChairId",DbType.Int32,researchChairId);
		    		Database.AddInParameter(command,"LanguageId",DbType.Int32,languageId);
		    		Database.AddInParameter(command,"Name",DbType.String,name);
		    		Database.AddInParameter(command,"Description",DbType.String,description);
				Database.AddInParameter(command,"oldResearchChairLanguagesId",DbType.Int32,oldresearchChairLanguagesId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from ResearchChairLanguages using Stored Procedure
		/// </summary>
		public DbCommand UpdateResearchChairLanguagesCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateResearchChairLanguages");

		    		Database.AddInParameter(command,"ResearchChairId",DbType.Int32,"ResearchChairId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"LanguageId",DbType.Int32,"LanguageId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Name",DbType.String,"Name",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Description",DbType.String,"Description",DataRowVersion.Current);
				Database.AddInParameter(command,"oldResearchChairLanguagesId",DbType.Int32,"ResearchChairLanguagesId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From ResearchChairLanguages using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteResearchChairLanguages( int researchChairLanguagesId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteResearchChairLanguages");
			Database.AddInParameter(command,"ResearchChairLanguagesId",DbType.Int32,researchChairLanguagesId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From ResearchChairLanguages Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteResearchChairLanguagesCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteResearchChairLanguages");
				Database.AddInParameter(command,"ResearchChairLanguagesId",DbType.Int32,"ResearchChairLanguagesId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table ResearchChairLanguages using Stored Procedure
		/// and return number of rows effected of the ResearchChairLanguages
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"ResearchChairLanguages",InsertNewResearchChairLanguagesCommand(),UpdateResearchChairLanguagesCommand(),DeleteResearchChairLanguagesCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table ResearchChairLanguages using Stored Procedure
		/// and return number of rows effected of the ResearchChairLanguages
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"ResearchChairLanguages",InsertNewResearchChairLanguagesCommand(),UpdateResearchChairLanguagesCommand(),DeleteResearchChairLanguagesCommand(), transaction);
          return rowsAffected;
		}


	}
}
