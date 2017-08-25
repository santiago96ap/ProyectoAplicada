using DATA;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTIL;

namespace BUSINESS{
    public class ReportBusiness{
        //Attributes
        private ReportData rd;

        public Boolean insertReport(float totalIncome, float totalExpenses, string dateStart, string dateEnd){

            RSA rsa = new RSA();

            byte[] totalIncomeBytes = rsa.DecryptText(totalIncome.ToString(), rsa.PrivateKey);
            byte[] totalExpensesBytes = rsa.DecryptText(totalExpenses.ToString(), rsa.PrivateKey);
            byte[] dateStartBytes = rsa.DecryptText(dateStart, rsa.PrivateKey);
            byte[] dateEndBytes = rsa.DecryptText(dateEnd, rsa.PrivateKey);

            string totalIncomeDecrypted = Encoding.ASCII.GetString(totalIncomeBytes);
            string totalExpensesDecrypted = Encoding.ASCII.GetString(totalExpensesBytes);
            string dateStartDecrypted = Encoding.ASCII.GetString(dateStartBytes);
            string dateEndDecrypted = Encoding.ASCII.GetString(dateEndBytes);

            return rd.insertReport(float.Parse(totalIncomeDecrypted), float.Parse(totalExpensesDecrypted), dateStartDecrypted, dateEndDecrypted);

        }//end insertReport

        public List<Report> selectClient(){
            return rd.selectReport();
        }//end selectClient

    }//End class ReportBusiness

}//End namespace BUSINESS
