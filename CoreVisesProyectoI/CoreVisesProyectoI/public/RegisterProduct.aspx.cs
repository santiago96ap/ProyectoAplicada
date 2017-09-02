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

            try{
                if (FileUpload1.HasFile){
                    // Se verifica que la extensión sea de un formato válido
                    string ext = FileUpload1.PostedFile.FileName;
                    ext = ext.Substring(ext.LastIndexOf(".") + 1).ToLower();
                    string[] formatos = new string[] { "jpg", "jpeg", "bmp", "png", "gif" };
                    if (Array.IndexOf(formatos, ext) < 0){
                        Label1.Text = "Formato de imagen inválido.";
                    }else {
                        String paht = saveImagen(FileUpload1.PostedFile);
                        Label1.Text = paht;
                    }//End if (Array.IndexOf(formatos, ext) < 0)
                } else
                    Label1.Text =  "Seleccione un archivo del disco duro.";
            }catch (Exception ex){
                Label1.Text = ex.Message;
            }//End catch (Exception ex)

            /*if (FileUpload1.HasFile){
                //si hay una archivo.
                string nombreArchivo = FileUpload1.FileName;
                string ruta = "~/Fotos/" + nombreArchivo;
                FileUpload1.SaveAs(Server.MapPath(ruta));

                Label1.Text = Environment.NewLine + ruta;
            }//End if (FileUpload1.HasFile)*/
        }//End Button2_Click

        public String saveImagen(HttpPostedFile file) {            
            string savePath = "c:\\temp\\uploads\\";
            string fileName = FileUpload1.FileName;
            string pathToCheck = savePath + fileName;
            string tempfileName = "";
            if (System.IO.File.Exists(pathToCheck)){
                int counter = 2;
                while (System.IO.File.Exists(pathToCheck)){
                    tempfileName = counter.ToString() + fileName;
                    pathToCheck = savePath + tempfileName;
                    counter++;
                }//End while (System.IO.File.Exists(pathToCheck))
                fileName = tempfileName;
                Label1.Text = "A file with the same name already exists. Your file was saved as " + fileName;
            }else{
                // Notify the user that the file was saved successfully.
                Label1.Text = "Your file was uploaded successfully.";
            }//End if-else (System.IO.File.Exists(pathToCheck))
            savePath += fileName;
            FileUpload1.SaveAs(savePath);
            return savePath;
        }//End saveImagen
    }//End class RegisterProduct
}//End namespace CoreVisesProyectoI