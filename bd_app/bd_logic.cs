using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd_app
{
    class bd_logic
    {
        //Подключение к базе данных 
        public static MySqlConnection GetConnection()
        { 
            //строка подключения
            string sql = "server=localhost;port=3306;user=root;database=farmbd5;password=LoLkek228kekLoL;";

            MySqlConnection Farmcon = new MySqlConnection(sql);
            //попытка подключения 
            try
            {
                Farmcon.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection \n" + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return Farmcon;
        }

        //Добавить новый продукт
        public static void AddProduct(Product prd)
        {
            //строка команды добавления новой записи
            string com = "INSERT INTO `farmbd5`.`product` (`type`, `volume`, `quality`, `cost`)  VALUES (@type, @volume, @quality, @cost)";

            MySqlConnection connect = GetConnection();
            MySqlCommand cmd = new MySqlCommand(com, connect);
            cmd.CommandType = CommandType.Text;

            //добавление параметров добавляемой записи
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = prd.type;
            cmd.Parameters.Add("@volume", MySqlDbType.Float).Value = prd.volume;
            cmd.Parameters.Add("@quality", MySqlDbType.VarChar).Value = prd.quality;
            cmd.Parameters.Add("@cost", MySqlDbType.Float).Value = prd.cost;
            
            //попытка вызова команды добавления
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.Close();

        }
        //Обновление данных выбранного продукта
        public static void UpdateProduct(Product prd , string id)
        {
            //Строка команды обновления записи

            string com = "UPDATE `farmbd5`.`product` SET type = @type, volume = @volume, quality = @quality, cost = @cost WHERE id_product = @id";

            MySqlConnection connect = GetConnection();
            MySqlCommand cmd = new MySqlCommand(com, connect);
            cmd.CommandType = CommandType.Text;

            //добавление параметров обновления записи
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = prd.type;
            cmd.Parameters.Add("@volume", MySqlDbType.Float).Value = prd.volume;
            cmd.Parameters.Add("@quality", MySqlDbType.VarChar).Value = prd.quality;
            cmd.Parameters.Add("@cost", MySqlDbType.Float).Value = prd.cost;

            //попытка вызова команды обновления
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.Close();

        }

        //Удаление выбранного продукта
        public static void DeleteProduct(string id)
        {
            //Строка команды удаления записи 
            string com = "DELETE FROM `farmbd5`.`product` WHERE id_product = @id";

            MySqlConnection connect = GetConnection();
            MySqlCommand cmd = new MySqlCommand(com, connect);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;


            //попытка вызова команды удаления
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.Close();

        }

        //Отображения и поиск записей 
        public static void DisplayAndSearch(string query, string searchtext, DataGridView dvg)
        {
            string sql = query;

            if (query == "product")
            {
                sql = "SELECT id_product, type, volume, quality, cost FROM farmbd5.product where type like '%" + searchtext + "%'";
            }
            if (query == "market")
            {
                sql = "SELECT id_market, trade_turnover, number_od_shops_for_sale, square, product.id_product, type, volume, quality, cost FROM farmbd5.market join product on product.id_product = market.id_product where square like '%" + searchtext + "%'";
            }
            if (query == "machinery")
            {
                sql = "SELECT id_machinery, cost, status, type_of_machine FROM farmbd5.machinery where type_of_machine like '%" + searchtext + "%'";
            }

            try
            {
                MySqlConnection connect = GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dvg.DataSource = tbl;
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        //Добавление Machinery 
        public static void AddMachinery(Machinery cle)
        {
            //Строка команды добавления записи
            string com = "INSERT INTO `farmbd5`.`machinery` (cost, status, type_of_machine) VALUES (@cost, @status, @type_of_machine)";

            MySqlConnection connect = GetConnection();
            MySqlCommand cmd = new MySqlCommand(com, connect);
            cmd.CommandType = CommandType.Text;

            //добавление параметров добавляемой записи
            cmd.Parameters.Add("@cost", MySqlDbType.Float).Value = cle.cost;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = cle.status;
            cmd.Parameters.Add("@type_of_machine", MySqlDbType.VarChar).Value = cle.type_of_machine;


            //попытка вызова команды добавления
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.Close();

        }

        //Обновление выбранного Machinery 
        public static void UpdateMachinery(Machinery cle, string id)
        {
            //Строка команды обнавления записи
            string com = "UPDATE `farmbd5`.`machinery` SET cost = @cost, status = @status, type_of_machine = @type_of_machine WHERE (`id_machinery` = @id)";
            
            MySqlConnection connect = GetConnection();
            MySqlCommand cmd = new MySqlCommand(com, connect);
            cmd.CommandType = CommandType.Text;

            //добавление параметров Обновляемой записи
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@cost", MySqlDbType.Float).Value = cle.cost;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = cle.status;
            cmd.Parameters.Add("@type_of_machine", MySqlDbType.VarChar).Value = cle.type_of_machine;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.Close();

        }

        //Удаление выбранного Machinery
        public static void DeleteMachinery(string id)
        {
            //Строка команды удаления записи
            string com = "DELETE FROM `farmbd5`.`machinery` WHERE (id_machinery = @id)";

            MySqlConnection connect = GetConnection();
            MySqlCommand cmd = new MySqlCommand(com, connect);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;


            //попытка вызова команды удаления
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.Close();

        }

        //Добавление корзины 
        public static void AddMarket(Market cle)
        {
            //Строка команды добавления записи
            string com = "INSERT INTO `farmbd5`.`market` (trade_turnover, number_od_shops_for_sale, square, id_product) VALUES (@trade_turnover, @number_od_shops_for_sale, @square, @id_product);";

            MySqlConnection connect = GetConnection();
            MySqlCommand cmd = new MySqlCommand(com, connect);
            cmd.CommandType = CommandType.Text;

            //добавление параметров добавляемой записи
            cmd.Parameters.Add("@trade_turnover", MySqlDbType.Float).Value = cle.trade_turnover;
            cmd.Parameters.Add("@number_od_shops_for_sale", MySqlDbType.Int32).Value = cle.number_od_shops_for_sale;
            cmd.Parameters.Add("@square", MySqlDbType.Float).Value = cle.square;
            cmd.Parameters.Add("@id_product", MySqlDbType.Int32).Value = cle.id_product;


            //попытка вызова команды добавления
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.Close();

        }

        //Обновление выбранной корзины 
        public static void UpdateMarket(Market cle, string id)
        {
            //Строка команды обнавления записи
            string com = " UPDATE `farmbd5`.`market` SET `trade_turnover` = @trade_turnover, `number_od_shops_for_sale` = @number_od_shops_for_sale, `square` = @square, `id_product` = @id_product WHERE (id_market = @id)";

            MySqlConnection connect = GetConnection();
            MySqlCommand cmd = new MySqlCommand(com, connect);
            cmd.CommandType = CommandType.Text;

            //добавление параметров Обновляемой записи
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@trade_turnover", MySqlDbType.Float).Value = cle.trade_turnover;
            cmd.Parameters.Add("@number_od_shops_for_sale", MySqlDbType.Int32).Value = cle.number_od_shops_for_sale;
            cmd.Parameters.Add("@square", MySqlDbType.Float).Value = cle.square;
            cmd.Parameters.Add("@id_product", MySqlDbType.Int32).Value = cle.id_product;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.Close();

        }

        //Удаление выбранной корзины
        public static void DeleteMarket(string id)
        {
            //Строка команды удаления записи
            string com = "DELETE FROM `farmbd5`.`market` WHERE (`id_market` = @id)";

            MySqlConnection connect = GetConnection();
            MySqlCommand cmd = new MySqlCommand(com, connect);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;


            //попытка вызова команды удаления
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.Close();

        }


        public static Product showProduct(string id)
        {
            //Строка команды 
            string com = "SELECT type, quality, cost FROM farmbd5.product where id_product = @id";
            Product cle = new Product(0 , "" , 0 , "" , 0);
            MySqlConnection connect = GetConnection();
            MySqlCommand cmd = new MySqlCommand(com, connect);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            //попытка вызова команды 
            try
            {
                var rider = cmd.ExecuteReader();

                while (rider.Read())
                {
                    try
                    {
                        cle.type = rider.GetString(0);
                        cle.quality = rider.GetString(1);
                        cle.cost = Convert.ToSingle(rider.GetString(2));
                    }
                    catch
                    {
                        cle.type = "NotFound";
                        cle.quality = "NotFound";
                        cle.cost = 0;
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.Close();
            
            
            return cle;

        }

        public static string QueryOne(string name, string date)
        {
            string res="";

            //Строка команды 
            string com = "select cost from farmbd5.buyer join farmbd5.product on buyer.id_product = product.id_product where name = @Name and date_of_birth = @date_of_birth";

            MySqlConnection connect = GetConnection();
            MySqlCommand cmd = new MySqlCommand(com, connect);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@date_of_birth", MySqlDbType.VarChar).Value = date;

            //попытка вызова команды 
            try
            {
                var rider = cmd.ExecuteReader();

                while (rider.Read())
                {
                    try
                    {
                        res = rider.GetString(0);
                    }
                    catch
                    {
                        res = "0";
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.Close();


            return res;
        }

        public static string QueryTwo(string name )
        {
            string res = "";

            name = "%" + name + "%"; 

            //Строка команды 
            string com = "select cost from farmbd5.farmer join farmbd5.machinery on farmer.id_machinery = machinery.id_machinery where name like @name limit 1 ";

            MySqlConnection connect = GetConnection();
            MySqlCommand cmd = new MySqlCommand(com, connect);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            

            //попытка вызова команды 
            try
            {
                var rider = cmd.ExecuteReader();

                while (rider.Read())
                {
                    try
                    {
                      res = rider.GetString(0);
                    }
                    catch 
                    { 
                        res = "0"; 
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.Close();


            return res;
        }
    }
}



