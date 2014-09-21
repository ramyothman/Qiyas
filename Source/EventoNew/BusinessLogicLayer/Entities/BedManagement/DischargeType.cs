using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.BedManagement
{
	/// <summary>
	/// This is a Business Entity Class  for DischargeType table
	/// </summary>

    [DataObject(true)]
	public class DischargeType : Entity
	{
		public DischargeType(){}

		/// <summary>
		/// This Property represents the DischargeTypeId which has int type
		/// </summary>
		private int _dischargeTypeId;
        [DataObjectField(true,true,false)]
		public int DischargeTypeId
		{
            get 
            {
              return _dischargeTypeId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _dischargeTypeId != value)
                     RBMDataChanged = true;
                _dischargeTypeId = value;
            }
		}

		/// <summary>
		/// This Property represents the Name which has nvarchar type
		/// </summary>
		private string _name = "";
        [DataObjectField(false,false,true,250)]
		public string Name
		{
            get 
            {
              return _name;
            }
            set 
            {
                if (!RBMInitiatingEntity && _name != value)
                     RBMDataChanged = true;
                _name = value;
            }
		}

		/// <summary>
		/// This Property represents the DischargeCode which has nvarchar type
		/// </summary>
		private string _dischargeCode = "";
        [DataObjectField(false,false,true,5)]
		public string DischargeCode
		{
            get 
            {
              return _dischargeCode;
            }
            set 
            {
                if (!RBMInitiatingEntity && _dischargeCode != value)
                     RBMDataChanged = true;
                _dischargeCode = value;
            }
		}

		/// <summary>
		/// This Property represents the DischargeOrder which has int type
		/// </summary>
		private int _dischargeOrder;
        [DataObjectField(false,false,true)]
		public int DischargeOrder
		{
            get 
            {
              return _dischargeOrder;
            }
            set 
            {
                if (!RBMInitiatingEntity && _dischargeOrder != value)
                     RBMDataChanged = true;
                _dischargeOrder = value;
            }
		}


	}
}
