using DOMAIN;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA {
    public class ProductData {

        /*public ObjectId idBD { get; set; }
        public String name { get; set; }
        public String category { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public String status { get; set; }*/

        public Boolean insertProduct(String name, String category, int price, int quantity, String status,String path) {

            Boolean ret = false; // return variable
            try {
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                var product = new Product(name, category, price, quantity, status,path);
                MongoCollection collection = db.GetCollection<Client>("Product");
                collection.Insert<Product>(product);
                ret = true;
            }//try
            catch (Exception error) {
                ret = false;
            }//catch
            return ret;

        }//insertProduct
        public int insertProductRest(String name, String category, int price, int quantity, String status)
        {

            int ret = 0; // return variable
            try
            {
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                var product = new Product(name, category, price, quantity, status,"");
                MongoCollection collection = db.GetCollection<Client>("Product");
                collection.Insert<Product>(product);
                ret = 1;
            }//try
            catch (Exception error)
            {
                ret = 0;
            }//catch
            return ret;

        }//insertProduct

        public List<Product> selectProduct() {
            MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
            MongoServer ms = mc.GetServer();
            MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
            ms.Connect();
            MongoCollection collection = db.GetCollection<Product>("Product");
            return collection.FindAllAs<Product>().ToList<Product>(); // select del doc producto y lo almacena en una lista a retornar de tipo producto
        }//insertProduct

        public int deleteProduct(String name){
            int ret = 0;// return variable
            try {
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                ms.Connect();
                MongoCollection collection = db.GetCollection<Product>("Product");
                var query = Query.EQ("name", name); // comparacion para hacer la eliminacion del documento de la bd
                collection.Remove(query);
                ret = 1;//
            } catch (Exception error) {
                ret = 0;
            }//catch
            return ret;
        }//end deleteProduct

        public Boolean updateProduct(String name, String category, int price, int quantity, String status, String path) {
            Boolean ret = false;// return variable
            try {
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                ms.Connect();
                MongoCollection collection = db.GetCollection<Product>("Product");
                var query = Query.EQ("name", name); // comparacion para hacer el update del documento de la bd                                
                var product = collection.FindOneAs<Product>(query);
                product.name = name;
                product.category = category;
                product.price = price;
                product.quantity = quantity;
                product.status = status;
                product.path = path;
                collection.Save(product);
                ret = true;
            } catch (Exception error) {
                ret = true;
            }//catch
            return ret;
        }//end updateProduct

        public int updateProductRest(String name, String category, int price, int quantity, String status)
        {
            int ret = 0;// return variable
            try
            {
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                ms.Connect();
                MongoCollection collection = db.GetCollection<Product>("Product");
                var query = Query.EQ("name", name); // comparacion para hacer el update del documento de la bd                                
                var product = collection.FindOneAs<Product>(query);
                product.name = name;
                product.category = category;
                product.price = price;
                product.quantity = quantity;
                product.status = status;                
                collection.Save(product);
                ret = 1;
            }
            catch (Exception error)
            {
                ret = 0;
            }//catch
            return ret;
        }//end updateProduct

    }//end class
}//namespace 
