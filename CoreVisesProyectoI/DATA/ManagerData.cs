using DOMAIN;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA { 
    public class ManagerData{

        public Boolean insertManager(String name, String pass, String type){
            Boolean ret = false;
            try{
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                var manager = new Manager(name, pass, type);
                MongoCollection collection = db.GetCollection<Manager>("Manager");
                collection.Insert<Manager>(manager);
                ret = true;
            }catch (Exception error){
                ret = false;
            }//End try-catch (Exception error)
            return ret;
        }//End insertManager

        public List<Manager> selectManager() { 

            MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
            MongoServer ms = mc.GetServer();
            MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
            ms.Connect();
            MongoCollection collection = db.GetCollection<Manager>("Manager");
            return collection.FindAllAs<Manager>().ToList<Manager>(); // select del doc cliente y lo almacena en una lista a retornar de tipo cliente

        }//End selectManager

        public Boolean loginManager(String name, String pass){
            Boolean ret = false;
            try{
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                ms.Connect();
                MongoCollection collection = db.GetCollection<Manager>("Manager");
                //var query = Query.EQ("mail", mail);
                //   var query = Query.EQ("mail", mail, "pass", pass);
                // "
                //   List<Client> client = collection.FindAs

                //       if (client.pass.equalsIgnoreCase(pass)) { }

                ret = true;
            }catch (Exception error){
                ret = false;
            }//End try-catch (Exception error)
            return ret;
        }//End loginManager

        public Boolean deleteManager(String name){
            Boolean ret = false;
            try{
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                ms.Connect();
                MongoCollection collection = db.GetCollection<Manager>("Manager");
                var query = Query.EQ("name", name); // comparacion para hacer la eliminacion del documento de la bd
                collection.Remove(query);
                ret = true;
            }catch (Exception error){
                ret = true;
            }//End try-catch(Exception error)
            return ret;
        }//End deleteManager

        public Boolean updateManager(String name, String pass, String type){
            Boolean ret = false;
            try{
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                ms.Connect();
                MongoCollection collection = db.GetCollection<Manager>("Manager");
                var query = Query.EQ("name", name); // comparacion para hacer la eliminacion del documento de la bd                                
                var manager = collection.FindOneAs<Manager>(query);
                manager.name = name;
                manager.password = pass;
                manager.type = type;
                collection.Save(manager);
                ret = true;
            }catch (Exception error){
                ret = true;
            }//End try-catch (Exception error)
            return ret;
        }//End updateManager

    }//End class ManagerData

}//End namespace DATA
