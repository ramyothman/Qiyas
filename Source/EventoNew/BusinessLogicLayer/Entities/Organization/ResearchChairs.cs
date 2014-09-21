using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.Organization
{
	/// <summary>
	/// This is a Business Entity Class  for ResearchChairs table
	/// </summary>

    [DataObject(true)]
	public class ResearchChairs : Entity
	{
		public ResearchChairs(){}

		/// <summary>
		/// This Property represents the ResearchChairId which has int type
		/// </summary>
		private int _researchChairId;
        [DataObjectField(true,true,false)]
		public int ResearchChairId
		{
            get 
            {
              return _researchChairId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _researchChairId != value)
                     RBMDataChanged = true;
                _researchChairId = value;
            }
		}

		/// <summary>
		/// This Property represents the Name which has nvarchar type
		/// </summary>
		private string _name = "";
        [DataObjectField(false,false,true,50)]
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
		/// This Property represents the Description which has nvarchar type
		/// </summary>
		private string _description = "";
        [DataObjectField(false,false,true,250)]
		public string Description
		{
            get 
            {
              return _description;
            }
            set 
            {
                if (!RBMInitiatingEntity && _description != value)
                     RBMDataChanged = true;
                _description = value;
            }
		}

		/// <summary>
		/// This Property represents the Phone1 which has nvarchar type
		/// </summary>
		private string _phone1 = "";
        [DataObjectField(false,false,true,20)]
		public string Phone1
		{
            get 
            {
              return _phone1;
            }
            set 
            {
                if (!RBMInitiatingEntity && _phone1 != value)
                     RBMDataChanged = true;
                _phone1 = value;
            }
		}

		/// <summary>
		/// This Property represents the Phone2 which has nvarchar type
		/// </summary>
		private string _phone2 = "";
        [DataObjectField(false,false,true,20)]
		public string Phone2
		{
            get 
            {
              return _phone2;
            }
            set 
            {
                if (!RBMInitiatingEntity && _phone2 != value)
                     RBMDataChanged = true;
                _phone2 = value;
            }
		}

		/// <summary>
		/// This Property represents the Fax1 which has nvarchar type
		/// </summary>
		private string _fax1 = "";
        [DataObjectField(false,false,true,20)]
		public string Fax1
		{
            get 
            {
              return _fax1;
            }
            set 
            {
                if (!RBMInitiatingEntity && _fax1 != value)
                     RBMDataChanged = true;
                _fax1 = value;
            }
		}

		/// <summary>
		/// This Property represents the Fax2 which has nvarchar type
		/// </summary>
		private string _fax2 = "";
        [DataObjectField(false,false,true,20)]
		public string Fax2
		{
            get 
            {
              return _fax2;
            }
            set 
            {
                if (!RBMInitiatingEntity && _fax2 != value)
                     RBMDataChanged = true;
                _fax2 = value;
            }
		}


	}
}
