using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.BedManagement
{
	/// <summary>
	/// This is a Business Entity Class  for WardRoomType table
	/// </summary>

    [DataObject(true)]
	public class WardRoomType : Entity
	{
		public WardRoomType(){}

		/// <summary>
		/// This Property represents the WardRoomTypeId which has int type
		/// </summary>
		private int _wardRoomTypeId;
        [DataObjectField(true,true,false)]
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
		/// This Property represents the WardRoomTypeName which has nvarchar type
		/// </summary>
		private string _wardRoomTypeName = "";
        [DataObjectField(false,false,true,150)]
		public string WardRoomTypeName
		{
            get 
            {
              return _wardRoomTypeName;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardRoomTypeName != value)
                     RBMDataChanged = true;
                _wardRoomTypeName = value;
            }
		}


	}
}
