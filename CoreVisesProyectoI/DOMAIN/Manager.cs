using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN{
    public class Manager{
        //Attributes
        public ObjectId _id { get; set; }//End set get idDB
        public String name { get; set; }//End set get name
        public String password { get; set; }//End set get password
        public String type { get; set; }//End set get type

        public Manager() {
            this.name = "";
            this.password = "";
            this.type = "";
        }//End construct default

        public Manager(String name, String password, String type) {
            this.name = name;
            this.password = password;
            this.type = type;
        }//End  construct overloaded

        public string toString(){
            return "ID: " + this._id + "\nName: " + this.name + "\nPassword: " + this.password + "\nType: " + this.type;
        }//End toString 

    }//End class Manager

}//End namespace DOMAIN
