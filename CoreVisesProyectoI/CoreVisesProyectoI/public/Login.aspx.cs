using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using BUSINESS;

namespace CoreVisesProyectoI
{
	public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            if (!Session["usuario"].Equals("N"))
            {
                Session["usuario"] = "N";
                Session["correo"] = "N";
            }
        }

        protected void Buttonlogin_Click(object sender, EventArgs e)
        {
            String pass = tbPasswordLogin.Text;
            String email = tbEmailLogin.Text;
            ManagerBusiness mb = new ManagerBusiness();
            Boolean exits =  mb.loginClient(email,pass);
            if (exits)
            {
                Session["usuario"] = "A";
                Session["correo"] = tbEmailLogin.Text;
                Response.BufferOutput = true;
                Response.Redirect("http://192.168.43.183:8094/public/Default.aspx");
            }
            else {
                Label1.Text = "Incorrect data";
            }
        }
    }
}