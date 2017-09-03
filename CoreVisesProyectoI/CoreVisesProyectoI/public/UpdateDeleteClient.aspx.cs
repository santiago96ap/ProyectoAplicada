using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUSINESS;
using DOMAIN;

namespace CoreVisesProyectoI{
	public partial class UpdateDeleteClient : System.Web.UI.Page{
        //Attributes
        private String nameAttendant = "";
        private int attendantId = 0;
        private String mail = "";

        protected void Page_Load(object sender, EventArgs e){
            ClientBusiness clientBusiness = new ClientBusiness();
            if (IsPostBack){
                List<Client> client = clientBusiness.selectClient();
                this.nameAttendant = DropDownList1.SelectedItem.ToString();
                foreach (Client clientActual in client){
                    if (nameAttendant.Equals("Name: " + clientActual.name + " Mail:" + clientActual.mail + " Password:" + clientActual.pass + " Card:" + clientActual.card)){
                        this.mail = clientActual.mail;
                    }//End if (nameAttendant.Equals("Name: " + clientActual.name + " Mail:" + clientActual.mail + " Password:" + clientActual.pass + " Card:" + clientActual.card))
                }//End foreach (Client clientActual in client)
            }else{
                DropDownList1.Items.Clear();
                DropDownList1.Items.Add("Unselected");
                List<Client> client = clientBusiness.selectClient();
                foreach (var item in client){
                    DropDownList1.Items.Add("Name: " + item.name + " Mail:" + item.mail + " Password:" + item.pass + " Card:" + item.card);
                }//End foreach  (var item in client)
                this.nameAttendant = DropDownList1.SelectedItem.ToString();
                foreach (Client clientActual in client){
                    if (nameAttendant.Equals("Name: " + clientActual.name + " Mail:" + clientActual.mail + " Password:" + clientActual.pass + " Card:" + clientActual.card)){
                        this.mail = clientActual.mail;
                    }//End if (nameAttendant.Equals("Name: " + clientActual.name + " Mail:" + clientActual.mail + " Password:" + clientActual.pass + " Card:" + clientActual.card))
                }//End foreach (Client clientActual in client)
            }//End if-else(IsPostBack)
        }//End Page_Load

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e){
            this.nameAttendant = DropDownList1.SelectedItem.ToString();
        }//End DropDownList1_SelectedIndexChanged

        protected void Button2_Click(object sender, EventArgs e){
            ClientBusiness clientBusiness = new ClientBusiness();
            if ((clientBusiness.updateClient(tbNameUpdateDeleteClient.Text, this.mail, tbPassUpdateDeleteClient.Text, tbCardUpdateDeleteClient.Text))==1) {
                Label1.Text = "Successful update.";
            }//End if (clientBusiness.updateClient(tbNameUpdateDeleteClient.Text, this.mail, tbPassUpdateDeleteClient.Text, tbCardUpdateDeleteClient.Text)) 
        }//End Button2_Click

        protected void Button1_Click(object sender, EventArgs e){
            ClientBusiness clientBusiness = new ClientBusiness();
            if (clientBusiness.deleteClient(this.mail)) {
                Label1.Text = "Successful elimination";
            }//End if (clientBusiness.deleteClient(this.mail))
        }//End Button1_Click

    }//End class UpdateDeleteClient

}//End CoreVisesProyectoI