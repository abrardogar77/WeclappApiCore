using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WeclappApiCore.Controllers
{
    public class TermOfPaymentController : ApiController
    {
        // GET: api/TermOfPayment
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TermOfPayment/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TermOfPayment
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TermOfPayment/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TermOfPayment/5
        public void Delete(int id)
        {
        }
    }
}
