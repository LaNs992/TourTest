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
using TourTest.Models;
using static System.Net.Mime.MediaTypeNames;

namespace TourTest.Forms.Main
{
    public partial class Hotel : Form
    {
        private int sizePage = 10;
        private int oldCurrent = -1;
        private BindingSource bindingSource;
        public string Username;
        public Hotel(string login)
        {
            Username= login;
            InitializeComponent();
            UserN.Text = Username;
        }

        //private void Print()
        //{   
        //    using (var db = new TourContext())
        //    {

        //        var count = db.Hotels.Count();

        //        var pageLength = (int)Math.Ceiling((float)count / sizePage);

        //        if (oldCurrent != pageLength)
        //        {
        //            oldCurrent = pageLength;
        //            var current = bindingSource.Position;

        //            if (current > pageLength)
        //            {
        //                current = pageLength;
        //            }
        //            bindingSource.DataSource = Enumerable.Range(1, pageLength);
        //            if (current != -1)
        //            {
        //                bindingSource.Position = current;
        //            }
        //            bindingNavigator.BindingSource = bindingSource;
        //        }
        //        toolStripAllCount.Text = $"Кол-во записей: {count}";
        //        dataGridView1.DataSource = db.Hotels.Include(y => y.Country)
        //            .OrderBy(x => x.Name)
        //            .Skip(bindingSource.Position * sizePage)
        //            .Take(sizePage)
        //            .ToList();
        //    }
        //}

        private void butAdd_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Country")
            {
                var country = (Country)e.Value;
                e.Value = country.Name;
            }
        }
    }
}
