using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Auth3
{
    public partial class Products : Form
    {
        public DataTable dataTable = new DataTable("Cart");
        /// <summary>
        /// Количество товара в корзине
        /// </summary>
        public int cartCounter = 0;

        public Products()
        {
            InitializeComponent();
            CartDataTableInit();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            Database.GetProductsList(dgv_products, "GetProductsList");
            DatagridviewSettings();
        }

        public void DatagridviewSettings()
        {
            // Берем данные из БД в DataGridView
            Database.GetProductsList(dgv_products, "GetProductsList");
            // Столбцы кнопки
            dgv_products.Columns[1].DisplayIndex = dgv_products.Columns.Count - 3; // Добавить
            dgv_products.Columns[1].Visible = true;
            dgv_products.Columns[3].DisplayIndex = dgv_products.Columns.Count - 4; // Количество
            dgv_products.Columns[3].Visible = true;
            dgv_products.Columns[3].Width = 25;

            if (Database.currUserRole == 2)
            {
                dgv_products.Columns[2].DisplayIndex = dgv_products.Columns.Count - 2; // Изменить
                dgv_products.Columns[2].Visible = true;
                dgv_products.Columns[0].DisplayIndex = dgv_products.Columns.Count - 1; // Удалить
                dgv_products.Columns[0].Visible = true;
            }

            dgv_products.Columns[4].DisplayIndex = 0;
            dgv_products.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_products.Columns[4].ReadOnly = true;
            dgv_products.Columns[5].DisplayIndex = 1;
            dgv_products.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_products.Columns[5].ReadOnly = true;
            dgv_products.Columns[6].DisplayIndex = 2;
            dgv_products.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_products.Columns[6].ReadOnly = true;
            dgv_products.Columns[7].DisplayIndex = 3;
            dgv_products.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_products.Columns[7].ReadOnly = true;
        }

        private void Products_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tsb_logout_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Hide();
            authorization.Show();
        }

        private void dgv_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedProductId = Convert.ToInt32(dgv_products.CurrentRow.Cells["№"].Value);
            string currColumnName = dgv_products.Columns[e.ColumnIndex].Name;
            if (currColumnName == "AddColumn")
            {
                if (Convert.ToDouble(dgv_products.CurrentRow.Cells["AmountColumn"].Value) > 0)
                {
                    dataTable.Rows.Add(new Object[]{
                    ++cartCounter,
                    dgv_products.CurrentRow.Cells["№"].Value,
                    dgv_products.CurrentRow.Cells["Наименование"].Value,
                    dgv_products.CurrentRow.Cells["AmountColumn"].Value,
                    Convert.ToDouble(dgv_products.CurrentRow.Cells["AmountColumn"].Value) * Convert.ToDouble(dgv_products.CurrentRow.Cells["Цена"].Value),
                });
                    tsb_cart.Text = "Корзина (" + cartCounter.ToString() + ")";
                }
                else if (dgv_products.CurrentRow.Cells["AmountColumn"].Value == null)
                {
                    MessageBox.Show("Укажите количество требуемого товара", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if ((Convert.ToDouble(dgv_products.CurrentRow.Cells["AmountColumn"].Value) == 0) || (Convert.ToDouble(dgv_products.CurrentRow.Cells["AmountColumn"].Value) < 0))
                {
                    MessageBox.Show("Количество товара не может быть равно или меньше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (currColumnName == "EditColumn")
            {
                EditProduct edit = new EditProduct(this, selectedProductId);
                edit.ShowDialog();
            }
            else if (currColumnName == "DeleteColumn")
            {
                Database.DeleteProduct(selectedProductId);
                DatagridviewSettings();
            }
        }

        private void CartDataTableInit()
        {
            DataColumn dataTableColumnNum = new DataColumn();
            DataColumn dataTableColumnId = new DataColumn();
            DataColumn dataTableColumnName = new DataColumn();
            DataColumn dataTableColumnCost = new DataColumn();
            DataColumn dataTableColumnAmount = new DataColumn();

            dataTableColumnNum.DataType = typeof(Int32);
            dataTableColumnNum.ColumnName = "№";
            dataTable.Columns.Add(dataTableColumnNum);

            dataTableColumnId.DataType = typeof(Int32);
            dataTableColumnId.ColumnName = "#";
            dataTable.Columns.Add(dataTableColumnId);

            dataTableColumnName.DataType = typeof(string);
            dataTableColumnName.ColumnName = "Наименование";
            dataTable.Columns.Add(dataTableColumnName);

            dataTableColumnAmount.DataType = typeof(Int32);
            dataTableColumnAmount.ColumnName = "Количество";
            dataTable.Columns.Add(dataTableColumnAmount);

            dataTableColumnCost.DataType = typeof(double);
            dataTableColumnCost.ColumnName = "Цена";
            dataTable.Columns.Add(dataTableColumnCost);
        }

        private void tsb_cart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart(this, dataTable);
            cart.ShowDialog();
        }
    }
}
