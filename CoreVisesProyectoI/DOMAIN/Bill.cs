using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Bill{
        public ObjectId idDB { get; set; }
        public String clientName { get; set; }
        public String productName { get; set; }
        public int quantity { get; set; }
        public int totalPay { get; set; }

    }//class
}//namespace
