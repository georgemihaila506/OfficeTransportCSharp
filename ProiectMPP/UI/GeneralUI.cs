using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectMPP.UI
{
    public partial class GeneralUI : Form
    {
        public GeneralUI()
        {
            InitializeComponent();
            loadingAll1.BringToFront();
        }

        private void Sign_Out(object sender, EventArgs e)
        {
            Application.Exit();          
        }

        private void loadingAll1_Load(object sender, EventArgs e)
        {
            loadingAll1.Controls.Clear();
           // loadingAll1 = new FindUser();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            findUser1.BringToFront();
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            reserve1.BringToFront();
        }
    }
}
