using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.PGME
{
	/// <summary>
	/// This is a Business Entity Class  for PersonReference table
	/// </summary>

    [DataObject(true)]
	public class PersonReference : Entity
	{
		public PersonReference(){}

		/// <summary>
		/// This Property represents the PersonReferenceId which has int type
		/// </summary>
		private int _personReferenceId;
        [DataObjectField(true,true,false)]
		public int PersonReferenceId
		{
            get 
            {
              return _personReferenceId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _personReferenceId != value)
                     RBMDataChanged = true;
                _personReferenceId = value;
            }
		}

		/// <summary>
		/// This Property represents the PersonId which has int type
		/// </summary>
		private int _personId;
        [DataObjectField(false,false,true)]
		public int PersonId
		{
            get 
            {
              return _personId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _personId != value)
                     RBMDataChanged = true;
                _personId = value;
            }
		}

		/// <summary>
		/// This Property represents the ReferenceFullName which has nvarchar type
		/// </summary>
		private string _referenceFullName = "";
        [DataObjectField(false,false,true,150)]
		public string ReferenceFullName
		{
            get 
            {
              return _referenceFullName;
            }
            set 
            {
                if (!RBMInitiatingEntity && _referenceFullName != value)
                     RBMDataChanged = true;
                _referenceFullName = value;
            }
		}

		/// <summary>
		/// This Property represents the ReferenceEmail which has nvarchar type
		/// </summary>
		private string _referenceEmail = "";
        [DataObjectField(false,false,true,150)]
		public string ReferenceEmail
		{
            get 
            {
              return _referenceEmail;
            }
            set 
            {
                if (!RBMInitiatingEntity && _referenceEmail != value)
                     RBMDataChanged = true;
                _referenceEmail = value;
            }
		}

		/// <summary>
		/// This Property represents the ReferenceAddress which has nvarchar type
		/// </summary>
		private string _referenceAddress = "";
        [DataObjectField(false,false,true,250)]
		public string ReferenceAddress
		{
            get 
            {
              return _referenceAddress;
            }
            set 
            {
                if (!RBMInitiatingEntity && _referenceAddress != value)
                     RBMDataChanged = true;
                _referenceAddress = value;
            }
		}

		/// <summary>
		/// This Property represents the ReferenceContactNumber which has nvarchar type
		/// </summary>
		private string _referenceContactNumber = "";
        [DataObjectField(false,false,true,50)]
		public string ReferenceContactNumber
		{
            get 
            {
              return _referenceContactNumber;
            }
            set 
            {
                if (!RBMInitiatingEntity && _referenceContactNumber != value)
                     RBMDataChanged = true;
                _referenceContactNumber = value;
            }
		}

		/// <summary>
		/// This Property represents the ReferenceMobileNumber which has nvarchar type
		/// </summary>
		private string _referenceMobileNumber = "";
        [DataObjectField(false,false,true,50)]
		public string ReferenceMobileNumber
		{
            get 
            {
              return _referenceMobileNumber;
            }
            set 
            {
                if (!RBMInitiatingEntity && _referenceMobileNumber != value)
                     RBMDataChanged = true;
                _referenceMobileNumber = value;
            }
		}

		/// <summary>
		/// This Property represents the ReferenceLetterPath which has nvarchar type
		/// </summary>
		private string _referenceLetterPath = "";
        [DataObjectField(false,false,true,250)]
		public string ReferenceLetterPath
		{
            get 
            {
              return _referenceLetterPath;
            }
            set 
            {
                if (!RBMInitiatingEntity && _referenceLetterPath != value)
                     RBMDataChanged = true;
                _referenceLetterPath = value;
            }
		}

		/// <summary>
		/// This Property represents the ReferenceLetterMessage which has ntext type
		/// </summary>
		private string _referenceLetterMessage = "";
        [DataObjectField(false,false,true,16)]
		public string ReferenceLetterMessage
		{
            get 
            {
              return _referenceLetterMessage;
            }
            set 
            {
                if (!RBMInitiatingEntity && _referenceLetterMessage != value)
                     RBMDataChanged = true;
                _referenceLetterMessage = value;
            }
		}

		/// <summary>
		/// This Property represents the ReferenceAcceptedPerson which has bit type
		/// </summary>
		private bool _referenceAcceptedPerson;
        [DataObjectField(false,false,true)]
		public bool ReferenceAcceptedPerson
		{
            get 
            {
              return _referenceAcceptedPerson;
            }
            set 
            {
                if (!RBMInitiatingEntity && _referenceAcceptedPerson != value)
                     RBMDataChanged = true;
                _referenceAcceptedPerson = value;
            }
		}

		/// <summary>
		/// This Property represents the ReferenceInstitution which has nvarchar type
		/// </summary>
		private string _referenceInstitution = "";
        [DataObjectField(false,false,true,150)]
		public string ReferenceInstitution
		{
            get 
            {
              return _referenceInstitution;
            }
            set 
            {
                if (!RBMInitiatingEntity && _referenceInstitution != value)
                     RBMDataChanged = true;
                _referenceInstitution = value;
            }
		}


	}
}
