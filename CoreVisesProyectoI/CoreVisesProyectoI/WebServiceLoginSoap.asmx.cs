using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DOMAIN;
using BUSINESS;
using System.Web.Script.Services;
using System.Web.Script.Serialization;

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
        public int LoginClient(string mail, string pass){
            ClientBusiness cb = new ClientBusiness();
            return cb.loginClient(mail, pass);
            // verify = cb.s
        }//End LoginClient

        [WebMethod]
        public int RegisterClient(string name, string mail, string pass, string card) {
            ClientBusiness cb = new ClientBusiness();            
            return cb.insertClient(name, mail, pass, card);            
        }//End RegisterClient

        [WebMethod]
        public int UpdateClient(string name, string mail, string pass, string card) {
            ClientBusiness cb = new ClientBusiness();
            return cb.updateClient(name, mail, pass, card);
        }//UpdateClient

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public String getClients() {
            ClientBusiness cb = new ClientBusiness();
            List<Client> clients = new List<Client>();
            clients = cb.selectAllClients();
            return new JavaScriptSerializer().Serialize(clients);
        }//allClients

    }//End class WebServiceLoginSoap
}//End namespace CoreVisesProyectoI
