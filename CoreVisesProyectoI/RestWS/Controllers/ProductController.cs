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

        // POST api/values
        [HttpPost]
        public int Post([FromBody] Product p)
        {
            if (p._id.Equals("1"))
            {
                ProductBusiness pb = new ProductBusiness();
                return pb.deleteProduct(p.name);
            }
            else if (p._id.Equals("2"))
            {
                ProductBusiness pb = new ProductBusiness();
                return pb.updateProductRest(p.name, p.category, p.price, p.quantity, p.status);
            }
            else if (p._id.Equals("3"))
            {
                ProductBusiness pb = new ProductBusiness();
                return pb.insertProductRest(p.name, p.category, p.price, p.quantity, p.status);
            }
            return 0;
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
