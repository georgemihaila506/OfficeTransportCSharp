using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectMPP.Domain;

namespace ProiectMPP.Repository
{
    interface RepositoryCursaInterface:IRepository<Cursa>
    {
        int cautaCursa(Cursa cursa);
        void updateNrLocuri(int nrLocuri, int codCursa);
        int getNrLocuriDisponibile(int codCursa);
    }
}
