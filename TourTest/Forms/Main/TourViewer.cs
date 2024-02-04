using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourTest.Forms.Main
{
    public partial class TourViewer : UserControl
    {
        //private readonly Tour tourView;
        //private EventHandler<(Tour, byte[])> onImageChanged;
        //public TourViewer(Tour tour)
        //{
        //    InitializeComponent();
        //    this.tourView = tour;
        //    InitTour(tour);
        //}
        //public Tour Tour => tourView;
        //private void InitTour(Tour tour)
        //{
        //   NameLb.Text = tour.Name;
        //   Price.Text = $"{tour.Price} р";
        //    Actual.Text = tour.IsActual ? "Актуален" : "Не актуален";
        //    Actual.ForeColor = tour.IsActual ? Color.Green : Color.Red;
        //    CountTick.Text = $"Кол: {tour.TicketCount.ToString()}";
        //    /*if (tour.ImagePreview != null)
        //    {
        //        MemoryStream image = new MemoryStream();
        //        image = new MemoryStream(tour.ImagePreview);
        //        pictureTour.Image = Image.FromStream(image);            
        //    }*/
        //}
        private void buttonEdit_Click(object sender, EventArgs e)
        {

            //var tourEdit = new TourEdit(Tour);
            //var result = tourEdit.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    using (var db = new AroundRussiaContext())
            //    {
            //        var tour = db.Tours.Include(nameof(Tour.Types)).FirstOrDefault(t => t.Id == Tour.Id);
            //        if (tour != null) { return; }
            //        tour = tourEdit.Tour;
            //        tour.Types.Clear();
            //        db.SaveChanges();
            //        InitTour(tour);
            //    }
            //}
            //else if (result == DialogResult.Yes)
            //{
            //    if (MessageBox.Show($"Вы уверены, что хотите удалить Тур:\n\tНазвание: {Tour.Name}\n\t" +
            //        $"Цена: {Tour.Price}", "Предупреждение!",
            //        MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            //    {
            //        using (var db = new AroundRussiaContext())
            //        {
            //            var tour = db.Tours.Include(nameof(Tour.Types)).FirstOrDefault(x => x.Id == Tour.Id);
            //            if (tour == null) { return; }
            //            db.Tours.Remove(tour);
            //            db.SaveChanges();
            //            this.Hide();
            //        }
            //    }
            //}
        }

        private void TourView_Load(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
