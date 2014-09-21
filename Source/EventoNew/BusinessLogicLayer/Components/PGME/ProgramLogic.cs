using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.PGME;
using BusinessLogicLayer.Entities.PGME;
namespace BusinessLogicLayer.Components.PGME
{
	/// <summary>
	/// This is a Business Logic Component Class  for Program table
	/// This class RAPs the ProgramDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class ProgramLogic : BusinessLogic
	{
		public ProgramLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<Program> GetAll()
         {
             ProgramDAC _programComponent = new ProgramDAC();
             IDataReader reader =  _programComponent.GetAllProgram().CreateDataReader();
             List<Program> _programList = new List<Program>();
             while(reader.Read())
             {
             if(_programList == null)
                 _programList = new List<Program>();
                 Program _program = new Program();
                 if(reader["ProgramId"] != DBNull.Value)
                     _program.ProgramId = Convert.ToInt32(reader["ProgramId"]);
                 if(reader["ProgramTypeId"] != DBNull.Value)
                     _program.ProgramTypeId = Convert.ToInt32(reader["ProgramTypeId"]);
                 if(reader["DepartmentId"] != DBNull.Value)
                     _program.DepartmentId = Convert.ToInt32(reader["DepartmentId"]);
                 if(reader["ProgramName"] != DBNull.Value)
                     _program.ProgramName = Convert.ToString(reader["ProgramName"]);
                 if(reader["ProgramDescription"] != DBNull.Value)
                     _program.ProgramDescription = Convert.ToString(reader["ProgramDescription"]);
             _program.NewRecord = false;
             _programList.Add(_program);
             }             reader.Close();
             return _programList;
         }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Program> GetAllByProgramTypeId(string ProgramTypeId)
        {
            ProgramDAC _programComponent = new ProgramDAC();
            IDataReader reader = _programComponent.GetAllProgram(" ProgramTypeId = " + ProgramTypeId).CreateDataReader();
            List<Program> _programList = new List<Program>();
            while (reader.Read())
            {
                if (_programList == null)
                    _programList = new List<Program>();
                Program _program = new Program();
                if (reader["ProgramId"] != DBNull.Value)
                    _program.ProgramId = Convert.ToInt32(reader["ProgramId"]);
                if (reader["ProgramTypeId"] != DBNull.Value)
                    _program.ProgramTypeId = Convert.ToInt32(reader["ProgramTypeId"]);
                if (reader["DepartmentId"] != DBNull.Value)
                    _program.DepartmentId = Convert.ToInt32(reader["DepartmentId"]);
                if (reader["ProgramName"] != DBNull.Value)
                    _program.ProgramName = Convert.ToString(reader["ProgramName"]);
                if (reader["ProgramDescription"] != DBNull.Value)
                    _program.ProgramDescription = Convert.ToString(reader["ProgramDescription"]);
                _program.NewRecord = false;
                _programList.Add(_program);
            } reader.Close();
            return _programList;
        }

        #region Insert And Update
		public bool Insert(Program program)
		{
			int autonumber = 0;
			ProgramDAC programComponent = new ProgramDAC();
			bool endedSuccessfuly = programComponent.InsertNewProgram( ref autonumber,  program.ProgramTypeId,  program.DepartmentId,  program.ProgramName,  program.ProgramDescription);
			if(endedSuccessfuly)
			{
				program.ProgramId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int ProgramId,  int ProgramTypeId,  int DepartmentId,  string ProgramName,  string ProgramDescription)
		{
			ProgramDAC programComponent = new ProgramDAC();
			return programComponent.InsertNewProgram( ref ProgramId,  ProgramTypeId,  DepartmentId,  ProgramName,  ProgramDescription);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int ProgramTypeId,  int DepartmentId,  string ProgramName,  string ProgramDescription)
		{
			ProgramDAC programComponent = new ProgramDAC();
            int ProgramId = 0;

			return programComponent.InsertNewProgram( ref ProgramId,  ProgramTypeId,  DepartmentId,  ProgramName,  ProgramDescription);
		}
		public bool Update(Program program ,int old_programId)
		{
			ProgramDAC programComponent = new ProgramDAC();
			return programComponent.UpdateProgram( program.ProgramTypeId,  program.DepartmentId,  program.ProgramName,  program.ProgramDescription,  old_programId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int ProgramTypeId,  int DepartmentId,  string ProgramName,  string ProgramDescription,  int Original_ProgramId)
		{
			ProgramDAC programComponent = new ProgramDAC();
			return programComponent.UpdateProgram( ProgramTypeId,  DepartmentId,  ProgramName,  ProgramDescription,  Original_ProgramId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_ProgramId)
		{
			ProgramDAC programComponent = new ProgramDAC();
			programComponent.DeleteProgram(Original_ProgramId);
		}

        #endregion
         public Program GetByID(int _programId)
         {
             ProgramDAC _programComponent = new ProgramDAC();
             IDataReader reader = _programComponent.GetByIDProgram(_programId);
             Program _program = null;
             while(reader.Read())
             {
                 _program = new Program();
                 if(reader["ProgramId"] != DBNull.Value)
                     _program.ProgramId = Convert.ToInt32(reader["ProgramId"]);
                 if(reader["ProgramTypeId"] != DBNull.Value)
                     _program.ProgramTypeId = Convert.ToInt32(reader["ProgramTypeId"]);
                 if(reader["DepartmentId"] != DBNull.Value)
                     _program.DepartmentId = Convert.ToInt32(reader["DepartmentId"]);
                 if(reader["ProgramName"] != DBNull.Value)
                     _program.ProgramName = Convert.ToString(reader["ProgramName"]);
                 if(reader["ProgramDescription"] != DBNull.Value)
                     _program.ProgramDescription = Convert.ToString(reader["ProgramDescription"]);
             _program.NewRecord = false;             }             reader.Close();
             return _program;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			ProgramDAC programcomponent = new ProgramDAC();
			return programcomponent.UpdateDataset(dataset);
		}



	}
}
