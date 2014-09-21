using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.Eligibility
{
	/// <summary>
	/// This is a Business Entity Class  for EligibleRequestStatusHistory table
	/// </summary>

    [DataObject(true)]
	public class EligibleRequestStatusHistory : Entity
	{
		public EligibleRequestStatusHistory(){}

		/// <summary>
		/// This Property represents the EligibilityRequestStatusId which has int type
		/// </summary>
		private int _eligibilityRequestStatusId;
        [DataObjectField(true,true,false)]
		public int EligibilityRequestStatusId
		{
            get 
            {
              return _eligibilityRequestStatusId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _eligibilityRequestStatusId != value)
                     RBMDataChanged = true;
                _eligibilityRequestStatusId = value;
            }
		}

		/// <summary>
		/// This Property represents the EligibilityStatusId which has int type
		/// </summary>
		private int _eligibilityStatusId;
        [DataObjectField(false,false,true)]
		public int EligibilityStatusId
		{
            get 
            {
              return _eligibilityStatusId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _eligibilityStatusId != value)
                     RBMDataChanged = true;
                _eligibilityStatusId = value;
            }
		}

		/// <summary>
		/// This Property represents the EligibileId which has int type
		/// </summary>
		private int _eligibileId;
        [DataObjectField(false,false,true)]
		public int EligibileId
		{
            get 
            {
              return _eligibileId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _eligibileId != value)
                     RBMDataChanged = true;
                _eligibileId = value;
            }
		}

		/// <summary>
		/// This Property represents the CreationDate which has datetime type
		/// </summary>
		private DateTime _creationDate;
        [DataObjectField(false,false,true)]
		public DateTime CreationDate
		{
            get 
            {
              return _creationDate;
            }
            set 
            {
                if (!RBMInitiatingEntity && _creationDate != value)
                     RBMDataChanged = true;
                _creationDate = value;
            }
		}

		/// <summary>
		/// This Property represents the Notes which has ntext type
		/// </summary>
		private string _notes = "";
        [DataObjectField(false,false,true,16)]
		public string Notes
		{
            get 
            {
              return _notes;
            }
            set 
            {
                if (!RBMInitiatingEntity && _notes != value)
                     RBMDataChanged = true;
                _notes = value;
            }
		}


	}
}
