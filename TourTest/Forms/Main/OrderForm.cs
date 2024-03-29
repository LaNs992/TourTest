﻿using Microsoft.EntityFrameworkCore;
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
using TourTest.Forms.Main.HelperForm;
using TourTest.Models;
using TourTest.Models.profiles;

namespace TourTest.Forms.Main
{
    public partial class OrderForm : Form
    {
        private Dictionary<Tour, int> orders;
        public decimal sum = 0;
        private int discount = 0;
        public string Username;

        public OrderForm(Dictionary<Tour, int> orders, string login)
        {
            InitializeComponent();
            this.orders = orders;
            Username = login;
            UserLbl.Text = Username;
            //var user = WorkToUser.User;
            //labelFIO.Text = $"{user.Surname} {user.Name} {user?.Patronymic}";

            foreach (var item in orders.Keys)
            {
                var orderView = new OrderViewer(item, orders[item]);
                orderView.ChangeCount += UpdateSum;
                orderView.Visible = true;
                orderView.Margin = new Padding(0, 0, 0, 50);
                orderView.Parent = flowLayoutPanel1;
                sum += item.Price * orderView.Count;
            }
            PeiceLbl.Text = $"{sum:C2}";
            Roles();
            using (var db = new TourContext())
            {
                comboBox.DisplayMember = "Title";
                //comboBox.Items.AddRange(db.ReceivingPoints.ToArray());
                comboBox.SelectedIndex = 0;
            }
        }
        private void UpdateSum()
        {
            sum = 0;
            foreach (var item in flowLayoutPanel1.Controls)
            {
                if (item is OrderViewer orderView)
                {
                    sum += orderView.Tour.Price * orderView.Count;
                    if (orders.TryGetValue(orderView.Tour, out var count))
                    {
                        orders[orderView.Tour] = orderView.Count;
                    }
                }
            }
            PeiceLbl.Text = $"{sum:C2}";
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {

        }
        public void Roles()
        {
            if (profile.user == 2 || profile.user == 1)
            {
                butZakaz.Enabled = true;

            }
            else
            {
                butZakaz.Enabled = true;
                comboBox.Enabled = false;

            }

        }
        private void butZakaz_Click(object sender, EventArgs e)
        {

            var rnd = new Random();
            var code = rnd.Next(100, 1000);
            foreach (var item in orders.Keys)
            {
                var orderViwer = new OrderViewer(item, orders[item]);
                var order = new Order()
                {

                    Cost = (int)sum,
                    PickUpCode = code,
                    Discount = (double)numericUpDown1.Value,
                    PickUpPoint = comboBox.Text,
                    TourId = item.Id,
                    User = Username

                };
                using (var db = new TourContext(DbOptions.Options()))
                {

                    db.Orders.Add(order);
                    db.SaveChanges();
                    this.Close();
                }
                MessageBox.Show("Вы успешно оформили заказ!");

            }
        }

    }
}

      
