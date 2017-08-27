using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using DOMAIN;
using UTIL;

namespace BUSINESS {
    public class ProductReportBusiness {
        private ProductReportData productReportData;

        public Boolean insertProductReport(string productName, string quantity, string totalPay) {

            RSA rsa = new RSA();

            byte[] productNameBytes = rsa.DecryptText(productName, rsa.PrivateKey);
            byte[] quantityBytes = rsa.DecryptText(quantity, rsa.PrivateKey);
            byte[] totalPayBytes = rsa.DecryptText(totalPay, rsa.PrivateKey);

            string productNameDecrypted = Encoding.ASCII.GetString(productNameBytes);
            int quantityDecrypted = int.Parse(Encoding.ASCII.GetString(quantityBytes));
            int totalPayDecrypted = int.Parse(Encoding.ASCII.GetString(totalPayBytes));

            return productReportData.insertProductReport(productNameDecrypted, quantityDecrypted, totalPayDecrypted);

        }//insertProductReport

        public List<ProductReport> selectProductReport() {
            return productReportData.selectProductReport();
        }//selectProductReport

        public Boolean deleteProductReport(String productName) {
            return productReportData.deleteProductReport(productName);
        }//deleteProductReport

        public Boolean updateProductReport(String productName, int quantity, int totalPay) {
            return productReportData.updateProductReport(productName, quantity, totalPay);
        }//updateProductReport
    }//ProductReportBusiness
}//Namespace
