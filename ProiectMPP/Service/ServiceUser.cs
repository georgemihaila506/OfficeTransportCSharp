using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectMPP.Repository;

namespace ProiectMPP.Service
{
    class ServiceUser
    {
        private RepositoryUserInterface repoUser;
        public ServiceUser(RepositoryUserInterface repoUser)
        {
            this.repoUser = repoUser;
        }
    }
}
