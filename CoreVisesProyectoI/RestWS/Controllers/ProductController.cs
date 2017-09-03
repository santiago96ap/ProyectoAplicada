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
    public class ProductController : ApiController
    {
        // GET api/values
        public List<Product> getProducts()
        {
            ProductBusiness p = new ProductBusiness();
            return p.selectProduct(); 
        } 
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        // POST api/values
        public int Post([FromBody] Product p)
        {
            ProductBusiness pb = new ProductBusiness();
            return pb.deleteProduct(p.name);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }//

        // DELETE api/values/5
        public int Delete(string name)
        {
            ProductBusiness pb = new ProductBusiness();
            return pb.deleteProduct(name);

        }
    }
}
