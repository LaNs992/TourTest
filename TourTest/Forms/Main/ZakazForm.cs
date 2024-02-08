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

                //var pageLength = (int)Math.Ceiling((float)count / sizePage);


            //    switch (comboBox1.SelectedIndex)
            //    {
            //        case 0:
            //            DataView dv = table.DefaultView;
            //            dv.RowFilter = "FirstName LIKE '" + txtSearch.Text + "%'";
            //            dataGridView1.DataSource = dv;
            //            break;
            //        case 1:
            //            DataView dv = table.DefaultView;
            //            dv.RowFilter = "FirstName LIKE '" + txtSearch.Text + "%'";
            //            dataGridView1.DataSource = dv;

            //            break;
            //        case 2:
                       
            //            break;
            //    }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            initDatagrid();
        }
    }
}
