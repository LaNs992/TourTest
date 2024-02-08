using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourTest.context;
using TourTest.Forms.Main;
using TourTest.Models;
using TourTest.Models.profiles;

namespace TourTest.Forms.autoriz
{
    public partial class Autorization : Form
    {
        public string login;
        public Autorization()
        {
            InitializeComponent();
        }
  
        private void buttonAuto_Click(object sender, EventArgs e)
        {
            using (var db = new TourContext(DbOptions.Options()))
            {

                login = textBoxLogin.Text;
                var password = textBoxPassword.Text;

                if (db.Users.Any(a => a.Username == login && a.Password == password))
                {
                    var currentUser = db.Users.FirstOrDefault(a => a.Username == login && a.Password == password);
                    TourForms ToursForm = new TourForms(login);
                   
                    switch (currentUser.RoleId)
                    {
                        case 1:
                            profile.user = 1;
                            break;
                        case 2:
                            profile.user = 2;
                            break;
                        case 3:
                            profile.user = 3;
                            break;
                    }
                    ToursForm.Show();

                }
                else
                {
                    MessageBox.Show("Неверный пароль или логин", "Ошибка авторизации");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            TourForms ToursForm = new TourForms(login);
            
            ToursForm.ShowDialog();
        }

        
    }
}
