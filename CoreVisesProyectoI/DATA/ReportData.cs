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

        public Boolean insertReport(float totalIncome, float totalExpenses, String dateStart, String dateEnd){
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
            }//End try-catch (Exception error)
            return ret;
        }//end insertClient

        public List<Report> selectReport(){

            MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
            MongoServer ms = mc.GetServer();
            MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
            ms.Connect();
            MongoCollection collection = db.GetCollection<Report>("Report");
            return collection.FindAllAs<Report>().ToList<Report>(); // select del doc cliente y lo almacena en una lista a retornar de tipo cliente

        }//end selectReport 

    }//End class ReportData

}//End namespace DATA
