using DOMAIN;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class BillData
    {
        public Boolean insertBill(string date, float amount, string subject, string client, string concept, string productName){
            Boolean ret = false;
            try{

                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                var bill = new Bill(date,amount,subject,client,concept,productName);
                MongoCollection collection = db.GetCollection<Bill>("Bill");
                collection.Insert<Bill>(bill);
                ret = true;

            }//try
            catch (Exception error)
            {
                ret = false;
            }//catch
            return ret;
        }//end insertBill

        public List<Bill> selectBill()
        {

            MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
            MongoServer ms = mc.GetServer();
            MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
            ms.Connect();
            MongoCollection collection = db.GetCollection<Bill>("Bill");
            return collection.FindAllAs<Bill>().ToList<Bill>(); // select de la factura y lo almacena en una lista a retornar de tipo factura

        }//end selectBill

    }//end class
}// namespace
