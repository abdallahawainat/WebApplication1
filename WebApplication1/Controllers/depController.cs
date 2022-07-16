using learn.core.Data;
using learn.core.service;
using learn.infra.service;
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
    public class depController : ControllerBase
    {
      
        private readonly Idep_apiservice dservice;
        public depController(Idep_apiservice d)
        {
            this.dservice = d;
        }
        [HttpPost]//insert new record in database
        public ActionResult createinsertdep([FromBody] dep_api cc)
        {
            
            return Ok(dservice.createinsertdep(cc));
        }
        [HttpDelete("delete/{id}")] //delete record from database
        public ActionResult deletedep(int id)
        {

            return Ok(this.dservice.deletedep(id));
        }
        [HttpGet]//retrevie all data
        public ActionResult department()
        {
            return Ok(dservice.getalldep());
        }
        [HttpGet("{id}")] // retrive data by id
        public ActionResult department(int id)
        {

            return Ok(dservice.getbyid(id));
        }
      
    }
}
