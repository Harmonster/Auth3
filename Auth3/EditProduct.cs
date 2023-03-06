using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auth3
{
    public partial class EditProduct : Form
    {
        private Products fromForm { get; set; }
        private int currProductId;
        public EditProduct(Products form, int p_id)
        {
            InitializeComponent();
            fromForm = form;
            currProductId = p_id;
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            lbl_id.Text = "Детали товара №" + currProductId;
            Database.GetProductDetails(currProductId, tb_name, tb_desc, tb_cost, "GetProductDetails");
            btn_save.Select();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Database.UpdateProductDetails(currProductId, tb_name, tb_desc, tb_cost, "UpdateProductDetails");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            fromForm.DatagridviewSettings();
            this.Hide();
        }
    }
}
