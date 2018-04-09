using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMPP.Domain
{
    class User
    {
        private String username;
        private String password;
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
