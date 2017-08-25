using DATA;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTIL;

namespace BUSINESS{

    public class ManagerBusiness{
        //Attributes
        private ManagerData md;

        public Boolean insertManager(string name, string pass, string type){

            RSA rsa = new RSA();

            byte[] nameBytes = rsa.DecryptText(name, rsa.PrivateKey);
            byte[] passBytes = rsa.DecryptText(pass, rsa.PrivateKey);
            byte[] typeBytes = rsa.DecryptText(type, rsa.PrivateKey);

            string nameDecrypted = Encoding.ASCII.GetString(nameBytes);
            string passDecrypted = Encoding.ASCII.GetString(passBytes);
            string typeDecrypted = Encoding.ASCII.GetString(typeBytes);

            return md.insertManager(nameDecrypted, passDecrypted, typeDecrypted);

        }//End insertManager

        public List<Manager> selectManager(){
            return md.selectManager();
        }//End selectManager

        public Boolean deleteManager(String name){
            return md.deleteManager(name);
        }//End deleteManager

        public Boolean updateManager(String name, String pass, String type){
            return md.updateManager(name, pass, type);
        }//End updateManager

    }//End class ManagerBusiness

}//End namespace BUSINESS
