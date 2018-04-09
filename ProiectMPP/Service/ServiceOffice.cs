using ProiectMPP.Domain;
using ProiectMPP.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMPP.Service
{
    class ServiceOffice
    {
        private RepositoryCursaInterface repoCursa;
        private RepositoryRezervareInterface repoRezervare;
        public ServiceOffice(RepositoryCursaInterface repoCursa, RepositoryRezervareInterface repoRezervare)
        {
            this.repoCursa = repoCursa;
            this.repoRezervare = repoRezervare;
        }
        public void rezerva(Cursa cursa, Rezervare rezervare)
        {
            int codCursa = repoCursa.cautaCursa(cursa);
            int nrLocuriDisponibile = repoCursa.getNrLocuriDisponibile(codCursa);
            if (nrLocuriDisponibile >= rezervare.NrLocuri)
            {
                repoRezervare.rezerva(codCursa, cursa, rezervare);
                repoCursa.updateNrLocuri(rezervare.NrLocuri, codCursa);

            }
        }
        public List<Rezervare> cautaRezervari(Cursa cursa)
        {
            return repoRezervare.cautaRezervari(repoCursa.cautaCursa(cursa));
        }
        public List<Rezervare> getAll()
        {
            return repoRezervare.getAll1();
        }
        public List<Cursa> getAllCurse()
        {
            return repoCursa.getAll();
        }
    }
}
