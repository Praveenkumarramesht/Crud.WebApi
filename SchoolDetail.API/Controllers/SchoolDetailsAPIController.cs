using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperDataAccessLayer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolDetails.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolDetailsAPIController : ControllerBase
    {
        ISchoolDetailsRepository obj;
        public SchoolDetailsAPIController()
        {
            obj = new SchoolDetailsRepository();
        }
        // GET: api/<SchoolDetailsAPIController>
        [HttpGet]
        public IEnumerable<SchoolDetailss> Get()
        {
            return obj.ReadSP();
        }

        // GET api/<SchoolDetailsAPIController>/5
        [HttpGet("{id}")]
        public SchoolDetailss Get(int id)
        {
           return obj.FindSchoolDetailsByIdSP(id);
        }

        // POST api/<SchoolDetailsAPIController>
        [HttpPost]
        public SchoolDetailss Post([FromBody] SchoolDetailss value)
        {
            return obj.InsertSP(value);
        }

        // PUT api/<SchoolDetailsAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] SchoolDetailss value)
        {
            obj.UpdateSchoolDetailsByIdSP(id, value);
        }

        // DELETE api/<SchoolDetailsAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            obj.DeleteSchoolDetailsByIdSP(id);
        }
    }
}
