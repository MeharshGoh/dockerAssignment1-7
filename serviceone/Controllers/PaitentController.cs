using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serviceone.Models;

namespace Serviceone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaitentController : ControllerBase
    {
        PaitentDb db;

        public PaitentController()
        {
            db = new PaitentDb();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db);
        }
    }
}
