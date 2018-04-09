using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectMPP.Repository;
using log4net.Config;
using ProiectMPP.Service;
using System.Configuration;

namespace ProiectMPP.UI
{
    public partial class LoadingAll : UserControl
    {
        
        public LoadingAll()
        {
            InitializeComponent();
           // loadService();
            //All.DataSource = service.getAllCurse();
        }
        ServiceOffice service;

        private void LoadingAll_Load(object sender, EventArgs e)
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
        private void All_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadService();
            All.DataSource = service.getAllCurse();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadService();
            All.DataSource = service.getAllCurse();
        }

        private void All_MouseClick(object sender, MouseEventArgs e)
        {
            loadService();
            All.DataSource = service.getAllCurse();
        }
    }
}
