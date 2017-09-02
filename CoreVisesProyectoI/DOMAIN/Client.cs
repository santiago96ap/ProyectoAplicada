using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN{
    public class Client{
        //Attributes

        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; } // Sets and Gets
        public String name { get; set; } // Sets and Gets
        public String mail { get; set; } // Sets and Gets
        public String pass { get; set; } // Sets and Gets 
        public String card { get; set; } // Sets and Gets

        public Client()
        {
            this.name = "";
            this.mail = "";
            this.pass = "";
            this.card = "";
        }//Construct default

        public Client(String name, String mail, String pass, String card)
        {            
            this.name = name;
            this.mail = mail;
            this.pass = pass;
            this.card = card;
        }//Construct Client

        public string toString()
        {
            return "Client: " + this.name+ ", Mail: " + this.mail+ ", Card: " + this.card;
        }//toString

    }// End class
}// End namespace
