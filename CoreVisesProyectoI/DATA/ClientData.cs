using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using DOMAIN;
using MongoDB.Driver.Builders;

namespace DATA {
    public class ClientData {
        public Boolean insertClient(String name, String mail,String pass,String card) {
            Boolean ret = false;
            try {

                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");

                List<Client> clients = selectClient();
                foreach (Client client in clients) {
                    if (client.mail.Equals(mail)) {
                        ret = false;
                        break;
                    }else {
                        ret = true;
                    }//End if (item.mail.Equals(mail) && item.pass.Equals(pass))
                }//End foreach (Client item in clients)

                if (ret) {
                    var client = new Client(name,mail,pass,card);                
                    MongoCollection collection = db.GetCollection<Client>("Client");
                    collection.Insert<Client>(client);
                }//Si es true, lo puede insertar.
            }catch (Exception error) {
                ret = false;
            }//try-catch
            return ret;
        }//end insertClient

        public List<Client> selectClient() {
              
            MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
            MongoServer ms = mc.GetServer();
            MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
            ms.Connect();
            MongoCollection collection = db.GetCollection<Client>("Client");
            return collection.FindAllAs<Client>().ToList<Client>(); // select del doc cliente y lo almacena en una lista a retornar de tipo cliente

        }//end insertClient

        public Boolean loginClient(string mail, string pass){
            Boolean ret = false;
            try{
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                ms.Connect();
                MongoCollection collection = db.GetCollection<Client>("Client");
                List<Client> clients = selectClient();
                foreach (Client item in clients){
                    if (item.mail.Equals(mail) && item.pass.Equals(pass)) {
                        ret = true;
                        break;
                    } else {
                        ret = false;
                    }//End if (item.mail.Equals(mail) && item.pass.Equals(pass))
                }//End foreach (Client item in clients)
            }catch (Exception error) {
                ret = false;
            }
            return ret;
        }//end insertClient

        public Boolean deleteClient(String name) {
            Boolean ret = false;
            try {
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                ms.Connect(); 
                MongoCollection collection = db.GetCollection<Client>("Client");                
                var query = Query.EQ("mail", name); // comparacion para hacer la eliminacion del documento de la bd
                collection.Remove(query);                
                ret = true;
            }catch (Exception error) {
                ret = true;
            }//try-catch
            return ret;
        }//end deleteClient

        public Boolean updateClient(String name,String mail,String pass,String card) {
            Boolean ret = false;
            try {
                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
                MongoServer ms = mc.GetServer();
                MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
                ms.Connect();
                MongoCollection collection = db.GetCollection<Client>("Client");
                var query = Query.EQ("mail", mail); // comparacion para hacer la eliminacion del documento de la bd                                
                var client = collection.FindOneAs<Client>(query);
                client.name = name;
                client.pass = pass;
                client.card = card;          
                collection.Save(client);
                ret = true;
            }catch (Exception error){
                ret = true;
            }//try-catch
            return ret;
        }//end updateClient
    }//end class
}//end namespace
