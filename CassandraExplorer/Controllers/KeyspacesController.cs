using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CassandraExplorer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CassandraExplorer.Controllers
{
    [Route("api/[controller]")]
    public class KeyspacesController : Controller
    {
        private readonly ICassandraService _cassandraService;

        public KeyspacesController(ICassandraService cassandraService)
        {
            _cassandraService = cassandraService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var keyspaces = await _cassandraService.GetKeyspaces();
            return Ok(keyspaces);
        }
    }
}