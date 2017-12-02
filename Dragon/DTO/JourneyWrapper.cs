using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Dragon.DTO
{
    [DataContract]
    public class JourneyWrapper
    {
        [DataMember]
        public List<User> Users { get; set; }

        [DataMember] public Route Route { get; set; }

        [DataMember] public int JourneyId { get; set; }

        [DataMember] public bool IsDriver { get; set; }
    }
}
