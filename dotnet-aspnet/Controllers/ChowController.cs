using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TastySite.Controllers
{
    [Route("api/[controller]")]
    public class ChowController : Controller
    {
        private readonly string[] _chows =  new string[] { "sammy", "yogurt", "burger", "burger", "burger", "juicy juicy", "not-bacon" };
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _chows;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            if (id < 0 || id > _chows.Length - 1) return "poop";
            return _chows[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
