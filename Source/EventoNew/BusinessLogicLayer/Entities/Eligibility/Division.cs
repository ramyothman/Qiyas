using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.Eligibility
{
	/// <summary>
	/// This is a Business Entity Class  for Division table
	/// </summary>

    [DataObject(true)]
	public class Division : Entity
	{
		public Division(){}

		/// <summary>
		/// This Property represents the DivisionID which has int type
		/// </summary>
		private int _divisionID;
        [DataObjectField(true,true,false)]
		public int DivisionID
		{
            get 
            {
              return _divisionID;
            }
            set 
            {
                if (!RBMInitiatingEntity && _divisionID != value)
                     RBMDataChanged = true;
                _divisionID = value;
            }
		}

		/// <summary>
		/// This Property represents the DepartmentID which has int type
		/// </summary>
		private int _departmentID;
        [DataObjectField(false,false,false)]
		public int DepartmentID
		{
            get 
            {
              return _departmentID;
            }
            set 
            {
                if (!RBMInitiatingEntity && _departmentID != value)
                     RBMDataChanged = true;
                _departmentID = value;
            }
		}

		/// <summary>
		/// This Property represents the Name which has nvarchar type
		/// </summary>
		private string _name = "";
        [DataObjectField(false,false,false,50)]
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
		/// This Property represents the SiteUrl which has nvarchar type
		/// </summary>
		private string _siteUrl = "";
        [DataObjectField(false,false,true,150)]
		public string SiteUrl
		{
            get 
            {
              return _siteUrl;
            }
            set 
            {
                if (!RBMInitiatingEntity && _siteUrl != value)
                     RBMDataChanged = true;
                _siteUrl = value;
            }
		}


	}
}
