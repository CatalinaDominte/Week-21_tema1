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
    class StoreLocationRepository: IReaderRepo<StoreLocation>
    {
        public List<StoreLocation> Reader(string query)
        {
            var connection = ConnectionManager.GetConnection();
            connection.Open();
            List<StoreLocation> StoreLocation = new List<StoreLocation>();
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    var currentRow = dataReader;
                    StoreLocation storeLocation = new StoreLocation();
                

                    storeLocation.StoreId = (int)currentRow["StoreId"];
                    storeLocation.StoreName = currentRow["StoreName"].ToString();
                    storeLocation.StoreAddress = currentRow["StoreAddress"].ToString();

                    StoreLocation.Add(storeLocation);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            connection.Close();

            return StoreLocation;
        }
        
    }
}
