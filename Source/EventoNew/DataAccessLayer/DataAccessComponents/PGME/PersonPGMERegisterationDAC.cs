using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.PGME
{
	/// <summary>
	/// This is a Data Access Class  for PersonPGMERegisteration table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the PersonPGMERegisteration table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class PersonPGMERegisterationDAC : DataAccessComponent
	{
		#region Constructors
		public PersonPGMERegisterationDAC(){}
		public PersonPGMERegisterationDAC(string connectionString): base(connectionString){}
		public PersonPGMERegisterationDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all PersonPGMERegisteration using Stored Procedure
		/// and return a DataTable containing all PersonPGMERegisteration Data
		/// </summary>
		public DataTable GetAllPersonPGMERegisteration()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "PersonPGMERegisteration";
         string query = " select * from GetAllPersonPGMERegisteration";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["PersonPGMERegisteration"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all PersonPGMERegisteration using Stored Procedure
		/// and return a DataTable containing all PersonPGMERegisteration Data using a Transaction
		/// </summary>
		public DataTable GetAllPersonPGMERegisteration(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "PersonPGMERegisteration";
         string query = " select * from GetAllPersonPGMERegisteration";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["PersonPGMERegisteration"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all PersonPGMERegisteration using Stored Procedure
		/// and return a DataTable containing all PersonPGMERegisteration Data
		/// </summary>
		public DataTable GetAllPersonPGMERegisteration(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "PersonPGMERegisteration";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllPersonPGMERegisteration" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["PersonPGMERegisteration"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all PersonPGMERegisteration using Stored Procedure
		/// and return a DataTable containing all PersonPGMERegisteration Data using a Transaction
		/// </summary>
		public DataTable GetAllPersonPGMERegisteration(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "PersonPGMERegisteration";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllPersonPGMERegisteration" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["PersonPGMERegisteration"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From PersonPGMERegisteration using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDPersonPGMERegisteration( int personRegisterationId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDPersonPGMERegisteration");
				    Database.AddInParameter(command,"PersonRegisterationId",DbType.Int32,personRegisterationId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From PersonPGMERegisteration using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDPersonPGMERegisteration( int personRegisterationId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDPersonPGMERegisteration");
				    Database.AddInParameter(command,"PersonRegisterationId",DbType.Int32,personRegisterationId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into PersonPGMERegisteration using Stored Procedure
		/// and return the auto number primary key of PersonPGMERegisteration inserted row
		/// </summary>
		public bool InsertNewPersonPGMERegisteration( ref int personRegisterationId,  int personId,  int personProgramId,  int personRegisterationStatusId,  string registerationNumber,  string uniRegisterationNumber)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewPersonPGMERegisteration");
				Database.AddOutParameter(command,"PersonRegisterationId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"PersonId",DbType.Int32,personId);
				Database.AddInParameter(command,"PersonProgramId",DbType.Int32,personProgramId);
				Database.AddInParameter(command,"PersonRegisterationStatusId",DbType.Int32,personRegisterationStatusId);
				Database.AddInParameter(command,"RegisterationNumber",DbType.String,registerationNumber);
				Database.AddInParameter(command,"UniRegisterationNumber",DbType.String,uniRegisterationNumber);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 personRegisterationId = Convert.ToInt32(Database.GetParameterValue(command, "PersonRegisterationId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into PersonPGMERegisteration using Stored Procedure
		/// and return the auto number primary key of PersonPGMERegisteration inserted row using Transaction
		/// </summary>
		public bool InsertNewPersonPGMERegisteration( ref int personRegisterationId,  int personId,  int personProgramId,  int personRegisterationStatusId,  string registerationNumber,  string uniRegisterationNumber,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewPersonPGMERegisteration");
				Database.AddOutParameter(command,"PersonRegisterationId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"PersonId",DbType.Int32,personId);
				Database.AddInParameter(command,"PersonProgramId",DbType.Int32,personProgramId);
				Database.AddInParameter(command,"PersonRegisterationStatusId",DbType.Int32,personRegisterationStatusId);
				Database.AddInParameter(command,"RegisterationNumber",DbType.String,registerationNumber);
				Database.AddInParameter(command,"UniRegisterationNumber",DbType.String,uniRegisterationNumber);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 personRegisterationId = Convert.ToInt32(Database.GetParameterValue(command, "PersonRegisterationId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for PersonPGMERegisteration using Stored Procedure
		/// and return DbCommand of the PersonPGMERegisteration
		/// </summary>
		public DbCommand InsertNewPersonPGMERegisterationCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewPersonPGMERegisteration");

				Database.AddInParameter(command,"PersonId",DbType.Int32,"PersonId",DataRowVersion.Current);
				Database.AddInParameter(command,"PersonProgramId",DbType.Int32,"PersonProgramId",DataRowVersion.Current);
				Database.AddInParameter(command,"PersonRegisterationStatusId",DbType.Int32,"PersonRegisterationStatusId",DataRowVersion.Current);
				Database.AddInParameter(command,"RegisterationNumber",DbType.String,"RegisterationNumber",DataRowVersion.Current);
				Database.AddInParameter(command,"UniRegisterationNumber",DbType.String,"UniRegisterationNumber",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into PersonPGMERegisteration using Stored Procedure
		/// </summary>
		public bool UpdatePersonPGMERegisteration( int personId, int personProgramId, int personRegisterationStatusId, string registerationNumber, string uniRegisterationNumber, int oldpersonRegisterationId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdatePersonPGMERegisteration");

		    		Database.AddInParameter(command,"PersonId",DbType.Int32,personId);
		    		Database.AddInParameter(command,"PersonProgramId",DbType.Int32,personProgramId);
		    		Database.AddInParameter(command,"PersonRegisterationStatusId",DbType.Int32,personRegisterationStatusId);
		    		Database.AddInParameter(command,"RegisterationNumber",DbType.String,registerationNumber);
		    		Database.AddInParameter(command,"UniRegisterationNumber",DbType.String,uniRegisterationNumber);
				Database.AddInParameter(command,"oldPersonRegisterationId",DbType.Int32,oldpersonRegisterationId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into PersonPGMERegisteration using Stored Procedure By Transaction
		/// </summary>
		public bool UpdatePersonPGMERegisteration( int personId, int personProgramId, int personRegisterationStatusId, string registerationNumber, string uniRegisterationNumber, int oldpersonRegisterationId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdatePersonPGMERegisteration");

		    		Database.AddInParameter(command,"PersonId",DbType.Int32,personId);
		    		Database.AddInParameter(command,"PersonProgramId",DbType.Int32,personProgramId);
		    		Database.AddInParameter(command,"PersonRegisterationStatusId",DbType.Int32,personRegisterationStatusId);
		    		Database.AddInParameter(command,"RegisterationNumber",DbType.String,registerationNumber);
		    		Database.AddInParameter(command,"UniRegisterationNumber",DbType.String,uniRegisterationNumber);
				Database.AddInParameter(command,"oldPersonRegisterationId",DbType.Int32,oldpersonRegisterationId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from PersonPGMERegisteration using Stored Procedure
		/// </summary>
		public DbCommand UpdatePersonPGMERegisterationCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdatePersonPGMERegisteration");

		    		Database.AddInParameter(command,"PersonId",DbType.Int32,"PersonId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"PersonProgramId",DbType.Int32,"PersonProgramId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"PersonRegisterationStatusId",DbType.Int32,"PersonRegisterationStatusId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"RegisterationNumber",DbType.String,"RegisterationNumber",DataRowVersion.Current);
		    		Database.AddInParameter(command,"UniRegisterationNumber",DbType.String,"UniRegisterationNumber",DataRowVersion.Current);
				Database.AddInParameter(command,"oldPersonRegisterationId",DbType.Int32,"PersonRegisterationId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From PersonPGMERegisteration using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeletePersonPGMERegisteration( int personRegisterationId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeletePersonPGMERegisteration");
			Database.AddInParameter(command,"PersonRegisterationId",DbType.Int32,personRegisterationId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From PersonPGMERegisteration Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeletePersonPGMERegisterationCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeletePersonPGMERegisteration");
				Database.AddInParameter(command,"PersonRegisterationId",DbType.Int32,"PersonRegisterationId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table PersonPGMERegisteration using Stored Procedure
		/// and return number of rows effected of the PersonPGMERegisteration
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"PersonPGMERegisteration",InsertNewPersonPGMERegisterationCommand(),UpdatePersonPGMERegisterationCommand(),DeletePersonPGMERegisterationCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table PersonPGMERegisteration using Stored Procedure
		/// and return number of rows effected of the PersonPGMERegisteration
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"PersonPGMERegisteration",InsertNewPersonPGMERegisterationCommand(),UpdatePersonPGMERegisterationCommand(),DeletePersonPGMERegisterationCommand(), transaction);
          return rowsAffected;
		}


	}
}
