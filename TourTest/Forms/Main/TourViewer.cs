using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourTest.context;
using TourTest.Forms.Main.HelperForm;
using TourTest.Models;
using TourTest.Models.profiles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TourTest.Forms.Main
{
    public partial class TourViewer : UserControl
    {
        private readonly Tour tourView;
        private EventHandler onCountOrdersChanged;
        public event Action<Tour> onAddToOrder;
        public event Action<int> onAddTour;
        public TourViewer(Tour tour)
        {
            InitializeComponent();
            this.tourView = tour;
            InitTour(tour);
        }
       
        public Tour Tour => tourView;
        private void InitTour(Tour tour)
        {
            Roles();
           NameLb.Text = tour.Name;
           Price.Text = tour.Price.ToString("C2",CultureInfo.GetCultureInfo("ru-RU"));
            Actual.Text = tour.IsActual ? "Актуален" : "Не актуален";
            Actual.ForeColor = tour.IsActual ? Color.Green : Color.Red;
            CountTick.Text = $"Кол: {tour.TicketCount.ToString()}";
            if (tour.ImagePreview != null)
            {
                pictureTour.Image = Image.FromStream(new MemoryStream(tour.ImagePreview));
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }
        public event EventHandler CountOrdersChanged
        {
            add
            {
                onCountOrdersChanged += value;
            }
            remove
            {
                onCountOrdersChanged -= value;
            }
        }
        private void TourView_Load(object sender, EventArgs e)
        {

        }
        public event Action<Tour, byte[]> OnImageChanged;
        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            using (var db = new TourContext(DbOptions.Options()))
            {
                var tourDB = db.Tours.Include(x=>x.Types).FirstOrDefault(x => x.Id == Tour.Id);
                var tourInfoForm = new AddTour(tourDB);
                var result = tourInfoForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var ids = tourInfoForm.GetTypeIdsChecked();
                    tourDB.Types.Clear();
                    tourDB.Types = db.Types.Where(x => ids.Contains(x.Id)).ToList();
                    db.SaveChanges();
                    InitTour(tourDB);
                    onAddTour?.Invoke((int)tourDB.Price * tourDB.TicketCount);
                }
                else if (result == DialogResult.No)
                {
                    if (MessageBox.Show($"Вы уверены, что хотите удалить Тур:\n\tНазвание: {tourDB.Name}\n\t" +
                        $"Цена: {tourDB.Price}", "Предупреждение!",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        if (tourDB.Types.Count == 0)
                        {
                            db.Tours.Remove(tourDB);
                            db.SaveChanges();
                            this.Hide();
                        }
                        else MessageBox.Show($"Сначал уберите галочку с туров");






                        onAddTour?.Invoke(-((int)tourDB.Price * tourDB.TicketCount));

                    }

                }
            }
        
        }
        public void Roles()
        {
            if (profile.user == 2 || profile.user == 1)
            {
                buttonEdit.Enabled = true;
                buttonAdd.Enabled = true;
            }
            else
            {
                buttonEdit.Enabled = false;

            }
        }

            private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var image = File.ReadAllBytes(openFileDialog1.FileName);
            OnImageChanged?.Invoke(tourView, image);
            pictureTour.Image = Image.FromStream(new MemoryStream(image));
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tourView.IsActual)
            {
                onAddToOrder?.Invoke(tourView);
                onCountOrdersChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
