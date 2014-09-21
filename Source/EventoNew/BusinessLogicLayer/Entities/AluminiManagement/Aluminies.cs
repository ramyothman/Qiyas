using System;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace BusinessLogicLayer.Entities
{
	/// <summary>
	/// This is a Business Entity Class  for Aluminies table
	/// </summary>

    [DataObject(true)]
	public class Aluminies : Entity
	{
		public Aluminies(){}

		/// <summary>
		/// This Property represents the Id which has int type
		/// </summary>
		private int _id;
        [DataObjectField(true,true,false)]
		public int Id
		{
            get 
            {
              return _id;
            }
            set 
            {
                if (!RBMInitiatingEntity && _id != value)
                     RBMDataChanged = true;
                _id = value;
            }
		}

		/// <summary>
		/// This Property represents the AluminiFor which has nvarchar type
		/// </summary>
		private string _aluminiFor = "";
        [DataObjectField(false,false,true,50)]
		public string AluminiFor
		{
            get 
            {
              return _aluminiFor;
            }
            set 
            {
                if (!RBMInitiatingEntity && _aluminiFor != value)
                     RBMDataChanged = true;
                _aluminiFor = value;
            }
		}

		/// <summary>
		/// This Property represents the Department which has nvarchar type
		/// </summary>
		private string _department = "";
        [DataObjectField(false,false,true,50)]
		public string Department
		{
            get 
            {
              return _department;
            }
            set 
            {
                if (!RBMInitiatingEntity && _department != value)
                     RBMDataChanged = true;
                _department = value;
            }
		}

		/// <summary>
		/// This Property represents the FirstName which has nvarchar type
		/// </summary>
		private string _firstName = "";
        [DataObjectField(false,false,true,150)]
		public string FirstName
		{
            get 
            {
              return _firstName;
            }
            set 
            {
                if (!RBMInitiatingEntity && _firstName != value)
                     RBMDataChanged = true;
                _firstName = value.ToLower();
                if (!string.IsNullOrEmpty(_firstName) && _firstName.Length > 2)
                {
                    _firstName = _firstName.Substring(0, 1).ToUpper() + _firstName.Substring(1, _firstName.Length - 1);
                }
            }
		}

		/// <summary>
		/// This Property represents the MiddleName which has nvarchar type
		/// </summary>
		private string _middleName = "";
        [DataObjectField(false,false,true,150)]
		public string MiddleName
		{
            get 
            {
              return _middleName;
            }
            set 
            {
                if (!RBMInitiatingEntity && _middleName != value)
                     RBMDataChanged = true;
                _middleName = value.ToString();
                if (!string.IsNullOrEmpty(_middleName) && _middleName.Length > 2)
                {
                    _middleName = _middleName.Substring(0, 1).ToUpper() + _middleName.Substring(1, _middleName.Length - 1);
                }
            }
		}

		/// <summary>
		/// This Property represents the FamilyName which has nvarchar type
		/// </summary>
		private string _familyName = "";
        [DataObjectField(false,false,true,150)]
		public string FamilyName
		{
            get 
            {
              return _familyName;
            }
            set 
            {
                if (!RBMInitiatingEntity && _familyName != value)
                     RBMDataChanged = true;
                _familyName = value.ToString();
                if (!string.IsNullOrEmpty(_familyName) && _familyName.Length > 2)
                {
                    _familyName = _familyName.Substring(0, 1).ToUpper() + _familyName.Substring(1, _familyName.Length - 1);
                }
            }
		}

		/// <summary>
		/// This Property represents the YearofJoining which has int type
		/// </summary>
		private int _yearofJoining;
        [DataObjectField(false,false,true)]
		public int YearofJoining
		{
            get 
            {
              return _yearofJoining;
            }
            set 
            {
                if (!RBMInitiatingEntity && _yearofJoining != value)
                     RBMDataChanged = true;
                _yearofJoining = value;
            }
		}

		/// <summary>
		/// This Property represents the YearofGraduation which has int type
		/// </summary>
		private int _yearofGraduation;
        [DataObjectField(false,false,true)]
		public int YearofGraduation
		{
            get 
            {
              return _yearofGraduation;
            }
            set 
            {
                if (!RBMInitiatingEntity && _yearofGraduation != value)
                     RBMDataChanged = true;
                _yearofGraduation = value;
            }
		}

		/// <summary>
		/// This Property represents the UniversityNumber which has nvarchar type
		/// </summary>
		private string _universityNumber = "";
        [DataObjectField(false,false,true,50)]
		public string UniversityNumber
		{
            get 
            {
              return _universityNumber;
            }
            set 
            {
                if (!RBMInitiatingEntity && _universityNumber != value)
                     RBMDataChanged = true;
                _universityNumber = value;
            }
		}

		/// <summary>
		/// This Property represents the Speciality which has nvarchar type
		/// </summary>
		private string _speciality = "";
        [DataObjectField(false,false,true,50)]
		public string Speciality
		{
            get 
            {
              return _speciality;
            }
            set 
            {
                if (!RBMInitiatingEntity && _speciality != value)
                     RBMDataChanged = true;
                _speciality = value;
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
		/// This Property represents the Contact1 which has nvarchar type
		/// </summary>
		private string _contact1 = "";
        [DataObjectField(false,false,true,50)]
		public string Contact1
		{
            get 
            {
              return _contact1;
            }
            set 
            {
                if (!RBMInitiatingEntity && _contact1 != value)
                     RBMDataChanged = true;
                _contact1 = value;
            }
		}

		/// <summary>
		/// This Property represents the Contact2 which has nvarchar type
		/// </summary>
		private string _contact2 = "";
        [DataObjectField(false,false,true,50)]
		public string Contact2
		{
            get 
            {
              return _contact2;
            }
            set 
            {
                if (!RBMInitiatingEntity && _contact2 != value)
                     RBMDataChanged = true;
                _contact2 = value;
            }
		}

		/// <summary>
		/// This Property represents the Contact3 which has nvarchar type
		/// </summary>
		private string _contact3 = "";
        [DataObjectField(false,false,true,50)]
		public string Contact3
		{
            get 
            {
              return _contact3;
            }
            set 
            {
                if (!RBMInitiatingEntity && _contact3 != value)
                     RBMDataChanged = true;
                _contact3 = value;
            }
		}

		/// <summary>
		/// This Property represents the MedicalSchool which has nvarchar type
		/// </summary>
		private string _medicalSchool = "";
        [DataObjectField(false,false,true,50)]
		public string MedicalSchool
		{
            get 
            {
              return _medicalSchool;
            }
            set 
            {
                if (!RBMInitiatingEntity && _medicalSchool != value)
                     RBMDataChanged = true;
                _medicalSchool = value;
            }
		}

		/// <summary>
		/// This Property represents the MedicalSchoolCity which has nvarchar type
		/// </summary>
		private string _medicalSchoolCity = "";
        [DataObjectField(false,false,true,50)]
		public string MedicalSchoolCity
		{
            get 
            {
              return _medicalSchoolCity;
            }
            set 
            {
                if (!RBMInitiatingEntity && _medicalSchoolCity != value)
                     RBMDataChanged = true;
                _medicalSchoolCity = value;
            }
		}

		/// <summary>
		/// This Property represents the Sponsor which has nvarchar type
		/// </summary>
		private string _sponsor = "";
        [DataObjectField(false,false,true,50)]
		public string Sponsor
		{
            get 
            {
              return _sponsor;
            }
            set 
            {
                if (!RBMInitiatingEntity && _sponsor != value)
                     RBMDataChanged = true;
                _sponsor = value;
            }
		}

		/// <summary>
		/// This Property represents the CurrentPosition which has nvarchar type
		/// </summary>
		private string _currentPosition = "";
        [DataObjectField(false,false,true,150)]
		public string CurrentPosition
		{
            get 
            {
              return _currentPosition;
            }
            set 
            {
                if (!RBMInitiatingEntity && _currentPosition != value)
                     RBMDataChanged = true;
                _currentPosition = value;
            }
		}

		/// <summary>
		/// This Property represents the CurrentWorkPlace which has nvarchar type
		/// </summary>
		private string _currentWorkPlace = "";
        [DataObjectField(false,false,true,50)]
		public string CurrentWorkPlace
		{
            get 
            {
              return _currentWorkPlace;
            }
            set 
            {
                if (!RBMInitiatingEntity && _currentWorkPlace != value)
                     RBMDataChanged = true;
                _currentWorkPlace = value;
            }
		}

		/// <summary>
		/// This Property represents the Certificates which has nvarchar type
		/// </summary>
		private string _certificates = "";
        [DataObjectField(false,false,true,250)]
		public string Certificates
		{
            get 
            {
              return _certificates;
            }
            set 
            {
                if (!RBMInitiatingEntity && _certificates != value)
                     RBMDataChanged = true;
                _certificates = value;
            }
		}

		/// <summary>
		/// This Property represents the Photo which has nvarchar type
		/// </summary>
		private string _photo = "";
        [DataObjectField(false,false,true,250)]
		public string Photo
		{
            get 
            {
              return _photo;
            }
            set 
            {
                if (!RBMInitiatingEntity && _photo != value)
                     RBMDataChanged = true;
                _photo = value;
            }
		}

		/// <summary>
		/// This Property represents the ScannedDocument which has nvarchar type
		/// </summary>
		private string _scannedDocument = "";
        [DataObjectField(false,false,true,250)]
		public string ScannedDocument
		{
            get 
            {
              return _scannedDocument;
            }
            set 
            {
                if (!RBMInitiatingEntity && _scannedDocument != value)
                     RBMDataChanged = true;
                _scannedDocument = value;
            }
		}

		/// <summary>
		/// This Property represents the ScannedDocumentTitle which has nvarchar type
		/// </summary>
		private string _scannedDocumentTitle = "";
        [DataObjectField(false,false,true,250)]
		public string ScannedDocumentTitle
		{
            get 
            {
              return _scannedDocumentTitle;
            }
            set 
            {
                if (!RBMInitiatingEntity && _scannedDocumentTitle != value)
                     RBMDataChanged = true;
                _scannedDocumentTitle = value;
            }
		}

		/// <summary>
		/// This Property represents the ScannedDocumentTitle2 which has nvarchar type
		/// </summary>
		private string _scannedDocumentTitle2 = "";
        [DataObjectField(false,false,true,250)]
		public string ScannedDocumentTitle2
		{
            get 
            {
              return _scannedDocumentTitle2;
            }
            set 
            {
                if (!RBMInitiatingEntity && _scannedDocumentTitle2 != value)
                     RBMDataChanged = true;
                _scannedDocumentTitle2 = value;
            }
		}

		/// <summary>
		/// This Property represents the ScannedDocument2 which has nvarchar type
		/// </summary>
		private string _scannedDocument2 = "";
        [DataObjectField(false,false,true,250)]
		public string ScannedDocument2
		{
            get 
            {
              return _scannedDocument2;
            }
            set 
            {
                if (!RBMInitiatingEntity && _scannedDocument2 != value)
                     RBMDataChanged = true;
                _scannedDocument2 = value;
            }
		}

		/// <summary>
		/// This Property represents the ScannedDocumentTitle3 which has nvarchar type
		/// </summary>
		private string _scannedDocumentTitle3 = "";
        [DataObjectField(false,false,true,250)]
		public string ScannedDocumentTitle3
		{
            get 
            {
              return _scannedDocumentTitle3;
            }
            set 
            {
                if (!RBMInitiatingEntity && _scannedDocumentTitle3 != value)
                     RBMDataChanged = true;
                _scannedDocumentTitle3 = value;
            }
		}

		/// <summary>
		/// This Property represents the ScannedDocument3 which has nvarchar type
		/// </summary>
		private string _scannedDocument3 = "";
        [DataObjectField(false,false,true,250)]
		public string ScannedDocument3
		{
            get 
            {
              return _scannedDocument3;
            }
            set 
            {
                if (!RBMInitiatingEntity && _scannedDocument3 != value)
                     RBMDataChanged = true;
                _scannedDocument3 = value;
            }
		}

		/// <summary>
		/// This Property represents the ScannedDocumentTitle4 which has nvarchar type
		/// </summary>
		private string _scannedDocumentTitle4 = "";
        [DataObjectField(false,false,true,250)]
		public string ScannedDocumentTitle4
		{
            get 
            {
              return _scannedDocumentTitle4;
            }
            set 
            {
                if (!RBMInitiatingEntity && _scannedDocumentTitle4 != value)
                     RBMDataChanged = true;
                _scannedDocumentTitle4 = value;
            }
		}

		/// <summary>
		/// This Property represents the ScannedDocument4 which has nvarchar type
		/// </summary>
		private string _scannedDocument4 = "";
        [DataObjectField(false,false,true,250)]
		public string ScannedDocument4
		{
            get 
            {
              return _scannedDocument4;
            }
            set 
            {
                if (!RBMInitiatingEntity && _scannedDocument4 != value)
                     RBMDataChanged = true;
                _scannedDocument4 = value;
            }
		}

		/// <summary>
		/// This Property represents the ScannedDocumentTitle5 which has nvarchar type
		/// </summary>
		private string _scannedDocumentTitle5 = "";
        [DataObjectField(false,false,true,250)]
		public string ScannedDocumentTitle5
		{
            get 
            {
              return _scannedDocumentTitle5;
            }
            set 
            {
                if (!RBMInitiatingEntity && _scannedDocumentTitle5 != value)
                     RBMDataChanged = true;
                _scannedDocumentTitle5 = value;
            }
		}

		/// <summary>
		/// This Property represents the ScannedDocument5 which has nvarchar type
		/// </summary>
		private string _scannedDocument5 = "";
        [DataObjectField(false,false,true,250)]
		public string ScannedDocument5
		{
            get 
            {
              return _scannedDocument5;
            }
            set 
            {
                if (!RBMInitiatingEntity && _scannedDocument5 != value)
                     RBMDataChanged = true;
                _scannedDocument5 = value;
            }
		}

        private string _FullName;
        public string FullName
        {
            get
            {

                if (!string.IsNullOrEmpty(MiddleName))
                {
                    _FullName = String.Format("{0} {1} {2}", FirstName, MiddleName,FamilyName);
                }
                else
                    _FullName = String.Format("{0} {1}", FirstName, FamilyName);
                return _FullName;
            }
            set
            {
                _FullName = value;
            }
        }
	}
}
