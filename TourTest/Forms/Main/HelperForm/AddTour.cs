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
using TourTest.Models;

namespace TourTest.Forms.Main.HelperForm
{
    public partial class AddTour : Form
    {
        private readonly Tour tourEdit;
        public Tour Tour => tourEdit;
        public AddTour()
        {
            InitializeComponent();
            Text = "Добавление тура";
            addButton.Text = "Добавить";
        }
        public AddTour(Tour tour) : this()
        {   
            Text = "Изменения тура";
         
            this.tourEdit = tour;
            addButton.Visible = false;
            deleteButton.Visible = true;
            nameTextBox.Text = tour.Name;
            countryComboBox.Text = tour.TicketCount.ToString();
            costTextBox.Text = tour.Price.ToString();
            ticketsNumeric.Value = tour.TicketCount;
            isActualChecked.Checked = tour.IsActual;
            descTextBox.Text = tour.Description;
           

            using (var db = new TourContext(DbOptions.Options()))
            {
                countryComboBox.SelectedItem = db.Countries.FirstOrDefault(c => c.Code == tour.TourCountry);

                typeComboBox.SelectedItem = db.Types.FirstOrDefault(c => c.Id == tour.Id.ToString());
            }

        }
        private void addButton_Click(object sender, EventArgs e)
        {

            using (var db = new TourContext(DbOptions.Options()))
            {
                Tour tourero = new Tour
                {
                    Name = nameTextBox.Text,
                    TourCountry = ((Country)countryComboBox.SelectedItem).Code,
                    TicketCount = Convert.ToInt32(ticketsNumeric.Value),
                    Description = descTextBox.Text,
                    Price = Convert.ToInt32(costTextBox.Text),
                    IsActual = isInternationalChecked.Checked,
                    IsInternational = isInternationalChecked.Checked,
                };
                db.Tours.Add(tourero);
                db.SaveChanges();
            }
            this.Close();
        }

        private void AddTour_Load(object sender, EventArgs e)
        {
            countryComboBox.DisplayMember = nameof(Country.Name);

            typeComboBox.DisplayMember = nameof(Models.Type.Name);
            using (var db = new TourContext(DbOptions.Options()))
            {
                countryComboBox.Items.AddRange(db.Countries.ToArray());
                countryComboBox.SelectedIndex = 0;
                typeComboBox.Items.AddRange(db.Types.ToArray());
            }
        }

        private void descTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttoEdit_Click(object sender, EventArgs e)
        {
            using (var db = new TourContext(DbOptions.Options()))
            {
                Tour tourero = new Tour
                {
                    Name = nameTextBox.Text,
                    TourCountry = ((Country)countryComboBox.SelectedItem).Code,
                    TicketCount = Convert.ToInt32(ticketsNumeric.Value),
                    Description = descTextBox.Text,
                    Price = Convert.ToInt32(costTextBox.Text),
                    IsActual = isInternationalChecked.Checked,
                    IsInternational = isInternationalChecked.Checked,
                };
                db.Tours.Update(tourero);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
