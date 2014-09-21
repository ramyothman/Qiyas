using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.BedManagement
{
	/// <summary>
	/// This is a Data Access Class  for Consultant table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the Consultant table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class ConsultantDAC : DataAccessComponent
	{
		#region Constructors
		public ConsultantDAC(){}
		public ConsultantDAC(string connectionString): base(connectionString){}
		public ConsultantDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Consultant using Stored Procedure
		/// and return a DataTable containing all Consultant Data
		/// </summary>
		public DataTable GetAllConsultant()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Consultant";
         string query = " select * from GetAllConsultant";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["Consultant"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Consultant using Stored Procedure
		/// and return a DataTable containing all Consultant Data using a Transaction
		/// </summary>
		public DataTable GetAllConsultant(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Consultant";
         string query = " select * from GetAllConsultant";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["Consultant"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Consultant using Stored Procedure
		/// and return a DataTable containing all Consultant Data
		/// </summary>
		public DataTable GetAllConsultant(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Consultant";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllConsultant" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["Consultant"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Consultant using Stored Procedure
		/// and return a DataTable containing all Consultant Data using a Transaction
		/// </summary>
		public DataTable GetAllConsultant(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Consultant";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllConsultant" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["Consultant"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From Consultant using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDConsultant( int consultantId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDConsultant");
				    Database.AddInParameter(command,"ConsultantId",DbType.Int32,consultantId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From Consultant using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDConsultant( int consultantId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDConsultant");
				    Database.AddInParameter(command,"ConsultantId",DbType.Int32,consultantId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into Consultant using Stored Procedure
		/// and return the auto number primary key of Consultant inserted row
		/// </summary>
		public bool InsertNewConsultant( int consultantId,  string consultantCode)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewConsultant");
				Database.AddInParameter(command,"ConsultantId",DbType.Int32,consultantId);
				Database.AddInParameter(command,"ConsultantCode",DbType.String,consultantCode);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into Consultant using Stored Procedure
		/// and return the auto number primary key of Consultant inserted row using Transaction
		/// </summary>
		public bool InsertNewConsultant( int consultantId,  string consultantCode,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewConsultant");
				Database.AddInParameter(command,"ConsultantId",DbType.Int32,consultantId);
				Database.AddInParameter(command,"ConsultantCode",DbType.String,consultantCode);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for Consultant using Stored Procedure
		/// and return DbCommand of the Consultant
		/// </summary>
		public DbCommand InsertNewConsultantCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewConsultant");
				Database.AddInParameter(command,"ConsultantId",DbType.Int32,"ConsultantId",DataRowVersion.Current);
				Database.AddInParameter(command,"ConsultantCode",DbType.String,"ConsultantCode",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into Consultant using Stored Procedure
		/// </summary>
		public bool UpdateConsultant( int consultantId, string consultantCode, int oldconsultantId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateConsultant");
		    		Database.AddInParameter(command,"ConsultantId",DbType.Int32,consultantId);
		    		Database.AddInParameter(command,"ConsultantCode",DbType.String,consultantCode);
				Database.AddInParameter(command,"oldConsultantId",DbType.Int32,oldconsultantId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into Consultant using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateConsultant( int consultantId, string consultantCode, int oldconsultantId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateConsultant");
		    		Database.AddInParameter(command,"ConsultantId",DbType.Int32,consultantId);
		    		Database.AddInParameter(command,"ConsultantCode",DbType.String,consultantCode);
				Database.AddInParameter(command,"oldConsultantId",DbType.Int32,oldconsultantId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from Consultant using Stored Procedure
		/// </summary>
		public DbCommand UpdateConsultantCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateConsultant");
		    		Database.AddInParameter(command,"ConsultantId",DbType.Int32,"ConsultantId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ConsultantCode",DbType.String,"ConsultantCode",DataRowVersion.Current);
				Database.AddInParameter(command,"oldConsultantId",DbType.Int32,"ConsultantId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From Consultant using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteConsultant( int consultantId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteConsultant");
			Database.AddInParameter(command,"ConsultantId",DbType.Int32,consultantId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From Consultant Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteConsultantCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteConsultant");
				Database.AddInParameter(command,"ConsultantId",DbType.Int32,"ConsultantId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table Consultant using Stored Procedure
		/// and return number of rows effected of the Consultant
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"Consultant",InsertNewConsultantCommand(),UpdateConsultantCommand(),DeleteConsultantCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table Consultant using Stored Procedure
		/// and return number of rows effected of the Consultant
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"Consultant",InsertNewConsultantCommand(),UpdateConsultantCommand(),DeleteConsultantCommand(), transaction);
          return rowsAffected;
		}


	}
}
