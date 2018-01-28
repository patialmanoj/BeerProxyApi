using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BeerProxyServer.DTO
{
    [DataContract]
    public class BeerInfo
    {

        [DataMember(Name = "abv")]
        public string Abv { get; set; }
        [DataMember(Name = "createDate")]
        public string CreateDate { get; set; }
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [DataMember(Name = "glass")]
        public LabelInfo Glass { get; set; }
        [DataMember(Name = "glassWareId")]
        public string GlassWareId { get; set; }
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "isOrganic")]
        public string IsOrganic { set; get; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "nameDisplay")]
        public string NameDisplay { get; set; }
        [DataMember(Name = "srm")]
        public HexInfo Srm { set; get; }
        [DataMember(Name = "srmId")]
        public Int32 SrmId { set; get; }
        [DataMember(Name = "status")]
        public string Status { set; get; }
        [DataMember(Name = "statusDisplay")]
        public string StatusDisplay { set; get; }
        [DataMember(Name = "style")]
        public StyleInfo Style { get; set; }
        [DataMember(Name = "styleId")]
        public string StyleId { get; set; }
        [DataMember(Name = "updateDate")]
        public string UpdateDate { get; set; }
    }
}
