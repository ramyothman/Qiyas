using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.Eligibility
{
	/// <summary>
	/// This is a Business Entity Class  for EligibilityConsultant table
	/// </summary>

    [DataObject(true)]
	public class EligibilityConsultant : Entity
	{
		public EligibilityConsultant(){}

		/// <summary>
		/// This Property represents the EligibilityConsultantId which has int type
		/// </summary>
		private int _eligibilityConsultantId;
        [DataObjectField(true,true,false)]
		public int EligibilityConsultantId
		{
            get 
            {
              return _eligibilityConsultantId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _eligibilityConsultantId != value)
                     RBMDataChanged = true;
                _eligibilityConsultantId = value;
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
		/// This Property represents the PersonId which has int type
		/// </summary>
		private int _personId;
        [DataObjectField(false,false,true)]
		public int PersonId
		{
            get 
            {
              return _personId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _personId != value)
                     RBMDataChanged = true;
                _personId = value;
            }
		}

		/// <summary>
		/// This Property represents the DateAssigned which has datetime type
		/// </summary>
		private DateTime _dateAssigned;
        [DataObjectField(false,false,true)]
		public DateTime DateAssigned
		{
            get 
            {
              return _dateAssigned;
            }
            set 
            {
                if (!RBMInitiatingEntity && _dateAssigned != value)
                     RBMDataChanged = true;
                _dateAssigned = value;
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

        private string _Poisition;
        public string Poisition
        {
            get { return _Poisition; }
            set
            {
                _Poisition = value;
            }
        }

        private string _Name;
        public string Name
        {
            get 
            {
                if (string.IsNullOrEmpty(_Name) && _personId != 0)
                {
                    _Name = BusinessLogicLayer.Common.PersonLogic.GetByID(_personId).FullName;
                }
                return _Name; 
            }
            set
            {
                _Name = value;
            }
        }
        

	}
}
