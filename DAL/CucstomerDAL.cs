using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    using Models;
    public class CustomerDAL:IDAL<Customer,int>
    {

        public CRMDataSetTableAdapters.customerTableAdapter CustomerDataTableAdapter
            = new CRMDataSetTableAdapters.customerTableAdapter();

        #region IDAL<Customer> Members

        public void Add(Customer c)
        {
            CustomerDataTableAdapter.CreateCustomer(c.CustomerName, c.Gender, c.CompanyName,
                c.Department, c.Position, c.Address,
                c.WebSite,c.Phone, c.Zip, c.Email, c.Mobile, 
                c.Fax, c.HomePhone, c.Description,c.Owner.UserName); 
        }


        public void Update(Customer c)
        {
            CustomerDataTableAdapter.Update(c.CustomerName,
                c.Gender,c.CompanyName,
                c.Department,c.Position,
                c.Address,c.WebSite,c.Phone,
                c.Zip,c.Email,c.Mobile,
                c.Fax,c.HomePhone,c.Description,c.Owner.UserName,c.CID);
        }

        public void Delete(int cid)
        {
            CustomerDataTableAdapter.Delete(cid);
            //throw new NotImplementedException();
        }
        public IList<Customer> GetList()
        {
           List<Customer> result = new List<Customer>();
           foreach (
               CRMDataSet.customerRow row in 
               CustomerDataTableAdapter.GetData().Rows)
           {
               result.Add(Mapper.Map(row));
           }
           return result;
        }

        public Customer GetByID(int id)
        {
            return Mapper.Map(CustomerDataTableAdapter.GetDataByID(id).Rows[0] 
                as CRMDataSet.customerRow);
            //throw new NotImplementedException();
        }

        #endregion

    }
}
