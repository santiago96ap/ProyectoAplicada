using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DOMAIN;
using BUSINESS;

namespace RestWS.Controllers
{
    public class ManagerController : ApiController
    {

        // GET api/values
        public List<Manager> getManagers()
        {
            ManagerBusiness mb = new ManagerBusiness();
            return mb.selectManager();
        }

        // GET api/values/5
        public String Get(int value)
        {
            return "value";
        }

        // POST api/values        
        [HttpPost]
        public Boolean Post([FromBody] Manager m)
        {
            ManagerBusiness mb = new ManagerBusiness();

            //   return cb.insertClientRest(name,mail,pass,card);//
            return mb.loginClient(m.name, m.password);

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

    }//class
}//namespace
