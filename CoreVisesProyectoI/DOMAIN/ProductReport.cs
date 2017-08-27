using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN {
    public class ProductReport {

        //Attributes
        public ObjectId _id { get; set; }
        public string productName { get; set; } // Sets and Gets
        public int quantity { get; set; } // Sets and Gets
        public int totalPay { get; set; } // Sets and Gets

        public ProductReport() {
            this.productName = "";
            this.quantity = 0;
            this.totalPay = 0;
        }//Construct.

        public ProductReport(string productName, int quantity, int totalPay) {
            this.productName = productName;
            this.quantity = quantity;
            this.totalPay = totalPay;
        }//Construct ProductReport
        
    }//ProductReport
}//Namespace
