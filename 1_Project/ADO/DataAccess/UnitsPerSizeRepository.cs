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
    class UnitsPerSizeRepository: IReaderRepo<UnitsPerSize>,IScalarRepo
    {
        public List<UnitsPerSize> Reader(string query)
        {
            var connection = ConnectionManager.GetConnection();
            connection.Open();
            List<UnitsPerSize> UnitsPerSize = new List<UnitsPerSize>();
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    var currentRow = dataReader;
                    UnitsPerSize unitsPerSize = new UnitsPerSize();
                   
                    unitsPerSize.UnitsPerSizeId= (int)currentRow["UnitsPerSizeId"];
                    unitsPerSize.UnitsPerSizeInStock = (int)currentRow["UnitsPerSizeInStock"];
                    unitsPerSize.Size = (int)currentRow["Size"];
                    unitsPerSize.Colour = currentRow["Size"].ToString();

                    UnitsPerSize.Add(unitsPerSize);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            connection.Close();

            return UnitsPerSize;
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

