using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;

namespace Client
{
    using CRM;
    public partial class CustomerInfor : UserControl
    {
        enum Status { NEW, EDIT };
        private Status curstatus = Status.NEW;
        private Customer curcsinfor;
        public CustomerInfor()
        {
            InitializeComponent();
            this.Load += new EventHandler(CustomerInfor_Load);
        }

        void CustomerInfor_Load(object sender, EventArgs e)
        {
            BindingList<ComboxItem> source = new BindingList<ComboxItem>();
            source.Add(new ComboxItem("男", true));
            source.Add(new ComboxItem("女", false));
            this.cbx_gender.DataSource = source;
            this.cbx_gender.DisplayMember = "Name";
            this.cbx_gender.ValueMember = "Value";
            //this.cbx_gender.Items.Add()
            //throw new NotImplementedException();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.CustomerName = this.txt_customername.Text;
            c.Address = this.txt_companyaddress.Text;
            c.CompanyName = this.txt_companyname.Text;
            c.Department = this.txt_department.Text;
            c.Description = this.txt_description.Text;
            c.Email = this.txt_email.Text;
            c.Fax = this.txt_fax.Text;
            c.Gender = Convert.ToBoolean(this.cbx_gender.SelectedValue);
            c.HomePhone = this.txt_homephone.Text;
            c.Mobile = this.txt_mobile.Text;
            c.Owner.UserName = GlobalData.GetInstance().ShareData["User"].ToString();
            c.Phone = this.txt_phone.Text;
            c.Position = this.txt_position.Text;
            c.WebSite = this.txt_website.Text;
            c.Zip = this.txt_zip.Text;

           if (curstatus== Status.EDIT)
           {
               c.CID = curcsinfor.CID;
               ClientProxy.GetInstance().GetCustomerServcie.UpdateCustomer(c);
           }
           else if(curstatus== Status.NEW)
           {
                ClientProxy.GetInstance().GetCustomerService().AddCustomer(c);
           }
           this.ParentForm.Close();
           (FormManager.GetInstance().GetFormByName(typeof(Main).ToString()) 
               as Main).RefreshData();
        }

        public void SetValue(Customer c)
        {
            this.curstatus = Status.EDIT;
            curcsinfor = c;
            this.txt_customername.Text = c.CustomerName;
            this.txt_department.Text = c.Department;
            this.txt_companyaddress.Text = c.Address;
            this.txt_companyname.Text = c.CompanyName;
            this.txt_description.Text = c.Description;
            this.txt_email.Text = c.Email;
            this.txt_fax.Text = c.Fax;
            this.txt_homephone.Text = c.HomePhone;
            this.txt_mobile.Text = c.Mobile;
            this.txt_position.Text = c.Position;
            this.txt_website.Text = c.WebSite;
            this.txt_zip.Text = c.Zip;
            this.txt_phone.Text = c.Phone;
            this.cbx_gender.SelectedValue = c.Gender;

        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
