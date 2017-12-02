using System.Runtime.Serialization;

namespace Dragon.DTO
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int UserId { get; set; }
    }
}