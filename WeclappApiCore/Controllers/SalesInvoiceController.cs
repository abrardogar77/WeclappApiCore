using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WeclappApiCore.Controllers
{
    public class SalesInvoiceController : ApiController
    {
        // GET: api/SalesInvoice
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SalesInvoice/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SalesInvoice
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SalesInvoice/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SalesInvoice/5
        public void Delete(int id)
        {
        }
    }
}
