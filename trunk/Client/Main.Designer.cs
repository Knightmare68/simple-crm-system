using System.Collections;
using Client.Properties;
using System.Windows.Forms;
namespace Client
{

    partial class Main
    {      
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.lbl_currenttime = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.AddCustomertoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AddTasktoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SearchtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.TaskListtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.logoff_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.gv_customer = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.companyname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.CustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addcustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewTaskListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customergv_contextmenu = new System.Windows.Forms.ContextMenu();
            this.EditCustomermenuItem = new System.Windows.Forms.MenuItem();
            this.DeleteCustomermenuItem = new System.Windows.Forms.MenuItem();
            this.ctxmenuitem_addcustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmenu_editcustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmenu_deletecustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCustomerTool = new System.Windows.Forms.ToolStripButton();
            this.tool_find = new System.Windows.Forms.ToolStripButton();
            this.tool_addcustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.addTskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加客户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户信息详情ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改客户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找客户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ni_reminder = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainpanel.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_customer)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 548);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(792, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(632, 347);
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.lbl_currenttime);
            this.mainpanel.Controls.Add(this.toolStrip);
            this.mainpanel.Controls.Add(this.gv_customer);
            this.mainpanel.Controls.Add(this.menuStrip);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(792, 548);
            this.mainpanel.TabIndex = 8;
            // 
            // lbl_currenttime
            // 
            this.lbl_currenttime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_currenttime.Font = new System.Drawing.Font("SimSun", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_currenttime.Location = new System.Drawing.Point(467, 88);
            this.lbl_currenttime.Name = "lbl_currenttime";
            this.lbl_currenttime.Size = new System.Drawing.Size(325, 60);
            this.lbl_currenttime.TabIndex = 11;
            this.lbl_currenttime.Text = "label2";
            this.lbl_currenttime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCustomertoolStripButton,
            this.AddTasktoolStripButton,
            this.toolStripSeparator1,
            this.SearchtoolStripButton,
            this.TaskListtoolStripButton,
            this.logoff_toolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(792, 64);
            this.toolStrip.TabIndex = 9;
            this.toolStrip.Text = "toolStrip1";
            // 
            // AddCustomertoolStripButton
            // 
            this.AddCustomertoolStripButton.AutoSize = false;
            this.AddCustomertoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddCustomertoolStripButton.Image = global::Client.Properties.Resources.edit;
            this.AddCustomertoolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddCustomertoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddCustomertoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddCustomertoolStripButton.Name = "AddCustomertoolStripButton";
            this.AddCustomertoolStripButton.Size = new System.Drawing.Size(64, 64);
            this.AddCustomertoolStripButton.Text = "添加用户";
            this.AddCustomertoolStripButton.ToolTipText = "添加用户";
            this.AddCustomertoolStripButton.Click += new System.EventHandler(this.AddCustomertoolStripButton_Click);
            // 
            // AddTasktoolStripButton
            // 
            this.AddTasktoolStripButton.AutoSize = false;
            this.AddTasktoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddTasktoolStripButton.Image = global::Client.Properties.Resources.task;
            this.AddTasktoolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddTasktoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddTasktoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddTasktoolStripButton.Name = "AddTasktoolStripButton";
            this.AddTasktoolStripButton.Size = new System.Drawing.Size(64, 64);
            this.AddTasktoolStripButton.Text = "添加任务";
            this.AddTasktoolStripButton.Click += new System.EventHandler(this.AddTasktoolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 64);
            // 
            // SearchtoolStripButton
            // 
            this.SearchtoolStripButton.AutoSize = false;
            this.SearchtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchtoolStripButton.Image")));
            this.SearchtoolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchtoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SearchtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchtoolStripButton.Name = "SearchtoolStripButton";
            this.SearchtoolStripButton.Size = new System.Drawing.Size(64, 64);
            this.SearchtoolStripButton.Text = "查找";
            // 
            // TaskListtoolStripButton
            // 
            this.TaskListtoolStripButton.AutoSize = false;
            this.TaskListtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TaskListtoolStripButton.Image = global::Client.Properties.Resources.taskList;
            this.TaskListtoolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TaskListtoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TaskListtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TaskListtoolStripButton.Name = "TaskListtoolStripButton";
            this.TaskListtoolStripButton.Size = new System.Drawing.Size(64, 64);
            this.TaskListtoolStripButton.Text = "查看任务";
            this.TaskListtoolStripButton.Click += new System.EventHandler(this.TaskListtoolStripButton_Click);
            // 
            // logoff_toolStripButton
            // 
            this.logoff_toolStripButton.AutoSize = false;
            this.logoff_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.logoff_toolStripButton.Image = global::Client.Properties.Resources.logoff;
            this.logoff_toolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoff_toolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logoff_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logoff_toolStripButton.Name = "logoff_toolStripButton";
            this.logoff_toolStripButton.Size = new System.Drawing.Size(64, 64);
            this.logoff_toolStripButton.Text = "logoff";
            this.logoff_toolStripButton.Click += new System.EventHandler(this.logoff_toolStripButton_Click);
            // 
            // gv_customer
            // 
            this.gv_customer.AllowUserToAddRows = false;
            this.gv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_delete,
            this.CID,
            this.customername,
            this.gender,
            this.companyname,
            this.department,
            this.position,
            this.address,
            this.zip,
            this.website,
            this.phone,
            this.fax,
            this.mobile,
            this.homephone,
            this.email,
            this.description});
            this.gv_customer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gv_customer.Location = new System.Drawing.Point(0, 148);
            this.gv_customer.MultiSelect = false;
            this.gv_customer.Name = "gv_customer";
            this.gv_customer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gv_customer.RowTemplate.Height = 23;
            this.gv_customer.Size = new System.Drawing.Size(792, 400);
            this.gv_customer.TabIndex = 7;
            this.gv_customer.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gv_customer_UserDeletingRow);
            this.gv_customer.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gv_customer_UserDeletedRow);
            this.gv_customer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gv_customer_MouseUp);
            this.gv_customer.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_customer_CellEndEdit);
            this.gv_customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_customer_CellClick);
            // 
            // btn_delete
            // 
            this.btn_delete.DataPropertyName = "删除";
            this.btn_delete.Frozen = true;
            this.btn_delete.HeaderText = "";
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btn_delete.Text = "删除";
            this.btn_delete.ToolTipText = "删除当前客户";
            this.btn_delete.UseColumnTextForButtonValue = true;
            this.btn_delete.Width = 50;
            // 
            // CID
            // 
            this.CID.DataPropertyName = "cid";
            this.CID.Frozen = true;
            this.CID.HeaderText = "CID";
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
            this.CID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CID.Width = 30;
            // 
            // customername
            // 
            this.customername.DataPropertyName = "customername";
            this.customername.Frozen = true;
            this.customername.HeaderText = "客户姓名";
            this.customername.Name = "customername";
            // 
            // gender
            // 
            this.gender.AutoComplete = false;
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "性别";
            this.gender.Name = "gender";
            // 
            // companyname
            // 
            this.companyname.DataPropertyName = "companyname";
            this.companyname.HeaderText = "公司名称";
            this.companyname.Name = "companyname";
            // 
            // department
            // 
            this.department.DataPropertyName = "department";
            this.department.HeaderText = "部门名称";
            this.department.Name = "department";
            // 
            // position
            // 
            this.position.DataPropertyName = "position";
            this.position.HeaderText = "职位";
            this.position.Name = "position";
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "公司地址";
            this.address.Name = "address";
            // 
            // zip
            // 
            this.zip.DataPropertyName = "zip";
            this.zip.HeaderText = "邮编";
            this.zip.Name = "zip";
            // 
            // website
            // 
            this.website.DataPropertyName = "website";
            this.website.HeaderText = "网址";
            this.website.Name = "website";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "联系电话";
            this.phone.Name = "phone";
            // 
            // fax
            // 
            this.fax.DataPropertyName = "fax";
            this.fax.HeaderText = "传真";
            this.fax.Name = "fax";
            // 
            // mobile
            // 
            this.mobile.DataPropertyName = "mobile";
            this.mobile.HeaderText = "手机";
            this.mobile.Name = "mobile";
            // 
            // homephone
            // 
            this.homephone.DataPropertyName = "homephone";
            this.homephone.HeaderText = "家庭电话";
            this.homephone.Name = "homephone";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "邮箱";
            this.email.Name = "email";
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "备注";
            this.description.Name = "description";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomerToolStripMenuItem,
            this.TaskToolStripMenuItem,
            this.其他ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(792, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // CustomerToolStripMenuItem
            // 
            this.CustomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addcustomerToolStripMenuItem});
            this.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem";
            this.CustomerToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.CustomerToolStripMenuItem.Text = "客户";
            // 
            // addcustomerToolStripMenuItem
            // 
            this.addcustomerToolStripMenuItem.Name = "addcustomerToolStripMenuItem";
            this.addcustomerToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+R";
            this.addcustomerToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addcustomerToolStripMenuItem.Text = "添加客户";
            // 
            // TaskToolStripMenuItem
            // 
            this.TaskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTaskToolStripMenuItem,
            this.ViewTaskListToolStripMenuItem});
            this.TaskToolStripMenuItem.Name = "TaskToolStripMenuItem";
            this.TaskToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.TaskToolStripMenuItem.Text = "任务";
            // 
            // AddTaskToolStripMenuItem
            // 
            this.AddTaskToolStripMenuItem.Name = "AddTaskToolStripMenuItem";
            this.AddTaskToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+T";
            this.AddTaskToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.AddTaskToolStripMenuItem.Text = "添加任务";
            // 
            // ViewTaskListToolStripMenuItem
            // 
            this.ViewTaskListToolStripMenuItem.Name = "ViewTaskListToolStripMenuItem";
            this.ViewTaskListToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ViewTaskListToolStripMenuItem.Text = "查看任务列表";
            // 
            // 其他ToolStripMenuItem
            // 
            this.其他ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchToolStripMenuItem});
            this.其他ToolStripMenuItem.Name = "其他ToolStripMenuItem";
            this.其他ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.其他ToolStripMenuItem.Text = "其他";
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.SearchToolStripMenuItem.Text = "查找";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // customergv_contextmenu
            // 
            this.customergv_contextmenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.EditCustomermenuItem,
            this.DeleteCustomermenuItem});
            // 
            // EditCustomermenuItem
            // 
            this.EditCustomermenuItem.Index = 0;
            this.EditCustomermenuItem.Text = "修改";
            this.EditCustomermenuItem.Click += new System.EventHandler(this.EditCustomermenuItem_Click);
            // 
            // DeleteCustomermenuItem
            // 
            this.DeleteCustomermenuItem.Index = 1;
            this.DeleteCustomermenuItem.Text = "删除";
            this.DeleteCustomermenuItem.Click += new System.EventHandler(this.DeleteCustomermenuItem_Click);
            // 
            // ctxmenuitem_addcustomer
            // 
            this.ctxmenuitem_addcustomer.Name = "ctxmenuitem_addcustomer";
            this.ctxmenuitem_addcustomer.Size = new System.Drawing.Size(32, 19);
            // 
            // ctxmenu_editcustomer
            // 
            this.ctxmenu_editcustomer.Name = "ctxmenu_editcustomer";
            this.ctxmenu_editcustomer.Size = new System.Drawing.Size(32, 19);
            // 
            // ctxmenu_deletecustomer
            // 
            this.ctxmenu_deletecustomer.Name = "ctxmenu_deletecustomer";
            this.ctxmenu_deletecustomer.Size = new System.Drawing.Size(32, 19);
            // 
            // AddCustomerTool
            // 
            this.AddCustomerTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddCustomerTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddCustomerTool.Name = "AddCustomerTool";
            this.AddCustomerTool.Size = new System.Drawing.Size(23, 22);
            this.AddCustomerTool.Text = "添加客户";
            this.AddCustomerTool.Click += new System.EventHandler(this.AddCustomertoolStripButton_Click);
            // 
            // tool_find
            // 
            this.tool_find.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_find.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_find.Name = "tool_find";
            this.tool_find.Size = new System.Drawing.Size(23, 22);
            this.tool_find.Text = "查找";
            this.tool_find.ToolTipText = "查找";
            // 
            // tool_addcustomer
            // 
            this.tool_addcustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_addcustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_addcustomer.Name = "tool_addcustomer";
            this.tool_addcustomer.Size = new System.Drawing.Size(23, 22);
            this.tool_addcustomer.Text = "toolStripButton1";
            this.tool_addcustomer.ToolTipText = "添加客户";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // addTskToolStripMenuItem
            // 
            this.addTskToolStripMenuItem.Name = "addTskToolStripMenuItem";
            this.addTskToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addTskToolStripMenuItem.Text = "添加任务";
            // 
            // 客户ToolStripMenuItem
            // 
            this.客户ToolStripMenuItem.Name = "客户ToolStripMenuItem";
            this.客户ToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.客户ToolStripMenuItem.Text = "客户";
            // 
            // 添加客户信息ToolStripMenuItem
            // 
            this.添加客户信息ToolStripMenuItem.Name = "添加客户信息ToolStripMenuItem";
            this.添加客户信息ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.添加客户信息ToolStripMenuItem.Text = "添加客户信息";
            // 
            // 客户信息详情ToolStripMenuItem
            // 
            this.客户信息详情ToolStripMenuItem.Name = "客户信息详情ToolStripMenuItem";
            this.客户信息详情ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.客户信息详情ToolStripMenuItem.Text = "客户信息详情";
            // 
            // 修改客户信息ToolStripMenuItem
            // 
            this.修改客户信息ToolStripMenuItem.Name = "修改客户信息ToolStripMenuItem";
            this.修改客户信息ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.修改客户信息ToolStripMenuItem.Text = "修改客户信息";
            // 
            // 查找客户信息ToolStripMenuItem
            // 
            this.查找客户信息ToolStripMenuItem.Name = "查找客户信息ToolStripMenuItem";
            this.查找客户信息ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.查找客户信息ToolStripMenuItem.Text = "查找客户信息";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ni_reminder
            // 
            this.ni_reminder.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ni_reminder.Icon = ((System.Drawing.Icon)(resources.GetObject("ni_reminder.Icon")));
            this.ni_reminder.Text = "notifyIcon1";
            this.ni_reminder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ni_reminder_MouseDoubleClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 570);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "Main";
            this.Deactivate += new System.EventHandler(this.Main_Deactivate);
            this.Load += new System.EventHandler(this.Main_Load);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_customer)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem addTskToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton AddCustomerTool;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.ToolStripButton tool_find;
        private System.Windows.Forms.ToolStripButton tool_addcustomer;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem 客户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加客户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户信息详情ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改客户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找客户信息ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem CustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TaskToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem addcustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewTaskListToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton AddCustomertoolStripButton;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton AddTasktoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton SearchtoolStripButton;
        private System.Windows.Forms.ToolStripButton TaskListtoolStripButton;
        private System.Windows.Forms.ContextMenu customergv_contextmenu;
        private System.Windows.Forms.ToolStripMenuItem ctxmenuitem_addcustomer;
        private System.Windows.Forms.ToolStripMenuItem ctxmenu_editcustomer;
        private System.Windows.Forms.ToolStripMenuItem ctxmenu_deletecustomer;
        private System.Windows.Forms.MenuItem EditCustomermenuItem;
        private System.Windows.Forms.MenuItem DeleteCustomermenuItem;
        private ToolStripButton logoff_toolStripButton;
        private DataGridViewButtonColumn btn_delete;
        private DataGridViewTextBoxColumn CID;
        private DataGridViewTextBoxColumn customername;
        private DataGridViewComboBoxColumn gender;
        private DataGridViewTextBoxColumn companyname;
        private DataGridViewTextBoxColumn department;
        private DataGridViewTextBoxColumn position;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn zip;
        private DataGridViewTextBoxColumn website;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn fax;
        private DataGridViewTextBoxColumn mobile;
        private DataGridViewTextBoxColumn homephone;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn description;
        private DataGridView gv_customer;
        private Label lbl_currenttime;
        private Timer timer;
        private NotifyIcon ni_reminder;
    }
}



