using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CRM;
using Models;
using System.Collections;
using Utility;
namespace Client
{
    public partial class Main : Form
    {
        CustomUIControls.TaskbarNotifier tasknotifier = new CustomUIControls.TaskbarNotifier();          
        int currentmouserowinde = -1;
        public Main()
        {
            InitializeComponent();
            BindingList<Item> source = new BindingList<Item>();
            source.Add(new Item("男", true));
            source.Add(new Item("女", false));
            this.gender.DataSource = source;
            this.gender.DisplayMember= "Name";
            this.gender.ValueMember = "Value";
            this.gender.DataPropertyName = "gender";
            this.gv_customer.ContextMenu = this.customergv_contextmenu;
            this.gv_customer.AutoGenerateColumns = false;
            tasknotifier.SetBackgroundBitmap(Properties.Resources.background,
                    Color.FromArgb(255, 0, 255));
            tasknotifier.SetCloseBitmap(Properties.Resources.close,
                    Color.FromArgb(255, 0, 255), new Point(230, 20));
            tasknotifier.TitleRectangle = new Rectangle(10, 9, 210,50);
            tasknotifier.ContentRectangle = new Rectangle(8, 50, 210, 180);
            tasknotifier.ContentClick += new EventHandler(tasknotifier_ContentClick);
            tasknotifier.CloseClick += new EventHandler(tasknotifier_CloseClick);
            //this.Activated += new EventHandler(Main_Activated);
        }

        void tasknotifier_CloseClick(object sender, EventArgs e)
        {
            tasknotifier.Hide();
        }

        void tasknotifier_ContentClick(object sender, EventArgs e)
        {
            MessageBox.Show("谢谢你点了我");
            //this.
            //throw new NotImplementedException();
        }
        public void RefreshData()
        {
            this.gv_customer.DataSource = 
                ClientProxy.GetInstance().GetCustomerServcie.GetCustomers();
        }
        private void Main_Load(object sender, EventArgs e)
        {

            this.timer.Enabled = true;
            // TODO: This line of code loads data into the 'crmDataSet.customer' table. You can move, or remove it, as needed.
            this.gv_customer.DataSource = ClientProxy.GetInstance().GetCustomerServcie.GetCustomers();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void gv_customer_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            MessageBox.Show("删除成功");
            //MessageBox.Show(this.gv_customer.SelectedRows[0].Cells[0]);
            //ClientProxy.GetInstance().GetCustomerServcie.DeleteByID()
        }

        private void gv_customer_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int cid = Convert.ToInt32(e.Row.Cells["cid"].Value.ToString());
            ClientProxy.GetInstance().GetCustomerServcie.DeleteByID(cid);
        }

        private void gv_customer_MouseUp(object sender, MouseEventArgs e)
        {
            
            DataGridView.HitTestInfo hitTestInfo;
            if (e.Button == MouseButtons.Right)
            {
                hitTestInfo = gv_customer.HitTest(e.X, e.Y);
                // If column is first column
                if (hitTestInfo.Type == DataGridViewHitTestType.Cell)// && hitTestInfo.ColumnIndex == 0)
                {
                    currentmouserowinde = hitTestInfo.RowIndex;
                    customergv_contextmenu.Show(gv_customer, new Point(e.X, e.Y));
                }
            }
        }

        void EditCustomermenuItem_Click(object sender, System.EventArgs e)
        {
            Customer c = this.ConvertRowtoModel(this.gv_customer.Rows[this.currentmouserowinde]);
            EditCustomer editdialog = new EditCustomer(c);
            editdialog.ShowDialog(this);
            //MessageBox.Show("Current Row index is :"+currentmouserowinde);

            //throw new System.NotImplementedException();
        }
        private void AddCustomertoolStripButton_Click(object sender, EventArgs e)
        {
            AddCustomer addcustomer = new AddCustomer();
            addcustomer.ShowDialog(this);
        }
        private string GetValue(object o)
        {
            if (o == null)
            {
                return "";
            }
            return o.ToString();
        }
        private Customer ConvertRowtoModel(DataGridViewRow row)
        {
            int cid = Convert.ToInt32(row.Cells["cid"].Value);
            string customername = GetValue(row.Cells["customername"].Value);
            Boolean gender = Convert.ToBoolean(row.Cells["gender"].Value);
            string companyname = GetValue(row.Cells["companyname"].Value);
            string department = GetValue(row.Cells["department"].Value);
            string position = GetValue(row.Cells["position"].Value);
            string address = GetValue(row.Cells["address"].Value);
            string website = GetValue(row.Cells["website"].Value);
            string phone = GetValue(row.Cells["phone"].Value);
            string zip = GetValue(row.Cells["zip"].Value);
            string email = GetValue(row.Cells["email"].Value);
            string mobile = GetValue(row.Cells["mobile"].Value);
            string fax = GetValue(row.Cells["fax"].Value);
            string homephone = GetValue(row.Cells["homephone"].Value);
            string description = GetValue(row.Cells["description"].Value);
            string owner = GlobalData.GetInstance().ShareData["User"].ToString();//GetValue(row.Cells["owner"].Value);
            Customer c = new Customer();
            c.CID = cid;
            c.Address = address;
            c.CompanyName = companyname;
            c.CustomerName = customername;
            c.Department = department;
            c.Description = description;
            c.Email = email;
            c.Fax = fax;
            c.Gender = gender;
            c.HomePhone = homephone;
            c.Mobile = mobile;
            c.Owner.UserName = owner;
            c.Phone = phone;
            c.Position = position;
            c.WebSite = website;
            c.Zip = zip;
            return c;

        }

        private void gv_customer_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Customer c = ConvertRowtoModel(this.gv_customer.Rows[e.RowIndex]);
            ClientProxy.GetInstance().GetCustomerServcie.UpdateCustomer(c);
        }

        private void AddTasktoolStripButton_Click(object sender, EventArgs e)
        {
            AddTask addtaskform = new AddTask();
            addtaskform.ShowDialog(this);
            //this.addtaskform.Visible = false;
            //this.ShowDialog(this.addtaskform);
        }

        void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Button");
            //throw new NotImplementedException();
        }

        private void btn_editclick(object sender, EventArgs e)
        {
            MessageBox.Show("Edit Button");
        }

        private void gv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex== 0 && e.RowIndex != -1)
            {
                DeleteOneCustomer(e.RowIndex);
            }
        }

        private void DeleteOneCustomer(int rowindex)
        {
            if(MessageBox.Show("你要删除这条记录吗？","提示",
                    MessageBoxButtons.OKCancel)== DialogResult.OK)
                {
                    int cid = Convert.ToInt32(this.gv_customer.Rows[rowindex].Cells["cid"].Value.ToString());
                    ClientProxy.GetInstance().GetCustomerServcie.DeleteByID(cid);
                    RefreshData();
                }
        }

        private void DeleteCustomermenuItem_Click(object sender, EventArgs e)
        {
            DeleteOneCustomer(this.currentmouserowinde);
        }

        private void logoff_toolStripButton_Click(object sender, EventArgs e)
        {
            FormManager.GetInstance().GetFormByName(typeof(Login).ToString()).Show();
            this.Hide();
        }

        private void TaskListtoolStripButton_Click(object sender, EventArgs e)
        {
            TaskList tasklistform = new TaskList();
            tasklistform.ShowDialog(this);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.lbl_currenttime.Text ="当前时间:"+DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            //Task task = ClientProxy.GetInstance().GetTaskService.GetCurTask();
            //if (task != null && DateTime.Now.Subtract(task.EndTime).Minutes <= 1)
            //{
            //    tasknotifier.Show("提醒", task.Description, 500, 3000, 500);        
            //}            
        }

        private void ShowNotificationIcon()
        {
            this.Hide();
            this.ShowInTaskbar = true;
            this.ni_reminder.Visible = true;
            this.ni_reminder.ShowBalloonTip(100, "提示","最小化到托盘", ToolTipIcon.Info);
        }
        private void HidNotificationIcon()
        {
            this.Visible = true;
            this.Show();
            this.ShowInTaskbar = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.ni_reminder.Visible = false;
        }
        private void Main_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                ShowNotificationIcon();
            }
        }

        private void ni_reminder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            HidNotificationIcon();
        }
        //private void ShowNewForm(object sender, EventArgs e)
        //{
        //    Form childForm = new Form();
        //    childForm.MdiParent = this;
        //    childForm.Text = "Window " + childFormNumber++;
        //    childForm.Show();
        //}

        //private void OpenFile(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //    openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        //    if (openFileDialog.ShowDialog(this) == DialogResult.OK)
        //    {
        //        string FileName = openFileDialog.FileName;
        //    }
        //}

        //private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //    saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        //    if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
        //    {
        //        string FileName = saveFileDialog.FileName;
        //    }
        //}

        //private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //}

        //private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //}

        //private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //}

        //private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
           
        //}

        //private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
           
        //}

        //private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    LayoutMdi(MdiLayout.Cascade);
        //}

        //private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    LayoutMdi(MdiLayout.TileVertical);
        //}

        //private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    LayoutMdi(MdiLayout.TileHorizontal);
        //}

        //private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    LayoutMdi(MdiLayout.ArrangeIcons);
        //}

        //private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    foreach (Form childForm in MdiChildren)
        //    {
        //        childForm.Close();
        //    }
        //}
    }
}
