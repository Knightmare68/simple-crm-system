namespace ServerHost
{
    partial class CurrentOnLineForm
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
            this.dgv_currentuser = new System.Windows.Forms.DataGridView();
            this.offline = new System.Windows.Forms.DataGridViewButtonColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_currentuser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_currentuser
            // 
            this.dgv_currentuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_currentuser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.offline,
            this.username});
            this.dgv_currentuser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_currentuser.Location = new System.Drawing.Point(0, 0);
            this.dgv_currentuser.Name = "dgv_currentuser";
            this.dgv_currentuser.RowTemplate.Height = 23;
            this.dgv_currentuser.Size = new System.Drawing.Size(492, 373);
            this.dgv_currentuser.TabIndex = 0;
            // 
            // offline
            // 
            this.offline.HeaderText = "";
            this.offline.Name = "offline";
            this.offline.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.offline.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.offline.Text = "离线";
            this.offline.UseColumnTextForButtonValue = true;
            this.offline.Width = 50;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "用户名";
            this.username.Name = "username";
            // 
            // CurrentOnLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 373);
            this.Controls.Add(this.dgv_currentuser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CurrentOnLineForm";
            this.ShowIcon = false;
            this.Text = "CurrentOnLineForm";
            this.Load += new System.EventHandler(this.CurrentOnLineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_currentuser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_currentuser;
        private System.Windows.Forms.DataGridViewButtonColumn offline;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
    }
}