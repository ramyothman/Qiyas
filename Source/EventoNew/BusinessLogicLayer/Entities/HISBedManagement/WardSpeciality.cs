using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.HISBedManagement
{
	/// <summary>
	/// This is a Business Entity Class  for WardSpeciality table
	/// </summary>

    [DataObject(true)]
	public class WardSpeciality : Entity
	{
		public WardSpeciality(){}

		/// <summary>
		/// This Property represents the WardSpeciality which has int type
		/// </summary>
		private int _wardSpeciality;
        [DataObjectField(true,true,false)]
		public int WardSpecialityId
		{
            get 
            {
              return _wardSpeciality;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardSpeciality != value)
                     RBMDataChanged = true;
                _wardSpeciality = value;
            }
		}

		/// <summary>
		/// This Property represents the WardId which has int type
		/// </summary>
		private int _wardId;
        [DataObjectField(false,false,true)]
		public int WardId
		{
            get 
            {
              return _wardId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardId != value)
                     RBMDataChanged = true;
                _wardId = value;
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
		/// This Property represents the IsMainSpeciality which has bit type
		/// </summary>
		private bool _isMainSpeciality;
        [DataObjectField(false,false,true)]
		public bool IsMainSpeciality
		{
            get 
            {
              return _isMainSpeciality;
            }
            set 
            {
                if (!RBMInitiatingEntity && _isMainSpeciality != value)
                     RBMDataChanged = true;
                _isMainSpeciality = value;
            }
		}

		/// <summary>
		/// This Property represents the SpecialityOrder which has int type
		/// </summary>
		private int _specialityOrder;
        [DataObjectField(false,false,true)]
		public int SpecialityOrder
		{
            get 
            {
              return _specialityOrder;
            }
            set 
            {
                if (!RBMInitiatingEntity && _specialityOrder != value)
                     RBMDataChanged = true;
                _specialityOrder = value;
            }
		}


	}
}
