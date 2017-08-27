using DATA;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTIL;

namespace BUSINESS
{
    public class BillBusiness   {
        private BillData bd;
        public BillBusiness()
        {
            this.bd = new BillData();
        }//constructor


        public Boolean insertBill(string date, float amount, string subject, string client, string concept, string productName)
        {
           RSA rsa = new RSA();

           byte[] dateBytes = rsa.DecryptText(date, rsa.PrivateKey); 
           byte[] amountBytes = rsa.DecryptText(amount.ToString(), rsa.PrivateKey);
           byte[] subjectBytes = rsa.DecryptText(subject, rsa.PrivateKey);
           byte[] clientBytes = rsa.DecryptText(client, rsa.PrivateKey);
           byte[] conceptBytes = rsa.DecryptText(concept, rsa.PrivateKey);
           byte[] producttBytes = rsa.DecryptText(productName, rsa.PrivateKey);

           string dateDecrypted = Encoding.ASCII.GetString(dateBytes);
           string amountDecrypted = Encoding.ASCII.GetString(amountBytes);
           string subjectDecrypted = Encoding.ASCII.GetString(subjectBytes);
           string clientDecrypted = Encoding.ASCII.GetString(clientBytes);
           string conceptDecrypted = Encoding.ASCII.GetString(conceptBytes);
           string productDecrypted = Encoding.ASCII.GetString(producttBytes);

           return this.bd.insertBill(dateDecrypted, float.Parse(amountDecrypted),subjectDecrypted,clientDecrypted,conceptDecrypted,productDecrypted);
        }//insertBill

        public List<Bill> selectBill()
        {
            return this.bd.selectBill();
        }//selectBill

    }//end class 
    }//namespace 
