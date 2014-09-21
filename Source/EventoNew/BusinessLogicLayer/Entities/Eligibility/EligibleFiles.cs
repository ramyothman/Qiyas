using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.Eligibility
{
	/// <summary>
	/// This is a Business Entity Class  for EligibleFiles table
	/// </summary>

    [DataObject(true)]
	public class EligibleFiles : Entity
	{
		public EligibleFiles(){}

		/// <summary>
		/// This Property represents the EligibleFileId which has int type
		/// </summary>
		private int _eligibleFileId;
        [DataObjectField(true,true,false)]
		public int EligibleFileId
		{
            get 
            {
              return _eligibleFileId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _eligibleFileId != value)
                     RBMDataChanged = true;
                _eligibleFileId = value;
            }
		}

		/// <summary>
		/// This Property represents the EligibleId which has int type
		/// </summary>
		private int _eligibleId;
        [DataObjectField(false,false,true)]
		public int EligibleId
		{
            get 
            {
              return _eligibleId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _eligibleId != value)
                     RBMDataChanged = true;
                _eligibleId = value;
            }
		}

		/// <summary>
		/// This Property represents the FileName which has nvarchar type
		/// </summary>
		private string _fileName = "";
        [DataObjectField(false,false,true,50)]
		public string FileName
		{
            get 
            {
              return _fileName;
            }
            set 
            {
                if (!RBMInitiatingEntity && _fileName != value)
                     RBMDataChanged = true;
                _fileName = value;
            }
		}

		/// <summary>
		/// This Property represents the FileDescription which has nvarchar type
		/// </summary>
		private string _fileDescription = "";
        [DataObjectField(false,false,true,50)]
		public string FileDescription
		{
            get 
            {
              return _fileDescription;
            }
            set 
            {
                if (!RBMInitiatingEntity && _fileDescription != value)
                     RBMDataChanged = true;
                _fileDescription = value;
            }
		}

		/// <summary>
		/// This Property represents the FilePath which has nvarchar type
		/// </summary>
		private string _filePath = "";
        [DataObjectField(false,false,true,250)]
		public string FilePath
		{
            get 
            {
              return _filePath;
            }
            set 
            {
                if (!RBMInitiatingEntity && _filePath != value)
                     RBMDataChanged = true;
                _filePath = value;
            }
		}


	}
}
