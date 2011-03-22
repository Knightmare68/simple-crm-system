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
    public partial class EditCustomer : Form
    {
        CustomerInfor cinfor = new CustomerInfor();
        public EditCustomer(Customer c)
        {
            InitializeComponent();           
            cinfor.SetValue(c);
            this.Controls.Add(cinfor);
        }
    }
}
