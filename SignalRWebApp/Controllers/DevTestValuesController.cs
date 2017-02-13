using SignalRWebApp.Models;
using SignalRWebApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SignalRWebApp.Controllers
{
    public class DevTestValuesController : ApiController
    {
        DevTestRepo repo = new DevTestRepo();

        [Route("/api/DevTestValues/Get")]
        public IEnumerable<DevTestModel> Get()
        {
            return repo.GetData();
        }

    }
}