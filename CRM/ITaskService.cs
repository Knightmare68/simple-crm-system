using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Models;
using DAL;
namespace CRM
{
    [ServiceContract]
    public interface ITaskService 
    {
        [OperationContract]
        void AddTask(Task t);
        [OperationContract]
        void UpdateTask(Task t);
        [OperationContract]
        void DeleteTask(int id);
        [OperationContract]
        Task FindByID(int id);
        [OperationContract]
        IList<Task> FindList();
        [OperationContract]
        IList<Task> GetListByUser(String uid);
        [OperationContract]
        Task GetCurTask();

    }
}
