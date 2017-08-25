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

            /* Ejemplo de como instanciar y usar RSA            
               
            RSA rsa = new RSA(); lo instancia
               
            byte[] nameBytes = rsa.DecryptText(name, rsa.PrivateKey); name es la variable encriptada que recibe por parametros de tipo string

            byte[] phoneBytes = rsa.DecryptText(phone, rsa.PrivateKey);  phone es la variable encriptada que recibe por parametros de tipo string

            string nameDecrypted = Encoding.ASCII.GetString(nameBytes); Son los datos ya desencriptados de la variable name

            string phoneDecrypted = Encoding.ASCII.GetString(phoneBytes); Son los datos ya desencriptados de la variable phone */
        }//End LoginClient

        [WebMethod]
        public void RegisterClient() {
        }//End RegisterClient

    }//End class WebServiceLoginSoap

}//End namespace CoreVisesProyectoI
