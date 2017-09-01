using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoreVisesProyectoI{
	public partial class RegisterProduct : System.Web.UI.Page{
        protected void Page_Load(object sender, EventArgs e){
           
        }//End Page_Load
        protected void Button2_Click(object sender, EventArgs e){
            if (FileUpload1.HasFile){
                //si hay una archivo.
                string nombreArchivo = FileUpload1.FileName;
                string ruta = "~/Fotos/" + nombreArchivo;
                FileUpload1.SaveAs(Server.MapPath(ruta));

                Label1.Text = Environment.NewLine + ruta;
            }//End if (FileUpload1.HasFile)
        }//End Button2_Click
    }//End class RegisterProduct
}//End namespace CoreVisesProyectoI