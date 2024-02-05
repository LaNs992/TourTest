﻿using System;
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

            TourForms ToursForm = new TourForms(login);
            
            ToursForm.ShowDialog();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
