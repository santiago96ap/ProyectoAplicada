using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUSINESS;
using UTIL;

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
                        Label1.Text = "Invalid image format.";
                    }else {
                        String paht = saveImagen(FileUpload1.PostedFile);
                        
                        ProductBusiness pb = new ProductBusiness();
                        RSA rsa = new RSA();

                        byte[] nameBytes = rsa.EncryptText(tbNameRegisterProduct.Text, rsa.PublicKey);
                        byte[] CategoryBytes = rsa.EncryptText(tbCategoryRegisterProduct.Text, rsa.PublicKey);
                        byte[] priceBytes = rsa.EncryptText(tbPriceRegisterProduct.Text, rsa.PublicKey);
                        byte[] quantityBytes = rsa.EncryptText(tbQuantityRegisterProduct.Text, rsa.PublicKey);
                        byte[] stateBytes = rsa.EncryptText(tbStateRegisterProduct.Text, rsa.PublicKey);
                        byte[] pathBytes = rsa.EncryptText(paht, rsa.PublicKey);

                        string nameDecrypted = Convert.ToBase64String(nameBytes);
                        string categoryDecrypted = Convert.ToBase64String(CategoryBytes);
                        string priceDecrypted = Convert.ToBase64String(priceBytes);
                        string quantityDecrypted = Convert.ToBase64String(quantityBytes);
                        string stateDecrypted = Convert.ToBase64String(stateBytes);
                        string pathDecrypted = Convert.ToBase64String(pathBytes);

                        pb.insertProduct(nameDecrypted, categoryDecrypted, priceDecrypted, quantityDecrypted, stateDecrypted, pathDecrypted);
                        Label1.Text = "Successful product registration.";
                    }//End if (Array.IndexOf(formatos, ext) < 0)
                } else
                    Label1.Text = "Select a file from the hard disk.";
            }catch (Exception ex){
                Label1.Text = ex.Message;
            }//End catch (Exception ex)
        }//End Button2_Click

        public String saveImagen(HttpPostedFile file) {            
            string savePath = "c:\\Program Files (x86)\\EasyPHP-Devserver-16.1\\eds-www\\GremlinStore\\public\\images\\";
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
                savePath += fileName;
                FileUpload1.SaveAs(savePath);
            }else{
                // Notify the user that the file was saved successfully.
                Label1.Text = "Your file was uploaded successfully.";
                savePath += fileName;
                FileUpload1.SaveAs(savePath);
            }//End if-else (System.IO.File.Exists(pathToCheck))
            return savePath;
        }//End saveImagen
    }//End class RegisterProduct
}//End namespace CoreVisesProyectoI