using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using CRM;
using System.ServiceModel.Description;
using ServerHost.Properties;
using System.Net;
namespace ServerHost
{
    public partial class Main : Form
    {
        ServiceHost ManagerHost;
        public Main()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                ManagerHost = new ServiceHost(typeof(CRMService));
                IPAddress[] addresslist = Dns.GetHostAddresses(Dns.GetHostName());
                NetTcpBinding binding = new NetTcpBinding();
                String endpointaddress = "net.tcp://" + addresslist[0].ToString()+":" + this.txt_port.Text + "/UserService";
                ServiceEndpoint endPoint = ManagerHost.AddServiceEndpoint(
                    typeof(IUserService), binding,
                    endpointaddress);
                String customeraddress = "net.tcp://" + addresslist[0].ToString()+":" + this.txt_port.Text + "/CustomerService";
                ServiceEndpoint customerEndPoint = ManagerHost.AddServiceEndpoint(
                    typeof(ICustomerService), binding, customeraddress);
                String taskaddress = "net.tcp://" + addresslist[0].ToString() + ":" + this.txt_port.Text + "/TaskService";
                ServiceEndpoint taskEndPoint = ManagerHost.AddServiceEndpoint(
                    typeof(ITaskService), binding, taskaddress);
                //endPoint.Behaviors.Add();
                ManagerHost.Open();
                this.pictureBox1.Image = Resources.green;
                this.btn_start.Enabled = false;
                this.btn_stop.Enabled = true;
            }
            catch (System.Exception ex)
            {
                this.serverstatuslist.Items.Add(ex.Message.ToString()+Environment.NewLine+ex.StackTrace);
            	
            }
            //endPoint.Behaviors.Add(new CustomBehavior());
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            ManagerHost.Close();
            this.pictureBox1.Image = Resources.red;
            this.btn_start.Enabled = true;
            this.btn_stop.Enabled = false;
        }
    }
}
