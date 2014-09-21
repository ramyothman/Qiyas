using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.Organization
{
	/// <summary>
	/// This is a Data Access Class  for ResearchChairs table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the ResearchChairs table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class ResearchChairsDAC : DataAccessComponent
	{
		#region Constructors
		public ResearchChairsDAC(){}
		public ResearchChairsDAC(string connectionString): base(connectionString){}
		public ResearchChairsDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all ResearchChairs using Stored Procedure
		/// and return a DataTable containing all ResearchChairs Data
		/// </summary>
		public DataTable GetAllResearchChairs()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "ResearchChairs";
         string query = " select * from GetAllResearchChairs";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["ResearchChairs"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all ResearchChairs using Stored Procedure
		/// and return a DataTable containing all ResearchChairs Data using a Transaction
		/// </summary>
		public DataTable GetAllResearchChairs(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "ResearchChairs";
         string query = " select * from GetAllResearchChairs";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["ResearchChairs"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all ResearchChairs using Stored Procedure
		/// and return a DataTable containing all ResearchChairs Data
		/// </summary>
		public DataTable GetAllResearchChairs(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "ResearchChairs";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllResearchChairs" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["ResearchChairs"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all ResearchChairs using Stored Procedure
		/// and return a DataTable containing all ResearchChairs Data using a Transaction
		/// </summary>
		public DataTable GetAllResearchChairs(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "ResearchChairs";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllResearchChairs" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["ResearchChairs"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From ResearchChairs using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDResearchChairs( int researchChairId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDResearchChairs");
				    Database.AddInParameter(command,"ResearchChairId",DbType.Int32,researchChairId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From ResearchChairs using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDResearchChairs( int researchChairId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDResearchChairs");
				    Database.AddInParameter(command,"ResearchChairId",DbType.Int32,researchChairId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into ResearchChairs using Stored Procedure
		/// and return the auto number primary key of ResearchChairs inserted row
		/// </summary>
		public bool InsertNewResearchChairs( ref int researchChairId,  string name,  string description,  string phone1,  string phone2,  string fax1,  string fax2)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewResearchChairs");
				Database.AddOutParameter(command,"ResearchChairId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"Name",DbType.String,name);
				Database.AddInParameter(command,"Description",DbType.String,description);
				Database.AddInParameter(command,"Phone1",DbType.String,phone1);
				Database.AddInParameter(command,"Phone2",DbType.String,phone2);
				Database.AddInParameter(command,"Fax1",DbType.String,fax1);
				Database.AddInParameter(command,"Fax2",DbType.String,fax2);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 researchChairId = Convert.ToInt32(Database.GetParameterValue(command, "ResearchChairId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into ResearchChairs using Stored Procedure
		/// and return the auto number primary key of ResearchChairs inserted row using Transaction
		/// </summary>
		public bool InsertNewResearchChairs( ref int researchChairId,  string name,  string description,  string phone1,  string phone2,  string fax1,  string fax2,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewResearchChairs");
				Database.AddOutParameter(command,"ResearchChairId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"Name",DbType.String,name);
				Database.AddInParameter(command,"Description",DbType.String,description);
				Database.AddInParameter(command,"Phone1",DbType.String,phone1);
				Database.AddInParameter(command,"Phone2",DbType.String,phone2);
				Database.AddInParameter(command,"Fax1",DbType.String,fax1);
				Database.AddInParameter(command,"Fax2",DbType.String,fax2);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 researchChairId = Convert.ToInt32(Database.GetParameterValue(command, "ResearchChairId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for ResearchChairs using Stored Procedure
		/// and return DbCommand of the ResearchChairs
		/// </summary>
		public DbCommand InsertNewResearchChairsCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewResearchChairs");

				Database.AddInParameter(command,"Name",DbType.String,"Name",DataRowVersion.Current);
				Database.AddInParameter(command,"Description",DbType.String,"Description",DataRowVersion.Current);
				Database.AddInParameter(command,"Phone1",DbType.String,"Phone1",DataRowVersion.Current);
				Database.AddInParameter(command,"Phone2",DbType.String,"Phone2",DataRowVersion.Current);
				Database.AddInParameter(command,"Fax1",DbType.String,"Fax1",DataRowVersion.Current);
				Database.AddInParameter(command,"Fax2",DbType.String,"Fax2",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into ResearchChairs using Stored Procedure
		/// </summary>
		public bool UpdateResearchChairs( string name, string description, string phone1, string phone2, string fax1, string fax2, int oldresearchChairId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateResearchChairs");

		    		Database.AddInParameter(command,"Name",DbType.String,name);
		    		Database.AddInParameter(command,"Description",DbType.String,description);
		    		Database.AddInParameter(command,"Phone1",DbType.String,phone1);
		    		Database.AddInParameter(command,"Phone2",DbType.String,phone2);
		    		Database.AddInParameter(command,"Fax1",DbType.String,fax1);
		    		Database.AddInParameter(command,"Fax2",DbType.String,fax2);
				Database.AddInParameter(command,"oldResearchChairId",DbType.Int32,oldresearchChairId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into ResearchChairs using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateResearchChairs( string name, string description, string phone1, string phone2, string fax1, string fax2, int oldresearchChairId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateResearchChairs");

		    		Database.AddInParameter(command,"Name",DbType.String,name);
		    		Database.AddInParameter(command,"Description",DbType.String,description);
		    		Database.AddInParameter(command,"Phone1",DbType.String,phone1);
		    		Database.AddInParameter(command,"Phone2",DbType.String,phone2);
		    		Database.AddInParameter(command,"Fax1",DbType.String,fax1);
		    		Database.AddInParameter(command,"Fax2",DbType.String,fax2);
				Database.AddInParameter(command,"oldResearchChairId",DbType.Int32,oldresearchChairId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from ResearchChairs using Stored Procedure
		/// </summary>
		public DbCommand UpdateResearchChairsCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateResearchChairs");

		    		Database.AddInParameter(command,"Name",DbType.String,"Name",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Description",DbType.String,"Description",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Phone1",DbType.String,"Phone1",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Phone2",DbType.String,"Phone2",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Fax1",DbType.String,"Fax1",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Fax2",DbType.String,"Fax2",DataRowVersion.Current);
				Database.AddInParameter(command,"oldResearchChairId",DbType.Int32,"ResearchChairId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From ResearchChairs using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteResearchChairs( int researchChairId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteResearchChairs");
			Database.AddInParameter(command,"ResearchChairId",DbType.Int32,researchChairId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From ResearchChairs Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteResearchChairsCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteResearchChairs");
				Database.AddInParameter(command,"ResearchChairId",DbType.Int32,"ResearchChairId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table ResearchChairs using Stored Procedure
		/// and return number of rows effected of the ResearchChairs
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"ResearchChairs",InsertNewResearchChairsCommand(),UpdateResearchChairsCommand(),DeleteResearchChairsCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table ResearchChairs using Stored Procedure
		/// and return number of rows effected of the ResearchChairs
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"ResearchChairs",InsertNewResearchChairsCommand(),UpdateResearchChairsCommand(),DeleteResearchChairsCommand(), transaction);
          return rowsAffected;
		}


	}
}
