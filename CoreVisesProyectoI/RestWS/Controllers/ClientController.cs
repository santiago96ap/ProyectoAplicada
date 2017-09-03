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
        //// GET api/values

        public List<Client> getClientes()
        {
            ClientBusiness cb = new ClientBusiness();
            return cb.selectClient();
        }

        // GET api/values/5
        public int Get(string mail, string pass)
        {
            ClientBusiness cb = new ClientBusiness();

            return cb.loginClient(mail, pass);
        }

        // POST api/values        
        [HttpPost]
        public int Post([FromBody] Client c)
        {
            ClientBusiness cb = new ClientBusiness();

         //   return cb.insertClientRest(name,mail,pass,card);//
            return cb.insertClientRest(c.name, c.mail, c.pass, c.card);

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
