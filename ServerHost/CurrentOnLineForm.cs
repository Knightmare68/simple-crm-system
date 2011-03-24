using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CRM;

namespace ServerHost
{
    public partial class CurrentOnLineForm : Form
    {
        CRMService service = new CRMService();
        public CurrentOnLineForm()
        {
            InitializeComponent();
        }

        private void CurrentOnLineForm_Load(object sender, EventArgs e)
        {
            this.dgv_currentuser.AutoGenerateColumns = false;
            this.dgv_currentuser.DataSource = service.userdatalayer.GetLoginedUser();
        }
    }
}
