using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    using Models;
    public class TaskDAL:IDAL<Task,int>
    {

        public CRMDataSetTableAdapters.tasksTableAdapter tasktableadapter =
            new DAL.CRMDataSetTableAdapters.tasksTableAdapter();
        #region IDAL<Task,int> Members

        public void Add(Task t)
        {
            tasktableadapter.Insert(t.Customer.CID, t.Starttime, t.Description,t.User.UserName,t.EndTime,t.Status);
            //throw new NotImplementedException();
        }

        public void Update(Task t)
        {
            tasktableadapter.Update(t.Starttime, t.Description, t.EndTime, t.User.UserName, t.Customer.CID,t.Status, t.ID);
        }

        public void Delete(int id)
        {
            tasktableadapter.Delete(id);
        }
        
        public IList<Task> GetList()    
        {
            List<Task> result = new List<Task>();
            foreach (CRMDataSet.tasksRow row in tasktableadapter.GetData())
            {
                result.Add(Mapper.Map(row));
            }

            return result;
        }

        public Task GetByID(int id)
        {
            return Mapper.Map(tasktableadapter.GetDataByID(id).Rows[0] 
                as CRMDataSet.tasksRow);
        }

        public Task GetLastestTask()
        {
            CRMDataSet.tasksDataTable result = tasktableadapter.GetLatestTask();
            if (result.Rows.Count == 0)
            {
                return null;
            }
            return Mapper.Map(result.Rows[0] 
                as CRMDataSet.tasksRow);
        }
        #endregion
    }
}
