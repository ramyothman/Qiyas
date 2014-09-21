using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.BedManagement;
using BusinessLogicLayer.Entities.BedManagement;
namespace BusinessLogicLayer.Components.BedManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for DischargeType table
	/// This class RAPs the DischargeTypeDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class DischargeTypeLogic : BusinessLogic
	{
		public DischargeTypeLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<DischargeType> GetAll()
         {
             DischargeTypeDAC _dischargeTypeComponent = new DischargeTypeDAC();
             IDataReader reader =  _dischargeTypeComponent.GetAllDischargeType().CreateDataReader();
             List<DischargeType> _dischargeTypeList = new List<DischargeType>();
             while(reader.Read())
             {
             if(_dischargeTypeList == null)
                 _dischargeTypeList = new List<DischargeType>();
                 DischargeType _dischargeType = new DischargeType();
                 if(reader["DischargeTypeId"] != DBNull.Value)
                     _dischargeType.DischargeTypeId = Convert.ToInt32(reader["DischargeTypeId"]);
                 if(reader["Name"] != DBNull.Value)
                     _dischargeType.Name = Convert.ToString(reader["Name"]);
                 if(reader["DischargeCode"] != DBNull.Value)
                     _dischargeType.DischargeCode = Convert.ToString(reader["DischargeCode"]);
                 if(reader["DischargeOrder"] != DBNull.Value)
                     _dischargeType.DischargeOrder = Convert.ToInt32(reader["DischargeOrder"]);
             _dischargeType.NewRecord = false;
             _dischargeTypeList.Add(_dischargeType);
             }             reader.Close();
             return _dischargeTypeList;
         }

        #region Insert And Update
		public bool Insert(DischargeType dischargetype)
		{
			int autonumber = 0;
			DischargeTypeDAC dischargetypeComponent = new DischargeTypeDAC();
			bool endedSuccessfuly = dischargetypeComponent.InsertNewDischargeType( ref autonumber,  dischargetype.Name,  dischargetype.DischargeCode,  dischargetype.DischargeOrder);
			if(endedSuccessfuly)
			{
				dischargetype.DischargeTypeId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int DischargeTypeId,  string Name,  string DischargeCode,  int DischargeOrder)
		{
			DischargeTypeDAC dischargetypeComponent = new DischargeTypeDAC();
			return dischargetypeComponent.InsertNewDischargeType( ref DischargeTypeId,  Name,  DischargeCode,  DischargeOrder);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( string Name,  string DischargeCode,  int DischargeOrder)
		{
			DischargeTypeDAC dischargetypeComponent = new DischargeTypeDAC();
            int DischargeTypeId = 0;

			return dischargetypeComponent.InsertNewDischargeType( ref DischargeTypeId,  Name,  DischargeCode,  DischargeOrder);
		}
		public bool Update(DischargeType dischargetype ,int old_dischargeTypeId)
		{
			DischargeTypeDAC dischargetypeComponent = new DischargeTypeDAC();
			return dischargetypeComponent.UpdateDischargeType( dischargetype.Name,  dischargetype.DischargeCode,  dischargetype.DischargeOrder,  old_dischargeTypeId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( string Name,  string DischargeCode,  int DischargeOrder,  int Original_DischargeTypeId)
		{
			DischargeTypeDAC dischargetypeComponent = new DischargeTypeDAC();
			return dischargetypeComponent.UpdateDischargeType( Name,  DischargeCode,  DischargeOrder,  Original_DischargeTypeId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_DischargeTypeId)
		{
			DischargeTypeDAC dischargetypeComponent = new DischargeTypeDAC();
			dischargetypeComponent.DeleteDischargeType(Original_DischargeTypeId);
		}

        #endregion
         public DischargeType GetByID(int _dischargeTypeId)
         {
             DischargeTypeDAC _dischargeTypeComponent = new DischargeTypeDAC();
             IDataReader reader = _dischargeTypeComponent.GetByIDDischargeType(_dischargeTypeId);
             DischargeType _dischargeType = null;
             while(reader.Read())
             {
                 _dischargeType = new DischargeType();
                 if(reader["DischargeTypeId"] != DBNull.Value)
                     _dischargeType.DischargeTypeId = Convert.ToInt32(reader["DischargeTypeId"]);
                 if(reader["Name"] != DBNull.Value)
                     _dischargeType.Name = Convert.ToString(reader["Name"]);
                 if(reader["DischargeCode"] != DBNull.Value)
                     _dischargeType.DischargeCode = Convert.ToString(reader["DischargeCode"]);
                 if(reader["DischargeOrder"] != DBNull.Value)
                     _dischargeType.DischargeOrder = Convert.ToInt32(reader["DischargeOrder"]);
             _dischargeType.NewRecord = false;             }             reader.Close();
             return _dischargeType;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			DischargeTypeDAC dischargetypecomponent = new DischargeTypeDAC();
			return dischargetypecomponent.UpdateDataset(dataset);
		}



	}
}
