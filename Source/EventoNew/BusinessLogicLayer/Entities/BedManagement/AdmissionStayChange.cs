using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.BedManagement
{
	/// <summary>
	/// This is a Business Entity Class  for AdmissionStayChange table
	/// </summary>

    [DataObject(true)]
	public class AdmissionStayChange : Entity
	{
		public AdmissionStayChange(){}

		/// <summary>
		/// This Property represents the AdmissionStayChangeId which has int type
		/// </summary>
		private int _admissionStayChangeId;
        [DataObjectField(true,true,false)]
		public int AdmissionStayChangeId
		{
            get 
            {
              return _admissionStayChangeId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _admissionStayChangeId != value)
                     RBMDataChanged = true;
                _admissionStayChangeId = value;
            }
		}

		/// <summary>
		/// This Property represents the PatientAdmissionId which has int type
		/// </summary>
		private int _patientAdmissionId;
        [DataObjectField(false,false,true)]
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
		/// This Property represents the ModifiedDate which has datetime type
		/// </summary>
		private DateTime _modifiedDate;
        [DataObjectField(false,false,true)]
		public DateTime ModifiedDate
		{
            get 
            {
              return _modifiedDate;
            }
            set 
            {
                if (!RBMInitiatingEntity && _modifiedDate != value)
                     RBMDataChanged = true;
                _modifiedDate = value;
            }
		}


	}
}
