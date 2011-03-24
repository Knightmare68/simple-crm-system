using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace CRM
{
    using Models;
    using System.Data;
    using System.ServiceModel;
    public partial class CRMService : IUserService
    {
        public UserDAL userdatalayer = new UserDAL();
        #region IUserService Members

        public void AddUser(User u)
        {
            userdatalayer.Add(u);
            //throw new NotImplementedException();
        }

        public void Update(User u)
        {
            userdatalayer.Update(u);
            //throw new NotImplementedException();
        }

        public void DeleteUser(User u)
        {
            userdatalayer.Delete(u.UserName);
        }

        public IList<User> GetUserList()
        {
            return userdatalayer.GetList();
        }

        public User GetUserByID(string uid)
        {
            return userdatalayer.GetByID(uid);
        }

        #endregion

        #region IUserService Members


        public bool Authenticate(string uid, string password)
        {
            User u = this.GetUserByID(uid);
            if(u!= null && u.Password == password)
            {
                //The User right is correct.
                this.userdatalayer.UpdateStatus(User.LOGINED, uid);                
                return true;
            }
            return false;
            //throw new NotImplementedException();
        }

        #endregion

        #region IUserService Members


        public CRMDataSet.userDataTable GetUserDataTable()
        {
            CRMDataSet.userDataTable result = this.userdatalayer.UserTableAdapter.GetData();
            return result;
            //throw new NotImplementedException();
        }

        #endregion
    }
}
