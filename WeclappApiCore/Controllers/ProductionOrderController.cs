using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WeclappApiCore.Controllers
{
    public class ProductionOrderController : ApiController
    {
        // GET: api/ProductionOrder
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ProductionOrder/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ProductionOrder
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProductionOrder/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProductionOrder/5
        public void Delete(int id)
        {
        }
    }
}
