using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.BedManagement;
using BusinessLogicLayer.Entities.BedManagement;
namespace BusinessLogicLayer.Components.BedManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for Consultant table
	/// This class RAPs the ConsultantDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class ConsultantLogic : BusinessLogic
	{
		public ConsultantLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<Consultant> GetAll()
         {
             ConsultantDAC _consultantComponent = new ConsultantDAC();
             IDataReader reader =  _consultantComponent.GetAllConsultant().CreateDataReader();
             List<Consultant> _consultantList = new List<Consultant>();
             while(reader.Read())
             {
             if(_consultantList == null)
                 _consultantList = new List<Consultant>();
                 Consultant _consultant = new Consultant();
                 if(reader["ConsultantId"] != DBNull.Value)
                     _consultant.ConsultantId = Convert.ToInt32(reader["ConsultantId"]);
                 if(reader["ConsultantCode"] != DBNull.Value)
                     _consultant.ConsultantCode = Convert.ToString(reader["ConsultantCode"]);
             _consultant.NewRecord = false;
             _consultantList.Add(_consultant);
             }             reader.Close();
             return _consultantList;
         }

        #region Insert And Update
		public bool Insert(Consultant consultant)
		{
			ConsultantDAC consultantComponent = new ConsultantDAC();
			return consultantComponent.InsertNewConsultant( consultant.ConsultantId,  consultant.ConsultantCode);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int ConsultantId,  string ConsultantCode)
		{
			ConsultantDAC consultantComponent = new ConsultantDAC();
			return consultantComponent.InsertNewConsultant( ConsultantId,  ConsultantCode);
		}
		public bool Update(Consultant consultant ,int old_consultantId)
		{
			ConsultantDAC consultantComponent = new ConsultantDAC();
			return consultantComponent.UpdateConsultant( consultant.ConsultantId,  consultant.ConsultantCode,  old_consultantId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int ConsultantId,  string ConsultantCode,  int Original_ConsultantId)
		{
			ConsultantDAC consultantComponent = new ConsultantDAC();
			return consultantComponent.UpdateConsultant( ConsultantId,  ConsultantCode,  Original_ConsultantId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_ConsultantId)
		{
			ConsultantDAC consultantComponent = new ConsultantDAC();
			consultantComponent.DeleteConsultant(Original_ConsultantId);
		}

        #endregion
         public Consultant GetByID(int _consultantId)
         {
             ConsultantDAC _consultantComponent = new ConsultantDAC();
             IDataReader reader = _consultantComponent.GetByIDConsultant(_consultantId);
             Consultant _consultant = null;
             while(reader.Read())
             {
                 _consultant = new Consultant();
                 if(reader["ConsultantId"] != DBNull.Value)
                     _consultant.ConsultantId = Convert.ToInt32(reader["ConsultantId"]);
                 if(reader["ConsultantCode"] != DBNull.Value)
                     _consultant.ConsultantCode = Convert.ToString(reader["ConsultantCode"]);
             _consultant.NewRecord = false;             }             reader.Close();
             return _consultant;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			ConsultantDAC consultantcomponent = new ConsultantDAC();
			return consultantcomponent.UpdateDataset(dataset);
		}



	}
}
