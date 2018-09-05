using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WeclappApiCore.Controllers
{
    public class commercialLanguageController : ApiController
    {
        // GET: api/commercialLanguage
        public commercialLanguage Get()
        {
            commercialLanguage com = new commercialLanguage();
            com.countryCode = "92";
           
            return com;
        }

        // GET: api/commercialLanguage/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/commercialLanguage
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/commercialLanguage/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/commercialLanguage/5
        public void Delete(int id)
        {
        }
    }
}
