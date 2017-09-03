using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUSINESS;
using DOMAIN;

namespace CoreVisesProyectoI{
	public partial class UpdateDeleteProducts : System.Web.UI.Page{

        //Attributes
        private String nameAttendant = "";
        private int attendantId = 0;
        private String name = "";
        private String path = "";
        private Product p;

        protected void Page_Load(object sender, EventArgs e){
            ProductBusiness productBusiness = new ProductBusiness();
            if (IsPostBack){                
                List<Product> product = productBusiness.selectProduct();
                this.nameAttendant = DropDownList1.SelectedItem.ToString();
                foreach (Product productActual in product){
                    if (nameAttendant.Equals("Name: " + productActual.name + " Category:" + productActual.category + " Precie:" + productActual.price + " Quantity:" + productActual.quantity + " Status:" + productActual.status)){
                        this.name = productActual.name;
                        this.p = productActual;
                        this.path = productActual.path;
                    }//End if  if (nameAttendant.Equals("Name: " + productActual.name + " Category:" + productActual.category + " Precie:" + productActual.price + " Quantity:" + productActual.quantity + " Status:" + productActual.status))
                }//End foreach (Product productActual in product)
            }else {
                DropDownList1.Items.Clear();
                DropDownList1.Items.Add("Unselected");
                List<Product> product = productBusiness.selectProduct();
                foreach (var item in product){
                    DropDownList1.Items.Add("Name: " + item.name + " Category:" + item.category + " Precie:" + item.price + " Quantity:" + item.quantity + " Status:" + item.status);
                }//End foreach  (var item in product)
                this.nameAttendant = DropDownList1.SelectedItem.ToString();
                foreach (Product productActual in product){
                    if (nameAttendant.Equals("Name: " + productActual.name + " Category:" + productActual.category + " Precie:" + productActual.price + " Quantity:" + productActual.quantity + " Status:" + productActual.status)){
                        this.name = productActual.name;
                        this.p = productActual;
                        this.path = productActual.path;
                    }//End if  if (nameAttendant.Equals("Name: " + productActual.name + " Category:" + productActual.category + " Precie:" + productActual.price + " Quantity:" + productActual.quantity + " Status:" + productActual.status))
                }//End foreach (Product productActual in product)
            }//End if-else(IsPostBack)

        }//End Page_Load

        protected void Button2_Click(object sender, EventArgs e){
            ProductBusiness productBusiness = new ProductBusiness();
            if (productBusiness.updateProduct(this.name, tbCategoryUpdateDeleteProduct.Text, int.Parse(tbPriceUpdateDeleteProduct.Text), int.Parse(tbQuantityUpdateDeleteProduct.Text), tbStateUpdateDeleteProduct.Text, this.path)) {
                Label1.Text = "Successful update.";
            }//End if (productBusiness.updateProduct(this.name,this.categoy,this.price,this.quantity,this.status,this.path))
        }//End Button2_Click

        protected void Button1_Click(object sender, EventArgs e){
            ProductBusiness productBusiness = new ProductBusiness();
            if (productBusiness.deleteProduct(this.name)) {
                Label1.Text = "Successful elimination";
            }//End if (productBusiness.deleteProduct(this.nameAttendant))
        }//End Button1_Click

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e){
            this.nameAttendant = DropDownList1.SelectedItem.ToString();
        }//End DropDownList1_SelectedIndexChanged

    }//End class UpdateDeleteProducts

}//End namespace CoreVisesProyectoI