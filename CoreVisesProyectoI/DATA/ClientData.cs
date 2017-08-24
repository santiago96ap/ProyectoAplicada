using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Core;

namespace DATA
{
    public class ClientData
    {
        public void insertClient() {
            try
            {

                MongoClient mc = new MongoClient("mongodb://aplicada:aplicada@ds139428.mlab.com:39428/info_aplicada_ucr");
           //     MongoServer ms = mc.GetServer();
             //   MongoDatabase db = ms.GetDatabase("info_aplicada_ucr");
              //  var rutina = new Rutina { accion = textBox1.Text, fecha = textBox2.Text };
               // MongoCollection colleccion = db.GetCollection<Rutina>("Store_aplicada");
               // colleccion.Insert<Rutina>(rutina);
               // MessageBox.Show("Datos Guardados correctamente");
            }
            catch (Exception error)
            {
               // MessageBox.Show("ocurrio un error" + error);
            }
        }
    }//end class
}//end namespace
