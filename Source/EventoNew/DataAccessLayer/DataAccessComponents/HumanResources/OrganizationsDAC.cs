using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.HumanResources
{
	/// <summary>
	/// This is a Data Access Class  for Organizations table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the Organizations table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class OrganizationsDAC : DataAccessComponent
	{
		#region Constructors
		public OrganizationsDAC(){}
		public OrganizationsDAC(string connectionString): base(connectionString){}
		public OrganizationsDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Organizations using Stored Procedure
		/// and return a DataTable containing all Organizations Data
		/// </summary>
		public DataTable GetAllOrganizations()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Organizations";
         string query = " select * from GetAllOrganizations";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["Organizations"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Organizations using Stored Procedure
		/// and return a DataTable containing all Organizations Data using a Transaction
		/// </summary>
		public DataTable GetAllOrganizations(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Organizations";
         string query = " select * from GetAllOrganizations";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["Organizations"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Organizations using Stored Procedure
		/// and return a DataTable containing all Organizations Data
		/// </summary>
		public DataTable GetAllOrganizations(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Organizations";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllOrganizations" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["Organizations"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Organizations using Stored Procedure
		/// and return a DataTable containing all Organizations Data using a Transaction
		/// </summary>
		public DataTable GetAllOrganizations(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Organizations";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllOrganizations" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["Organizations"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From Organizations using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDOrganizations( int organizationId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDOrganizations");
				    Database.AddInParameter(command,"OrganizationId",DbType.Int32,organizationId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From Organizations using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDOrganizations( int organizationId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDOrganizations");
				    Database.AddInParameter(command,"OrganizationId",DbType.Int32,organizationId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into Organizations using Stored Procedure
		/// and return the auto number primary key of Organizations inserted row
		/// </summary>
		public bool InsertNewOrganizations( ref int organizationId,  string organizationName,  string organizationDescription,  string phone1,  string phone2,  string phone3,  string fax1,  string fax2,  string addressLine1,  string addressLine2)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewOrganizations");
				Database.AddOutParameter(command,"OrganizationId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"OrganizationName",DbType.String,organizationName);
				Database.AddInParameter(command,"OrganizationDescription",DbType.String,organizationDescription);
				Database.AddInParameter(command,"Phone1",DbType.String,phone1);
				Database.AddInParameter(command,"Phone2",DbType.String,phone2);
				Database.AddInParameter(command,"Phone3",DbType.String,phone3);
				Database.AddInParameter(command,"Fax1",DbType.String,fax1);
				Database.AddInParameter(command,"Fax2",DbType.String,fax2);
				Database.AddInParameter(command,"AddressLine1",DbType.String,addressLine1);
				Database.AddInParameter(command,"AddressLine2",DbType.String,addressLine2);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 organizationId = Convert.ToInt32(Database.GetParameterValue(command, "OrganizationId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into Organizations using Stored Procedure
		/// and return the auto number primary key of Organizations inserted row using Transaction
		/// </summary>
		public bool InsertNewOrganizations( ref int organizationId,  string organizationName,  string organizationDescription,  string phone1,  string phone2,  string phone3,  string fax1,  string fax2,  string addressLine1,  string addressLine2,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewOrganizations");
				Database.AddOutParameter(command,"OrganizationId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"OrganizationName",DbType.String,organizationName);
				Database.AddInParameter(command,"OrganizationDescription",DbType.String,organizationDescription);
				Database.AddInParameter(command,"Phone1",DbType.String,phone1);
				Database.AddInParameter(command,"Phone2",DbType.String,phone2);
				Database.AddInParameter(command,"Phone3",DbType.String,phone3);
				Database.AddInParameter(command,"Fax1",DbType.String,fax1);
				Database.AddInParameter(command,"Fax2",DbType.String,fax2);
				Database.AddInParameter(command,"AddressLine1",DbType.String,addressLine1);
				Database.AddInParameter(command,"AddressLine2",DbType.String,addressLine2);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 organizationId = Convert.ToInt32(Database.GetParameterValue(command, "OrganizationId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for Organizations using Stored Procedure
		/// and return DbCommand of the Organizations
		/// </summary>
		public DbCommand InsertNewOrganizationsCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewOrganizations");

				Database.AddInParameter(command,"OrganizationName",DbType.String,"OrganizationName",DataRowVersion.Current);
				Database.AddInParameter(command,"OrganizationDescription",DbType.String,"OrganizationDescription",DataRowVersion.Current);
				Database.AddInParameter(command,"Phone1",DbType.String,"Phone1",DataRowVersion.Current);
				Database.AddInParameter(command,"Phone2",DbType.String,"Phone2",DataRowVersion.Current);
				Database.AddInParameter(command,"Phone3",DbType.String,"Phone3",DataRowVersion.Current);
				Database.AddInParameter(command,"Fax1",DbType.String,"Fax1",DataRowVersion.Current);
				Database.AddInParameter(command,"Fax2",DbType.String,"Fax2",DataRowVersion.Current);
				Database.AddInParameter(command,"AddressLine1",DbType.String,"AddressLine1",DataRowVersion.Current);
				Database.AddInParameter(command,"AddressLine2",DbType.String,"AddressLine2",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into Organizations using Stored Procedure
		/// </summary>
		public bool UpdateOrganizations( string organizationName, string organizationDescription, string phone1, string phone2, string phone3, string fax1, string fax2, string addressLine1, string addressLine2, int oldorganizationId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateOrganizations");

		    		Database.AddInParameter(command,"OrganizationName",DbType.String,organizationName);
		    		Database.AddInParameter(command,"OrganizationDescription",DbType.String,organizationDescription);
		    		Database.AddInParameter(command,"Phone1",DbType.String,phone1);
		    		Database.AddInParameter(command,"Phone2",DbType.String,phone2);
		    		Database.AddInParameter(command,"Phone3",DbType.String,phone3);
		    		Database.AddInParameter(command,"Fax1",DbType.String,fax1);
		    		Database.AddInParameter(command,"Fax2",DbType.String,fax2);
		    		Database.AddInParameter(command,"AddressLine1",DbType.String,addressLine1);
		    		Database.AddInParameter(command,"AddressLine2",DbType.String,addressLine2);
				Database.AddInParameter(command,"oldOrganizationId",DbType.Int32,oldorganizationId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into Organizations using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateOrganizations( string organizationName, string organizationDescription, string phone1, string phone2, string phone3, string fax1, string fax2, string addressLine1, string addressLine2, int oldorganizationId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateOrganizations");

		    		Database.AddInParameter(command,"OrganizationName",DbType.String,organizationName);
		    		Database.AddInParameter(command,"OrganizationDescription",DbType.String,organizationDescription);
		    		Database.AddInParameter(command,"Phone1",DbType.String,phone1);
		    		Database.AddInParameter(command,"Phone2",DbType.String,phone2);
		    		Database.AddInParameter(command,"Phone3",DbType.String,phone3);
		    		Database.AddInParameter(command,"Fax1",DbType.String,fax1);
		    		Database.AddInParameter(command,"Fax2",DbType.String,fax2);
		    		Database.AddInParameter(command,"AddressLine1",DbType.String,addressLine1);
		    		Database.AddInParameter(command,"AddressLine2",DbType.String,addressLine2);
				Database.AddInParameter(command,"oldOrganizationId",DbType.Int32,oldorganizationId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from Organizations using Stored Procedure
		/// </summary>
		public DbCommand UpdateOrganizationsCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateOrganizations");

		    		Database.AddInParameter(command,"OrganizationName",DbType.String,"OrganizationName",DataRowVersion.Current);
		    		Database.AddInParameter(command,"OrganizationDescription",DbType.String,"OrganizationDescription",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Phone1",DbType.String,"Phone1",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Phone2",DbType.String,"Phone2",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Phone3",DbType.String,"Phone3",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Fax1",DbType.String,"Fax1",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Fax2",DbType.String,"Fax2",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AddressLine1",DbType.String,"AddressLine1",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AddressLine2",DbType.String,"AddressLine2",DataRowVersion.Current);
				Database.AddInParameter(command,"oldOrganizationId",DbType.Int32,"OrganizationId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From Organizations using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteOrganizations( int organizationId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteOrganizations");
			Database.AddInParameter(command,"OrganizationId",DbType.Int32,organizationId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From Organizations Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteOrganizationsCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteOrganizations");
				Database.AddInParameter(command,"OrganizationId",DbType.Int32,"OrganizationId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table Organizations using Stored Procedure
		/// and return number of rows effected of the Organizations
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"Organizations",InsertNewOrganizationsCommand(),UpdateOrganizationsCommand(),DeleteOrganizationsCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table Organizations using Stored Procedure
		/// and return number of rows effected of the Organizations
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"Organizations",InsertNewOrganizationsCommand(),UpdateOrganizationsCommand(),DeleteOrganizationsCommand(), transaction);
          return rowsAffected;
		}


	}
}
