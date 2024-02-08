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
using Type = TourTest.Models.Type;

namespace TourTest.Forms.Main
{
    public partial class TourForms : Form
    {
        public string Username;
        public static Dictionary<Tour, int> orders;

        public TourForms(string Login )
        {
            orders = new Dictionary<Tour, int>();
            Username = Login;
            InitializeComponent();
            comboBox1.DisplayMember = nameof(Type.Name);
            comboBox1.ValueMember = nameof(Type.Id);
            Namelbl.Text = Username;
            Roles();
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
                    tourInfo.OnImageChanged += TourInfo_OnImageChanged;
                    tourInfo.CountOrdersChanged += TourInfo_CountOrdersChanged;
                    tourInfo.onAddToOrder += TourInfo_onAddToOrder;
                    tourInfo.onAddTour += TourInfo_onAddTour;

                    allToursSum += (int)(tourInfo.Tour.Price * tourInfo.Tour.TicketCount);
                    Moneylbl.Text = $"{allToursSum:C2}";


                }
            }
               

        }

        private void TourInfo_OnImageChanged(Tour tour, byte[] image)
        {
            using (var db = new TourContext(DbOptions.Options()))
            {
                var tourDB = db.Tours.FirstOrDefault(x => x.Id == tour.Id);
                tourDB.ImagePreview = image;    
                db.SaveChanges();
            }
        }
        private void TourInfo_onAddToOrder(Tour tour)
        {
            if (orders.TryGetValue(tour, out var count))
            {
                orders[tour] = ++count;
            }
            else
            {
                orders.Add(tour, 1);
            }

        }
        private void TourInfo_onAddTour(int money)
        {
            allToursSum += money;
            //OrderForm orderForm = new OrderForm();
            //orderForm.s
            Moneylbl.Text = $"{allToursSum}";

        }
        private void TourInfo_CountOrdersChanged(object sender, EventArgs e)
        {
            CountCorLbl.Text = $"В корзине: {orders.Count}"; 
            butOrder.Visible = orders.Count != 0;
        }
        public void LoadControl()
        {

            using (var db = new TourContext(DbOptions.Options()))
            {

                var query = db.Types.OrderBy(x => x.Name);

                
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(query.ToArray());
                comboBox1.Items.Insert(0, new Type()
                {
                    Id = "-1",
                    Name = "Все типы",
                });
                var tours = db.Tours.Include(nameof(Tour.Types)).ToList();
                foreach (var tour in tours)
                {
                    
                    var tourInfo = new TourViewer(tour);
                    tourInfo.Parent = flowLayoutPanel4;
                    tourInfo.OnImageChanged += TourInfo_OnImageChanged;
                    tourInfo.onAddToOrder += TourInfo_onAddToOrder;
                    tourInfo.onAddTour += TourInfo_onAddTour;
                    tourInfo.CountOrdersChanged += TourInfo_CountOrdersChanged;

                  
                }
               
            }
        }
        private void Filter()
        {
            if (comboBox1.SelectedItem == null) return;
            var selectedTypeId = ((Type)comboBox1.SelectedItem).Id;
            allToursSum = 0;
            foreach (var item in flowLayoutPanel4.Controls)
            {
                var visible = true;
                if (item is TourViewer tourInfo)
                {
                    if (selectedTypeId != "-1" &&
                        !tourInfo.Tour.Types.Any(x => x.Id == selectedTypeId))
                    {
                        visible = false;
                    }

                    if (isActualcheckBox.Checked && !tourInfo.Tour.IsActual)
                    {
                        visible = false;
                    }

                    if (!(string.IsNullOrEmpty(searchTextBox.Text) ||
                        tourInfo.Tour.Name.Contains(searchTextBox.Text)))
                    {
                        visible = false;
                    }
                    if (visible)
                    {
                        allToursSum += (int)(tourInfo.Tour.Price * tourInfo.Tour.TicketCount);
                    }
                    tourInfo.Visible = visible;
                }
            }
           
        }
        public void Roles()
        {
            if (profile.user == 2 || profile.user ==1)
            {
                buttonAuto.Enabled= true;

            }else 
            {
                buttonAuto.Enabled = false;
              
            }
            
        }
        private void TourForms_Load_1(object sender, EventArgs e)
        {
            Namelbl.Text = Username;
            LoadControl();
            Roles();
            using (var db = new TourContext())
                {
                var tours = db.Tours.AsNoTracking().Include(x => x.Types).ToList();
            //    allToursSum = 0;
            foreach (var tour in tours)
            {

                var tourInfo = new TourViewer(tour);
                //        tourInfo.Parent = flowLayoutPanel4;
                //        tourInfo.OnImageChanged += TourInfo_OnImageChanged;
                //        tourInfo.CountOrdersChanged += TourInfo_CountOrdersChanged;
                //        tourInfo.onAddToOrder += TourInfo_onAddToOrder;
                //        tourInfo.onAddTour += TourInfo_onAddTour;

                allToursSum += (int)(tour.Price * tour.TicketCount);
            }
            AllSumm.Text = $"{allToursSum:C2}";
        }
    }
        private int allToursSum = 0;
       
        private void button1_Click(object sender, EventArgs e)
        {
            HotelForm hotel = new HotelForm(Username);
            hotel.ShowDialog();
           
        }

        private void butOrder_Click(object sender, EventArgs e)
        {
            var orderForm = new OrderForm(orders);
            orderForm.ShowDialog();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
