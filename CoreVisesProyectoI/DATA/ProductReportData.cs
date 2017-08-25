using DOMAIN;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA {
    public class ProductReportData {
        public Boolean insertProductReport(string productName, int quantity, int totalPay) {

            Boolean ret = false; // return variable
            try {
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                var productReport = new ProductReport(productName, quantity, totalPay);
                MongoCollection collection = db.GetCollection<ProductReport>("ProductReport");
                collection.Insert<ProductReport>(productReport);
                ret = true;
            }//try
            catch (Exception error) {
                ret = false;
            }//catch
            return ret;
        }//insertProductReport

        public List<ProductReport> selectProductReport() {
            MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
            MongoServer ms = mc.GetServer();
            MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
            ms.Connect();
            MongoCollection collection = db.GetCollection<ProductReport>("ProductReport");
            return collection.FindAllAs<ProductReport>().ToList<ProductReport>(); // select del doc producto y lo almacena en una lista a retornar de tipo producto
        }//selectProductReport

        public Boolean deleteProductReport(string name) {
            Boolean ret = false;// return variable
            try {
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                ms.Connect();
                MongoCollection collection = db.GetCollection<ProductReport>("ProductReport");
                var query = Query.EQ("name", name); // comparacion para hacer la eliminacion del documento de la bd
                collection.Remove(query);
                ret = true;
            }//try
            catch (Exception error) {
                ret = true;
            }//catch
            return ret;
        }//end deleteProduct

        public Boolean updateProductReport(string productName, int quantity, int totalPay) {
            Boolean ret = false;// return variable
            try {
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                ms.Connect();
                MongoCollection collection = db.GetCollection<ProductReport>("ProductReport");
                var query = Query.EQ("name", productName); // comparacion para hacer el update del documento de la bd                                
                var productReport = collection.FindOneAs<ProductReport>(query);
                productReport.productName = productName;
                productReport.quantity = quantity;
                productReport.totalPay = totalPay;
                collection.Save(productReport);
                ret = true;
            }//try
            catch (Exception error) {
                ret = true;
            }//catch
            return ret;
        }//updateProductReport
    }//ProductReportData
}//Namespace
