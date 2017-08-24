using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN{
    public class Manager{
        //Attributes
        public ObjectId idBD { get; set; }//End set get idDB
        public String name { get; set; }//End set get name
        public String password { get; set; }//End set get password
        public String type { get; set; }//End set get type

        public Manager() {
            this.name = "";
            this.password = "";
            this.type = "";
        }//End construct default

        public Manager(ObjectId idDB,String name, String password, String type) {
            this.idBD = idDB;
            this.name = name;
            this.password = password;
            this.type = type;
        }//End  construct overloaded

        public string toString(){
            return "ID: " + this.idBD + "\nName: " + this.name + "\nPassword: " + this.password + "\nType: " + this.type;
        }//End toString 

    }//End class Manager

}//End namespace DOMAIN
