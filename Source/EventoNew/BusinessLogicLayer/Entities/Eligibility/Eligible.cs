using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.Eligibility
{
	/// <summary>
	/// This is a Business Entity Class  for Eligible table
	/// </summary>

    [DataObject(true)]
	public class Eligible : Entity
	{
		public Eligible(){}

		/// <summary>
		/// This Property represents the EligibleId which has int type
		/// </summary>
		private int _eligibleId;
        [DataObjectField(true,true,false)]
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
		/// This Property represents the PatientId which has nvarchar type
		/// </summary>
		private string _patientId = "";
        [DataObjectField(false,false,true,20)]
		public string PatientId
		{
            get 
            {
              return _patientId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _patientId != value)
                     RBMDataChanged = true;
                _patientId = value;
            }
		}

		/// <summary>
		/// This Property represents the PatientName which has nvarchar type
		/// </summary>
		private string _patientName = "";
        [DataObjectField(false,false,true,150)]
		public string PatientName
		{
            get 
            {
              return _patientName;
            }
            set 
            {
                if (!RBMInitiatingEntity && _patientName != value)
                     RBMDataChanged = true;
                _patientName = value;
            }
		}

		/// <summary>
		/// This Property represents the NationalityId which has char type
		/// </summary>
		private string _nationalityId = "";
        [DataObjectField(false,false,true,3)]
		public string NationalityId
		{
            get 
            {
              return _nationalityId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _nationalityId != value)
                     RBMDataChanged = true;
                _nationalityId = value;
            }
		}

		/// <summary>
		/// This Property represents the Age which has int type
		/// </summary>
		private int _age;
        [DataObjectField(false,false,true)]
		public int Age
		{
            get 
            {
              return _age;
            }
            set 
            {
                if (!RBMInitiatingEntity && _age != value)
                     RBMDataChanged = true;
                _age = value;
            }
		}

		/// <summary>
		/// This Property represents the Mobile which has nvarchar type
		/// </summary>
		private string _mobile = "";
        [DataObjectField(false,false,true,50)]
		public string Mobile
		{
            get 
            {
              return _mobile;
            }
            set 
            {
                if (!RBMInitiatingEntity && _mobile != value)
                     RBMDataChanged = true;
                _mobile = value;
            }
		}

		/// <summary>
		/// This Property represents the Fax which has nvarchar type
		/// </summary>
		private string _fax = "";
        [DataObjectField(false,false,true,50)]
		public string Fax
		{
            get 
            {
              return _fax;
            }
            set 
            {
                if (!RBMInitiatingEntity && _fax != value)
                     RBMDataChanged = true;
                _fax = value;
            }
		}

		/// <summary>
		/// This Property represents the Email which has nvarchar type
		/// </summary>
		private string _email = "";
        [DataObjectField(false,false,true,50)]
		public string Email
		{
            get 
            {
              return _email;
            }
            set 
            {
                if (!RBMInitiatingEntity && _email != value)
                     RBMDataChanged = true;
                _email = value;
            }
		}

		/// <summary>
		/// This Property represents the TransferredFrom which has nvarchar type
		/// </summary>
		private string _transferredFrom = "";
        [DataObjectField(false,false,true,150)]
		public string TransferredFrom
		{
            get 
            {
              return _transferredFrom;
            }
            set 
            {
                if (!RBMInitiatingEntity && _transferredFrom != value)
                     RBMDataChanged = true;
                _transferredFrom = value;
            }
		}

		/// <summary>
		/// This Property represents the CurrentTransferredToDepartmentId which has int type
		/// </summary>
		private int _currentTransferredToDepartmentId;
        [DataObjectField(false,false,true)]
		public int CurrentTransferredToDepartmentId
		{
            get 
            {
              return _currentTransferredToDepartmentId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _currentTransferredToDepartmentId != value)
                     RBMDataChanged = true;
                _currentTransferredToDepartmentId = value;
            }
		}

		/// <summary>
		/// This Property represents the CurrentEligibilityStatusId which has int type
		/// </summary>
		private int _currentEligibilityStatusId;
        [DataObjectField(false,false,true)]
		public int CurrentEligibilityStatusId
		{
            get 
            {
              return _currentEligibilityStatusId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _currentEligibilityStatusId != value)
                     RBMDataChanged = true;
                _currentEligibilityStatusId = value;
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
		/// This Property represents the HomePhone which has nvarchar type
		/// </summary>
		private string _homePhone = "";
        [DataObjectField(false,false,true,50)]
		public string HomePhone
		{
            get 
            {
              return _homePhone;
            }
            set 
            {
                if (!RBMInitiatingEntity && _homePhone != value)
                     RBMDataChanged = true;
                _homePhone = value;
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

        private int _DivisionID;
        public int DivisionID
        {
            get { return _DivisionID; }
            set
            {
                _DivisionID = value;
            }
        }

        private int _ConsultantID;
        public int ConsultantID
        {
            get { return _ConsultantID; }
            set
            {
                _ConsultantID = value;
            }
        }
        


	}
}
