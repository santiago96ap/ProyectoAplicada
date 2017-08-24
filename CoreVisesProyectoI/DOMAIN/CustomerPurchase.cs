using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class CustomerPurchase{
        //Attributes
        public ObjectId idDB { get; set; }
        public String clientName { get; set; }
        public String productName { get; set; }
        public int quantity { get; set; }
        public int totalPay { get; set; }

        public CustomerPurchase()
        {
            this.clientName = "";
            this.productName = "";
            this.quantity = 0;
            this.totalPay = 0;
        }//Construct default

        public CustomerPurchase(ObjectId idDB, String clientName, String productName, int quantity, int totalPay)
        {
            this.idDB = idDB;
            this.clientName = clientName;
            this.productName = productName;
            this.quantity = quantity;
            this.totalPay = totalPay;
        }//Construct overloaded

        public string toString()
        {
            return "Client: " + this.clientName + ", Product: " + this.productName + ", Quantity: " + this.quantity + ", Total: " + this.totalPay;
        }//toString

    }//class
}//namespace

