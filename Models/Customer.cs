using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
namespace Models
{
    [DataContract]
    public class Customer:Model
    {
        public Customer()
        {
            this.TaskList = new List<Task>();
            this.Owner = new User();
        }
        [DataMember]
        public int CID{get;set;}
        [DataMember]
        public String CustomerName { get; set; }
        [DataMember]
        public Boolean Gender { get; set; }
        [DataMember]
        public String CompanyName{get;set;}
        [DataMember]
        public String Address{get;set;}
        [DataMember]
        public String Department{get;set;}
        [DataMember]
        public String Position{get;set;}
        [DataMember]
        public String WebSite{get;set;}
        //public String Category{get;set;}
        [DataMember]
        public String Phone{get;set;}
        [DataMember]
        public String Zip{get;set;}
        [DataMember]
        public String Email{get;set;}
        [DataMember]
        public String Mobile{get;set;}
        [DataMember]
        public String Fax{get;set;}
        [DataMember]
        public String HomePhone{get;set;}
        [DataMember]
        public String Description{get;set;}
        [DataMember]
        public User Owner { get; set; }
        [DataMember]
        public IList<Task> TaskList{ get; set; }
    }
}
