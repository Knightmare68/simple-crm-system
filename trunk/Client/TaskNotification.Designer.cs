namespace Client
{
    partial class TaskNotification
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_doneselected = new System.Windows.Forms.Button();
            this.btn_doneall = new System.Windows.Forms.Button();
            this.btn_cancelselected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(492, 220);
            this.listBox1.TabIndex = 0;
            // 
            // btn_doneselected
            // 
            this.btn_doneselected.Location = new System.Drawing.Point(23, 238);
            this.btn_doneselected.Name = "btn_doneselected";
            this.btn_doneselected.Size = new System.Drawing.Size(89, 23);
            this.btn_doneselected.TabIndex = 1;
            this.btn_doneselected.Text = "完成所选任务";
            this.btn_doneselected.UseVisualStyleBackColor = true;
            this.btn_doneselected.Click += new System.EventHandler(this.btn_doneselected_Click);
            // 
            // btn_doneall
            // 
            this.btn_doneall.Location = new System.Drawing.Point(380, 238);
            this.btn_doneall.Name = "btn_doneall";
            this.btn_doneall.Size = new System.Drawing.Size(75, 23);
            this.btn_doneall.TabIndex = 2;
            this.btn_doneall.Text = "完成所有";
            this.btn_doneall.UseVisualStyleBackColor = true;
            // 
            // btn_cancelselected
            // 
            this.btn_cancelselected.Location = new System.Drawing.Point(200, 238);
            this.btn_cancelselected.Name = "btn_cancelselected";
            this.btn_cancelselected.Size = new System.Drawing.Size(85, 23);
            this.btn_cancelselected.TabIndex = 3;
            this.btn_cancelselected.Text = "取消所选任务";
            this.btn_cancelselected.UseVisualStyleBackColor = true;
            // 
            // TaskNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 273);
            this.Controls.Add(this.btn_cancelselected);
            this.Controls.Add(this.btn_doneall);
            this.Controls.Add(this.btn_doneselected);
            this.Controls.Add(this.listBox1);
            this.Name = "TaskNotification";
            this.Text = "任务提醒";
            this.Load += new System.EventHandler(this.TaskNotification_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_doneselected;
        private System.Windows.Forms.Button btn_doneall;
        private System.Windows.Forms.Button btn_cancelselected;
    }
}