using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.Eligibility
{
	/// <summary>
	/// This is a Business Entity Class  for EligibilityStatus table
	/// </summary>

    [DataObject(true)]
	public class EligibilityStatus : Entity
	{
		public EligibilityStatus(){}

		/// <summary>
		/// This Property represents the EligibilityStatusId which has int type
		/// </summary>
		private int _eligibilityStatusId;
        [DataObjectField(true,true,false)]
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
		/// This Property represents the Name which has nvarchar type
		/// </summary>
		private string _name = "";
        [DataObjectField(false,false,true,50)]
		public string Name
		{
            get 
            {
              return _name;
            }
            set 
            {
                if (!RBMInitiatingEntity && _name != value)
                     RBMDataChanged = true;
                _name = value;
            }
		}

        public string StatusImage
        {
            get { return "~/images/status/" + _eligibilityStatusId + ".png"; }
        }
        

	}
}
