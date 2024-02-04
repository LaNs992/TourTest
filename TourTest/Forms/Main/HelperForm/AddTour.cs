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

namespace TourTest.Forms.Main.HelperForm
{
    public partial class AddTour : Form
    {
    //    private readonly Tour tourEdit;
    //    public Tour Tour => tourEdit;
        public AddTour()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        //    using (var db = new TourContext(DbOptions.Options()))
        //    {
        //        Tour tourero = new Tour
        //        {
        //            Name = nameTextBox.Text,
        //            TourCountry = countryComboBox.SelectedItem.ToString(),
        //            TicketCount = Convert.ToInt32(ticketsNumeric.Value),
        //            Description = descTextBox.Text,
        //            Price = Convert.ToInt32(costTextBox.Text),
        //            IsActual = isInternationalChecked.Checked,
        //            IsInternational = isInternationalChecked.Checked,
        //        };
        //        db.Tours.Add(tourero);
        //    }
        //    this.Close();
        }

        //private void AddTour_Load(object sender, EventArgs e)
        //{
        //    countryComboBox.DisplayMember = nameof(Country.Name);

        //    typeComboBox.DisplayMember = nameof(Models.Type.Name);
        //    using (var db = new TourContext(DbOptions.Options()))
        //    {
        //        countryComboBox.Items.AddRange(db.Countries.ToArray());
        //        countryComboBox.SelectedIndex = 0;
        //        typeComboBox.Items.AddRange(db.Types.ToArray());
        //    }
        //}
    }
}
