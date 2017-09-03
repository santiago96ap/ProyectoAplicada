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
     
        public List<Client> Get()
        {
            ClientBusiness cb = new ClientBusiness();
            return cb.selectClient();
        }


        // GET api/values/5
        public string Get(string name)
        {
            return name;
        }

        // POST api/values        
        [HttpPost]
        //public Boolean Post([FromBody]String name, [FromBody] String mail, [FromBody]String pass, [FromBody] String card)
        public Boolean Post([FromBody]Client c)
        {
            ClientBusiness cb = new ClientBusiness();
            string[] lines = { c._id,c.name, c.mail, c.pass, c.card };
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllLines(@"C:\Users\mcalvo96\Documents\win 7\WriteLog.txt", lines);

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
