using DATA;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTIL;

namespace BUSINESS
{
    public class ProductBusiness
    {

        private ProductData productData;

        /*public ObjectId idBD { get; set; }
        public String name { get; set; }
        public String category { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public String status { get; set; }*/

        public Boolean insertProduct(String name, String category, int price, int quantity, String status)
        {

            RSA rsa = new RSA();

            byte[] nameBytes = rsa.DecryptText(name, rsa.PrivateKey);
            byte[] categoryBytes = rsa.DecryptText(category, rsa.PrivateKey);
            byte[] priceBytes = rsa.DecryptText(price.ToString(), rsa.PrivateKey);
            byte[] quantityBytes = rsa.DecryptText(quantity.ToString(), rsa.PrivateKey);
            byte[] statusBytes = rsa.DecryptText(status, rsa.PrivateKey);

            string nameDecrypted = Encoding.ASCII.GetString(nameBytes);
            string categoryDecrypted = Encoding.ASCII.GetString(categoryBytes);
            string priceDecrypted = Encoding.ASCII.GetString(priceBytes);
            string quantityDecrypted = Encoding.ASCII.GetString(quantityBytes);
            string statusDecrypted = Encoding.ASCII.GetString(statusBytes);

            return productData.insertProduct(nameDecrypted, categoryDecrypted, int.Parse(priceDecrypted), int.Parse(quantityDecrypted), statusDecrypted);

        }//end insertProduct

        public List<Product> selectProduct()
        {
            return productData.selectProduct();
        }//end insertClient

        public Boolean deleteProduct(String name)
        {
            return productData.deleteProduct(name);
        }//end deleteClient

        public Boolean updateProduct(String name, String category, int price, int quantity, String status)
        {
            return productData.updateProduct(name, category, price, quantity, status);
        }//end updateClient

    }//end class
}//end namespace
