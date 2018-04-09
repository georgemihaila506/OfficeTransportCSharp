using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectMPP.Repository;
using System.Configuration;
using log4net.Config;
using ProiectMPP.Domain;
using ProiectMPP.UI;
namespace ProiectMPP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            XmlConfigurator.Configure(new System.IO.FileInfo(args[0]));
            Console.WriteLine("Configuration Settings for OfficeTransport {0}", GetConnectionStringByName("OfficeTransport"));
            IDictionary<String, string> props = new SortedList<String, String>();
            props.Add("ConnectionString", GetConnectionStringByName("OfficeTransport"));
            //SimpleDateFormat dateFormat = new SimpleDateFormat("YYYY-MM-DD");
            //String dateFormated = dateFormat.format(date);
            RepositoryCursa repository = new RepositoryCursa(props);
            TimeSpan t = new TimeSpan(14, 15, 0);
            DateTime d = new DateTime(2018, 3, 15);
            Console.WriteLine(t+" "+d);
           // Console.WriteLine(repository.cautaCursa(new Domain.Cursa("Bucuresti","2018-03-15",t)));
            //repository.rezerva(new Cursa("Bucuresti", "2018-03-15", t), new Rezervare("Gigis", 3));
            //List<Rezervare> a = repository.cautaRezervari(repository.cautaCursa(new Domain.Cursa("Bucuresti", "2018-03-15", t)));       
            ////foreach (var aux in a)
            //Console.WriteLine(aux); 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LogIn log=new LogIn();           
            Application.Run(log);
  
        }
        static string GetConnectionStringByName(string name)
        {
            // Assume failure.
            string returnValue = null;

            // Look for the name in the connectionStrings section.
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];

            // If found, return the connection string.
            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }
    }
}
