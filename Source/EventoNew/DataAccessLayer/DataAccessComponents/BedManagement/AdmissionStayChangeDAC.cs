using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.BedManagement
{
	/// <summary>
	/// This is a Data Access Class  for AdmissionStayChange table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the AdmissionStayChange table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class AdmissionStayChangeDAC : DataAccessComponent
	{
		#region Constructors
		public AdmissionStayChangeDAC(){}
		public AdmissionStayChangeDAC(string connectionString): base(connectionString){}
		public AdmissionStayChangeDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all AdmissionStayChange using Stored Procedure
		/// and return a DataTable containing all AdmissionStayChange Data
		/// </summary>
		public DataTable GetAllAdmissionStayChange()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "AdmissionStayChange";
         string query = " select * from GetAllAdmissionStayChange";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["AdmissionStayChange"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all AdmissionStayChange using Stored Procedure
		/// and return a DataTable containing all AdmissionStayChange Data using a Transaction
		/// </summary>
		public DataTable GetAllAdmissionStayChange(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "AdmissionStayChange";
         string query = " select * from GetAllAdmissionStayChange";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["AdmissionStayChange"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all AdmissionStayChange using Stored Procedure
		/// and return a DataTable containing all AdmissionStayChange Data
		/// </summary>
		public DataTable GetAllAdmissionStayChange(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "AdmissionStayChange";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllAdmissionStayChange" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["AdmissionStayChange"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all AdmissionStayChange using Stored Procedure
		/// and return a DataTable containing all AdmissionStayChange Data using a Transaction
		/// </summary>
		public DataTable GetAllAdmissionStayChange(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "AdmissionStayChange";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllAdmissionStayChange" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["AdmissionStayChange"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From AdmissionStayChange using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDAdmissionStayChange( int admissionStayChangeId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDAdmissionStayChange");
				    Database.AddInParameter(command,"AdmissionStayChangeId",DbType.Int32,admissionStayChangeId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From AdmissionStayChange using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDAdmissionStayChange( int admissionStayChangeId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDAdmissionStayChange");
				    Database.AddInParameter(command,"AdmissionStayChangeId",DbType.Int32,admissionStayChangeId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into AdmissionStayChange using Stored Procedure
		/// and return the auto number primary key of AdmissionStayChange inserted row
		/// </summary>
		public bool InsertNewAdmissionStayChange( ref int admissionStayChangeId,  int patientAdmissionId,  int admissionStayTypeId,  DateTime modifiedDate)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewAdmissionStayChange");
				Database.AddOutParameter(command,"AdmissionStayChangeId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"PatientAdmissionId",DbType.Int32,patientAdmissionId);
				Database.AddInParameter(command,"AdmissionStayTypeId",DbType.Int32,admissionStayTypeId);
				Database.AddInParameter(command,"ModifiedDate",DbType.DateTime,modifiedDate);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 admissionStayChangeId = Convert.ToInt32(Database.GetParameterValue(command, "AdmissionStayChangeId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into AdmissionStayChange using Stored Procedure
		/// and return the auto number primary key of AdmissionStayChange inserted row using Transaction
		/// </summary>
		public bool InsertNewAdmissionStayChange( ref int admissionStayChangeId,  int patientAdmissionId,  int admissionStayTypeId,  DateTime modifiedDate,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewAdmissionStayChange");
				Database.AddOutParameter(command,"AdmissionStayChangeId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"PatientAdmissionId",DbType.Int32,patientAdmissionId);
				Database.AddInParameter(command,"AdmissionStayTypeId",DbType.Int32,admissionStayTypeId);
				Database.AddInParameter(command,"ModifiedDate",DbType.DateTime,modifiedDate);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 admissionStayChangeId = Convert.ToInt32(Database.GetParameterValue(command, "AdmissionStayChangeId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for AdmissionStayChange using Stored Procedure
		/// and return DbCommand of the AdmissionStayChange
		/// </summary>
		public DbCommand InsertNewAdmissionStayChangeCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewAdmissionStayChange");

				Database.AddInParameter(command,"PatientAdmissionId",DbType.Int32,"PatientAdmissionId",DataRowVersion.Current);
				Database.AddInParameter(command,"AdmissionStayTypeId",DbType.Int32,"AdmissionStayTypeId",DataRowVersion.Current);
				Database.AddInParameter(command,"ModifiedDate",DbType.DateTime,"ModifiedDate",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into AdmissionStayChange using Stored Procedure
		/// </summary>
		public bool UpdateAdmissionStayChange( int patientAdmissionId, int admissionStayTypeId, DateTime modifiedDate, int oldadmissionStayChangeId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateAdmissionStayChange");

		    		Database.AddInParameter(command,"PatientAdmissionId",DbType.Int32,patientAdmissionId);
		    		Database.AddInParameter(command,"AdmissionStayTypeId",DbType.Int32,admissionStayTypeId);
		    		Database.AddInParameter(command,"ModifiedDate",DbType.DateTime,modifiedDate);
				Database.AddInParameter(command,"oldAdmissionStayChangeId",DbType.Int32,oldadmissionStayChangeId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into AdmissionStayChange using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateAdmissionStayChange( int patientAdmissionId, int admissionStayTypeId, DateTime modifiedDate, int oldadmissionStayChangeId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateAdmissionStayChange");

		    		Database.AddInParameter(command,"PatientAdmissionId",DbType.Int32,patientAdmissionId);
		    		Database.AddInParameter(command,"AdmissionStayTypeId",DbType.Int32,admissionStayTypeId);
		    		Database.AddInParameter(command,"ModifiedDate",DbType.DateTime,modifiedDate);
				Database.AddInParameter(command,"oldAdmissionStayChangeId",DbType.Int32,oldadmissionStayChangeId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from AdmissionStayChange using Stored Procedure
		/// </summary>
		public DbCommand UpdateAdmissionStayChangeCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateAdmissionStayChange");

		    		Database.AddInParameter(command,"PatientAdmissionId",DbType.Int32,"PatientAdmissionId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AdmissionStayTypeId",DbType.Int32,"AdmissionStayTypeId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ModifiedDate",DbType.DateTime,"ModifiedDate",DataRowVersion.Current);
				Database.AddInParameter(command,"oldAdmissionStayChangeId",DbType.Int32,"AdmissionStayChangeId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From AdmissionStayChange using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteAdmissionStayChange( int admissionStayChangeId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteAdmissionStayChange");
			Database.AddInParameter(command,"AdmissionStayChangeId",DbType.Int32,admissionStayChangeId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From AdmissionStayChange Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteAdmissionStayChangeCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteAdmissionStayChange");
				Database.AddInParameter(command,"AdmissionStayChangeId",DbType.Int32,"AdmissionStayChangeId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table AdmissionStayChange using Stored Procedure
		/// and return number of rows effected of the AdmissionStayChange
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"AdmissionStayChange",InsertNewAdmissionStayChangeCommand(),UpdateAdmissionStayChangeCommand(),DeleteAdmissionStayChangeCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table AdmissionStayChange using Stored Procedure
		/// and return number of rows effected of the AdmissionStayChange
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"AdmissionStayChange",InsertNewAdmissionStayChangeCommand(),UpdateAdmissionStayChangeCommand(),DeleteAdmissionStayChangeCommand(), transaction);
          return rowsAffected;
		}


	}
}
