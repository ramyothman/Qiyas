using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.Organization
{
	/// <summary>
	/// This is a Business Entity Class  for ResearchChairLanguages table
	/// </summary>

    [DataObject(true)]
	public class ResearchChairLanguages : Entity
	{
		public ResearchChairLanguages(){}

		/// <summary>
		/// This Property represents the ResearchChairLanguagesId which has int type
		/// </summary>
		private int _researchChairLanguagesId;
        [DataObjectField(true,true,false)]
		public int ResearchChairLanguagesId
		{
            get 
            {
              return _researchChairLanguagesId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _researchChairLanguagesId != value)
                     RBMDataChanged = true;
                _researchChairLanguagesId = value;
            }
		}

		/// <summary>
		/// This Property represents the ResearchChairId which has int type
		/// </summary>
		private int _researchChairId;
     [RangeValidator(1,RangeBoundaryType.Inclusive,Int32.MaxValue,RangeBoundaryType.Inclusive,Ruleset="Entity", MessageTemplate="ResearchChairId Not Entered")]
        [DataObjectField(false,false,true)]
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
		/// This Property represents the LanguageId which has int type
		/// </summary>
		private int _languageId;
     [RangeValidator(1,RangeBoundaryType.Inclusive,Int32.MaxValue,RangeBoundaryType.Inclusive,Ruleset="Entity", MessageTemplate="LanguageId Not Entered")]
        [DataObjectField(false,false,true)]
		public int LanguageId
		{
            get 
            {
              return _languageId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _languageId != value)
                     RBMDataChanged = true;
                _languageId = value;
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


	}
}
