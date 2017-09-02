using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BUSINESS;
using DOMAIN;
namespace RestWS.Controllers
{
    public class ClientController : ApiController
    {
        // GET api/values
     
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values        
        [HttpPost]
        public Boolean Post([FromBody]String name, [FromBody] String mail, [FromBody]String pass, [FromBody] String card)
        {
            ClientBusiness cb = new ClientBusiness();
            return cb.insertClientRest(name,mail,pass,card);//
            //cb.insertClientRest(c.name, c.mail, c.pass, c.card);

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

       
       
    }
}
