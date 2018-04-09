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
    public partial class Reserve : UserControl
    {
        ServiceOffice service;
        public Reserve()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

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
        private void reserveButton_Click(object sender, EventArgs e)
        {
            loadService();
            Rezervare rezervare = new Rezervare(nameText.Text, Int32.Parse(numberText.Text));
            string[] timp = timeText.Text.Split(':');
            TimeSpan time = new TimeSpan(int.Parse(timp[0]), int.Parse(timp[1]), 0);
            Cursa cursa = new Cursa(destinationText.Text, dateText.Text, time,0);
            service.rezerva(cursa, rezervare);
        }
    }
}
