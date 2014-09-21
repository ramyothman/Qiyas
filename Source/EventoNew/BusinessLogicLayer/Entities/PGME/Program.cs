using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.PGME
{
	/// <summary>
	/// This is a Business Entity Class  for Program table
	/// </summary>

    [DataObject(true)]
	public class Program : Entity
	{
		public Program(){}

		/// <summary>
		/// This Property represents the ProgramId which has int type
		/// </summary>
		private int _programId;
        [DataObjectField(true,true,false)]
		public int ProgramId
		{
            get 
            {
              return _programId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _programId != value)
                     RBMDataChanged = true;
                _programId = value;
            }
		}

		/// <summary>
		/// This Property represents the ProgramTypeId which has int type
		/// </summary>
		private int _programTypeId;
        [DataObjectField(false,false,true)]
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
		/// This Property represents the DepartmentId which has int type
		/// </summary>
		private int _departmentId;
        [DataObjectField(false,false,true)]
		public int DepartmentId
		{
            get 
            {
              return _departmentId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _departmentId != value)
                     RBMDataChanged = true;
                _departmentId = value;
            }
		}

		/// <summary>
		/// This Property represents the ProgramName which has nvarchar type
		/// </summary>
		private string _programName = "";
        [DataObjectField(false,false,true,150)]
		public string ProgramName
		{
            get 
            {
              return _programName;
            }
            set 
            {
                if (!RBMInitiatingEntity && _programName != value)
                     RBMDataChanged = true;
                _programName = value;
            }
		}

		/// <summary>
		/// This Property represents the ProgramDescription which has ntext type
		/// </summary>
		private string _programDescription = "";
        [DataObjectField(false,false,true,16)]
		public string ProgramDescription
		{
            get 
            {
              return _programDescription;
            }
            set 
            {
                if (!RBMInitiatingEntity && _programDescription != value)
                     RBMDataChanged = true;
                _programDescription = value;
            }
		}


	}
}
