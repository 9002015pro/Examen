using DriveMyself.Model;
using examen;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DriveMyself.Classes
{
    class MySqlDataProvider : IDataProvider
    {
        private MySqlConnection Connection;
        public MySqlDataProvider()
        {
            try
            {
                Connection = new MySqlConnection(
                    "Server=server232;Database=bd_kirillov;port=3306;UserId=serv232;password=123456;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public IEnumerable<Manufacturers> GetManufacturers()
        {
            List<Manufacturers> ManufacturersList = new List<Manufacturers>();
            string Query = "Select * From manufacture;";
            try
            {
                Connection.Open();
                try
                {
                    MySqlCommand Command = new MySqlCommand(Query, Connection);
                    MySqlDataReader Reader = Command.ExecuteReader();

                    while (Reader.Read())
                    {
                        Manufacturers NewManufacturer = new Manufacturers();

                        NewManufacturer.ID = Reader.GetInt32("ID");
                        NewManufacturer.Title = Reader.GetString("Title");

                        ManufacturersList.Add(NewManufacturer);
                    }
                }
                finally
                {
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ManufacturersList;

        }

        public IEnumerable<Product> GetProducts()
        {
            List<Product> ProductList = new List<Product>();
            string Query = "Select * From Product;";
            try
            {
                Connection.Open();
                try
                {
                    MySqlCommand Command = new MySqlCommand(Query, Connection);
                    MySqlDataReader Reader = Command.ExecuteReader();
                    while (Reader.Read())
                    {
                        Product NewProduct = new Product();

                        NewProduct.id = Reader.GetInt32("ID");
                        NewProduct.Name = Reader.GetString("Name");
                        NewProduct.Image = Reader.GetString("Image");
                        NewProduct.Manufacturer = Reader.GetString("Manufacturer");
                        NewProduct.Enable = Reader.GetString("Enable");
                        NewProduct.Price = Reader.GetInt32("Price");

                        ProductList.Add(NewProduct);
                    }
                }
                finally
                {
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ProductList;
        }

        public void SaveProducts(Product current)
        {
            throw new NotImplementedException();
        }
    }
}
