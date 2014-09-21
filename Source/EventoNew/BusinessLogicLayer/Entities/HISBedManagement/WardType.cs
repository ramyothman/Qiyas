using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.HISBedManagement
{
	/// <summary>
	/// This is a Business Entity Class  for WardType table
	/// </summary>

    [DataObject(true)]
	public class WardType : Entity
	{
		public WardType(){}

		/// <summary>
		/// This Property represents the WardTypeId which has int type
		/// </summary>
		private int _wardTypeId;
        [DataObjectField(true,true,false)]
		public int WardTypeId
		{
            get 
            {
              return _wardTypeId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardTypeId != value)
                     RBMDataChanged = true;
                _wardTypeId = value;
            }
		}

		/// <summary>
		/// This Property represents the WardTypeName which has nvarchar type
		/// </summary>
		private string _wardTypeName = "";
        [DataObjectField(false,false,true,50)]
		public string WardTypeName
		{
            get 
            {
              return _wardTypeName;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardTypeName != value)
                     RBMDataChanged = true;
                _wardTypeName = value;
            }
		}


	}
}
