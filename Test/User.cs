using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class User
    {

        private string idUser;
        private string userType;
        private string identif;
        public string Id
        {
            get { return idUser; }
            set { idUser = value; }
        }
        public string UserType
        {
            get { return userType; }
            set { userType = value; }
        }
        public User(string id, string type, string ident)
        {
            idUser = id;
            userType = type;
            identif = ident;
        }

        public string Identif
        {
            get { return identif; }
            set { identif =  value; }
        }

    }
}
