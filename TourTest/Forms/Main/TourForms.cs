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
using Type = TourTest.Models.Type;

namespace TourTest.Forms.Main
{
    public partial class TourForms : Form
    {
        public string Username;
        public TourForms(string Login )
        {
            Username = Login;
            InitializeComponent();
            Namelbl.Text = Username;
            LoadControl();
        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {
            AddTour addbtn= new AddTour();
            if (addbtn.ShowDialog() == DialogResult.OK)
            {
                using (var db = new TourContext(DbOptions.Options()))
                {
                    var ids = addbtn.GetTypeIdsChecked();
                    addbtn.Tour.Types = db.Types.Where(x => ids.Contains(x.Id)).ToList();
                    db.Tours.Add(addbtn.Tour);
                    db.SaveChanges();
                    var tourInfo = new TourViewer(addbtn.Tour);
                    tourInfo.Parent = flowLayoutPanel4;
                }
             }
               

        }
        public void LoadControl()
        {

            using (var db = new TourContext(DbOptions.Options()))
            {
               
                var tours = db.Tours.Include(nameof(Tour.Types)).ToList();
                foreach (var tour in tours)
                {

                    var tourInfo = new TourViewer(tour);
                    tourInfo.Parent = flowLayoutPanel4;
                    //tourInfo.ImageChanged += TourView_ImageChanged;
                }

            }
        }
        private void TourForms_Load_1(object sender, EventArgs e)
        {
            Namelbl.Text = Username;
            LoadControl();
        }
        private int allToursSum = 0;
        private void Filter()
        {
            flowLayoutPanel4.Controls.Clear();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel(Username);
            hotel.Show();
            this.Close();
        }
    }
}
