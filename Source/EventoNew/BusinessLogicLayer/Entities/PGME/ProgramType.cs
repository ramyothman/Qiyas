using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.PGME
{
	/// <summary>
	/// This is a Business Entity Class  for ProgramType table
	/// </summary>

    [DataObject(true)]
	public class ProgramType : Entity
	{
		public ProgramType(){}

		/// <summary>
		/// This Property represents the ProgramTypeId which has int type
		/// </summary>
		private int _programTypeId;
        [DataObjectField(true,true,false)]
		public int ProgramTypeId
		{
            get 
            {
              return _programTypeId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _programTypeId != value)
                     RBMDataChanged = true;
                _programTypeId = value;
            }
		}

		/// <summary>
		/// This Property represents the ProgramTypeName which has nvarchar type
		/// </summary>
		private string _programTypeName = "";
        [DataObjectField(false,false,true,50)]
		public string ProgramTypeName
		{
            get 
            {
              return _programTypeName;
            }
            set 
            {
                if (!RBMInitiatingEntity && _programTypeName != value)
                     RBMDataChanged = true;
                _programTypeName = value;
            }
		}


	}
}
