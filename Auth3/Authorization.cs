using MySql.Data.MySqlClient;
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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void btn_auth_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_login.Text))
            {
                MessageBox.Show("Вы не ввели логин. Пожалуйста повторите ввод.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            else if (string.IsNullOrEmpty(tb_password.Text))
            {
                MessageBox.Show("Вы не ввели пароль. Пожалуйста повторите ввод.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            else
            {
                using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnection))
                {
                    try
                    {
                        string query = @"SELECT `auth_role` FROM `Auth3`.`auth` WHERE `auth_log` = @u_login AND `auth_pwd` = @u_password;";
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, Connection);
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@u_login", tb_login.Text);
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@u_password", tb_password.Text);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        if (dataTable.Rows.Count == 1)
                        {
                            Database.currUserRole = Convert.ToInt32(dataTable.Rows[0]["auth_role"]);
                            Products products = new Products();
                            this.Hide();
                            products.Show();
                        }
                        else
                        {
                            MessageBox.Show("Запись с такими данными не найдена. Перепроверьте вводимые данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        Connection.Close();
                    }
                }
            }
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            tb_login.Select();
            tb_login.Text = "qwerty4";
            tb_password.Text = "123456";
        }
    }
}
