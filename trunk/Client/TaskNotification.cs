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
    public partial class TaskNotification : Form
    {
        public TaskNotification()
        {
            InitializeComponent();
        }

        private void TaskNotification_Load(object sender, EventArgs e)
        {
        }

        private void btn_doneselected_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem == null)
            {
                MessageBox.Show(this,"请选中一个任务","提示");
                return;
            }
            String taskid = this.listBox1.SelectedValue.ToString();
            this.listBox1.Items.Remove(this.listBox1.SelectedItem);
            Task t = ClientProxy.GetInstance().GetTaskService.FindByID(Convert.ToInt32(taskid));
            t.Status = Task.Finished;
            ClientProxy.GetInstance().GetTaskService.UpdateTask(t);

        }
    }
}
