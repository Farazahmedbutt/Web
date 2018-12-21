using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Webapi.Controllers
{
    [System.Web.Mvc.Route("api/[CourseController]")
            ]
    public class CourseController : ApiController
    {
        public IEnumerable<string> GET()
        {
            return new string[] { "value1", "value2" };

        }
        public string Get(int id)
        {
            return "value";
        }
        public void POST([FromBody]string value)
        {
        }
        public void Put(int id, [FromBody]string value)
        { }
        public void Delete(int id)
        {

        } 
    }
}
