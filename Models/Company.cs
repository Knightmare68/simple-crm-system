using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
namespace Models
{
    [DataContract]
    public class Company:Model
    {
        [DataMember]
        public string CompanyID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public String Description { get; set; }
    }
}
