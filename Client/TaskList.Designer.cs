namespace Client
{
    partial class TaskList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_tasklist = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tasklist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tasklist
            // 
            this.dgv_tasklist.AllowUserToAddRows = false;
            this.dgv_tasklist.AllowUserToDeleteRows = false;
            this.dgv_tasklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tasklist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete,
            this.id,
            this.TaskName,
            this.customer,
            this.starttime,
            this.endtime});
            this.dgv_tasklist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tasklist.Location = new System.Drawing.Point(0, 0);
            this.dgv_tasklist.Name = "dgv_tasklist";
            this.dgv_tasklist.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tasklist.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tasklist.RowTemplate.Height = 23;
            this.dgv_tasklist.Size = new System.Drawing.Size(503, 383);
            this.dgv_tasklist.TabIndex = 0;
            this.dgv_tasklist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tasklist_CellClick);
            // 
            // delete
            // 
            this.delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete.Text = "删除";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 50;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // TaskName
            // 
            this.TaskName.DataPropertyName = "description";
            this.TaskName.HeaderText = "任务";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            // 
            // customer
            // 
            this.customer.HeaderText = "客户";
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            // 
            // starttime
            // 
            this.starttime.DataPropertyName = "starttime";
            this.starttime.HeaderText = "开始时间";
            this.starttime.Name = "starttime";
            this.starttime.ReadOnly = true;
            // 
            // endtime
            // 
            this.endtime.DataPropertyName = "endtime";
            this.endtime.HeaderText = "结束时间";
            this.endtime.Name = "endtime";
            this.endtime.ReadOnly = true;
            // 
            // TaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 383);
            this.Controls.Add(this.dgv_tasklist);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskList";
            this.ShowIcon = false;
            this.Text = "任务列表";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tasklist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tasklist;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtime;

    }
}