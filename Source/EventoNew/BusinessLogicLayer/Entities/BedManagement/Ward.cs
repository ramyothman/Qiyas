using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using System.Collections.Generic;
namespace BusinessLogicLayer.Entities.BedManagement
{
	/// <summary>
	/// This is a Business Entity Class  for Ward table
	/// </summary>

    [DataObject(true)]
	public class Ward : Entity
	{
		public Ward(){}

		/// <summary>
		/// This Property represents the WardId which has int type
		/// </summary>
		private int _wardId;
        [DataObjectField(true,true,false)]
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
		/// This Property represents the WardCode which has nvarchar type
		/// </summary>
		private string _wardCode = "";
        [DataObjectField(false,false,true,8)]
		public string WardCode
		{
            get 
            {
              return _wardCode;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardCode != value)
                     RBMDataChanged = true;
                _wardCode = value;
            }
		}

		/// <summary>
		/// This Property represents the WardDescription which has nvarchar type
		/// </summary>
		private string _wardDescription = "";
        [DataObjectField(false,false,true,50)]
		public string WardDescription
		{
            get 
            {
              return _wardDescription;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardDescription != value)
                     RBMDataChanged = true;
                _wardDescription = value;
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
		/// This Property represents the WardCapacity which has int type
		/// </summary>
		private int _wardCapacity;
        [DataObjectField(false,false,true)]
		public int WardCapacity
		{
            get 
            {
              return _wardCapacity;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardCapacity != value)
                     RBMDataChanged = true;
                _wardCapacity = value;
            }
		}

		/// <summary>
		/// This Property represents the RoomsNumber which has int type
		/// </summary>
		private int _roomsNumber;
        [DataObjectField(false,false,true)]
		public int RoomsNumber
		{
            get 
            {
              return _roomsNumber;
            }
            set 
            {
                if (!RBMInitiatingEntity && _roomsNumber != value)
                     RBMDataChanged = true;
                _roomsNumber = value;
            }
		}

		/// <summary>
		/// This Property represents the WardType which has nvarchar type
		/// </summary>
		private string _wardType = "";
        [DataObjectField(false,false,true,1)]
		public string WardType
		{
            get 
            {
              return _wardType;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardType != value)
                     RBMDataChanged = true;
                _wardType = value;
            }
		}

		/// <summary>
		/// This Property represents the WardPhone which has nvarchar type
		/// </summary>
		private string _wardPhone = "";
        [DataObjectField(false,false,true,14)]
		public string WardPhone
		{
            get 
            {
              return _wardPhone;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardPhone != value)
                     RBMDataChanged = true;
                _wardPhone = value;
            }
		}

		/// <summary>
		/// This Property represents the WardColor which has nvarchar type
		/// </summary>
		private string _wardColor = "";
        [DataObjectField(false,false,true,10)]
		public string WardColor
		{
            get 
            {
              return _wardColor;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardColor != value)
                     RBMDataChanged = true;
                _wardColor = value;
            }
		}

		/// <summary>
		/// This Property represents the WardOrder which has int type
		/// </summary>
		private int _wardOrder;
        [DataObjectField(false,false,true)]
		public int WardOrder
		{
            get 
            {
              return _wardOrder;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardOrder != value)
                     RBMDataChanged = true;
                _wardOrder = value;
            }
		}
        private List<WardRoom> _WardRooms = null;
        public List<WardRoom> WardRooms
        {
            set { _WardRooms = value; }
            get
            {
                if (_WardRooms == null)
                {
                    _WardRooms = Common.WardRoomLogic.GetAllByWardId(_wardId);
                }
                return _WardRooms;
            }
        }
        public void SetWardRooms()
        {
            if (_WardRooms == null)
                _WardRooms = new List<WardRoom>();
        }

	}
}
