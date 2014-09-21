using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.BedManagement
{
	/// <summary>
	/// This is a Data Access Class  for AdmissionStayType table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the AdmissionStayType table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class AdmissionStayTypeDAC : DataAccessComponent
	{
		#region Constructors
		public AdmissionStayTypeDAC(){}
		public AdmissionStayTypeDAC(string connectionString): base(connectionString){}
		public AdmissionStayTypeDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all AdmissionStayType using Stored Procedure
		/// and return a DataTable containing all AdmissionStayType Data
		/// </summary>
		public DataTable GetAllAdmissionStayType()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "AdmissionStayType";
         string query = " select * from GetAllAdmissionStayType";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["AdmissionStayType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all AdmissionStayType using Stored Procedure
		/// and return a DataTable containing all AdmissionStayType Data using a Transaction
		/// </summary>
		public DataTable GetAllAdmissionStayType(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "AdmissionStayType";
         string query = " select * from GetAllAdmissionStayType";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["AdmissionStayType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all AdmissionStayType using Stored Procedure
		/// and return a DataTable containing all AdmissionStayType Data
		/// </summary>
		public DataTable GetAllAdmissionStayType(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "AdmissionStayType";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllAdmissionStayType" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["AdmissionStayType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all AdmissionStayType using Stored Procedure
		/// and return a DataTable containing all AdmissionStayType Data using a Transaction
		/// </summary>
		public DataTable GetAllAdmissionStayType(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "AdmissionStayType";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllAdmissionStayType" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["AdmissionStayType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From AdmissionStayType using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDAdmissionStayType( int admissionStayTypeId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDAdmissionStayType");
				    Database.AddInParameter(command,"AdmissionStayTypeId",DbType.Int32,admissionStayTypeId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From AdmissionStayType using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDAdmissionStayType( int admissionStayTypeId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDAdmissionStayType");
				    Database.AddInParameter(command,"AdmissionStayTypeId",DbType.Int32,admissionStayTypeId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into AdmissionStayType using Stored Procedure
		/// and return the auto number primary key of AdmissionStayType inserted row
		/// </summary>
		public bool InsertNewAdmissionStayType( ref int admissionStayTypeId,  string name,  int duration,  string code,  int admissionStayOrder)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewAdmissionStayType");
				Database.AddOutParameter(command,"AdmissionStayTypeId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"Name",DbType.String,name);
				Database.AddInParameter(command,"Duration",DbType.Int32,duration);
				Database.AddInParameter(command,"Code",DbType.String,code);
				Database.AddInParameter(command,"AdmissionStayOrder",DbType.Int32,admissionStayOrder);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 admissionStayTypeId = Convert.ToInt32(Database.GetParameterValue(command, "AdmissionStayTypeId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into AdmissionStayType using Stored Procedure
		/// and return the auto number primary key of AdmissionStayType inserted row using Transaction
		/// </summary>
		public bool InsertNewAdmissionStayType( ref int admissionStayTypeId,  string name,  int duration,  string code,  int admissionStayOrder,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewAdmissionStayType");
				Database.AddOutParameter(command,"AdmissionStayTypeId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"Name",DbType.String,name);
				Database.AddInParameter(command,"Duration",DbType.Int32,duration);
				Database.AddInParameter(command,"Code",DbType.String,code);
				Database.AddInParameter(command,"AdmissionStayOrder",DbType.Int32,admissionStayOrder);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 admissionStayTypeId = Convert.ToInt32(Database.GetParameterValue(command, "AdmissionStayTypeId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for AdmissionStayType using Stored Procedure
		/// and return DbCommand of the AdmissionStayType
		/// </summary>
		public DbCommand InsertNewAdmissionStayTypeCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewAdmissionStayType");

				Database.AddInParameter(command,"Name",DbType.String,"Name",DataRowVersion.Current);
				Database.AddInParameter(command,"Duration",DbType.Int32,"Duration",DataRowVersion.Current);
				Database.AddInParameter(command,"Code",DbType.String,"Code",DataRowVersion.Current);
				Database.AddInParameter(command,"AdmissionStayOrder",DbType.Int32,"AdmissionStayOrder",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into AdmissionStayType using Stored Procedure
		/// </summary>
		public bool UpdateAdmissionStayType( string name, int duration, string code, int admissionStayOrder, int oldadmissionStayTypeId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateAdmissionStayType");

		    		Database.AddInParameter(command,"Name",DbType.String,name);
		    		Database.AddInParameter(command,"Duration",DbType.Int32,duration);
		    		Database.AddInParameter(command,"Code",DbType.String,code);
		    		Database.AddInParameter(command,"AdmissionStayOrder",DbType.Int32,admissionStayOrder);
				Database.AddInParameter(command,"oldAdmissionStayTypeId",DbType.Int32,oldadmissionStayTypeId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into AdmissionStayType using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateAdmissionStayType( string name, int duration, string code, int admissionStayOrder, int oldadmissionStayTypeId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateAdmissionStayType");

		    		Database.AddInParameter(command,"Name",DbType.String,name);
		    		Database.AddInParameter(command,"Duration",DbType.Int32,duration);
		    		Database.AddInParameter(command,"Code",DbType.String,code);
		    		Database.AddInParameter(command,"AdmissionStayOrder",DbType.Int32,admissionStayOrder);
				Database.AddInParameter(command,"oldAdmissionStayTypeId",DbType.Int32,oldadmissionStayTypeId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from AdmissionStayType using Stored Procedure
		/// </summary>
		public DbCommand UpdateAdmissionStayTypeCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateAdmissionStayType");

		    		Database.AddInParameter(command,"Name",DbType.String,"Name",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Duration",DbType.Int32,"Duration",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Code",DbType.String,"Code",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AdmissionStayOrder",DbType.Int32,"AdmissionStayOrder",DataRowVersion.Current);
				Database.AddInParameter(command,"oldAdmissionStayTypeId",DbType.Int32,"AdmissionStayTypeId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From AdmissionStayType using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteAdmissionStayType( int admissionStayTypeId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteAdmissionStayType");
			Database.AddInParameter(command,"AdmissionStayTypeId",DbType.Int32,admissionStayTypeId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From AdmissionStayType Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteAdmissionStayTypeCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteAdmissionStayType");
				Database.AddInParameter(command,"AdmissionStayTypeId",DbType.Int32,"AdmissionStayTypeId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table AdmissionStayType using Stored Procedure
		/// and return number of rows effected of the AdmissionStayType
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"AdmissionStayType",InsertNewAdmissionStayTypeCommand(),UpdateAdmissionStayTypeCommand(),DeleteAdmissionStayTypeCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table AdmissionStayType using Stored Procedure
		/// and return number of rows effected of the AdmissionStayType
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"AdmissionStayType",InsertNewAdmissionStayTypeCommand(),UpdateAdmissionStayTypeCommand(),DeleteAdmissionStayTypeCommand(), transaction);
          return rowsAffected;
		}


	}
}
