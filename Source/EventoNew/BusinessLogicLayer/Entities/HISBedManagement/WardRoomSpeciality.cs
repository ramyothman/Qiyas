using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.HISBedManagement
{
	/// <summary>
	/// This is a Business Entity Class  for WardRoomSpeciality table
	/// </summary>

    [DataObject(true)]
	public class WardRoomSpeciality : Entity
	{
		public WardRoomSpeciality(){}

		/// <summary>
		/// This Property represents the RoomSpecialityId which has int type
		/// </summary>
		private int _roomSpecialityId;
        [DataObjectField(true,true,false)]
		public int RoomSpecialityId
		{
            get 
            {
              return _roomSpecialityId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _roomSpecialityId != value)
                     RBMDataChanged = true;
                _roomSpecialityId = value;
            }
		}

		/// <summary>
		/// This Property represents the WardRoomId which has int type
		/// </summary>
		private int _wardRoomId;
        [DataObjectField(false,false,true)]
		public int WardRoomId
		{
            get 
            {
              return _wardRoomId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardRoomId != value)
                     RBMDataChanged = true;
                _wardRoomId = value;
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
