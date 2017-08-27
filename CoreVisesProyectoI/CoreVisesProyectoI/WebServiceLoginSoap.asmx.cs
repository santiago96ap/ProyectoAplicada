using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DOMAIN;
using BUSINESS;

namespace CoreVisesProyectoI{
    /// <summary>
    /// Summary description for WebServiceLoginSoap
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceLoginSoap : System.Web.Services.WebService{

        [WebMethod]
        public string HelloWorld() { 
            return "Hello World";
        }//End Helloworld

        [WebMethod]
        public void LoginClient(String mail, String pass){
            ClientBusiness cb = new ClientBusiness();
            Boolean verify;
            // verify = cb.s
        }//End LoginClient

        [WebMethod]
        public Boolean RegisterClient(string name, string mail, string pass, string card) {
            ClientBusiness cb = new ClientBusiness();            
            return cb.insertClient(name, mail, pass, card);            
        }//End RegisterClient

    }//End class WebServiceLoginSoap
}//End namespace CoreVisesProyectoI
