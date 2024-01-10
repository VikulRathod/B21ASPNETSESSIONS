using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _2_Routing.Controllers
{
    // [RoutePrefix("api/[controller]")]
    public class StudentController : ApiController
    {
        // get https://localhost:44342/api/student
        [HttpGet]
        public IEnumerable<string> GetNames()
        {
            return new List<string>() { "Vishal", "Kunal", "Ritesh" };
        }

        [HttpGet]
        public string GetName(int id)
        {
            return "Kunal";
        }

        [HttpPost]
        // public void Create([FromBody] string name)
        // [Route("{name}?")]
        public void Create(string name)
        {
            // create logic
        }

        [HttpPut]
        public void Update([FromUri] int id, [FromBody] string name)
        {

        }

        [HttpDelete]
        public void Delete([FromUri] int id)
        {

        }
    }
}
