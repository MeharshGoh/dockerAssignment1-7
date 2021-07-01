using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicetwo.Models;

namespace Servicetwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {

        DoctorDb db;

        public DoctorController()
        {
            db = new DoctorDb();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db);
        }
    }
}
