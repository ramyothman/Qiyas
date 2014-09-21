using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.Eligibility;
using BusinessLogicLayer.Entities.Eligibility;
namespace BusinessLogicLayer.Components.Eligibility
{
	/// <summary>
	/// This is a Business Logic Component Class  for Hospital table
	/// This class RAPs the HospitalDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class HospitalLogic : BusinessLogic
	{
		public HospitalLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<Hospital> GetAll()
         {
             HospitalDAC _hospitalComponent = new HospitalDAC();
             IDataReader reader =  _hospitalComponent.GetAllHospital().CreateDataReader();
             List<Hospital> _hospitalList = new List<Hospital>();
             while(reader.Read())
             {
             if(_hospitalList == null)
                 _hospitalList = new List<Hospital>();
                 Hospital _hospital = new Hospital();
                 if(reader["EligibilityHospitalID"] != DBNull.Value)
                     _hospital.EligibilityHospitalID = Convert.ToInt32(reader["EligibilityHospitalID"]);
                 if(reader["HospitalName"] != DBNull.Value)
                     _hospital.HospitalName = Convert.ToString(reader["HospitalName"]);
                 if(reader["Phone"] != DBNull.Value)
                     _hospital.Phone = Convert.ToString(reader["Phone"]);
                 if(reader["Fax"] != DBNull.Value)
                     _hospital.Fax = Convert.ToString(reader["Fax"]);
                 if(reader["Email"] != DBNull.Value)
                     _hospital.Email = Convert.ToString(reader["Email"]);
                 if(reader["SiteURL"] != DBNull.Value)
                     _hospital.SiteURL = Convert.ToString(reader["SiteURL"]);
                 if(reader["UserID"] != DBNull.Value)
                     _hospital.UserID = Convert.ToInt32(reader["UserID"]);
             _hospital.NewRecord = false;
             _hospitalList.Add(_hospital);
             }             reader.Close();
             return _hospitalList;
         }

        #region Insert And Update
		public bool Insert(Hospital hospital)
		{
			int autonumber = 0;
			HospitalDAC hospitalComponent = new HospitalDAC();
			bool endedSuccessfuly = hospitalComponent.InsertNewHospital( ref autonumber,  hospital.HospitalName,  hospital.Phone,  hospital.Fax,  hospital.Email,  hospital.SiteURL,  hospital.UserID);
			if(endedSuccessfuly)
			{
				hospital.EligibilityHospitalID = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int EligibilityHospitalID,  string HospitalName,  string Phone,  string Fax,  string Email,  string SiteURL,  int UserID)
		{
			HospitalDAC hospitalComponent = new HospitalDAC();
			return hospitalComponent.InsertNewHospital( ref EligibilityHospitalID,  HospitalName,  Phone,  Fax,  Email,  SiteURL,  UserID);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( string HospitalName,  string Phone,  string Fax,  string Email,  string SiteURL,  int UserID)
		{
			HospitalDAC hospitalComponent = new HospitalDAC();
            int EligibilityHospitalID = 0;

			return hospitalComponent.InsertNewHospital( ref EligibilityHospitalID,  HospitalName,  Phone,  Fax,  Email,  SiteURL,  UserID);
		}
		public bool Update(Hospital hospital ,int old_eligibilityHospitalID)
		{
			HospitalDAC hospitalComponent = new HospitalDAC();
			return hospitalComponent.UpdateHospital( hospital.HospitalName,  hospital.Phone,  hospital.Fax,  hospital.Email,  hospital.SiteURL,  hospital.UserID,  old_eligibilityHospitalID);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( string HospitalName,  string Phone,  string Fax,  string Email,  string SiteURL,  int UserID,  int Original_EligibilityHospitalID)
		{
			HospitalDAC hospitalComponent = new HospitalDAC();
			return hospitalComponent.UpdateHospital( HospitalName,  Phone,  Fax,  Email,  SiteURL,  UserID,  Original_EligibilityHospitalID);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_EligibilityHospitalID)
		{
			HospitalDAC hospitalComponent = new HospitalDAC();
			hospitalComponent.DeleteHospital(Original_EligibilityHospitalID);
		}

        #endregion
         public Hospital GetByID(int _eligibilityHospitalID)
         {
             HospitalDAC _hospitalComponent = new HospitalDAC();
             IDataReader reader = _hospitalComponent.GetByIDHospital(_eligibilityHospitalID);
             Hospital _hospital = null;
             while(reader.Read())
             {
                 _hospital = new Hospital();
                 if(reader["EligibilityHospitalID"] != DBNull.Value)
                     _hospital.EligibilityHospitalID = Convert.ToInt32(reader["EligibilityHospitalID"]);
                 if(reader["HospitalName"] != DBNull.Value)
                     _hospital.HospitalName = Convert.ToString(reader["HospitalName"]);
                 if(reader["Phone"] != DBNull.Value)
                     _hospital.Phone = Convert.ToString(reader["Phone"]);
                 if(reader["Fax"] != DBNull.Value)
                     _hospital.Fax = Convert.ToString(reader["Fax"]);
                 if(reader["Email"] != DBNull.Value)
                     _hospital.Email = Convert.ToString(reader["Email"]);
                 if(reader["SiteURL"] != DBNull.Value)
                     _hospital.SiteURL = Convert.ToString(reader["SiteURL"]);
                 if(reader["UserID"] != DBNull.Value)
                     _hospital.UserID = Convert.ToInt32(reader["UserID"]);
             _hospital.NewRecord = false;             }             reader.Close();
             return _hospital;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			HospitalDAC hospitalcomponent = new HospitalDAC();
			return hospitalcomponent.UpdateDataset(dataset);
		}



	}
}
