using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.HISBedManagement
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
		/// This Property represents the RoomTypeId which has int type
		/// </summary>
		private int _roomTypeId;
        [DataObjectField(false,false,true)]
		public int RoomTypeId
		{
            get 
            {
              return _roomTypeId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _roomTypeId != value)
                     RBMDataChanged = true;
                _roomTypeId = value;
            }
		}

		/// <summary>
		/// This Property represents the RoomCode which has nvarchar type
		/// </summary>
		private string _roomCode = "";
        [DataObjectField(false,false,true,10)]
		public string RoomCode
		{
            get 
            {
              return _roomCode;
            }
            set 
            {
                if (!RBMInitiatingEntity && _roomCode != value)
                     RBMDataChanged = true;
                _roomCode = value;
            }
		}

		/// <summary>
		/// This Property represents the RoomDescription which has nvarchar type
		/// </summary>
		private string _roomDescription = "";
        [DataObjectField(false,false,true,150)]
		public string RoomDescription
		{
            get 
            {
              return _roomDescription;
            }
            set 
            {
                if (!RBMInitiatingEntity && _roomDescription != value)
                     RBMDataChanged = true;
                _roomDescription = value;
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

		/// <summary>
		/// This Property represents the ClosingReason which has ntext type
		/// </summary>
		private string _closingReason = "";
        [DataObjectField(false,false,true,16)]
		public string ClosingReason
		{
            get 
            {
              return _closingReason;
            }
            set 
            {
                if (!RBMInitiatingEntity && _closingReason != value)
                     RBMDataChanged = true;
                _closingReason = value;
            }
		}


	}
}
