using learn.core.Data;
using learn.core.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class emptaskController : ControllerBase
    {
        private readonly Iemptaskservice emptask;
        public emptaskController(Iemptaskservice emptask)
        {
            this.emptask = emptask;
        }
        [HttpPost]//insert new record in database
        public ActionResult createinsertemployeetask([FromBody] employee_task_api t)
        {

            return Ok(emptask.createinsertemployeetask(t));
        }

        [HttpDelete("delete/{id}")] //delete record from database
        public ActionResult deleteemployeetask(int id)
        {

            return Ok(this.emptask.deleteemployeetask(id));
        }
        [HttpGet]//retrevie all data
        public ActionResult task()
        {
            return Ok(emptask.getallemployeetask());
        }
        [HttpGet("{id}")] // retrive data by id
        public IActionResult task(int id)
        {

            return Ok(emptask.getbyid(id));
        }
    }
}
