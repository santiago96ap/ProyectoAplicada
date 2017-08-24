using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using DOMAIN;

namespace BUSINESS
{
    public class ClientBusiness
    {
        private ClientData cd;

        public Boolean insertClient(String name, String mail, String pass, String card)
        {
            return cd.insertClient(name,mail,pass,card);
        }//end insertClient

        public List<Client> selectClient()
        {
            return cd.selectClient();
        }//end insertClient

        public Boolean deleteClient(String name)
        {
            return deleteClient(name);
        }//end deleteClient

        public Boolean updateClient(String name, String mail, String pass)
        {
            return updateClient(name, mail, pass);
        }//end updateClient

    }//end class
}//end namespace
