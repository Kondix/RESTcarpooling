using System.Runtime.Serialization;

namespace Dragon.DTO
{
    [DataContract]
    public class Route
    {
        [DataMember]
        public int Capacity { get; set; }
        [DataMember]
        public int RouteId { get; set; }
        [DataMember]
        public Position StartPosition { get; set; }
        [DataMember]
        public Position EndPosition { get; set; }
    }
}
