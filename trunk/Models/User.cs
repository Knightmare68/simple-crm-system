using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
namespace Models
{
    [DataContract]
    public class User:Model
    {

        public static String LOGINED= "Logined";
        public static String LOGOFF= "Logoff";
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
        public int Role { get; set; }
        [DataMember]
        public IList<Task> TaskList{ get; set; }
        [DataMember]
        public String Status{ get; set; }

    }

}
