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
   public class CategoryRepository: IReaderRepo<Category>
    {
        public List<Category> Reader(string query)
        {
            var connection = ConnectionManager.GetConnection();
            connection.Open();
            List<Category> Category = new List<Category>();
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    var currentRow = dataReader;
                    Category category = new Category();

                    category.CategoryId = (int)currentRow["CategoryId"];
                    category.CategoryName = currentRow["CategoryName"].ToString();
                    category.CategoryDescription = currentRow["CategoryDescription"].ToString();

                    Category.Add(category);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            connection.Close();
            return Category;
        }

        
    }
}
