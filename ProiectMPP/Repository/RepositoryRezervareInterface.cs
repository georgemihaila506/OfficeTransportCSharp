using ProiectMPP.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMPP.Repository
{
    interface RepositoryRezervareInterface:IRepository<Rezervare>
    {
        void rezerva(int codCursa, Cursa cursa, Rezervare rezervare);
        List<Rezervare> cautaRezervari(int codCursa);
        List<Rezervare> getAll1();
    }
}
