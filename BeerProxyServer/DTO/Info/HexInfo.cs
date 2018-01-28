using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BeerProxyServer.DTO
{
    [DataContract]
    public class HexInfo
    {
        [DataMember(Name = "id")]
        public Int32 Id { set; get; }
        [DataMember(Name = "name")]
        public string Name { set; get; }
        [DataMember(Name = "hex")]
        public string Hex { set; get; }
    }
}
