using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.Eligibility;
using BusinessLogicLayer.Entities.Eligibility;
namespace BusinessLogicLayer.Components.Eligibility
{
	/// <summary>
	/// This is a Business Logic Component Class  for EligibilityDepartment table
	/// This class RAPs the EligibilityDepartmentDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class EligibilityDepartmentLogic : BusinessLogic
	{
		public EligibilityDepartmentLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<EligibilityDepartment> GetAll()
         {
             EligibilityDepartmentDAC _eligibilityDepartmentComponent = new EligibilityDepartmentDAC();
             IDataReader reader =  _eligibilityDepartmentComponent.GetAllEligibilityDepartment().CreateDataReader();
             List<EligibilityDepartment> _eligibilityDepartmentList = new List<EligibilityDepartment>();
             while(reader.Read())
             {
             if(_eligibilityDepartmentList == null)
                 _eligibilityDepartmentList = new List<EligibilityDepartment>();
                 EligibilityDepartment _eligibilityDepartment = new EligibilityDepartment();
                 if(reader["EligibilityDepartmentId"] != DBNull.Value)
                     _eligibilityDepartment.EligibilityDepartmentId = Convert.ToInt32(reader["EligibilityDepartmentId"]);
                 if(reader["DepartmentName"] != DBNull.Value)
                     _eligibilityDepartment.DepartmentName = Convert.ToString(reader["DepartmentName"]);
             _eligibilityDepartment.NewRecord = false;
             _eligibilityDepartmentList.Add(_eligibilityDepartment);
             }             reader.Close();
             return _eligibilityDepartmentList;
         }

        #region Insert And Update
		public bool Insert(EligibilityDepartment eligibilitydepartment)
		{
			int autonumber = 0;
			EligibilityDepartmentDAC eligibilitydepartmentComponent = new EligibilityDepartmentDAC();
			bool endedSuccessfuly = eligibilitydepartmentComponent.InsertNewEligibilityDepartment( ref autonumber,  eligibilitydepartment.DepartmentName);
			if(endedSuccessfuly)
			{
				eligibilitydepartment.EligibilityDepartmentId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int EligibilityDepartmentId,  string DepartmentName)
		{
			EligibilityDepartmentDAC eligibilitydepartmentComponent = new EligibilityDepartmentDAC();
			return eligibilitydepartmentComponent.InsertNewEligibilityDepartment( ref EligibilityDepartmentId,  DepartmentName);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( string DepartmentName)
		{
			EligibilityDepartmentDAC eligibilitydepartmentComponent = new EligibilityDepartmentDAC();
            int EligibilityDepartmentId = 0;

			return eligibilitydepartmentComponent.InsertNewEligibilityDepartment( ref EligibilityDepartmentId,  DepartmentName);
		}
		public bool Update(EligibilityDepartment eligibilitydepartment ,int old_eligibilityDepartmentId)
		{
			EligibilityDepartmentDAC eligibilitydepartmentComponent = new EligibilityDepartmentDAC();
			return eligibilitydepartmentComponent.UpdateEligibilityDepartment( eligibilitydepartment.DepartmentName,  old_eligibilityDepartmentId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( string DepartmentName,  int Original_EligibilityDepartmentId)
		{
			EligibilityDepartmentDAC eligibilitydepartmentComponent = new EligibilityDepartmentDAC();
			return eligibilitydepartmentComponent.UpdateEligibilityDepartment( DepartmentName,  Original_EligibilityDepartmentId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_EligibilityDepartmentId)
		{
			EligibilityDepartmentDAC eligibilitydepartmentComponent = new EligibilityDepartmentDAC();
			eligibilitydepartmentComponent.DeleteEligibilityDepartment(Original_EligibilityDepartmentId);
		}

        #endregion
         public EligibilityDepartment GetByID(int _eligibilityDepartmentId)
         {
             EligibilityDepartmentDAC _eligibilityDepartmentComponent = new EligibilityDepartmentDAC();
             IDataReader reader = _eligibilityDepartmentComponent.GetByIDEligibilityDepartment(_eligibilityDepartmentId);
             EligibilityDepartment _eligibilityDepartment = null;
             while(reader.Read())
             {
                 _eligibilityDepartment = new EligibilityDepartment();
                 if(reader["EligibilityDepartmentId"] != DBNull.Value)
                     _eligibilityDepartment.EligibilityDepartmentId = Convert.ToInt32(reader["EligibilityDepartmentId"]);
                 if(reader["DepartmentName"] != DBNull.Value)
                     _eligibilityDepartment.DepartmentName = Convert.ToString(reader["DepartmentName"]);
             _eligibilityDepartment.NewRecord = false;             }             reader.Close();
             return _eligibilityDepartment;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			EligibilityDepartmentDAC eligibilitydepartmentcomponent = new EligibilityDepartmentDAC();
			return eligibilitydepartmentcomponent.UpdateDataset(dataset);
		}



	}
}
