using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using System.Collections.Generic;
namespace BusinessLogicLayer.Entities.BedManagement
{
	/// <summary>
	/// This is a Business Entity Class  for WardRoom table
	/// </summary>

    [DataObject(true)]
	public class WardRoom : Entity
	{
		public WardRoom(){}

		/// <summary>
		/// This Property represents the WardRoomId which has int type
		/// </summary>
		private int _wardRoomId;
        [DataObjectField(true,true,false)]
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
		/// This Property represents the RoomColor which has nvarchar type
		/// </summary>
		private string _roomColor = "";
        [DataObjectField(false,false,true,10)]
		public string RoomColor
		{
            get 
            {
              return _roomColor;
            }
            set 
            {
                if (!RBMInitiatingEntity && _roomColor != value)
                     RBMDataChanged = true;
                _roomColor = value;
            }
		}

		/// <summary>
		/// This Property represents the RoomNumber which has int type
		/// </summary>
		private int _roomNumber;
        [DataObjectField(false,false,true)]
		public int RoomNumber
		{
            get 
            {
              return _roomNumber;
            }
            set 
            {
                if (!RBMInitiatingEntity && _roomNumber != value)
                     RBMDataChanged = true;
                _roomNumber = value;
            }
		}

		/// <summary>
		/// This Property represents the BedsNumber which has int type
		/// </summary>
		private int _bedsNumber;
        [DataObjectField(false,false,true)]
		public int BedsNumber
		{
            get 
            {
              return _bedsNumber;
            }
            set 
            {
                if (!RBMInitiatingEntity && _bedsNumber != value)
                     RBMDataChanged = true;
                _bedsNumber = value;
            }
		}

		/// <summary>
		/// This Property represents the Capacity which has int type
		/// </summary>
		private int _capacity;
        [DataObjectField(false,false,true)]
		public int Capacity
		{
            get 
            {
              return _capacity;
            }
            set 
            {
                if (!RBMInitiatingEntity && _capacity != value)
                     RBMDataChanged = true;
                _capacity = value;
            }
		}

		/// <summary>
		/// This Property represents the IsPrivate which has bit type
		/// </summary>
		private bool _isPrivate;
        [DataObjectField(false,false,true)]
		public bool IsPrivate
		{
            get 
            {
              return _isPrivate;
            }
            set 
            {
                if (!RBMInitiatingEntity && _isPrivate != value)
                     RBMDataChanged = true;
                _isPrivate = value;
            }
		}

		/// <summary>
		/// This Property represents the RoomPhone which has nvarchar type
		/// </summary>
		private string _roomPhone = "";
        [DataObjectField(false,false,true,14)]
		public string RoomPhone
		{
            get 
            {
              return _roomPhone;
            }
            set 
            {
                if (!RBMInitiatingEntity && _roomPhone != value)
                     RBMDataChanged = true;
                _roomPhone = value;
            }
		}

		/// <summary>
		/// This Property represents the WardRoomTypeId which has int type
		/// </summary>
		private int _wardRoomTypeId;
        [DataObjectField(false,false,true)]
		public int WardRoomTypeId
		{
            get 
            {
              return _wardRoomTypeId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardRoomTypeId != value)
                     RBMDataChanged = true;
                _wardRoomTypeId = value;
            }
		}

		/// <summary>
		/// This Property represents the IsClosed which has bit type
		/// </summary>
		private bool _isClosed;
        [DataObjectField(false,false,true)]
		public bool IsClosed
		{
            get 
            {
              return _isClosed;
            }
            set 
            {
                if (!RBMInitiatingEntity && _isClosed != value)
                     RBMDataChanged = true;
                _isClosed = value;
            }
		}

        public List<WardBed> _WardBeds = null;
        public List<WardBed> WardBeds
        {
            set { _WardBeds = value; }
            get
            {
                if (_WardBeds == null)
                {
                    _WardBeds = BusinessLogicLayer.Common.WardBedLogic.GetAllByWardRoomId(_wardRoomId);
                }
                return _WardBeds;
            }
        }
        public void SetWardBeds()
        {
            if (_WardBeds == null)
                _WardBeds = new List<WardBed>();
        }
	}
}
