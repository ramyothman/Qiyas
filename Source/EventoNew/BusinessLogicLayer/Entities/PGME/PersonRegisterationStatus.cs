using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.PGME
{
	/// <summary>
	/// This is a Business Entity Class  for PersonRegisterationStatus table
	/// </summary>

    [DataObject(true)]
	public class PersonRegisterationStatus : Entity
	{
		public PersonRegisterationStatus(){}

		/// <summary>
		/// This Property represents the PersonRegisterationStatusId which has int type
		/// </summary>
		private int _personRegisterationStatusId;
        [DataObjectField(true,true,false)]
		public int PersonRegisterationStatusId
		{
            get 
            {
              return _personRegisterationStatusId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _personRegisterationStatusId != value)
                     RBMDataChanged = true;
                _personRegisterationStatusId = value;
            }
		}

		/// <summary>
		/// This Property represents the Status which has nvarchar type
		/// </summary>
		private string _status = "";
        [DataObjectField(false,false,true,50)]
		public string Status
		{
            get 
            {
              return _status;
            }
            set 
            {
                if (!RBMInitiatingEntity && _status != value)
                     RBMDataChanged = true;
                _status = value;
            }
		}


	}
}
