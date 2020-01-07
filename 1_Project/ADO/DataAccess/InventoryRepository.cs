using DataAccess.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tables;

namespace DataAccess
{
    class InventoryRepository: IReaderRepo<Inventory>,IScalarRepo
    {
        public List<Inventory> Reader(string query)
        {
            var connection = ConnectionManager.GetConnection();
            connection.Open();
            List<Inventory> Inventory = new List<Inventory>();
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    var currentRow = dataReader;
                    Inventory inventory = new Inventory();
          
                    inventory.ProductsId= (int)currentRow["ProductsId"];
                    inventory.UnitsPerSizeId = (int)currentRow["UnitsPerSizeId"];
                    inventory.ProductsName = currentRow["ProductsName"].ToString();
                    inventory.Category = (int)currentRow["Category"];
                    inventory.Suppliers = (int)currentRow["Suppliers"];
                    inventory.StoreLocation = (int)currentRow["StoreLocation"];
                    inventory.UnitsSold = (int)currentRow["UnitsSold"];
                    inventory.SoldDate = (DateTime)currentRow["SoldDate"];
                    inventory.UnitPrice = (float)currentRow["UnitPrice"];
                    inventory.Discount = (float)currentRow["Discount"];
                    inventory.FinalPrice = (float)currentRow["FinalPrice"];
                    inventory.Size = (int)currentRow["Size"];
                    inventory.Colour = currentRow["Colour"].ToString();

                    Inventory.Add(inventory);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            connection.Close();

            return Inventory;
        }
        public void Scalar(string command)
        {

            var connection = ConnectionManager.GetConnection();
            connection.Open();
            try
            {

                SqlCommand commandQuery = new SqlCommand(command, connection);
                var commandScalar = commandQuery.ExecuteScalar();
                Console.WriteLine(commandScalar);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

            }
            connection.Close();

        }
    }
}
