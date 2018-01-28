using BeerProxyServer.Interface;
using BeerProxyServer.ProxyClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BeerProxyApi.Controllers
{
    public class BeerController : ApiController
    {
        // GET api/values

        IBeer proxyBeerClient = new BeerProxyClient();
        string serializeResult = "";
        public string Get()
        {
            serializeResult = proxyBeerClient.Get();
            return serializeResult;
        }

        // GET api/values/5
        public string Get(string id)
        {
            serializeResult = proxyBeerClient.Get(id);
            return serializeResult;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
