using DATA;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTIL;

namespace BUSINESS {
    public class ProductBusiness {

        /*public ObjectId idBD { get; set; }
        public String name { get; set; }
        public String category { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public String status { get; set; }*/

        private ProductData productData;

        public ProductBusiness()  {
            this.productData = new ProductData();
        }//constructor

        public Boolean insertProduct(String name, String category, String price, String quantity, String status, String path) {

            RSA rsa = new RSA();

            byte[] nameBytes = rsa.DecryptText(name, rsa.PrivateKey);
            byte[] categoryBytes = rsa.DecryptText(category, rsa.PrivateKey);
            byte[] priceBytes = rsa.DecryptText(price.ToString(), rsa.PrivateKey);
            byte[] quantityBytes = rsa.DecryptText(quantity.ToString(), rsa.PrivateKey);
            byte[] statusBytes = rsa.DecryptText(status, rsa.PrivateKey);
            byte[] pathBytes = rsa.DecryptText(path,rsa.PrivateKey);

            string nameDecrypted = Encoding.ASCII.GetString(nameBytes);
            string categoryDecrypted = Encoding.ASCII.GetString(categoryBytes);
            string priceDecrypted = Encoding.ASCII.GetString(priceBytes);
            string quantityDecrypted = Encoding.ASCII.GetString(quantityBytes);
            string statusDecrypted = Encoding.ASCII.GetString(statusBytes);
            string pathDecrypted = Encoding.ASCII.GetString(pathBytes);

            return productData.insertProduct(nameDecrypted, categoryDecrypted, int.Parse(priceDecrypted), int.Parse(quantityDecrypted), statusDecrypted, pathDecrypted);

        }//end insertProduct

        public List<Product> selectProduct() {
            return productData.selectProduct();
        }//end insertClient

        public int deleteProduct(String name) {
            return productData.deleteProduct(name);
        }//end deleteClient

        public List<Product> getProducts(String category) {
            List<Product> decryptedProducts = productData.selectProduct();
            List<Product> encryptedProducts = new List<Product>();
            RSA rsa = new RSA();

            foreach (Product product in decryptedProducts) {
                if ((product.category.Equals(category)) || (category.Equals("All"))) {
                    product.name = Convert.ToBase64String(rsa.EncryptText(product.name, rsa.PublicKey));
                    product.category = Convert.ToBase64String(rsa.EncryptText(product.category, rsa.PublicKey));
                    product.price = int.Parse(Convert.ToBase64String(rsa.EncryptText(product.price.ToString(), rsa.PublicKey)));
                    product.quantity = int.Parse(Convert.ToBase64String(rsa.EncryptText(product.quantity.ToString(), rsa.PublicKey)));
                    product.status = Convert.ToBase64String(rsa.EncryptText(product.status, rsa.PublicKey));
                    product.path = Convert.ToBase64String(rsa.EncryptText(product.path, rsa.PublicKey));
                    encryptedProducts.Add(product);
                }//Solo agrega los productos de la categoría que se quiere mostrar.
            }//foreach

            return encryptedProducts;
        }//getProducts

        public Boolean updateProduct(String name, String category, int price, int quantity, String status ,String path) {
            return productData.updateProduct(name, category, price, quantity, status,path);
        }//end updateClient

    }//end class
}//end namespace
