using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM
{
    using DAL;
    using Models;
    using System.ServiceModel;
    [ServiceBehavior(IncludeExceptionDetailInFaults=true)]
    public partial class CRMService:ITaskService
    {
        public TaskDAL taskdal = new TaskDAL();
        #region ITaskService Members

        public void AddTask(Task t)
        {
            taskdal.Add(t);
         //   throw new NotImplementedException();
        }

        public void UpdateTask(Task t)
        {
            taskdal.Update(t);
        }

        public void DeleteTask(int id)
        {
            taskdal.Delete(id);
        }

        public Task FindByID(int id)
        {
            return taskdal.GetByID(id);
        }

        public IList<Task> FindList()
        {
            return taskdal.GetList();
            //throw new NotImplementedException();
        }

        #endregion

        #region ITaskService Members


        public Task GetCurTask()
        {
            return taskdal.GetLastestTask();
            //taskdal.GetByID()
            //throw new NotImplementedException();
        }

        #endregion
    }
}
