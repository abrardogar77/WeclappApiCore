using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WeclappApiCore.Controllers
{
    public class TaxController : ApiController
    {
        // GET: api/Tax
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Tax/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tax
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Tax/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Tax/5
        public void Delete(int id)
        {
        }
    }
}
