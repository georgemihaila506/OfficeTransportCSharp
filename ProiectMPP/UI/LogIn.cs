using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectMPP.Repository;
using ProiectMPP.Service;

namespace ProiectMPP.UI
{
    public partial class LogIn : Form
    {
        //ServiceOffice service;
        ServiceOffice service;
        public LogIn()
        {
            InitializeComponent();
            Password._TextBox.PasswordChar = '*';
        }
        


        private void Username_Enter(object sender, EventArgs e)
        {
            if (Username.text == "Username")
                Username.text = "";
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (Username.text == "")
                Username.text = "Username";
        }

        private void Password_Enter(object sender, EventArgs e)
        {

            if (Password.text == "Password")
                Password.text = "";
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.text == "")
                Password._TextBox.Text = "Password";
        }

        private void LogInLabel_Click(object sender, EventArgs e)
        {

        }

        private void LogInAction_Click(object sender, EventArgs e)
        {
            if (Username.text != "" && Password.text != "")
            {
                this.Hide();
                GeneralUI generalUI = new GeneralUI();
                generalUI.ShowDialog();
                this.Close();
            }
            
        }

        private void Username_OnTextChange(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
