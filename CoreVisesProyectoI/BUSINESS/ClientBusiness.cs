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

        public int insertClient(string name, string mail, string pass, string card) {
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

        public int insertClientRest(String name, String mail, String pass, String card) {          
            return cd.insertClient(name, mail, pass, card);//
        }//end insertClientRest

        public int loginClient(string email, string pass) {
            RSA rsa = new RSA();
            byte[] mailBytes = rsa.DecryptText(email, rsa.PrivateKey);
            byte[] passBytes = rsa.DecryptText(pass, rsa.PrivateKey);
            string mailDecrypted = Encoding.ASCII.GetString(mailBytes);
            string passDecrypted = Encoding.ASCII.GetString(passBytes);
            return cd.loginClient(mailDecrypted, passDecrypted);
        }//end loginClient

        public List<Client> selectClient() {
            return cd.selectClient();
        }//end insertClient

        public List<Client> selectAllClients() {
            List<Client> decryptedClients = cd.selectClient();
            List<Client> encryptedClients = new List<Client>();
            RSA rsa = new RSA();

            foreach (Client client in decryptedClients) {
                client.name = Convert.ToBase64String(rsa.EncryptText(client.name, rsa.PublicKey));
                client.card = Convert.ToBase64String(rsa.EncryptText(client.card, rsa.PublicKey));
                client.mail = Convert.ToBase64String(rsa.EncryptText(client.mail, rsa.PublicKey));
                client.pass = Convert.ToBase64String(rsa.EncryptText(client.pass, rsa.PublicKey));
                encryptedClients.Add(client);
            }//foreach

            return encryptedClients;
        }//selectAllClients

        public Boolean deleteClient(String name) {
            return cd.deleteClient(name);
        }//end deleteClient

        public int updateClient(String name, String mail, String pass,String card) {
            RSA rsa = new RSA();
            byte[] nameBytes = rsa.DecryptText(name, rsa.PrivateKey);
            byte[] mailBytes = rsa.DecryptText(mail, rsa.PrivateKey);
            byte[] passBytes = rsa.DecryptText(pass, rsa.PrivateKey);
            byte[] cardBytes = rsa.DecryptText(card, rsa.PrivateKey);
            string nameDecrypted = Encoding.ASCII.GetString(nameBytes);
            string mailDecrypted = Encoding.ASCII.GetString(mailBytes);
            string passDecrypted = Encoding.ASCII.GetString(passBytes);
            string cardDecrypted = Encoding.ASCII.GetString(cardBytes);
            return cd.updateClient(nameDecrypted, mailDecrypted, passDecrypted, cardDecrypted);
        }//end updateClient

        public int updateClientRest(String name, String mail, String pass, String card)
        {
            return cd.updateClient(name, mail, pass, card);
        }//end updateClient

    }//end class
}//end namespace
