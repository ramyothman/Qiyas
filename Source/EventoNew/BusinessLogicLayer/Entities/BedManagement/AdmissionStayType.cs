using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities.BedManagement
{
	/// <summary>
	/// This is a Business Entity Class  for AdmissionStayType table
	/// </summary>

    [DataObject(true)]
	public class AdmissionStayType : Entity
	{
		public AdmissionStayType(){}

		/// <summary>
		/// This Property represents the AdmissionStayTypeId which has int type
		/// </summary>
		private int _admissionStayTypeId;
        [DataObjectField(true,true,false)]
		public int AdmissionStayTypeId
		{
            get 
            {
              return _admissionStayTypeId;
            }
            set 
            {
                if (!RBMInitiatingEntity && _admissionStayTypeId != value)
                     RBMDataChanged = true;
                _admissionStayTypeId = value;
            }
		}

		/// <summary>
		/// This Property represents the Name which has nvarchar type
		/// </summary>
		private string _name = "";
        [DataObjectField(false,false,true,250)]
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
		/// This Property represents the Duration which has int type
		/// </summary>
		private int _duration;
        [DataObjectField(false,false,true)]
		public int Duration
		{
            get 
            {
              return _duration;
            }
            set 
            {
                if (!RBMInitiatingEntity && _duration != value)
                     RBMDataChanged = true;
                _duration = value;
            }
		}

		/// <summary>
		/// This Property represents the Code which has nvarchar type
		/// </summary>
		private string _code = "";
        [DataObjectField(false,false,true,5)]
		public string Code
		{
            get 
            {
              return _code;
            }
            set 
            {
                if (!RBMInitiatingEntity && _code != value)
                     RBMDataChanged = true;
                _code = value;
            }
		}

		/// <summary>
		/// This Property represents the AdmissionStayOrder which has int type
		/// </summary>
		private int _admissionStayOrder;
        [DataObjectField(false,false,true)]
		public int AdmissionStayOrder
		{
            get 
            {
              return _admissionStayOrder;
            }
            set 
            {
                if (!RBMInitiatingEntity && _admissionStayOrder != value)
                     RBMDataChanged = true;
                _admissionStayOrder = value;
            }
		}


	}
}
