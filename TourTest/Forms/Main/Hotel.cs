using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourTest.Forms.Main
{
    public partial class Hotel : Form
    {
        public string Username;
        public Hotel(string login)
        {
            Username= login;
            InitializeComponent();
            UserN.Text = Username;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
