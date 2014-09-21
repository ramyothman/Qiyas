using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.BedManagement
{
	/// <summary>
	/// This is a Business Entity Class  for WardSpeciality table
	/// </summary>

    [DataObject(true)]
	public class WardSpeciality : Entity
	{
		public WardSpeciality(){}

		/// <summary>
		/// This Property represents the WardSpecialityId which has int type
		/// </summary>
		private int _wardSpecialityId;
        [DataObjectField(true,true,false)]
		public int WardSpecialityId
		{
            get 
            {
              return _wardSpecialityId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardSpecialityId != value)
                     RBMDataChanged = true;
                _wardSpecialityId = value;
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
		/// This Property represents the IsMain which has bit type
		/// </summary>
		private bool _isMain;
        [DataObjectField(false,false,true)]
		public bool IsMain
		{
            get 
            {
              return _isMain;
            }
            set 
            {
                if (!RBMInitiatingEntity && _isMain != value)
                     RBMDataChanged = true;
                _isMain = value;
            }
		}


	}
}
