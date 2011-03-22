using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM
{
    using DAL;
    using Models;
    using System.ServiceModel;
    public partial class CRMService:ICustomerService
    {
        public DAL.CucstomerDAL CustomerDataLayer= new DAL.CucstomerDAL();

        #region ICustomerService Members

        public IList<Customer> GetCustomers()
        {
           return CustomerDataLayer.GetList();
        }

        public void AddCustomer(Customer c)
        {
            CustomerDataLayer.Add(c);
            //throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer c)
        {
            CustomerDataLayer.Update(c);
            //throw new NotImplementedException();
        }

        public void Delete(Customer c)
        {
            CustomerDataLayer.Delete(c.CID);
            //throw new NotImplementedException();
        }

        #endregion


        #region ICustomerService Members


        public void DeleteByID(int cid)
        {
            CustomerDataLayer.Delete(cid);
        }

        #endregion
    }
}
