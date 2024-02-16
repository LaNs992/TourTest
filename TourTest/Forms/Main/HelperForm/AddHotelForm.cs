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
    public partial class AddHotelForm : Form
    {
        private readonly Hotel hotel;
        public AddHotelForm()
        {
            InitializeComponent();

            hotel = new Hotel();
            using (var db = new TourContext(DbOptions.Options()))
            {
                comboBoxCountri.DisplayMember = "Name";
                comboBoxCountri.Items.AddRange(db.Countries.ToArray());
                comboBoxCountri.SelectedIndex = 0;
            }
            numericUpDownStars.Value = 1;


        }
        public Hotel Hotel => hotel;
        public AddHotelForm(Hotel hotel) : this()
        {
            this.hotel = hotel;
            textBoxName.Text = hotel.Name;
            textBoxDesc.Text = hotel.Description;
            numericUpDownStars.Value = hotel.CountOfStars;
            comboBoxCountri.SelectedItem = comboBoxCountri.Items.Cast<Country>()
                .FirstOrDefault(x => x.Code == hotel.CountryCode);
        }

        private void comboBoxCountri_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            hotel.CountryCode = ((Country)comboBoxCountri.SelectedItem).Code;

        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            hotel.Description = textBoxDesc.Text;

        }

        private void numericUpDownStars_ValueChanged(object sender, EventArgs e)
        {
            hotel.CountOfStars = (int)numericUpDownStars.Value;

        }

        

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            hotel.Name = textBoxName.Text;

            if (numericUpDownStars.Value == 0)
            {
                numericUpDownStars.Value = 1;
            }
        }
    }
}
