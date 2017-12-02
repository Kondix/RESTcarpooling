using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;

namespace Dragon.DTO
{
    [DataContract]
    public class Journey
    {
        [DataMember]
        public List<int> UsersIds { get; set; }
        [DataMember]
        public int JourneyId { get; set; }
        [DataMember]
        public bool IsDriver { get; set; }
        [DataMember]
        public int RouteId { get; set; }
    }
}
