using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BeerProxyServer.DTO
{
    [DataContract]
    public class StyleInfo
    {
        [DataMember(Name = "abvMax")]
        public string AbvMax { set; get; }
        [DataMember(Name = "abvMin")]
        public string AbvMin { set; get; }
        [DataMember(Name = "category")]
        public LabelInfo Category { set; get; }
        [DataMember(Name = "categoryId")]
        public Int32 CategoryId { set; get; }
        [DataMember(Name = "createDate")]
        public string CreateDate { set; get; }
        [DataMember(Name = "description")]
        public string Description { set; get; }
        [DataMember(Name = "fgMax")]
        public string FgMax { set; get; }
        [DataMember(Name = "fgMin")]
        public string FgMin { set; get; }
        [DataMember(Name = "ibuMax")]
        public string IbuMax { set; get; }
        [DataMember(Name = "ibuMin")]
        public string IbuMin { set; get; }
        [DataMember(Name = "id")]
        public Int32 Id { set; get; }
        [DataMember(Name = "name")]
        public string Name { set; get; }
        [DataMember(Name = "ogMin")]
        public string OgMin { set; get; }
        [DataMember(Name = "shortName")]
        public string ShortName { set; get; }
        [DataMember(Name = "srmMax")]
        public string SrmMax { set; get; }
        [DataMember(Name = "srmMin")]
        public string SrmMin { set; get; }
        [DataMember(Name = "updateDate")]
        public string UpdateDate { set; get; }

    }
}
