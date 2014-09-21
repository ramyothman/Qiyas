using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace DataAccessLayer.DataAccessComponents.Eligibility
{
	/// <summary>
	/// This is a Data Access Class  for Eligible table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the Eligible table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class EligibleDAC : DataAccessComponent
	{
		#region Constructors
		public EligibleDAC(){}
		public EligibleDAC(string connectionString): base(connectionString){}
		public EligibleDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Eligible using Stored Procedure
		/// and return a DataTable containing all Eligible Data
		/// </summary>
		public DataTable GetAllEligible()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Eligible";
         string query = " select * from GetAllEligible";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["Eligible"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Eligible using Stored Procedure
		/// and return a DataTable containing all Eligible Data using a Transaction
		/// </summary>
		public DataTable GetAllEligible(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Eligible";
         string query = " select * from GetAllEligible";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["Eligible"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Eligible using Stored Procedure
		/// and return a DataTable containing all Eligible Data
		/// </summary>
		public DataTable GetAllEligible(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Eligible";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllEligible" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames);
         return ds.Tables["Eligible"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all Eligible using Stored Procedure
		/// and return a DataTable containing all Eligible Data using a Transaction
		/// </summary>
		public DataTable GetAllEligible(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "Eligible";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllEligible" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["Eligible"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From Eligible using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDEligible( int eligibleId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDEligible");
				    Database.AddInParameter(command,"EligibleId",DbType.Int32,eligibleId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From Eligible using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDEligible( int eligibleId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDEligible");
				    Database.AddInParameter(command,"EligibleId",DbType.Int32,eligibleId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into Eligible using Stored Procedure
		/// and return the auto number primary key of Eligible inserted row
		/// </summary>
		public bool InsertNewEligible( ref int eligibleId,  string patientId,  string patientName,  string nationalityId,  int age,  string mobile,  string fax,  string email,  string transferredFrom,  int currentTransferredToDepartmentId,  int currentEligibilityStatusId,  bool isAdmitted,  DateTime admissionApointmentDate,  string ward,  bool isOPDAppointment,  DateTime oPDAppointmentDate,  string homePhone,  string clinic,  bool isFurtherInvestigationDoneInReferringHospital,  bool isPatientCantBeAccommodatedForBedUnavailability,  bool isNothingAdditionalCanBeOfferedRightMedication,  bool isNothingAdditionalCanBeOfferedIsTerminal,  bool isMedicalReportIncomplete,  bool isNotAvailableSpeciality,  bool isOtherReason,  string otherReason,  string consultantName,int DivisionID,int ConsultantID)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligible");
				Database.AddOutParameter(command,"EligibleId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"PatientId",DbType.String,patientId);
				Database.AddInParameter(command,"PatientName",DbType.String,patientName);
				Database.AddInParameter(command,"NationalityId",DbType.String,nationalityId);
				Database.AddInParameter(command,"Age",DbType.Int32,age);
				Database.AddInParameter(command,"Mobile",DbType.String,mobile);
				Database.AddInParameter(command,"Fax",DbType.String,fax);
				Database.AddInParameter(command,"Email",DbType.String,email);
				Database.AddInParameter(command,"TransferredFrom",DbType.String,transferredFrom);
                if (currentTransferredToDepartmentId == 0)
                    Database.AddInParameter(command, "CurrentTransferredToDepartmentId", DbType.Int32, DBNull.Value);
                else
                    Database.AddInParameter(command, "CurrentTransferredToDepartmentId", DbType.Int32, currentTransferredToDepartmentId);
				Database.AddInParameter(command,"CurrentEligibilityStatusId",DbType.Int32,currentEligibilityStatusId);
				Database.AddInParameter(command,"IsAdmitted",DbType.Boolean,isAdmitted);
            if(admissionApointmentDate == DateTime.MinValue)
				Database.AddInParameter(command,"AdmissionApointmentDate",DbType.DateTime,DBNull.Value);
            else
                Database.AddInParameter(command, "AdmissionApointmentDate", DbType.DateTime, admissionApointmentDate);
				Database.AddInParameter(command,"Ward",DbType.String,ward);
				Database.AddInParameter(command,"IsOPDAppointment",DbType.Boolean,isOPDAppointment);
            if(oPDAppointmentDate == DateTime.MinValue)
				Database.AddInParameter(command,"OPDAppointmentDate",DbType.DateTime,DBNull.Value);
            else
                Database.AddInParameter(command, "OPDAppointmentDate", DbType.DateTime, oPDAppointmentDate);
				Database.AddInParameter(command,"HomePhone",DbType.String,homePhone);
				Database.AddInParameter(command,"Clinic",DbType.String,clinic);
				Database.AddInParameter(command,"IsFurtherInvestigationDoneInReferringHospital",DbType.Boolean,isFurtherInvestigationDoneInReferringHospital);
				Database.AddInParameter(command,"IsPatientCantBeAccommodatedForBedUnavailability",DbType.Boolean,isPatientCantBeAccommodatedForBedUnavailability);
				Database.AddInParameter(command,"IsNothingAdditionalCanBeOfferedRightMedication",DbType.Boolean,isNothingAdditionalCanBeOfferedRightMedication);
				Database.AddInParameter(command,"IsNothingAdditionalCanBeOfferedIsTerminal",DbType.Boolean,isNothingAdditionalCanBeOfferedIsTerminal);
				Database.AddInParameter(command,"IsMedicalReportIncomplete",DbType.Boolean,isMedicalReportIncomplete);
				Database.AddInParameter(command,"IsNotAvailableSpeciality",DbType.Boolean,isNotAvailableSpeciality);
				Database.AddInParameter(command,"IsOtherReason",DbType.Boolean,isOtherReason);
				Database.AddInParameter(command,"OtherReason",DbType.String,otherReason);
				Database.AddInParameter(command,"ConsultantName",DbType.String,consultantName);
            if(DivisionID == 0)
                Database.AddInParameter(command, "DivisionID", DbType.Int32, DBNull.Value);
            else
                Database.AddInParameter(command, "DivisionID", DbType.Int32, DivisionID);
            if(ConsultantID == 0)
                Database.AddInParameter(command, "ConsultantID", DbType.Int32, DBNull.Value);
            else
                Database.AddInParameter(command, "ConsultantID", DbType.Int32, ConsultantID);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 eligibleId = Convert.ToInt32(Database.GetParameterValue(command, "EligibleId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into Eligible using Stored Procedure
		/// and return the auto number primary key of Eligible inserted row using Transaction
		/// </summary>
        public bool InsertNewEligible(ref int eligibleId, string patientId, string patientName, string nationalityId, int age, string mobile, string fax, string email, string transferredFrom, int currentTransferredToDepartmentId, int currentEligibilityStatusId, bool isAdmitted, DateTime admissionApointmentDate, string ward, bool isOPDAppointment, DateTime oPDAppointmentDate, string homePhone, string clinic, bool isFurtherInvestigationDoneInReferringHospital, bool isPatientCantBeAccommodatedForBedUnavailability, bool isNothingAdditionalCanBeOfferedRightMedication, bool isNothingAdditionalCanBeOfferedIsTerminal, bool isMedicalReportIncomplete, bool isNotAvailableSpeciality, bool isOtherReason, string otherReason, string consultantName, int DivisionID, int ConsultantID, DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligible");
				Database.AddOutParameter(command,"EligibleId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"PatientId",DbType.String,patientId);
				Database.AddInParameter(command,"PatientName",DbType.String,patientName);
				Database.AddInParameter(command,"NationalityId",DbType.String,nationalityId);
				Database.AddInParameter(command,"Age",DbType.Int32,age);
				Database.AddInParameter(command,"Mobile",DbType.String,mobile);
				Database.AddInParameter(command,"Fax",DbType.String,fax);
				Database.AddInParameter(command,"Email",DbType.String,email);
				Database.AddInParameter(command,"TransferredFrom",DbType.String,transferredFrom);
            if(currentTransferredToDepartmentId == 0)
				Database.AddInParameter(command,"CurrentTransferredToDepartmentId",DbType.Int32,DBNull.Value);
            else
                Database.AddInParameter(command, "CurrentTransferredToDepartmentId", DbType.Int32, currentTransferredToDepartmentId);
				Database.AddInParameter(command,"CurrentEligibilityStatusId",DbType.Int32,currentEligibilityStatusId);
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
				Database.AddInParameter(command,"HomePhone",DbType.String,homePhone);
				Database.AddInParameter(command,"Clinic",DbType.String,clinic);
				Database.AddInParameter(command,"IsFurtherInvestigationDoneInReferringHospital",DbType.Boolean,isFurtherInvestigationDoneInReferringHospital);
				Database.AddInParameter(command,"IsPatientCantBeAccommodatedForBedUnavailability",DbType.Boolean,isPatientCantBeAccommodatedForBedUnavailability);
				Database.AddInParameter(command,"IsNothingAdditionalCanBeOfferedRightMedication",DbType.Boolean,isNothingAdditionalCanBeOfferedRightMedication);
				Database.AddInParameter(command,"IsNothingAdditionalCanBeOfferedIsTerminal",DbType.Boolean,isNothingAdditionalCanBeOfferedIsTerminal);
				Database.AddInParameter(command,"IsMedicalReportIncomplete",DbType.Boolean,isMedicalReportIncomplete);
				Database.AddInParameter(command,"IsNotAvailableSpeciality",DbType.Boolean,isNotAvailableSpeciality);
				Database.AddInParameter(command,"IsOtherReason",DbType.Boolean,isOtherReason);
				Database.AddInParameter(command,"OtherReason",DbType.String,otherReason);
				Database.AddInParameter(command,"ConsultantName",DbType.String,consultantName);
                if (DivisionID == 0)
                    Database.AddInParameter(command, "DivisionID", DbType.Int32, DBNull.Value);
                else
                    Database.AddInParameter(command, "DivisionID", DbType.Int32, DivisionID);
                if (ConsultantID == 0)
                    Database.AddInParameter(command, "ConsultantID", DbType.Int32, DBNull.Value);
                else
                    Database.AddInParameter(command, "ConsultantID", DbType.Int32, ConsultantID);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 eligibleId = Convert.ToInt32(Database.GetParameterValue(command, "EligibleId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for Eligible using Stored Procedure
		/// and return DbCommand of the Eligible
		/// </summary>
		public DbCommand InsertNewEligibleCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewEligible");

				Database.AddInParameter(command,"PatientId",DbType.String,"PatientId",DataRowVersion.Current);
				Database.AddInParameter(command,"PatientName",DbType.String,"PatientName",DataRowVersion.Current);
				Database.AddInParameter(command,"NationalityId",DbType.String,"NationalityId",DataRowVersion.Current);
				Database.AddInParameter(command,"Age",DbType.Int32,"Age",DataRowVersion.Current);
				Database.AddInParameter(command,"Mobile",DbType.String,"Mobile",DataRowVersion.Current);
				Database.AddInParameter(command,"Fax",DbType.String,"Fax",DataRowVersion.Current);
				Database.AddInParameter(command,"Email",DbType.String,"Email",DataRowVersion.Current);
				Database.AddInParameter(command,"TransferredFrom",DbType.String,"TransferredFrom",DataRowVersion.Current);
				Database.AddInParameter(command,"CurrentTransferredToDepartmentId",DbType.Int32,"CurrentTransferredToDepartmentId",DataRowVersion.Current);
				Database.AddInParameter(command,"CurrentEligibilityStatusId",DbType.Int32,"CurrentEligibilityStatusId",DataRowVersion.Current);
				Database.AddInParameter(command,"IsAdmitted",DbType.Boolean,"IsAdmitted",DataRowVersion.Current);
				Database.AddInParameter(command,"AdmissionApointmentDate",DbType.DateTime,"AdmissionApointmentDate",DataRowVersion.Current);
				Database.AddInParameter(command,"Ward",DbType.String,"Ward",DataRowVersion.Current);
				Database.AddInParameter(command,"IsOPDAppointment",DbType.Boolean,"IsOPDAppointment",DataRowVersion.Current);
				Database.AddInParameter(command,"OPDAppointmentDate",DbType.DateTime,"OPDAppointmentDate",DataRowVersion.Current);
				Database.AddInParameter(command,"HomePhone",DbType.String,"HomePhone",DataRowVersion.Current);
				Database.AddInParameter(command,"Clinic",DbType.String,"Clinic",DataRowVersion.Current);
				Database.AddInParameter(command,"IsFurtherInvestigationDoneInReferringHospital",DbType.Boolean,"IsFurtherInvestigationDoneInReferringHospital",DataRowVersion.Current);
				Database.AddInParameter(command,"IsPatientCantBeAccommodatedForBedUnavailability",DbType.Boolean,"IsPatientCantBeAccommodatedForBedUnavailability",DataRowVersion.Current);
				Database.AddInParameter(command,"IsNothingAdditionalCanBeOfferedRightMedication",DbType.Boolean,"IsNothingAdditionalCanBeOfferedRightMedication",DataRowVersion.Current);
				Database.AddInParameter(command,"IsNothingAdditionalCanBeOfferedIsTerminal",DbType.Boolean,"IsNothingAdditionalCanBeOfferedIsTerminal",DataRowVersion.Current);
				Database.AddInParameter(command,"IsMedicalReportIncomplete",DbType.Boolean,"IsMedicalReportIncomplete",DataRowVersion.Current);
				Database.AddInParameter(command,"IsNotAvailableSpeciality",DbType.Boolean,"IsNotAvailableSpeciality",DataRowVersion.Current);
				Database.AddInParameter(command,"IsOtherReason",DbType.Boolean,"IsOtherReason",DataRowVersion.Current);
				Database.AddInParameter(command,"OtherReason",DbType.String,"OtherReason",DataRowVersion.Current);
				Database.AddInParameter(command,"ConsultantName",DbType.String,"ConsultantName",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into Eligible using Stored Procedure
		/// </summary>
        public bool UpdateEligible(string patientId, string patientName, string nationalityId, int age, string mobile, string fax, string email, string transferredFrom, int currentTransferredToDepartmentId, int currentEligibilityStatusId, bool isAdmitted, DateTime admissionApointmentDate, string ward, bool isOPDAppointment, DateTime oPDAppointmentDate, string homePhone, string clinic, bool isFurtherInvestigationDoneInReferringHospital, bool isPatientCantBeAccommodatedForBedUnavailability, bool isNothingAdditionalCanBeOfferedRightMedication, bool isNothingAdditionalCanBeOfferedIsTerminal, bool isMedicalReportIncomplete, bool isNotAvailableSpeciality, bool isOtherReason, string otherReason, string consultantName, int DivisionID, int ConsultantID, int oldeligibleId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligible");

		    		Database.AddInParameter(command,"PatientId",DbType.String,patientId);
		    		Database.AddInParameter(command,"PatientName",DbType.String,patientName);
		    		Database.AddInParameter(command,"NationalityId",DbType.String,nationalityId);
		    		Database.AddInParameter(command,"Age",DbType.Int32,age);
		    		Database.AddInParameter(command,"Mobile",DbType.String,mobile);
		    		Database.AddInParameter(command,"Fax",DbType.String,fax);
		    		Database.AddInParameter(command,"Email",DbType.String,email);
		    		Database.AddInParameter(command,"TransferredFrom",DbType.String,transferredFrom);
                    if (currentTransferredToDepartmentId == 0)
                        Database.AddInParameter(command, "CurrentTransferredToDepartmentId", DbType.Int32, DBNull.Value);
                    else
                        Database.AddInParameter(command, "CurrentTransferredToDepartmentId", DbType.Int32, currentTransferredToDepartmentId);
		    		Database.AddInParameter(command,"CurrentEligibilityStatusId",DbType.Int32,currentEligibilityStatusId);
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
		    		Database.AddInParameter(command,"HomePhone",DbType.String,homePhone);
		    		Database.AddInParameter(command,"Clinic",DbType.String,clinic);
		    		Database.AddInParameter(command,"IsFurtherInvestigationDoneInReferringHospital",DbType.Boolean,isFurtherInvestigationDoneInReferringHospital);
		    		Database.AddInParameter(command,"IsPatientCantBeAccommodatedForBedUnavailability",DbType.Boolean,isPatientCantBeAccommodatedForBedUnavailability);
		    		Database.AddInParameter(command,"IsNothingAdditionalCanBeOfferedRightMedication",DbType.Boolean,isNothingAdditionalCanBeOfferedRightMedication);
		    		Database.AddInParameter(command,"IsNothingAdditionalCanBeOfferedIsTerminal",DbType.Boolean,isNothingAdditionalCanBeOfferedIsTerminal);
		    		Database.AddInParameter(command,"IsMedicalReportIncomplete",DbType.Boolean,isMedicalReportIncomplete);
		    		Database.AddInParameter(command,"IsNotAvailableSpeciality",DbType.Boolean,isNotAvailableSpeciality);
		    		Database.AddInParameter(command,"IsOtherReason",DbType.Boolean,isOtherReason);
		    		Database.AddInParameter(command,"OtherReason",DbType.String,otherReason);
		    		Database.AddInParameter(command,"ConsultantName",DbType.String,consultantName);
                    if (DivisionID == 0)
                        Database.AddInParameter(command, "DivisionID", DbType.Int32, DBNull.Value);
                    else
                        Database.AddInParameter(command, "DivisionID", DbType.Int32, DivisionID);
                    if (ConsultantID == 0)
                        Database.AddInParameter(command, "ConsultantID", DbType.Int32, DBNull.Value);
                    else
                        Database.AddInParameter(command, "ConsultantID", DbType.Int32, ConsultantID);
				Database.AddInParameter(command,"oldEligibleId",DbType.Int32,oldeligibleId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into Eligible using Stored Procedure By Transaction
		/// </summary>
        public bool UpdateEligible(string patientId, string patientName, string nationalityId, int age, string mobile, string fax, string email, string transferredFrom, int currentTransferredToDepartmentId, int currentEligibilityStatusId, bool isAdmitted, DateTime admissionApointmentDate, string ward, bool isOPDAppointment, DateTime oPDAppointmentDate, string homePhone, string clinic, bool isFurtherInvestigationDoneInReferringHospital, bool isPatientCantBeAccommodatedForBedUnavailability, bool isNothingAdditionalCanBeOfferedRightMedication, bool isNothingAdditionalCanBeOfferedIsTerminal, bool isMedicalReportIncomplete, bool isNotAvailableSpeciality, bool isOtherReason, string otherReason, string consultantName, int DivisionID, int ConsultantID, int oldeligibleId, DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligible");

		    		Database.AddInParameter(command,"PatientId",DbType.String,patientId);
		    		Database.AddInParameter(command,"PatientName",DbType.String,patientName);
		    		Database.AddInParameter(command,"NationalityId",DbType.String,nationalityId);
		    		Database.AddInParameter(command,"Age",DbType.Int32,age);
		    		Database.AddInParameter(command,"Mobile",DbType.String,mobile);
		    		Database.AddInParameter(command,"Fax",DbType.String,fax);
		    		Database.AddInParameter(command,"Email",DbType.String,email);
		    		Database.AddInParameter(command,"TransferredFrom",DbType.String,transferredFrom);
                    if (currentTransferredToDepartmentId == 0)
                        Database.AddInParameter(command, "CurrentTransferredToDepartmentId", DbType.Int32, DBNull.Value);
                    else
                        Database.AddInParameter(command, "CurrentTransferredToDepartmentId", DbType.Int32, currentTransferredToDepartmentId);
		    		Database.AddInParameter(command,"CurrentEligibilityStatusId",DbType.Int32,currentEligibilityStatusId);
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
		    		Database.AddInParameter(command,"HomePhone",DbType.String,homePhone);
		    		Database.AddInParameter(command,"Clinic",DbType.String,clinic);
		    		Database.AddInParameter(command,"IsFurtherInvestigationDoneInReferringHospital",DbType.Boolean,isFurtherInvestigationDoneInReferringHospital);
		    		Database.AddInParameter(command,"IsPatientCantBeAccommodatedForBedUnavailability",DbType.Boolean,isPatientCantBeAccommodatedForBedUnavailability);
		    		Database.AddInParameter(command,"IsNothingAdditionalCanBeOfferedRightMedication",DbType.Boolean,isNothingAdditionalCanBeOfferedRightMedication);
		    		Database.AddInParameter(command,"IsNothingAdditionalCanBeOfferedIsTerminal",DbType.Boolean,isNothingAdditionalCanBeOfferedIsTerminal);
		    		Database.AddInParameter(command,"IsMedicalReportIncomplete",DbType.Boolean,isMedicalReportIncomplete);
		    		Database.AddInParameter(command,"IsNotAvailableSpeciality",DbType.Boolean,isNotAvailableSpeciality);
		    		Database.AddInParameter(command,"IsOtherReason",DbType.Boolean,isOtherReason);
		    		Database.AddInParameter(command,"OtherReason",DbType.String,otherReason);
		    		Database.AddInParameter(command,"ConsultantName",DbType.String,consultantName);
                    if (DivisionID == 0)
                        Database.AddInParameter(command, "DivisionID", DbType.Int32, DBNull.Value);
                    else
                        Database.AddInParameter(command, "DivisionID", DbType.Int32, DivisionID);
                    if (ConsultantID == 0)
                        Database.AddInParameter(command, "ConsultantID", DbType.Int32, DBNull.Value);
                    else
                        Database.AddInParameter(command, "ConsultantID", DbType.Int32, ConsultantID);
				Database.AddInParameter(command,"oldEligibleId",DbType.Int32,oldeligibleId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from Eligible using Stored Procedure
		/// </summary>
		public DbCommand UpdateEligibleCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateEligible");

		    		Database.AddInParameter(command,"PatientId",DbType.String,"PatientId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"PatientName",DbType.String,"PatientName",DataRowVersion.Current);
		    		Database.AddInParameter(command,"NationalityId",DbType.String,"NationalityId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Age",DbType.Int32,"Age",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Mobile",DbType.String,"Mobile",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Fax",DbType.String,"Fax",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Email",DbType.String,"Email",DataRowVersion.Current);
		    		Database.AddInParameter(command,"TransferredFrom",DbType.String,"TransferredFrom",DataRowVersion.Current);
		    		Database.AddInParameter(command,"CurrentTransferredToDepartmentId",DbType.Int32,"CurrentTransferredToDepartmentId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"CurrentEligibilityStatusId",DbType.Int32,"CurrentEligibilityStatusId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsAdmitted",DbType.Boolean,"IsAdmitted",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AdmissionApointmentDate",DbType.DateTime,"AdmissionApointmentDate",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Ward",DbType.String,"Ward",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsOPDAppointment",DbType.Boolean,"IsOPDAppointment",DataRowVersion.Current);
		    		Database.AddInParameter(command,"OPDAppointmentDate",DbType.DateTime,"OPDAppointmentDate",DataRowVersion.Current);
		    		Database.AddInParameter(command,"HomePhone",DbType.String,"HomePhone",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Clinic",DbType.String,"Clinic",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsFurtherInvestigationDoneInReferringHospital",DbType.Boolean,"IsFurtherInvestigationDoneInReferringHospital",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsPatientCantBeAccommodatedForBedUnavailability",DbType.Boolean,"IsPatientCantBeAccommodatedForBedUnavailability",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsNothingAdditionalCanBeOfferedRightMedication",DbType.Boolean,"IsNothingAdditionalCanBeOfferedRightMedication",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsNothingAdditionalCanBeOfferedIsTerminal",DbType.Boolean,"IsNothingAdditionalCanBeOfferedIsTerminal",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsMedicalReportIncomplete",DbType.Boolean,"IsMedicalReportIncomplete",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsNotAvailableSpeciality",DbType.Boolean,"IsNotAvailableSpeciality",DataRowVersion.Current);
		    		Database.AddInParameter(command,"IsOtherReason",DbType.Boolean,"IsOtherReason",DataRowVersion.Current);
		    		Database.AddInParameter(command,"OtherReason",DbType.String,"OtherReason",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ConsultantName",DbType.String,"ConsultantName",DataRowVersion.Current);
				Database.AddInParameter(command,"oldEligibleId",DbType.Int32,"EligibleId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From Eligible using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteEligible( int eligibleId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteEligible");
			Database.AddInParameter(command,"EligibleId",DbType.Int32,eligibleId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From Eligible Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteEligibleCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteEligible");
				Database.AddInParameter(command,"EligibleId",DbType.Int32,"EligibleId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table Eligible using Stored Procedure
		/// and return number of rows effected of the Eligible
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"Eligible",InsertNewEligibleCommand(),UpdateEligibleCommand(),DeleteEligibleCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table Eligible using Stored Procedure
		/// and return number of rows effected of the Eligible
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"Eligible",InsertNewEligibleCommand(),UpdateEligibleCommand(),DeleteEligibleCommand(), transaction);
          return rowsAffected;
		}


	}
}
