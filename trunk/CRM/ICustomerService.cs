using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using DAL;
namespace CRM
{
    using Models;
    [ServiceContract]
    public interface ICustomerService 
    {
        [OperationContract]
        IList<Customer> GetCustomers();
        [OperationContract]
        IList<Customer> GetCustomersByUser(string user);
        [OperationContract]
        void AddCustomer(Customer c);
        [OperationContract]
        void UpdateCustomer(Customer c);
        [OperationContract]
        void Delete(Customer c);
        [OperationContract]
        void DeleteByID(int cid);  
    }
}
