using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txt_username.Text))
            {
                MessageBox.Show("请输入用户名");
                this.txt_username.Focus();
                return;
            }
            if (String.IsNullOrEmpty(this.txt_pass.Text))
            {
                this.txt_pass.Focus();
                return;
            }

            String serverinfor = this.cbx_server.Text.ToString();
            String serverinforsubstr = serverinfor.Substring(serverinfor.IndexOf('(') + 1, serverinfor.IndexOf(')') - serverinfor.IndexOf('('));
            String[] server = serverinforsubstr.Split(':');
            GlobalData.GetInstance().Add("ServerAddress", server[0]);
            GlobalData.GetInstance().Add("ServerPort", server[1]);
            GlobalData.GetInstance().Add("User", this.txt_username.Text);
            if(ClientProxy.GetInstance().Authentication(this.txt_username.Text, this.txt_pass.Text))
            {
                this.Hide();
                FormManager.GetInstance().GetFormByName(typeof(Main).ToString()).Show();
            }
            else
            {
                MessageBox.Show("你的用户名和密码不正确");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            IList<ServerInfo> serverlist = Utility.GetServerList();
            foreach (ServerInfo server in serverlist)
            {
                this.cbx_server.Items.Add(server.ServerName + "(" + server.ServerName + ":" + server.Port + ")");
            }
            //Search the server
            cbx_server.SelectedIndex = 0;
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                this.btn_login_Click(this.btn_login, null);
            }
        }
    }
}
