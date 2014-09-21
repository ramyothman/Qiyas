using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.Eligibility
{
	/// <summary>
	/// This is a Business Entity Class  for Hospital table
	/// </summary>

    [DataObject(true)]
	public class Hospital : Entity
	{
		public Hospital(){}

		/// <summary>
		/// This Property represents the EligibilityHospitalID which has int type
		/// </summary>
		private int _eligibilityHospitalID;
        [DataObjectField(true,true,false)]
		public int EligibilityHospitalID
		{
            get 
            {
              return _eligibilityHospitalID;
            }
            set 
            {
                if (!RBMInitiatingEntity && _eligibilityHospitalID != value)
                     RBMDataChanged = true;
                _eligibilityHospitalID = value;
            }
		}

		/// <summary>
		/// This Property represents the HospitalName which has nvarchar type
		/// </summary>
		private string _hospitalName = "";
        [DataObjectField(false,false,true,50)]
		public string HospitalName
		{
            get 
            {
              return _hospitalName;
            }
            set 
            {
                if (!RBMInitiatingEntity && _hospitalName != value)
                     RBMDataChanged = true;
                _hospitalName = value;
            }
		}

		/// <summary>
		/// This Property represents the Phone which has nvarchar type
		/// </summary>
		private string _phone = "";
        [DataObjectField(false,false,true,20)]
		public string Phone
		{
            get 
            {
              return _phone;
            }
            set 
            {
                if (!RBMInitiatingEntity && _phone != value)
                     RBMDataChanged = true;
                _phone = value;
            }
		}

		/// <summary>
		/// This Property represents the Fax which has nvarchar type
		/// </summary>
		private string _fax = "";
        [DataObjectField(false,false,true,20)]
		public string Fax
		{
            get 
            {
              return _fax;
            }
            set 
            {
                if (!RBMInitiatingEntity && _fax != value)
                     RBMDataChanged = true;
                _fax = value;
            }
		}

		/// <summary>
		/// This Property represents the Email which has nvarchar type
		/// </summary>
		private string _email = "";
        [DataObjectField(false,false,true,50)]
		public string Email
		{
            get 
            {
              return _email;
            }
            set 
            {
                if (!RBMInitiatingEntity && _email != value)
                     RBMDataChanged = true;
                _email = value;
            }
		}

		/// <summary>
		/// This Property represents the SiteURL which has nvarchar type
		/// </summary>
		private string _siteURL = "";
        [DataObjectField(false,false,true,150)]
		public string SiteURL
		{
            get 
            {
              return _siteURL;
            }
            set 
            {
                if (!RBMInitiatingEntity && _siteURL != value)
                     RBMDataChanged = true;
                _siteURL = value;
            }
		}

		/// <summary>
		/// This Property represents the UserID which has int type
		/// </summary>
		private int _userID;
        [DataObjectField(false,false,true)]
		public int UserID
		{
            get 
            {
              return _userID;
            }
            set 
            {
                if (!RBMInitiatingEntity && _userID != value)
                     RBMDataChanged = true;
                _userID = value;
            }
		}


	}
}
