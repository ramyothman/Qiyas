using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.HISBedManagement
{
	/// <summary>
	/// This is a Business Entity Class  for WardFor table
	/// </summary>

    [DataObject(true)]
	public class WardFor : Entity
	{
		public WardFor(){}

		/// <summary>
		/// This Property represents the WardForId which has int type
		/// </summary>
		private int _wardForId;
        [DataObjectField(true,true,false)]
		public int WardForId
		{
            get 
            {
              return _wardForId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardForId != value)
                     RBMDataChanged = true;
                _wardForId = value;
            }
		}

		/// <summary>
		/// This Property represents the WardForName which has nvarchar type
		/// </summary>
		private string _wardForName = "";
        [DataObjectField(false,false,true,50)]
		public string WardForName
		{
            get 
            {
              return _wardForName;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardForName != value)
                     RBMDataChanged = true;
                _wardForName = value;
            }
		}


	}
}
