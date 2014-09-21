using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.Eligibility
{
	/// <summary>
	/// This is a Data Access Class  for Hospital table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the Hospital table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class HospitalDAC : DataAccessComponent
	{
		#region Constructors
		public HospitalDAC(){}
		public HospitalDAC(string connectionString): base(connectionString){}
		public HospitalDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Hospital using Stored Procedure
		/// and return a DataTable containing all Hospital Data
		/// </summary>
		public DataTable GetAllHospital()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Hospital";
         string query = " select * from GetAllHospital";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["Hospital"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Hospital using Stored Procedure
		/// and return a DataTable containing all Hospital Data using a Transaction
		/// </summary>
		public DataTable GetAllHospital(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Hospital";
         string query = " select * from GetAllHospital";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["Hospital"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Hospital using Stored Procedure
		/// and return a DataTable containing all Hospital Data
		/// </summary>
		public DataTable GetAllHospital(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Hospital";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllHospital" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["Hospital"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Hospital using Stored Procedure
		/// and return a DataTable containing all Hospital Data using a Transaction
		/// </summary>
		public DataTable GetAllHospital(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Hospital";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllHospital" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["Hospital"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From Hospital using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDHospital( int eligibilityHospitalID)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDHospital");
				    Database.AddInParameter(command,"EligibilityHospitalID",DbType.Int32,eligibilityHospitalID);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From Hospital using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDHospital( int eligibilityHospitalID,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDHospital");
				    Database.AddInParameter(command,"EligibilityHospitalID",DbType.Int32,eligibilityHospitalID);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into Hospital using Stored Procedure
		/// and return the auto number primary key of Hospital inserted row
		/// </summary>
		public bool InsertNewHospital( ref int eligibilityHospitalID,  string hospitalName,  string phone,  string fax,  string email,  string siteURL,  int userID)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewHospital");
				Database.AddOutParameter(command,"EligibilityHospitalID",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"HospitalName",DbType.String,hospitalName);
				Database.AddInParameter(command,"Phone",DbType.String,phone);
				Database.AddInParameter(command,"Fax",DbType.String,fax);
				Database.AddInParameter(command,"Email",DbType.String,email);
				Database.AddInParameter(command,"SiteURL",DbType.String,siteURL);
				Database.AddInParameter(command,"UserID",DbType.Int32,userID);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 eligibilityHospitalID = Convert.ToInt32(Database.GetParameterValue(command, "EligibilityHospitalID"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into Hospital using Stored Procedure
		/// and return the auto number primary key of Hospital inserted row using Transaction
		/// </summary>
		public bool InsertNewHospital( ref int eligibilityHospitalID,  string hospitalName,  string phone,  string fax,  string email,  string siteURL,  int userID,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewHospital");
				Database.AddOutParameter(command,"EligibilityHospitalID",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"HospitalName",DbType.String,hospitalName);
				Database.AddInParameter(command,"Phone",DbType.String,phone);
				Database.AddInParameter(command,"Fax",DbType.String,fax);
				Database.AddInParameter(command,"Email",DbType.String,email);
				Database.AddInParameter(command,"SiteURL",DbType.String,siteURL);
				Database.AddInParameter(command,"UserID",DbType.Int32,userID);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 eligibilityHospitalID = Convert.ToInt32(Database.GetParameterValue(command, "EligibilityHospitalID"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for Hospital using Stored Procedure
		/// and return DbCommand of the Hospital
		/// </summary>
		public DbCommand InsertNewHospitalCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewHospital");

				Database.AddInParameter(command,"HospitalName",DbType.String,"HospitalName",DataRowVersion.Current);
				Database.AddInParameter(command,"Phone",DbType.String,"Phone",DataRowVersion.Current);
				Database.AddInParameter(command,"Fax",DbType.String,"Fax",DataRowVersion.Current);
				Database.AddInParameter(command,"Email",DbType.String,"Email",DataRowVersion.Current);
				Database.AddInParameter(command,"SiteURL",DbType.String,"SiteURL",DataRowVersion.Current);
				Database.AddInParameter(command,"UserID",DbType.Int32,"UserID",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into Hospital using Stored Procedure
		/// </summary>
		public bool UpdateHospital( string hospitalName, string phone, string fax, string email, string siteURL, int userID, int oldeligibilityHospitalID)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateHospital");

		    		Database.AddInParameter(command,"HospitalName",DbType.String,hospitalName);
		    		Database.AddInParameter(command,"Phone",DbType.String,phone);
		    		Database.AddInParameter(command,"Fax",DbType.String,fax);
		    		Database.AddInParameter(command,"Email",DbType.String,email);
		    		Database.AddInParameter(command,"SiteURL",DbType.String,siteURL);
		    		Database.AddInParameter(command,"UserID",DbType.Int32,userID);
				Database.AddInParameter(command,"oldEligibilityHospitalID",DbType.Int32,oldeligibilityHospitalID);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into Hospital using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateHospital( string hospitalName, string phone, string fax, string email, string siteURL, int userID, int oldeligibilityHospitalID,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateHospital");

		    		Database.AddInParameter(command,"HospitalName",DbType.String,hospitalName);
		    		Database.AddInParameter(command,"Phone",DbType.String,phone);
		    		Database.AddInParameter(command,"Fax",DbType.String,fax);
		    		Database.AddInParameter(command,"Email",DbType.String,email);
		    		Database.AddInParameter(command,"SiteURL",DbType.String,siteURL);
		    		Database.AddInParameter(command,"UserID",DbType.Int32,userID);
				Database.AddInParameter(command,"oldEligibilityHospitalID",DbType.Int32,oldeligibilityHospitalID);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from Hospital using Stored Procedure
		/// </summary>
		public DbCommand UpdateHospitalCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateHospital");

		    		Database.AddInParameter(command,"HospitalName",DbType.String,"HospitalName",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Phone",DbType.String,"Phone",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Fax",DbType.String,"Fax",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Email",DbType.String,"Email",DataRowVersion.Current);
		    		Database.AddInParameter(command,"SiteURL",DbType.String,"SiteURL",DataRowVersion.Current);
		    		Database.AddInParameter(command,"UserID",DbType.Int32,"UserID",DataRowVersion.Current);
				Database.AddInParameter(command,"oldEligibilityHospitalID",DbType.Int32,"EligibilityHospitalID",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From Hospital using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteHospital( int eligibilityHospitalID)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteHospital");
			Database.AddInParameter(command,"EligibilityHospitalID",DbType.Int32,eligibilityHospitalID);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From Hospital Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteHospitalCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteHospital");
				Database.AddInParameter(command,"EligibilityHospitalID",DbType.Int32,"EligibilityHospitalID",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table Hospital using Stored Procedure
		/// and return number of rows effected of the Hospital
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"Hospital",InsertNewHospitalCommand(),UpdateHospitalCommand(),DeleteHospitalCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table Hospital using Stored Procedure
		/// and return number of rows effected of the Hospital
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"Hospital",InsertNewHospitalCommand(),UpdateHospitalCommand(),DeleteHospitalCommand(), transaction);
          return rowsAffected;
		}


	}
}
