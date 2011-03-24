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
using ServerHost.Properties;
using Models;
namespace ServerHost
{
    public partial class Main : Form
    {
        Server server = new Server();
        CRMService service = new CRMService();
        public Main()
        {
            InitializeComponent();
        }
       

        void Channel_Closed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            this.timer.Enabled = true;
            server.StartServer(this.txt_port.Text);
            this.pictureBox1.Image = Resources.green;
            this.btn_start.Enabled = false;
            this.btn_stop.Enabled = true;
            //endPoint.Behaviors.Add(new CustomBehavior());
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            this.timer.Enabled = false;
            server.StopServer();
            this.pictureBox1.Image = Resources.red;
            this.btn_start.Enabled = true;
            this.btn_stop.Enabled = false;
        }
       
        private void startserverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            server.StartServer(this.txt_port.Text);
        }

        private void StopServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            server.StopServer();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //foreach (User u in this.service.userdatalayer.GetLoginedUser())
            //{
            //    this.serverstatuslist.Items.Add(u.UserName + Environment.NewLine);
            //}
        }

        private void btn_currentonline_Click(object sender, EventArgs e)
        {
            CurrentOnLineForm form = new CurrentOnLineForm();
            form.ShowDialog(this);
        }

        private void btn_usermanager_Click(object sender, EventArgs e)
        {
            UserManagerForm usermgmtform = new UserManagerForm();
            usermgmtform.ShowDialog(this);
        }
    }
}
