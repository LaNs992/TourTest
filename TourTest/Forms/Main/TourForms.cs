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

namespace TourTest.Forms.Main
{
    public partial class TourForms : Form
    {
        public TourForms()
        {
            InitializeComponent();
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

        private void TourForms_Load_1(object sender, EventArgs e)
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
    }
}
