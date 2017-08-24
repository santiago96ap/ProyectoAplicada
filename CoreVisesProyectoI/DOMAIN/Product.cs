using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    class Product
    {

        //Attributes
        //public ObjectId idBD { get; set; }
        public int id { get; set; }
        public String name { get; set; }
        public String category { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public String status { get; set; }

        public Product()
        {
            this.id = 0;
            this.name = " ";
            this.category = " ";
            this.price = 0;
            this.quantity = 0;
            this.status = " ";
        }//build default

        public Product(
            //ObjectId idBD,
             int id, String name, String category, int price, int quantity, String status)
        {
            //this.idBD = idBD;
            this.id = id;
            this.name = name;
            this.category = category;
            this.price = price;
            this.quantity = quantity;
            this.status = status;
        }//build overload

        public string toString()
        {
            return "ID: " + this.id + "\nName: " + this.name + "\nCategory: " + this.category + "\nPrice: " + this.price +
                "\nQuantity: " + this.quantity + "\nStatus: " + this.status;
        }//toString 


    }//product
}//namespace
