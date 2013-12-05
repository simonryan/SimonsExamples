using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloApiTemplateDemo.Controllers
{
    public class ValuesController : ApiController
    {
        private static List<string> data = InitList();
        
        private static List<string> InitList()
        {
            return new List<string> {"string1", "string2"};
        }


        // GET api/values
        public IEnumerable<string> Get()
        {
            return data;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return data[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            data.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            data[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            data.RemoveAt(id);
        }
    }
}