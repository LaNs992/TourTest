using Microsoft.EntityFrameworkCore;
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
using static System.Net.Mime.MediaTypeNames;

namespace TourTest.Forms.Main
{
    public partial class HotelForm : Form
    {
        private int sizePage = 10;
        private int oldCurrent = -1;
        private BindingSource bindingSource;
        public string Username;
        public HotelForm(string login)
        {
            Username= login;
            InitializeComponent();
            UserN.Text = Username;
            Roles();
            initDatagrid();
        }
        public Hotel hotel1;
        public void initDatagrid()
        {
            using (var db = new TourContext(DbOptions.Options()))
            {
                dataGridView1.DataSource = db.Hotels.Select(x => new Models.Hotel
                {
                    Id = x.Id,
                    Name = x.Name,
                    CountOfStars = x.CountOfStars,
                    CountryCode = x.CountryCode,
                    Description = x.Description,             
                }).ToList();

                var count = db.Hotels.Count();

                //var pageLength = (int)Math.Ceiling((float)count / sizePage);
                toolStripStatusLabel1.Text = $"Кол-во записей: {count}";


            }
        }

        

        private void butAdd_Click(object sender, EventArgs e)
        {
            var addHotelForm = new AddHotelForm();
            if (addHotelForm.ShowDialog() == DialogResult.OK)
            {
                using (var db = new TourContext(DbOptions.Options()))
                {
                    db.Hotels.Add(addHotelForm.Hotel);
                    db.SaveChanges();
                    initDatagrid();
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Country")
            {
                var country = (Country)e.Value;
                e.Value = country.Name;
            }
        }

        private void butEdit_Click(object sender, EventArgs e)
        {

            var hotelDataGrid = (Hotel)dataGridView1.SelectedRows[0].DataBoundItem;
            if (hotelDataGrid == null)
            {
                return;
            }
            using (var db = new TourContext(DbOptions.Options()))
            {
                var hotelDB = db.Hotels.FirstOrDefault(x => x.Id == hotelDataGrid.Id);
                var hotelChange = new AddHotelForm(hotelDB);
                if (hotelChange.ShowDialog() == DialogResult.OK)
                {
                    db.SaveChanges();
                    initDatagrid();
                }
            }
        }
        public void Roles()
        {
            if (profile.user == 2 || profile.user == 1)
            {
                butAdd.Enabled = true;
                butDel.Enabled = true;
                butEdit.Enabled = true;
            }
            else
            {
                butAdd.Enabled = false;
                butDel.Enabled = false;
                butEdit.Enabled = false;

            }
        }
        private void butDel_Click(object sender, EventArgs e)
        {
            var hotel = (Hotel)dataGridView1.SelectedRows[0].DataBoundItem;

            if (hotel == null)
            {
                return;
            }
            using (var db = new TourContext(DbOptions.Options()))
            {
                var hotelDB = db.Hotels.Include(x => x.Tours).FirstOrDefault(x => x.Id == hotel.Id);
                if (hotelDB.Tours.Count(x => x.IsActual) != 0)
                {
                    MessageBox.Show("Этот отель подходит к актуальным турам!!");
                    return;
                }

                if (MessageBox.Show($"Удалить ли отель {hotelDB.Name}?", "Подтвердите!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    db.Hotels.Remove(hotelDB);
                    db.SaveChanges();
                    initDatagrid();
                }
            }
        }
    }
}
