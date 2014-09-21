using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.HISBedManagement
{
	/// <summary>
	/// This is a Business Entity Class  for WardRoomBed table
	/// </summary>

    [DataObject(true)]
	public class WardRoomBed : Entity
	{
		public WardRoomBed(){}

		/// <summary>
		/// This Property represents the WardRoomBedId which has int type
		/// </summary>
		private int _wardRoomBedId;
        [DataObjectField(true,true,false)]
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
		/// This Property represents the BedStatusId which has int type
		/// </summary>
		private int _bedStatusId;
        [DataObjectField(false,false,true)]
		public int BedStatusId
		{
            get 
            {
              return _bedStatusId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _bedStatusId != value)
                     RBMDataChanged = true;
                _bedStatusId = value;
            }
		}

		/// <summary>
		/// This Property represents the BedTypeId which has int type
		/// </summary>
		private int _bedTypeId;
        [DataObjectField(false,false,true)]
		public int BedTypeId
		{
            get 
            {
              return _bedTypeId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _bedTypeId != value)
                     RBMDataChanged = true;
                _bedTypeId = value;
            }
		}

		/// <summary>
		/// This Property represents the BedCode which has nvarchar type
		/// </summary>
		private string _bedCode = "";
        [DataObjectField(false,false,true,10)]
		public string BedCode
		{
            get 
            {
              return _bedCode;
            }
            set 
            {
                if (!RBMInitiatingEntity && _bedCode != value)
                     RBMDataChanged = true;
                _bedCode = value;
            }
		}


	}
}
