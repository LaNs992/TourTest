using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourTest.Models;

namespace TourTest.Forms.Main.HelperForm
{
   
    public partial class OrderViewer : UserControl
    {
        public Tour Tour;
        public int Count;
        public Action ChangeCount;
        public OrderViewer(Tour tour, int count)
        {
            InitializeComponent();
            this.Tour = tour;
            Count = count;
            label1.Text = Tour.Name;
            label2.Text = string.IsNullOrWhiteSpace(Tour.Description) ?
                "Описание отсутствует" : Tour.Description;
            Countrylbl.Text = Tour.TourCountry.ToString();
            Pricelbl.Text = $"Цена {Tour.Price:C2}";
            countlbl.Text = $"Кол-во билетов: {Tour.TicketCount}";
            numericUpDown1.Maximum=Tour.TicketCount;
            numericUpDown1.Value = count;
            listBox1.DisplayMember = "Name";
            listBox1.Items.AddRange(Tour.Types.ToArray());
            if (Tour.ImagePreview != null)
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(Tour.ImagePreview));
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Count = (int)numericUpDown1.Value;
            ChangeCount?.Invoke();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
