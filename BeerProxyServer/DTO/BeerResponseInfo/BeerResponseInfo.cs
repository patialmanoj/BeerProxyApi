using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BeerProxyServer.DTO
{
    [DataContract]
    public class BeerResponseInfo
    {
        [DataMember(Name = "message")]
        public string Message { set; get; }
        [DataMember(Name = "status")]
        public string Status { set; get; }
        [DataMember(Name = "data")]
        public BeerInfo Data { set; get; }

    }
}
