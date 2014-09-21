using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.HISBedManagement
{
	/// <summary>
	/// This is a Business Entity Class  for BedType table
	/// </summary>

    [DataObject(true)]
	public class BedType : Entity
	{
		public BedType(){}

		/// <summary>
		/// This Property represents the BedTypeId which has int type
		/// </summary>
		private int _bedTypeId;
        [DataObjectField(true,true,false)]
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
		/// This Property represents the BedTypeName which has nvarchar type
		/// </summary>
		private string _bedTypeName = "";
        [DataObjectField(false,false,true,50)]
		public string BedTypeName
		{
            get 
            {
              return _bedTypeName;
            }
            set 
            {
                if (!RBMInitiatingEntity && _bedTypeName != value)
                     RBMDataChanged = true;
                _bedTypeName = value;
            }
		}


	}
}
