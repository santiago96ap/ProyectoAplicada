using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUSINESS;
using UTIL;
using DOMAIN;
using System.Text;

namespace CoreVisesProyectoI
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ManagerBusiness mb = new ManagerBusiness();
            RSA rsa = new RSA();

            byte[] nameBytes = rsa.EncryptText(tbEmailRegister.Text, rsa.PublicKey);
            byte[] passBytes = rsa.EncryptText(tbPassRegister.Text, rsa.PublicKey);
            byte[] typeBytes = rsa.EncryptText("a", rsa.PublicKey);

            string nameDecrypted = Convert.ToBase64String(nameBytes);
            string passDecrypted = Convert.ToBase64String(passBytes);
            string typeDecrypted = Convert.ToBase64String(typeBytes);

            Boolean successful = mb.insertManager(nameDecrypted,passDecrypted,typeDecrypted);

            if (successful) {
                Label1.Text = "Register Sucessful";
            } else {
                Label1.Text = "Register Error";
            }//End if-else (successful)

        }
    }
}