using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.HISBedManagement
{
	/// <summary>
	/// This is a Business Entity Class  for Speciality table
	/// </summary>

    [DataObject(true)]
	public class Speciality : Entity
	{
		public Speciality(){}

		/// <summary>
		/// This Property represents the SpecialityId which has int type
		/// </summary>
		private int _specialityId;
        [DataObjectField(true,true,false)]
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
		/// This Property represents the SpecialityCode which has nvarchar type
		/// </summary>
		private string _specialityCode = "";
        [DataObjectField(false,false,true,10)]
		public string SpecialityCode
		{
            get 
            {
              return _specialityCode;
            }
            set 
            {
                if (!RBMInitiatingEntity && _specialityCode != value)
                     RBMDataChanged = true;
                _specialityCode = value;
            }
		}

		/// <summary>
		/// This Property represents the SpecialityName which has nvarchar type
		/// </summary>
		private string _specialityName = "";
        [DataObjectField(false,false,true,50)]
		public string SpecialityName
		{
            get 
            {
              return _specialityName;
            }
            set 
            {
                if (!RBMInitiatingEntity && _specialityName != value)
                     RBMDataChanged = true;
                _specialityName = value;
            }
		}

		/// <summary>
		/// This Property represents the SpecialityAbbreviation which has nvarchar type
		/// </summary>
		private string _specialityAbbreviation = "";
        [DataObjectField(false,false,true,10)]
		public string SpecialityAbbreviation
		{
            get 
            {
              return _specialityAbbreviation;
            }
            set 
            {
                if (!RBMInitiatingEntity && _specialityAbbreviation != value)
                     RBMDataChanged = true;
                _specialityAbbreviation = value;
            }
		}


	}
}
