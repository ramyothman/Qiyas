using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.Organization
{
	/// <summary>
	/// This is a Data Access Class  for Speciality table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the Speciality table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class SpecialityDAC : DataAccessComponent
	{
		#region Constructors
		public SpecialityDAC(){}
		public SpecialityDAC(string connectionString): base(connectionString){}
		public SpecialityDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Speciality using Stored Procedure
		/// and return a DataTable containing all Speciality Data
		/// </summary>
		public DataTable GetAllSpeciality()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Speciality";
         string query = " select * from GetAllSpeciality";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["Speciality"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Speciality using Stored Procedure
		/// and return a DataTable containing all Speciality Data using a Transaction
		/// </summary>
		public DataTable GetAllSpeciality(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Speciality";
         string query = " select * from GetAllSpeciality";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["Speciality"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Speciality using Stored Procedure
		/// and return a DataTable containing all Speciality Data
		/// </summary>
		public DataTable GetAllSpeciality(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Speciality";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllSpeciality" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["Speciality"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Speciality using Stored Procedure
		/// and return a DataTable containing all Speciality Data using a Transaction
		/// </summary>
		public DataTable GetAllSpeciality(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Speciality";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllSpeciality" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["Speciality"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From Speciality using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDSpeciality( int specialityId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDSpeciality");
				    Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From Speciality using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDSpeciality( int specialityId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDSpeciality");
				    Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into Speciality using Stored Procedure
		/// and return the auto number primary key of Speciality inserted row
		/// </summary>
		public bool InsertNewSpeciality( ref int specialityId,  string specialityCode,  string specialityName,  string bedDisplayCode)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewSpeciality");
				Database.AddOutParameter(command,"SpecialityId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"SpecialityCode",DbType.String,specialityCode);
				Database.AddInParameter(command,"SpecialityName",DbType.String,specialityName);
				Database.AddInParameter(command,"BedDisplayCode",DbType.String,bedDisplayCode);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 specialityId = Convert.ToInt32(Database.GetParameterValue(command, "SpecialityId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into Speciality using Stored Procedure
		/// and return the auto number primary key of Speciality inserted row using Transaction
		/// </summary>
		public bool InsertNewSpeciality( ref int specialityId,  string specialityCode,  string specialityName,  string bedDisplayCode,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewSpeciality");
				Database.AddOutParameter(command,"SpecialityId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"SpecialityCode",DbType.String,specialityCode);
				Database.AddInParameter(command,"SpecialityName",DbType.String,specialityName);
				Database.AddInParameter(command,"BedDisplayCode",DbType.String,bedDisplayCode);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 specialityId = Convert.ToInt32(Database.GetParameterValue(command, "SpecialityId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for Speciality using Stored Procedure
		/// and return DbCommand of the Speciality
		/// </summary>
		public DbCommand InsertNewSpecialityCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewSpeciality");

				Database.AddInParameter(command,"SpecialityCode",DbType.String,"SpecialityCode",DataRowVersion.Current);
				Database.AddInParameter(command,"SpecialityName",DbType.String,"SpecialityName",DataRowVersion.Current);
				Database.AddInParameter(command,"BedDisplayCode",DbType.String,"BedDisplayCode",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into Speciality using Stored Procedure
		/// </summary>
		public bool UpdateSpeciality( string specialityCode, string specialityName, string bedDisplayCode, int oldspecialityId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateSpeciality");

		    		Database.AddInParameter(command,"SpecialityCode",DbType.String,specialityCode);
		    		Database.AddInParameter(command,"SpecialityName",DbType.String,specialityName);
		    		Database.AddInParameter(command,"BedDisplayCode",DbType.String,bedDisplayCode);
				Database.AddInParameter(command,"oldSpecialityId",DbType.Int32,oldspecialityId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into Speciality using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateSpeciality( string specialityCode, string specialityName, string bedDisplayCode, int oldspecialityId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateSpeciality");

		    		Database.AddInParameter(command,"SpecialityCode",DbType.String,specialityCode);
		    		Database.AddInParameter(command,"SpecialityName",DbType.String,specialityName);
		    		Database.AddInParameter(command,"BedDisplayCode",DbType.String,bedDisplayCode);
				Database.AddInParameter(command,"oldSpecialityId",DbType.Int32,oldspecialityId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from Speciality using Stored Procedure
		/// </summary>
		public DbCommand UpdateSpecialityCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateSpeciality");

		    		Database.AddInParameter(command,"SpecialityCode",DbType.String,"SpecialityCode",DataRowVersion.Current);
		    		Database.AddInParameter(command,"SpecialityName",DbType.String,"SpecialityName",DataRowVersion.Current);
		    		Database.AddInParameter(command,"BedDisplayCode",DbType.String,"BedDisplayCode",DataRowVersion.Current);
				Database.AddInParameter(command,"oldSpecialityId",DbType.Int32,"SpecialityId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From Speciality using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteSpeciality( int specialityId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteSpeciality");
			Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From Speciality Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteSpecialityCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteSpeciality");
				Database.AddInParameter(command,"SpecialityId",DbType.Int32,"SpecialityId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table Speciality using Stored Procedure
		/// and return number of rows effected of the Speciality
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"Speciality",InsertNewSpecialityCommand(),UpdateSpecialityCommand(),DeleteSpecialityCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table Speciality using Stored Procedure
		/// and return number of rows effected of the Speciality
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"Speciality",InsertNewSpecialityCommand(),UpdateSpecialityCommand(),DeleteSpecialityCommand(), transaction);
          return rowsAffected;
		}


	}
}
