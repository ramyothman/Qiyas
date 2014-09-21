using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.HISBedManagement
{
	/// <summary>
	/// This is a Data Access Class  for BedType table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the BedType table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class BedTypeDAC : DataAccessComponent
	{
		#region Constructors
		public BedTypeDAC(){}
		public BedTypeDAC(string connectionString): base(connectionString){}
		public BedTypeDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all BedType using Stored Procedure
		/// and return a DataTable containing all BedType Data
		/// </summary>
		public DataTable GetAllBedType()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "BedType";
         string query = " select * from GetAllBedType";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["BedType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all BedType using Stored Procedure
		/// and return a DataTable containing all BedType Data using a Transaction
		/// </summary>
		public DataTable GetAllBedType(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "BedType";
         string query = " select * from GetAllBedType";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["BedType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all BedType using Stored Procedure
		/// and return a DataTable containing all BedType Data
		/// </summary>
		public DataTable GetAllBedType(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "BedType";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllBedType" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["BedType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all BedType using Stored Procedure
		/// and return a DataTable containing all BedType Data using a Transaction
		/// </summary>
		public DataTable GetAllBedType(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "BedType";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllBedType" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["BedType"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From BedType using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDBedType( int bedTypeId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDBedType");
				    Database.AddInParameter(command,"BedTypeId",DbType.Int32,bedTypeId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From BedType using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDBedType( int bedTypeId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDBedType");
				    Database.AddInParameter(command,"BedTypeId",DbType.Int32,bedTypeId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into BedType using Stored Procedure
		/// and return the auto number primary key of BedType inserted row
		/// </summary>
		public bool InsertNewBedType( ref int bedTypeId,  string bedTypeName)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewBedType");
				Database.AddOutParameter(command,"BedTypeId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"BedTypeName",DbType.String,bedTypeName);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 bedTypeId = Convert.ToInt32(Database.GetParameterValue(command, "BedTypeId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into BedType using Stored Procedure
		/// and return the auto number primary key of BedType inserted row using Transaction
		/// </summary>
		public bool InsertNewBedType( ref int bedTypeId,  string bedTypeName,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewBedType");
				Database.AddOutParameter(command,"BedTypeId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"BedTypeName",DbType.String,bedTypeName);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 bedTypeId = Convert.ToInt32(Database.GetParameterValue(command, "BedTypeId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for BedType using Stored Procedure
		/// and return DbCommand of the BedType
		/// </summary>
		public DbCommand InsertNewBedTypeCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewBedType");

				Database.AddInParameter(command,"BedTypeName",DbType.String,"BedTypeName",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into BedType using Stored Procedure
		/// </summary>
		public bool UpdateBedType( string bedTypeName, int oldbedTypeId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateBedType");

		    		Database.AddInParameter(command,"BedTypeName",DbType.String,bedTypeName);
				Database.AddInParameter(command,"oldBedTypeId",DbType.Int32,oldbedTypeId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into BedType using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateBedType( string bedTypeName, int oldbedTypeId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateBedType");

		    		Database.AddInParameter(command,"BedTypeName",DbType.String,bedTypeName);
				Database.AddInParameter(command,"oldBedTypeId",DbType.Int32,oldbedTypeId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from BedType using Stored Procedure
		/// </summary>
		public DbCommand UpdateBedTypeCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateBedType");

		    		Database.AddInParameter(command,"BedTypeName",DbType.String,"BedTypeName",DataRowVersion.Current);
				Database.AddInParameter(command,"oldBedTypeId",DbType.Int32,"BedTypeId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From BedType using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteBedType( int bedTypeId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteBedType");
			Database.AddInParameter(command,"BedTypeId",DbType.Int32,bedTypeId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From BedType Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteBedTypeCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteBedType");
				Database.AddInParameter(command,"BedTypeId",DbType.Int32,"BedTypeId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table BedType using Stored Procedure
		/// and return number of rows effected of the BedType
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"BedType",InsertNewBedTypeCommand(),UpdateBedTypeCommand(),DeleteBedTypeCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table BedType using Stored Procedure
		/// and return number of rows effected of the BedType
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"BedType",InsertNewBedTypeCommand(),UpdateBedTypeCommand(),DeleteBedTypeCommand(), transaction);
          return rowsAffected;
		}


	}
}
