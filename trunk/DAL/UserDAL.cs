using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    using Models;
    public class UserDAL:IDAL<User,String>
    {
        private CRMDataSetTableAdapters.userTableAdapter usertableadapter
            = new CRMDataSetTableAdapters.userTableAdapter();

        public CRMDataSetTableAdapters.userTableAdapter UserTableAdapter{
            get { return this.usertableadapter; }
        }
        #region IDAL<User,string> Members

        public void Add(User t)
        {
            UserTableAdapter.Insert(t.UserName, 
                t.Password, 
                t.Description,
                (int)t.CurrentRole);
        }

        public void Update(User t)
        {
            UserTableAdapter.Update(t.Password, t.Description, 
                (int)t.CurrentRole, t.UserName);
            //throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            UserTableAdapter.Delete(id);
           // throw new NotImplementedException();
        }

        public IList<User> GetList()
        {
            List<User> result = new List<User>();
            foreach (CRMDataSet.userRow row in UserTableAdapter.GetData())
            {
                result.Add(Mapper.Map(row));
            }
            return result;
        }

        public User GetByID(string id)
        {
            if (UserTableAdapter.GetDataByID(id).Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return Mapper.Map(UserTableAdapter.GetDataByID(id).Rows[0]
                as CRMDataSet.userRow);
            }            
        }

        #endregion
    }
}
