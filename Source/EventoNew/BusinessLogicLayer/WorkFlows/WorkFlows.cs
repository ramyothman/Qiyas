using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer.WorkFlows
{
    public class WorkFlows
    {
        #region Events
        public delegate void AfterInsertedEventHandler(object id);
        public delegate void AfterUpdatedEventHandler();
        public delegate void AfterDeletedEventHandler();

        public event AfterInsertedEventHandler AfterInserted;
        public event AfterUpdatedEventHandler AfterUpdated;
        public event AfterDeletedEventHandler AfterDeleted;
        #endregion
    }
}
