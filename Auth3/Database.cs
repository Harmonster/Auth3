using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auth3
{
    public class Database
    {
        /// <summary>
        /// Роль активного пользователя
        /// </summary>
        public static int currUserRole;
        /// <summary>
        /// Загрузка списка продукции в DataGridView
        /// </summary>
        /// <param name="dgv">Элемент DataGridView</param>
        /// <param name="selectType">Имя хранимой процедуры</param>
        public static void GetProductsList(DataGridView dgv, string selectType)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnection))
            {
                MySqlCommand cmd = new MySqlCommand(selectType, Connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cmd.Dispose();
                    Connection.Close();
                }
            }
        }
        /// <summary>
        /// Загрузка информации о продукте
        /// </summary>
        /// <param name="id">Идентификатор продукта</param>
        /// <param name="tb_name">Поле наименование</param>
        /// <param name="tb_desc">Поле описания</param>
        /// <param name="tb_cost">Поле цены</param>
        /// <param name="selectType">Имя хранимой процедуры</param>
        public static void GetProductDetails(int id, TextBox tb_name, TextBox tb_misc, TextBox tb_cost, string selectType)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnection))
            {
                MySqlCommand cmd = new MySqlCommand(selectType, Connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@u_id", id);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    tb_name.Text = dt.Rows[0]["Наименование"].ToString();
                    tb_misc.Text = dt.Rows[0]["Описание"].ToString();
                    tb_cost.Text = dt.Rows[0]["Цена"].ToString();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cmd.Dispose();
                    Connection.Close();
                }
            }
        }
        /// <summary>
        /// Редактирование информации о продукте
        /// </summary>
        /// <param name="id">Идентификатор продукта</param>
        /// <param name="tb_name">Поле наименование</param>
        /// <param name="tb_desc">Поле описания</param>
        /// <param name="tb_cost">Поле цены</param>
        /// <param name="selectType">Имя хранимой процедуры</param>
        public static void UpdateProductDetails(int id, TextBox tb_name, TextBox tb_desc, TextBox tb_cost, string selectType)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnection))
            {
                MySqlCommand cmd = new MySqlCommand(selectType, Connection);
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@u_id", id);
                    cmd.Parameters.AddWithValue("@u_name", tb_name.Text);
                    cmd.Parameters.AddWithValue("@u_desc", tb_desc.Text);
                    cmd.Parameters.AddWithValue("@u_cost", tb_cost.Text);
                    Connection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Данные товара успешно изменены.");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cmd.Dispose();
                    Connection.Close();
                }
            }
        }
        /// <summary>
        /// Удаление продукта по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор продукта</param>
        public static void DeleteProduct(int id)
        {
            if (MessageBox.Show("Вы действительно хотите удалить данный продукт?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnection))
                {
                    MySqlCommand cmd = new MySqlCommand("DeleteProduct", Connection);
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@u_id", id);
                        Connection.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Выбранный товар успешно удалён.");
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        cmd.Dispose();
                        Connection.Close();
                    }
                }
            }
        }
        /// <summary>
        /// Вставка данных в таблицу cort
        /// </summary>
        /// <param name="startIndex">Порядковый номер корзины</param>
        /// <param name="dataTable">Таблица данных</param>
        public static void InsertDatatable(int startIndex, DataTable dataTable)
        {
            int start = ++startIndex; // Счётчик порядкового номера корзины
            int executeCounter = 0; // Счётчик выполнений
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnection))
            {
                MySqlCommand cmd = new MySqlCommand("CreateCart", Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    Connection.Open();
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@order_id", start);
                        cmd.Parameters.AddWithValue("@item_id", dataTable.Rows[i]["#"]);
                        cmd.Parameters.AddWithValue("@amount", dataTable.Rows[i]["Количество"]);
                        executeCounter += cmd.ExecuteNonQuery();
                    }
                    if (executeCounter > 0)
                    {
                        MessageBox.Show("Корзина успешно сохранена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    Connection.Close();
                    cmd.Dispose();
                }
            }
        }

        public static int GetLastCartId()
        {
            int lastIndex = 0;
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnection))
            {
                MySqlCommand cmd = new MySqlCommand("GetLastCartId", Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    Connection.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        lastIndex = Convert.ToInt32(rdr["order_id"]);
                    }
                    return lastIndex;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    Connection.Close();
                    cmd.Dispose();
                }
            }
        }
    }
}
