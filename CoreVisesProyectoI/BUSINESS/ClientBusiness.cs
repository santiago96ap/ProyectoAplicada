using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using DOMAIN;
using UTIL;

namespace BUSINESS {
    public class ClientBusiness {

        private ClientData cd;

        public ClientBusiness() {
            this.cd = new ClientData();
        }

        public Boolean insertClient(string name, string mail, string pass, string card) {             

           RSA rsa = new RSA();

           byte[] nameBytes = rsa.DecryptText(name, rsa.PrivateKey); 
           byte[] mailBytes = rsa.DecryptText(mail, rsa.PrivateKey);
           byte[] passBytes = rsa.DecryptText(pass, rsa.PrivateKey);
           byte[] cardBytes = rsa.DecryptText(card, rsa.PrivateKey);

           string nameDecrypted = Encoding.ASCII.GetString(nameBytes);
           string mailDecrypted = Encoding.ASCII.GetString(mailBytes);
           string passDecrypted = Encoding.ASCII.GetString(passBytes);
           string cardDecrypted = Encoding.ASCII.GetString(cardBytes);
            
           return cd.insertClient(nameDecrypted, mailDecrypted, passDecrypted, cardDecrypted);

        }//end insertClient

        public List<Client> selectClient()
        {
            return cd.selectClient();
        }//end insertClient

        public Boolean deleteClient(String name)
        {
            return cd.deleteClient(name);
        }//end deleteClient

        public Boolean updateClient(String name, String mail, String pass)
        {
            return cd.updateClient(name, mail, pass);
        }//end updateClient

    }//end class
}//end namespace
