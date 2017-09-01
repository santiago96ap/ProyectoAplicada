﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BUSINESS;
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
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        // POST REGISTER CLIENT api/values
        public Boolean Register([FromBody]string name, [FromBody]string mail, [FromBody]string pass, [FromBody]string card)
        {
            ClientBusiness cb = new ClientBusiness();
            return cb.insertClientRest(name,mail,pass,card);            
        }
    }
}
