using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.Eligibility
{
	/// <summary>
	/// This is a Data Access Class  for EligibilityDepartmentAction table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the EligibilityDepartmentAction table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class EligibilityDepartmentActionDAC : DataAccessComponent
	{
		#region Constructors
		public EligibilityDepartmentActionDAC(){}
		public EligibilityDepartmentActionDAC(string connectionString): base(connectionString){}
		public EligibilityDepartmentActionDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibilityDepartmentAction using Stored Procedure
		/// and return a DataTable containing all EligibilityDepartmentAction Data
		/// </summary>
		public DataTable GetAllEligibilityDepartmentAction()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibilityDepartmentAction";
         string query = " select * from GetAllEligibilityDepartmentAction";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["EligibilityDepartmentAction"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibilityDepartmentAction using Stored Procedure
		/// and return a DataTable containing all EligibilityDepartmentAction Data using a Transaction
		/// </summary>
		public DataTable GetAllEligibilityDepartmentAction(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibilityDepartmentAction";
         string query = " select * from GetAllEligibilityDepartmentAction";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["EligibilityDepartmentAction"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibilityDepartmentAction using Stored Procedure
		/// and return a DataTable containing all EligibilityDepartmentAction Data
		/// </summary>
		public DataTable GetAllEligibilityDepartmentAction(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibilityDepartmentAction";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllEligibilityDepartmentAction" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["EligibilityDepartmentAction"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all EligibilityDepartmentAction using Stored Procedure
		/// and return a DataTable containing all EligibilityDepartmentAction Data using a Transaction
		/// </summary>
		public DataTable GetAllEligibilityDepartmentAction(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "EligibilityDepartmentAction";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllEligibilityDepartmentAction" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["EligibilityDepartmentAction"];

		}


        public System.Data.IDataReader GetByDepartmentIDEligibilityDepartmentAction(int EligibilityDepartmentId)
		{
            DbCommand command = Database.GetStoredProcCommand("GetByDepartmentIDEligibilityDepartmentAction");
            Database.AddInParameter(command, "EligibilityDepartmentId", DbType.Int32, EligibilityDepartmentId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

        public System.Data.IDataReader GetByDepartmentIDEligibilityDepartmentActionnew(int EligibilityDepartmentId, int EligibleId)
        {
            DbCommand command = Database.GetStoredProcCommand("GetByDepartmentIDEligibilityDepartmentActionnew");
            Database.AddInParameter(command, "EligibilityDepartmentId", DbType.Int32, EligibilityDepartmentId);
            Database.AddInParameter(command, "EligibleId", DbType.Int32, EligibleId);
            IDataReader reader = Database.ExecuteReader(command);
            return reader;
        }
		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From EligibilityDepartmentAction using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDEligibilityDepartmentAction( int eligibilityDepartmentActionId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDEligibilityDepartmentAction");
				    Database.AddInParameter(command,"EligibilityDepartmentActionId",DbType.Int32,eligibilityDepartmentActionId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From EligibilityDepartmentAction using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDEligibilityDepartmentAction( int eligibilityDepartmentActionId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDEligibilityDepartmentAction");
				    Database.AddInParameter(command,"EligibilityDepartmentActionId",DbType.Int32,eligibilityDepartmentActionId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into EligibilityDepartmentAction using Stored Procedure
		/// and return the auto number primary key of EligibilityDepartmentAction inserted row
		/// </summary>
		public bool InsertNewEligibilityDepartmentAction( ref int eligibilityDepartmentActionId,  int eligibilityDepartmentId,  int eligibleId,  int consultantSubmittingActionId,  string consultantName,  string note,  int eligibilityStatusId,  bool isAdmitted,  DateTime admissionApointmentDate,  string ward,  bool isOPDAppointment,  DateTime oPDAppointmentDate,  string clinic,  bool isFurtherInvestigationDoneInReferringHospital,  bool isPatientCantBeAccommodatedForBedUnavailability,  bool isNothingAdditionalCanBeOfferedRightMedication,  bool isNothingAdditionalCanBeOfferedIsTerminal,  bool isMedicalReportIncomplete,  bool isNotAvailableSpeciality,  bool isOtherReason,  string otherReason,  DateTime dateCreated,  DateTime dateModified,  int transferToDepartmentId)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligibilityDepartmentAction");
				Database.AddOutParameter(command,"EligibilityDepartmentActionId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"EligibilityDepartmentId",DbType.Int32,eligibilityDepartmentId);
				Database.AddInParameter(command,"EligibleId",DbType.Int32,eligibleId);
				Database.AddInParameter(command,"ConsultantSubmittingActionId",DbType.Int32,consultantSubmittingActionId);
				Database.AddInParameter(command,"ConsultantName",DbType.String,consultantName);
				Database.AddInParameter(command,"Note",DbType.String,note);
				Database.AddInParameter(command,"EligibilityStatusId",DbType.Int32,eligibilityStatusId);
				Database.AddInParameter(command,"IsAdmitted",DbType.Boolean,isAdmitted);
                if (admissionApointmentDate== DateTime.MinValue)
				    Database.AddInParameter(command,"AdmissionApointmentDate",DbType.DateTime,DBNull.Value);
                else
                    Database.AddInParameter(command, "AdmissionApointmentDate", DbType.DateTime, admissionApointmentDate);
				Database.AddInParameter(command,"Ward",DbType.String,ward);
				Database.AddInParameter(command,"IsOPDAppointment",DbType.Boolean,isOPDAppointment);
                if (oPDAppointmentDate == DateTime.MinValue)
				    Database.AddInParameter(command,"OPDAppointmentDate",DbType.DateTime,DBNull.Value);
                else
                    Database.AddInParameter(command, "OPDAppointmentDate", DbType.DateTime, oPDAppointmentDate);
				Database.AddInParameter(command,"Clinic",DbType.String,clinic);
				Database.AddInParameter(command,"IsFurtherInvestigationDoneInReferringHospital",DbType.Boolean,isFurtherInvestigationDoneInReferringHospital);
				Database.AddInParameter(command,"IsPatientCantBeAccommodatedForBedUnavailability",DbType.Boolean,isPatientCantBeAccommodatedForBedUnavailability);
				Database.AddInParameter(command,"IsNothingAdditionalCanBeOfferedRightMedication",DbType.Boolean,isNothingAdditionalCanBeOfferedRightMedication);
				Database.AddInParameter(command,"IsNothingAdditionalCanBeOfferedIsTerminal",DbType.Boolean,isNothingAdditionalCanBeOfferedIsTerminal);
				Database.AddInParameter(command,"IsMedicalReportIncomplete",DbType.Boolean,isMedicalReportIncomplete);
				Database.AddInParameter(command,"IsNotAvailableSpeciality",DbType.Boolean,isNotAvailableSpeciality);
				Database.AddInParameter(command,"IsOtherReason",DbType.Boolean,isOtherReason);
				Database.AddInParameter(command,"OtherReason",DbType.String,otherReason);
				Database.AddInParameter(command,"DateCreated",DbType.DateTime,dateCreated);
				Database.AddInParameter(command,"DateModified",DbType.DateTime,dateModified);
            if(transferToDepartmentId == 0)
				Database.AddInParameter(command,"TransferToDepartmentId",DbType.Int32,DBNull.Value);
            else
                Database.AddInParameter(command, "TransferToDepartmentId", DbType.Int32, transferToDepartmentId);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 eligibilityDepartmentActionId = Convert.ToInt32(Database.GetParameterValue(command, "EligibilityDepartmentActionId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into EligibilityDepartmentAction using Stored Procedure
		/// and return the auto number primary key of EligibilityDepartmentAction inserted row using Transaction
		/// </summary>
		public bool InsertNewEligibilityDepartmentAction( ref int eligibilityDepartmentActionId,  int eligibilityDepartmentId,  int eligibleId,  int consultantSubmittingActionId,  string consultantName,  string note,  int eligibilityStatusId,  bool isAdmitted,  DateTime admissionApointmentDate,  string ward,  bool isOPDAppointment,  DateTime oPDAppointmentDate,  string clinic,  bool isFurtherInvestigationDoneInReferringHospital,  bool isPatientCantBeAccommodatedForBedUnavailability,  bool isNothingAdditionalCanBeOfferedRightMedication,  bool isNothingAdditionalCanBeOfferedIsTerminal,  bool isMedicalReportIncomplete,  bool isNotAvailableSpeciality,  bool isOtherReason,  string otherReason,  DateTime dateCreated,  DateTime dateModified,  int transferToDepartmentId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligibilityDepartmentAction");
				Database.AddOutParameter(command,"EligibilityDepartmentActionId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"EligibilityDepartmentId",DbType.Int32,eligibilityDepartmentId);
				Database.AddInParameter(command,"EligibleId",DbType.Int32,eligibleId);
				Database.AddInParameter(command,"ConsultantSubmittingActionId",DbType.Int32,consultantSubmittingActionId);
				Database.AddInParameter(command,"ConsultantName",DbType.String,consultantName);
				Database.AddInParameter(command,"Note",DbType.String,note);
				Database.AddInParameter(command,"EligibilityStatusId",DbType.Int32,eligibilityStatusId);
				Database.AddInParameter(command,"IsAdmitted",DbType.Boolean,isAdmitted);
                if (admissionApointmentDate == DateTime.MinValue)
                    Database.AddInParameter(command, "AdmissionApointmentDate", DbType.DateTime, DBNull.Value);
                else
                    Database.AddInParameter(command, "AdmissionApointmentDate", DbType.DateTime, admissionApointmentDate);
                Database.AddInParameter(command, "Ward", DbType.String, ward);
                Database.AddInParameter(command, "IsOPDAppointment", DbType.Boolean, isOPDAppointment);
                if (oPDAppointmentDate == DateTime.MinValue)
                    Database.AddInParameter(command, "OPDAppointmentDate", DbType.DateTime, DBNull.Value);
                else
                    Database.AddInParameter(command, "OPDAppointmentDate", DbType.DateTime, oPDAppointmentDate);
                Database.AddInParameter(command, "Clinic", DbType.String, clinic);
                Database.AddInParameter(command, "IsFurtherInvestigationDoneInReferringHospital", DbType.Boolean, isFurtherInvestigationDoneInReferringHospital);
                Database.AddInParameter(command, "IsPatientCantBeAccommodatedForBedUnavailability", DbType.Boolean, isPatientCantBeAccommodatedForBedUnavailability);
                Database.AddInParameter(command, "IsNothingAdditionalCanBeOfferedRightMedication", DbType.Boolean, isNothingAdditionalCanBeOfferedRightMedication);
                Database.AddInParameter(command, "IsNothingAdditionalCanBeOfferedIsTerminal", DbType.Boolean, isNothingAdditionalCanBeOfferedIsTerminal);
                Database.AddInParameter(command, "IsMedicalReportIncomplete", DbType.Boolean, isMedicalReportIncomplete);
                Database.AddInParameter(command, "IsNotAvailableSpeciality", DbType.Boolean, isNotAvailableSpeciality);
                Database.AddInParameter(command, "IsOtherReason", DbType.Boolean, isOtherReason);
                Database.AddInParameter(command, "OtherReason", DbType.String, otherReason);
                Database.AddInParameter(command, "DateCreated", DbType.DateTime, dateCreated);
                Database.AddInParameter(command, "DateModified", DbType.DateTime, dateModified);
                if (transferToDepartmentId == 0)
                    Database.AddInParameter(command, "TransferToDepartmentId", DbType.Int32, DBNull.Value);
                else
                    Database.AddInParameter(command, "TransferToDepartmentId", DbType.Int32, transferToDepartmentId);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 eligibilityDepartmentActionId = Convert.ToInt32(Database.GetParameterValue(command, "EligibilityDepartmentActionId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for EligibilityDepartmentAction using Stored Procedure
		/// and return DbCommand of the EligibilityDepartmentAction
		/// </summary>
		public DbCommand InsertNewEligibilityDepartmentActionCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligibilityDepartmentAction");

				Database.AddInParameter(command,"EligibilityDepartmentId",DbType.Int32,"EligibilityDepartmentId",DataRowVersion.Current);
				Database.AddInParameter(command,"EligibleId",DbType.Int32,"EligibleId",DataRowVersion.Current);
				Database.AddInParameter(command,"ConsultantSubmittingActionId",DbType.Int32,"ConsultantSubmittingActionId",DataRowVersion.Current);
				Database.AddInParameter(command,"ConsultantName",DbType.String,"ConsultantName",DataRowVersion.Current);
				Database.AddInParameter(command,"Note",DbType.String,"Note",DataRowVersion.Current);
				Database.AddInParameter(command,"EligibilityStatusId",DbType.Int32,"EligibilityStatusId",DataRowVersion.Current);
				Database.AddInParameter(command,"IsAdmitted",DbType.Boolean,"IsAdmitted",DataRowVersion.Current);
				Database.AddInParameter(command,"AdmissionApointmentDate",DbType.DateTime,"AdmissionApointmentDate",DataRowVersion.Current);
				Database.AddInParameter(command,"Ward",DbType.String,"Ward",DataRowVersion.Current);
				Database.AddInParameter(command,"IsOPDAppointment",DbType.Boolean,"IsOPDAppointment",DataRowVersion.Current);
				Database.AddInParameter(command,"OPDAppointmentDate",DbType.DateTime,"OPDAppointmentDate",DataRowVersion.Current);
				Database.AddInParameter(command,"Clinic",DbType.String,"Clinic",DataRowVersion.Current);
				Database.AddInParameter(command,"IsFurtherInvestigationDoneInReferringHospital",DbType.Boolean,"IsFurtherInvestigationDoneInReferringHospital",DataRowVersion.Current);
				Database.AddInParameter(command,"IsPatientCantBeAccommodatedForBedUnavailability",DbType.Boolean,"IsPatientCantBeAccommodatedForBedUnavailability",DataRowVersion.Current);
				Database.AddInParameter(command,"IsNothingAdditionalCanBeOfferedRightMedication",DbType.Boolean,"IsNothingAdditionalCanBeOfferedRightMedication",DataRowVersion.Current);
				Database.AddInParameter(command,"IsNothingAdditionalCanBeOfferedIsTerminal",DbType.Boolean,"IsNothingAdditionalCanBeOfferedIsTerminal",DataRowVersion.Current);
				Database.AddInParameter(command,"IsMedicalReportIncomplete",DbType.Boolean,"IsMedicalReportIncomplete",DataRowVersion.Current);
				Database.AddInParameter(command,"IsNotAvailableSpeciality",DbType.Boolean,"IsNotAvailableSpeciality",DataRowVersion.Current);
				Database.AddInParameter(command,"IsOtherReason",DbType.Boolean,"IsOtherReason",DataRowVersion.Current);
				Database.AddInParameter(command,"OtherReason",DbType.String,"OtherReason",DataRowVersion.Current);
				Database.AddInParameter(command,"DateCreated",DbType.DateTime,"DateCreated",DataRowVersion.Current);
				Database.AddInParameter(command,"DateModified",DbType.DateTime,"DateModified",DataRowVersion.Current);
				Database.AddInParameter(command,"TransferToDepartmentId",DbType.Int32,"TransferToDepartmentId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into EligibilityDepartmentAction using Stored Procedure
		/// </summary>
		public bool UpdateEligibilityDepartmentAction( int eligibilityDepartmentId, int eligibleId, int consultantSubmittingActionId, string consultantName, string note, int eligibilityStatusId, bool isAdmitted, DateTime admissionApointmentDate, string ward, bool isOPDAppointment, DateTime oPDAppointmentDate, string clinic, bool isFurtherInvestigationDoneInReferringHospital, bool isPatientCantBeAccommodatedForBedUnavailability, bool isNothingAdditionalCanBeOfferedRightMedication, bool isNothingAdditionalCanBeOfferedIsTerminal, bool isMedicalReportIncomplete, bool isNotAvailableSpeciality, bool isOtherReason, string otherReason, DateTime dateCreated, DateTime dateModified, int transferToDepartmentId, int oldeligibilityDepartmentActionId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligibilityDepartmentAction");

		    		Database.AddInParameter(command,"EligibilityDepartmentId",DbType.Int32,eligibilityDepartmentId);
		    		Database.AddInParameter(command,"EligibleId",DbType.Int32,eligibleId);
		    		Database.AddInParameter(command,"ConsultantSubmittingActionId",DbType.Int32,consultantSubmittingActionId);
		    		Database.AddInParameter(command,"ConsultantName",DbType.String,consultantName);
		    		Database.AddInParameter(command,"Note",DbType.String,note);
		    		Database.AddInParameter(command,"EligibilityStatusId",DbType.Int32,eligibilityStatusId);
		    		Database.AddInParameter(command,"IsAdmitted",DbType.Boolean,isAdmitted);
                    if (admissionApointmentDate == DateTime.MinValue)
                        Database.AddInParameter(command, "AdmissionApointmentDate", DbType.DateTime, DBNull.Value);
                    else
                        Database.AddInParameter(command, "AdmissionApointmentDate", DbType.DateTime, admissionApointmentDate);
                    Database.AddInParameter(command, "Ward", DbType.String, ward);
                    Database.AddInParameter(command, "IsOPDAppointment", DbType.Boolean, isOPDAppointment);
                    if (oPDAppointmentDate == DateTime.MinValue)
                        Database.AddInParameter(command, "OPDAppointmentDate", DbType.DateTime, DBNull.Value);
                    else
                        Database.AddInParameter(command, "OPDAppointmentDate", DbType.DateTime, oPDAppointmentDate);
                    Database.AddInParameter(command, "Clinic", DbType.String, clinic);
                    Database.AddInParameter(command, "IsFurtherInvestigationDoneInReferringHospital", DbType.Boolean, isFurtherInvestigationDoneInReferringHospital);
                    Database.AddInParameter(command, "IsPatientCantBeAccommodatedForBedUnavailability", DbType.Boolean, isPatientCantBeAccommodatedForBedUnavailability);
                    Database.AddInParameter(command, "IsNothingAdditionalCanBeOfferedRightMedication", DbType.Boolean, isNothingAdditionalCanBeOfferedRightMedication);
                    Database.AddInParameter(command, "IsNothingAdditionalCanBeOfferedIsTerminal", DbType.Boolean, isNothingAdditionalCanBeOfferedIsTerminal);
                    Database.AddInParameter(command, "IsMedicalReportIncomplete", DbType.Boolean, isMedicalReportIncomplete);
                    Database.AddInParameter(command, "IsNotAvailableSpeciality", DbType.Boolean, isNotAvailableSpeciality);
                    Database.AddInParameter(command, "IsOtherReason", DbType.Boolean, isOtherReason);
                    Database.AddInParameter(command, "OtherReason", DbType.String, otherReason);
                    Database.AddInParameter(command, "DateCreated", DbType.DateTime, dateCreated);
                    Database.AddInParameter(command, "DateModified", DbType.DateTime, dateModified);
                    if (transferToDepartmentId == 0)
                        Database.AddInParameter(command, "TransferToDepartmentId", DbType.Int32, DBNull.Value);
                    else
                        Database.AddInParameter(command, "TransferToDepartmentId", DbType.Int32, transferToDepartmentId);
				Database.AddInParameter(command,"oldEligibilityDepartmentActionId",DbType.Int32,oldeligibilityDepartmentActionId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into EligibilityDepartmentAction using Stored Procedure By Transaction
		/// </summary>
		public bool UpdateEligibilityDepartmentAction( int eligibilityDepartmentId, int eligibleId, int consultantSubmittingActionId, string consultantName, string note, int eligibilityStatusId, bool isAdmitted, DateTime admissionApointmentDate, string ward, bool isOPDAppointment, DateTime oPDAppointmentDate, string clinic, bool isFurtherInvestigationDoneInReferringHospital, bool isPatientCantBeAccommodatedForBedUnavailability, bool isNothingAdditionalCanBeOfferedRightMedication, bool isNothingAdditionalCanBeOfferedIsTerminal, bool isMedicalReportIncomplete, bool isNotAvailableSpeciality, bool isOtherReason, string otherReason, DateTime dateCreated, DateTime dateModified, int transferToDepartmentId, int oldeligibilityDepartmentActionId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligibilityDepartmentAction");

		    		Database.AddInParameter(command,"EligibilityDepartmentId",DbType.Int32,eligibilityDepartmentId);
		    		Database.AddInParameter(command,"EligibleId",DbType.Int32,eligibleId);
		    		Database.AddInParameter(command,"ConsultantSubmittingActionId",DbType.Int32,consultantSubmittingActionId);
		    		Database.AddInParameter(command,"ConsultantName",DbType.String,consultantName);
		    		Database.AddInParameter(command,"Note",DbType.String,note);
		    		Database.AddInParameter(command,"EligibilityStatusId",DbType.Int32,eligibilityStatusId);
		    		Database.AddInParameter(command,"IsAdmitted",DbType.Boolean,isAdmitted);
                    if (admissionApointmentDate == DateTime.MinValue)
                        Database.AddInParameter(command, "AdmissionApointmentDate", DbType.DateTime, DBNull.Value);
                    else
                        Database.AddInParameter(command, "AdmissionApointmentDate", DbType.DateTime, admissionApointmentDate);
                    Database.AddInParameter(command, "Ward", DbType.String, ward);
                    Database.AddInParameter(command, "IsOPDAppointment", DbType.Boolean, isOPDAppointment);
                    if (oPDAppointmentDate == DateTime.MinValue)
                        Database.AddInParameter(command, "OPDAppointmentDate", DbType.DateTime, DBNull.Value);
                    else
                        Database.AddInParameter(command, "OPDAppointmentDate", DbType.DateTime, oPDAppointmentDate);
                    Database.AddInParameter(command, "Clinic", DbType.String, clinic);
                    Database.AddInParameter(command, "IsFurtherInvestigationDoneInReferringHospital", DbType.Boolean, isFurtherInvestigationDoneInReferringHospital);
                    Database.AddInParameter(command, "IsPatientCantBeAccommodatedForBedUnavailability", DbType.Boolean, isPatientCantBeAccommodatedForBedUnavailability);
                    Database.AddInParameter(command, "IsNothingAdditionalCanBeOfferedRightMedication", DbType.Boolean, isNothingAdditionalCanBeOfferedRightMedication);
                    Database.AddInParameter(command, "IsNothingAdditionalCanBeOfferedIsTerminal", DbType.Boolean, isNothingAdditionalCanBeOfferedIsTerminal);
                    Database.AddInParameter(command, "IsMedicalReportIncomplete", DbType.Boolean, isMedicalReportIncomplete);
                    Database.AddInParameter(command, "IsNotAvailableSpeciality", DbType.Boolean, isNotAvailableSpeciality);
                    Database.AddInParameter(command, "IsOtherReason", DbType.Boolean, isOtherReason);
                    Database.AddInParameter(command, "OtherReason", DbType.String, otherReason);
                    Database.AddInParameter(command, "DateCreated", DbType.DateTime, dateCreated);
                    Database.AddInParameter(command, "DateModified", DbType.DateTime, dateModified);
                    if (transferToDepartmentId == 0)
                        Database.AddInParameter(command, "TransferToDepartmentId", DbType.Int32, DBNull.Value);
                    else
                        Database.AddInParameter(command, "TransferToDepartmentId", DbType.Int32, transferToDepartmentId);
				Database.AddInParameter(command,"oldEligibilityDepartmentActionId",DbType.Int32,oldeligibilityDepartmentActionId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from EligibilityDepartmentAction using Stored Procedure
		/// </summary>
		public DbCommand UpdateEligibilityDepartmentActionCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligibilityDepartmentAction");

		    		Database.AddInParameter(command,"EligibilityDepartmentId",DbType.Int32,"EligibilityDepartmentId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"EligibleId",DbType.Int32,"EligibleId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ConsultantSubmittingActionId",DbType.Int32,"ConsultantSubmittingActionId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ConsultantName",DbType.String,"ConsultantName",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Note",DbType.String,"Note",DataRowVersion.Current);
		    		Database.AddInParameter(command,"EligibilityStatusId",DbType.Int32,"EligibilityStatusId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsAdmitted",DbType.Boolean,"IsAdmitted",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AdmissionApointmentDate",DbType.DateTime,"AdmissionApointmentDate",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Ward",DbType.String,"Ward",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsOPDAppointment",DbType.Boolean,"IsOPDAppointment",DataRowVersion.Current);
		    		Database.AddInParameter(command,"OPDAppointmentDate",DbType.DateTime,"OPDAppointmentDate",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Clinic",DbType.String,"Clinic",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsFurtherInvestigationDoneInReferringHospital",DbType.Boolean,"IsFurtherInvestigationDoneInReferringHospital",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsPatientCantBeAccommodatedForBedUnavailability",DbType.Boolean,"IsPatientCantBeAccommodatedForBedUnavailability",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsNothingAdditionalCanBeOfferedRightMedication",DbType.Boolean,"IsNothingAdditionalCanBeOfferedRightMedication",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsNothingAdditionalCanBeOfferedIsTerminal",DbType.Boolean,"IsNothingAdditionalCanBeOfferedIsTerminal",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsMedicalReportIncomplete",DbType.Boolean,"IsMedicalReportIncomplete",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsNotAvailableSpeciality",DbType.Boolean,"IsNotAvailableSpeciality",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsOtherReason",DbType.Boolean,"IsOtherReason",DataRowVersion.Current);
		    		Database.AddInParameter(command,"OtherReason",DbType.String,"OtherReason",DataRowVersion.Current);
		    		Database.AddInParameter(command,"DateCreated",DbType.DateTime,"DateCreated",DataRowVersion.Current);
		    		Database.AddInParameter(command,"DateModified",DbType.DateTime,"DateModified",DataRowVersion.Current);
		    		Database.AddInParameter(command,"TransferToDepartmentId",DbType.Int32,"TransferToDepartmentId",DataRowVersion.Current);
				Database.AddInParameter(command,"oldEligibilityDepartmentActionId",DbType.Int32,"EligibilityDepartmentActionId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From EligibilityDepartmentAction using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteEligibilityDepartmentAction( int eligibilityDepartmentActionId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteEligibilityDepartmentAction");
			Database.AddInParameter(command,"EligibilityDepartmentActionId",DbType.Int32,eligibilityDepartmentActionId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From EligibilityDepartmentAction Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteEligibilityDepartmentActionCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteEligibilityDepartmentAction");
				Database.AddInParameter(command,"EligibilityDepartmentActionId",DbType.Int32,"EligibilityDepartmentActionId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table EligibilityDepartmentAction using Stored Procedure
		/// and return number of rows effected of the EligibilityDepartmentAction
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"EligibilityDepartmentAction",InsertNewEligibilityDepartmentActionCommand(),UpdateEligibilityDepartmentActionCommand(),DeleteEligibilityDepartmentActionCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table EligibilityDepartmentAction using Stored Procedure
		/// and return number of rows effected of the EligibilityDepartmentAction
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"EligibilityDepartmentAction",InsertNewEligibilityDepartmentActionCommand(),UpdateEligibilityDepartmentActionCommand(),DeleteEligibilityDepartmentActionCommand(), transaction);
          return rowsAffected;
		}


	}
}
