using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectMPP.Service;
using log4net.Config;
using ProiectMPP.Repository;
using ProiectMPP.Domain;
using System.Configuration;

namespace ProiectMPP.UI
{
    public partial class FindUser : UserControl
    {
        ServiceOffice service;
        public FindUser()
        {
            InitializeComponent();
        }
        private void loadService()
        {
            XmlConfigurator.Configure(new System.IO.FileInfo("log4j.xml"));
            Console.WriteLine("Configuration Settings for OfficeTransport {0}", GetConnectionStringByName("OfficeTransport"));
            IDictionary<String, string> props = new SortedList<String, String>();
            props.Add("ConnectionString", GetConnectionStringByName("OfficeTransport"));
            //SimpleDateFormat dateFormat = new SimpleDateFormat("YYYY-MM-DD");
            //String dateFormated = dateFormat.format(date);
            RepositoryCursa repository = new RepositoryCursa(props);
            RepositoryRezervare repositoryRezervare = new RepositoryRezervare(props);
            this.service = new ServiceOffice(repository, repositoryRezervare);
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
        private void SearchButtonU_Click(object sender, EventArgs e)
        {
            loadService();

            string[] variabilaTime=TimeText.Text.Split(':');
            TimeSpan timeSpan = new TimeSpan(Int32.Parse(variabilaTime[0]), Int32.Parse(variabilaTime[1]), 0);

            string dataM = dateText.Text;
            string destination = bunifuMaterialTextbox1.Text;
            TimeSpan t = new TimeSpan(14, 15, 0);
            Cursa c = new Cursa("Bucuresti", dataM, timeSpan, 0);
            
            Cursa cursa = new Cursa(destination, "2018-03-15", t,0);            
            var rez = service.cautaRezervari(c);
            AllDataGrid.DataSource = rez;
        }
    }
}
