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

        private void TourForms_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {
            AddTour addbtn= new AddTour();
            addbtn.ShowDialog();
        }
        public void LoadControl()
        {

            using (var db = new TourContext(DbOptions.Options()))
            {
                flowLayoutPanel4.Controls.Clear();
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


            //if (comboBox1.SelectedItem == null) return;
            //var selectedTypeId = ((Type)comboBox1.SelectedItem).Id;
            //allToursSum = 0;
            //foreach (var item in flowLayoutPanel4.Controls)
            //{
            //    var visible = true;
            //    if (item is TourViewer tourInfo)
            //    {
            //        if (selectedTypeId != null &&
            //            !tourInfo.Tour.Types.Any(x => x.Id == selectedTypeId))
            //        {
            //            visible = false;
            //        }

            //        if (isActualcheckBox.Checked && !tourInfo.Tour.IsActual)
            //        {
            //            visible = false;
            //        }

            //        if (!(string.IsNullOrEmpty(searchTextBox.Text) ||
            //            tourInfo.Tour.Name.Contains(searchTextBox.Text)))
            //        {
            //            visible = false;
            //        }
            //        if (visible)
            //        {
            //            allToursSum += (int)(tourInfo.Tour.Price * tourInfo.Tour.TicketCount);
            //        }
            //        tourInfo.Visible = visible;
            //    }
            //}
            //label1.Text = $"{allToursSum:C2}";
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
