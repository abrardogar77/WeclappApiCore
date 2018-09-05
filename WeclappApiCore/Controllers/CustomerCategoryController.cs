using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WeclappApiCore.Controllers
{
    public class CustomerCategoryController : ApiController
    {
        // GET: api/CustomerCategory
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CustomerCategory/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CustomerCategory
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CustomerCategory/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CustomerCategory/5
        public void Delete(int id)
        {
        }
    }
}
