using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.BedManagement
{
	/// <summary>
	/// This is a Data Access Class  for PatientAdmission table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the PatientAdmission table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class PatientAdmissionDAC : DataAccessComponent
	{
		#region Constructors
		public PatientAdmissionDAC(){}
		public PatientAdmissionDAC(string connectionString): base(connectionString){}
		public PatientAdmissionDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all PatientAdmission using Stored Procedure
		/// and return a DataTable containing all PatientAdmission Data
		/// </summary>
		public DataTable GetAllPatientAdmission()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "PatientAdmission";
         string query = " select * from GetAllPatientAdmission";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["PatientAdmission"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all PatientAdmission using Stored Procedure
		/// and return a DataTable containing all PatientAdmission Data using a Transaction
		/// </summary>
		public DataTable GetAllPatientAdmission(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "PatientAdmission";
         string query = " select * from GetAllPatientAdmission";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["PatientAdmission"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all PatientAdmission using Stored Procedure
		/// and return a DataTable containing all PatientAdmission Data
		/// </summary>
		public DataTable GetAllPatientAdmission(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "PatientAdmission";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllPatientAdmission" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["PatientAdmission"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all PatientAdmission using Stored Procedure
		/// and return a DataTable containing all PatientAdmission Data using a Transaction
		/// </summary>
		public DataTable GetAllPatientAdmission(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "PatientAdmission";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllPatientAdmission" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["PatientAdmission"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From PatientAdmission using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDPatientAdmission( int patientAdmissionId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDPatientAdmission");
				    Database.AddInParameter(command,"PatientAdmissionId",DbType.Int32,patientAdmissionId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From PatientAdmission using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDPatientAdmission( int patientAdmissionId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDPatientAdmission");
				    Database.AddInParameter(command,"PatientAdmissionId",DbType.Int32,patientAdmissionId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into PatientAdmission using Stored Procedure
		/// and return the auto number primary key of PatientAdmission inserted row
		/// </summary>
		public bool InsertNewPatientAdmission( ref int patientAdmissionId,  DateTime admissionStartDate,  DateTime dischargeDate,  int admissionStayTypeId,  int dischargeTypeId,  string patientCode,  int consultantId,  int specialityId,  int wardBedId)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewPatientAdmission");
				Database.AddOutParameter(command,"PatientAdmissionId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"AdmissionStartDate",DbType.DateTime,admissionStartDate);
				Database.AddInParameter(command,"DischargeDate",DbType.DateTime,dischargeDate);
				Database.AddInParameter(command,"AdmissionStayTypeId",DbType.Int32,admissionStayTypeId);
				Database.AddInParameter(command,"DischargeTypeId",DbType.Int32,dischargeTypeId);
				Database.AddInParameter(command,"PatientCode",DbType.String,patientCode);
				Database.AddInParameter(command,"ConsultantId",DbType.Int32,consultantId);
				Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
				Database.AddInParameter(command,"WardBedId",DbType.Int32,wardBedId);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 patientAdmissionId = Convert.ToInt32(Database.GetParameterValue(command, "PatientAdmissionId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into PatientAdmission using Stored Procedure
		/// and return the auto number primary key of PatientAdmission inserted row using Transaction
		/// </summary>
		public bool InsertNewPatientAdmission( ref int patientAdmissionId,  DateTime admissionStartDate,  DateTime dischargeDate,  int admissionStayTypeId,  int dischargeTypeId,  string patientCode,  int consultantId,  int specialityId,  int wardBedId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewPatientAdmission");
				Database.AddOutParameter(command,"PatientAdmissionId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"AdmissionStartDate",DbType.DateTime,admissionStartDate);
				Database.AddInParameter(command,"DischargeDate",DbType.DateTime,dischargeDate);
				Database.AddInParameter(command,"AdmissionStayTypeId",DbType.Int32,admissionStayTypeId);
				Database.AddInParameter(command,"DischargeTypeId",DbType.Int32,dischargeTypeId);
				Database.AddInParameter(command,"PatientCode",DbType.String,patientCode);
				Database.AddInParameter(command,"ConsultantId",DbType.Int32,consultantId);
				Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
				Database.AddInParameter(command,"WardBedId",DbType.Int32,wardBedId);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 patientAdmissionId = Convert.ToInt32(Database.GetParameterValue(command, "PatientAdmissionId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for PatientAdmission using Stored Procedure
		/// and return DbCommand of the PatientAdmission
		/// </summary>
		public DbCommand InsertNewPatientAdmissionCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewPatientAdmission");

				Database.AddInParameter(command,"AdmissionStartDate",DbType.DateTime,"AdmissionStartDate",DataRowVersion.Current);
				Database.AddInParameter(command,"DischargeDate",DbType.DateTime,"DischargeDate",DataRowVersion.Current);
				Database.AddInParameter(command,"AdmissionStayTypeId",DbType.Int32,"AdmissionStayTypeId",DataRowVersion.Current);
				Database.AddInParameter(command,"DischargeTypeId",DbType.Int32,"DischargeTypeId",DataRowVersion.Current);
				Database.AddInParameter(command,"PatientCode",DbType.String,"PatientCode",DataRowVersion.Current);
				Database.AddInParameter(command,"ConsultantId",DbType.Int32,"ConsultantId",DataRowVersion.Current);
				Database.AddInParameter(command,"SpecialityId",DbType.Int32,"SpecialityId",DataRowVersion.Current);
				Database.AddInParameter(command,"WardBedId",DbType.Int32,"WardBedId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into PatientAdmission using Stored Procedure
		/// </summary>
		public bool UpdatePatientAdmission( DateTime admissionStartDate, DateTime dischargeDate, int admissionStayTypeId, int dischargeTypeId, string patientCode, int consultantId, int specialityId, int wardBedId, int oldpatientAdmissionId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdatePatientAdmission");

		    		Database.AddInParameter(command,"AdmissionStartDate",DbType.DateTime,admissionStartDate);
		    		Database.AddInParameter(command,"DischargeDate",DbType.DateTime,dischargeDate);
		    		Database.AddInParameter(command,"AdmissionStayTypeId",DbType.Int32,admissionStayTypeId);
		    		Database.AddInParameter(command,"DischargeTypeId",DbType.Int32,dischargeTypeId);
		    		Database.AddInParameter(command,"PatientCode",DbType.String,patientCode);
		    		Database.AddInParameter(command,"ConsultantId",DbType.Int32,consultantId);
		    		Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
		    		Database.AddInParameter(command,"WardBedId",DbType.Int32,wardBedId);
				Database.AddInParameter(command,"oldPatientAdmissionId",DbType.Int32,oldpatientAdmissionId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into PatientAdmission using Stored Procedure By Transaction
		/// </summary>
		public bool UpdatePatientAdmission( DateTime admissionStartDate, DateTime dischargeDate, int admissionStayTypeId, int dischargeTypeId, string patientCode, int consultantId, int specialityId, int wardBedId, int oldpatientAdmissionId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdatePatientAdmission");

		    		Database.AddInParameter(command,"AdmissionStartDate",DbType.DateTime,admissionStartDate);
		    		Database.AddInParameter(command,"DischargeDate",DbType.DateTime,dischargeDate);
		    		Database.AddInParameter(command,"AdmissionStayTypeId",DbType.Int32,admissionStayTypeId);
		    		Database.AddInParameter(command,"DischargeTypeId",DbType.Int32,dischargeTypeId);
		    		Database.AddInParameter(command,"PatientCode",DbType.String,patientCode);
		    		Database.AddInParameter(command,"ConsultantId",DbType.Int32,consultantId);
		    		Database.AddInParameter(command,"SpecialityId",DbType.Int32,specialityId);
		    		Database.AddInParameter(command,"WardBedId",DbType.Int32,wardBedId);
				Database.AddInParameter(command,"oldPatientAdmissionId",DbType.Int32,oldpatientAdmissionId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from PatientAdmission using Stored Procedure
		/// </summary>
		public DbCommand UpdatePatientAdmissionCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdatePatientAdmission");

		    		Database.AddInParameter(command,"AdmissionStartDate",DbType.DateTime,"AdmissionStartDate",DataRowVersion.Current);
		    		Database.AddInParameter(command,"DischargeDate",DbType.DateTime,"DischargeDate",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AdmissionStayTypeId",DbType.Int32,"AdmissionStayTypeId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"DischargeTypeId",DbType.Int32,"DischargeTypeId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"PatientCode",DbType.String,"PatientCode",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ConsultantId",DbType.Int32,"ConsultantId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"SpecialityId",DbType.Int32,"SpecialityId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"WardBedId",DbType.Int32,"WardBedId",DataRowVersion.Current);
				Database.AddInParameter(command,"oldPatientAdmissionId",DbType.Int32,"PatientAdmissionId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From PatientAdmission using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeletePatientAdmission( int patientAdmissionId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeletePatientAdmission");
			Database.AddInParameter(command,"PatientAdmissionId",DbType.Int32,patientAdmissionId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From PatientAdmission Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeletePatientAdmissionCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeletePatientAdmission");
				Database.AddInParameter(command,"PatientAdmissionId",DbType.Int32,"PatientAdmissionId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table PatientAdmission using Stored Procedure
		/// and return number of rows effected of the PatientAdmission
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"PatientAdmission",InsertNewPatientAdmissionCommand(),UpdatePatientAdmissionCommand(),DeletePatientAdmissionCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table PatientAdmission using Stored Procedure
		/// and return number of rows effected of the PatientAdmission
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"PatientAdmission",InsertNewPatientAdmissionCommand(),UpdatePatientAdmissionCommand(),DeletePatientAdmissionCommand(), transaction);
          return rowsAffected;
		}


	}
}
