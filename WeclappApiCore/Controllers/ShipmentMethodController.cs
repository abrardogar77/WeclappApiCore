using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WeclappApiCore.Controllers
{
    public class ShipmentMethodController : ApiController
    {
        // GET: api/shipmentMethod
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/shipmentMethod/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/shipmentMethod
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/shipmentMethod/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/shipmentMethod/5
        public void Delete(int id)
        {
        }
    }
}
