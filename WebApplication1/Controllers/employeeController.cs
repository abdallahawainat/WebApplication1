using learn.core.Data;
using learn.core.DTO;
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
    public class employeeController : ControllerBase
    {
        private readonly Iemployee_apiservice employeeservice;
        private readonly Iempinfo_dtoservice empinfoservice;
        public employeeController(Iemployee_apiservice employeeservice, Iempinfo_dtoservice empinfoservice)
        {
            this.employeeservice = employeeservice;
            this.empinfoservice = empinfoservice;
        }
        
       
        [HttpPost]//insert new record in database
        public ActionResult createinsertemployee([FromBody] employee_api e)
        {
            string[] arr = { "RASHEED JABER", "SAEED JARALLAH", "AHMED HASSAN", "BASIM BINSALEM", "OSAMA NASSER", "AHMED HASSAN"
                    ,"ZAIER DEEF","ABDULRAHIM ERMEET","NABIL MUIDH","OWAYED AWAD","NAIF ALI","GHAZI HASSAN","ABDULRAHIM HELAL",
                    "SALEH JOIBER","FARIS FRAIJ","AHMED GHURMULLAH","THAMER KHADIR","HASSAN HAMDI ABDULLAH","MOHAMMED MUNEER","KHALID MUBARAK"};
            Random rd = new Random();
            int a = 0;
            string str1 = " ";
            string str2 = " ";
            int t = 0;
            int rand_num = rd.Next(0, arr.Length);
            for (int i = 0; i < arr[rand_num].Length; i++)
            {

                a = arr[rand_num].IndexOf(' ');
                str1 = arr[rand_num].Substring(0, a);
                t = arr[rand_num].Length - a - 1;
                str2 = arr[rand_num].Substring(a + 1, t);
            }
            e.fname = str1;
            e.lname = str2;
            e.email = str1 + str2 + "@gmail.com";

            int randsalary = rd.Next(500, 1000);
            e.salary = randsalary;
            return Ok(employeeservice.createinsertemployee(e));

 
        }
        [HttpDelete("delete/{id}")] //delete record from database
        public ActionResult deleteemployee(int id)
        {

            return Ok(this.employeeservice.deleteemployee(id));
        }
        [HttpGet]//retrevie all data
        public ActionResult employee()
        {
            return Ok(employeeservice.getallemployee());
        }
        [HttpGet("{id}")] // retrive data by id
        public ActionResult employeebyid(int id)
        {

            return Ok(employeeservice.getbyid(id));
        }
        [HttpGet]
        [Route("countemp")]
        public ActionResult countemp() {
            return Ok(employeeservice.getallemployee().Count());
        }
        [HttpGet]
        [Route("sumsalary")]
        public ActionResult sumsalary()
        {
            return Ok(employeeservice.getallemployee().Sum(x=>x.salary));
        }
        [HttpGet]
        [Route("avgsalary")]
        public ActionResult avgsalary()
        {
            return Ok(employeeservice.getallemployee().Average(x => x.salary));
        }


        [HttpGet]//retrevie empinfo
        [Route("empinfo")]
        public List<empinfo_dto> empinfo()
        {
            return empinfoservice.getempinfo();
        }

        [HttpGet]//retrevie empinfo
        [Route("emptask")]
        public List<emptask_dto> emptask() {
            return empinfoservice.getemptask();
        }
        [HttpGet]//retrevie empinfo
        [Route("filtername/{ch}")]
        public ActionResult filtername( char ch) {
            return Ok(employeeservice.getallemployee().Where(x => x.fname.ToUpper().Contains(ch.ToString().ToUpper())));
        }
        [HttpGet]
        [Route("salinfo")]
        public ActionResult salinfo() { 
        return Ok(empinfoservice.getsalinfo());
        }

        [HttpGet]
        [Route("checkemail/{id}")]
        public ActionResult checkemail(int id) {
            List<employee_api> result= employeeservice.getallemployee().Where(x=>x.empid == id && x.email==null).ToList();

  
            if (result.Count() == 1)
                return Ok("not exist");
            else
                return Ok("exist");
        }

        [HttpGet]
        [Route("nameandemail")]
        public ActionResult nameandemail() {
           return Ok(empinfoservice.getnameandemail());
        }

        [HttpGet]
        [Route("countempindep")]
        public ActionResult countempindep() {
            return Ok(empinfoservice.getcountempindep());
        }

        [HttpGet]
        [Route("countemptask")]
        public ActionResult countemptask()
        {
            return Ok(empinfoservice.getcountemptask());
        }

        [HttpPost]
        [Route("filterdate")]
        public ActionResult filterdate([FromBody] filterdate_dto f)
        {
           
            return Ok(empinfoservice.filterdate(f));
        }
    }
}
