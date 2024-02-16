using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using TourTest.Models.profiles;

namespace TourTest.Forms.Main
{
   
    public partial class ZakazForm : Form
    {
        public string Username;
        public ZakazForm(string login)
        {
            InitializeComponent();
            Username = login;
            initDatagrid();
        }

        public void initDatagrid()
        {
            using (var db = new TourContext(DbOptions.Options()))
            {
                dataGridView1.DataSource = db.Orders.Select(x => new Models.Order
                {
                    IdOrder = x.IdOrder,
                    User = x.User,
                    DateOrder = x.DateOrder,
                    TourId = x.TourId,
                    Cost = x.Cost,
                    Discount = x.Discount,
                    PickUpCode = x.PickUpCode,
                    PickUpPoint = x.PickUpPoint,
                    
                }).ToList();

                var count = db.Hotels.Count();

                
               
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Все")
            {
                initDatagrid();
            }
            else
            if (comboBox1.Text != "15") {
                dataGridView1.DataSource = null;
            
                using (var db = new TourContext(DbOptions.Options()))
                {
                    dataGridView1.DataSource = db.Orders.Select(x => new Models.Order
                    {
                        IdOrder = x.IdOrder,
                        User = x.User,
                        DateOrder = x.DateOrder,
                        TourId = x.TourId,
                        Cost = x.Cost,
                        Discount = x.Discount,
                        PickUpCode = x.PickUpCode,
                        PickUpPoint = x.PickUpPoint,

                    }).Where(x => x.Discount == 15).ToList();

                    var count = db.Hotels.Count();
                };
                 
                
            }
            if (comboBox1.Text == "0-10%")
            {
                dataGridView1.DataSource = null;

                using (var db = new TourContext(DbOptions.Options()))
                {
                    dataGridView1.DataSource = db.Orders.Select(x => new Models.Order
                    {
                        IdOrder = x.IdOrder,
                        User = x.User,
                        DateOrder = x.DateOrder,
                        TourId = x.TourId,
                        Cost = x.Cost,
                        Discount = x.Discount,
                        PickUpCode = x.PickUpCode,
                        PickUpPoint = x.PickUpPoint,

                    }).Where(x => x.Discount <= 10).ToList();

                    var count = db.Hotels.Count();
                };



            }

        }
    }
}
