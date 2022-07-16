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
    public class taskController : ControllerBase
    {
        private readonly Itask_apiservice tservice;
        public taskController(Itask_apiservice tservice)
        {
            this.tservice = tservice;
        }
        [HttpPost]//insert new record in database
        public ActionResult createinserttask([FromBody] task_api t)
        {

            return Ok(tservice.createinserttask(t));
        }

        [HttpDelete("delete/{id}")] //delete record from database
        public ActionResult deletetask(int id)
        {

            return Ok(this.tservice.deletetask(id));
        }
        [HttpGet]//retrevie all data
        public ActionResult task()
        {
            return Ok(tservice.getalltask());
        }
        [HttpGet("{id}")] // retrive data by id
        public IActionResult task(int id)
        {

            return Ok(tservice.getbyid(id));
        }
    }
}
