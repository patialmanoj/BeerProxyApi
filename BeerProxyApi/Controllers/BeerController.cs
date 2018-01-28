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
        public IEnumerable<string> Get()
        {
            return new string[] { "beer1", "beer2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "beer";
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
