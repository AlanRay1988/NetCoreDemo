using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() => new string[] { "value1", "value2" };

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id) => "value";

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            var a = 1;
            a++;
            a+=1;
        }
        

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
