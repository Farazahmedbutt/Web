using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Webapi.Controllers
{
    [System.Web.Mvc.Route("api/[JoinController]")
           ]
    public class JoinController : ApiController
    {
        public void Post([FromBody]string value)
        { }
        protected override void Executecore()
        {
            throw new NotImplementedException();
        }
    }
}
