using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN{
    public class Report{
        //Attributes
        public ObjectId _id { get; set; }//End set get idDB
        public float totalIncome { get; set; }//End set get totalIncome
        public float totalExpenses { get; set; }//End set get totalExpenses
        public String dateStart { get; set; }//End set get dateStart
        public String dateEnd { get; set; }//End set get dateEnd

        public Report(){
            this.totalIncome = 0;
            this.totalExpenses = 0;
            this.dateStart = "";
            this.dateEnd = "";
        }//End costruct default

        public Report(float totalIncome, float totalExpenses, String dateStart, String dateEnd){
            this.totalIncome = totalIncome;
            this.totalExpenses = totalExpenses;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
        }//End costruct overloaded

        public string toString(){
            return "ID: " + this._id + "\nTotal Income: " + this.totalIncome + "\nTotal Expenses: " + this.totalExpenses + "\nDate Start: " + this.dateStart +
                "\nDate End: " + this.dateEnd;
        }//End toString 

    }//End class Report

}//End namespace DOMAIN
