using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.Organization;
using BusinessLogicLayer.Entities.Organization;
namespace BusinessLogicLayer.Components.Organization
{
	/// <summary>
	/// This is a Business Logic Component Class  for ResearchChairLanguages table
	/// This class RAPs the ResearchChairLanguagesDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class ResearchChairLanguagesLogic : BusinessLogic
	{
		public ResearchChairLanguagesLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<ResearchChairLanguages> GetAll()
         {
             ResearchChairLanguagesDAC _researchChairLanguagesComponent = new ResearchChairLanguagesDAC();
             IDataReader reader =  _researchChairLanguagesComponent.GetAllResearchChairLanguages().CreateDataReader();
             List<ResearchChairLanguages> _researchChairLanguagesList = new List<ResearchChairLanguages>();
             while(reader.Read())
             {
             if(_researchChairLanguagesList == null)
                 _researchChairLanguagesList = new List<ResearchChairLanguages>();
                 ResearchChairLanguages _researchChairLanguages = new ResearchChairLanguages();
                 if(reader["ResearchChairLanguagesId"] != DBNull.Value)
                     _researchChairLanguages.ResearchChairLanguagesId = Convert.ToInt32(reader["ResearchChairLanguagesId"]);
                 if(reader["ResearchChairId"] != DBNull.Value)
                     _researchChairLanguages.ResearchChairId = Convert.ToInt32(reader["ResearchChairId"]);
                 if(reader["LanguageId"] != DBNull.Value)
                     _researchChairLanguages.LanguageId = Convert.ToInt32(reader["LanguageId"]);
                 if(reader["Name"] != DBNull.Value)
                     _researchChairLanguages.Name = Convert.ToString(reader["Name"]);
                 if(reader["Description"] != DBNull.Value)
                     _researchChairLanguages.Description = Convert.ToString(reader["Description"]);
             _researchChairLanguages.NewRecord = false;
             _researchChairLanguagesList.Add(_researchChairLanguages);
             }             reader.Close();
             return _researchChairLanguagesList;
         }

        #region Insert And Update
		public bool Insert(ResearchChairLanguages researchchairlanguages)
		{
			int autonumber = 0;
			ResearchChairLanguagesDAC researchchairlanguagesComponent = new ResearchChairLanguagesDAC();
			bool endedSuccessfuly = researchchairlanguagesComponent.InsertNewResearchChairLanguages( ref autonumber,  researchchairlanguages.ResearchChairId,  researchchairlanguages.LanguageId,  researchchairlanguages.Name,  researchchairlanguages.Description);
			if(endedSuccessfuly)
			{
				researchchairlanguages.ResearchChairLanguagesId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int ResearchChairLanguagesId,  int ResearchChairId,  int LanguageId,  string Name,  string Description)
		{
			ResearchChairLanguagesDAC researchchairlanguagesComponent = new ResearchChairLanguagesDAC();
			return researchchairlanguagesComponent.InsertNewResearchChairLanguages( ref ResearchChairLanguagesId,  ResearchChairId,  LanguageId,  Name,  Description);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int ResearchChairId,  int LanguageId,  string Name,  string Description)
		{
			ResearchChairLanguagesDAC researchchairlanguagesComponent = new ResearchChairLanguagesDAC();
            int ResearchChairLanguagesId = 0;

			return researchchairlanguagesComponent.InsertNewResearchChairLanguages( ref ResearchChairLanguagesId,  ResearchChairId,  LanguageId,  Name,  Description);
		}
		public bool Update(ResearchChairLanguages researchchairlanguages ,int old_researchChairLanguagesId)
		{
			ResearchChairLanguagesDAC researchchairlanguagesComponent = new ResearchChairLanguagesDAC();
			return researchchairlanguagesComponent.UpdateResearchChairLanguages( researchchairlanguages.ResearchChairId,  researchchairlanguages.LanguageId,  researchchairlanguages.Name,  researchchairlanguages.Description,  old_researchChairLanguagesId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int ResearchChairId,  int LanguageId,  string Name,  string Description,  int Original_ResearchChairLanguagesId)
		{
			ResearchChairLanguagesDAC researchchairlanguagesComponent = new ResearchChairLanguagesDAC();
			return researchchairlanguagesComponent.UpdateResearchChairLanguages( ResearchChairId,  LanguageId,  Name,  Description,  Original_ResearchChairLanguagesId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_ResearchChairLanguagesId)
		{
			ResearchChairLanguagesDAC researchchairlanguagesComponent = new ResearchChairLanguagesDAC();
			researchchairlanguagesComponent.DeleteResearchChairLanguages(Original_ResearchChairLanguagesId);
		}

        #endregion
         public ResearchChairLanguages GetByID(int _researchChairLanguagesId)
         {
             ResearchChairLanguagesDAC _researchChairLanguagesComponent = new ResearchChairLanguagesDAC();
             IDataReader reader = _researchChairLanguagesComponent.GetByIDResearchChairLanguages(_researchChairLanguagesId);
             ResearchChairLanguages _researchChairLanguages = null;
             while(reader.Read())
             {
                 _researchChairLanguages = new ResearchChairLanguages();
                 if(reader["ResearchChairLanguagesId"] != DBNull.Value)
                     _researchChairLanguages.ResearchChairLanguagesId = Convert.ToInt32(reader["ResearchChairLanguagesId"]);
                 if(reader["ResearchChairId"] != DBNull.Value)
                     _researchChairLanguages.ResearchChairId = Convert.ToInt32(reader["ResearchChairId"]);
                 if(reader["LanguageId"] != DBNull.Value)
                     _researchChairLanguages.LanguageId = Convert.ToInt32(reader["LanguageId"]);
                 if(reader["Name"] != DBNull.Value)
                     _researchChairLanguages.Name = Convert.ToString(reader["Name"]);
                 if(reader["Description"] != DBNull.Value)
                     _researchChairLanguages.Description = Convert.ToString(reader["Description"]);
             _researchChairLanguages.NewRecord = false;             }             reader.Close();
             return _researchChairLanguages;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			ResearchChairLanguagesDAC researchchairlanguagescomponent = new ResearchChairLanguagesDAC();
			return researchchairlanguagescomponent.UpdateDataset(dataset);
		}



	}
}
