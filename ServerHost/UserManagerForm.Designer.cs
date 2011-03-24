namespace ServerHost
{
    partial class UserManagerForm
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
            this.dgv_userlist = new System.Windows.Forms.DataGridView();
            this.deletebuttoncolumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btn_adduser = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_role = new System.Windows.Forms.Label();
            this.cbx_role = new System.Windows.Forms.ComboBox();
            this.offline = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userlist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_userlist
            // 
            this.dgv_userlist.AllowUserToAddRows = false;
            this.dgv_userlist.AllowUserToDeleteRows = false;
            this.dgv_userlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_userlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deletebuttoncolumn,
            this.username,
            this.password,
            this.description,
            this.role});
            this.dgv_userlist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_userlist.Location = new System.Drawing.Point(0, 165);
            this.dgv_userlist.Name = "dgv_userlist";
            this.dgv_userlist.RowTemplate.Height = 23;
            this.dgv_userlist.Size = new System.Drawing.Size(512, 208);
            this.dgv_userlist.TabIndex = 1;
            this.dgv_userlist.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_userlist_CellEndEdit);
            this.dgv_userlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_userlist_CellClick);
            // 
            // deletebuttoncolumn
            // 
            this.deletebuttoncolumn.HeaderText = "";
            this.deletebuttoncolumn.Name = "deletebuttoncolumn";
            this.deletebuttoncolumn.UseColumnTextForButtonValue = true;
            this.deletebuttoncolumn.Text = "删除";
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "用户名";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "密码";
            this.password.Name = "password";
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "描述";
            this.description.Name = "description";
            // 
            // role
            // 
            this.role.HeaderText = "角色";
            this.role.Name = "role";
            // 
            // btn_adduser
            // 
            this.btn_adduser.Location = new System.Drawing.Point(74, 136);
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Size = new System.Drawing.Size(75, 23);
            this.btn_adduser.TabIndex = 2;
            this.btn_adduser.Text = "添加";
            this.btn_adduser.UseVisualStyleBackColor = true;
            this.btn_adduser.Click += new System.EventHandler(this.btn_adduser_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(74, 12);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(138, 21);
            this.txt_username.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "用户名";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(12, 47);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(29, 12);
            this.lbl_password.TabIndex = 5;
            this.lbl_password.Text = "密码";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(74, 44);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(138, 21);
            this.txt_password.TabIndex = 6;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(74, 71);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(314, 59);
            this.txt_description.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "描述";
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Location = new System.Drawing.Point(232, 15);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(29, 12);
            this.lbl_role.TabIndex = 9;
            this.lbl_role.Text = "角色";
            // 
            // cbx_role
            // 
            this.cbx_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_role.FormattingEnabled = true;
            this.cbx_role.Location = new System.Drawing.Point(267, 12);
            this.cbx_role.Name = "cbx_role";
            this.cbx_role.Size = new System.Drawing.Size(121, 20);
            this.cbx_role.TabIndex = 10;
            // 
            // offline
            // 
            this.offline.HeaderText = "";
            this.offline.Name = "offline";
            this.offline.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.offline.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.offline.Text = "删除";
            this.offline.UseColumnTextForButtonValue = true;
            this.offline.Width = 50;
            // 
            // UserManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 373);
            this.Controls.Add(this.cbx_role);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_adduser);
            this.Controls.Add(this.dgv_userlist);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserManagerForm";
            this.ShowIcon = false;
            this.Text = "用户管理界面";
            this.Load += new System.EventHandler(this.UserManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_userlist;
        private System.Windows.Forms.Button btn_adduser;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.ComboBox cbx_role;
        private System.Windows.Forms.DataGridViewButtonColumn offline;
        private System.Windows.Forms.DataGridViewButtonColumn deletebuttoncolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewComboBoxColumn role;
    }
}