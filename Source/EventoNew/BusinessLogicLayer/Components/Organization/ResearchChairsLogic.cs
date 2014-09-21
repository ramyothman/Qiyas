using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.Organization;
using BusinessLogicLayer.Entities.Organization;
namespace BusinessLogicLayer.Components.Organization
{
	/// <summary>
	/// This is a Business Logic Component Class  for ResearchChairs table
	/// This class RAPs the ResearchChairsDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class ResearchChairsLogic : BusinessLogic
	{
		public ResearchChairsLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<ResearchChairs> GetAll()
         {
             ResearchChairsDAC _researchChairsComponent = new ResearchChairsDAC();
             IDataReader reader =  _researchChairsComponent.GetAllResearchChairs().CreateDataReader();
             List<ResearchChairs> _researchChairsList = new List<ResearchChairs>();
             while(reader.Read())
             {
             if(_researchChairsList == null)
                 _researchChairsList = new List<ResearchChairs>();
                 ResearchChairs _researchChairs = new ResearchChairs();
                 if(reader["ResearchChairId"] != DBNull.Value)
                     _researchChairs.ResearchChairId = Convert.ToInt32(reader["ResearchChairId"]);
                 if(reader["Name"] != DBNull.Value)
                     _researchChairs.Name = Convert.ToString(reader["Name"]);
                 if(reader["Description"] != DBNull.Value)
                     _researchChairs.Description = Convert.ToString(reader["Description"]);
                 if(reader["Phone1"] != DBNull.Value)
                     _researchChairs.Phone1 = Convert.ToString(reader["Phone1"]);
                 if(reader["Phone2"] != DBNull.Value)
                     _researchChairs.Phone2 = Convert.ToString(reader["Phone2"]);
                 if(reader["Fax1"] != DBNull.Value)
                     _researchChairs.Fax1 = Convert.ToString(reader["Fax1"]);
                 if(reader["Fax2"] != DBNull.Value)
                     _researchChairs.Fax2 = Convert.ToString(reader["Fax2"]);
             _researchChairs.NewRecord = false;
             _researchChairsList.Add(_researchChairs);
             }             reader.Close();
             return _researchChairsList;
         }

        #region Insert And Update
		public bool Insert(ResearchChairs researchchairs)
		{
			int autonumber = 0;
			ResearchChairsDAC researchchairsComponent = new ResearchChairsDAC();
			bool endedSuccessfuly = researchchairsComponent.InsertNewResearchChairs( ref autonumber,  researchchairs.Name,  researchchairs.Description,  researchchairs.Phone1,  researchchairs.Phone2,  researchchairs.Fax1,  researchchairs.Fax2);
			if(endedSuccessfuly)
			{
				researchchairs.ResearchChairId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int ResearchChairId,  string Name,  string Description,  string Phone1,  string Phone2,  string Fax1,  string Fax2)
		{
			ResearchChairsDAC researchchairsComponent = new ResearchChairsDAC();
			return researchchairsComponent.InsertNewResearchChairs( ref ResearchChairId,  Name,  Description,  Phone1,  Phone2,  Fax1,  Fax2);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( string Name,  string Description,  string Phone1,  string Phone2,  string Fax1,  string Fax2)
		{
			ResearchChairsDAC researchchairsComponent = new ResearchChairsDAC();
            int ResearchChairId = 0;

			return researchchairsComponent.InsertNewResearchChairs( ref ResearchChairId,  Name,  Description,  Phone1,  Phone2,  Fax1,  Fax2);
		}
		public bool Update(ResearchChairs researchchairs ,int old_researchChairId)
		{
			ResearchChairsDAC researchchairsComponent = new ResearchChairsDAC();
			return researchchairsComponent.UpdateResearchChairs( researchchairs.Name,  researchchairs.Description,  researchchairs.Phone1,  researchchairs.Phone2,  researchchairs.Fax1,  researchchairs.Fax2,  old_researchChairId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( string Name,  string Description,  string Phone1,  string Phone2,  string Fax1,  string Fax2,  int Original_ResearchChairId)
		{
			ResearchChairsDAC researchchairsComponent = new ResearchChairsDAC();
			return researchchairsComponent.UpdateResearchChairs( Name,  Description,  Phone1,  Phone2,  Fax1,  Fax2,  Original_ResearchChairId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_ResearchChairId)
		{
			ResearchChairsDAC researchchairsComponent = new ResearchChairsDAC();
			researchchairsComponent.DeleteResearchChairs(Original_ResearchChairId);
		}

        #endregion
         public ResearchChairs GetByID(int _researchChairId)
         {
             ResearchChairsDAC _researchChairsComponent = new ResearchChairsDAC();
             IDataReader reader = _researchChairsComponent.GetByIDResearchChairs(_researchChairId);
             ResearchChairs _researchChairs = null;
             while(reader.Read())
             {
                 _researchChairs = new ResearchChairs();
                 if(reader["ResearchChairId"] != DBNull.Value)
                     _researchChairs.ResearchChairId = Convert.ToInt32(reader["ResearchChairId"]);
                 if(reader["Name"] != DBNull.Value)
                     _researchChairs.Name = Convert.ToString(reader["Name"]);
                 if(reader["Description"] != DBNull.Value)
                     _researchChairs.Description = Convert.ToString(reader["Description"]);
                 if(reader["Phone1"] != DBNull.Value)
                     _researchChairs.Phone1 = Convert.ToString(reader["Phone1"]);
                 if(reader["Phone2"] != DBNull.Value)
                     _researchChairs.Phone2 = Convert.ToString(reader["Phone2"]);
                 if(reader["Fax1"] != DBNull.Value)
                     _researchChairs.Fax1 = Convert.ToString(reader["Fax1"]);
                 if(reader["Fax2"] != DBNull.Value)
                     _researchChairs.Fax2 = Convert.ToString(reader["Fax2"]);
             _researchChairs.NewRecord = false;             }             reader.Close();
             return _researchChairs;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			ResearchChairsDAC researchchairscomponent = new ResearchChairsDAC();
			return researchchairscomponent.UpdateDataset(dataset);
		}



	}
}
