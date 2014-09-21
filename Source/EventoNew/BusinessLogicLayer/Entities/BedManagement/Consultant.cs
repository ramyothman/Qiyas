using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.BedManagement
{
	/// <summary>
	/// This is a Business Entity Class  for Consultant table
	/// </summary>

    [DataObject(true)]
	public class Consultant : Entity
	{
		public Consultant(){}

		/// <summary>
		/// This Property represents the ConsultantId which has int type
		/// </summary>
		private int _consultantId;
     [NotNullValidator]
     [RangeValidator(1,RangeBoundaryType.Inclusive,Int32.MaxValue,RangeBoundaryType.Inclusive,Ruleset="Entity", MessageTemplate="ConsultantId Not Entered")]
        [DataObjectField(true,false,false)]
		public int ConsultantId
		{
            get 
            {
              return _consultantId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _consultantId != value)
                     RBMDataChanged = true;
                _consultantId = value;
            }
		}

		/// <summary>
		/// This Property represents the ConsultantCode which has nvarchar type
		/// </summary>
		private string _consultantCode = "";
        [DataObjectField(false,false,true,50)]
		public string ConsultantCode
		{
            get 
            {
              return _consultantCode;
            }
            set 
            {
                if (!RBMInitiatingEntity && _consultantCode != value)
                     RBMDataChanged = true;
                _consultantCode = value;
            }
		}


	}
}
