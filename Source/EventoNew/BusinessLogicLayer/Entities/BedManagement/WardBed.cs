using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.BedManagement
{
	/// <summary>
	/// This is a Business Entity Class  for WardBed table
	/// </summary>

    [DataObject(true)]
	public class WardBed : Entity
	{
		public WardBed(){}

		/// <summary>
		/// This Property represents the WardBedId which has int type
		/// </summary>
		private int _wardBedId;
        [DataObjectField(true,true,false)]
		public int WardBedId
		{
            get 
            {
              return _wardBedId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardBedId != value)
                     RBMDataChanged = true;
                _wardBedId = value;
            }
		}

		/// <summary>
		/// This Property represents the WardRoomId which has int type
		/// </summary>
		private int _wardRoomId;
        [DataObjectField(false,false,true)]
		public int WardRoomId
		{
            get 
            {
              return _wardRoomId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _wardRoomId != value)
                     RBMDataChanged = true;
                _wardRoomId = value;
            }
		}

		/// <summary>
		/// This Property represents the BedNumber which has int type
		/// </summary>
		private int _bedNumber;
        [DataObjectField(false,false,true)]
		public int BedNumber
		{
            get 
            {
              return _bedNumber;
            }
            set 
            {
                if (!RBMInitiatingEntity && _bedNumber != value)
                     RBMDataChanged = true;
                _bedNumber = value;
            }
		}

		/// <summary>
		/// This Property represents the BedCode which has nvarchar type
		/// </summary>
		private string _bedCode = "";
        [DataObjectField(false,false,true,50)]
		public string BedCode
		{
            get 
            {
              return _bedCode;
            }
            set 
            {
                if (!RBMInitiatingEntity && _bedCode != value)
                     RBMDataChanged = true;
                _bedCode = value;
            }
		}

		/// <summary>
		/// This Property represents the BedStatus which has nvarchar type
		/// </summary>
		private string _bedStatus = "";
        [DataObjectField(false,false,true,1)]
		public string BedStatus
		{
            get 
            {
              return _bedStatus;
            }
            set 
            {
                if (!RBMInitiatingEntity && _bedStatus != value)
                     RBMDataChanged = true;
                _bedStatus = value;
            }
		}

		/// <summary>
		/// This Property represents the BedType which has nvarchar type
		/// </summary>
		private string _bedType = "";
        [DataObjectField(false,false,true,50)]
		public string BedType
		{
            get 
            {
              return _bedType;
            }
            set 
            {
                if (!RBMInitiatingEntity && _bedType != value)
                     RBMDataChanged = true;
                _bedType = value;
            }
		}

		/// <summary>
		/// This Property represents the BedStatusPercentage which has int type
		/// </summary>
		private int _bedStatusPercentage;
        [DataObjectField(false,false,true)]
		public int BedStatusPercentage
		{
            get 
            {
              return _bedStatusPercentage;
            }
            set 
            {
                if (!RBMInitiatingEntity && _bedStatusPercentage != value)
                     RBMDataChanged = true;
                _bedStatusPercentage = value;
            }
		}

		/// <summary>
		/// This Property represents the CurrentPatientCode which has nvarchar type
		/// </summary>
		private string _currentPatientCode = "";
        [DataObjectField(false,false,true,8)]
		public string CurrentPatientCode
		{
            get 
            {
              return _currentPatientCode;
            }
            set 
            {
                if (!RBMInitiatingEntity && _currentPatientCode != value)
                     RBMDataChanged = true;
                _currentPatientCode = value;
            }
		}

		/// <summary>
		/// This Property represents the SpecialityId which has int type
		/// </summary>
		private int _specialityId;
        [DataObjectField(false,false,true)]
		public int SpecialityId
		{
            get 
            {
              return _specialityId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _specialityId != value)
                     RBMDataChanged = true;
                _specialityId = value;
            }
		}


	}
}
