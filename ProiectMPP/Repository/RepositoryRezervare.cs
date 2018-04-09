using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using ProiectMPP.Domain;

namespace ProiectMPP.Repository
{

    class RepositoryRezervare : RepositoryRezervareInterface
    {
        private static readonly ILog log = LogManager.GetLogger("RepositoryCursa");
        IDictionary<string, string> properties;
        public RepositoryRezervare(IDictionary<string, string> properties)
        {
            this.properties = properties;
        }
        public void addEntity(Rezervare entity)
        {
            throw new NotImplementedException();
        }

        public List<Rezervare> cautaRezervari(int codCursa)
        {
            log.InfoFormat("Entering findOne with value {0}", codCursa);
            IDbConnection con = RepoUtils.getConnection(properties);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select Nume,NrLocuri algoritm  from Rezervari where CodCursa=@CodCursa";
                IDbDataParameter paramCod = comm.CreateParameter();
                //
                paramCod.ParameterName = "@CodCursa";
                paramCod.Value = codCursa;
                //                               
                comm.Parameters.Add(paramCod);

                using (var dataR = comm.ExecuteReader())
                {
                    List<Rezervare> rezervari = new List<Rezervare>();
                    while (dataR.Read())
                    {
                        string nume = dataR.GetString(0);
                        int nr = dataR.GetInt32(1);
                        rezervari.Add(new Rezervare(nume, nr));
                    }
                    return rezervari;
                }
            }
            log.InfoFormat("Exiting cautaRezervari with value {0}", null);
            return null;
        }

        public void deleteEntity(Rezervare entity)
        {
            throw new NotImplementedException();
        }

        public void findOne(Rezervare entity)
        {
            throw new NotImplementedException();
        }
        public List<Rezervare> getAll()
        {
            return null;
        }
        public List<Rezervare> getAll1()
        {
            log.InfoFormat("Entering findOne with value {0}");
            IDbConnection con = RepoUtils.getConnection(properties);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select Nume,NrLocuri algoritm  from Rezervari";
                IDbDataParameter paramCod = comm.CreateParameter();
                using (var dataR = comm.ExecuteReader())
                {                   
                    List<Rezervare> rezervari = new List<Rezervare>();
                     while (dataR.Read())
                     {
                         string nume = dataR.GetString(0);
                         int nr = dataR.GetInt32(1);
                         rezervari.Add(new Rezervare(nume, nr));
                     }
                    return rezervari;
                }
            }
            log.InfoFormat("Exiting cautaRezervari with value {0}", null);
            return null;
        }

        public void rezerva(int codCursa,Cursa cursa, Rezervare rezervare)
        {
            log.InfoFormat("Entering rezerva");
            IDbConnection con = RepoUtils.getConnection(properties);

                using (var comm = con.CreateCommand())
                {
                    comm.CommandText = "insert into Rezervari(Nume,NrLocuri,CodCursa) values(@Nume,@NrLocuri,@CodCursa) ";

                    //
                    IDbDataParameter paramCod = comm.CreateParameter();
                    paramCod.ParameterName = "@CodCursa";
                    paramCod.Value = codCursa;
                    //
                    IDbDataParameter paramNrLocuri = comm.CreateParameter();
                    paramNrLocuri.ParameterName = "@NrLocuri";
                    paramNrLocuri.Value = rezervare.NrLocuri;
                    //
                    IDbDataParameter paramNume = comm.CreateParameter();
                    paramNume.ParameterName = "@Nume";
                    paramNume.Value = rezervare.Nume;

                    comm.Parameters.Add(paramNume);
                    comm.Parameters.Add(paramNrLocuri);
                    comm.Parameters.Add(paramCod);

                    using (var dataR = comm.ExecuteReader())
                    {
                        log.InfoFormat("Exiting rezervare with value ");
                    }

                
            }
        }

    }
}
