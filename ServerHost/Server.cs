using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Description;
using System.Windows.Forms;
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
        }
        
        public void StartServer(String port)
        {
            if (ManagerHost == null)          
            {
                ManagerHost = new ServiceHost(typeof(CRMService));
                try
                {
                    IPAddress[] addresslist = Dns.GetHostAddresses(Dns.GetHostName());
                    NetTcpBinding binding = new NetTcpBinding();
                    String endpointaddress = "net.tcp://" + addresslist[0].ToString() + ":" + port + "/UserService";
                    ServiceEndpoint endPoint = ManagerHost.AddServiceEndpoint(
                        typeof(IUserService), binding,
                        endpointaddress);
                    String customeraddress = "net.tcp://" + addresslist[0].ToString() + ":" + port + "/CustomerService";
                    ServiceEndpoint customerEndPoint = ManagerHost.AddServiceEndpoint(
                        typeof(ICustomerService), binding, customeraddress);
                    String taskaddress = "net.tcp://" + addresslist[0].ToString() + ":" + port + "/TaskService";
                    ServiceEndpoint taskEndPoint = ManagerHost.AddServiceEndpoint(
                        typeof(ITaskService), binding, taskaddress);
                    //endPoint.Behaviors.Add();
                    //OperationContext.Current.Channel.Closed += new EventHandler(Channel_Closed);
                    //如果当前状态是开放着的，或者已经打开了，这个时候应该关掉
                    if (this.CurrentState == CommunicationState.Created)
                    {
                        
                        ManagerHost.Opened += new EventHandler(ManagerHost_Opened);
                        ManagerHost.Closed += new EventHandler(ManagerHost_Closed);
                        ManagerHost.Open();
                    }
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
            MessageBox.Show("The server is Opende!");
            //throw new NotImplementedException();
        }

        void ManagerHost_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("The server is Closed!");
            //throw new NotImplementedException();
        }

        public void StopServer()
        {
            ManagerHost.Abort();
            if (this.CurrentState != CommunicationState.Closed
                || this.CurrentState != CommunicationState.Closing
                || this.CurrentState != CommunicationState.Faulted)
            {
                ManagerHost.Close();
            }            
        }
    }
}
