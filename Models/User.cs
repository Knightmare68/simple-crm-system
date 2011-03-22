using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
namespace Models
{
    public enum Role
    {
        Admin,
        Guest,
        PowerUser
    }
    [DataContract]
    public class User:Model
    {
        public User()
        {
            this.TaskList = new List<Task>();
        }
        [DataMember]
        public string UserName{get;set;}
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public Role CurrentRole { get; set; }
        [DataMember]
        public IList<Task> TaskList{ get; set; }

    }

}
