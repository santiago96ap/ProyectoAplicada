using DOMAIN;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA{
    public class ReportData{

        public Boolean insertReport(float totalIncome, float totalExpenses, String dateStart, String dateEnd)
        {
            Boolean ret = false;
            try{

                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                var report = new Report(totalIncome, totalExpenses, dateStart, dateEnd);
                MongoCollection collection = db.GetCollection<Report>("Report");
                collection.Insert<Report>(report);
                ret = true;

            }catch (Exception error){
                ret = false;
            }//catch
            return ret;
        }//end insertClient

        public List<Report> selectClient(){

            MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
            MongoServer ms = mc.GetServer();
            MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
            ms.Connect();
            MongoCollection collection = db.GetCollection<Report>("Report");
            return collection.FindAllAs<Report>().ToList<Report>(); // select del doc cliente y lo almacena en una lista a retornar de tipo cliente

        }//end insertClient

        public Boolean loginClient(String mail, String pass){
            Boolean ret = false;
            try{
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                ms.Connect();
                MongoCollection collection = db.GetCollection<Report>("Report");
                //var query = Query.EQ("mail", mail);
                //   var query = Query.EQ("mail", mail, "pass", pass);
                // "
                //   List<Client> client = collection.FindAs

                //       if (client.pass.equalsIgnoreCase(pass)) { }

                ret = true;
            }catch (Exception error){
                ret = false;
            }
            return ret;
        }//end insertClient

        public Boolean deleteClient(String name){
            Boolean ret = false;
            try{
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                ms.Connect();
                MongoCollection collection = db.GetCollection<Report>("Report");
                var query = Query.EQ("name", name); // comparacion para hacer la eliminacion del documento de la bd
                collection.Remove(query);
                ret = true;
            }catch (Exception error){
                ret = true;
            }//catch
            return ret;
        }//end deleteClient

        public Boolean updateClient(String name, String mail, String pass){
            Boolean ret = false;
            try {
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                ms.Connect();
                MongoCollection collection = db.GetCollection<Report>("Report");
                var query = Query.EQ("name", name); // comparacion para hacer la eliminacion del documento de la bd                                
                var report = collection.FindOneAs<Report>(query);
                report.mail = mail;
                report.pass = pass;
                collection.Save(report);
                ret = true;
            }catch (Exception error){
                ret = true;
            }//catch
            return ret;
        }//end updateClient

    }//End class ReportData

}//End namespace DATA
