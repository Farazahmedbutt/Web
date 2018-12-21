using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Webapi.Controllers
{
    [System.Web.Mvc.Route("api/[AssignmentController]")
         ]
    public class AssignmentController : ApiController
    {
        public void Post([FromBody]string value)
        { }
        public void Put(int id, [FromBody]string value)
        { }
        public void Delete(int id)
        { }
        protected  void Executecore()
        {
            throw new NotImplementedException();
        }


    }
}
