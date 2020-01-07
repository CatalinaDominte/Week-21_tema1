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
    class ProductRepository: IReaderRepo<Products>,IScalarRepo
    {
        public List<Products> Reader(string query)
        {
            var connection = ConnectionManager.GetConnection();
            connection.Open();
            List<Products> Products = new List<Products>();
            try
            {

                SqlCommand command = new SqlCommand(query, connection);


                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    var currentRow = dataReader;

                    Products products = new Products();
                   
                    products.ProductsId=(int)currentRow["ProductsId"];
                    products.ProductsName = currentRow["ProductsName"].ToString();
                    products.Suppliers = (int)currentRow["Suppliers"];
                    products.Category = (int)currentRow["Category"];
                    products.StoreLocation = (int)currentRow["StoreLocation"];
                    products.ProductsDescription = currentRow["ProductsDescription"].ToString();
                    products.UnitsInStock = (int)currentRow["UnitsInStock"];
                    products.UnitPrice = (float)currentRow["UnitPrice"];
                    products.Discount = (float)currentRow["Discount"];
                    products.FinalPrice = (float)currentRow["FinalPrice"];
                    products.AvaibleSize = currentRow["AvaibleSize"].ToString();
                    products.AvaibleColours = currentRow["AvaibleColours"].ToString();
                    products.EntryDate = (DateTime)currentRow["EntryDate"];

                    Products.Add(products);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            connection.Close();

            return Products;
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
