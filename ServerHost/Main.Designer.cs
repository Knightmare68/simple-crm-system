using ServerHost.Properties;
namespace ServerHost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.serverstatuslist = new System.Windows.Forms.ListBox();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.服务器状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.port = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.serverstatuslist);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // serverstatuslist
            // 
            this.serverstatuslist.FormattingEnabled = true;
            resources.ApplyResources(this.serverstatuslist, "serverstatuslist");
            this.serverstatuslist.Name = "serverstatuslist";
            this.serverstatuslist.SelectionMode = System.Windows.Forms.SelectionMode.None;
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            resources.ApplyResources(this.StatusBar, "StatusBar");
            this.StatusBar.Name = "StatusBar";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            resources.ApplyResources(this.StatusLabel, "StatusLabel");
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.信息ToolStripMenuItem});
            resources.ApplyResources(this.MenuStrip, "MenuStrip");
            this.MenuStrip.Name = "MenuStrip";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.启动服务器ToolStripMenuItem,
            this.停止服务器ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            resources.ApplyResources(this.菜单ToolStripMenuItem, "菜单ToolStripMenuItem");
            // 
            // 启动服务器ToolStripMenuItem
            // 
            this.启动服务器ToolStripMenuItem.Name = "启动服务器ToolStripMenuItem";
            resources.ApplyResources(this.启动服务器ToolStripMenuItem, "启动服务器ToolStripMenuItem");
            // 
            // 停止服务器ToolStripMenuItem
            // 
            this.停止服务器ToolStripMenuItem.Name = "停止服务器ToolStripMenuItem";
            resources.ApplyResources(this.停止服务器ToolStripMenuItem, "停止服务器ToolStripMenuItem");
            // 
            // 信息ToolStripMenuItem
            // 
            this.信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.服务器状态ToolStripMenuItem});
            this.信息ToolStripMenuItem.Name = "信息ToolStripMenuItem";
            resources.ApplyResources(this.信息ToolStripMenuItem, "信息ToolStripMenuItem");
            // 
            // 服务器状态ToolStripMenuItem
            // 
            this.服务器状态ToolStripMenuItem.Name = "服务器状态ToolStripMenuItem";
            resources.ApplyResources(this.服务器状态ToolStripMenuItem, "服务器状态ToolStripMenuItem");
            // 
            // btn_start
            // 
            resources.ApplyResources(this.btn_start, "btn_start");
            this.btn_start.Name = "btn_start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            resources.ApplyResources(this.btn_stop, "btn_stop");
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.port);
            this.panel2.Controls.Add(this.txt_port);
            this.panel2.Controls.Add(this.btn_start);
            this.panel2.Controls.Add(this.btn_stop);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ServerHost.Properties.Resources.red;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // port
            // 
            resources.ApplyResources(this.port, "port");
            this.port.Name = "port";
            // 
            // txt_port
            // 
            resources.ApplyResources(this.txt_port, "txt_port");
            this.txt_port.Name = "txt_port";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.panel1);
            this.Icon = global::ServerHost.Properties.Resources.apptitle;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.panel1.ResumeLayout(false);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启动服务器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止服务器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 服务器状态ToolStripMenuItem;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label port;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox serverstatuslist;



    }
}

