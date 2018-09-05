using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WeclappApiCore.Controllers
{
    public class SectorController : ApiController
    {
        // GET: api/Sector
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Sector/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Sector
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Sector/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Sector/5
        public void Delete(int id)
        {
        }
    }
}
