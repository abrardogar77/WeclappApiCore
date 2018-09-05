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
        // GET: api/ShipmentMethod
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ShipmentMethod/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ShipmentMethod
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ShipmentMethod/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ShipmentMethod/5
        public void Delete(int id)
        {
        }
    }
}
