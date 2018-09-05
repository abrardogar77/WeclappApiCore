using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WeclappApiCore.Controllers
{
    public class SalesChannelController : ApiController
    {
        // GET: api/SalesChannel
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SalesChannel/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SalesChannel
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SalesChannel/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SalesChannel/5
        public void Delete(int id)
        {
        }
    }
}
