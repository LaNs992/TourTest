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
        public Autorization()
        {
            InitializeComponent();
        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {
            using (var db = new TourContext(DbOptions.Options()))
            {

                var login = textBoxLogin.Text;
                var password = textBoxPassword.Text;

                if (db.Users.Any(a => a.Username == login && a.Password == password))
                {
                    var currentUser = db.Users.FirstOrDefault(a => a.Username == login && a.Password == password);
                    TourForms ToursForm = new TourForms();
                    ToursForm.Show();
                    switch (currentUser.RoleId)
                    {
                        case 1:
                            profile.admin = true;
                            break;
                        case 2:
                            profile.manager = true;
                            break;
                        case 3:
                            profile.user = true;
                            break;
                    }

                }
                else
                {
                    MessageBox.Show("Неверный пароль или логин", "Ошибка авторизации");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            profile.user = true;

            TourForms ToursForm = new TourForms();
            
            ToursForm.ShowDialog();
        }
    }
}
