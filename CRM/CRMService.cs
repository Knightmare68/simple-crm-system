using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM
{
    using DAL;
    using Models;
    using Microsoft.Practices.Unity;
    public partial class CRMService
    {
        private readonly UnityContainer container = new UnityContainer();
        public UserDAL UserDAL{
            get{
                return this.container.Resolve<UserDAL>();
            }
        }

        public TaskDAL TaskDAL{
            get
            {
                return this.container.Resolve<TaskDAL>();
            }
        }

        public CustomerDAL CustomerDAL
        {
            get
            {
                return this.container.Resolve<CustomerDAL>();
            }
        }

        public CRMService()
        {
            TaskDAL taskdal = new TaskDAL();
            UserDAL  userdal = new UserDAL();
            CustomerDAL customerdal = new CustomerDAL();
            container.RegisterInstance<TaskDAL>(taskdal);
            container.RegisterInstance<UserDAL>(userdal);
            container.RegisterInstance<CustomerDAL>(customerdal);
        }
 
    }
}
