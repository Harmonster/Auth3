using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Auth3
{
    public partial class Cart : Form
    {
        Products fromForm { get; set; }
        int lastIndex;
        DataTable dt;
        public Cart(Products form, DataTable dataTable)
        {
            InitializeComponent();
            fromForm = form;
            dt = dataTable;
            dgv_cart.DataSource = dt;

            dgv_cart.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_cart.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_cart.Columns[1].Visible = false;
            dgv_cart.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_cart.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            lastIndex = Database.GetLastCartId();
            if (dt.Rows.Count > 0)
            {
                tsl_total.Text = "Итого: " + Convert.ToDouble(dt.Compute("SUM(Цена)", string.Empty)).ToString();
            }      
        }

        private void tsb_clear_Click(object sender, EventArgs e)
        {
            dt.Clear();
            tsl_total.Text = "Итого: 0";
            fromForm.cartCounter = 0;
            fromForm.tsb_cart.Text = "Корзина";
        }

        private void tsb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsb_order_Click(object sender, EventArgs e)
        {
            Database.InsertDatatable(lastIndex, dt);
        }

    }
}
