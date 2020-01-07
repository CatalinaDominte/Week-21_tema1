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
    class ArchiveProductsRepository: IReaderRepo<ArchiveProducts>,IScalarRepo
    {
        public List<ArchiveProducts> Reader(string query)
        {
            var connection = ConnectionManager.GetConnection();
            connection.Open();
            List<ArchiveProducts> ArchiveProducts = new List<ArchiveProducts>();
            try
            {

                SqlCommand command = new SqlCommand(query, connection);


                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    var currentRow = dataReader;

                    ArchiveProducts archiveProducts = new ArchiveProducts();

                    archiveProducts.ProductsId = (int)currentRow["ProductsId"];
                    archiveProducts.ProductsName = currentRow["ProductsName"].ToString();
                    archiveProducts.Suppliers = (int)currentRow["Suppliers"];
                    archiveProducts.Category = (int)currentRow["Category"];
                    archiveProducts.StoreLocation = (int)currentRow["StoreLocation"];
                    archiveProducts.ProductsDescription = currentRow["ProductsDescription"].ToString();
                    archiveProducts.UnitsInStock = (int)currentRow["UnitsInStock"];
                    archiveProducts.UnitPrice = (float)currentRow["UnitPrice"];
                    archiveProducts.Discount = (float)currentRow["Discount"];
                    archiveProducts.FinalPrice = (float)currentRow["FinalPrice"];
                    archiveProducts.AvaibleSize = currentRow["AvaibleSize"].ToString();
                    archiveProducts.AvaibleColours = currentRow["AvaibleColours"].ToString();
                    archiveProducts.EntryDate = (DateTime)currentRow["EntryDate"];

                    ArchiveProducts.Add(archiveProducts);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            connection.Close();

            return ArchiveProducts;
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
