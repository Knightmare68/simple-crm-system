using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CRM;
using System.ServiceModel;
using System.Windows.Forms;

namespace Client
{
    public class ClientProxy
    {                 
        public String ServerAddress { get; set; }
        public int ServerPort { get; set; }
        private ICustomerService customerservie;
        public ICustomerService GetCustomerServcie { get {
            if (customerservie == null)
            {
                customerservie = this.GetService<ICustomerService>("net.tcp",
                     this.ServerAddress,
                     this.ServerPort, "CustomerService");

            }

            return customerservie;        
        }}
        private ITaskService taskservice;
        public ITaskService GetTaskService
        {
            get
            {
                if (taskservice == null)
                {
                    taskservice = this.GetService<ITaskService>("net.tcp",
                    this.ServerAddress,
                    this.ServerPort, "TaskService");
                }
                return taskservice;
            }
        }

        private IUserService userservice;
        public IUserService GetUserService
        {
            get
            {
                if (userservice == null)
                {
                    userservice = this.GetService<IUserService>("net.tcp",
                    this.ServerAddress,
                    this.ServerPort, "UserService");
                }
                return userservice;
            }
        }
        private ClientProxy()
        {
            if (String.IsNullOrEmpty(System.Configuration.ConfigurationSettings.AppSettings["Server"]))
            {
                throw new Exception("Your configuration do not have server name");
            }
            else
            {
                this.ServerAddress = System.Configuration.ConfigurationSettings.AppSettings["Server"];
            }
            if (String.IsNullOrEmpty(System.Configuration.ConfigurationSettings.AppSettings["ServerPort"]))
            {
                throw new Exception("Your configuration do not have server port");
            }
            else
            {
                this.ServerPort = Convert.ToInt32(System.Configuration.ConfigurationSettings.AppSettings["ServerPort"]);
            }

            
            
        }

        private static ClientProxy _instatnce = new ClientProxy();
        public static ClientProxy GetInstance()
        {
            if (_instatnce == null)
            {
                return new ClientProxy();
            }
            return _instatnce;
        }
        public T GetService<T>(String type,String server, int Port, String UserEndpoint)
        {
            NetTcpBinding binding = new NetTcpBinding();
            ChannelFactory<T> factory = new ChannelFactory<T>(binding);
            factory.Closed += new EventHandler(factory_Closed);
            String url = type+"://"+server+":"+Port+"/"+UserEndpoint;
            EndpointAddress endPointAddress = 
                new EndpointAddress(url);
            return factory.CreateChannel(endPointAddress);
        }

        void factory_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("Factory Close");
            //throw new NotImplementedException();
        }

        public ICustomerService GetCustomerService()
        {
            return this.GetService<ICustomerService>("net.tcp", 
                this.ServerAddress, 
                this.ServerPort, "CustomerService");
        }

        //public IUserService GetUserService()
        //{
        //    return this.GetService<IUserService>("net.tcp",
        //        this.ServerAddress,
        //        this.ServerPort, "UserService");
        //}
        public bool Authentication(String username, String password)
        {
            return GetUserService.Authenticate(username, password);
        }
    }
}
