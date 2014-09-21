using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.BedManagement;
using BusinessLogicLayer.Entities.BedManagement;
namespace BusinessLogicLayer.Components.BedManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for AdmissionStayType table
	/// This class RAPs the AdmissionStayTypeDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class AdmissionStayTypeLogic : BusinessLogic
	{
		public AdmissionStayTypeLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<AdmissionStayType> GetAll()
         {
             AdmissionStayTypeDAC _admissionStayTypeComponent = new AdmissionStayTypeDAC();
             IDataReader reader =  _admissionStayTypeComponent.GetAllAdmissionStayType().CreateDataReader();
             List<AdmissionStayType> _admissionStayTypeList = new List<AdmissionStayType>();
             while(reader.Read())
             {
             if(_admissionStayTypeList == null)
                 _admissionStayTypeList = new List<AdmissionStayType>();
                 AdmissionStayType _admissionStayType = new AdmissionStayType();
                 if(reader["AdmissionStayTypeId"] != DBNull.Value)
                     _admissionStayType.AdmissionStayTypeId = Convert.ToInt32(reader["AdmissionStayTypeId"]);
                 if(reader["Name"] != DBNull.Value)
                     _admissionStayType.Name = Convert.ToString(reader["Name"]);
                 if(reader["Duration"] != DBNull.Value)
                     _admissionStayType.Duration = Convert.ToInt32(reader["Duration"]);
                 if(reader["Code"] != DBNull.Value)
                     _admissionStayType.Code = Convert.ToString(reader["Code"]);
                 if(reader["AdmissionStayOrder"] != DBNull.Value)
                     _admissionStayType.AdmissionStayOrder = Convert.ToInt32(reader["AdmissionStayOrder"]);
             _admissionStayType.NewRecord = false;
             _admissionStayTypeList.Add(_admissionStayType);
             }             reader.Close();
             return _admissionStayTypeList;
         }

        #region Insert And Update
		public bool Insert(AdmissionStayType admissionstaytype)
		{
			int autonumber = 0;
			AdmissionStayTypeDAC admissionstaytypeComponent = new AdmissionStayTypeDAC();
			bool endedSuccessfuly = admissionstaytypeComponent.InsertNewAdmissionStayType( ref autonumber,  admissionstaytype.Name,  admissionstaytype.Duration,  admissionstaytype.Code,  admissionstaytype.AdmissionStayOrder);
			if(endedSuccessfuly)
			{
				admissionstaytype.AdmissionStayTypeId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int AdmissionStayTypeId,  string Name,  int Duration,  string Code,  int AdmissionStayOrder)
		{
			AdmissionStayTypeDAC admissionstaytypeComponent = new AdmissionStayTypeDAC();
			return admissionstaytypeComponent.InsertNewAdmissionStayType( ref AdmissionStayTypeId,  Name,  Duration,  Code,  AdmissionStayOrder);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( string Name,  int Duration,  string Code,  int AdmissionStayOrder)
		{
			AdmissionStayTypeDAC admissionstaytypeComponent = new AdmissionStayTypeDAC();
            int AdmissionStayTypeId = 0;

			return admissionstaytypeComponent.InsertNewAdmissionStayType( ref AdmissionStayTypeId,  Name,  Duration,  Code,  AdmissionStayOrder);
		}
		public bool Update(AdmissionStayType admissionstaytype ,int old_admissionStayTypeId)
		{
			AdmissionStayTypeDAC admissionstaytypeComponent = new AdmissionStayTypeDAC();
			return admissionstaytypeComponent.UpdateAdmissionStayType( admissionstaytype.Name,  admissionstaytype.Duration,  admissionstaytype.Code,  admissionstaytype.AdmissionStayOrder,  old_admissionStayTypeId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( string Name,  int Duration,  string Code,  int AdmissionStayOrder,  int Original_AdmissionStayTypeId)
		{
			AdmissionStayTypeDAC admissionstaytypeComponent = new AdmissionStayTypeDAC();
			return admissionstaytypeComponent.UpdateAdmissionStayType( Name,  Duration,  Code,  AdmissionStayOrder,  Original_AdmissionStayTypeId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_AdmissionStayTypeId)
		{
			AdmissionStayTypeDAC admissionstaytypeComponent = new AdmissionStayTypeDAC();
			admissionstaytypeComponent.DeleteAdmissionStayType(Original_AdmissionStayTypeId);
		}

        #endregion
         public AdmissionStayType GetByID(int _admissionStayTypeId)
         {
             AdmissionStayTypeDAC _admissionStayTypeComponent = new AdmissionStayTypeDAC();
             IDataReader reader = _admissionStayTypeComponent.GetByIDAdmissionStayType(_admissionStayTypeId);
             AdmissionStayType _admissionStayType = null;
             while(reader.Read())
             {
                 _admissionStayType = new AdmissionStayType();
                 if(reader["AdmissionStayTypeId"] != DBNull.Value)
                     _admissionStayType.AdmissionStayTypeId = Convert.ToInt32(reader["AdmissionStayTypeId"]);
                 if(reader["Name"] != DBNull.Value)
                     _admissionStayType.Name = Convert.ToString(reader["Name"]);
                 if(reader["Duration"] != DBNull.Value)
                     _admissionStayType.Duration = Convert.ToInt32(reader["Duration"]);
                 if(reader["Code"] != DBNull.Value)
                     _admissionStayType.Code = Convert.ToString(reader["Code"]);
                 if(reader["AdmissionStayOrder"] != DBNull.Value)
                     _admissionStayType.AdmissionStayOrder = Convert.ToInt32(reader["AdmissionStayOrder"]);
             _admissionStayType.NewRecord = false;             }             reader.Close();
             return _admissionStayType;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			AdmissionStayTypeDAC admissionstaytypecomponent = new AdmissionStayTypeDAC();
			return admissionstaytypecomponent.UpdateDataset(dataset);
		}



	}
}
