using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Description;

using System.ServiceModel;
using System.Net;
using CRM;
namespace ServerHost
{
    public class Server
    {
        ServiceHost ManagerHost;
        public CommunicationState CurrentState
        {
            get { return ManagerHost.State; }
            private set;
        }
        
        public void StartServer()
        {
            if (ManagerHost == null 
                || this.CurrentState== CommunicationState.Closed)
            {            
                try
                {
                    ManagerHost = new ServiceHost(typeof(CRMService));                
                    ManagerHost.Opened += new EventHandler(ManagerHost_Opened);
                    ManagerHost.Closed += new EventHandler(ManagerHost_Closed);
                    IPAddress[] addresslist = Dns.GetHostAddresses(Dns.GetHostName());
                    NetTcpBinding binding = new NetTcpBinding();
                    String endpointaddress = "net.tcp://" + addresslist[0].ToString() + ":" + this.txt_port.Text + "/UserService";
                    ServiceEndpoint endPoint = ManagerHost.AddServiceEndpoint(
                        typeof(IUserService), binding,
                        endpointaddress);
                    String customeraddress = "net.tcp://" + addresslist[0].ToString() + ":" + this.txt_port.Text + "/CustomerService";
                    ServiceEndpoint customerEndPoint = ManagerHost.AddServiceEndpoint(
                        typeof(ICustomerService), binding, customeraddress);
                    String taskaddress = "net.tcp://" + addresslist[0].ToString() + ":" + this.txt_port.Text + "/TaskService";
                    ServiceEndpoint taskEndPoint = ManagerHost.AddServiceEndpoint(
                        typeof(ITaskService), binding, taskaddress);
                    //endPoint.Behaviors.Add();
                    //OperationContext.Current.Channel.Closed += new EventHandler(Channel_Closed);
                    ManagerHost.Open();

                }
                catch (System.Exception ex)
                {
                    throw ex;
                 //this.serverstatuslist.Items.Add(ex.Message.ToString() + Environment.NewLine + ex.StackTrace);
                }
            }
        }

        void ManagerHost_Opened(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        void ManagerHost_Closed(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        public void StopServer()
        {
            if (this.CurrentState != CommunicationState.Closed
                || this.CurrentState != CommunicationState.Closing
                || this.CurrentState != CommunicationState.Faulted)
            {
                ManagerHost.Close();
            }
            
        }
    }
}
