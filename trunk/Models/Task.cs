using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
namespace Models
{
    [DataContract]
    public class Task:Model
    {
        public static string Planned="Planned";
        public static string Finished= "Finished";
        public static string Hold= "Planned";
        public Task()
        {
            this.User = new User();
            this.Customer = new Customer();
        }
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public Customer Customer{get;set;}
        [DataMember]
        public DateTime Starttime { get; set; }
        [DataMember]
        public DateTime EndTime { get; set; }
        [DataMember]
        public String Description { get; set; }
        [DataMember]
        public User User{ get; set; }
        [DataMember]
        public String Status { get; set; }
    }
}
