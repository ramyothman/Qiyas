using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.Eligibility;
using BusinessLogicLayer.Entities.Eligibility;
namespace BusinessLogicLayer.Components.Eligibility
{
	/// <summary>
	/// This is a Business Logic Component Class  for Eligible table
	/// This class RAPs the EligibleDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class EligibleLogic : BusinessLogic
	{
		public EligibleLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<Eligible> GetAll()
         {
             EligibleDAC _eligibleComponent = new EligibleDAC();
             IDataReader reader =  _eligibleComponent.GetAllEligible().CreateDataReader();
             List<Eligible> _eligibleList = new List<Eligible>();
             while(reader.Read())
             {
             if(_eligibleList == null)
                 _eligibleList = new List<Eligible>();
                 Eligible _eligible = new Eligible();
                 if(reader["EligibleId"] != DBNull.Value)
                     _eligible.EligibleId = Convert.ToInt32(reader["EligibleId"]);
                 if(reader["PatientId"] != DBNull.Value)
                     _eligible.PatientId = Convert.ToString(reader["PatientId"]);
                 if(reader["PatientName"] != DBNull.Value)
                     _eligible.PatientName = Convert.ToString(reader["PatientName"]);
                 if(reader["NationalityId"] != DBNull.Value)
                     _eligible.NationalityId = Convert.ToString(reader["NationalityId"]);
                 if(reader["Age"] != DBNull.Value)
                     _eligible.Age = Convert.ToInt32(reader["Age"]);
                 if(reader["Mobile"] != DBNull.Value)
                     _eligible.Mobile = Convert.ToString(reader["Mobile"]);
                 if(reader["Fax"] != DBNull.Value)
                     _eligible.Fax = Convert.ToString(reader["Fax"]);
                 if(reader["Email"] != DBNull.Value)
                     _eligible.Email = Convert.ToString(reader["Email"]);
                 if(reader["TransferredFrom"] != DBNull.Value)
                     _eligible.TransferredFrom = Convert.ToString(reader["TransferredFrom"]);
                 if(reader["CurrentTransferredToDepartmentId"] != DBNull.Value)
                     _eligible.CurrentTransferredToDepartmentId = Convert.ToInt32(reader["CurrentTransferredToDepartmentId"]);
                 if(reader["CurrentEligibilityStatusId"] != DBNull.Value)
                     _eligible.CurrentEligibilityStatusId = Convert.ToInt32(reader["CurrentEligibilityStatusId"]);
                 if(reader["IsAdmitted"] != DBNull.Value)
                     _eligible.IsAdmitted = Convert.ToBoolean(reader["IsAdmitted"]);
                 if(reader["AdmissionApointmentDate"] != DBNull.Value)
                     _eligible.AdmissionApointmentDate = Convert.ToDateTime(reader["AdmissionApointmentDate"]);
                 if(reader["Ward"] != DBNull.Value)
                     _eligible.Ward = Convert.ToString(reader["Ward"]);
                 if(reader["IsOPDAppointment"] != DBNull.Value)
                     _eligible.IsOPDAppointment = Convert.ToBoolean(reader["IsOPDAppointment"]);
                 if(reader["OPDAppointmentDate"] != DBNull.Value)
                     _eligible.OPDAppointmentDate = Convert.ToDateTime(reader["OPDAppointmentDate"]);
                 if(reader["HomePhone"] != DBNull.Value)
                     _eligible.HomePhone = Convert.ToString(reader["HomePhone"]);
                 if(reader["Clinic"] != DBNull.Value)
                     _eligible.Clinic = Convert.ToString(reader["Clinic"]);
                 if(reader["IsFurtherInvestigationDoneInReferringHospital"] != DBNull.Value)
                     _eligible.IsFurtherInvestigationDoneInReferringHospital = Convert.ToBoolean(reader["IsFurtherInvestigationDoneInReferringHospital"]);
                 if(reader["IsPatientCantBeAccommodatedForBedUnavailability"] != DBNull.Value)
                     _eligible.IsPatientCantBeAccommodatedForBedUnavailability = Convert.ToBoolean(reader["IsPatientCantBeAccommodatedForBedUnavailability"]);
                 if(reader["IsNothingAdditionalCanBeOfferedRightMedication"] != DBNull.Value)
                     _eligible.IsNothingAdditionalCanBeOfferedRightMedication = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedRightMedication"]);
                 if(reader["IsNothingAdditionalCanBeOfferedIsTerminal"] != DBNull.Value)
                     _eligible.IsNothingAdditionalCanBeOfferedIsTerminal = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedIsTerminal"]);
                 if(reader["IsMedicalReportIncomplete"] != DBNull.Value)
                     _eligible.IsMedicalReportIncomplete = Convert.ToBoolean(reader["IsMedicalReportIncomplete"]);
                 if(reader["IsNotAvailableSpeciality"] != DBNull.Value)
                     _eligible.IsNotAvailableSpeciality = Convert.ToBoolean(reader["IsNotAvailableSpeciality"]);
                 if(reader["IsOtherReason"] != DBNull.Value)
                     _eligible.IsOtherReason = Convert.ToBoolean(reader["IsOtherReason"]);
                 if(reader["OtherReason"] != DBNull.Value)
                     _eligible.OtherReason = Convert.ToString(reader["OtherReason"]);
                 if(reader["ConsultantName"] != DBNull.Value)
                     _eligible.ConsultantName = Convert.ToString(reader["ConsultantName"]);
                 if (reader["ConsultantID"] != DBNull.Value)
                     _eligible.ConsultantID = Convert.ToInt32(reader["ConsultantID"]);
                 if (reader["DivisionID"] != DBNull.Value)
                     _eligible.DivisionID = Convert.ToInt32(reader["DivisionID"]);
             _eligible.NewRecord = false;
             _eligibleList.Add(_eligible);
             }             reader.Close();
             return _eligibleList;
         }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Eligible> GetAllByStatusId(int StatusId)
        {
            EligibleDAC _eligibleComponent = new EligibleDAC();
            IDataReader reader = _eligibleComponent.GetAllEligible("CurrentEligibilityStatusId = " + StatusId).CreateDataReader();
            List<Eligible> _eligibleList = new List<Eligible>();
            while (reader.Read())
            {
                if (_eligibleList == null)
                    _eligibleList = new List<Eligible>();
                Eligible _eligible = new Eligible();
                if (reader["EligibleId"] != DBNull.Value)
                    _eligible.EligibleId = Convert.ToInt32(reader["EligibleId"]);
                if (reader["PatientId"] != DBNull.Value)
                    _eligible.PatientId = Convert.ToString(reader["PatientId"]);
                if (reader["PatientName"] != DBNull.Value)
                    _eligible.PatientName = Convert.ToString(reader["PatientName"]);
                if (reader["NationalityId"] != DBNull.Value)
                    _eligible.NationalityId = Convert.ToString(reader["NationalityId"]);
                if (reader["Age"] != DBNull.Value)
                    _eligible.Age = Convert.ToInt32(reader["Age"]);
                if (reader["Mobile"] != DBNull.Value)
                    _eligible.Mobile = Convert.ToString(reader["Mobile"]);
                if (reader["Fax"] != DBNull.Value)
                    _eligible.Fax = Convert.ToString(reader["Fax"]);
                if (reader["Email"] != DBNull.Value)
                    _eligible.Email = Convert.ToString(reader["Email"]);
                if (reader["TransferredFrom"] != DBNull.Value)
                    _eligible.TransferredFrom = Convert.ToString(reader["TransferredFrom"]);
                if (reader["CurrentTransferredToDepartmentId"] != DBNull.Value)
                    _eligible.CurrentTransferredToDepartmentId = Convert.ToInt32(reader["CurrentTransferredToDepartmentId"]);
                if (reader["CurrentEligibilityStatusId"] != DBNull.Value)
                    _eligible.CurrentEligibilityStatusId = Convert.ToInt32(reader["CurrentEligibilityStatusId"]);
                if (reader["IsAdmitted"] != DBNull.Value)
                    _eligible.IsAdmitted = Convert.ToBoolean(reader["IsAdmitted"]);
                if (reader["AdmissionApointmentDate"] != DBNull.Value)
                    _eligible.AdmissionApointmentDate = Convert.ToDateTime(reader["AdmissionApointmentDate"]);
                if (reader["Ward"] != DBNull.Value)
                    _eligible.Ward = Convert.ToString(reader["Ward"]);
                if (reader["IsOPDAppointment"] != DBNull.Value)
                    _eligible.IsOPDAppointment = Convert.ToBoolean(reader["IsOPDAppointment"]);
                if (reader["OPDAppointmentDate"] != DBNull.Value)
                    _eligible.OPDAppointmentDate = Convert.ToDateTime(reader["OPDAppointmentDate"]);
                if (reader["HomePhone"] != DBNull.Value)
                    _eligible.HomePhone = Convert.ToString(reader["HomePhone"]);
                if (reader["Clinic"] != DBNull.Value)
                    _eligible.Clinic = Convert.ToString(reader["Clinic"]);
                if (reader["IsFurtherInvestigationDoneInReferringHospital"] != DBNull.Value)
                    _eligible.IsFurtherInvestigationDoneInReferringHospital = Convert.ToBoolean(reader["IsFurtherInvestigationDoneInReferringHospital"]);
                if (reader["IsPatientCantBeAccommodatedForBedUnavailability"] != DBNull.Value)
                    _eligible.IsPatientCantBeAccommodatedForBedUnavailability = Convert.ToBoolean(reader["IsPatientCantBeAccommodatedForBedUnavailability"]);
                if (reader["IsNothingAdditionalCanBeOfferedRightMedication"] != DBNull.Value)
                    _eligible.IsNothingAdditionalCanBeOfferedRightMedication = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedRightMedication"]);
                if (reader["IsNothingAdditionalCanBeOfferedIsTerminal"] != DBNull.Value)
                    _eligible.IsNothingAdditionalCanBeOfferedIsTerminal = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedIsTerminal"]);
                if (reader["IsMedicalReportIncomplete"] != DBNull.Value)
                    _eligible.IsMedicalReportIncomplete = Convert.ToBoolean(reader["IsMedicalReportIncomplete"]);
                if (reader["IsNotAvailableSpeciality"] != DBNull.Value)
                    _eligible.IsNotAvailableSpeciality = Convert.ToBoolean(reader["IsNotAvailableSpeciality"]);
                if (reader["IsOtherReason"] != DBNull.Value)
                    _eligible.IsOtherReason = Convert.ToBoolean(reader["IsOtherReason"]);
                if (reader["OtherReason"] != DBNull.Value)
                    _eligible.OtherReason = Convert.ToString(reader["OtherReason"]);
                if (reader["ConsultantName"] != DBNull.Value)
                    _eligible.ConsultantName = Convert.ToString(reader["ConsultantName"]);
                if (reader["ConsultantID"] != DBNull.Value)
                    _eligible.ConsultantID = Convert.ToInt32(reader["ConsultantID"]);
                if (reader["DivisionID"] != DBNull.Value)
                    _eligible.DivisionID = Convert.ToInt32(reader["DivisionID"]);
                _eligible.NewRecord = false;
                _eligibleList.Add(_eligible);
            } reader.Close();
            return _eligibleList;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Eligible> GetAllPendingAction()
        {
            EligibleDAC _eligibleComponent = new EligibleDAC();
            IDataReader reader = _eligibleComponent.GetAllEligible("CurrentEligibilityStatusId Not In(4,5,1) ").CreateDataReader();
            List<Eligible> _eligibleList = new List<Eligible>();
            while (reader.Read())
            {
                if (_eligibleList == null)
                    _eligibleList = new List<Eligible>();
                Eligible _eligible = new Eligible();
                if (reader["EligibleId"] != DBNull.Value)
                    _eligible.EligibleId = Convert.ToInt32(reader["EligibleId"]);
                if (reader["PatientId"] != DBNull.Value)
                    _eligible.PatientId = Convert.ToString(reader["PatientId"]);
                if (reader["PatientName"] != DBNull.Value)
                    _eligible.PatientName = Convert.ToString(reader["PatientName"]);
                if (reader["NationalityId"] != DBNull.Value)
                    _eligible.NationalityId = Convert.ToString(reader["NationalityId"]);
                if (reader["Age"] != DBNull.Value)
                    _eligible.Age = Convert.ToInt32(reader["Age"]);
                if (reader["Mobile"] != DBNull.Value)
                    _eligible.Mobile = Convert.ToString(reader["Mobile"]);
                if (reader["Fax"] != DBNull.Value)
                    _eligible.Fax = Convert.ToString(reader["Fax"]);
                if (reader["Email"] != DBNull.Value)
                    _eligible.Email = Convert.ToString(reader["Email"]);
                if (reader["TransferredFrom"] != DBNull.Value)
                    _eligible.TransferredFrom = Convert.ToString(reader["TransferredFrom"]);
                if (reader["CurrentTransferredToDepartmentId"] != DBNull.Value)
                    _eligible.CurrentTransferredToDepartmentId = Convert.ToInt32(reader["CurrentTransferredToDepartmentId"]);
                if (reader["CurrentEligibilityStatusId"] != DBNull.Value)
                    _eligible.CurrentEligibilityStatusId = Convert.ToInt32(reader["CurrentEligibilityStatusId"]);
                if (reader["IsAdmitted"] != DBNull.Value)
                    _eligible.IsAdmitted = Convert.ToBoolean(reader["IsAdmitted"]);
                if (reader["AdmissionApointmentDate"] != DBNull.Value)
                    _eligible.AdmissionApointmentDate = Convert.ToDateTime(reader["AdmissionApointmentDate"]);
                if (reader["Ward"] != DBNull.Value)
                    _eligible.Ward = Convert.ToString(reader["Ward"]);
                if (reader["IsOPDAppointment"] != DBNull.Value)
                    _eligible.IsOPDAppointment = Convert.ToBoolean(reader["IsOPDAppointment"]);
                if (reader["OPDAppointmentDate"] != DBNull.Value)
                    _eligible.OPDAppointmentDate = Convert.ToDateTime(reader["OPDAppointmentDate"]);
                if (reader["HomePhone"] != DBNull.Value)
                    _eligible.HomePhone = Convert.ToString(reader["HomePhone"]);
                if (reader["Clinic"] != DBNull.Value)
                    _eligible.Clinic = Convert.ToString(reader["Clinic"]);
                if (reader["IsFurtherInvestigationDoneInReferringHospital"] != DBNull.Value)
                    _eligible.IsFurtherInvestigationDoneInReferringHospital = Convert.ToBoolean(reader["IsFurtherInvestigationDoneInReferringHospital"]);
                if (reader["IsPatientCantBeAccommodatedForBedUnavailability"] != DBNull.Value)
                    _eligible.IsPatientCantBeAccommodatedForBedUnavailability = Convert.ToBoolean(reader["IsPatientCantBeAccommodatedForBedUnavailability"]);
                if (reader["IsNothingAdditionalCanBeOfferedRightMedication"] != DBNull.Value)
                    _eligible.IsNothingAdditionalCanBeOfferedRightMedication = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedRightMedication"]);
                if (reader["IsNothingAdditionalCanBeOfferedIsTerminal"] != DBNull.Value)
                    _eligible.IsNothingAdditionalCanBeOfferedIsTerminal = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedIsTerminal"]);
                if (reader["IsMedicalReportIncomplete"] != DBNull.Value)
                    _eligible.IsMedicalReportIncomplete = Convert.ToBoolean(reader["IsMedicalReportIncomplete"]);
                if (reader["IsNotAvailableSpeciality"] != DBNull.Value)
                    _eligible.IsNotAvailableSpeciality = Convert.ToBoolean(reader["IsNotAvailableSpeciality"]);
                if (reader["IsOtherReason"] != DBNull.Value)
                    _eligible.IsOtherReason = Convert.ToBoolean(reader["IsOtherReason"]);
                if (reader["OtherReason"] != DBNull.Value)
                    _eligible.OtherReason = Convert.ToString(reader["OtherReason"]);
                if (reader["ConsultantName"] != DBNull.Value)
                    _eligible.ConsultantName = Convert.ToString(reader["ConsultantName"]);
                if (reader["ConsultantID"] != DBNull.Value)
                    _eligible.ConsultantID = Convert.ToInt32(reader["ConsultantID"]);
                if (reader["DivisionID"] != DBNull.Value)
                    _eligible.DivisionID = Convert.ToInt32(reader["DivisionID"]);
                _eligible.NewRecord = false;
                _eligibleList.Add(_eligible);
            } reader.Close();
            return _eligibleList;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Eligible> GetAllByDepartmentAndStatus(int DepartmentId, int StatusId)
        {
            EligibleDAC _eligibleComponent = new EligibleDAC();
            string where = "CurrentTransferredToDepartmentId = " + DepartmentId;
            if (StatusId != 0)
                where += " AND CurrentEligibilityStatusId = " + StatusId;
            
            IDataReader reader = _eligibleComponent.GetAllEligible(where).CreateDataReader();
            List<Eligible> _eligibleList = new List<Eligible>();
            while (reader.Read())
            {
                if (_eligibleList == null)
                    _eligibleList = new List<Eligible>();
                Eligible _eligible = new Eligible();
                if (reader["EligibleId"] != DBNull.Value)
                    _eligible.EligibleId = Convert.ToInt32(reader["EligibleId"]);
                if (reader["PatientId"] != DBNull.Value)
                    _eligible.PatientId = Convert.ToString(reader["PatientId"]);
                if (reader["PatientName"] != DBNull.Value)
                    _eligible.PatientName = Convert.ToString(reader["PatientName"]);
                if (reader["NationalityId"] != DBNull.Value)
                    _eligible.NationalityId = Convert.ToString(reader["NationalityId"]);
                if (reader["Age"] != DBNull.Value)
                    _eligible.Age = Convert.ToInt32(reader["Age"]);
                if (reader["Mobile"] != DBNull.Value)
                    _eligible.Mobile = Convert.ToString(reader["Mobile"]);
                if (reader["Fax"] != DBNull.Value)
                    _eligible.Fax = Convert.ToString(reader["Fax"]);
                if (reader["Email"] != DBNull.Value)
                    _eligible.Email = Convert.ToString(reader["Email"]);
                if (reader["TransferredFrom"] != DBNull.Value)
                    _eligible.TransferredFrom = Convert.ToString(reader["TransferredFrom"]);
                if (reader["CurrentTransferredToDepartmentId"] != DBNull.Value)
                    _eligible.CurrentTransferredToDepartmentId = Convert.ToInt32(reader["CurrentTransferredToDepartmentId"]);
                if (reader["CurrentEligibilityStatusId"] != DBNull.Value)
                    _eligible.CurrentEligibilityStatusId = Convert.ToInt32(reader["CurrentEligibilityStatusId"]);
                if (reader["IsAdmitted"] != DBNull.Value)
                    _eligible.IsAdmitted = Convert.ToBoolean(reader["IsAdmitted"]);
                if (reader["AdmissionApointmentDate"] != DBNull.Value)
                    _eligible.AdmissionApointmentDate = Convert.ToDateTime(reader["AdmissionApointmentDate"]);
                if (reader["Ward"] != DBNull.Value)
                    _eligible.Ward = Convert.ToString(reader["Ward"]);
                if (reader["IsOPDAppointment"] != DBNull.Value)
                    _eligible.IsOPDAppointment = Convert.ToBoolean(reader["IsOPDAppointment"]);
                if (reader["OPDAppointmentDate"] != DBNull.Value)
                    _eligible.OPDAppointmentDate = Convert.ToDateTime(reader["OPDAppointmentDate"]);
                if (reader["HomePhone"] != DBNull.Value)
                    _eligible.HomePhone = Convert.ToString(reader["HomePhone"]);
                if (reader["Clinic"] != DBNull.Value)
                    _eligible.Clinic = Convert.ToString(reader["Clinic"]);
                if (reader["IsFurtherInvestigationDoneInReferringHospital"] != DBNull.Value)
                    _eligible.IsFurtherInvestigationDoneInReferringHospital = Convert.ToBoolean(reader["IsFurtherInvestigationDoneInReferringHospital"]);
                if (reader["IsPatientCantBeAccommodatedForBedUnavailability"] != DBNull.Value)
                    _eligible.IsPatientCantBeAccommodatedForBedUnavailability = Convert.ToBoolean(reader["IsPatientCantBeAccommodatedForBedUnavailability"]);
                if (reader["IsNothingAdditionalCanBeOfferedRightMedication"] != DBNull.Value)
                    _eligible.IsNothingAdditionalCanBeOfferedRightMedication = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedRightMedication"]);
                if (reader["IsNothingAdditionalCanBeOfferedIsTerminal"] != DBNull.Value)
                    _eligible.IsNothingAdditionalCanBeOfferedIsTerminal = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedIsTerminal"]);
                if (reader["IsMedicalReportIncomplete"] != DBNull.Value)
                    _eligible.IsMedicalReportIncomplete = Convert.ToBoolean(reader["IsMedicalReportIncomplete"]);
                if (reader["IsNotAvailableSpeciality"] != DBNull.Value)
                    _eligible.IsNotAvailableSpeciality = Convert.ToBoolean(reader["IsNotAvailableSpeciality"]);
                if (reader["IsOtherReason"] != DBNull.Value)
                    _eligible.IsOtherReason = Convert.ToBoolean(reader["IsOtherReason"]);
                if (reader["OtherReason"] != DBNull.Value)
                    _eligible.OtherReason = Convert.ToString(reader["OtherReason"]);
                if (reader["ConsultantName"] != DBNull.Value)
                    _eligible.ConsultantName = Convert.ToString(reader["ConsultantName"]);
                if (reader["ConsultantID"] != DBNull.Value)
                    _eligible.ConsultantID = Convert.ToInt32(reader["ConsultantID"]);
                if (reader["DivisionID"] != DBNull.Value)
                    _eligible.DivisionID = Convert.ToInt32(reader["DivisionID"]);
                _eligible.NewRecord = false;
                _eligibleList.Add(_eligible);
            } reader.Close();
            return _eligibleList;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Eligible> GetAllPendingByDepartmentAndStatus(int DepartmentId)
        {
            EligibleDAC _eligibleComponent = new EligibleDAC();
            string where = String.Format("CurrentTransferredToDepartmentId = {0} AND CurrentEligibilityStatusId NOT IN(1,4,5)", DepartmentId);
          

            IDataReader reader = _eligibleComponent.GetAllEligible(where).CreateDataReader();
            List<Eligible> _eligibleList = new List<Eligible>();
            while (reader.Read())
            {
                if (_eligibleList == null)
                    _eligibleList = new List<Eligible>();
                Eligible _eligible = new Eligible();
                if (reader["EligibleId"] != DBNull.Value)
                    _eligible.EligibleId = Convert.ToInt32(reader["EligibleId"]);
                if (reader["PatientId"] != DBNull.Value)
                    _eligible.PatientId = Convert.ToString(reader["PatientId"]);
                if (reader["PatientName"] != DBNull.Value)
                    _eligible.PatientName = Convert.ToString(reader["PatientName"]);
                if (reader["NationalityId"] != DBNull.Value)
                    _eligible.NationalityId = Convert.ToString(reader["NationalityId"]);
                if (reader["Age"] != DBNull.Value)
                    _eligible.Age = Convert.ToInt32(reader["Age"]);
                if (reader["Mobile"] != DBNull.Value)
                    _eligible.Mobile = Convert.ToString(reader["Mobile"]);
                if (reader["Fax"] != DBNull.Value)
                    _eligible.Fax = Convert.ToString(reader["Fax"]);
                if (reader["Email"] != DBNull.Value)
                    _eligible.Email = Convert.ToString(reader["Email"]);
                if (reader["TransferredFrom"] != DBNull.Value)
                    _eligible.TransferredFrom = Convert.ToString(reader["TransferredFrom"]);
                if (reader["CurrentTransferredToDepartmentId"] != DBNull.Value)
                    _eligible.CurrentTransferredToDepartmentId = Convert.ToInt32(reader["CurrentTransferredToDepartmentId"]);
                if (reader["CurrentEligibilityStatusId"] != DBNull.Value)
                    _eligible.CurrentEligibilityStatusId = Convert.ToInt32(reader["CurrentEligibilityStatusId"]);
                if (reader["IsAdmitted"] != DBNull.Value)
                    _eligible.IsAdmitted = Convert.ToBoolean(reader["IsAdmitted"]);
                if (reader["AdmissionApointmentDate"] != DBNull.Value)
                    _eligible.AdmissionApointmentDate = Convert.ToDateTime(reader["AdmissionApointmentDate"]);
                if (reader["Ward"] != DBNull.Value)
                    _eligible.Ward = Convert.ToString(reader["Ward"]);
                if (reader["IsOPDAppointment"] != DBNull.Value)
                    _eligible.IsOPDAppointment = Convert.ToBoolean(reader["IsOPDAppointment"]);
                if (reader["OPDAppointmentDate"] != DBNull.Value)
                    _eligible.OPDAppointmentDate = Convert.ToDateTime(reader["OPDAppointmentDate"]);
                if (reader["HomePhone"] != DBNull.Value)
                    _eligible.HomePhone = Convert.ToString(reader["HomePhone"]);
                if (reader["Clinic"] != DBNull.Value)
                    _eligible.Clinic = Convert.ToString(reader["Clinic"]);
                if (reader["IsFurtherInvestigationDoneInReferringHospital"] != DBNull.Value)
                    _eligible.IsFurtherInvestigationDoneInReferringHospital = Convert.ToBoolean(reader["IsFurtherInvestigationDoneInReferringHospital"]);
                if (reader["IsPatientCantBeAccommodatedForBedUnavailability"] != DBNull.Value)
                    _eligible.IsPatientCantBeAccommodatedForBedUnavailability = Convert.ToBoolean(reader["IsPatientCantBeAccommodatedForBedUnavailability"]);
                if (reader["IsNothingAdditionalCanBeOfferedRightMedication"] != DBNull.Value)
                    _eligible.IsNothingAdditionalCanBeOfferedRightMedication = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedRightMedication"]);
                if (reader["IsNothingAdditionalCanBeOfferedIsTerminal"] != DBNull.Value)
                    _eligible.IsNothingAdditionalCanBeOfferedIsTerminal = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedIsTerminal"]);
                if (reader["IsMedicalReportIncomplete"] != DBNull.Value)
                    _eligible.IsMedicalReportIncomplete = Convert.ToBoolean(reader["IsMedicalReportIncomplete"]);
                if (reader["IsNotAvailableSpeciality"] != DBNull.Value)
                    _eligible.IsNotAvailableSpeciality = Convert.ToBoolean(reader["IsNotAvailableSpeciality"]);
                if (reader["IsOtherReason"] != DBNull.Value)
                    _eligible.IsOtherReason = Convert.ToBoolean(reader["IsOtherReason"]);
                if (reader["OtherReason"] != DBNull.Value)
                    _eligible.OtherReason = Convert.ToString(reader["OtherReason"]);
                if (reader["ConsultantName"] != DBNull.Value)
                    _eligible.ConsultantName = Convert.ToString(reader["ConsultantName"]);
                if (reader["ConsultantID"] != DBNull.Value)
                    _eligible.ConsultantID = Convert.ToInt32(reader["ConsultantID"]);
                if (reader["DivisionID"] != DBNull.Value)
                    _eligible.DivisionID = Convert.ToInt32(reader["DivisionID"]);
                _eligible.NewRecord = false;
                _eligibleList.Add(_eligible);
            } reader.Close();
            return _eligibleList;
        }
        #region Insert And Update
		public bool Insert(Eligible eligible)
		{
			int autonumber = 0;
			EligibleDAC eligibleComponent = new EligibleDAC();
			bool endedSuccessfuly = eligibleComponent.InsertNewEligible( ref autonumber,  eligible.PatientId,  eligible.PatientName,  eligible.NationalityId,  eligible.Age,  eligible.Mobile,  eligible.Fax,  eligible.Email,  eligible.TransferredFrom,  eligible.CurrentTransferredToDepartmentId,  eligible.CurrentEligibilityStatusId,  eligible.IsAdmitted,  eligible.AdmissionApointmentDate,  eligible.Ward,  eligible.IsOPDAppointment,  eligible.OPDAppointmentDate,  eligible.HomePhone,  eligible.Clinic,  eligible.IsFurtherInvestigationDoneInReferringHospital,  eligible.IsPatientCantBeAccommodatedForBedUnavailability,  eligible.IsNothingAdditionalCanBeOfferedRightMedication,  eligible.IsNothingAdditionalCanBeOfferedIsTerminal,  eligible.IsMedicalReportIncomplete,  eligible.IsNotAvailableSpeciality,  eligible.IsOtherReason,  eligible.OtherReason,  eligible.ConsultantName,eligible.DivisionID,eligible.ConsultantID);
			if(endedSuccessfuly)
			{
				eligible.EligibleId = autonumber;
			}
			return endedSuccessfuly;
		}
        public bool Insert(ref int EligibleId, string PatientId, string PatientName, string NationalityId, int Age, string Mobile, string Fax, string Email, string TransferredFrom, int CurrentTransferredToDepartmentId, int CurrentEligibilityStatusId, bool IsAdmitted, DateTime AdmissionApointmentDate, string Ward, bool IsOPDAppointment, DateTime OPDAppointmentDate, string HomePhone, string Clinic, bool IsFurtherInvestigationDoneInReferringHospital, bool IsPatientCantBeAccommodatedForBedUnavailability, bool IsNothingAdditionalCanBeOfferedRightMedication, bool IsNothingAdditionalCanBeOfferedIsTerminal, bool IsMedicalReportIncomplete, bool IsNotAvailableSpeciality, bool IsOtherReason, string OtherReason, string ConsultantName, int DivisionID, int ConsultantID)
		{
			EligibleDAC eligibleComponent = new EligibleDAC();
			return eligibleComponent.InsertNewEligible( ref EligibleId,  PatientId,  PatientName,  NationalityId,  Age,  Mobile,  Fax,  Email,  TransferredFrom,  CurrentTransferredToDepartmentId,  CurrentEligibilityStatusId,  IsAdmitted,  AdmissionApointmentDate,  Ward,  IsOPDAppointment,  OPDAppointmentDate,  HomePhone,  Clinic,  IsFurtherInvestigationDoneInReferringHospital,  IsPatientCantBeAccommodatedForBedUnavailability,  IsNothingAdditionalCanBeOfferedRightMedication,  IsNothingAdditionalCanBeOfferedIsTerminal,  IsMedicalReportIncomplete,  IsNotAvailableSpeciality,  IsOtherReason,  OtherReason,  ConsultantName,DivisionID,ConsultantID);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
        public bool Insert(string PatientId, string PatientName, string NationalityId, int Age, string Mobile, string Fax, string Email, string TransferredFrom, int CurrentTransferredToDepartmentId, int CurrentEligibilityStatusId, bool IsAdmitted, DateTime AdmissionApointmentDate, string Ward, bool IsOPDAppointment, DateTime OPDAppointmentDate, string HomePhone, string Clinic, bool IsFurtherInvestigationDoneInReferringHospital, bool IsPatientCantBeAccommodatedForBedUnavailability, bool IsNothingAdditionalCanBeOfferedRightMedication, bool IsNothingAdditionalCanBeOfferedIsTerminal, bool IsMedicalReportIncomplete, bool IsNotAvailableSpeciality, bool IsOtherReason, string OtherReason, string ConsultantName, int DivisionID, int ConsultantID)
		{
			EligibleDAC eligibleComponent = new EligibleDAC();
            int EligibleId = 0;

			return eligibleComponent.InsertNewEligible( ref EligibleId,  PatientId,  PatientName,  NationalityId,  Age,  Mobile,  Fax,  Email,  TransferredFrom,  CurrentTransferredToDepartmentId,  CurrentEligibilityStatusId,  IsAdmitted,  AdmissionApointmentDate,  Ward,  IsOPDAppointment,  OPDAppointmentDate,  HomePhone,  Clinic,  IsFurtherInvestigationDoneInReferringHospital,  IsPatientCantBeAccommodatedForBedUnavailability,  IsNothingAdditionalCanBeOfferedRightMedication,  IsNothingAdditionalCanBeOfferedIsTerminal,  IsMedicalReportIncomplete,  IsNotAvailableSpeciality,  IsOtherReason,  OtherReason,  ConsultantName,DivisionID,ConsultantID);
		}
		public bool Update(Eligible eligible ,int old_eligibleId)
		{
			EligibleDAC eligibleComponent = new EligibleDAC();
			return eligibleComponent.UpdateEligible( eligible.PatientId,  eligible.PatientName,  eligible.NationalityId,  eligible.Age,  eligible.Mobile,  eligible.Fax,  eligible.Email,  eligible.TransferredFrom,  eligible.CurrentTransferredToDepartmentId,  eligible.CurrentEligibilityStatusId,  eligible.IsAdmitted,  eligible.AdmissionApointmentDate,  eligible.Ward,  eligible.IsOPDAppointment,  eligible.OPDAppointmentDate,  eligible.HomePhone,  eligible.Clinic,  eligible.IsFurtherInvestigationDoneInReferringHospital,  eligible.IsPatientCantBeAccommodatedForBedUnavailability,  eligible.IsNothingAdditionalCanBeOfferedRightMedication,  eligible.IsNothingAdditionalCanBeOfferedIsTerminal,  eligible.IsMedicalReportIncomplete,  eligible.IsNotAvailableSpeciality,  eligible.IsOtherReason,  eligible.OtherReason,  eligible.ConsultantName,eligible.DivisionID,eligible.ConsultantID,  old_eligibleId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
        public bool Update(string PatientId, string PatientName, string NationalityId, int Age, string Mobile, string Fax, string Email, string TransferredFrom, int CurrentTransferredToDepartmentId, int CurrentEligibilityStatusId, bool IsAdmitted, DateTime AdmissionApointmentDate, string Ward, bool IsOPDAppointment, DateTime OPDAppointmentDate, string HomePhone, string Clinic, bool IsFurtherInvestigationDoneInReferringHospital, bool IsPatientCantBeAccommodatedForBedUnavailability, bool IsNothingAdditionalCanBeOfferedRightMedication, bool IsNothingAdditionalCanBeOfferedIsTerminal, bool IsMedicalReportIncomplete, bool IsNotAvailableSpeciality, bool IsOtherReason, string OtherReason, string ConsultantName, int DivisionID, int ConsultantID, int Original_EligibleId)
		{
			EligibleDAC eligibleComponent = new EligibleDAC();
			return eligibleComponent.UpdateEligible( PatientId,  PatientName,  NationalityId,  Age,  Mobile,  Fax,  Email,  TransferredFrom,  CurrentTransferredToDepartmentId,  CurrentEligibilityStatusId,  IsAdmitted,  AdmissionApointmentDate,  Ward,  IsOPDAppointment,  OPDAppointmentDate,  HomePhone,  Clinic,  IsFurtherInvestigationDoneInReferringHospital,  IsPatientCantBeAccommodatedForBedUnavailability,  IsNothingAdditionalCanBeOfferedRightMedication,  IsNothingAdditionalCanBeOfferedIsTerminal,  IsMedicalReportIncomplete,  IsNotAvailableSpeciality,  IsOtherReason,  OtherReason,  ConsultantName,DivisionID,ConsultantID,  Original_EligibleId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_EligibleId)
		{
			EligibleDAC eligibleComponent = new EligibleDAC();
			eligibleComponent.DeleteEligible(Original_EligibleId);
		}

        #endregion
         public Eligible GetByID(int _eligibleId)
         {
             EligibleDAC _eligibleComponent = new EligibleDAC();
             IDataReader reader = _eligibleComponent.GetByIDEligible(_eligibleId);
             Eligible _eligible = null;
             while(reader.Read())
             {
                 _eligible = new Eligible();
                 if(reader["EligibleId"] != DBNull.Value)
                     _eligible.EligibleId = Convert.ToInt32(reader["EligibleId"]);
                 if(reader["PatientId"] != DBNull.Value)
                     _eligible.PatientId = Convert.ToString(reader["PatientId"]);
                 if(reader["PatientName"] != DBNull.Value)
                     _eligible.PatientName = Convert.ToString(reader["PatientName"]);
                 if(reader["NationalityId"] != DBNull.Value)
                     _eligible.NationalityId = Convert.ToString(reader["NationalityId"]);
                 if(reader["Age"] != DBNull.Value)
                     _eligible.Age = Convert.ToInt32(reader["Age"]);
                 if(reader["Mobile"] != DBNull.Value)
                     _eligible.Mobile = Convert.ToString(reader["Mobile"]);
                 if(reader["Fax"] != DBNull.Value)
                     _eligible.Fax = Convert.ToString(reader["Fax"]);
                 if(reader["Email"] != DBNull.Value)
                     _eligible.Email = Convert.ToString(reader["Email"]);
                 if(reader["TransferredFrom"] != DBNull.Value)
                     _eligible.TransferredFrom = Convert.ToString(reader["TransferredFrom"]);
                 if(reader["CurrentTransferredToDepartmentId"] != DBNull.Value)
                     _eligible.CurrentTransferredToDepartmentId = Convert.ToInt32(reader["CurrentTransferredToDepartmentId"]);
                 if(reader["CurrentEligibilityStatusId"] != DBNull.Value)
                     _eligible.CurrentEligibilityStatusId = Convert.ToInt32(reader["CurrentEligibilityStatusId"]);
                 if(reader["IsAdmitted"] != DBNull.Value)
                     _eligible.IsAdmitted = Convert.ToBoolean(reader["IsAdmitted"]);
                 if(reader["AdmissionApointmentDate"] != DBNull.Value)
                     _eligible.AdmissionApointmentDate = Convert.ToDateTime(reader["AdmissionApointmentDate"]);
                 if(reader["Ward"] != DBNull.Value)
                     _eligible.Ward = Convert.ToString(reader["Ward"]);
                 if(reader["IsOPDAppointment"] != DBNull.Value)
                     _eligible.IsOPDAppointment = Convert.ToBoolean(reader["IsOPDAppointment"]);
                 if(reader["OPDAppointmentDate"] != DBNull.Value)
                     _eligible.OPDAppointmentDate = Convert.ToDateTime(reader["OPDAppointmentDate"]);
                 if(reader["HomePhone"] != DBNull.Value)
                     _eligible.HomePhone = Convert.ToString(reader["HomePhone"]);
                 if(reader["Clinic"] != DBNull.Value)
                     _eligible.Clinic = Convert.ToString(reader["Clinic"]);
                 if(reader["IsFurtherInvestigationDoneInReferringHospital"] != DBNull.Value)
                     _eligible.IsFurtherInvestigationDoneInReferringHospital = Convert.ToBoolean(reader["IsFurtherInvestigationDoneInReferringHospital"]);
                 if(reader["IsPatientCantBeAccommodatedForBedUnavailability"] != DBNull.Value)
                     _eligible.IsPatientCantBeAccommodatedForBedUnavailability = Convert.ToBoolean(reader["IsPatientCantBeAccommodatedForBedUnavailability"]);
                 if(reader["IsNothingAdditionalCanBeOfferedRightMedication"] != DBNull.Value)
                     _eligible.IsNothingAdditionalCanBeOfferedRightMedication = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedRightMedication"]);
                 if(reader["IsNothingAdditionalCanBeOfferedIsTerminal"] != DBNull.Value)
                     _eligible.IsNothingAdditionalCanBeOfferedIsTerminal = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedIsTerminal"]);
                 if(reader["IsMedicalReportIncomplete"] != DBNull.Value)
                     _eligible.IsMedicalReportIncomplete = Convert.ToBoolean(reader["IsMedicalReportIncomplete"]);
                 if(reader["IsNotAvailableSpeciality"] != DBNull.Value)
                     _eligible.IsNotAvailableSpeciality = Convert.ToBoolean(reader["IsNotAvailableSpeciality"]);
                 if(reader["IsOtherReason"] != DBNull.Value)
                     _eligible.IsOtherReason = Convert.ToBoolean(reader["IsOtherReason"]);
                 if(reader["OtherReason"] != DBNull.Value)
                     _eligible.OtherReason = Convert.ToString(reader["OtherReason"]);
                 if(reader["ConsultantName"] != DBNull.Value)
                     _eligible.ConsultantName = Convert.ToString(reader["ConsultantName"]);
                 if (reader["ConsultantID"] != DBNull.Value)
                     _eligible.ConsultantID = Convert.ToInt32(reader["ConsultantID"]);
                 if (reader["DivisionID"] != DBNull.Value)
                     _eligible.DivisionID = Convert.ToInt32(reader["DivisionID"]);
             _eligible.NewRecord = false;             }             reader.Close();
             return _eligible;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			EligibleDAC eligiblecomponent = new EligibleDAC();
			return eligiblecomponent.UpdateDataset(dataset);
		}



	}
}
