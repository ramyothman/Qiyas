using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.HISBedManagement;
using BusinessLogicLayer.Entities.HISBedManagement;
namespace BusinessLogicLayer.Components.HISBedManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for WardFor table
	/// This class RAPs the WardForDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class WardForLogic : BusinessLogic
	{
		public WardForLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<WardFor> GetAll()
         {
             WardForDAC _wardForComponent = new WardForDAC();
             IDataReader reader =  _wardForComponent.GetAllWardFor().CreateDataReader();
             List<WardFor> _wardForList = new List<WardFor>();
             while(reader.Read())
             {
             if(_wardForList == null)
                 _wardForList = new List<WardFor>();
                 WardFor _wardFor = new WardFor();
                 if(reader["WardForId"] != DBNull.Value)
                     _wardFor.WardForId = Convert.ToInt32(reader["WardForId"]);
                 if(reader["WardForName"] != DBNull.Value)
                     _wardFor.WardForName = Convert.ToString(reader["WardForName"]);
             _wardFor.NewRecord = false;
             _wardForList.Add(_wardFor);
             }             reader.Close();
             return _wardForList;
         }

        #region Insert And Update
		public bool Insert(WardFor wardfor)
		{
			int autonumber = 0;
			WardForDAC wardforComponent = new WardForDAC();
			bool endedSuccessfuly = wardforComponent.InsertNewWardFor( ref autonumber,  wardfor.WardForName);
			if(endedSuccessfuly)
			{
				wardfor.WardForId = autonumber;
			}
			return endedSuccessfuly;
		}
		public bool Insert( ref int WardForId,  string WardForName)
		{
			WardForDAC wardforComponent = new WardForDAC();
			return wardforComponent.InsertNewWardFor( ref WardForId,  WardForName);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( string WardForName)
		{
			WardForDAC wardforComponent = new WardForDAC();
            int WardForId = 0;

			return wardforComponent.InsertNewWardFor( ref WardForId,  WardForName);
		}
		public bool Update(WardFor wardfor ,int old_wardForId)
		{
			WardForDAC wardforComponent = new WardForDAC();
			return wardforComponent.UpdateWardFor( wardfor.WardForName,  old_wardForId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( string WardForName,  int Original_WardForId)
		{
			WardForDAC wardforComponent = new WardForDAC();
			return wardforComponent.UpdateWardFor( WardForName,  Original_WardForId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_WardForId)
		{
			WardForDAC wardforComponent = new WardForDAC();
			wardforComponent.DeleteWardFor(Original_WardForId);
		}

        #endregion
         public WardFor GetByID(int _wardForId)
         {
             WardForDAC _wardForComponent = new WardForDAC();
             IDataReader reader = _wardForComponent.GetByIDWardFor(_wardForId);
             WardFor _wardFor = null;
             while(reader.Read())
             {
                 _wardFor = new WardFor();
                 if(reader["WardForId"] != DBNull.Value)
                     _wardFor.WardForId = Convert.ToInt32(reader["WardForId"]);
                 if(reader["WardForName"] != DBNull.Value)
                     _wardFor.WardForName = Convert.ToString(reader["WardForName"]);
             _wardFor.NewRecord = false;             }             reader.Close();
             return _wardFor;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			WardForDAC wardforcomponent = new WardForDAC();
			return wardforcomponent.UpdateDataset(dataset);
		}



	}
}
