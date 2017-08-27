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
    public class CustomerPurchaseBusiness
    {

        private CustomerPurchaseData customerPurchaseData;

        public CustomerPurchaseBusiness()
        {
            this.customerPurchaseData = new CustomerPurchaseData();
        }//constructor

        public Boolean insertCustomerPurchase(String clientName, String productName, int quantity, int totalPay)
        {

            RSA rsa = new RSA();

            byte[] clientNameBytes = rsa.DecryptText(clientName, rsa.PrivateKey);
            byte[] productNameBytes = rsa.DecryptText(productName, rsa.PrivateKey);
            byte[] quantityBytes = rsa.DecryptText(quantity.ToString(), rsa.PrivateKey);
            byte[] totalPayBytes = rsa.DecryptText(totalPay.ToString(), rsa.PrivateKey);

            string clietNameDecrypted = Encoding.ASCII.GetString(clientNameBytes);
            string productNameDecrypted = Encoding.ASCII.GetString(productNameBytes);
            string quantityDecrypted = Encoding.ASCII.GetString(quantityBytes);
            string totalPayDecrypted = Encoding.ASCII.GetString(totalPayBytes);

            return customerPurchaseData.insertCustomerPurchase(clietNameDecrypted, productNameDecrypted, int.Parse(quantityDecrypted), int.Parse(totalPayDecrypted));

        }//end insertCustomerPurchase

        public List<CustomerPurchase> selectCustomerPurchase()
        {
            return customerPurchaseData.selectCustomerPurchase();
        }//end insertCustomerPurchase

        public Boolean deleteCustomerPurchase(String clientName)
        {
            return customerPurchaseData.deleteCustomerPurchase(clientName);
        }//end deleteCustomerPurchase

        public Boolean updateCustomerPurchase(String clientName, String productName, int quantity, int totalPay)
        {
            return customerPurchaseData.updateCustomerPurchase(clientName, productName, quantity, totalPay);
        }//end updateCustomerPurchase

    }//class
}//namespace
