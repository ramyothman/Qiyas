using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.PGME
{
	/// <summary>
	/// This is a Business Entity Class  for PersonPGMERegisteration table
	/// </summary>

    [DataObject(true)]
	public class PersonPGMERegisteration : Entity
	{
		public PersonPGMERegisteration(){}

		/// <summary>
		/// This Property represents the PersonRegisterationId which has int type
		/// </summary>
		private int _personRegisterationId;
        [DataObjectField(true,true,false)]
		public int PersonRegisterationId
		{
            get 
            {
              return _personRegisterationId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _personRegisterationId != value)
                     RBMDataChanged = true;
                _personRegisterationId = value;
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
		/// This Property represents the PersonProgramId which has int type
		/// </summary>
		private int _personProgramId;
        [DataObjectField(false,false,true)]
		public int PersonProgramId
		{
            get 
            {
              return _personProgramId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _personProgramId != value)
                     RBMDataChanged = true;
                _personProgramId = value;
            }
		}

		/// <summary>
		/// This Property represents the PersonRegisterationStatusId which has int type
		/// </summary>
		private int _personRegisterationStatusId;
        [DataObjectField(false,false,true)]
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
		/// This Property represents the RegisterationNumber which has nvarchar type
		/// </summary>
		private string _registerationNumber = "";
        [DataObjectField(false,false,true,50)]
		public string RegisterationNumber
		{
            get 
            {
              return _registerationNumber;
            }
            set 
            {
                if (!RBMInitiatingEntity && _registerationNumber != value)
                     RBMDataChanged = true;
                _registerationNumber = value;
            }
		}

		/// <summary>
		/// This Property represents the UniRegisterationNumber which has nvarchar type
		/// </summary>
		private string _uniRegisterationNumber = "";
        [DataObjectField(false,false,true,50)]
		public string UniRegisterationNumber
		{
            get 
            {
              return _uniRegisterationNumber;
            }
            set 
            {
                if (!RBMInitiatingEntity && _uniRegisterationNumber != value)
                     RBMDataChanged = true;
                _uniRegisterationNumber = value;
            }
		}


	}
}
