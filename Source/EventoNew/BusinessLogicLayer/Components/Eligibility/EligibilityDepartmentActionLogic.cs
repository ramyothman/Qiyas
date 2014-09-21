using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.Eligibility;
using BusinessLogicLayer.Entities.Eligibility;
namespace BusinessLogicLayer.Components.Eligibility
{
	/// <summary>
	/// This is a Business Logic Component Class  for EligibilityDepartmentAction table
	/// This class RAPs the EligibilityDepartmentActionDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class EligibilityDepartmentActionLogic : BusinessLogic
	{
		public EligibilityDepartmentActionLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<EligibilityDepartmentAction> GetAll()
         {
             EligibilityDepartmentActionDAC _eligibilityDepartmentActionComponent = new EligibilityDepartmentActionDAC();
             IDataReader reader =  _eligibilityDepartmentActionComponent.GetAllEligibilityDepartmentAction().CreateDataReader();
             List<EligibilityDepartmentAction> _eligibilityDepartmentActionList = new List<EligibilityDepartmentAction>();
             while(reader.Read())
             {
             if(_eligibilityDepartmentActionList == null)
                 _eligibilityDepartmentActionList = new List<EligibilityDepartmentAction>();
                 EligibilityDepartmentAction _eligibilityDepartmentAction = new EligibilityDepartmentAction();
                 if(reader["EligibilityDepartmentActionId"] != DBNull.Value)
                     _eligibilityDepartmentAction.EligibilityDepartmentActionId = Convert.ToInt32(reader["EligibilityDepartmentActionId"]);
                 if(reader["EligibilityDepartmentId"] != DBNull.Value)
                     _eligibilityDepartmentAction.EligibilityDepartmentId = Convert.ToInt32(reader["EligibilityDepartmentId"]);
                 if(reader["EligibleId"] != DBNull.Value)
                     _eligibilityDepartmentAction.EligibleId = Convert.ToInt32(reader["EligibleId"]);
                 if(reader["ConsultantSubmittingActionId"] != DBNull.Value)
                     _eligibilityDepartmentAction.ConsultantSubmittingActionId = Convert.ToInt32(reader["ConsultantSubmittingActionId"]);
                 if(reader["ConsultantName"] != DBNull.Value)
                     _eligibilityDepartmentAction.ConsultantName = Convert.ToString(reader["ConsultantName"]);
                 if(reader["Note"] != DBNull.Value)
                     _eligibilityDepartmentAction.Note = Convert.ToString(reader["Note"]);
                 if(reader["EligibilityStatusId"] != DBNull.Value)
                     _eligibilityDepartmentAction.EligibilityStatusId = Convert.ToInt32(reader["EligibilityStatusId"]);
                 if(reader["IsAdmitted"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsAdmitted = Convert.ToBoolean(reader["IsAdmitted"]);
                 if(reader["AdmissionApointmentDate"] != DBNull.Value)
                     _eligibilityDepartmentAction.AdmissionApointmentDate = Convert.ToDateTime(reader["AdmissionApointmentDate"]);
                 if(reader["Ward"] != DBNull.Value)
                     _eligibilityDepartmentAction.Ward = Convert.ToString(reader["Ward"]);
                 if(reader["IsOPDAppointment"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsOPDAppointment = Convert.ToBoolean(reader["IsOPDAppointment"]);
                 if(reader["OPDAppointmentDate"] != DBNull.Value)
                     _eligibilityDepartmentAction.OPDAppointmentDate = Convert.ToDateTime(reader["OPDAppointmentDate"]);
                 if(reader["Clinic"] != DBNull.Value)
                     _eligibilityDepartmentAction.Clinic = Convert.ToString(reader["Clinic"]);
                 if(reader["IsFurtherInvestigationDoneInReferringHospital"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsFurtherInvestigationDoneInReferringHospital = Convert.ToBoolean(reader["IsFurtherInvestigationDoneInReferringHospital"]);
                 if(reader["IsPatientCantBeAccommodatedForBedUnavailability"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsPatientCantBeAccommodatedForBedUnavailability = Convert.ToBoolean(reader["IsPatientCantBeAccommodatedForBedUnavailability"]);
                 if(reader["IsNothingAdditionalCanBeOfferedRightMedication"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsNothingAdditionalCanBeOfferedRightMedication = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedRightMedication"]);
                 if(reader["IsNothingAdditionalCanBeOfferedIsTerminal"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsNothingAdditionalCanBeOfferedIsTerminal = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedIsTerminal"]);
                 if(reader["IsMedicalReportIncomplete"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsMedicalReportIncomplete = Convert.ToBoolean(reader["IsMedicalReportIncomplete"]);
                 if(reader["IsNotAvailableSpeciality"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsNotAvailableSpeciality = Convert.ToBoolean(reader["IsNotAvailableSpeciality"]);
                 if(reader["IsOtherReason"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsOtherReason = Convert.ToBoolean(reader["IsOtherReason"]);
                 if(reader["OtherReason"] != DBNull.Value)
                     _eligibilityDepartmentAction.OtherReason = Convert.ToString(reader["OtherReason"]);
                 if(reader["DateCreated"] != DBNull.Value)
                     _eligibilityDepartmentAction.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                 if(reader["DateModified"] != DBNull.Value)
                     _eligibilityDepartmentAction.DateModified = Convert.ToDateTime(reader["DateModified"]);
                 if(reader["TransferToDepartmentId"] != DBNull.Value)
                     _eligibilityDepartmentAction.TransferToDepartmentId = Convert.ToInt32(reader["TransferToDepartmentId"]);
             _eligibilityDepartmentAction.NewRecord = false;
             _eligibilityDepartmentActionList.Add(_eligibilityDepartmentAction);
             }             reader.Close();
             return _eligibilityDepartmentActionList;
         }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<EligibilityDepartmentAction> GetAllByPatientId(int EligibleId)
        {
            EligibilityDepartmentActionDAC _eligibilityDepartmentActionComponent = new EligibilityDepartmentActionDAC();
            IDataReader reader = _eligibilityDepartmentActionComponent.GetAllEligibilityDepartmentAction("EligibleId = " + EligibleId).CreateDataReader();
            List<EligibilityDepartmentAction> _eligibilityDepartmentActionList = new List<EligibilityDepartmentAction>();
            while (reader.Read())
            {
                if (_eligibilityDepartmentActionList == null)
                    _eligibilityDepartmentActionList = new List<EligibilityDepartmentAction>();
                EligibilityDepartmentAction _eligibilityDepartmentAction = new EligibilityDepartmentAction();
                if (reader["EligibilityDepartmentActionId"] != DBNull.Value)
                    _eligibilityDepartmentAction.EligibilityDepartmentActionId = Convert.ToInt32(reader["EligibilityDepartmentActionId"]);
                if (reader["EligibilityDepartmentId"] != DBNull.Value)
                    _eligibilityDepartmentAction.EligibilityDepartmentId = Convert.ToInt32(reader["EligibilityDepartmentId"]);
                if (reader["EligibleId"] != DBNull.Value)
                    _eligibilityDepartmentAction.EligibleId = Convert.ToInt32(reader["EligibleId"]);
                if (reader["ConsultantSubmittingActionId"] != DBNull.Value)
                    _eligibilityDepartmentAction.ConsultantSubmittingActionId = Convert.ToInt32(reader["ConsultantSubmittingActionId"]);
                if (reader["ConsultantName"] != DBNull.Value)
                    _eligibilityDepartmentAction.ConsultantName = Convert.ToString(reader["ConsultantName"]);
                if (reader["Note"] != DBNull.Value)
                    _eligibilityDepartmentAction.Note = Convert.ToString(reader["Note"]);
                if (reader["EligibilityStatusId"] != DBNull.Value)
                    _eligibilityDepartmentAction.EligibilityStatusId = Convert.ToInt32(reader["EligibilityStatusId"]);
                if (reader["IsAdmitted"] != DBNull.Value)
                    _eligibilityDepartmentAction.IsAdmitted = Convert.ToBoolean(reader["IsAdmitted"]);
                if (reader["AdmissionApointmentDate"] != DBNull.Value)
                    _eligibilityDepartmentAction.AdmissionApointmentDate = Convert.ToDateTime(reader["AdmissionApointmentDate"]);
                if (reader["Ward"] != DBNull.Value)
                    _eligibilityDepartmentAction.Ward = Convert.ToString(reader["Ward"]);
                if (reader["IsOPDAppointment"] != DBNull.Value)
                    _eligibilityDepartmentAction.IsOPDAppointment = Convert.ToBoolean(reader["IsOPDAppointment"]);
                if (reader["OPDAppointmentDate"] != DBNull.Value)
                    _eligibilityDepartmentAction.OPDAppointmentDate = Convert.ToDateTime(reader["OPDAppointmentDate"]);
                if (reader["Clinic"] != DBNull.Value)
                    _eligibilityDepartmentAction.Clinic = Convert.ToString(reader["Clinic"]);
                if (reader["IsFurtherInvestigationDoneInReferringHospital"] != DBNull.Value)
                    _eligibilityDepartmentAction.IsFurtherInvestigationDoneInReferringHospital = Convert.ToBoolean(reader["IsFurtherInvestigationDoneInReferringHospital"]);
                if (reader["IsPatientCantBeAccommodatedForBedUnavailability"] != DBNull.Value)
                    _eligibilityDepartmentAction.IsPatientCantBeAccommodatedForBedUnavailability = Convert.ToBoolean(reader["IsPatientCantBeAccommodatedForBedUnavailability"]);
                if (reader["IsNothingAdditionalCanBeOfferedRightMedication"] != DBNull.Value)
                    _eligibilityDepartmentAction.IsNothingAdditionalCanBeOfferedRightMedication = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedRightMedication"]);
                if (reader["IsNothingAdditionalCanBeOfferedIsTerminal"] != DBNull.Value)
                    _eligibilityDepartmentAction.IsNothingAdditionalCanBeOfferedIsTerminal = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedIsTerminal"]);
                if (reader["IsMedicalReportIncomplete"] != DBNull.Value)
                    _eligibilityDepartmentAction.IsMedicalReportIncomplete = Convert.ToBoolean(reader["IsMedicalReportIncomplete"]);
                if (reader["IsNotAvailableSpeciality"] != DBNull.Value)
                    _eligibilityDepartmentAction.IsNotAvailableSpeciality = Convert.ToBoolean(reader["IsNotAvailableSpeciality"]);
                if (reader["IsOtherReason"] != DBNull.Value)
                    _eligibilityDepartmentAction.IsOtherReason = Convert.ToBoolean(reader["IsOtherReason"]);
                if (reader["OtherReason"] != DBNull.Value)
                    _eligibilityDepartmentAction.OtherReason = Convert.ToString(reader["OtherReason"]);
                if (reader["DateCreated"] != DBNull.Value)
                    _eligibilityDepartmentAction.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                if (reader["DateModified"] != DBNull.Value)
                    _eligibilityDepartmentAction.DateModified = Convert.ToDateTime(reader["DateModified"]);
                if (reader["TransferToDepartmentId"] != DBNull.Value)
                    _eligibilityDepartmentAction.TransferToDepartmentId = Convert.ToInt32(reader["TransferToDepartmentId"]);
                _eligibilityDepartmentAction.NewRecord = false;
                _eligibilityDepartmentActionList.Add(_eligibilityDepartmentAction);
            } reader.Close();
            return _eligibilityDepartmentActionList;
        }

        #region Insert And Update
		public bool Insert(EligibilityDepartmentAction eligibilitydepartmentaction)
		{
			int autonumber = 0;
			EligibilityDepartmentActionDAC eligibilitydepartmentactionComponent = new EligibilityDepartmentActionDAC();
			bool endedSuccessfuly = eligibilitydepartmentactionComponent.InsertNewEligibilityDepartmentAction( ref autonumber,  eligibilitydepartmentaction.EligibilityDepartmentId,  eligibilitydepartmentaction.EligibleId,  eligibilitydepartmentaction.ConsultantSubmittingActionId,  eligibilitydepartmentaction.ConsultantName,  eligibilitydepartmentaction.Note,  eligibilitydepartmentaction.EligibilityStatusId,  eligibilitydepartmentaction.IsAdmitted,  eligibilitydepartmentaction.AdmissionApointmentDate,  eligibilitydepartmentaction.Ward,  eligibilitydepartmentaction.IsOPDAppointment,  eligibilitydepartmentaction.OPDAppointmentDate,  eligibilitydepartmentaction.Clinic,  eligibilitydepartmentaction.IsFurtherInvestigationDoneInReferringHospital,  eligibilitydepartmentaction.IsPatientCantBeAccommodatedForBedUnavailability,  eligibilitydepartmentaction.IsNothingAdditionalCanBeOfferedRightMedication,  eligibilitydepartmentaction.IsNothingAdditionalCanBeOfferedIsTerminal,  eligibilitydepartmentaction.IsMedicalReportIncomplete,  eligibilitydepartmentaction.IsNotAvailableSpeciality,  eligibilitydepartmentaction.IsOtherReason,  eligibilitydepartmentaction.OtherReason,  eligibilitydepartmentaction.DateCreated,  eligibilitydepartmentaction.DateModified,  eligibilitydepartmentaction.TransferToDepartmentId);
			if(endedSuccessfuly)
			{
				eligibilitydepartmentaction.EligibilityDepartmentActionId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int EligibilityDepartmentActionId,  int EligibilityDepartmentId,  int EligibleId,  int ConsultantSubmittingActionId,  string ConsultantName,  string Note,  int EligibilityStatusId,  bool IsAdmitted,  DateTime AdmissionApointmentDate,  string Ward,  bool IsOPDAppointment,  DateTime OPDAppointmentDate,  string Clinic,  bool IsFurtherInvestigationDoneInReferringHospital,  bool IsPatientCantBeAccommodatedForBedUnavailability,  bool IsNothingAdditionalCanBeOfferedRightMedication,  bool IsNothingAdditionalCanBeOfferedIsTerminal,  bool IsMedicalReportIncomplete,  bool IsNotAvailableSpeciality,  bool IsOtherReason,  string OtherReason,  DateTime DateCreated,  DateTime DateModified,  int TransferToDepartmentId)
		{
			EligibilityDepartmentActionDAC eligibilitydepartmentactionComponent = new EligibilityDepartmentActionDAC();
			return eligibilitydepartmentactionComponent.InsertNewEligibilityDepartmentAction( ref EligibilityDepartmentActionId,  EligibilityDepartmentId,  EligibleId,  ConsultantSubmittingActionId,  ConsultantName,  Note,  EligibilityStatusId,  IsAdmitted,  AdmissionApointmentDate,  Ward,  IsOPDAppointment,  OPDAppointmentDate,  Clinic,  IsFurtherInvestigationDoneInReferringHospital,  IsPatientCantBeAccommodatedForBedUnavailability,  IsNothingAdditionalCanBeOfferedRightMedication,  IsNothingAdditionalCanBeOfferedIsTerminal,  IsMedicalReportIncomplete,  IsNotAvailableSpeciality,  IsOtherReason,  OtherReason,  DateCreated,  DateModified,  TransferToDepartmentId);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int EligibilityDepartmentId,  int EligibleId,  int ConsultantSubmittingActionId,  string ConsultantName,  string Note,  int EligibilityStatusId,  bool IsAdmitted,  DateTime AdmissionApointmentDate,  string Ward,  bool IsOPDAppointment,  DateTime OPDAppointmentDate,  string Clinic,  bool IsFurtherInvestigationDoneInReferringHospital,  bool IsPatientCantBeAccommodatedForBedUnavailability,  bool IsNothingAdditionalCanBeOfferedRightMedication,  bool IsNothingAdditionalCanBeOfferedIsTerminal,  bool IsMedicalReportIncomplete,  bool IsNotAvailableSpeciality,  bool IsOtherReason,  string OtherReason,  DateTime DateCreated,  DateTime DateModified,  int TransferToDepartmentId)
		{
			EligibilityDepartmentActionDAC eligibilitydepartmentactionComponent = new EligibilityDepartmentActionDAC();
            int EligibilityDepartmentActionId = 0;

			return eligibilitydepartmentactionComponent.InsertNewEligibilityDepartmentAction( ref EligibilityDepartmentActionId,  EligibilityDepartmentId,  EligibleId,  ConsultantSubmittingActionId,  ConsultantName,  Note,  EligibilityStatusId,  IsAdmitted,  AdmissionApointmentDate,  Ward,  IsOPDAppointment,  OPDAppointmentDate,  Clinic,  IsFurtherInvestigationDoneInReferringHospital,  IsPatientCantBeAccommodatedForBedUnavailability,  IsNothingAdditionalCanBeOfferedRightMedication,  IsNothingAdditionalCanBeOfferedIsTerminal,  IsMedicalReportIncomplete,  IsNotAvailableSpeciality,  IsOtherReason,  OtherReason,  DateCreated,  DateModified,  TransferToDepartmentId);
		}
		public bool Update(EligibilityDepartmentAction eligibilitydepartmentaction ,int old_eligibilityDepartmentActionId)
		{
			EligibilityDepartmentActionDAC eligibilitydepartmentactionComponent = new EligibilityDepartmentActionDAC();
			return eligibilitydepartmentactionComponent.UpdateEligibilityDepartmentAction( eligibilitydepartmentaction.EligibilityDepartmentId,  eligibilitydepartmentaction.EligibleId,  eligibilitydepartmentaction.ConsultantSubmittingActionId,  eligibilitydepartmentaction.ConsultantName,  eligibilitydepartmentaction.Note,  eligibilitydepartmentaction.EligibilityStatusId,  eligibilitydepartmentaction.IsAdmitted,  eligibilitydepartmentaction.AdmissionApointmentDate,  eligibilitydepartmentaction.Ward,  eligibilitydepartmentaction.IsOPDAppointment,  eligibilitydepartmentaction.OPDAppointmentDate,  eligibilitydepartmentaction.Clinic,  eligibilitydepartmentaction.IsFurtherInvestigationDoneInReferringHospital,  eligibilitydepartmentaction.IsPatientCantBeAccommodatedForBedUnavailability,  eligibilitydepartmentaction.IsNothingAdditionalCanBeOfferedRightMedication,  eligibilitydepartmentaction.IsNothingAdditionalCanBeOfferedIsTerminal,  eligibilitydepartmentaction.IsMedicalReportIncomplete,  eligibilitydepartmentaction.IsNotAvailableSpeciality,  eligibilitydepartmentaction.IsOtherReason,  eligibilitydepartmentaction.OtherReason,  eligibilitydepartmentaction.DateCreated,  eligibilitydepartmentaction.DateModified,  eligibilitydepartmentaction.TransferToDepartmentId,  old_eligibilityDepartmentActionId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int EligibilityDepartmentId,  int EligibleId,  int ConsultantSubmittingActionId,  string ConsultantName,  string Note,  int EligibilityStatusId,  bool IsAdmitted,  DateTime AdmissionApointmentDate,  string Ward,  bool IsOPDAppointment,  DateTime OPDAppointmentDate,  string Clinic,  bool IsFurtherInvestigationDoneInReferringHospital,  bool IsPatientCantBeAccommodatedForBedUnavailability,  bool IsNothingAdditionalCanBeOfferedRightMedication,  bool IsNothingAdditionalCanBeOfferedIsTerminal,  bool IsMedicalReportIncomplete,  bool IsNotAvailableSpeciality,  bool IsOtherReason,  string OtherReason,  DateTime DateCreated,  DateTime DateModified,  int TransferToDepartmentId,  int Original_EligibilityDepartmentActionId)
		{
			EligibilityDepartmentActionDAC eligibilitydepartmentactionComponent = new EligibilityDepartmentActionDAC();
			return eligibilitydepartmentactionComponent.UpdateEligibilityDepartmentAction( EligibilityDepartmentId,  EligibleId,  ConsultantSubmittingActionId,  ConsultantName,  Note,  EligibilityStatusId,  IsAdmitted,  AdmissionApointmentDate,  Ward,  IsOPDAppointment,  OPDAppointmentDate,  Clinic,  IsFurtherInvestigationDoneInReferringHospital,  IsPatientCantBeAccommodatedForBedUnavailability,  IsNothingAdditionalCanBeOfferedRightMedication,  IsNothingAdditionalCanBeOfferedIsTerminal,  IsMedicalReportIncomplete,  IsNotAvailableSpeciality,  IsOtherReason,  OtherReason,  DateCreated,  DateModified,  TransferToDepartmentId,  Original_EligibilityDepartmentActionId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_EligibilityDepartmentActionId)
		{
			EligibilityDepartmentActionDAC eligibilitydepartmentactionComponent = new EligibilityDepartmentActionDAC();
			eligibilitydepartmentactionComponent.DeleteEligibilityDepartmentAction(Original_EligibilityDepartmentActionId);
		}

        #endregion
         public EligibilityDepartmentAction GetByID(int _eligibilityDepartmentActionId)
         {
             EligibilityDepartmentActionDAC _eligibilityDepartmentActionComponent = new EligibilityDepartmentActionDAC();
             IDataReader reader = _eligibilityDepartmentActionComponent.GetByIDEligibilityDepartmentAction(_eligibilityDepartmentActionId);
             EligibilityDepartmentAction _eligibilityDepartmentAction = null;
             while(reader.Read())
             {
                 _eligibilityDepartmentAction = new EligibilityDepartmentAction();
                 if(reader["EligibilityDepartmentActionId"] != DBNull.Value)
                     _eligibilityDepartmentAction.EligibilityDepartmentActionId = Convert.ToInt32(reader["EligibilityDepartmentActionId"]);
                 if(reader["EligibilityDepartmentId"] != DBNull.Value)
                     _eligibilityDepartmentAction.EligibilityDepartmentId = Convert.ToInt32(reader["EligibilityDepartmentId"]);
                 if(reader["EligibleId"] != DBNull.Value)
                     _eligibilityDepartmentAction.EligibleId = Convert.ToInt32(reader["EligibleId"]);
                 if(reader["ConsultantSubmittingActionId"] != DBNull.Value)
                     _eligibilityDepartmentAction.ConsultantSubmittingActionId = Convert.ToInt32(reader["ConsultantSubmittingActionId"]);
                 if(reader["ConsultantName"] != DBNull.Value)
                     _eligibilityDepartmentAction.ConsultantName = Convert.ToString(reader["ConsultantName"]);
                 if(reader["Note"] != DBNull.Value)
                     _eligibilityDepartmentAction.Note = Convert.ToString(reader["Note"]);
                 if(reader["EligibilityStatusId"] != DBNull.Value)
                     _eligibilityDepartmentAction.EligibilityStatusId = Convert.ToInt32(reader["EligibilityStatusId"]);
                 if(reader["IsAdmitted"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsAdmitted = Convert.ToBoolean(reader["IsAdmitted"]);
                 if(reader["AdmissionApointmentDate"] != DBNull.Value)
                     _eligibilityDepartmentAction.AdmissionApointmentDate = Convert.ToDateTime(reader["AdmissionApointmentDate"]);
                 if(reader["Ward"] != DBNull.Value)
                     _eligibilityDepartmentAction.Ward = Convert.ToString(reader["Ward"]);
                 if(reader["IsOPDAppointment"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsOPDAppointment = Convert.ToBoolean(reader["IsOPDAppointment"]);
                 if(reader["OPDAppointmentDate"] != DBNull.Value)
                     _eligibilityDepartmentAction.OPDAppointmentDate = Convert.ToDateTime(reader["OPDAppointmentDate"]);
                 if(reader["Clinic"] != DBNull.Value)
                     _eligibilityDepartmentAction.Clinic = Convert.ToString(reader["Clinic"]);
                 if(reader["IsFurtherInvestigationDoneInReferringHospital"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsFurtherInvestigationDoneInReferringHospital = Convert.ToBoolean(reader["IsFurtherInvestigationDoneInReferringHospital"]);
                 if(reader["IsPatientCantBeAccommodatedForBedUnavailability"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsPatientCantBeAccommodatedForBedUnavailability = Convert.ToBoolean(reader["IsPatientCantBeAccommodatedForBedUnavailability"]);
                 if(reader["IsNothingAdditionalCanBeOfferedRightMedication"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsNothingAdditionalCanBeOfferedRightMedication = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedRightMedication"]);
                 if(reader["IsNothingAdditionalCanBeOfferedIsTerminal"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsNothingAdditionalCanBeOfferedIsTerminal = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedIsTerminal"]);
                 if(reader["IsMedicalReportIncomplete"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsMedicalReportIncomplete = Convert.ToBoolean(reader["IsMedicalReportIncomplete"]);
                 if(reader["IsNotAvailableSpeciality"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsNotAvailableSpeciality = Convert.ToBoolean(reader["IsNotAvailableSpeciality"]);
                 if(reader["IsOtherReason"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsOtherReason = Convert.ToBoolean(reader["IsOtherReason"]);
                 if(reader["OtherReason"] != DBNull.Value)
                     _eligibilityDepartmentAction.OtherReason = Convert.ToString(reader["OtherReason"]);
                 if(reader["DateCreated"] != DBNull.Value)
                     _eligibilityDepartmentAction.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                 if(reader["DateModified"] != DBNull.Value)
                     _eligibilityDepartmentAction.DateModified = Convert.ToDateTime(reader["DateModified"]);
                 if(reader["TransferToDepartmentId"] != DBNull.Value)
                     _eligibilityDepartmentAction.TransferToDepartmentId = Convert.ToInt32(reader["TransferToDepartmentId"]);
             _eligibilityDepartmentAction.NewRecord = false;             }             reader.Close();
             return _eligibilityDepartmentAction;
         }

         public EligibilityDepartmentAction GetByDepartmentID(int EligibilityDepartmentId)
         {
             EligibilityDepartmentActionDAC _eligibilityDepartmentActionComponent = new EligibilityDepartmentActionDAC();
             IDataReader reader = _eligibilityDepartmentActionComponent.GetByDepartmentIDEligibilityDepartmentAction(EligibilityDepartmentId);
             EligibilityDepartmentAction _eligibilityDepartmentAction = null;
             while (reader.Read())
             {
                 _eligibilityDepartmentAction = new EligibilityDepartmentAction();
                 if (reader["EligibilityDepartmentActionId"] != DBNull.Value)
                     _eligibilityDepartmentAction.EligibilityDepartmentActionId = Convert.ToInt32(reader["EligibilityDepartmentActionId"]);
                 if (reader["EligibilityDepartmentId"] != DBNull.Value)
                     _eligibilityDepartmentAction.EligibilityDepartmentId = Convert.ToInt32(reader["EligibilityDepartmentId"]);
                 if (reader["EligibleId"] != DBNull.Value)
                     _eligibilityDepartmentAction.EligibleId = Convert.ToInt32(reader["EligibleId"]);
                 if (reader["ConsultantSubmittingActionId"] != DBNull.Value)
                     _eligibilityDepartmentAction.ConsultantSubmittingActionId = Convert.ToInt32(reader["ConsultantSubmittingActionId"]);
                 if (reader["ConsultantName"] != DBNull.Value)
                     _eligibilityDepartmentAction.ConsultantName = Convert.ToString(reader["ConsultantName"]);
                 if (reader["Note"] != DBNull.Value)
                     _eligibilityDepartmentAction.Note = Convert.ToString(reader["Note"]);
                 if (reader["EligibilityStatusId"] != DBNull.Value)
                     _eligibilityDepartmentAction.EligibilityStatusId = Convert.ToInt32(reader["EligibilityStatusId"]);
                 if (reader["IsAdmitted"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsAdmitted = Convert.ToBoolean(reader["IsAdmitted"]);
                 if (reader["AdmissionApointmentDate"] != DBNull.Value)
                     _eligibilityDepartmentAction.AdmissionApointmentDate = Convert.ToDateTime(reader["AdmissionApointmentDate"]);
                 if (reader["Ward"] != DBNull.Value)
                     _eligibilityDepartmentAction.Ward = Convert.ToString(reader["Ward"]);
                 if (reader["IsOPDAppointment"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsOPDAppointment = Convert.ToBoolean(reader["IsOPDAppointment"]);
                 if (reader["OPDAppointmentDate"] != DBNull.Value)
                     _eligibilityDepartmentAction.OPDAppointmentDate = Convert.ToDateTime(reader["OPDAppointmentDate"]);
                 if (reader["Clinic"] != DBNull.Value)
                     _eligibilityDepartmentAction.Clinic = Convert.ToString(reader["Clinic"]);
                 if (reader["IsFurtherInvestigationDoneInReferringHospital"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsFurtherInvestigationDoneInReferringHospital = Convert.ToBoolean(reader["IsFurtherInvestigationDoneInReferringHospital"]);
                 if (reader["IsPatientCantBeAccommodatedForBedUnavailability"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsPatientCantBeAccommodatedForBedUnavailability = Convert.ToBoolean(reader["IsPatientCantBeAccommodatedForBedUnavailability"]);
                 if (reader["IsNothingAdditionalCanBeOfferedRightMedication"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsNothingAdditionalCanBeOfferedRightMedication = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedRightMedication"]);
                 if (reader["IsNothingAdditionalCanBeOfferedIsTerminal"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsNothingAdditionalCanBeOfferedIsTerminal = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedIsTerminal"]);
                 if (reader["IsMedicalReportIncomplete"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsMedicalReportIncomplete = Convert.ToBoolean(reader["IsMedicalReportIncomplete"]);
                 if (reader["IsNotAvailableSpeciality"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsNotAvailableSpeciality = Convert.ToBoolean(reader["IsNotAvailableSpeciality"]);
                 if (reader["IsOtherReason"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsOtherReason = Convert.ToBoolean(reader["IsOtherReason"]);
                 if (reader["OtherReason"] != DBNull.Value)
                     _eligibilityDepartmentAction.OtherReason = Convert.ToString(reader["OtherReason"]);
                 if (reader["DateCreated"] != DBNull.Value)
                     _eligibilityDepartmentAction.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                 if (reader["DateModified"] != DBNull.Value)
                     _eligibilityDepartmentAction.DateModified = Convert.ToDateTime(reader["DateModified"]);
                 if (reader["TransferToDepartmentId"] != DBNull.Value)
                     _eligibilityDepartmentAction.TransferToDepartmentId = Convert.ToInt32(reader["TransferToDepartmentId"]);
                 _eligibilityDepartmentAction.NewRecord = false;
             } reader.Close();
             return _eligibilityDepartmentAction;
         }

         public EligibilityDepartmentAction GetByDepartmentIDNew(int EligibilityDepartmentId, int EligibleId)
         {
             EligibilityDepartmentActionDAC _eligibilityDepartmentActionComponent = new EligibilityDepartmentActionDAC();
             IDataReader reader = _eligibilityDepartmentActionComponent.GetByDepartmentIDEligibilityDepartmentActionnew(EligibilityDepartmentId,EligibleId);
             EligibilityDepartmentAction _eligibilityDepartmentAction = null;
             while (reader.Read())
             {
                 _eligibilityDepartmentAction = new EligibilityDepartmentAction();
                 if (reader["EligibilityDepartmentActionId"] != DBNull.Value)
                     _eligibilityDepartmentAction.EligibilityDepartmentActionId = Convert.ToInt32(reader["EligibilityDepartmentActionId"]);
                 if (reader["EligibilityDepartmentId"] != DBNull.Value)
                     _eligibilityDepartmentAction.EligibilityDepartmentId = Convert.ToInt32(reader["EligibilityDepartmentId"]);
                 if (reader["EligibleId"] != DBNull.Value)
                     _eligibilityDepartmentAction.EligibleId = Convert.ToInt32(reader["EligibleId"]);
                 if (reader["ConsultantSubmittingActionId"] != DBNull.Value)
                     _eligibilityDepartmentAction.ConsultantSubmittingActionId = Convert.ToInt32(reader["ConsultantSubmittingActionId"]);
                 if (reader["ConsultantName"] != DBNull.Value)
                     _eligibilityDepartmentAction.ConsultantName = Convert.ToString(reader["ConsultantName"]);
                 if (reader["Note"] != DBNull.Value)
                     _eligibilityDepartmentAction.Note = Convert.ToString(reader["Note"]);
                 if (reader["EligibilityStatusId"] != DBNull.Value)
                     _eligibilityDepartmentAction.EligibilityStatusId = Convert.ToInt32(reader["EligibilityStatusId"]);
                 if (reader["IsAdmitted"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsAdmitted = Convert.ToBoolean(reader["IsAdmitted"]);
                 if (reader["AdmissionApointmentDate"] != DBNull.Value)
                     _eligibilityDepartmentAction.AdmissionApointmentDate = Convert.ToDateTime(reader["AdmissionApointmentDate"]);
                 if (reader["Ward"] != DBNull.Value)
                     _eligibilityDepartmentAction.Ward = Convert.ToString(reader["Ward"]);
                 if (reader["IsOPDAppointment"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsOPDAppointment = Convert.ToBoolean(reader["IsOPDAppointment"]);
                 if (reader["OPDAppointmentDate"] != DBNull.Value)
                     _eligibilityDepartmentAction.OPDAppointmentDate = Convert.ToDateTime(reader["OPDAppointmentDate"]);
                 if (reader["Clinic"] != DBNull.Value)
                     _eligibilityDepartmentAction.Clinic = Convert.ToString(reader["Clinic"]);
                 if (reader["IsFurtherInvestigationDoneInReferringHospital"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsFurtherInvestigationDoneInReferringHospital = Convert.ToBoolean(reader["IsFurtherInvestigationDoneInReferringHospital"]);
                 if (reader["IsPatientCantBeAccommodatedForBedUnavailability"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsPatientCantBeAccommodatedForBedUnavailability = Convert.ToBoolean(reader["IsPatientCantBeAccommodatedForBedUnavailability"]);
                 if (reader["IsNothingAdditionalCanBeOfferedRightMedication"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsNothingAdditionalCanBeOfferedRightMedication = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedRightMedication"]);
                 if (reader["IsNothingAdditionalCanBeOfferedIsTerminal"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsNothingAdditionalCanBeOfferedIsTerminal = Convert.ToBoolean(reader["IsNothingAdditionalCanBeOfferedIsTerminal"]);
                 if (reader["IsMedicalReportIncomplete"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsMedicalReportIncomplete = Convert.ToBoolean(reader["IsMedicalReportIncomplete"]);
                 if (reader["IsNotAvailableSpeciality"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsNotAvailableSpeciality = Convert.ToBoolean(reader["IsNotAvailableSpeciality"]);
                 if (reader["IsOtherReason"] != DBNull.Value)
                     _eligibilityDepartmentAction.IsOtherReason = Convert.ToBoolean(reader["IsOtherReason"]);
                 if (reader["OtherReason"] != DBNull.Value)
                     _eligibilityDepartmentAction.OtherReason = Convert.ToString(reader["OtherReason"]);
                 if (reader["DateCreated"] != DBNull.Value)
                     _eligibilityDepartmentAction.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                 if (reader["DateModified"] != DBNull.Value)
                     _eligibilityDepartmentAction.DateModified = Convert.ToDateTime(reader["DateModified"]);
                 if (reader["TransferToDepartmentId"] != DBNull.Value)
                     _eligibilityDepartmentAction.TransferToDepartmentId = Convert.ToInt32(reader["TransferToDepartmentId"]);
                 _eligibilityDepartmentAction.NewRecord = false;
             } reader.Close();
             return _eligibilityDepartmentAction;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			EligibilityDepartmentActionDAC eligibilitydepartmentactioncomponent = new EligibilityDepartmentActionDAC();
			return eligibilitydepartmentactioncomponent.UpdateDataset(dataset);
		}



	}
}
