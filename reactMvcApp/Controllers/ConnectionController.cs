using System;
using Microsoft.AspNetCore.Mvc;
using MovieInterface.Service.Interface;

namespace reactMvcApp.Controllers
{
    [Route("api/[controller]")]
    public class ConnectionController : Controller
    {
        private readonly IMongoConnections _mongoConnections;

        public ConnectionController(IMongoConnections mongoConnections)
        {
            _mongoConnections = mongoConnections;

        }
        // GET api/values
        [HttpGet("testDb")]
        public Boolean Get()
        {

            return _mongoConnections.checkMongoConnections();
        }

    }
}
