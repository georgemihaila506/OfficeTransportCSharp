using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMPP.Domain
{
    class Cursa
    {
        private string destinatie;
        private string data;
        private TimeSpan ora;
        private int nrLocuri;
        public Cursa(string destinatie, string data, TimeSpan ora,int nr)
        {
            this.Destinatie = destinatie;
            this.Data = data;
            this.Ora = ora;
            this.NrLocuri = nr;
        }

        public string Destinatie { get => destinatie; set => destinatie = value; }
        public string Data { get => data; set => data = value; }
        public TimeSpan Ora { get => ora; set => ora = value; }
        public int NrLocuri { get => nrLocuri; set => nrLocuri = value; }
    }
}
