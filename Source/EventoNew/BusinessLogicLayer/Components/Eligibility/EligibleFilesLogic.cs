using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.Eligibility;
using BusinessLogicLayer.Entities.Eligibility;
namespace BusinessLogicLayer.Components.Eligibility
{
	/// <summary>
	/// This is a Business Logic Component Class  for EligibleFiles table
	/// This class RAPs the EligibleFilesDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class EligibleFilesLogic : BusinessLogic
	{
		public EligibleFilesLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<EligibleFiles> GetAll()
         {
             EligibleFilesDAC _eligibleFilesComponent = new EligibleFilesDAC();
             IDataReader reader =  _eligibleFilesComponent.GetAllEligibleFiles().CreateDataReader();
             List<EligibleFiles> _eligibleFilesList = new List<EligibleFiles>();
             while(reader.Read())
             {
             if(_eligibleFilesList == null)
                 _eligibleFilesList = new List<EligibleFiles>();
                 EligibleFiles _eligibleFiles = new EligibleFiles();
                 if(reader["EligibleFileId"] != DBNull.Value)
                     _eligibleFiles.EligibleFileId = Convert.ToInt32(reader["EligibleFileId"]);
                 if(reader["EligibleId"] != DBNull.Value)
                     _eligibleFiles.EligibleId = Convert.ToInt32(reader["EligibleId"]);
                 if(reader["FileName"] != DBNull.Value)
                     _eligibleFiles.FileName = Convert.ToString(reader["FileName"]);
                 if(reader["FileDescription"] != DBNull.Value)
                     _eligibleFiles.FileDescription = Convert.ToString(reader["FileDescription"]);
                 if(reader["FilePath"] != DBNull.Value)
                     _eligibleFiles.FilePath = Convert.ToString(reader["FilePath"]);
             _eligibleFiles.NewRecord = false;
             _eligibleFilesList.Add(_eligibleFiles);
             }             reader.Close();
             return _eligibleFilesList;
         }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<EligibleFiles> GetAllByPatientId(int EligibleId)
        {
            EligibleFilesDAC _eligibleFilesComponent = new EligibleFilesDAC();
            IDataReader reader = _eligibleFilesComponent.GetAllEligibleFiles("EligibleId = " + EligibleId).CreateDataReader();
            List<EligibleFiles> _eligibleFilesList = new List<EligibleFiles>();
            while (reader.Read())
            {
                if (_eligibleFilesList == null)
                    _eligibleFilesList = new List<EligibleFiles>();
                EligibleFiles _eligibleFiles = new EligibleFiles();
                if (reader["EligibleFileId"] != DBNull.Value)
                    _eligibleFiles.EligibleFileId = Convert.ToInt32(reader["EligibleFileId"]);
                if (reader["EligibleId"] != DBNull.Value)
                    _eligibleFiles.EligibleId = Convert.ToInt32(reader["EligibleId"]);
                if (reader["FileName"] != DBNull.Value)
                    _eligibleFiles.FileName = Convert.ToString(reader["FileName"]);
                if (reader["FileDescription"] != DBNull.Value)
                    _eligibleFiles.FileDescription = Convert.ToString(reader["FileDescription"]);
                if (reader["FilePath"] != DBNull.Value)
                    _eligibleFiles.FilePath = Convert.ToString(reader["FilePath"]);
                _eligibleFiles.NewRecord = false;
                _eligibleFilesList.Add(_eligibleFiles);
            } reader.Close();
            return _eligibleFilesList;
        }

        #region Insert And Update
		public bool Insert(EligibleFiles eligiblefiles)
		{
			int autonumber = 0;
			EligibleFilesDAC eligiblefilesComponent = new EligibleFilesDAC();
			bool endedSuccessfuly = eligiblefilesComponent.InsertNewEligibleFiles( ref autonumber,  eligiblefiles.EligibleId,  eligiblefiles.FileName,  eligiblefiles.FileDescription,  eligiblefiles.FilePath);
			if(endedSuccessfuly)
			{
				eligiblefiles.EligibleFileId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int EligibleFileId,  int EligibleId,  string FileName,  string FileDescription,  string FilePath)
		{
			EligibleFilesDAC eligiblefilesComponent = new EligibleFilesDAC();
			return eligiblefilesComponent.InsertNewEligibleFiles( ref EligibleFileId,  EligibleId,  FileName,  FileDescription,  FilePath);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int EligibleId,  string FileName,  string FileDescription,  string FilePath)
		{
			EligibleFilesDAC eligiblefilesComponent = new EligibleFilesDAC();
            int EligibleFileId = 0;

			return eligiblefilesComponent.InsertNewEligibleFiles( ref EligibleFileId,  EligibleId,  FileName,  FileDescription,  FilePath);
		}
		public bool Update(EligibleFiles eligiblefiles ,int old_eligibleFileId)
		{
			EligibleFilesDAC eligiblefilesComponent = new EligibleFilesDAC();
			return eligiblefilesComponent.UpdateEligibleFiles( eligiblefiles.EligibleId,  eligiblefiles.FileName,  eligiblefiles.FileDescription,  eligiblefiles.FilePath,  old_eligibleFileId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int EligibleId,  string FileName,  string FileDescription,  string FilePath,  int Original_EligibleFileId)
		{
			EligibleFilesDAC eligiblefilesComponent = new EligibleFilesDAC();
			return eligiblefilesComponent.UpdateEligibleFiles( EligibleId,  FileName,  FileDescription,  FilePath,  Original_EligibleFileId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_EligibleFileId)
		{
			EligibleFilesDAC eligiblefilesComponent = new EligibleFilesDAC();
			eligiblefilesComponent.DeleteEligibleFiles(Original_EligibleFileId);
		}

        #endregion
         public EligibleFiles GetByID(int _eligibleFileId)
         {
             EligibleFilesDAC _eligibleFilesComponent = new EligibleFilesDAC();
             IDataReader reader = _eligibleFilesComponent.GetByIDEligibleFiles(_eligibleFileId);
             EligibleFiles _eligibleFiles = null;
             while(reader.Read())
             {
                 _eligibleFiles = new EligibleFiles();
                 if(reader["EligibleFileId"] != DBNull.Value)
                     _eligibleFiles.EligibleFileId = Convert.ToInt32(reader["EligibleFileId"]);
                 if(reader["EligibleId"] != DBNull.Value)
                     _eligibleFiles.EligibleId = Convert.ToInt32(reader["EligibleId"]);
                 if(reader["FileName"] != DBNull.Value)
                     _eligibleFiles.FileName = Convert.ToString(reader["FileName"]);
                 if(reader["FileDescription"] != DBNull.Value)
                     _eligibleFiles.FileDescription = Convert.ToString(reader["FileDescription"]);
                 if(reader["FilePath"] != DBNull.Value)
                     _eligibleFiles.FilePath = Convert.ToString(reader["FilePath"]);
             _eligibleFiles.NewRecord = false;             }             reader.Close();
             return _eligibleFiles;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			EligibleFilesDAC eligiblefilescomponent = new EligibleFilesDAC();
			return eligiblefilescomponent.UpdateDataset(dataset);
		}



	}
}
