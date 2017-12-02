using System.Runtime.Serialization;

namespace Dragon.DTO
{
    [DataContract]
    public class Position
    {
        [DataMember]
        public string PositionX { get; set; }
        [DataMember]
        public string PositionY { get; set; }
    }
}
