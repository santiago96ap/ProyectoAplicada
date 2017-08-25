using DOMAIN;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class CustomerPurchaseData
    {
        public Boolean insertCustomerPurchase(String clientName, String productName, int quantity, int totalPay)
        {

            Boolean ret = false; // return variable
            try
            {
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                var customerPurchase = new CustomerPurchase(clientName, productName, quantity, totalPay);
                MongoCollection collection = db.GetCollection<CustomerPurchase>("Client_Report");
                collection.Insert<CustomerPurchase>(customerPurchase);
                ret = true;
            }//try
            catch (Exception error)
            {
                ret = false;
            }//catch
            return ret;

        }//insertCustomerPurchase

        public List<CustomerPurchase> selectCustomerPurchase()
        {

            MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
            MongoServer ms = mc.GetServer();
            MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
            ms.Connect();
            MongoCollection collection = db.GetCollection<CustomerPurchase>("Client_Report");
            return collection.FindAllAs<CustomerPurchase>().ToList<CustomerPurchase>(); // select del CustomerPurchase y lo almacena en una lista a retornar de tipo CustomerPurchase

        }//insertCustomerPurchase

        public Boolean deleteCustomerPurchase(String clientName)
        {
            Boolean ret = false;// return variable
            try
            {
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                ms.Connect();
                MongoCollection collection = db.GetCollection<CustomerPurchase>("Client_Report");
                var query = Query.EQ("clientName", clientName); // comparacion para hacer la eliminacion del documento de la bd
                collection.Remove(query);
                ret = true;
            }//try
            catch (Exception error)
            {
                ret = true;
            }//catch
            return ret;
        }//end deleteCustomerPurchase

        public Boolean updateCustomerPurchase(String clientName, String productName, int quantity, int totalPay)
        {
            Boolean ret = false;// return variable
            try
            {
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                ms.Connect();
                MongoCollection collection = db.GetCollection<CustomerPurchase>("Client_Report");
                var query = Query.EQ("clientName", clientName); // comparacion para hacer el update del documento de la bd                                
                var customerPurchase = collection.FindOneAs<CustomerPurchase>(query);
                customerPurchase.clientName = clientName;
                customerPurchase.productName = productName;
                customerPurchase.quantity = quantity;
                customerPurchase.totalPay = totalPay;
                collection.Save(customerPurchase);
                ret = true;
            }//try
            catch (Exception error)
            {
                ret = true;
            }//catch
            return ret;
        }//end updateCustomerPurchase

    }//class
}//namespace
