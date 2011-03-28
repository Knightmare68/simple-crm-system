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
    public partial class TaskList : Form
    {
        public TaskList()
        {
            InitializeComponent();
            this.dgv_tasklist.AutoGenerateColumns = false;
            Refreshdata();            
        }
        private void Refreshdata()
        {
            String user = GlobalData.GetInstance()["User"].ToString();
            IList<Task> result = ClientProxy.GetInstance().GetTaskService.GetListByUser(user);
            this.dgv_tasklist.DataSource = result;
        }
        private void DeleteOneCustomer(int rowindex)
        {
            if (MessageBox.Show("你要删除这条记录吗？", "提示",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int id = Convert.ToInt32(this.dgv_tasklist.Rows[rowindex].Cells["id"].Value.ToString());
                ClientProxy.GetInstance().GetTaskService.DeleteTask(id);
                Refreshdata();
            }
        }
        private void dgv_tasklist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex== 0 && e.RowIndex != -1)
            {
                DeleteOneCustomer(e.RowIndex);
            }
        }
    }
}
