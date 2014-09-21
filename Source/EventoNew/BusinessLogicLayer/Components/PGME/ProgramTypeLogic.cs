using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.PGME;
using BusinessLogicLayer.Entities.PGME;
namespace BusinessLogicLayer.Components.PGME
{
	/// <summary>
	/// This is a Business Logic Component Class  for ProgramType table
	/// This class RAPs the ProgramTypeDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class ProgramTypeLogic : BusinessLogic
	{
		public ProgramTypeLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<ProgramType> GetAll()
         {
             ProgramTypeDAC _programTypeComponent = new ProgramTypeDAC();
             IDataReader reader =  _programTypeComponent.GetAllProgramType().CreateDataReader();
             List<ProgramType> _programTypeList = new List<ProgramType>();
             while(reader.Read())
             {
             if(_programTypeList == null)
                 _programTypeList = new List<ProgramType>();
                 ProgramType _programType = new ProgramType();
                 if(reader["ProgramTypeId"] != DBNull.Value)
                     _programType.ProgramTypeId = Convert.ToInt32(reader["ProgramTypeId"]);
                 if(reader["ProgramTypeName"] != DBNull.Value)
                     _programType.ProgramTypeName = Convert.ToString(reader["ProgramTypeName"]);
             _programType.NewRecord = false;
             _programTypeList.Add(_programType);
             }             reader.Close();
             return _programTypeList;
         }

        #region Insert And Update
		public bool Insert(ProgramType programtype)
		{
			int autonumber = 0;
			ProgramTypeDAC programtypeComponent = new ProgramTypeDAC();
			bool endedSuccessfuly = programtypeComponent.InsertNewProgramType( ref autonumber,  programtype.ProgramTypeName);
			if(endedSuccessfuly)
			{
				programtype.ProgramTypeId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int ProgramTypeId,  string ProgramTypeName)
		{
			ProgramTypeDAC programtypeComponent = new ProgramTypeDAC();
			return programtypeComponent.InsertNewProgramType( ref ProgramTypeId,  ProgramTypeName);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( string ProgramTypeName)
		{
			ProgramTypeDAC programtypeComponent = new ProgramTypeDAC();
            int ProgramTypeId = 0;

			return programtypeComponent.InsertNewProgramType( ref ProgramTypeId,  ProgramTypeName);
		}
		public bool Update(ProgramType programtype ,int old_programTypeId)
		{
			ProgramTypeDAC programtypeComponent = new ProgramTypeDAC();
			return programtypeComponent.UpdateProgramType( programtype.ProgramTypeName,  old_programTypeId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( string ProgramTypeName,  int Original_ProgramTypeId)
		{
			ProgramTypeDAC programtypeComponent = new ProgramTypeDAC();
			return programtypeComponent.UpdateProgramType( ProgramTypeName,  Original_ProgramTypeId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_ProgramTypeId)
		{
			ProgramTypeDAC programtypeComponent = new ProgramTypeDAC();
			programtypeComponent.DeleteProgramType(Original_ProgramTypeId);
		}

        #endregion
         public ProgramType GetByID(int _programTypeId)
         {
             ProgramTypeDAC _programTypeComponent = new ProgramTypeDAC();
             IDataReader reader = _programTypeComponent.GetByIDProgramType(_programTypeId);
             ProgramType _programType = null;
             while(reader.Read())
             {
                 _programType = new ProgramType();
                 if(reader["ProgramTypeId"] != DBNull.Value)
                     _programType.ProgramTypeId = Convert.ToInt32(reader["ProgramTypeId"]);
                 if(reader["ProgramTypeName"] != DBNull.Value)
                     _programType.ProgramTypeName = Convert.ToString(reader["ProgramTypeName"]);
             _programType.NewRecord = false;             }             reader.Close();
             return _programType;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			ProgramTypeDAC programtypecomponent = new ProgramTypeDAC();
			return programtypecomponent.UpdateDataset(dataset);
		}



	}
}
