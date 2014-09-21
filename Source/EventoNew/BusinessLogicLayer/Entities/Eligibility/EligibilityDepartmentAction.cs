using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.Eligibility
{
	/// <summary>
	/// This is a Business Entity Class  for EligibilityDepartmentAction table
	/// </summary>

    [DataObject(true)]
	public class EligibilityDepartmentAction : Entity
	{
		public EligibilityDepartmentAction(){}

		/// <summary>
		/// This Property represents the EligibilityDepartmentActionId which has int type
		/// </summary>
		private int _eligibilityDepartmentActionId;
        [DataObjectField(true,true,false)]
		public int EligibilityDepartmentActionId
		{
            get 
            {
              return _eligibilityDepartmentActionId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _eligibilityDepartmentActionId != value)
                     RBMDataChanged = true;
                _eligibilityDepartmentActionId = value;
            }
		}

		/// <summary>
		/// This Property represents the EligibilityDepartmentId which has int type
		/// </summary>
		private int _eligibilityDepartmentId;
        [DataObjectField(false,false,true)]
		public int EligibilityDepartmentId
		{
            get 
            {
              return _eligibilityDepartmentId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _eligibilityDepartmentId != value)
                     RBMDataChanged = true;
                _eligibilityDepartmentId = value;
            }
		}

		/// <summary>
		/// This Property represents the EligibleId which has int type
		/// </summary>
		private int _eligibleId;
        [DataObjectField(false,false,true)]
		public int EligibleId
		{
            get 
            {
              return _eligibleId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _eligibleId != value)
                     RBMDataChanged = true;
                _eligibleId = value;
            }
		}

		/// <summary>
		/// This Property represents the ConsultantSubmittingActionId which has int type
		/// </summary>
		private int _consultantSubmittingActionId;
        [DataObjectField(false,false,true)]
		public int ConsultantSubmittingActionId
		{
            get 
            {
              return _consultantSubmittingActionId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _consultantSubmittingActionId != value)
                     RBMDataChanged = true;
                _consultantSubmittingActionId = value;
            }
		}

		/// <summary>
		/// This Property represents the ConsultantName which has nvarchar type
		/// </summary>
		private string _consultantName = "";
        [DataObjectField(false,false,true,150)]
		public string ConsultantName
		{
            get 
            {
              return _consultantName;
            }
            set 
            {
                if (!RBMInitiatingEntity && _consultantName != value)
                     RBMDataChanged = true;
                _consultantName = value;
            }
		}

		/// <summary>
		/// This Property represents the Note which has ntext type
		/// </summary>
		private string _note = "";
        [DataObjectField(false,false,true,16)]
		public string Note
		{
            get 
            {
              return _note;
            }
            set 
            {
                if (!RBMInitiatingEntity && _note != value)
                     RBMDataChanged = true;
                _note = value;
            }
		}

		/// <summary>
		/// This Property represents the EligibilityStatusId which has int type
		/// </summary>
		private int _eligibilityStatusId;
        [DataObjectField(false,false,true)]
		public int EligibilityStatusId
		{
            get 
            {
              return _eligibilityStatusId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _eligibilityStatusId != value)
                     RBMDataChanged = true;
                _eligibilityStatusId = value;
            }
		}

		/// <summary>
		/// This Property represents the IsAdmitted which has bit type
		/// </summary>
		private bool _isAdmitted;
        [DataObjectField(false,false,true)]
		public bool IsAdmitted
		{
            get 
            {
              return _isAdmitted;
            }
            set 
            {
                if (!RBMInitiatingEntity && _isAdmitted != value)
                     RBMDataChanged = true;
                _isAdmitted = value;
            }
		}

		/// <summary>
		/// This Property represents the AdmissionApointmentDate which has datetime type
		/// </summary>
		private DateTime _admissionApointmentDate;
        [DataObjectField(false,false,true)]
		public DateTime AdmissionApointmentDate
		{
            get 
            {
              return _admissionApointmentDate;
            }
            set 
            {
                if (!RBMInitiatingEntity && _admissionApointmentDate != value)
                     RBMDataChanged = true;
                _admissionApointmentDate = value;
            }
		}

		/// <summary>
		/// This Property represents the Ward which has nvarchar type
		/// </summary>
		private string _ward = "";
        [DataObjectField(false,false,true,50)]
		public string Ward
		{
            get 
            {
              return _ward;
            }
            set 
            {
                if (!RBMInitiatingEntity && _ward != value)
                     RBMDataChanged = true;
                _ward = value;
            }
		}

		/// <summary>
		/// This Property represents the IsOPDAppointment which has bit type
		/// </summary>
		private bool _isOPDAppointment;
        [DataObjectField(false,false,true)]
		public bool IsOPDAppointment
		{
            get 
            {
              return _isOPDAppointment;
            }
            set 
            {
                if (!RBMInitiatingEntity && _isOPDAppointment != value)
                     RBMDataChanged = true;
                _isOPDAppointment = value;
            }
		}

		/// <summary>
		/// This Property represents the OPDAppointmentDate which has datetime type
		/// </summary>
		private DateTime _oPDAppointmentDate;
        [DataObjectField(false,false,true)]
		public DateTime OPDAppointmentDate
		{
            get 
            {
              return _oPDAppointmentDate;
            }
            set 
            {
                if (!RBMInitiatingEntity && _oPDAppointmentDate != value)
                     RBMDataChanged = true;
                _oPDAppointmentDate = value;
            }
		}

		/// <summary>
		/// This Property represents the Clinic which has nvarchar type
		/// </summary>
		private string _clinic = "";
        [DataObjectField(false,false,true,150)]
		public string Clinic
		{
            get 
            {
              return _clinic;
            }
            set 
            {
                if (!RBMInitiatingEntity && _clinic != value)
                     RBMDataChanged = true;
                _clinic = value;
            }
		}

		/// <summary>
		/// This Property represents the IsFurtherInvestigationDoneInReferringHospital which has bit type
		/// </summary>
		private bool _isFurtherInvestigationDoneInReferringHospital;
        [DataObjectField(false,false,true)]
		public bool IsFurtherInvestigationDoneInReferringHospital
		{
            get 
            {
              return _isFurtherInvestigationDoneInReferringHospital;
            }
            set 
            {
                if (!RBMInitiatingEntity && _isFurtherInvestigationDoneInReferringHospital != value)
                     RBMDataChanged = true;
                _isFurtherInvestigationDoneInReferringHospital = value;
            }
		}

		/// <summary>
		/// This Property represents the IsPatientCantBeAccommodatedForBedUnavailability which has bit type
		/// </summary>
		private bool _isPatientCantBeAccommodatedForBedUnavailability;
        [DataObjectField(false,false,true)]
		public bool IsPatientCantBeAccommodatedForBedUnavailability
		{
            get 
            {
              return _isPatientCantBeAccommodatedForBedUnavailability;
            }
            set 
            {
                if (!RBMInitiatingEntity && _isPatientCantBeAccommodatedForBedUnavailability != value)
                     RBMDataChanged = true;
                _isPatientCantBeAccommodatedForBedUnavailability = value;
            }
		}

		/// <summary>
		/// This Property represents the IsNothingAdditionalCanBeOfferedRightMedication which has bit type
		/// </summary>
		private bool _isNothingAdditionalCanBeOfferedRightMedication;
        [DataObjectField(false,false,true)]
		public bool IsNothingAdditionalCanBeOfferedRightMedication
		{
            get 
            {
              return _isNothingAdditionalCanBeOfferedRightMedication;
            }
            set 
            {
                if (!RBMInitiatingEntity && _isNothingAdditionalCanBeOfferedRightMedication != value)
                     RBMDataChanged = true;
                _isNothingAdditionalCanBeOfferedRightMedication = value;
            }
		}

		/// <summary>
		/// This Property represents the IsNothingAdditionalCanBeOfferedIsTerminal which has bit type
		/// </summary>
		private bool _isNothingAdditionalCanBeOfferedIsTerminal;
        [DataObjectField(false,false,true)]
		public bool IsNothingAdditionalCanBeOfferedIsTerminal
		{
            get 
            {
              return _isNothingAdditionalCanBeOfferedIsTerminal;
            }
            set 
            {
                if (!RBMInitiatingEntity && _isNothingAdditionalCanBeOfferedIsTerminal != value)
                     RBMDataChanged = true;
                _isNothingAdditionalCanBeOfferedIsTerminal = value;
            }
		}

		/// <summary>
		/// This Property represents the IsMedicalReportIncomplete which has bit type
		/// </summary>
		private bool _isMedicalReportIncomplete;
        [DataObjectField(false,false,true)]
		public bool IsMedicalReportIncomplete
		{
            get 
            {
              return _isMedicalReportIncomplete;
            }
            set 
            {
                if (!RBMInitiatingEntity && _isMedicalReportIncomplete != value)
                     RBMDataChanged = true;
                _isMedicalReportIncomplete = value;
            }
		}

		/// <summary>
		/// This Property represents the IsNotAvailableSpeciality which has bit type
		/// </summary>
		private bool _isNotAvailableSpeciality;
        [DataObjectField(false,false,true)]
		public bool IsNotAvailableSpeciality
		{
            get 
            {
              return _isNotAvailableSpeciality;
            }
            set 
            {
                if (!RBMInitiatingEntity && _isNotAvailableSpeciality != value)
                     RBMDataChanged = true;
                _isNotAvailableSpeciality = value;
            }
		}

		/// <summary>
		/// This Property represents the IsOtherReason which has bit type
		/// </summary>
		private bool _isOtherReason;
        [DataObjectField(false,false,true)]
		public bool IsOtherReason
		{
            get 
            {
              return _isOtherReason;
            }
            set 
            {
                if (!RBMInitiatingEntity && _isOtherReason != value)
                     RBMDataChanged = true;
                _isOtherReason = value;
            }
		}

		/// <summary>
		/// This Property represents the OtherReason which has ntext type
		/// </summary>
		private string _otherReason = "";
        [DataObjectField(false,false,true,16)]
		public string OtherReason
		{
            get 
            {
              return _otherReason;
            }
            set 
            {
                if (!RBMInitiatingEntity && _otherReason != value)
                     RBMDataChanged = true;
                _otherReason = value;
            }
		}

		/// <summary>
		/// This Property represents the DateCreated which has datetime type
		/// </summary>
		private DateTime _dateCreated;
        [DataObjectField(false,false,true)]
		public DateTime DateCreated
		{
            get 
            {
              return _dateCreated;
            }
            set 
            {
                if (!RBMInitiatingEntity && _dateCreated != value)
                     RBMDataChanged = true;
                _dateCreated = value;
            }
		}

		/// <summary>
		/// This Property represents the DateModified which has datetime type
		/// </summary>
		private DateTime _dateModified;
        [DataObjectField(false,false,true)]
		public DateTime DateModified
		{
            get 
            {
              return _dateModified;
            }
            set 
            {
                if (!RBMInitiatingEntity && _dateModified != value)
                     RBMDataChanged = true;
                _dateModified = value;
            }
		}

		/// <summary>
		/// This Property represents the TransferToDepartmentId which has int type
		/// </summary>
		private int _transferToDepartmentId;
        [DataObjectField(false,false,true)]
		public int TransferToDepartmentId
		{
            get 
            {
              return _transferToDepartmentId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _transferToDepartmentId != value)
                     RBMDataChanged = true;
                _transferToDepartmentId = value;
            }
		}


	}
}
