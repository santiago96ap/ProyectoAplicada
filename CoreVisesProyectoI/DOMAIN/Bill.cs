using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Bill{
        public Bill(string date, float amount, string subject, string client, string concept, string productName)
        {
            this.date = date;
            this.amount = amount;
            this.subject = subject;
            this.client = client;
            this.concept = concept;
            this.productName = productName;
        }//building
        public Bill()
        {
            this.date = "";
            this.amount = 0;
            this.subject = "";
            this.client = "";
            this.concept = "";
            this.productName = "";
        }//default

        /*Set and Get*/
        public ObjectId idDB { get; set; }
        public String date { get; set; }
        public float amount { get; set; }
        public String subject { get; set; }
        public String  client { get; set; }
        public String  concept { get; set; }
        public String  productName { get; set; }

        public string toString()
        {
            return "Date: " + this.date + "Amount: " + this.amount + " Subject: " + this.subject + " Client: " + this.client + " Concept: "  + this.concept + "Product Name: "+ this.productName;
        }//toString

    }//class
}//namespace
