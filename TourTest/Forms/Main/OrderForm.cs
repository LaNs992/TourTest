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
    public partial class OrderForm : Form
    {
        private Dictionary<Tour, int> orders;
        private decimal sum = 0;
        private int discount = 0;
        public OrderForm(Dictionary<Tour, int> orders)
        {
            InitializeComponent();
            this.orders = orders;
            //var user = WorkToUser.User;
            //labelFIO.Text = $"{user.Surname} {user.Name} {user?.Patronymic}";

            foreach (var item in orders.Keys)
            {
                var orderView = new OrderViewer(item, orders[item]);
                orderView.ChangeCount += UpdateSum;
                orderView.Visible = true;
                orderView.Margin = new Padding(0, 0, 0, 50);
                orderView.Parent = flowLayoutPanel1;
                sum += item.Price * orderView.Count;
            }
            PeiceLbl.Text = $"{sum:C2}";

            using (var db = new TourContext())
            {
                comboBox.DisplayMember = "Title";
                //comboBox.Items.AddRange(db.ReceivingPoints.ToArray());
                //comboBox.SelectedIndex = 0;
            }
        }
        private void UpdateSum()
        {
            sum = 0;
            foreach (var item in flowLayoutPanel1.Controls)
            {
                if (item is OrderViewer orderView)
                {
                    sum += orderView.Tour.Price * orderView.Count;
                    if (orders.TryGetValue(orderView.Tour, out var count))
                    {
                        orders[orderView.Tour] = orderView.Count;
                    }
                }
            }
            PeiceLbl.Text = $"{sum:C2}";
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void butZakaz_Click(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
