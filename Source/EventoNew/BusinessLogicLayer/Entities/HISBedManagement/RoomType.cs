using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.HISBedManagement
{
	/// <summary>
	/// This is a Business Entity Class  for RoomType table
	/// </summary>

    [DataObject(true)]
	public class RoomType : Entity
	{
		public RoomType(){}

		/// <summary>
		/// This Property represents the RoomTypeId which has int type
		/// </summary>
		private int _roomTypeId;
        [DataObjectField(true,true,false)]
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
		/// This Property represents the RoomTypeName which has nvarchar type
		/// </summary>
		private string _roomTypeName = "";
        [DataObjectField(false,false,true,50)]
		public string RoomTypeName
		{
            get 
            {
              return _roomTypeName;
            }
            set 
            {
                if (!RBMInitiatingEntity && _roomTypeName != value)
                     RBMDataChanged = true;
                _roomTypeName = value;
            }
		}


	}
}
