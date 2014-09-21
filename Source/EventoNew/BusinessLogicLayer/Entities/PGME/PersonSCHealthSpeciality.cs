using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.PGME
{
	/// <summary>
	/// This is a Business Entity Class  for PersonSCHealthSpeciality table
	/// </summary>

    [DataObject(true)]
	public class PersonSCHealthSpeciality : Entity
	{
		public PersonSCHealthSpeciality(){}

		/// <summary>
		/// This Property represents the PersonSCHealthSpecialityId which has int type
		/// </summary>
		private int _personSCHealthSpecialityId;
        [DataObjectField(true,true,false)]
		public int PersonSCHealthSpecialityId
		{
            get 
            {
              return _personSCHealthSpecialityId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _personSCHealthSpecialityId != value)
                     RBMDataChanged = true;
                _personSCHealthSpecialityId = value;
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
		/// This Property represents the Score which has decimal type
		/// </summary>
		private decimal _score;
        [DataObjectField(false,false,true)]
		public decimal Score
		{
            get 
            {
              return _score;
            }
            set 
            {
                if (!RBMInitiatingEntity && _score != value)
                     RBMDataChanged = true;
                _score = value;
            }
		}

		/// <summary>
		/// This Property represents the DateTaken which has datetime type
		/// </summary>
		private DateTime _dateTaken;
        [DataObjectField(false,false,true)]
		public DateTime DateTaken
		{
            get 
            {
              return _dateTaken;
            }
            set 
            {
                if (!RBMInitiatingEntity && _dateTaken != value)
                     RBMDataChanged = true;
                _dateTaken = value;
            }
		}

		/// <summary>
		/// This Property represents the LicensingNumber which has nvarchar type
		/// </summary>
		private string _licensingNumber = "";
        [DataObjectField(false,false,true,50)]
		public string LicensingNumber
		{
            get 
            {
              return _licensingNumber;
            }
            set 
            {
                if (!RBMInitiatingEntity && _licensingNumber != value)
                     RBMDataChanged = true;
                _licensingNumber = value;
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


	}
}
