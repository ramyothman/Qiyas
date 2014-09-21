using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.Eligibility
{
	/// <summary>
	/// This is a Business Entity Class  for EligibilityDepartment table
	/// </summary>

    [DataObject(true)]
	public class EligibilityDepartment : Entity
	{
		public EligibilityDepartment(){}

		/// <summary>
		/// This Property represents the EligibilityDepartmentId which has int type
		/// </summary>
		private int _eligibilityDepartmentId;
        [DataObjectField(true,true,false)]
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
		/// This Property represents the DepartmentName which has nvarchar type
		/// </summary>
		private string _departmentName = "";
        [DataObjectField(false,false,true,50)]
		public string DepartmentName
		{
            get 
            {
              return _departmentName;
            }
            set 
            {
                if (!RBMInitiatingEntity && _departmentName != value)
                     RBMDataChanged = true;
                _departmentName = value;
            }
		}


	}
}
