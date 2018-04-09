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
    class RepositoryCursa:RepositoryCursaInterface
    {
        private static readonly ILog log = LogManager.GetLogger("RepositoryCursa");
        IDictionary<string, string> properties;
        public RepositoryCursa(IDictionary<string,string> props)
        {
            log.Info("Creating RepositoryCursa!");
            this.properties = props;
        }
        public void updateNrLocuri(int nrLocuri, int codCursa)
        {
            log.InfoFormat("Entering rezerva");
            IDbConnection con = RepoUtils.getConnection(properties);
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "update Curse set NrLocuriDisponibile=NrLocuriDisponibile-@Nr where CodCursa=@CodCursa";


                //
                IDbDataParameter paramCod = comm.CreateParameter();
                paramCod.ParameterName = "@CodCursa";
                paramCod.Value = codCursa;
                //
                IDbDataParameter paramNrLocuri = comm.CreateParameter();
                paramNrLocuri.ParameterName = "@Nr";
                paramNrLocuri.Value = nrLocuri;
                //

                comm.Parameters.Add(paramNrLocuri);
                comm.Parameters.Add(paramCod);

                using (var dataR = comm.ExecuteReader())
                {
                    log.InfoFormat("Exiting updateNrLocuri with value ");

                }

            
        }
    }

        public int getNrLocuriDisponibile(int codCursa)
        {
            log.InfoFormat("Entering getNrLocuriDisponibile");
            IDbConnection con = RepoUtils.getConnection(properties);
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select NrLocuriDisponibile algorithm from Curse where CodCursa=@CodCursa";
                IDbDataParameter paramCod = comm.CreateParameter();

                paramCod.ParameterName = "@CodCursa";
                paramCod.Value = codCursa;
                comm.Parameters.Add(paramCod);
                using (var dataR = comm.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        int nr  = dataR.GetInt32(0);
                        log.InfoFormat("Exiting getNrLocuriDisponibile with value {0}", codCursa);
                        return nr;
                    }
                }
            }
            return 0;
        }      
        public int cautaCursa(Cursa cursa)
        {
            log.InfoFormat("Entering findOne with value {0}", cursa);
            IDbConnection con = RepoUtils.getConnection(properties);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select CodCursa algoritm  from Curse where Destinatie=@Destinatie and Data=@Data and Ora=@Ora";
                IDbDataParameter paramDestinatie = comm.CreateParameter();
                IDbDataParameter paramData = comm.CreateParameter();
                IDbDataParameter paramOra = comm.CreateParameter();
                //
                paramDestinatie.ParameterName = "@Destinatie";
                paramDestinatie.Value = cursa.Destinatie;
                //               
                paramData.ParameterName = "@Data";
                paramData.Value =cursa.Data;             
                //
                paramOra.ParameterName = "@Ora";
                paramOra.Value =cursa.Ora;
                //              
                comm.Parameters.Add(paramDestinatie);
                comm.Parameters.Add(paramOra);
                comm.Parameters.Add(paramData);

                using (var dataR = comm.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        int codCursa = dataR.GetInt32(0);
                        log.InfoFormat("Exiting findOne with value {0}",codCursa);
                        return codCursa;
                    }
                }
            }
            log.InfoFormat("Exiting cautaCursa with value {0}", -1);
            Console.WriteLine("cica");
            return -1;
        }

        public void addEntity(Cursa entity)
        {
            throw new NotImplementedException();
        }

        public void deleteEntity(Cursa entity)
        {
            throw new NotImplementedException();
        }

        public List<Cursa> getAll()
        {
            log.InfoFormat("Entering findOne with value {0}");
            IDbConnection con = RepoUtils.getConnection(properties);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select Destinatie,Data,Ora,NrLocuriDisponibile algoritm  from Curse";
                IDbDataParameter paramCod = comm.CreateParameter();
                using (var dataR = comm.ExecuteReader())
                {
                    List<Cursa> curse = new List<Cursa>();
                    while (dataR.Read())
                    {
                        string destinatie = dataR.GetString(0);
                        string data = dataR.GetString(1);
                        TimeSpan ora = dataR.GetDateTime(2).TimeOfDay;
                        int nr = dataR.GetInt32(3);
                        curse.Add(new Cursa(destinatie,data,ora,nr));
                    }
                    return curse;
                }
            }
            log.InfoFormat("Exiting cautaRezervari with value {0}", null);
            return null;
        }

        public void findOne(Cursa entity)
        {
            throw new NotImplementedException();
        }
    }
}
