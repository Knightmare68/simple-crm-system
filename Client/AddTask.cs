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
    using Models;
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
            IList<Customer> result = ClientProxy.GetInstance().GetCustomerServcie.GetCustomers();
            cbx_customer.DisplayMember = "CustomerName";
            cbx_customer.ValueMember = "CID";
            cbx_customer.DataSource = result;
        }
        private void ClearContent()
        {
            this.txt_description.Text = "";
            this.cbx_customer.SelectedIndex = 0;
            this.dtp_endtime.Value = DateTime.Now;
            this.dtp_starttime.Value = DateTime.Now;
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (this.dtp_starttime.Value > this.dtp_endtime.Value)
            {
                MessageBox.Show("开始时间不能大于结束时间");
                return;
            }
            Task t = new Task();
            t.Customer.CID = Convert.ToInt32(this.cbx_customer.SelectedValue.ToString());
            t.Starttime = this.dtp_starttime.Value;
            t.EndTime = this.dtp_endtime.Value;
            t.Description = this.txt_description.Text;
            t.User.UserName = GlobalData.GetInstance().ShareData["User"].ToString();
            ClientProxy.GetInstance().GetTaskService.AddTask(t);
            ClearContent();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
