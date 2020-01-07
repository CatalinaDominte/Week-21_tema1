using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tables;
using DataAccess.Connection;

namespace DataAccess
{
    public class SuppliersRepository: IReaderRepo<Suppliers>
    {
        public List<Suppliers> Reader(string query)
        {
            var connection = ConnectionManager.GetConnection();
            connection.Open();
            List<Suppliers> Suppliers = new List<Suppliers>();
            try
            {

                SqlCommand command = new SqlCommand(query, connection);


                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    var currentRow = dataReader;

                    Suppliers supplier = new Suppliers();
                  
                    supplier.SuppliersId = (int)currentRow["SuppliersId"];
                    supplier.SuppliersName = currentRow["SuppliersName"].ToString();
                    supplier.SuppliersAddress = currentRow["SuppliersAddress"].ToString();
                    supplier.SuppliersContactInformations = currentRow["SuppliersContactInformations"].ToString();

                    Suppliers.Add(supplier);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            connection.Close();

            return Suppliers;
        
         }
       
    }
}
