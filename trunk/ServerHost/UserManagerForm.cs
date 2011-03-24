using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ServerHost
{
    using CRM;
    using Utility;
    using Models;
    public partial class UserManagerForm : Form
    {  
        CRMService service = new CRMService();
        public UserManagerForm()
        {
            InitializeComponent();
        }

        private void UserManagerForm_Load(object sender, EventArgs e)
        {
            BindingList<Item> source = new BindingList<Item>();
            source.Add(new Item("管理员",1 ));
            source.Add(new Item("普通用户", 2));
            this.cbx_role.DataSource = source;
            this.cbx_role.DisplayMember= "Name";
            this.cbx_role.ValueMember = "Value";

            BindingList<Item> source1 = new BindingList<Item>();
            source1.Add(new Item("管理员", 1));
            source1.Add(new Item("普通用户", 2));

            this.role.DataSource = source1;
            this.role.DisplayMember = "Name";
            this.role.ValueMember = "Value";
            this.role.DataPropertyName = "Role";
            this.dgv_userlist.AutoGenerateColumns = false;
            this.dgv_userlist.DataSource = service.GetUserList();
        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {
            if (String .IsNullOrEmpty(this.txt_username.Text) || 
                String .IsNullOrEmpty(this.txt_password.Text))
            {
                MessageBox.Show("请输入用户名和密码");
                return;
            }
            User u = new User();
            u.UserName = this.txt_username.Text;
            u.Password = this.txt_password.Text;
            u.Description = this.txt_description.Text;
            u.Role = Convert.ToInt32(this.cbx_role.SelectedValue.ToString());
            u.Status = User.LOGOFF;
            service.AddUser(u);
            RefreshData();
        }
        private void RefreshData()
        {
            this.dgv_userlist.DataSource = service.GetUserList();
        }
        private void dgv_userlist_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            String username = this.dgv_userlist.Rows[e.RowIndex].Cells["username"].Value.ToString();
            String password= this.dgv_userlist.Rows[e.RowIndex].Cells["password"].Value.ToString();
            String description= this.dgv_userlist.Rows[e.RowIndex].Cells["description"].Value.ToString();
            int role = (int)this.dgv_userlist.Rows[e.RowIndex].Cells["role"].Value;
            User u = service.GetUserByID(username);
            u.Password = password;
            u.Description = description;
            u.Role = role;
            service.Update(u);
            this.dgv_userlist.RefreshEdit();
        }
        private void dgv_userlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {
                DeleteUser(e.RowIndex);
                RefreshData();
            }
        }

        private void DeleteUser(int rowindex)
        {
            if(MessageBox.Show("删除这个用户？", "提示",MessageBoxButtons.OKCancel)== DialogResult.OK)
            {
                string username = this.dgv_userlist.Rows[rowindex].Cells["username"].Value.ToString();
                service.UserDAL.Delete(username);
            }
        }
    }
}
