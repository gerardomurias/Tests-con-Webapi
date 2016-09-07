using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OtraPruebaWebApi.Controllers
{
    public class PruebaController : ApiController
    {
        [ActionName("getprincipal")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [ActionName("getaverquepasa")]
        public IEnumerable<string> GetOther()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [ActionName("httpresponse")]
        public HttpResponseMessage ActionWithHttpResponse()
        {
            var instance = new DummyTestClass
            {
                Id = 1,
                Name = "prueba"
            };

            return Request.CreateResponse(HttpStatusCode.OK, instance);
        }
    }

    public class DummyTestClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}