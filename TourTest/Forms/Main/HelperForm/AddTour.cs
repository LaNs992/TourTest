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
using TourTest.Models;

namespace TourTest.Forms.Main.HelperForm
{
    public partial class AddTour : Form
    {
        private  Tour tourEdit;
        public Tour Tour => tourEdit;
        public AddTour()
        {
            InitializeComponent();
            tourEdit=new Tour();
            Text = "Добавление тура";
            addButton.Text = "Добавить";
        }
        public AddTour(Tour tour) : this()
        {   
            Text = "Изменения тура";
            addButton.Text = "Изменить";
            this.tourEdit = tour;
            deleteButton.Visible = true;
            nameTextBox.Text = tour.Name;
            costTextBox.Text = tour.Price.ToString();
            ticketsNumeric.Value = tour.TicketCount;
            isActualChecked.Checked = tour.IsActual;
            descTextBox.Text = tour.Description;

            countryComboBox.SelectedItem = countryComboBox.Items
               .Cast<Country>()
               .FirstOrDefault(x => x.Code == tour.TourCountry);

            var ids = tour.Types.Select(x => x.Id).ToList();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (ids.Contains(((Models.Type)checkedListBox1.Items[i]).Id))
                {
                    checkedListBox1.SetItemChecked(i, true);
                }

            }
            

        }
        private void addButton_Click(object sender, EventArgs e)
        {
                tourEdit = new Tour
                {
                    Name = nameTextBox.Text,
                    TourCountry = ((Country)countryComboBox.SelectedItem).Code,
                    TicketCount = Convert.ToInt32(ticketsNumeric.Value),
                    Description = descTextBox.Text,
                    Price = decimal.Parse(costTextBox.Text),
                    IsActual = isInternationalChecked.Checked,
                    IsInternational = isInternationalChecked.Checked,
                };
                DialogResult=DialogResult.OK;
                         
        }
        public List<string> GetTypeIdsChecked()
        => checkedListBox1.CheckedItems
            .Cast<Models.Type>()
            .Select(x => x.Id)
            .ToList();
        private void AddTour_Load(object sender, EventArgs e)
        {
            countryComboBox.DisplayMember = nameof(Country.Name);

            checkedListBox1.DisplayMember = nameof(Models.Type.Name);
            using (var db = new TourContext(DbOptions.Options()))
            {
                countryComboBox.Items.AddRange(db.Countries.ToArray());
                countryComboBox.SelectedIndex = 0;

                checkedListBox1.Items.AddRange(db.Types.ToArray());
            }
        }

        private void costTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void costTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
