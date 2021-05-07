using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApi.Controllers
{
    //路由设置
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new String[] { "value1", "value2" };
        }

        //GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id) 
        {
            return "valule";
        }

        //POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        { 

        }

        //PUT api/values
        [HttpPut("id")]
        public void Put(int id, [FromBody] string value)
        { 
            
        }

        //DELETE api/value/5
        [HttpDelete]
        public void Delete(int id)
        { 
            
        }


    }
}
