﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BeerProxyServer.DTO
{

    [DataContract]
    public class BeersResponseInfo
    {
        [DataMember(Name = "currentPage")]
        public Int32 CurrentPage { set; get; }
        [DataMember(Name = "data")]
        List<BeerInfo> Data { set; get; }
        [DataMember(Name = "numberOfPages")]
        public Int32 NumberOfPages { set; get; }
        [DataMember(Name = "status")]
        public string Status { set; get; }
        [DataMember(Name = "totalResults")]
        public Int32 TotalResults { set; get; }

    }
}
