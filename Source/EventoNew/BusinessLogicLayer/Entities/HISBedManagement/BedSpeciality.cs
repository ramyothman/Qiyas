using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.HISBedManagement
{
	/// <summary>
	/// This is a Business Entity Class  for BedSpeciality table
	/// </summary>

    [DataObject(true)]
	public class BedSpeciality : Entity
	{
		public BedSpeciality(){}

		/// <summary>
		/// This Property represents the BedSpecialityId which has int type
		/// </summary>
		private int _bedSpecialityId;
        [DataObjectField(true,true,false)]
		public int BedSpecialityId
		{
            get 
            {
              return _bedSpecialityId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _bedSpecialityId != value)
                     RBMDataChanged = true;
                _bedSpecialityId = value;
            }
		}

		/// <summary>
		/// This Property represents the WardRoomBedId which has int type
		/// </summary>
		private int _wardRoomBedId;
        [DataObjectField(false,false,true)]
		public int WardRoomBedId
		{
            get 
            {
              return _wardRoomBedId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardRoomBedId != value)
                     RBMDataChanged = true;
                _wardRoomBedId = value;
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
