using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.Eligibility
{
	/// <summary>
	/// This is a Data Access Class  for EligibilityConsultant table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the EligibilityConsultant table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class EligibilityConsultantDAC : DataAccessComponent
	{
		#region Constructors
		public EligibilityConsultantDAC(){}
		public EligibilityConsultantDAC(string connectionString): base(connectionString){}
		public EligibilityConsultantDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibilityConsultant using Stored Procedure
		/// and return a DataTable containing all EligibilityConsultant Data
		/// </summary>
		public DataTable GetAllEligibilityConsultant()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibilityConsultant";
         string query = " select * from GetAllEligibilityConsultant";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["EligibilityConsultant"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibilityConsultant using Stored Procedure
		/// and return a DataTable containing all EligibilityConsultant Data using a Transaction
		/// </summary>
		public DataTable GetAllEligibilityConsultant(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibilityConsultant";
         string query = " select * from GetAllEligibilityConsultant";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["EligibilityConsultant"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibilityConsultant using Stored Procedure
		/// and return a DataTable containing all EligibilityConsultant Data
		/// </summary>
		public DataTable GetAllEligibilityConsultant(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibilityConsultant";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllEligibilityConsultant" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["EligibilityConsultant"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibilityConsultant using Stored Procedure
		/// and return a DataTable containing all EligibilityConsultant Data using a Transaction
		/// </summary>
		public DataTable GetAllEligibilityConsultant(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibilityConsultant";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllEligibilityConsultant" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["EligibilityConsultant"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From EligibilityConsultant using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDEligibilityConsultant( int eligibilityConsultantId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDEligibilityConsultant");
				    Database.AddInParameter(command,"EligibilityConsultantId",DbType.Int32,eligibilityConsultantId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From EligibilityConsultant using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDEligibilityConsultant( int eligibilityConsultantId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDEligibilityConsultant");
				    Database.AddInParameter(command,"EligibilityConsultantId",DbType.Int32,eligibilityConsultantId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into EligibilityConsultant using Stored Procedure
		/// and return the auto number primary key of EligibilityConsultant inserted row
		/// </summary>
		public bool InsertNewEligibilityConsultant( ref int eligibilityConsultantId,  int eligibilityDepartmentId,int DivisionID,  int personId,  DateTime dateAssigned,string Position)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligibilityConsultant");
				Database.AddOutParameter(command,"EligibilityConsultantId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"EligibilityDepartmentId",DbType.Int32,eligibilityDepartmentId);
                Database.AddInParameter(command, "DivisionID", DbType.Int32, DivisionID);
				Database.AddInParameter(command,"PersonId",DbType.Int32,personId);
				Database.AddInParameter(command,"DateAssigned",DbType.DateTime,dateAssigned);
                Database.AddInParameter(command, "Position", DbType.DateTime, Position);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 eligibilityConsultantId = Convert.ToInt32(Database.GetParameterValue(command, "EligibilityConsultantId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into EligibilityConsultant using Stored Procedure
		/// and return the auto number primary key of EligibilityConsultant inserted row using Transaction
		/// </summary>
		public bool InsertNewEligibilityConsultant( ref int eligibilityConsultantId,  int eligibilityDepartmentId,int DivisionID,  int personId,  DateTime dateAssigned,string Position,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligibilityConsultant");
				Database.AddOutParameter(command,"EligibilityConsultantId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"EligibilityDepartmentId",DbType.Int32,eligibilityDepartmentId);
				Database.AddInParameter(command,"PersonId",DbType.Int32,personId);
				Database.AddInParameter(command,"DateAssigned",DbType.DateTime,dateAssigned);
                Database.AddInParameter(command, "DivisionID", DbType.Int32, DivisionID);
                Database.AddInParameter(command, "PersonId", DbType.Int32, personId);
                Database.AddInParameter(command, "DateAssigned", DbType.DateTime, dateAssigned);
                Database.AddInParameter(command, "Position", DbType.DateTime, Position);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 eligibilityConsultantId = Convert.ToInt32(Database.GetParameterValue(command, "EligibilityConsultantId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for EligibilityConsultant using Stored Procedure
		/// and return DbCommand of the EligibilityConsultant
		/// </summary>
		public DbCommand InsertNewEligibilityConsultantCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligibilityConsultant");

				Database.AddInParameter(command,"EligibilityDepartmentId",DbType.Int32,"EligibilityDepartmentId",DataRowVersion.Current);
				Database.AddInParameter(command,"PersonId",DbType.Int32,"PersonId",DataRowVersion.Current);
				Database.AddInParameter(command,"DateAssigned",DbType.DateTime,"DateAssigned",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into EligibilityConsultant using Stored Procedure
		/// </summary>
		public bool UpdateEligibilityConsultant( int eligibilityDepartmentId,int DivisionID, int personId, DateTime dateAssigned,string Position, int oldeligibilityConsultantId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligibilityConsultant");

		    		Database.AddInParameter(command,"EligibilityDepartmentId",DbType.Int32,eligibilityDepartmentId);
                    Database.AddInParameter(command, "EligibilityDepartmentId", DbType.Int32, eligibilityDepartmentId);
                    Database.AddInParameter(command, "PersonId", DbType.Int32, personId);
                    Database.AddInParameter(command, "DateAssigned", DbType.DateTime, dateAssigned);
                    Database.AddInParameter(command, "DivisionID", DbType.Int32, DivisionID);
                    Database.AddInParameter(command, "PersonId", DbType.Int32, personId);
                    Database.AddInParameter(command, "DateAssigned", DbType.DateTime, dateAssigned);
                    Database.AddInParameter(command, "Position", DbType.DateTime, Position);
				Database.AddInParameter(command,"oldEligibilityConsultantId",DbType.Int32,oldeligibilityConsultantId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into EligibilityConsultant using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateEligibilityConsultant( int eligibilityDepartmentId,int DivisionID, int personId, DateTime dateAssigned,string Position, int oldeligibilityConsultantId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligibilityConsultant");

		    		Database.AddInParameter(command,"EligibilityDepartmentId",DbType.Int32,eligibilityDepartmentId);
                    
                    Database.AddInParameter(command, "PersonId", DbType.Int32, personId);
                    Database.AddInParameter(command, "DateAssigned", DbType.DateTime, dateAssigned);
                    Database.AddInParameter(command, "DivisionID", DbType.Int32, DivisionID);
                    Database.AddInParameter(command, "PersonId", DbType.Int32, personId);
                    Database.AddInParameter(command, "DateAssigned", DbType.DateTime, dateAssigned);
                    Database.AddInParameter(command, "Position", DbType.DateTime, Position);
				Database.AddInParameter(command,"oldEligibilityConsultantId",DbType.Int32,oldeligibilityConsultantId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from EligibilityConsultant using Stored Procedure
		/// </summary>
		public DbCommand UpdateEligibilityConsultantCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligibilityConsultant");

		    		Database.AddInParameter(command,"EligibilityDepartmentId",DbType.Int32,"EligibilityDepartmentId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"PersonId",DbType.Int32,"PersonId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"DateAssigned",DbType.DateTime,"DateAssigned",DataRowVersion.Current);
				Database.AddInParameter(command,"oldEligibilityConsultantId",DbType.Int32,"EligibilityConsultantId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From EligibilityConsultant using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteEligibilityConsultant( int eligibilityConsultantId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteEligibilityConsultant");
			Database.AddInParameter(command,"EligibilityConsultantId",DbType.Int32,eligibilityConsultantId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From EligibilityConsultant Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteEligibilityConsultantCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteEligibilityConsultant");
				Database.AddInParameter(command,"EligibilityConsultantId",DbType.Int32,"EligibilityConsultantId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table EligibilityConsultant using Stored Procedure
		/// and return number of rows effected of the EligibilityConsultant
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"EligibilityConsultant",InsertNewEligibilityConsultantCommand(),UpdateEligibilityConsultantCommand(),DeleteEligibilityConsultantCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table EligibilityConsultant using Stored Procedure
		/// and return number of rows effected of the EligibilityConsultant
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"EligibilityConsultant",InsertNewEligibilityConsultantCommand(),UpdateEligibilityConsultantCommand(),DeleteEligibilityConsultantCommand(), transaction);
          return rowsAffected;
		}


	}
}
