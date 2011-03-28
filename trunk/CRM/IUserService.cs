using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Data;
namespace CRM
{
    using Models;
    using DAL;
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        void AddUser(User u);
        [OperationContract]
        void Update(User u);
        [OperationContract]
        void DeleteUser(User u);
        [OperationContract]
        IList<User> GetUserList();
        [OperationContract]
        User GetUserByID(string uid);
        [OperationContract]
        bool Authenticate(String uid, string password);
        [OperationContract]
        void Logoff(string uid);
    }
}
