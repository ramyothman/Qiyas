using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.Eligibility;
using BusinessLogicLayer.Entities.Eligibility;
namespace BusinessLogicLayer.Components.Eligibility
{
	/// <summary>
	/// This is a Business Logic Component Class  for Division table
	/// This class RAPs the DivisionDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class DivisionLogic : BusinessLogic
	{
		public DivisionLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<Division> GetAll()
         {
             DivisionDAC _divisionComponent = new DivisionDAC();
             IDataReader reader =  _divisionComponent.GetAllDivision().CreateDataReader();
             List<Division> _divisionList = new List<Division>();
             while(reader.Read())
             {
             if(_divisionList == null)
                 _divisionList = new List<Division>();
                 Division _division = new Division();
                 if(reader["DivisionID"] != DBNull.Value)
                     _division.DivisionID = Convert.ToInt32(reader["DivisionID"]);
                 if(reader["DepartmentID"] != DBNull.Value)
                     _division.DepartmentID = Convert.ToInt32(reader["DepartmentID"]);
                 if(reader["Name"] != DBNull.Value)
                     _division.Name = Convert.ToString(reader["Name"]);
                 if(reader["SiteUrl"] != DBNull.Value)
                     _division.SiteUrl = Convert.ToString(reader["SiteUrl"]);
             _division.NewRecord = false;
             _divisionList.Add(_division);
             }             reader.Close();
             return _divisionList;
         }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Division> GetAll(int DepartmentID)
        {
            DivisionDAC _divisionComponent = new DivisionDAC();
            IDataReader reader = _divisionComponent.GetAllDivision("DepartmentID = " + DepartmentID).CreateDataReader();
            List<Division> _divisionList = new List<Division>();
            while (reader.Read())
            {
                if (_divisionList == null)
                    _divisionList = new List<Division>();
                Division _division = new Division();
                if (reader["DivisionID"] != DBNull.Value)
                    _division.DivisionID = Convert.ToInt32(reader["DivisionID"]);
                if (reader["DepartmentID"] != DBNull.Value)
                    _division.DepartmentID = Convert.ToInt32(reader["DepartmentID"]);
                if (reader["Name"] != DBNull.Value)
                    _division.Name = Convert.ToString(reader["Name"]);
                if (reader["SiteUrl"] != DBNull.Value)
                    _division.SiteUrl = Convert.ToString(reader["SiteUrl"]);
                _division.NewRecord = false;
                _divisionList.Add(_division);
            } reader.Close();
            return _divisionList;
        }

        #region Insert And Update
		public bool Insert(Division division)
		{
			int autonumber = 0;
			DivisionDAC divisionComponent = new DivisionDAC();
			bool endedSuccessfuly = divisionComponent.InsertNewDivision( ref autonumber,  division.DepartmentID,  division.Name,  division.SiteUrl);
			if(endedSuccessfuly)
			{
				division.DivisionID = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int DivisionID,  int DepartmentID,  string Name,  string SiteUrl)
		{
			DivisionDAC divisionComponent = new DivisionDAC();
			return divisionComponent.InsertNewDivision( ref DivisionID,  DepartmentID,  Name,  SiteUrl);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int DepartmentID,  string Name,  string SiteUrl)
		{
			DivisionDAC divisionComponent = new DivisionDAC();
            int DivisionID = 0;

			return divisionComponent.InsertNewDivision( ref DivisionID,  DepartmentID,  Name,  SiteUrl);
		}
		public bool Update(Division division ,int old_divisionID)
		{
			DivisionDAC divisionComponent = new DivisionDAC();
			return divisionComponent.UpdateDivision( division.DepartmentID,  division.Name,  division.SiteUrl,  old_divisionID);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int DepartmentID,  string Name,  string SiteUrl,  int Original_DivisionID)
		{
			DivisionDAC divisionComponent = new DivisionDAC();
			return divisionComponent.UpdateDivision( DepartmentID,  Name,  SiteUrl,  Original_DivisionID);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_DivisionID)
		{
			DivisionDAC divisionComponent = new DivisionDAC();
			divisionComponent.DeleteDivision(Original_DivisionID);
		}

        #endregion
         public Division GetByID(int _divisionID)
         {
             DivisionDAC _divisionComponent = new DivisionDAC();
             IDataReader reader = _divisionComponent.GetByIDDivision(_divisionID);
             Division _division = null;
             while(reader.Read())
             {
                 _division = new Division();
                 if(reader["DivisionID"] != DBNull.Value)
                     _division.DivisionID = Convert.ToInt32(reader["DivisionID"]);
                 if(reader["DepartmentID"] != DBNull.Value)
                     _division.DepartmentID = Convert.ToInt32(reader["DepartmentID"]);
                 if(reader["Name"] != DBNull.Value)
                     _division.Name = Convert.ToString(reader["Name"]);
                 if(reader["SiteUrl"] != DBNull.Value)
                     _division.SiteUrl = Convert.ToString(reader["SiteUrl"]);
             _division.NewRecord = false;             }             reader.Close();
             return _division;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			DivisionDAC divisioncomponent = new DivisionDAC();
			return divisioncomponent.UpdateDataset(dataset);
		}



	}
}
