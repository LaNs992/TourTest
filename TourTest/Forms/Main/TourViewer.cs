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
    public partial class TourViewer : UserControl
    {
        private readonly Tour tourView;
        private EventHandler<(Tour, byte[])> onImageChanged;
        public TourViewer(Tour tour)
        {
            InitializeComponent();
            this.tourView = tour;
            InitTour(tour);
        }
        public Tour Tour => tourView;
        private void InitTour(Tour tour)
        {
           NameLb.Text = tour.Name;
           Price.Text = $"{tour.Price} р";
            Actual.Text = tour.IsActual ? "Актуален" : "Не актуален";
            Actual.ForeColor = tour.IsActual ? Color.Green : Color.Red;
            CountTick.Text = $"Кол: {tour.TicketCount.ToString()}";
            //if (tour.ImagePreview != null)
            //{
            //    MemoryStream image = new MemoryStream();
            //    image = new MemoryStream(tour.ImagePreview);
            //    pictureTour.Image = Image.FromStream(image);            
            //}
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void TourView_Load(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            using (var db = new TourContext(DbOptions.Options()))
            {
                var tourDB = db.Tours.FirstOrDefault(x => x.Id == Tour.Id);
                var tourInfoForm = new AddTour(tourDB);
                var result = tourInfoForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var ids = tourInfoForm.GetTypeIdsChecked();
                    tourDB.Types.Clear();
                    tourDB.Types = db.Types.Where(x => ids.Contains(x.Id)).ToList();
                    db.SaveChanges();
                    InitTour(tourDB);
                    
                }
                else if (result == DialogResult.Yes)
                {
                    if (MessageBox.Show($"Вы уверены, что хотите удалить Тур:\n\tНазвание: {tourDB.Name}\n\t" +
                        $"Цена: {tourDB.Price}", "Предупреждение!",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {

                        db.Tours.Remove(tourDB);
                        db.SaveChanges();
                        this.Hide();
                      
                    }

                }
            }
        
        }
    }
}
