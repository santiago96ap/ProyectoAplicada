using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN{
    public class Client{
        //Attributes
        public ObjectId idDB { get; set; }
        public String name { get; set; }
        public String mail { get; set; }
        public String pass { get; set; }
        public String card { get; set; }

        public Client()
        {
            this.name = "";
            this.mail = "";
            this.pass = "";
            this.card = "";
        }//Construct default

        public Client(ObjectId idDB, String name, String mail, String pass, String card)
        {
            this.idDB = idDB;
            this.name = name;
            this.mail = mail;
            this.pass = pass;
            this.card = card;
        }//Construct Client

        public string toString()
        {
            return "Client: " + this.name+ ", Mail: " + this.mail+ ", Card: " + this.card;
        }//toString

    }
}
