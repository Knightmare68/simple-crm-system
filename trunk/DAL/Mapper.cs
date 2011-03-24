using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    using Models;
    public class Mapper
    {
        public static Customer Map(CRMDataSet.customerRow row)
        {
            if (row == null)
            {
                return null;
            }
            Customer c = new Customer();
            c.CID = row.cid;
            c.CustomerName = row.customername;
            c.CompanyName = row.companyname;
            c.Description = row.description;
            c.Department = row.department;
            c.Email = row.email;
            c.Gender = row.gender;
            c.Mobile = row.mobile;
            c.Phone = row.phone;
            c.Position = row.position;
            c.Zip = row.zip;
            c.WebSite = row.website;
            c.HomePhone = row.homephone;
            foreach (CRMDataSet.tasksRow task in row.GettasksRows())
            {
                Task t = new Task();
                t.ID = task.id;
                t.Starttime = task.starttime;
                t.EndTime = task.endtime;
                t.Description = task.description;
                User u = new User();
                u.UserName = task.userRow.username;
                u.Password = task.userRow.password;
                u.Description = task.userRow.description;
                u.Role = task.userRow.role;
                t.User = u;
                c.TaskList.Add(t);
            }
            
            return c;
        }

        public static User Map(CRMDataSet.userRow row)
        {
            if (row == null)
            {
                return null;
            }
            User u = new User();
            u.UserName = row.username;
            u.Password = row.password;
            u.Description = row.description;
            u.Status = row.status;
            u.Role = row.role;
            foreach (CRMDataSet.tasksRow task in row.GettasksRows())
            {
                Task t = new Task();
                t.ID = task.id;
                t.Starttime = task.starttime;
                t.EndTime = task.endtime;
                t.Description = task.description;
                t.User = u;
                u.TaskList.Add(t);
            }
            return u;
        }
        public static IList<User> Map(CRMDataSet.userDataTable datatable)
        {
            if (datatable== null)
            {
                return null;
            }
            List<User> result = new List<User>();
            foreach (CRMDataSet.userRow row in datatable.Rows)
            {
                User u =Mapper.Map(row);
                result.Add(u);
            }
            return result;
        }
        public static Task Map(CRMDataSet.tasksRow row)
        {
            if (row == null)
            {
                return null;
            }
            Task t = new Task();
            t.ID = row.id;
            t.Customer = Map(row.customerRow);
            t.Description = row.description;
            t.EndTime = row.endtime;
            t.Starttime = row.starttime;
            t.Status = row.status;
            t.User = Map(row.userRow);
            return t;
        }
    }
}
