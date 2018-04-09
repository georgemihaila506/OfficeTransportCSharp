using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMPP.Domain
{
    class Rezervare
    {
        private string nume;
        private int nrLocuri;
        public Rezervare(string nume, int nrLocuri)
        {
            this.nume = nume;
            this.nrLocuri = nrLocuri;
        }

        public int NrLocuri { get => nrLocuri; set => nrLocuri = value; }
        public string Nume { get => nume; set => nume = value; }
        public override string ToString()
        {
            return nume + " " + nrLocuri;
        }
    }
}
