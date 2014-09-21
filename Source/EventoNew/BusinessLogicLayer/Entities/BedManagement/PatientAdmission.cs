using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.BedManagement
{
	/// <summary>
	/// This is a Business Entity Class  for PatientAdmission table
	/// </summary>

    [DataObject(true)]
	public class PatientAdmission : Entity
	{
		public PatientAdmission(){}

		/// <summary>
		/// This Property represents the PatientAdmissionId which has int type
		/// </summary>
		private int _patientAdmissionId;
        [DataObjectField(true,true,false)]
		public int PatientAdmissionId
		{
            get 
            {
              return _patientAdmissionId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _patientAdmissionId != value)
                     RBMDataChanged = true;
                _patientAdmissionId = value;
            }
		}

		/// <summary>
		/// This Property represents the AdmissionStartDate which has datetime type
		/// </summary>
		private DateTime _admissionStartDate;
        [DataObjectField(false,false,true)]
		public DateTime AdmissionStartDate
		{
            get 
            {
              return _admissionStartDate;
            }
            set 
            {
                if (!RBMInitiatingEntity && _admissionStartDate != value)
                     RBMDataChanged = true;
                _admissionStartDate = value;
            }
		}

		/// <summary>
		/// This Property represents the DischargeDate which has datetime type
		/// </summary>
		private DateTime _dischargeDate;
        [DataObjectField(false,false,true)]
		public DateTime DischargeDate
		{
            get 
            {
              return _dischargeDate;
            }
            set 
            {
                if (!RBMInitiatingEntity && _dischargeDate != value)
                     RBMDataChanged = true;
                _dischargeDate = value;
            }
		}

		/// <summary>
		/// This Property represents the AdmissionStayTypeId which has int type
		/// </summary>
		private int _admissionStayTypeId;
        [DataObjectField(false,false,true)]
		public int AdmissionStayTypeId
		{
            get 
            {
              return _admissionStayTypeId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _admissionStayTypeId != value)
                     RBMDataChanged = true;
                _admissionStayTypeId = value;
            }
		}

		/// <summary>
		/// This Property represents the DischargeTypeId which has int type
		/// </summary>
		private int _dischargeTypeId;
        [DataObjectField(false,false,true)]
		public int DischargeTypeId
		{
            get 
            {
              return _dischargeTypeId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _dischargeTypeId != value)
                     RBMDataChanged = true;
                _dischargeTypeId = value;
            }
		}

		/// <summary>
		/// This Property represents the PatientCode which has nvarchar type
		/// </summary>
		private string _patientCode = "";
        [DataObjectField(false,false,true,8)]
		public string PatientCode
		{
            get 
            {
              return _patientCode;
            }
            set 
            {
                if (!RBMInitiatingEntity && _patientCode != value)
                     RBMDataChanged = true;
                _patientCode = value;
            }
		}

		/// <summary>
		/// This Property represents the ConsultantId which has int type
		/// </summary>
		private int _consultantId;
        [DataObjectField(false,false,true)]
		public int ConsultantId
		{
            get 
            {
              return _consultantId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _consultantId != value)
                     RBMDataChanged = true;
                _consultantId = value;
            }
		}

		/// <summary>
		/// This Property represents the SpecialityId which has int type
		/// </summary>
		private int _specialityId;
        [DataObjectField(false,false,true)]
		public int SpecialityId
		{
            get 
            {
              return _specialityId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _specialityId != value)
                     RBMDataChanged = true;
                _specialityId = value;
            }
		}

		/// <summary>
		/// This Property represents the WardBedId which has int type
		/// </summary>
		private int _wardBedId;
        [DataObjectField(false,false,true)]
		public int WardBedId
		{
            get 
            {
              return _wardBedId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardBedId != value)
                     RBMDataChanged = true;
                _wardBedId = value;
            }
		}


	}
}
