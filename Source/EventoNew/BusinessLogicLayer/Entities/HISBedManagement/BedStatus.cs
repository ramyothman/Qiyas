using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.HISBedManagement
{
	/// <summary>
	/// This is a Business Entity Class  for BedStatus table
	/// </summary>

    [DataObject(true)]
	public class BedStatus : Entity
	{
		public BedStatus(){}

		/// <summary>
		/// This Property represents the BedStatusId which has int type
		/// </summary>
		private int _bedStatusId;
        [DataObjectField(true,true,false)]
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
		/// This Property represents the BedStatusName which has nvarchar type
		/// </summary>
		private string _bedStatusName = "";
        [DataObjectField(false,false,true,50)]
		public string BedStatusName
		{
            get 
            {
              return _bedStatusName;
            }
            set 
            {
                if (!RBMInitiatingEntity && _bedStatusName != value)
                     RBMDataChanged = true;
                _bedStatusName = value;
            }
		}


	}
}
